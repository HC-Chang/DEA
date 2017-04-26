namespace DEA
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browse_path = new System.Windows.Forms.TextBox();
            this.browse_data = new System.Windows.Forms.Button();
            this.browse_data_name = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.firm_display_button = new System.Windows.Forms.ToolStripSplitButton();
            this.原始資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本DEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交叉效率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.k平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.figure_display_button = new System.Windows.Forms.ToolStripDropDownButton();
            this.投入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.產出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Basic_DEA_Label = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cross_efficiency_Label = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.numTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.CF_label = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.input_group = new System.Windows.Forms.GroupBox();
            this.in_com_2 = new System.Windows.Forms.ComboBox();
            this.in_com_1 = new System.Windows.Forms.ComboBox();
            this.output_group = new System.Windows.Forms.GroupBox();
            this.out_com_2 = new System.Windows.Forms.ComboBox();
            this.out_com_1 = new System.Windows.Forms.ComboBox();
            this.k_mean_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.K_Mean_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.K_Mean_checkBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.input_group.SuspendLayout();
            this.output_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K_Mean_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // browse_path
            // 
            this.browse_path.Location = new System.Drawing.Point(12, 37);
            this.browse_path.Name = "browse_path";
            this.browse_path.Size = new System.Drawing.Size(312, 22);
            this.browse_path.TabIndex = 0;
            // 
            // browse_data
            // 
            this.browse_data.Location = new System.Drawing.Point(330, 37);
            this.browse_data.Name = "browse_data";
            this.browse_data.Size = new System.Drawing.Size(75, 23);
            this.browse_data.TabIndex = 1;
            this.browse_data.Text = "匯入檔案";
            this.browse_data.UseVisualStyleBackColor = true;
            this.browse_data.Click += new System.EventHandler(this.browse_data_Click);
            // 
            // browse_data_name
            // 
            this.browse_data_name.AutoSize = true;
            this.browse_data_name.Location = new System.Drawing.Point(12, 66);
            this.browse_data_name.Name = "browse_data_name";
            this.browse_data_name.Size = new System.Drawing.Size(29, 12);
            this.browse_data_name.TabIndex = 2;
            this.browse_data_name.Text = "檔名";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firm_display_button,
            this.toolStripSeparator1,
            this.figure_display_button,
            this.toolStripSeparator3,
            this.Basic_DEA_Label,
            this.toolStripSeparator2,
            this.cross_efficiency_Label,
            this.toolStripSeparator4,
            this.numTextBox,
            this.CF_label,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(417, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // firm_display_button
            // 
            this.firm_display_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firm_display_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原始資料ToolStripMenuItem,
            this.基本DEAToolStripMenuItem,
            this.交叉效率ToolStripMenuItem,
            this.k平均ToolStripMenuItem});
            this.firm_display_button.Image = ((System.Drawing.Image)(resources.GetObject("firm_display_button.Image")));
            this.firm_display_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firm_display_button.Name = "firm_display_button";
            this.firm_display_button.Size = new System.Drawing.Size(72, 22);
            this.firm_display_button.Text = "資料顯示";
            this.firm_display_button.ButtonClick += new System.EventHandler(this.firm_display_button_ButtonClick);
            // 
            // 原始資料ToolStripMenuItem
            // 
            this.原始資料ToolStripMenuItem.Name = "原始資料ToolStripMenuItem";
            this.原始資料ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.原始資料ToolStripMenuItem.Text = "原始資料";
            this.原始資料ToolStripMenuItem.Click += new System.EventHandler(this.原始資料ToolStripMenuItem_Click);
            // 
            // 基本DEAToolStripMenuItem
            // 
            this.基本DEAToolStripMenuItem.Name = "基本DEAToolStripMenuItem";
            this.基本DEAToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.基本DEAToolStripMenuItem.Text = "基本DEA";
            this.基本DEAToolStripMenuItem.Click += new System.EventHandler(this.基本DEAToolStripMenuItem_Click);
            // 
            // 交叉效率ToolStripMenuItem
            // 
            this.交叉效率ToolStripMenuItem.Name = "交叉效率ToolStripMenuItem";
            this.交叉效率ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.交叉效率ToolStripMenuItem.Text = "交叉效率";
            this.交叉效率ToolStripMenuItem.Click += new System.EventHandler(this.交叉效率ToolStripMenuItem_Click);
            // 
            // k平均ToolStripMenuItem
            // 
            this.k平均ToolStripMenuItem.Name = "k平均ToolStripMenuItem";
            this.k平均ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.k平均ToolStripMenuItem.Text = "K平均";
            this.k平均ToolStripMenuItem.Click += new System.EventHandler(this.k平均ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // figure_display_button
            // 
            this.figure_display_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.figure_display_button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投入ToolStripMenuItem,
            this.產出ToolStripMenuItem});
            this.figure_display_button.Image = ((System.Drawing.Image)(resources.GetObject("figure_display_button.Image")));
            this.figure_display_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.figure_display_button.Name = "figure_display_button";
            this.figure_display_button.Size = new System.Drawing.Size(45, 22);
            this.figure_display_button.Text = "圖形";
            // 
            // 投入ToolStripMenuItem
            // 
            this.投入ToolStripMenuItem.Name = "投入ToolStripMenuItem";
            this.投入ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.投入ToolStripMenuItem.Text = "投入";
            this.投入ToolStripMenuItem.Click += new System.EventHandler(this.投入ToolStripMenuItem_Click);
            // 
            // 產出ToolStripMenuItem
            // 
            this.產出ToolStripMenuItem.Name = "產出ToolStripMenuItem";
            this.產出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.產出ToolStripMenuItem.Text = "產出";
            this.產出ToolStripMenuItem.Click += new System.EventHandler(this.產出ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Basic_DEA_Label
            // 
            this.Basic_DEA_Label.Name = "Basic_DEA_Label";
            this.Basic_DEA_Label.Size = new System.Drawing.Size(63, 22);
            this.Basic_DEA_Label.Text = "Basic DEA";
            this.Basic_DEA_Label.Click += new System.EventHandler(this.Basic_DEA_Label_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cross_efficiency_Label
            // 
            this.cross_efficiency_Label.Name = "cross_efficiency_Label";
            this.cross_efficiency_Label.Size = new System.Drawing.Size(56, 22);
            this.cross_efficiency_Label.Text = "交叉效率";
            this.cross_efficiency_Label.Click += new System.EventHandler(this.cross_efficiency_Label_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // numTextBox
            // 
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // CF_label
            // 
            this.CF_label.Name = "CF_label";
            this.CF_label.Size = new System.Drawing.Size(56, 16);
            this.CF_label.Text = "相關係數";
            this.CF_label.Click += new System.EventHandler(this.CF_label_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // input_group
            // 
            this.input_group.Controls.Add(this.in_com_2);
            this.input_group.Controls.Add(this.in_com_1);
            this.input_group.Location = new System.Drawing.Point(12, 80);
            this.input_group.Margin = new System.Windows.Forms.Padding(2);
            this.input_group.Name = "input_group";
            this.input_group.Padding = new System.Windows.Forms.Padding(2);
            this.input_group.Size = new System.Drawing.Size(105, 67);
            this.input_group.TabIndex = 5;
            this.input_group.TabStop = false;
            this.input_group.Text = "投入";
            // 
            // in_com_2
            // 
            this.in_com_2.FormattingEnabled = true;
            this.in_com_2.Location = new System.Drawing.Point(4, 41);
            this.in_com_2.Margin = new System.Windows.Forms.Padding(2);
            this.in_com_2.Name = "in_com_2";
            this.in_com_2.Size = new System.Drawing.Size(98, 20);
            this.in_com_2.TabIndex = 1;
            this.in_com_2.SelectionChangeCommitted += new System.EventHandler(this.in_com_2_SelectionChangeCommitted);
            // 
            // in_com_1
            // 
            this.in_com_1.FormattingEnabled = true;
            this.in_com_1.Location = new System.Drawing.Point(5, 19);
            this.in_com_1.Margin = new System.Windows.Forms.Padding(2);
            this.in_com_1.Name = "in_com_1";
            this.in_com_1.Size = new System.Drawing.Size(98, 20);
            this.in_com_1.TabIndex = 0;
            this.in_com_1.SelectionChangeCommitted += new System.EventHandler(this.in_com_1_SelectionChangeCommitted);
            // 
            // output_group
            // 
            this.output_group.Controls.Add(this.out_com_2);
            this.output_group.Controls.Add(this.out_com_1);
            this.output_group.Location = new System.Drawing.Point(12, 151);
            this.output_group.Margin = new System.Windows.Forms.Padding(2);
            this.output_group.Name = "output_group";
            this.output_group.Padding = new System.Windows.Forms.Padding(2);
            this.output_group.Size = new System.Drawing.Size(105, 67);
            this.output_group.TabIndex = 6;
            this.output_group.TabStop = false;
            this.output_group.Text = "產出";
            // 
            // out_com_2
            // 
            this.out_com_2.FormattingEnabled = true;
            this.out_com_2.Location = new System.Drawing.Point(4, 41);
            this.out_com_2.Margin = new System.Windows.Forms.Padding(2);
            this.out_com_2.Name = "out_com_2";
            this.out_com_2.Size = new System.Drawing.Size(98, 20);
            this.out_com_2.TabIndex = 1;
            this.out_com_2.SelectionChangeCommitted += new System.EventHandler(this.out_com_2_SelectionChangeCommitted);
            // 
            // out_com_1
            // 
            this.out_com_1.FormattingEnabled = true;
            this.out_com_1.Location = new System.Drawing.Point(5, 19);
            this.out_com_1.Margin = new System.Windows.Forms.Padding(2);
            this.out_com_1.Name = "out_com_1";
            this.out_com_1.Size = new System.Drawing.Size(98, 20);
            this.out_com_1.TabIndex = 0;
            this.out_com_1.SelectionChangeCommitted += new System.EventHandler(this.out_com_1_SelectionChangeCommitted);
            // 
            // k_mean_button
            // 
            this.k_mean_button.Location = new System.Drawing.Point(119, 117);
            this.k_mean_button.Name = "k_mean_button";
            this.k_mean_button.Size = new System.Drawing.Size(75, 23);
            this.k_mean_button.TabIndex = 7;
            this.k_mean_button.Text = "K 平均分群";
            this.k_mean_button.UseVisualStyleBackColor = true;
            this.k_mean_button.Click += new System.EventHandler(this.k_mean_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.K_Mean_checkBox);
            this.groupBox1.Controls.Add(this.K_Mean_numericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.k_mean_button);
            this.groupBox1.Location = new System.Drawing.Point(124, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "K平均分群";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "分群數";
            // 
            // K_Mean_numericUpDown
            // 
            this.K_Mean_numericUpDown.Location = new System.Drawing.Point(74, 19);
            this.K_Mean_numericUpDown.Name = "K_Mean_numericUpDown";
            this.K_Mean_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.K_Mean_numericUpDown.TabIndex = 9;
            this.K_Mean_numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // K_Mean_checkBox
            // 
            this.K_Mean_checkBox.AutoSize = true;
            this.K_Mean_checkBox.Location = new System.Drawing.Point(6, 55);
            this.K_Mean_checkBox.Name = "K_Mean_checkBox";
            this.K_Mean_checkBox.Size = new System.Drawing.Size(72, 16);
            this.K_Mean_checkBox.TabIndex = 10;
            this.K_Mean_checkBox.Text = "隨機分群";
            this.K_Mean_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output_group);
            this.Controls.Add(this.input_group);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.browse_data_name);
            this.Controls.Add(this.browse_data);
            this.Controls.Add(this.browse_path);
            this.Name = "Form1";
            this.Text = "DEA Caculator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.input_group.ResumeLayout(false);
            this.output_group.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K_Mean_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox browse_path;
        private System.Windows.Forms.Button browse_data;
        private System.Windows.Forms.Label browse_data_name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton figure_display_button;
        private System.Windows.Forms.ToolStripMenuItem 投入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 產出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox input_group;
        private System.Windows.Forms.ComboBox in_com_2;
        private System.Windows.Forms.ComboBox in_com_1;
        private System.Windows.Forms.GroupBox output_group;
        private System.Windows.Forms.ComboBox out_com_2;
        private System.Windows.Forms.ComboBox out_com_1;
        private System.Windows.Forms.ToolStripLabel Basic_DEA_Label;
        private System.Windows.Forms.ToolStripLabel cross_efficiency_Label;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel CF_label;
        private System.Windows.Forms.ToolStripTextBox numTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton firm_display_button;
        private System.Windows.Forms.ToolStripMenuItem 原始資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本DEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交叉效率ToolStripMenuItem;
        private System.Windows.Forms.Button k_mean_button;
        private System.Windows.Forms.ToolStripMenuItem k平均ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox K_Mean_checkBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown K_Mean_numericUpDown;
    }
}

