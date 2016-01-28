namespace Pong
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackgrowndPanel = new System.Windows.Forms.Panel();
            this.MaincontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemBall = new System.Windows.Forms.PictureBox();
            this.ItemRacket = new System.Windows.Forms.PictureBox();
            this.StatusTrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ScoreStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgrowndPanel.SuspendLayout();
            this.MaincontextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemRacket)).BeginInit();
            this.StatusTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgrowndPanel
            // 
            this.BackgrowndPanel.AllowDrop = true;
            this.BackgrowndPanel.ContextMenuStrip = this.MaincontextMenu;
            this.BackgrowndPanel.Controls.Add(this.lblGameOver);
            this.BackgrowndPanel.Controls.Add(this.label1);
            this.BackgrowndPanel.Controls.Add(this.ItemBall);
            this.BackgrowndPanel.Controls.Add(this.ItemRacket);
            this.BackgrowndPanel.Controls.Add(this.StatusTrip);
            this.BackgrowndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgrowndPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgrowndPanel.Name = "BackgrowndPanel";
            this.BackgrowndPanel.Size = new System.Drawing.Size(754, 501);
            this.BackgrowndPanel.TabIndex = 0;
            // 
            // MaincontextMenu
            // 
            this.MaincontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MaincontextMenu.Name = "MaincontextMenu";
            this.MaincontextMenu.Size = new System.Drawing.Size(153, 120);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Right click to menu";
            // 
            // ItemBall
            // 
            this.ItemBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemBall.Location = new System.Drawing.Point(351, 246);
            this.ItemBall.Name = "ItemBall";
            this.ItemBall.Size = new System.Drawing.Size(13, 13);
            this.ItemBall.TabIndex = 2;
            this.ItemBall.TabStop = false;
            // 
            // ItemRacket
            // 
            this.ItemRacket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemRacket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemRacket.Location = new System.Drawing.Point(269, 450);
            this.ItemRacket.Name = "ItemRacket";
            this.ItemRacket.Size = new System.Drawing.Size(144, 16);
            this.ItemRacket.TabIndex = 1;
            this.ItemRacket.TabStop = false;
            // 
            // StatusTrip
            // 
            this.StatusTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ScoreStrip});
            this.StatusTrip.Location = new System.Drawing.Point(0, 479);
            this.StatusTrip.Name = "StatusTrip";
            this.StatusTrip.Size = new System.Drawing.Size(754, 22);
            this.StatusTrip.SizingGrip = false;
            this.StatusTrip.TabIndex = 0;
            this.StatusTrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Score:";
            // 
            // ScoreStrip
            // 
            this.ScoreStrip.Name = "ScoreStrip";
            this.ScoreStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 30;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(220, 106);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(285, 224);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Game Over\r\n\r\nEsc to exit\r\n\r\nEnter to retry\r\nor rightclick to menu\r\n\r\nScore:\r\n";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 501);
            this.Controls.Add(this.BackgrowndPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping-Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.BackgrowndPanel.ResumeLayout(false);
            this.BackgrowndPanel.PerformLayout();
            this.MaincontextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemRacket)).EndInit();
            this.StatusTrip.ResumeLayout(false);
            this.StatusTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgrowndPanel;
        private System.Windows.Forms.StatusStrip StatusTrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ScoreStrip;
        private System.Windows.Forms.ContextMenuStrip MaincontextMenu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox ItemBall;
        private System.Windows.Forms.PictureBox ItemRacket;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
    }
}

