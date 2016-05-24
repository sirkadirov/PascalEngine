namespace PascalEngineLauncher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.officialWebsiteLink = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.levelList = new System.Windows.Forms.ListBox();
            this.updateLevelListBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openLevelEditorBtn = new System.Windows.Forms.Button();
            this.openLevelListEditorBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newLevelBtn = new System.Windows.Forms.Button();
            this.openLevelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PascalEngine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A simple game engine writed in Free Pascal";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 413);
            this.panel2.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.officialWebsiteLink);
            this.groupBox4.Controls.Add(this.updBtn);
            this.groupBox4.Controls.Add(this.aboutBtn);
            this.groupBox4.Controls.Add(this.docBtn);
            this.groupBox4.Location = new System.Drawing.Point(498, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 382);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Useful links";
            // 
            // officialWebsiteLink
            // 
            this.officialWebsiteLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officialWebsiteLink.Location = new System.Drawing.Point(11, 177);
            this.officialWebsiteLink.Name = "officialWebsiteLink";
            this.officialWebsiteLink.Size = new System.Drawing.Size(211, 46);
            this.officialWebsiteLink.TabIndex = 5;
            this.officialWebsiteLink.Text = "Official website";
            this.officialWebsiteLink.UseVisualStyleBackColor = true;
            this.officialWebsiteLink.Click += new System.EventHandler(this.button5_Click);
            // 
            // updBtn
            // 
            this.updBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updBtn.Location = new System.Drawing.Point(11, 125);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(211, 46);
            this.updBtn.TabIndex = 4;
            this.updBtn.Text = "Check for updates";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBtn.Location = new System.Drawing.Point(11, 21);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(211, 46);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // docBtn
            // 
            this.docBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docBtn.Location = new System.Drawing.Point(11, 73);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(211, 46);
            this.docBtn.TabIndex = 3;
            this.docBtn.Text = "Documentation";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kadirov Yurij\'s project. Licensed under GNU GPL v3.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.levelList);
            this.groupBox3.Controls.Add(this.updateLevelListBtn);
            this.groupBox3.Location = new System.Drawing.Point(256, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 382);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All levels";
            // 
            // levelList
            // 
            this.levelList.FormattingEnabled = true;
            this.levelList.Items.AddRange(new object[] {
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl",
            "level1.lvl"});
            this.levelList.Location = new System.Drawing.Point(11, 56);
            this.levelList.Name = "levelList";
            this.levelList.Size = new System.Drawing.Size(211, 251);
            this.levelList.TabIndex = 3;
            // 
            // updateLevelListBtn
            // 
            this.updateLevelListBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateLevelListBtn.Location = new System.Drawing.Point(11, 21);
            this.updateLevelListBtn.Name = "updateLevelListBtn";
            this.updateLevelListBtn.Size = new System.Drawing.Size(211, 29);
            this.updateLevelListBtn.TabIndex = 2;
            this.updateLevelListBtn.Text = "Refresh";
            this.updateLevelListBtn.UseVisualStyleBackColor = true;
            this.updateLevelListBtn.Click += new System.EventHandler(this.updateLevelListBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.openLevelEditorBtn);
            this.groupBox2.Controls.Add(this.openLevelListEditorBtn);
            this.groupBox2.Location = new System.Drawing.Point(14, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 246);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(11, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pre-launcher config";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openLevelEditorBtn
            // 
            this.openLevelEditorBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openLevelEditorBtn.Location = new System.Drawing.Point(11, 21);
            this.openLevelEditorBtn.Name = "openLevelEditorBtn";
            this.openLevelEditorBtn.Size = new System.Drawing.Size(211, 46);
            this.openLevelEditorBtn.TabIndex = 2;
            this.openLevelEditorBtn.Text = "Level editor";
            this.openLevelEditorBtn.UseVisualStyleBackColor = true;
            // 
            // openLevelListEditorBtn
            // 
            this.openLevelListEditorBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openLevelListEditorBtn.Location = new System.Drawing.Point(11, 73);
            this.openLevelListEditorBtn.Name = "openLevelListEditorBtn";
            this.openLevelListEditorBtn.Size = new System.Drawing.Size(211, 46);
            this.openLevelListEditorBtn.TabIndex = 3;
            this.openLevelListEditorBtn.Text = "Level list editor";
            this.openLevelListEditorBtn.UseVisualStyleBackColor = true;
            this.openLevelListEditorBtn.Click += new System.EventHandler(this.openLevelListEditorBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newLevelBtn);
            this.groupBox1.Controls.Add(this.openLevelBtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level editor";
            // 
            // newLevelBtn
            // 
            this.newLevelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLevelBtn.Location = new System.Drawing.Point(11, 21);
            this.newLevelBtn.Name = "newLevelBtn";
            this.newLevelBtn.Size = new System.Drawing.Size(211, 46);
            this.newLevelBtn.TabIndex = 2;
            this.newLevelBtn.Text = "New level";
            this.newLevelBtn.UseVisualStyleBackColor = true;
            // 
            // openLevelBtn
            // 
            this.openLevelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openLevelBtn.Location = new System.Drawing.Point(11, 73);
            this.openLevelBtn.Name = "openLevelBtn";
            this.openLevelBtn.Size = new System.Drawing.Size(211, 46);
            this.openLevelBtn.TabIndex = 3;
            this.openLevelBtn.Text = "Open level";
            this.openLevelBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PascalEngine Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button officialWebsiteLink;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox levelList;
        private System.Windows.Forms.Button updateLevelListBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openLevelEditorBtn;
        private System.Windows.Forms.Button openLevelListEditorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newLevelBtn;
        private System.Windows.Forms.Button openLevelBtn;
    }
}

