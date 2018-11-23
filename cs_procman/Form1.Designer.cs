namespace cs_procman
{+
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
            this.prop_dgv = new System.Windows.Forms.DataGridView();
            this.name_dgv = new System.Windows.Forms.DataGridView();
            this.log_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prop_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // prop_dgv
            // 
            this.prop_dgv.AllowUserToAddRows = false;
            this.prop_dgv.AllowUserToDeleteRows = false;
            this.prop_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prop_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prop_dgv.Location = new System.Drawing.Point(288, 12);
            this.prop_dgv.Name = "prop_dgv";
            this.prop_dgv.ReadOnly = true;
            this.prop_dgv.RowHeadersVisible = false;
            this.prop_dgv.RowTemplate.Height = 24;
            this.prop_dgv.Size = new System.Drawing.Size(353, 500);
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
            this.name_dgv.Location = new System.Drawing.Point(12, 12);
            this.name_dgv.MultiSelect = false;
            this.name_dgv.Name = "name_dgv";
            this.name_dgv.RowHeadersVisible = false;
            this.name_dgv.RowTemplate.Height = 24;
            this.name_dgv.Size = new System.Drawing.Size(270, 500);
            this.name_dgv.TabIndex = 1;
            this.name_dgv.Click += new System.EventHandler(this.listDetails);
            // 
            // log_textbox
            // 
            this.log_textbox.Location = new System.Drawing.Point(647, 12);
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
            this.ClientSize = new System.Drawing.Size(1215, 548);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.name_dgv);
            this.Controls.Add(this.prop_dgv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prop_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prop_dgv;
        private System.Windows.Forms.DataGridView name_dgv;
        private System.Windows.Forms.TextBox log_textbox;

    }
}

