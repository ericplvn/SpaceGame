namespace SpaceGame
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pausedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.shieldsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.energyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.scoreStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.levelMap = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelMap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausedToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.shieldsProgressBar,
            this.toolStripStatusLabel2,
            this.energyProgressBar,
            this.toolStripStatusLabel3,
            this.scoreStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pausedToolStripStatusLabel
            // 
            this.pausedToolStripStatusLabel.AutoSize = false;
            this.pausedToolStripStatusLabel.Name = "pausedToolStripStatusLabel";
            this.pausedToolStripStatusLabel.Size = new System.Drawing.Size(60, 19);
            this.pausedToolStripStatusLabel.Text = "Paused";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 19);
            this.toolStripStatusLabel1.Text = "Shields:";
            // 
            // shieldsProgressBar
            // 
            this.shieldsProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 20, 3);
            this.shieldsProgressBar.Name = "shieldsProgressBar";
            this.shieldsProgressBar.Size = new System.Drawing.Size(100, 18);
            this.shieldsProgressBar.Value = 100;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 19);
            this.toolStripStatusLabel2.Text = "Energy:";
            // 
            // energyProgressBar
            // 
            this.energyProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.energyProgressBar.ForeColor = System.Drawing.Color.Yellow;
            this.energyProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 20, 3);
            this.energyProgressBar.Name = "energyProgressBar";
            this.energyProgressBar.Size = new System.Drawing.Size(100, 18);
            this.energyProgressBar.Value = 100;
            // 
            // scoreStatusLabel
            // 
            this.scoreStatusLabel.AutoSize = false;
            this.scoreStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.scoreStatusLabel.Name = "scoreStatusLabel";
            this.scoreStatusLabel.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.levelMap);
            this.splitContainer1.Size = new System.Drawing.Size(784, 489);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 3;
            // 
            // levelMap
            // 
            this.levelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelMap.Location = new System.Drawing.Point(0, 0);
            this.levelMap.Name = "levelMap";
            this.levelMap.Size = new System.Drawing.Size(682, 489);
            this.levelMap.TabIndex = 0;
            this.levelMap.TabStop = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 19);
            this.toolStripStatusLabel3.Text = "Score:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "The Ship Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar shieldsProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar energyProgressBar;
        private System.Windows.Forms.PictureBox levelMap;
        private System.Windows.Forms.ToolStripStatusLabel pausedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel scoreStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

