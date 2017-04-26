using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Microsoft.SolverFoundation.Common;
using Microsoft.SolverFoundation.Solvers;
using Microsoft.SolverFoundation.Services;

namespace DEA
{
    public partial class Form1 : Form
    {
        Firm o_firm = new Firm();
        Firm b1_firm = new Firm();
        Firm b2_firm = new Firm();
        Figure input_figure = new Figure();
        Figure output_figure = new Figure();
        Text k_mean_text_form = new Text();

        string k_mean_text;

        public DEA_lib dea_lib = new DEA_lib();

        double[] x1;
        double[] x2;
        double[] y1;
        double[] sita1s;
        double[][] londas;
        double[] sita2s;
        double[] u1;
        double[] u2;
        double[] v1;

        public Form1()
        {
            InitializeComponent();

            b2_firm.f1 = this;

            input_figure.f1 = this;
            input_figure.Text = "投入";

            output_figure.f1 = this;
            output_figure.Text = "產出";
        }

        // 匯入檔案
        private void browse_data_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "data files (*.dcsv)|*.dcsv|All files (*.*)|*.*";
            ofd.ShowDialog();

            if (File.Exists(ofd.FileName))
            {
                browse_path.Text = ofd.FileName;
                browse_data_name.Text = ofd.SafeFileName;

                dea_lib.inport_data(browse_path.Text);

                x1 = dea_lib.Get_X1();
                x2 = dea_lib.Get_X2();
                y1 = dea_lib.Get_Y1();

                Reset_Combo_Items();

                MessageBox.Show("檔案匯入成功");
            }

            
        }

        #region 資料顯示

        // 資料顯示
        private void firm_display_button_ButtonClick(object sender, EventArgs e)
        {
            原始資料ToolStripMenuItem_Click(sender, e);
            基本DEAToolStripMenuItem_Click(sender, e);
            k平均ToolStripMenuItem_Click(sender, e);
        }

