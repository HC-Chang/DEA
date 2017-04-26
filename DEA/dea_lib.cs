using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using Microsoft.SolverFoundation.Common;
using Microsoft.SolverFoundation.Solvers;
using Microsoft.SolverFoundation.Services;


namespace DEA
{
    public class DEA_lib
    {
        // 原始資料
        public class O_Data
        {
            public string index { get; set; }
            public double X1 { get; set; }
            public double X2 { get; set; }
            public double Y1 { get; set; }
        }

        // Basic DEA 資料
        public class B_Data1
        {
            public double B_Sita1 { get; set; }
            public double l_1 { get; set; }
            public double l_2 { get; set; }
            public double l_3 { get; set; }
            public double l_4 { get; set; }
            public double l_5 { get; set; }
            public double l_6 { get; set; }
            public double l_7 { get; set; }
            public double l_8 { get; set; }
            public double l_9 { get; set; }
            public double l_10 { get; set; }
            public double l_11 { get; set; }
            public double l_12 { get; set; }
            
        }

        public class B_Data2
        {
            public double B_Sita2 { get; set; }
            public double U1 { get; set; }
            public double U2 { get; set; }
            public double V1 { get; set; }
        }

        /***********************************************************************/
        // 交叉效率資料 (DGV 讀CSV)
        public class C_E_Data
        {
            public int index { get; set; }
            public double cross_eff { get; set; }
        }

        string dea_data_path = "";

        public string[] titles;

        public int data_count;

        public List<O_Data> original_data = new List<O_Data>();

        public List<B_Data1> basic_dea_data1 = new List<B_Data1>();

        public List<B_Data2> basic_dea_data2 = new List<B_Data2>();

        public List<C_E_Data> cross_efficiency = new List<C_E_Data>();

        // 匯入資料
        public void inport_data(string data_path)
        {
            dea_data_path = data_path;

            StreamReader sr = new StreamReader(dea_data_path);
            string [] temp;
            titles = sr.ReadLine().Split(',');
            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine().Split(',');
                original_data.Add(new O_Data
                {
                    index = temp[0],
                    X1 = Convert.ToDouble(temp[1]),
                    X2 = Convert.ToDouble(temp[2]),
                    Y1 = Convert.ToDouble(temp[3])
                });
            }
            data_count = original_data.Count;
        }

        // 取得原始資料
        #region Get Data Value

        // X1
        public double[] Get_X1()
        {
            double[] get_x1 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_x1[i] = original_data[i].X1;
            }

