namespace WindowsFormsPart
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
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.lblFavouriteTeam = new System.Windows.Forms.Label();
            this.btnAddFavouriteTeam = new System.Windows.Forms.Button();
            this.tlpFavouriteTeam = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFavouritePlayers = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddFavouritePlayers = new System.Windows.Forms.Button();
            this.lblFavouritePlayers = new System.Windows.Forms.Label();
            this.clbPlayers = new System.Windows.Forms.CheckedListBox();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.igraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNonFavouritePlayers = new System.Windows.Forms.Panel();
            this.pFavouritePlayers = new System.Windows.Forms.Panel();
            this.tlpPlayersPanels = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFavouriteTeam.SuspendLayout();
            this.tlpFavouritePlayers.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.tlpPlayersPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(14, 65);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(195, 28);
            this.cbTeams.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            this.lblFavouriteTeam.Location = new System.Drawing.Point(14, 13);
            this.lblFavouriteTeam.Name = "lblFavouriteTeam";
            this.lblFavouriteTeam.Size = new System.Drawing.Size(195, 31);
            this.lblFavouriteTeam.TabIndex = 1;
            this.lblFavouriteTeam.Text = "Omiljeni tim:";
            this.lblFavouriteTeam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAddFavouriteTeam
            // 
            this.btnAddFavouriteTeam.Location = new System.Drawing.Point(14, 113);
            this.btnAddFavouriteTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFavouriteTeam.Name = "btnAddFavouriteTeam";
            this.btnAddFavouriteTeam.Size = new System.Drawing.Size(195, 32);
            this.btnAddFavouriteTeam.TabIndex = 2;
            this.btnAddFavouriteTeam.Text = "DODAJ";
            this.btnAddFavouriteTeam.UseVisualStyleBackColor = true;
            this.btnAddFavouriteTeam.Click += new System.EventHandler(this.btnAddFavouriteTeam_Click);
            // 
            // tlpFavouriteTeam
            // 
            this.tlpFavouriteTeam.BackColor = System.Drawing.Color.White;
            this.tlpFavouriteTeam.ColumnCount = 1;
            this.tlpFavouriteTeam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.Controls.Add(this.cbTeams, 0, 1);
            this.tlpFavouriteTeam.Controls.Add(this.btnAddFavouriteTeam, 0, 2);
            this.tlpFavouriteTeam.Controls.Add(this.lblFavouriteTeam, 0, 0);
            this.tlpFavouriteTeam.Location = new System.Drawing.Point(345, 209);
            this.tlpFavouriteTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpFavouriteTeam.Name = "tlpFavouriteTeam";
            this.tlpFavouriteTeam.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.tlpFavouriteTeam.RowCount = 3;
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFavouriteTeam.Size = new System.Drawing.Size(225, 163);
            this.tlpFavouriteTeam.TabIndex = 3;
            // 
            // tlpFavouritePlayers
            // 
            this.tlpFavouritePlayers.BackColor = System.Drawing.Color.White;
            this.tlpFavouritePlayers.ColumnCount = 1;
            this.tlpFavouritePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouritePlayers.Controls.Add(this.btnAddFavouritePlayers, 0, 2);
            this.tlpFavouritePlayers.Controls.Add(this.lblFavouritePlayers, 0, 0);
            this.tlpFavouritePlayers.Controls.Add(this.clbPlayers, 0, 1);
            this.tlpFavouritePlayers.Location = new System.Drawing.Point(345, 128);
            this.tlpFavouritePlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpFavouritePlayers.Name = "tlpFavouritePlayers";
            this.tlpFavouritePlayers.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.tlpFavouritePlayers.RowCount = 3;
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.30434F));
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpFavouritePlayers.Size = new System.Drawing.Size(242, 355);
            this.tlpFavouritePlayers.TabIndex = 5;
            // 
            // btnAddFavouritePlayers
            // 
            this.btnAddFavouritePlayers.Location = new System.Drawing.Point(14, 274);
            this.btnAddFavouritePlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFavouritePlayers.Name = "btnAddFavouritePlayers";
            this.btnAddFavouritePlayers.Size = new System.Drawing.Size(213, 33);
            this.btnAddFavouritePlayers.TabIndex = 2;
            this.btnAddFavouritePlayers.Text = "DODAJ";
            this.btnAddFavouritePlayers.UseVisualStyleBackColor = true;
            this.btnAddFavouritePlayers.Click += new System.EventHandler(this.btnAddFavouritePlayers_Click);
            // 
            // lblFavouritePlayers
            // 
            this.lblFavouritePlayers.Location = new System.Drawing.Point(14, 13);
            this.lblFavouritePlayers.Name = "lblFavouritePlayers";
            this.lblFavouritePlayers.Size = new System.Drawing.Size(213, 21);
            this.lblFavouritePlayers.TabIndex = 1;
            this.lblFavouritePlayers.Text = "Omiljeni igraci:";
            this.lblFavouritePlayers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // clbPlayers
            // 
            this.clbPlayers.FormattingEnabled = true;
            this.clbPlayers.Location = new System.Drawing.Point(14, 39);
            this.clbPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbPlayers.Name = "clbPlayers";
            this.clbPlayers.Size = new System.Drawing.Size(212, 202);
            this.clbPlayers.TabIndex = 6;
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igraciToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(914, 28);
            this.msMainMenu.TabIndex = 6;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // igraciToolStripMenuItem
            // 
            this.igraciToolStripMenuItem.Name = "igraciToolStripMenuItem";
            this.igraciToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.igraciToolStripMenuItem.Text = "Igraci";
            // 
            // pNonFavouritePlayers
            // 
            this.pNonFavouritePlayers.BackColor = System.Drawing.Color.RosyBrown;
            this.pNonFavouritePlayers.Location = new System.Drawing.Point(3, 3);
            this.pNonFavouritePlayers.Name = "pNonFavouritePlayers";
            this.pNonFavouritePlayers.Size = new System.Drawing.Size(439, 551);
            this.pNonFavouritePlayers.TabIndex = 7;
            // 
            // pFavouritePlayers
            // 
            this.pFavouritePlayers.BackColor = System.Drawing.Color.RosyBrown;
            this.pFavouritePlayers.Location = new System.Drawing.Point(448, 3);
            this.pFavouritePlayers.Name = "pFavouritePlayers";
            this.pFavouritePlayers.Size = new System.Drawing.Size(439, 551);
            this.pFavouritePlayers.TabIndex = 8;
            // 
            // tlpPlayersPanels
            // 
            this.tlpPlayersPanels.ColumnCount = 2;
            this.tlpPlayersPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayersPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayersPanels.Controls.Add(this.pFavouritePlayers, 1, 0);
            this.tlpPlayersPanels.Controls.Add(this.pNonFavouritePlayers, 0, 0);
            this.tlpPlayersPanels.Location = new System.Drawing.Point(12, 31);
            this.tlpPlayersPanels.Name = "tlpPlayersPanels";
            this.tlpPlayersPanels.RowCount = 1;
            this.tlpPlayersPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayersPanels.Size = new System.Drawing.Size(890, 557);
            this.tlpPlayersPanels.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tlpPlayersPanels);
            this.Controls.Add(this.tlpFavouritePlayers);
            this.Controls.Add(this.tlpFavouriteTeam);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpFavouriteTeam.ResumeLayout(false);
            this.tlpFavouritePlayers.ResumeLayout(false);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tlpPlayersPanels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTeams;
        private Label lblFavouriteTeam;
        private Button btnAddFavouriteTeam;
        private TableLayoutPanel tlpFavouriteTeam;
        private TableLayoutPanel tlpFavouritePlayers;
        private Button btnAddFavouritePlayers;
        private Label lblFavouritePlayers;
        private CheckedListBox clbPlayers;
        private MenuStrip msMainMenu;
        private ToolStripMenuItem igraciToolStripMenuItem;
        private Panel pNonFavouritePlayers;
        private Panel pFavouritePlayers;
        private TableLayoutPanel tlpPlayersPanels;
    }
}