        private void 原始資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bindingList = new BindingList<DEA_lib.O_Data>(dea_lib.original_data);
            var source = new BindingSource(bindingList, null);
            o_firm.Text = "原始資料";
            o_firm.dgv.DataSource = source;
            o_firm.Show();
        }

        private void 基本DEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bindingList1 = new BindingList<DEA_lib.B_Data1>(dea_lib.basic_dea_data1);
            var source1 = new BindingSource(bindingList1, null);
            b1_firm.Text = "對偶式";
            b1_firm.dgv.DataSource = source1;
            b1_firm.Show();

            var bindingList2 = new BindingList<DEA_lib.B_Data2>(dea_lib.basic_dea_data2);
            var source2 = new BindingSource(bindingList2, null);
            b2_firm.Text = "一般式";
            b2_firm.dgv.DataSource = source2;
            b2_firm.Show();
        }

        private void 交叉效率ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void k平均ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k_mean_text_form.RichTextBox.Text = k_mean_text;
            k_mean_text_form.Show();
        }

        #endregion

        #region 圖形

        // 投入 圖形
        public void 投入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_figure.draw_points(dea_lib.original_data, (string)selected_titles[0], (string)selected_titles[1]);
            input_figure.Show();
        }

        // 產出 圖形
        private void 產出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output_figure.Show();
        }

        #endregion

        #region combobox - in & out

        // 0,1 為選擇投入
        // 2,3 為選擇產出
        object[] selected_titles = new object[4];

        private void in_com_1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selected_titles[0] = in_com_1.SelectedItem;
            Reset_Combo_Items();
            Remove_Combo_Items();
            Select_Combo_Items();
        }

        private void in_com_2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selected_titles[1] = in_com_2.SelectedItem;
            Reset_Combo_Items();
            Remove_Combo_Items();
            Select_Combo_Items();
        }

        private void out_com_1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selected_titles[2] = out_com_1.SelectedItem;
            Reset_Combo_Items();
            Remove_Combo_Items();
            Select_Combo_Items();
        }

        private void out_com_2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selected_titles[3] = out_com_2.SelectedItem;
            Reset_Combo_Items();
            Remove_Combo_Items();
            Select_Combo_Items();
        }

        // 重設 Item
        private void Reset_Combo_Items()
        {
            in_com_1.Items.Clear();
            in_com_2.Items.Clear();
            out_com_1.Items.Clear();
            out_com_2.Items.Clear();
            foreach (string in_out_item in dea_lib.titles)
            {
                in_com_1.Items.Add(in_out_item);
                in_com_2.Items.Add(in_out_item);
                out_com_1.Items.Add(in_out_item);
                out_com_2.Items.Add(in_out_item);
            }
        }

        // 移除 Item
        private void Remove_Combo_Items()
        {
            in_com_2.Items.Remove(selected_titles[0]);
            out_com_1.Items.Remove(selected_titles[0]);
            out_com_2.Items.Remove(selected_titles[0]);

            in_com_1.Items.Remove(selected_titles[1]);
            out_com_1.Items.Remove(selected_titles[1]);
            out_com_2.Items.Remove(selected_titles[1]);

            in_com_1.Items.Remove(selected_titles[2]);
            in_com_2.Items.Remove(selected_titles[2]);
            out_com_2.Items.Remove(selected_titles[2]);

            in_com_1.Items.Remove(selected_titles[3]);
            in_com_2.Items.Remove(selected_titles[3]);
            out_com_1.Items.Remove(selected_titles[3]);

        }

        // 選擇 Item
        private void Select_Combo_Items()
        {
            in_com_1.SelectedIndex = in_com_1.FindStringExact((string)selected_titles[0]);
            in_com_2.SelectedIndex = in_com_2.FindStringExact((string)selected_titles[1]);
            out_com_1.SelectedIndex = out_com_1.FindStringExact((string)selected_titles[2]);
            out_com_2.SelectedIndex = out_com_2.FindStringExact((string)selected_titles[3]);

        }

        #endregion

        // Basic DEA
        private void Basic_DEA_Label_Click(object sender, EventArgs e)
        {
            // Slove Basic DEA
            dea_lib.Solve_Basic_DEA();

            // 加入 SiTa1 值
//            sita1s = dea_lib.Get_SiTa1();

            // 加入 LonDa 值
//            londas = dea_lib.Get_Londas();

            // 加入 SiTa2 值
            sita2s = dea_lib.Get_SiTa2();

            // 加入 U1 值
            u1 = dea_lib.Get_U1();

            // 加入 U2 值
            u2 = dea_lib.Get_U2();

            // 加入 V1值
            v1 = dea_lib.Get_V1();

            // 寫入檔案
            StreamWriter sw = new StreamWriter("Basic-DEA.csv");
            string s = "";

            #region m1
            /*
            // model 1
            s += "SiTa,";

            for (int i = 0; i < dea_lib.data_count; i++)
            {
                s += "LonDa_" + i.ToString() + ",";
            }

            s = s.TrimEnd(',');
            s += "\r\n";

            for (int i = 0; i < dea_lib.data_count; i++)
            {
                s += sita1s[i].ToString() + ",";
                for (int j = 0; j < dea_lib.data_count; j++)
                {
                    s += londas[i][j].ToString() + ",";
                }
                s += "\r\n";
            }

            s += "\r\n";
            */
            #endregion

            // model 2
            s += "SiTa,u1,u2,v1\r\n";
            for (int i = 0; i < dea_lib.data_count; i++)
            {
                s += (v1[i] * y1[i]).ToString() + "," + u1[i].ToString() + "," + u2[i].ToString() + "," + v1[i].ToString() + "\r\n";
            }

            s += "\r\n";

            sw.Write(s);
            sw.Close();
         
            MessageBox.Show("Finish !!!");
        }
        
        // 交叉效率
        private void cross_efficiency_Label_Click(object sender, EventArgs e)
        {

            string text = "";
            text = dea_lib.Solve_Cross_Efficiency();

         
            // 寫入檔案
            StreamWriter sw = new StreamWriter("Cross Efficiency.csv");
            sw.Write(text);
            sw.Close();

            sw = new StreamWriter("cross_data.ccsv");
            sw.Write(text);
            sw.Close();

            MessageBox.Show("Finish !!!");

        }

        // Pearson 相關係數
        private void CF_label_Click(object sender, EventArgs e)
        {
            int number = dea_lib.data_count;
            if (numTextBox.Text != "")
            {
                number = Convert.ToInt16(numTextBox.Text);
            }
            string[][] cross_data = new string[number][];

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "data files (*.ccsv)|*.ccsv|All files (*.*)|*.*";
            ofd.ShowDialog();

            if (File.Exists(ofd.FileName))
            {
                browse_path.Text = ofd.FileName;
                browse_data_name.Text = ofd.SafeFileName;

                StreamReader sr = new StreamReader(browse_path.Text);
                
                for (int i = 0; i < number; i++)
                {
                    cross_data[i] = new string [number];
                }

                for (int i = 0; i < number; i++)
                {
                    cross_data[i] = sr.ReadLine().Split(',');
                }

                double[][] answer = new double[number][];
                for (int i = 0; i < number; i++)
                {
                    answer[i] = new double[number];
                }

                answer = dea_lib.pearson(cross_data,number);

                StreamWriter sw = new StreamWriter("pearson.csv");
                string s = "";
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        s += answer[i][j] + ",";
                    }
                    s += "\r\n";
                }

                sw.Write(s);
                sw.Close();
                MessageBox.Show("Finish !!!");
            }      
        }



        

        private void k_mean_button_Click(object sender, EventArgs e)
        {
            k_means k_m = new k_means();
            k_mean_text = "";
            int k_mean_count = (int)K_Mean_numericUpDown.Value;
            bool If_Random = false;
            if(K_Mean_checkBox.Checked)
            {
                If_Random = true;
            }
            k_mean_text = k_m.k_action(x1, x2, k_mean_count,If_Random);
            StreamWriter sw = new StreamWriter("k-mean.txt");
            sw.Write(k_mean_text);
            sw.Close();
            MessageBox.Show("Finish！！！");

            k_mean_text_form.RichTextBox.Text = k_mean_text;
            k_mean_text_form.Show();
        }

       


    }
}
