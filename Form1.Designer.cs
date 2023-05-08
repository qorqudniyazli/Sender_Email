namespace Send_Email
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtFileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Email";
            // 
            // TxtTo
            // 
            this.TxtTo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtTo.Location = new System.Drawing.Point(37, 107);
            this.TxtTo.Margin = new System.Windows.Forms.Padding(0);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.PlaceholderText = "To";
            this.TxtTo.Size = new System.Drawing.Size(307, 34);
            this.TxtTo.TabIndex = 1;
            // 
            // TxtSubject
            // 
            this.TxtSubject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtSubject.Location = new System.Drawing.Point(37, 177);
            this.TxtSubject.Margin = new System.Windows.Forms.Padding(0);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.PlaceholderText = "Subject";
            this.TxtSubject.Size = new System.Drawing.Size(307, 34);
            this.TxtSubject.TabIndex = 2;
            // 
            // TxtBody
            // 
            this.TxtBody.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtBody.Location = new System.Drawing.Point(37, 245);
            this.TxtBody.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.PlaceholderText = "Body";
            this.TxtBody.Size = new System.Drawing.Size(575, 192);
            this.TxtBody.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(660, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ədliyyə Nazirliyi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Send_Email.Properties.Resources.mojLogo;
            this.pictureBox1.Location = new System.Drawing.Point(694, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TxtFileName
            // 
            this.TxtFileName.AutoSize = true;
            this.TxtFileName.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFileName.ForeColor = System.Drawing.Color.White;
            this.TxtFileName.Location = new System.Drawing.Point(407, 188);
            this.TxtFileName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(0, 23);
            this.TxtFileName.TabIndex = 7;
            this.TxtFileName.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.BtnSend.Location = new System.Drawing.Point(660, 387);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(122, 50);
            this.BtnSend.TabIndex = 8;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBody);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtTo;
        private TextBox TxtSubject;
        private TextBox TxtBody;
        private Label label2;
        private PictureBox pictureBox1;
        private Label TxtFileName;
        private OpenFileDialog openFileDialog;
        private Button BtnSend;
    }
}