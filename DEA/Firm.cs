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
    public partial class Firm : Form
    {
        public Form1 f1;

        public Firm()
        {
            InitializeComponent();
        }

        // 關閉視窗時作隱藏
        private void Firm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


    }
}
