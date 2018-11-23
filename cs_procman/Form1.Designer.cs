namespace cs_procman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.prop_dgv = new System.Windows.Forms.DataGridView();
            this.name_dgv = new System.Windows.Forms.DataGridView();
            this.log_textbox = new System.Windows.Forms.TextBox();
            this.ch_proc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.prop_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_proc)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prop_dgv
            // 
            this.prop_dgv.AllowUserToAddRows = false;
            this.prop_dgv.AllowUserToDeleteRows = false;
            this.prop_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prop_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prop_dgv.Location = new System.Drawing.Point(213, 5);
            this.prop_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prop_dgv.Name = "prop_dgv";
            this.prop_dgv.RowHeadersVisible = false;
            this.prop_dgv.RowTemplate.Height = 24;
            this.prop_dgv.Size = new System.Drawing.Size(265, 406);
            this.prop_dgv.TabIndex = 0;
            // 
            // name_dgv
            // 
            this.name_dgv.AllowUserToAddRows = false;
            this.name_dgv.AllowUserToDeleteRows = false;
            this.name_dgv.AllowUserToOrderColumns = true;
            this.name_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.name_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.name_dgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name_dgv.Location = new System.Drawing.Point(5, 5);
            this.name_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_dgv.MultiSelect = false;
            this.name_dgv.Name = "name_dgv";
            this.name_dgv.RowHeadersVisible = false;
            this.name_dgv.RowTemplate.Height = 24;
            this.name_dgv.Size = new System.Drawing.Size(202, 406);
            this.name_dgv.TabIndex = 1;
            this.name_dgv.Click += new System.EventHandler(this.listDetails);
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(482, 5);
            this.log_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ReadOnly = true;
            this.log_textbox.Size = new System.Drawing.Size(418, 406);
            this.log_textbox.TabIndex = 3;
            // 
            // ch_proc
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_proc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_proc.Legends.Add(legend2);
            this.ch_proc.Location = new System.Drawing.Point(3, 3);
            this.ch_proc.Name = "ch_proc";
            this.ch_proc.Size = new System.Drawing.Size(897, 409);
            this.ch_proc.TabIndex = 4;
            this.ch_proc.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 444);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ch_proc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.name_dgv);
            this.tabPage3.Controls.Add(this.log_textbox);
            this.tabPage3.Controls.Add(this.prop_dgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 418);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 449);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prop_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_proc)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prop_dgv;
        private System.Windows.Forms.DataGridView name_dgv;
        private System.Windows.Forms.TextBox log_textbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_proc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;

    }
}

