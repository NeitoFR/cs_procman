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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pname_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pval_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_dgv = new System.Windows.Forms.DataGridView();
            this.proc_name_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.log_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pname_list,
            this.pval_list});
            this.dgv.Location = new System.Drawing.Point(211, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(315, 500);
            this.dgv.TabIndex = 0;
            // 
            // pname_list
            // 
            this.pname_list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pname_list.HeaderText = "Properties";
            this.pname_list.Name = "pname_list";
            this.pname_list.ReadOnly = true;
            // 
            // pval_list
            // 
            this.pval_list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pval_list.HeaderText = "Values";
            this.pval_list.Name = "pval_list";
            this.pval_list.ReadOnly = true;
            // 
            // name_dgv
            // 
            this.name_dgv.AllowUserToAddRows = false;
            this.name_dgv.AllowUserToDeleteRows = false;
            this.name_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.name_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.name_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proc_name_list});
            this.name_dgv.Location = new System.Drawing.Point(12, 28);
            this.name_dgv.Name = "name_dgv";
            this.name_dgv.ReadOnly = true;
            this.name_dgv.RowHeadersVisible = false;
            this.name_dgv.RowTemplate.Height = 24;
            this.name_dgv.Size = new System.Drawing.Size(193, 500);
            this.name_dgv.TabIndex = 1;
            this.name_dgv.Click += new System.EventHandler(this.listDetails);
            // 
            // proc_name_list
            // 
            this.proc_name_list.HeaderText = "Process Name";
            this.proc_name_list.Name = "proc_name_list";
            this.proc_name_list.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(532, 28);
            this.log_textbox.Multiline = true;
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ReadOnly = true;
            this.log_textbox.Size = new System.Drawing.Size(556, 500);
            this.log_textbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 548);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_dgv);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn pval_list;
        private System.Windows.Forms.DataGridView name_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proc_name_list;
        private System.Windows.Forms.TextBox log_textbox;

    }
}