            return get_x1;
        }

        // X2
        public double[] Get_X2()
        {
            double[] get_x2 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_x2[i] = original_data[i].X2;
            }

            return get_x2;
        }

        // Y1
        public double[] Get_Y1()
        {
            double[] get_y1 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_y1[i] = original_data[i].Y1;
            }

            return get_y1;
        }

        // SiTa1
        public double[] Get_SiTa1()
        {
            double[] get_sita = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_sita[i] = basic_dea_data1[i].B_Sita1;
            }

            return get_sita;
        }

        // LonDa
        public double[][] Get_Londas()
        {
            double[][] get_londas = new double[basic_dea_data1.Count][];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_londas[i] = new double[data_count];
                get_londas[i][0] = basic_dea_data1[i].l_1;
                get_londas[i][1] = basic_dea_data1[i].l_2;
                get_londas[i][2] = basic_dea_data1[i].l_3;
                get_londas[i][3] = basic_dea_data1[i].l_4;
                get_londas[i][4] = basic_dea_data1[i].l_5;
                get_londas[i][5] = basic_dea_data1[i].l_6;
                get_londas[i][6] = basic_dea_data1[i].l_7;
                get_londas[i][7] = basic_dea_data1[i].l_8;
                get_londas[i][8] = basic_dea_data1[i].l_9;
                get_londas[i][9] = basic_dea_data1[i].l_10;
                get_londas[i][10] = basic_dea_data1[i].l_11;
                get_londas[i][11] = basic_dea_data1[i].l_12;
            }
            return get_londas;
        }

        // SiTa2
        public double[] Get_SiTa2()
        {
            double[] get_sita2 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_sita2[i] = basic_dea_data2[i].B_Sita2;
            }

            return get_sita2;
        }

        // U1
        public double[] Get_U1()
        {
            double[] get_u1 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_u1[i] = basic_dea_data2[i].U1;
            }

            return get_u1;
        }

        // U2
        public double[] Get_U2()
        {
            double[] get_u2 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_u2[i] = basic_dea_data2[i].U2;
            }

            return get_u2;
        }

        // V1
        public double[] Get_V1()
        {
            double[] get_v1 = new double[original_data.Count];
            for (int i = 0; i < original_data.Count; i++)
            {
                get_v1[i] = basic_dea_data2[i].V1;
            }

            return get_v1;
        }

        #endregion

        // Basic DEA 1,2
        public void Solve_Basic_DEA()
        {
            double[] m1_X1 = Get_X1();
            double[] m1_X2 = Get_X2();
            double[] m1_Y1 = Get_Y1();

           
            #region 對偶式
            /*
            // 建立模型
            var solver1 = SolverContext.GetContext();
            var model1 = solver1.CreateModel();

            // 加入決策變數
            var SiTa = new Decision(Domain.RealNonnegative, "SiTa");
            var LonDa_1 = new Decision(Domain.RealNonnegative, "LonDa_1");
            var LonDa_2 = new Decision(Domain.RealNonnegative, "LonDa_2");
            var LonDa_3 = new Decision(Domain.RealNonnegative, "LonDa_3");
            var LonDa_4 = new Decision(Domain.RealNonnegative, "LonDa_4");
            var LonDa_5 = new Decision(Domain.RealNonnegative, "LonDa_5");
            var LonDa_6 = new Decision(Domain.RealNonnegative, "LonDa_6");
            var LonDa_7 = new Decision(Domain.RealNonnegative, "LonDa_7");
            var LonDa_8 = new Decision(Domain.RealNonnegative, "LonDa_8");
            var LonDa_9 = new Decision(Domain.RealNonnegative, "LonDa_9");
            var LonDa_10 = new Decision(Domain.RealNonnegative, "LonDa_10");
            var LonDa_11 = new Decision(Domain.RealNonnegative, "LonDa_11");
            var LonDa_12 = new Decision(Domain.RealNonnegative, "LonDa_21");

            model1.AddDecisions(SiTa, LonDa_1, LonDa_2, LonDa_3, LonDa_4, LonDa_5, LonDa_6, LonDa_7, LonDa_8, LonDa_9, LonDa_10, LonDa_11, LonDa_12);

            // 設定 目標
            model1.AddGoal("Goal", GoalKind.Minimize, SiTa);

            #region 限制式

            // 加入限制式
            Microsoft.SolverFoundation.Services.Constraint c_londa;

            c_londa = model1.AddConstraints("LondaLimits", LonDa_1 >= 0,
                                                          LonDa_2 >= 0,
                                                          LonDa_3 >= 0,
                                                          LonDa_4 >= 0,
                                                          LonDa_5 >= 0,
                                                          LonDa_6 >= 0,
                                                          LonDa_7 >= 0,
                                                          LonDa_8 >= 0,
                                                          LonDa_9 >= 0,
                                                          LonDa_10 >= 0,
                                                          LonDa_11 >= 0,
                                                          LonDa_12 >= 0);


            Microsoft.SolverFoundation.Services.Constraint c11;
            Microsoft.SolverFoundation.Services.Constraint c12;
            Microsoft.SolverFoundation.Services.Constraint c13;

            for (int i = 0; i < data_count; i++)
            {
                c11 = model1.AddConstraint("Constraint1", m1_Y1[0] * LonDa_1 + m1_Y1[1] * LonDa_2 + m1_Y1[2] * LonDa_3 + m1_Y1[3] * LonDa_4 + m1_Y1[4] * LonDa_5 + m1_Y1[5] * LonDa_6 + m1_Y1[6] * LonDa_7 + m1_Y1[7] * LonDa_8 + m1_Y1[8] * LonDa_9 + m1_Y1[9] * LonDa_10 + m1_Y1[10] * LonDa_11 + m1_Y1[11] * LonDa_12 >= m1_Y1[i]);
                c12 = model1.AddConstraint("Constraint2", SiTa * m1_X1[i] >= m1_X1[0] * LonDa_1 + m1_X1[1] * LonDa_2 + m1_X1[2] * LonDa_3 + m1_X1[3] * LonDa_4 + m1_X1[4] * LonDa_5 + m1_X1[5] * LonDa_6 + m1_X1[6] * LonDa_7 + m1_X1[7] * LonDa_8 + m1_X1[8] * LonDa_9 + m1_X1[9] * LonDa_10 + m1_X1[10] * LonDa_11 + m1_X1[11] * LonDa_12);
                c13 = model1.AddConstraint("Constraint3", SiTa * m1_X2[i] >= m1_X2[0] * LonDa_1 + m1_X2[1] * LonDa_2 + m1_X2[2] * LonDa_3 + m1_X2[3] * LonDa_4 + m1_X2[4] * LonDa_5 + m1_X2[5] * LonDa_6 + m1_X2[6] * LonDa_7 + m1_X2[7] * LonDa_8 + m1_X2[8] * LonDa_9 + m1_X2[9] * LonDa_10 + m1_X2[10] * LonDa_11 + m1_X2[11] * LonDa_12);

                // 求解
                var solution = solver1.Solve();

                // 把 LonDa 加入 basic DEA data
                basic_dea_data1.Add(new DEA_lib.B_Data1
                {
                    B_Sita1 = SiTa.GetDouble(),
                    l_1 = LonDa_1.GetDouble(),
                    l_2 = LonDa_2.GetDouble(),
                    l_3 = LonDa_3.GetDouble(),
                    l_4 = LonDa_4.GetDouble(),
                    l_5 = LonDa_5.GetDouble(),
                    l_6 = LonDa_6.GetDouble(),
                    l_7 = LonDa_7.GetDouble(),
                    l_8 = LonDa_8.GetDouble(),
                    l_9 = LonDa_9.GetDouble(),
                    l_10 = LonDa_10.GetDouble(),
                    l_11 = LonDa_11.GetDouble(),
                    l_12 = LonDa_12.GetDouble()
                });

                // 移除 限制式
                model1.RemoveConstraint(c11);
                model1.RemoveConstraint(c12);
                model1.RemoveConstraint(c13);
            }

            #endregion

            // 清除模型
            solver1.ClearModel();
             
            */ 
            #endregion
            

            #region 一般式

            // 建立模型
            var solver2 = SolverContext.GetContext();
            var model2 = solver2.CreateModel();

            // 加入決策變數
            var u1 = new Decision(Domain.RealNonnegative, "u1");
            var u2 = new Decision(Domain.RealNonnegative, "u2");
            var v1 = new Decision(Domain.RealNonnegative, "v1");

            model2.AddDecisions(u1, u2, v1);

            // 設定 目標
            Microsoft.SolverFoundation.Services.Goal goal;
  
            // 加入限制式
            Microsoft.SolverFoundation.Services.Constraint cPrimal1;

            model2.AddConstraints("c2", u1 >= 0, u2 >= 0, v1 >= 0);

            for (int i = 0; i < data_count; i++)
            {
                model2.AddConstraint("c3" + (i).ToString(), u1 * m1_X1[i] + u2 * m1_X2[i] >= v1 * m1_Y1[i]);
            }

            for (int i = 0; i < data_count; i++)
            {
                goal = model2.AddGoal("Goal", GoalKind.Maximize, v1*m1_Y1[i]);

                cPrimal1 = model2.AddConstraint("c1", u1 * m1_X1[i] + u2 * m1_X2[i] == 1);

                var solution = solver2.Solve();

                basic_dea_data2.Add(new B_Data2 { U1 = u1.GetDouble(), U2 = u2.GetDouble(), V1 = v1.GetDouble(),B_Sita2 = v1.GetDouble()*m1_Y1[i] });

                model2.RemoveGoal(goal);
                model2.RemoveConstraint(cPrimal1);
            }
            // 清除模型
            solver2.ClearModel();

            #endregion

        }

        /***********************************************************************/
        public string Solve_Cross_Efficiency()
        {
            double[] X1 = Get_X1();
            double[] X2 = Get_X2();
            double[] Y1 = Get_Y1();
            double[] sitas = Get_SiTa2();
            double[] U1 = Get_U1();
            double[] U2 = Get_U2();
            double[] V1 = Get_V1();

            string s = "";

            #region Model Cross Efficiency
            /*

            // 建立模型
            var solver = SolverContext.GetContext();
            var model = solver.CreateModel();

            // 加入決策變數
            var u1 = new Decision(Domain.RealNonnegative, "u1");
            var u2 = new Decision(Domain.RealNonnegative, "u2");
            var v1 = new Decision(Domain.RealNonnegative, "v1");

            model.AddDecisions(u1, u2, v1);

            // 設定 目標
            Microsoft.SolverFoundation.Services.Goal goal;

            // 加入限制式
            Microsoft.SolverFoundation.Services.Constraint c1;
            Microsoft.SolverFoundation.Services.Constraint [] c2 = new Microsoft.SolverFoundation.Services.Constraint[data_count];
            Microsoft.SolverFoundation.Services.Constraint[] c3 = new Microsoft.SolverFoundation.Services.Constraint[data_count];

            model.AddConstraints("c4", u1 >= 0, u2 >= 0, v1 >= 0);

            

            

            for (int i = 0; i < data_count; i++)
            {
                c2[0] = model.AddConstraint("c2", sitas[i] * (u1 * X1[i] + u2 * X2[i]) == v1 * Y1[i]);

                for (int j = 0; j < data_count; j++)
                {
                    c3[j] = model.AddConstraint("c3" + (j).ToString(), u1 * X1[j] + u2 * X2[j] >= v1 * Y1[j]);

                    if (i == j)
                    {
                        model.RemoveConstraint(c3[j]);
                    }
                }


                for (int j = 0; j < data_count; j++)
                {
                    goal = model.AddGoal("Goal", GoalKind.Minimize, v1 * Y1[j]);
                    c1 = model.AddConstraint("c1", u1 * X1[j] + u2 * X2[j] == 1);

                    var solution = solver.Solve();

                    s += (v1.GetDouble() * Y1[j]).ToString() + ",";

                    model.RemoveGoal(goal);
                    model.RemoveConstraint(c1);
                }
                s = s.TrimEnd(',');
                s += "\r\n";

                model.RemoveConstraint(c2[0]);

                for (int j = 0; j < data_count; j++)
                {
                    model.RemoveConstraint(c3[j]);
                }

            }
 
            // 清除模型
            solver.ClearModel();

            MessageBox.Show(s);

            */
            #endregion

            for (int i = 0; i < data_count; i++)
            {
                for (int j = 0; j < data_count; j++)
                {
                    s += ((V1[i] * Y1[j]) / (U1[i] * X1[j] + U2[i] * X2[j])).ToString() + ",";
                }
                s += "\r\n";
            }

            return s;

            }
           

        // 相關係數
        public double[][] pearson(string[][] data,int repeat_time)
        {

            double[][]answer = new double[repeat_time][];
            for (int i = 0; i < repeat_time; i++)
            {
                answer[i] = new double[repeat_time];
            }

            double[] a_data = new double[repeat_time];
            double[] b_data = new double[repeat_time];

            for (int i = 0; i < repeat_time; i++)
            {
                for (int j = 0; j < repeat_time; j++)
                {
                    for (int k = 0; k < repeat_time; k++)
                    {
                        a_data[k] = Convert.ToDouble(data[i][k]);
                        b_data[k] = Convert.ToDouble(data[j][k]);                   
                    }
                    double mean_a = 0;
                    double mean_b = 0;

                    for (int a = 0; a < repeat_time; a++)
                    {
                        mean_a += a_data[a];
                        mean_b += b_data[a];
                    }
                    mean_a = mean_a / repeat_time;
                    mean_b = mean_b / repeat_time;

                    double[] A_meanA = new double[repeat_time];
                    double[] B_meanB = new double[repeat_time];

                    for (int a = 0; a < repeat_time; a++)
                    {
                        A_meanA[a] = a_data[a] - mean_a;
                        B_meanB[a] = b_data[a] - mean_b;
                    }

                    double sum_AxB = 0;
                    double sum_Apow = 0;
                    double sum_Bpow = 0;

                    for (int a = 0; a < repeat_time; a++)
                    {
                        sum_AxB += A_meanA[a] * B_meanB[a];
                        sum_Apow += A_meanA[a] * A_meanA[a];
                        sum_Bpow += B_meanB[a] * B_meanB[a];
                    }
                    answer[i][j] = sum_AxB / Math.Sqrt(sum_Apow * sum_Bpow);
                }
            }

            return answer;
        }


        /**********************************************************************/

        // 計算斜率
        public double ratio(double r_x, double r_y)
        {
            return (r_y / r_x);
        }

    }
}
