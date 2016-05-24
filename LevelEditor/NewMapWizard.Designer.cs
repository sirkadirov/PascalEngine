namespace LevelEditor
{
    partial class NewMapWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMapWizard));
            this.wizard = new CristiPotlog.Controls.Wizard();
            this.prefsPage = new CristiPotlog.Controls.WizardPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.audioMixer_SDL2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.browseMapSaveDirBtn = new System.Windows.Forms.Button();
            this.mapSaveDir = new System.Windows.Forms.TextBox();
            this.mapName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mapWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mapHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wizardPage1 = new CristiPotlog.Controls.WizardPage();
            this.welcomePage = new CristiPotlog.Controls.WizardPage();
            this.wizard.SuspendLayout();
            this.prefsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.prefsPage);
            this.wizard.Controls.Add(this.welcomePage);
            this.wizard.Controls.Add(this.wizardPage1);
            this.wizard.HeaderImage = global::LevelEditor.Properties.Resources.Blaise_Pascal;
            this.wizard.Location = new System.Drawing.Point(0, 0);
            this.wizard.Name = "wizard";
            this.wizard.Pages.AddRange(new CristiPotlog.Controls.WizardPage[] {
            this.welcomePage,
            this.prefsPage,
            this.wizardPage1});
            this.wizard.Size = new System.Drawing.Size(529, 389);
            this.wizard.TabIndex = 0;
            this.wizard.WelcomeImage = global::LevelEditor.Properties.Resources.min;
            this.wizard.Cancel += new System.ComponentModel.CancelEventHandler(this.wizard_Cancel);
            // 
            // prefsPage
            // 
            this.prefsPage.Controls.Add(this.pictureBox1);
            this.prefsPage.Controls.Add(this.label8);
            this.prefsPage.Controls.Add(this.label7);
            this.prefsPage.Controls.Add(this.audioMixer_SDL2);
            this.prefsPage.Controls.Add(this.label6);
            this.prefsPage.Controls.Add(this.browseMapSaveDirBtn);
            this.prefsPage.Controls.Add(this.mapSaveDir);
            this.prefsPage.Controls.Add(this.mapName);
            this.prefsPage.Controls.Add(this.label5);
            this.prefsPage.Controls.Add(this.label4);
            this.prefsPage.Controls.Add(this.mapWidth);
            this.prefsPage.Controls.Add(this.label3);
            this.prefsPage.Controls.Add(this.mapHeight);
            this.prefsPage.Controls.Add(this.label2);
            this.prefsPage.Controls.Add(this.label1);
            this.prefsPage.Description = "On this page, you can change default preferences of the new map";
            this.prefsPage.Location = new System.Drawing.Point(0, 0);
            this.prefsPage.Name = "prefsPage";
            this.prefsPage.Size = new System.Drawing.Size(529, 341);
            this.prefsPage.TabIndex = 11;
            this.prefsPage.Title = "Map preferences";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LevelEditor.Properties.Resources._1463080243_Warning;
            this.pictureBox1.Location = new System.Drawing.Point(15, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(50, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Please, check all configuration listed on this wizard page. You can\'t change\r\nthi" +
    "s settings later!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Audio mixer:";
            // 
            // audioMixer_SDL2
            // 
            this.audioMixer_SDL2.AutoSize = true;
            this.audioMixer_SDL2.Checked = true;
            this.audioMixer_SDL2.Location = new System.Drawing.Point(143, 171);
            this.audioMixer_SDL2.Name = "audioMixer_SDL2";
            this.audioMixer_SDL2.Size = new System.Drawing.Size(91, 17);
            this.audioMixer_SDL2.TabIndex = 11;
            this.audioMixer_SDL2.TabStop = true;
            this.audioMixer_SDL2.Text = "SDL_mixer2.0";
            this.audioMixer_SDL2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Engine directory:";
            // 
            // browseMapSaveDirBtn
            // 
            this.browseMapSaveDirBtn.Enabled = false;
            this.browseMapSaveDirBtn.Location = new System.Drawing.Point(442, 145);
            this.browseMapSaveDirBtn.Name = "browseMapSaveDirBtn";
            this.browseMapSaveDirBtn.Size = new System.Drawing.Size(75, 20);
            this.browseMapSaveDirBtn.TabIndex = 9;
            this.browseMapSaveDirBtn.Text = "Browse...";
            this.browseMapSaveDirBtn.UseVisualStyleBackColor = true;
            // 
            // mapSaveDir
            // 
            this.mapSaveDir.Location = new System.Drawing.Point(143, 145);
            this.mapSaveDir.Name = "mapSaveDir";
            this.mapSaveDir.ReadOnly = true;
            this.mapSaveDir.Size = new System.Drawing.Size(293, 20);
            this.mapSaveDir.TabIndex = 8;
            this.mapSaveDir.Text = "C:\\Program Files (x86)\\SirkadirovLLC\\PascalEngine\\bin-win32";
            // 
            // mapName
            // 
            this.mapName.Location = new System.Drawing.Point(143, 72);
            this.mapName.MaxLength = 15;
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(348, 20);
            this.mapName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(489, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = ".lvl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(140, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "W";
            // 
            // mapWidth
            // 
            this.mapWidth.Enabled = false;
            this.mapWidth.Location = new System.Drawing.Point(160, 119);
            this.mapWidth.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.mapWidth.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.mapWidth.Name = "mapWidth";
            this.mapWidth.Size = new System.Drawing.Size(357, 20);
            this.mapWidth.TabIndex = 5;
            this.mapWidth.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "H";
            // 
            // mapHeight
            // 
            this.mapHeight.Location = new System.Drawing.Point(160, 98);
            this.mapHeight.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.mapHeight.Name = "mapHeight";
            this.mapHeight.Size = new System.Drawing.Size(357, 20);
            this.mapHeight.TabIndex = 3;
            this.mapHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map name:";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Description = "Please, confirm your choose! If you ready to start creating the level, click on O" +
    "K button, but if you not ready to do this click on \"Cancel\" button.";
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(529, 341);
            this.wizardPage1.Style = CristiPotlog.Controls.WizardPageStyle.Finish;
            this.wizardPage1.TabIndex = 12;
            this.wizardPage1.Title = "Confirmation";
            // 
            // welcomePage
            // 
            this.welcomePage.Description = resources.GetString("welcomePage.Description");
            this.welcomePage.Location = new System.Drawing.Point(0, 0);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Size = new System.Drawing.Size(529, 341);
            this.welcomePage.Style = CristiPotlog.Controls.WizardPageStyle.Welcome;
            this.welcomePage.TabIndex = 10;
            this.welcomePage.Title = "Map creation wizard";
            // 
            // NewMapWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 389);
            this.Controls.Add(this.wizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMapWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New map wizard";
            this.wizard.ResumeLayout(false);
            this.prefsPage.ResumeLayout(false);
            this.prefsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CristiPotlog.Controls.Wizard wizard;
        private CristiPotlog.Controls.WizardPage welcomePage;
        private CristiPotlog.Controls.WizardPage prefsPage;
        private System.Windows.Forms.TextBox mapName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mapWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mapHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseMapSaveDirBtn;
        private System.Windows.Forms.TextBox mapSaveDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton audioMixer_SDL2;
        private CristiPotlog.Controls.WizardPage wizardPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}