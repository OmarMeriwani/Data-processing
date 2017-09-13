namespace LogSearcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_mainword = new System.Windows.Forms.TextBox();
            this.btn_process = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtbox_logpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.txtbox_connectionstring = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_tablename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main word prefix";
            // 
            // txtbox_mainword
            // 
            this.txtbox_mainword.Location = new System.Drawing.Point(105, 37);
            this.txtbox_mainword.Name = "txtbox_mainword";
            this.txtbox_mainword.Size = new System.Drawing.Size(143, 20);
            this.txtbox_mainword.TabIndex = 1;
            this.txtbox_mainword.Text = "96475";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(254, 35);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(75, 23);
            this.btn_process.TabIndex = 2;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(254, 10);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // txtbox_logpath
            // 
            this.txtbox_logpath.Location = new System.Drawing.Point(105, 12);
            this.txtbox_logpath.Name = "txtbox_logpath";
            this.txtbox_logpath.Size = new System.Drawing.Size(143, 20);
            this.txtbox_logpath.TabIndex = 4;
            this.txtbox_logpath.Text = "\\\\Hqvappt01\\er_log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log location";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 111);
            this.textBox1.TabIndex = 6;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(254, 115);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "Export file";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // txtbox_connectionstring
            // 
            this.txtbox_connectionstring.Location = new System.Drawing.Point(105, 63);
            this.txtbox_connectionstring.Name = "txtbox_connectionstring";
            this.txtbox_connectionstring.Size = new System.Drawing.Size(143, 20);
            this.txtbox_connectionstring.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connection string";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Export to db";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbox_tablename
            // 
            this.txtbox_tablename.Location = new System.Drawing.Point(105, 89);
            this.txtbox_tablename.Name = "txtbox_tablename";
            this.txtbox_tablename.Size = new System.Drawing.Size(143, 20);
            this.txtbox_tablename.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 264);
            this.Controls.Add(this.txtbox_tablename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_connectionstring);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_logpath);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.txtbox_mainword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Log searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_mainword;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txtbox_logpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox txtbox_connectionstring;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_tablename;
    }
}

