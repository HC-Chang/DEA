using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DEA
{
    class k_means
    {
        // K平均法
        // loopCount        循環次數
        // recursiveFlag    是否循環
        int loopCount = 1;
        int recursiveFlag = 0;
        double [] each_class_count;
        double[][] each_distance;

        

        public string k_action(double[]x1,double[]x2,int classNumber,bool if_random)
        {
            string s = "";

            // nodes   分群樣本
            // classes 分群數
            double[,] nodes;
            double[,] classes;

            // 分群樣本數
            int nodeNumber = x1.Length;
            
            // 實體化 樣本 & 分群數
            nodes = new double[nodeNumber, 3];         // x1,x2,所屬群集
            classes = new double[nodeNumber, 2]; 
            each_class_count = new double [classNumber];
            each_distance = new double[nodeNumber][];
        
            for (int i = 0; i < nodeNumber; i++)
            {
                each_distance[i] = new double[classNumber];
            }

            

            for (int i = 0; i < nodeNumber; i++)
            {
                nodes[i, 0] = (int)x1[i];
                nodes[i, 1] = (int)x2[i];
                s += string.Format((i + 1).ToString() + "---({0},{1})", nodes[i, 0], nodes[i, 1]) + "\r\n";
            }
            s += "\r\n";

            // 不重複node
            int [] random_nodes = non_repeat(nodeNumber,classNumber);

            // 是否隨機分配
            if (!if_random)
            {
                for (int i = 0; i < random_nodes.Length; i++)
                {
                    random_nodes[i] = i;
                }
            }

            // 隨機選取資料點，將之分別視為群聚的中心
            for (int i = 0; i < classNumber; i++)
            {
                // 不重複
                int r = random_nodes[i];

                classes[i, 0] = nodes[r, 0];
                classes[i, 1] = nodes[r, 1];
                Thread.Sleep(20);

                s += string.Format("群集 {0} --- {1}\t({2},{3})", i + 1, (r + 1).ToString().PadRight(3, ' ') + ",  " + (char)(65 + r), classes[i, 0], classes[i, 1]) + "\r\n";
            }
            s += "========================================\r\n";
            s += kMean(nodeNumber, classNumber, nodes, classes);
            s += "========================================\r\n\r\n分群結果:\r\n\r\n";
            s += showResult(nodes, nodeNumber, classes, classNumber);
            s += showClassfy(nodes, nodeNumber, classNumber);

            return s;
        }



        // K平均
        string kMean(int nodeNumber, int classNumber, double[,] nodes, double[,] classes)
        {
            string ss = "";
            
            // 計算距離並重新計算所屬群集
            for (int i = 0; i < nodeNumber; i++)
            {
                double min = double.MaxValue;
                for (int j = 0; j < classNumber; j++)
                {
                    double mindDistance = distance(nodes[i, 0], nodes[i, 1], classes[j, 0], classes[j, 1]);
                    each_distance[i][j] = mindDistance;
                    if (mindDistance < min)
                    {
                        min = mindDistance;
                        nodes[i, 2] = j;
                    }
                }
            }

            ss += string.Format("迭代次數 : {0}\r\n", loopCount);
            ss += showResult(nodes, nodeNumber, classes, classNumber);

            // 計算新的集群中心
            double[,] tempClasses = new double[nodeNumber, 3];
            for (int j = 0; j < classNumber; j++)
            {
                double[] tempCoordinate = new double[2];
                for (int i = 0; i < nodeNumber; i++)
                {
                    if (nodes[i, 2] == j)
                    {
                        // new class
                        tempCoordinate[0] += nodes[i, 0];
                        tempCoordinate[1] += nodes[i, 1];
                        tempClasses[j, 2]++;
                    }
                }
                if (tempClasses[j, 2] == 0)
                    tempClasses[j, 2] = 1;
                tempClasses[j, 0] = tempCoordinate[0] / tempClasses[j, 2];
                tempClasses[j, 1] = tempCoordinate[1] / tempClasses[j, 2];
                each_class_count[j] = tempClasses[j, 2];
                ss += string.Format("群集 {0} ---> 新中心   ({1},{2})\t個數:   {3} 個", j + 1, tempClasses[j, 0].ToString("f3"), tempClasses[j, 1].ToString("f3"), tempClasses[j, 2]) + "\r\n";
            }
            ss += "\r\n";



            int k = 0;
            for (k = 0; k < classNumber; k++)
            {
                if ((tempClasses[k, 0] != classes[k, 0]) || (tempClasses[k, 1] != classes[k, 1]))
                {
                    recursiveFlag = 1;
                    break;
                }
            }
            if (k >= classNumber)
                recursiveFlag = 0;
            if (recursiveFlag == 1)
            {
                for (int j = 0; j < classNumber; j++)
                {
                    classes[j, 0] = tempClasses[j, 0];
                    classes[j, 1] = tempClasses[j, 1];
                }

                // 迭代
                loopCount++;
                ss += "========================================\r\n";
                ss += kMean(nodeNumber, classNumber, nodes, classes);
            }

            return ss;
        }

        // 距離公式
        double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }

        // 顯示目前執行結果
        string showResult(double[,] nodes, int nodeNumber, double[,] classes, int classNumber)
        {
            string ss = "";
            
            // 群集中心
            for (int i = 0; i < classNumber; i++)
            {
                ss += string.Format("群集{0} ---> 中心   ({1},{2})", i + 1, classes[i, 0].ToString("#0.0000"), classes[i, 1].ToString("#0.0000")) + "\r\n";
            }
            ss += "\r\n";

            // 各點分群狀態
            for (int i = 0; i < nodeNumber; i++)
            {
                ss += string.Format((i+1).ToString()+"\t{0}\t({1},{2})\t-->\t群集 {3}",(char)(65+i) ,nodes[i, 0], nodes[i, 1], nodes[i, 2]+1) + "\r\n";
            }
            ss += "\r\n";

            // 各點與各群集之距離
            ss += string.Format("距離：\t\t{0}\t{1}\t{2}\r\n","A","B","C");
            for (int i = 0; i<nodeNumber;i++ )
            {
                string s_distance = "";

                for(int j = 0;j<classNumber;j++)
                {
                    s_distance += each_distance[i][j].ToString("f3")+"\t";
                }

                ss += string.Format((i + 1).ToString() + "\t{0}\t" + s_distance + "\r\n", (char)(65 + i));
            }
            ss += "\r\n";

            return ss;
        }

        // 顯示分群資料
        string showClassfy(double[,] nodes, int nodeNumber,int classNumber)
        {
            string ss = "";
            for (int i = 0; i < classNumber; i++)
            {
                ss += string.Format("群集 {0}\t--->\t個數:   {1}:\r\n", i + 1,each_class_count[i]);

                for (int j = 0; j < nodeNumber; j++)
                {
                    if (nodes[j, 2] == i)
                    {
                        ss += string.Format((j + 1).ToString() + "\t{0}\t({1},{2})", (char)(65 + j), nodes[j, 0], nodes[j, 1]) + "\r\n";
                    }
                }

                ss += "\r\n\r\n";
            }

            return ss;
        }
        
        // 不重複陣列
        int [] non_repeat(int a,int number)
        {
	        // a        陣列出現的最大值
            // number   陣列大小
	        int[] i_array = new int[number];
            Random rand = new Random();

	        for (int i=0; i<number; i++)
	        { 
		        do
		        { 
			        i_array[i] = rand.Next(0,a); 
			        for (int j=0; j<i; j++)
			        { 
				        if (i_array[i]==i_array[j]) 
				        { 
					        i_array[i]=0; 
					        break; 
				        } 
			        } 
		        }
		        while(i_array[i]==0);
	        } 

	        return i_array;
        }


    }
}
