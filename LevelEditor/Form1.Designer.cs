namespace LevelEditor
{
    partial class LevelEditorMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTCHIOPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.eastereggMoneyCtrl = new System.Windows.Forms.Button();
            this.advaiCtrl = new System.Windows.Forms.Button();
            this.bot_verticalCtrl = new System.Windows.Forms.Button();
            this.bot_horizontalCtrl = new System.Windows.Forms.Button();
            this.waterCtrl = new System.Windows.Forms.Button();
            this.xpCtrl = new System.Windows.Forms.Button();
            this.goldCtrl = new System.Windows.Forms.Button();
            this.spointCtrl = new System.Windows.Forms.Button();
            this.wallCtrl = new System.Windows.Forms.Button();
            this.mapEditor = new System.Windows.Forms.FlowLayoutPanel();
            this.levelOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMapToolStripMenuItem,
            this.mapSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearMapToolStripMenuItem.Text = "Clear map";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // mapSettingsToolStripMenuItem
            // 
            this.mapSettingsToolStripMenuItem.Enabled = false;
            this.mapSettingsToolStripMenuItem.Name = "mapSettingsToolStripMenuItem";
            this.mapSettingsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.mapSettingsToolStripMenuItem.Text = "Map settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.iTCHIOPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // iTCHIOPageToolStripMenuItem
            // 
            this.iTCHIOPageToolStripMenuItem.Name = "iTCHIOPageToolStripMenuItem";
            this.iTCHIOPageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.iTCHIOPageToolStripMenuItem.Text = "ITCH.IO page";
            // 
            // controlsPanel
            // 
            this.controlsPanel.AutoScroll = true;
            this.controlsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlsPanel.Controls.Add(this.eastereggMoneyCtrl);
            this.controlsPanel.Controls.Add(this.advaiCtrl);
            this.controlsPanel.Controls.Add(this.bot_verticalCtrl);
            this.controlsPanel.Controls.Add(this.bot_horizontalCtrl);
            this.controlsPanel.Controls.Add(this.waterCtrl);
            this.controlsPanel.Controls.Add(this.xpCtrl);
            this.controlsPanel.Controls.Add(this.goldCtrl);
            this.controlsPanel.Controls.Add(this.spointCtrl);
            this.controlsPanel.Controls.Add(this.wallCtrl);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlsPanel.Enabled = false;
            this.controlsPanel.Location = new System.Drawing.Point(0, 24);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(102, 408);
            this.controlsPanel.TabIndex = 1;
            // 
            // eastereggMoneyCtrl
            // 
            this.eastereggMoneyCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.eastereggMoneyCtrl.Location = new System.Drawing.Point(0, 248);
            this.eastereggMoneyCtrl.Name = "eastereggMoneyCtrl";
            this.eastereggMoneyCtrl.Size = new System.Drawing.Size(100, 31);
            this.eastereggMoneyCtrl.TabIndex = 10;
            this.eastereggMoneyCtrl.Text = "EasterEgg_money";
            this.eastereggMoneyCtrl.UseVisualStyleBackColor = true;
            // 
            // advaiCtrl
            // 
            this.advaiCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.advaiCtrl.Location = new System.Drawing.Point(0, 217);
            this.advaiCtrl.Name = "advaiCtrl";
            this.advaiCtrl.Size = new System.Drawing.Size(100, 31);
            this.advaiCtrl.TabIndex = 9;
            this.advaiCtrl.Text = "bot_advanced";
            this.advaiCtrl.UseVisualStyleBackColor = true;
            // 
            // bot_verticalCtrl
            // 
            this.bot_verticalCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bot_verticalCtrl.Location = new System.Drawing.Point(0, 186);
            this.bot_verticalCtrl.Name = "bot_verticalCtrl";
            this.bot_verticalCtrl.Size = new System.Drawing.Size(100, 31);
            this.bot_verticalCtrl.TabIndex = 8;
            this.bot_verticalCtrl.Text = "bot_vertical";
            this.bot_verticalCtrl.UseVisualStyleBackColor = true;
            // 
            // bot_horizontalCtrl
            // 
            this.bot_horizontalCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bot_horizontalCtrl.Location = new System.Drawing.Point(0, 155);
            this.bot_horizontalCtrl.Name = "bot_horizontalCtrl";
            this.bot_horizontalCtrl.Size = new System.Drawing.Size(100, 31);
            this.bot_horizontalCtrl.TabIndex = 7;
            this.bot_horizontalCtrl.Text = "bot_horizontal";
            this.bot_horizontalCtrl.UseVisualStyleBackColor = true;
            // 
            // waterCtrl
            // 
            this.waterCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.waterCtrl.Location = new System.Drawing.Point(0, 124);
            this.waterCtrl.Name = "waterCtrl";
            this.waterCtrl.Size = new System.Drawing.Size(100, 31);
            this.waterCtrl.TabIndex = 6;
            this.waterCtrl.Text = "Water";
            this.waterCtrl.UseVisualStyleBackColor = true;
            // 
            // xpCtrl
            // 
            this.xpCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpCtrl.Location = new System.Drawing.Point(0, 93);
            this.xpCtrl.Name = "xpCtrl";
            this.xpCtrl.Size = new System.Drawing.Size(100, 31);
            this.xpCtrl.TabIndex = 5;
            this.xpCtrl.Text = "XP";
            this.xpCtrl.UseVisualStyleBackColor = true;
            // 
            // goldCtrl
            // 
            this.goldCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.goldCtrl.Location = new System.Drawing.Point(0, 62);
            this.goldCtrl.Name = "goldCtrl";
            this.goldCtrl.Size = new System.Drawing.Size(100, 31);
            this.goldCtrl.TabIndex = 4;
            this.goldCtrl.Text = "Money";
            this.goldCtrl.UseVisualStyleBackColor = true;
            // 
            // spointCtrl
            // 
            this.spointCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.spointCtrl.Location = new System.Drawing.Point(0, 31);
            this.spointCtrl.Name = "spointCtrl";
            this.spointCtrl.Size = new System.Drawing.Size(100, 31);
            this.spointCtrl.TabIndex = 3;
            this.spointCtrl.Text = "Spawn point";
            this.spointCtrl.UseVisualStyleBackColor = true;
            // 
            // wallCtrl
            // 
            this.wallCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wallCtrl.Location = new System.Drawing.Point(0, 0);
            this.wallCtrl.Name = "wallCtrl";
            this.wallCtrl.Size = new System.Drawing.Size(100, 31);
            this.wallCtrl.TabIndex = 2;
            this.wallCtrl.Text = "Wall";
            this.wallCtrl.UseVisualStyleBackColor = true;
            // 
            // mapEditor
            // 
            this.mapEditor.AutoScroll = true;
            this.mapEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapEditor.Location = new System.Drawing.Point(102, 24);
            this.mapEditor.Name = "mapEditor";
            this.mapEditor.Size = new System.Drawing.Size(604, 408);
            this.mapEditor.TabIndex = 2;
            // 
            // levelOpenDialog
            // 
            this.levelOpenDialog.Filter = "PascalEngine level files|*.lvl";
            this.levelOpenDialog.ShowReadOnly = true;
            this.levelOpenDialog.SupportMultiDottedExtensions = true;
            this.levelOpenDialog.Title = "Open exciting level...";
            // 
            // LevelEditorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(706, 432);
            this.Controls.Add(this.mapEditor);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelEditorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PascalEngine level editor";
            this.Load += new System.EventHandler(this.LevelEditorMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTCHIOPageToolStripMenuItem;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button advaiCtrl;
        private System.Windows.Forms.Button bot_verticalCtrl;
        private System.Windows.Forms.Button bot_horizontalCtrl;
        private System.Windows.Forms.Button waterCtrl;
        private System.Windows.Forms.Button xpCtrl;
        private System.Windows.Forms.Button goldCtrl;
        private System.Windows.Forms.Button spointCtrl;
        private System.Windows.Forms.Button wallCtrl;
        private System.Windows.Forms.Button eastereggMoneyCtrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel mapEditor;
        private System.Windows.Forms.OpenFileDialog levelOpenDialog;
    }
}

