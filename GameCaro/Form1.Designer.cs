namespace GameCaro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBroad = new Panel();
            panel2 = new Panel();
            ptcbAvatar = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            btnLAN = new Button();
            ptcbMark = new PictureBox();
            txbIP = new TextBox();
            prcbCoolDown = new ProgressBar();
            txbPlayerName = new TextBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptcbAvatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptcbMark).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBroad
            // 
            pnlChessBroad.Location = new Point(1, 30);
            pnlChessBroad.Name = "pnlChessBroad";
            pnlChessBroad.Size = new Size(700, 700);
            pnlChessBroad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(ptcbAvatar);
            panel2.Location = new Point(720, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 312);
            panel2.TabIndex = 1;
            // 
            // ptcbAvatar
            // 
            ptcbAvatar.Image = Properties.Resources.caro;
            ptcbAvatar.Location = new Point(0, 3);
            ptcbAvatar.Name = "ptcbAvatar";
            ptcbAvatar.Size = new Size(337, 309);
            ptcbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptcbAvatar.TabIndex = 0;
            ptcbAvatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnLAN);
            panel3.Controls.Add(ptcbMark);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbPlayerName);
            panel3.Location = new Point(720, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 269);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 179);
            label1.Name = "label1";
            label1.Size = new Size(325, 51);
            label1.TabIndex = 5;
            label1.Text = "5 in a line to win";
            // 
            // btnLAN
            // 
            btnLAN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLAN.Location = new Point(4, 105);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(174, 27);
            btnLAN.TabIndex = 4;
            btnLAN.Text = "LAN";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // ptcbMark
            // 
            ptcbMark.BackColor = SystemColors.HighlightText;
            ptcbMark.BorderStyle = BorderStyle.Fixed3D;
            ptcbMark.Location = new Point(184, 5);
            ptcbMark.Name = "ptcbMark";
            ptcbMark.Size = new Size(150, 127);
            ptcbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            ptcbMark.TabIndex = 3;
            ptcbMark.TabStop = false;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(4, 72);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(174, 27);
            txbIP.TabIndex = 2;
            txbIP.Text = "127.0.0.1";
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(4, 39);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(174, 27);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(4, 6);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(174, 27);
            txbPlayerName.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1062, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(218, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(218, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitToolStripMenuItem.Size = new Size(218, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 732);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBroad);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Game Caro";
            FormClosing += Form1_FormClosing;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptcbAvatar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptcbMark).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBroad;
        private Panel panel2;
        private PictureBox ptcbAvatar;
        private Panel panel3;
        private TextBox txbIP;
        private ProgressBar prcbCoolDown;
        private TextBox txbPlayerName;
        private PictureBox ptcbMark;
        private Label label1;
        private Button btnLAN;
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
