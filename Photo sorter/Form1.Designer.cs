namespace Photo_sorter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_choose_directory = new System.Windows.Forms.Button();
            this.txtb_Directory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_sort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_choose_directory);
            this.groupBox1.Controls.Add(this.txtb_Directory);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose directory";
            // 
            // btn_choose_directory
            // 
            this.btn_choose_directory.Location = new System.Drawing.Point(7, 32);
            this.btn_choose_directory.Name = "btn_choose_directory";
            this.btn_choose_directory.Size = new System.Drawing.Size(94, 23);
            this.btn_choose_directory.TabIndex = 1;
            this.btn_choose_directory.Text = "Choose directory";
            this.btn_choose_directory.UseVisualStyleBackColor = true;
            this.btn_choose_directory.Click += new System.EventHandler(this.btn_choose_directory_Click);
            // 
            // txtb_Directory
            // 
            this.txtb_Directory.Location = new System.Drawing.Point(107, 33);
            this.txtb_Directory.Name = "txtb_Directory";
            this.txtb_Directory.ReadOnly = true;
            this.txtb_Directory.Size = new System.Drawing.Size(257, 20);
            this.txtb_Directory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_date);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose date";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(14, 36);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 4;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(151, 170);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(112, 47);
            this.btn_sort.TabIndex = 3;
            this.btn_sort.Text = "Do magic!";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 226);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_choose_directory;
        private System.Windows.Forms.TextBox txtb_Directory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}

