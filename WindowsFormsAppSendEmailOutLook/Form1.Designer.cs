namespace WindowsFormsAppSendEmailOutLook
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
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxMessange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.checkBoxSendAll = new System.Windows.Forms.CheckBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBoxCc = new System.Windows.Forms.ListBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxCc = new System.Windows.Forms.TextBox();
            this.textBoxFindFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(620, 553);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 74);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessange
            // 
            this.textBoxMessange.Location = new System.Drawing.Point(213, 265);
            this.textBoxMessange.Multiline = true;
            this.textBoxMessange.Name = "textBoxMessange";
            this.textBoxMessange.Size = new System.Drawing.Size(387, 200);
            this.textBoxMessange.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(213, 218);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(387, 26);
            this.textBoxSubject.TabIndex = 9;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // checkBoxSendAll
            // 
            this.checkBoxSendAll.AutoSize = true;
            this.checkBoxSendAll.Location = new System.Drawing.Point(728, 53);
            this.checkBoxSendAll.Name = "checkBoxSendAll";
            this.checkBoxSendAll.Size = new System.Drawing.Size(72, 24);
            this.checkBoxSendAll.TabIndex = 12;
            this.checkBoxSendAll.Text = "To all";
            this.checkBoxSendAll.UseVisualStyleBackColor = true;
            this.checkBoxSendAll.CheckedChanged += new System.EventHandler(this.checkBoxSendAll_CheckedChanged);
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 20;
            this.listBoxTo.Items.AddRange(new object[] {
            "thanhhungbkhn@gmail.com",
            "chinh18111993@gmail.com",
            "tieututranduc@gmail.com"});
            this.listBoxTo.Location = new System.Drawing.Point(213, 33);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(387, 44);
            this.listBoxTo.TabIndex = 13;
            this.listBoxTo.SelectedIndexChanged += new System.EventHandler(this.listBoxTo_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(728, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Cc all";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxCc
            // 
            this.listBoxCc.FormattingEnabled = true;
            this.listBoxCc.ItemHeight = 20;
            this.listBoxCc.Items.AddRange(new object[] {
            "thanhhungbkhn@gmail.com",
            "chinh19111993@gmail.com",
            "tieututranduc@gmail.com"});
            this.listBoxCc.Location = new System.Drawing.Point(213, 115);
            this.listBoxCc.Name = "listBoxCc";
            this.listBoxCc.Size = new System.Drawing.Size(387, 44);
            this.listBoxCc.TabIndex = 15;
            this.listBoxCc.SelectedIndexChanged += new System.EventHandler(this.listBoxCc_SelectedIndexChanged);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(213, 83);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(387, 26);
            this.textBoxTo.TabIndex = 16;
            // 
            // textBoxCc
            // 
            this.textBoxCc.Location = new System.Drawing.Point(213, 165);
            this.textBoxCc.Multiline = true;
            this.textBoxCc.Name = "textBoxCc";
            this.textBoxCc.Size = new System.Drawing.Size(387, 47);
            this.textBoxCc.TabIndex = 17;
            // 
            // textBoxFindFile
            // 
            this.textBoxFindFile.Location = new System.Drawing.Point(213, 497);
            this.textBoxFindFile.Name = "textBoxFindFile";
            this.textBoxFindFile.Size = new System.Drawing.Size(387, 26);
            this.textBoxFindFile.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dinh kem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFindFile);
            this.Controls.Add(this.textBoxCc);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.listBoxCc);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.checkBoxSendAll);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessange);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxMessange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.CheckBox checkBoxSendAll;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBoxCc;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxCc;
        private System.Windows.Forms.TextBox textBoxFindFile;
        private System.Windows.Forms.Button button1;
    }
}

