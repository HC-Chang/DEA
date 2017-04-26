using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEA
{
    public partial class Figure : Form
    {
        public Form1 f1;

        Bitmap draw_area;
        const int draw_save_area = 30;

        public Figure()
        {
            InitializeComponent();
            picture_box_reset();
        }

        // 初始化 畫版座標系統
        public void picture_box_reset()
        {
            // 設定畫布大小
            draw_area = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Graphics g;
            g = Graphics.FromImage(draw_area);

            // 設定畫筆
            Pen mypen = new Pen(Color.Black);
            mypen.Width = 4;

            // 畫線 - 垂直
            g.DrawLine(mypen,
                draw_save_area,
                draw_save_area,
                draw_save_area,
                pictureBox1.Size.Height - draw_save_area);
            // 畫線 - 水平
            g.DrawLine(mypen,
                draw_save_area,
                pictureBox1.Size.Height - draw_save_area,
                pictureBox1.Size.Width - draw_save_area,
                pictureBox1.Size.Height - draw_save_area);

            pictureBox1.Image = draw_area;

            g.Dispose();
        }


        // 畫面大小改變時，重繪畫版
        private void Figure_SizeChanged(object sender, EventArgs e)
        {
            picture_box_reset();
            f1.投入ToolStripMenuItem_Click(sender, e);
        }

        // 關閉視窗時作隱藏
        private void Figure_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        // 自動取得 list 單項資料
        /***************************************************************/
        // 畫點
        public void draw_points(List<DEA_lib.O_Data> list_d,string x_index,string y_index)
        {
            int d_count = list_d.Count;
            double [] p_x = new double [d_count];
            double[] p_y = new double[d_count];


/**************************************/

            double range_x = (list_d.Max(M =>  M.X1)-list_d.Min(m => m.X1))/8*10;
            double min_x = list_d.Min(m => m.X1)-0.1*range_x;
            double range_y = (list_d.Max(M => M.X2) - list_d.Min(m => m.X2)) / 8 * 10;
            double min_y = list_d.Min(m => m.X2) - 0.1 * range_y;

            double draw_total_width = pictureBox1.Size.Width - 2*draw_save_area;
            double draw_total_height = pictureBox1.Size.Height - 2 * draw_save_area;

            // 設定畫布大小
            draw_area = (Bitmap)pictureBox1.Image;
            Graphics g;
            g = Graphics.FromImage(draw_area);

            // 設定畫筆
            SolidBrush myBrush = new SolidBrush(Color.Black);

            for (int i = 0; i < d_count; i++)
            {                
                g.FillRectangle(myBrush, (int)(draw_save_area + (list_d[i].X1-min_x)/range_x*draw_total_width),
                    (int)(pictureBox1.Size.Height - draw_save_area - (list_d[i].X2-min_y)/range_y*draw_total_height),
                    5, 5);
            }

            pictureBox1.Image = draw_area;
            g.Dispose();
        }
    }
}
