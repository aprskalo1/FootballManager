namespace WindowsFormsPart
{
    partial class FootbalManagerForm
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
            cbTeams = new ComboBox();
            lblFavouriteTeam = new Label();
            btnAddFavouriteTeam = new Button();
            tlpFavouriteTeam = new TableLayoutPanel();
            tlpFavouritePlayers = new TableLayoutPanel();
            btnAddFavouritePlayers = new Button();
            lblFavouritePlayers = new Label();
            clbPlayers = new CheckedListBox();
            msMainMenu = new MenuStrip();
            igraciToolStripMenuItem = new ToolStripMenuItem();
            rangListeToolStripMenuItem = new ToolStripMenuItem();
            pNonFavouritePlayers = new Panel();
            lbAllPlayers = new ListBox();
            pFavouritePlayers = new Panel();
            lbFavouritePlayers = new ListBox();
            tlpPlayersPanels = new TableLayoutPanel();
            lblOtherPlayers = new Label();
            lblFavPlayers = new Label();
            btnPlayerDetails = new Button();
            tlpRankLists = new TableLayoutPanel();
            panel1 = new Panel();
            lbVisitorRankList = new ListBox();
            panel2 = new Panel();
            lbPlayerRankList = new ListBox();
            lblRankPlayers = new Label();
            lblRangVisitors = new Label();
            tlpFavouriteTeam.SuspendLayout();
            tlpFavouritePlayers.SuspendLayout();
            msMainMenu.SuspendLayout();
            pNonFavouritePlayers.SuspendLayout();
            pFavouritePlayers.SuspendLayout();
            tlpPlayersPanels.SuspendLayout();
            tlpRankLists.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(14, 65);
            cbTeams.Margin = new Padding(3, 4, 3, 4);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(195, 28);
            cbTeams.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            lblFavouriteTeam.Location = new Point(14, 13);
            lblFavouriteTeam.Name = "lblFavouriteTeam";
            lblFavouriteTeam.Size = new Size(195, 31);
            lblFavouriteTeam.TabIndex = 1;
            lblFavouriteTeam.Text = "Omiljeni tim:";
            lblFavouriteTeam.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAddFavouriteTeam
            // 
            btnAddFavouriteTeam.Location = new Point(14, 113);
            btnAddFavouriteTeam.Margin = new Padding(3, 4, 3, 4);
            btnAddFavouriteTeam.Name = "btnAddFavouriteTeam";
            btnAddFavouriteTeam.Size = new Size(195, 32);
            btnAddFavouriteTeam.TabIndex = 2;
            btnAddFavouriteTeam.Text = "DODAJ";
            btnAddFavouriteTeam.UseVisualStyleBackColor = true;
            btnAddFavouriteTeam.Click += btnAddFavouriteTeam_Click;
            // 
            // tlpFavouriteTeam
            // 
            tlpFavouriteTeam.BackColor = Color.White;
            tlpFavouriteTeam.ColumnCount = 1;
            tlpFavouriteTeam.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFavouriteTeam.Controls.Add(cbTeams, 0, 1);
            tlpFavouriteTeam.Controls.Add(btnAddFavouriteTeam, 0, 2);
            tlpFavouriteTeam.Controls.Add(lblFavouriteTeam, 0, 0);
            tlpFavouriteTeam.Location = new Point(345, 209);
            tlpFavouriteTeam.Margin = new Padding(3, 4, 3, 4);
            tlpFavouriteTeam.Name = "tlpFavouriteTeam";
            tlpFavouriteTeam.Padding = new Padding(11, 13, 11, 13);
            tlpFavouriteTeam.RowCount = 3;
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFavouriteTeam.Size = new Size(225, 163);
            tlpFavouriteTeam.TabIndex = 3;
            // 
            // tlpFavouritePlayers
            // 
            tlpFavouritePlayers.BackColor = Color.White;
            tlpFavouritePlayers.ColumnCount = 1;
            tlpFavouritePlayers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFavouritePlayers.Controls.Add(btnAddFavouritePlayers, 0, 2);
            tlpFavouritePlayers.Controls.Add(lblFavouritePlayers, 0, 0);
            tlpFavouritePlayers.Controls.Add(clbPlayers, 0, 1);
            tlpFavouritePlayers.Location = new Point(345, 128);
            tlpFavouritePlayers.Margin = new Padding(3, 4, 3, 4);
            tlpFavouritePlayers.Name = "tlpFavouritePlayers";
            tlpFavouritePlayers.Padding = new Padding(11, 13, 11, 13);
            tlpFavouritePlayers.RowCount = 3;
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 91.30434F));
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tlpFavouritePlayers.Size = new Size(242, 355);
            tlpFavouritePlayers.TabIndex = 5;
            // 
            // btnAddFavouritePlayers
            // 
            btnAddFavouritePlayers.Location = new Point(14, 274);
            btnAddFavouritePlayers.Margin = new Padding(3, 4, 3, 4);
            btnAddFavouritePlayers.Name = "btnAddFavouritePlayers";
            btnAddFavouritePlayers.Size = new Size(213, 33);
            btnAddFavouritePlayers.TabIndex = 2;
            btnAddFavouritePlayers.Text = "DODAJ";
            btnAddFavouritePlayers.UseVisualStyleBackColor = true;
            btnAddFavouritePlayers.Click += btnAddFavouritePlayers_Click;
            // 
            // lblFavouritePlayers
            // 
            lblFavouritePlayers.Location = new Point(14, 13);
            lblFavouritePlayers.Name = "lblFavouritePlayers";
            lblFavouritePlayers.Size = new Size(213, 21);
            lblFavouritePlayers.TabIndex = 1;
            lblFavouritePlayers.Text = "Omiljeni igraci:";
            lblFavouritePlayers.TextAlign = ContentAlignment.BottomLeft;
            // 
            // clbPlayers
            // 
            clbPlayers.FormattingEnabled = true;
            clbPlayers.Location = new Point(14, 39);
            clbPlayers.Margin = new Padding(3, 4, 3, 4);
            clbPlayers.Name = "clbPlayers";
            clbPlayers.Size = new Size(212, 180);
            clbPlayers.TabIndex = 6;
            // 
            // msMainMenu
            // 
            msMainMenu.ImageScalingSize = new Size(20, 20);
            msMainMenu.Items.AddRange(new ToolStripItem[] { igraciToolStripMenuItem, rangListeToolStripMenuItem });
            msMainMenu.Location = new Point(0, 0);
            msMainMenu.Name = "msMainMenu";
            msMainMenu.Padding = new Padding(6, 3, 0, 3);
            msMainMenu.Size = new Size(914, 30);
            msMainMenu.TabIndex = 6;
            msMainMenu.Text = "menuStrip1";
            // 
            // igraciToolStripMenuItem
            // 
            igraciToolStripMenuItem.Name = "igraciToolStripMenuItem";
            igraciToolStripMenuItem.Size = new Size(60, 24);
            igraciToolStripMenuItem.Text = "Igraci";
            igraciToolStripMenuItem.Click += igraciToolStripMenuItem_Click;
            // 
            // rangListeToolStripMenuItem
            // 
            rangListeToolStripMenuItem.Name = "rangListeToolStripMenuItem";
            rangListeToolStripMenuItem.Size = new Size(88, 24);
            rangListeToolStripMenuItem.Text = "Rang liste";
            rangListeToolStripMenuItem.Click += rangListeToolStripMenuItem_Click;
            // 
            // pNonFavouritePlayers
            // 
            pNonFavouritePlayers.BackColor = Color.White;
            pNonFavouritePlayers.Controls.Add(lbAllPlayers);
            pNonFavouritePlayers.Location = new Point(3, 3);
            pNonFavouritePlayers.Name = "pNonFavouritePlayers";
            pNonFavouritePlayers.Size = new Size(438, 511);
            pNonFavouritePlayers.TabIndex = 7;
            // 
            // lbAllPlayers
            // 
            lbAllPlayers.FormattingEnabled = true;
            lbAllPlayers.ItemHeight = 20;
            lbAllPlayers.Location = new Point(3, 3);
            lbAllPlayers.Name = "lbAllPlayers";
            lbAllPlayers.Size = new Size(433, 504);
            lbAllPlayers.TabIndex = 0;
            lbAllPlayers.DragDrop += lbAllPlayers_DragDrop;
            lbAllPlayers.DragEnter += lbAllPlayers_DragEnter;
            lbAllPlayers.MouseDown += lbAllPlayers_MouseDown;
            lbAllPlayers.MouseUp += lbAllPlayers_MouseUp;
            // 
            // pFavouritePlayers
            // 
            pFavouritePlayers.BackColor = Color.White;
            pFavouritePlayers.Controls.Add(lbFavouritePlayers);
            pFavouritePlayers.Location = new Point(448, 3);
            pFavouritePlayers.Name = "pFavouritePlayers";
            pFavouritePlayers.Size = new Size(439, 511);
            pFavouritePlayers.TabIndex = 8;
            // 
            // lbFavouritePlayers
            // 
            lbFavouritePlayers.FormattingEnabled = true;
            lbFavouritePlayers.ItemHeight = 20;
            lbFavouritePlayers.Location = new Point(3, 3);
            lbFavouritePlayers.Name = "lbFavouritePlayers";
            lbFavouritePlayers.Size = new Size(433, 504);
            lbFavouritePlayers.TabIndex = 1;
            lbFavouritePlayers.DragDrop += lbFavouritePlayers_DragDrop;
            lbFavouritePlayers.DragEnter += lbFavouritePlayers_DragEnter;
            lbFavouritePlayers.MouseDown += lbFavouritePlayers_MouseDown;
            lbFavouritePlayers.MouseUp += lbFavouritePlayers_MouseUp;
            // 
            // tlpPlayersPanels
            // 
            tlpPlayersPanels.ColumnCount = 2;
            tlpPlayersPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.Controls.Add(pFavouritePlayers, 1, 0);
            tlpPlayersPanels.Controls.Add(pNonFavouritePlayers, 0, 0);
            tlpPlayersPanels.Location = new Point(10, 79);
            tlpPlayersPanels.Name = "tlpPlayersPanels";
            tlpPlayersPanels.RowCount = 1;
            tlpPlayersPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.Size = new Size(890, 517);
            tlpPlayersPanels.TabIndex = 9;
            // 
            // lblOtherPlayers
            // 
            lblOtherPlayers.AutoSize = true;
            lblOtherPlayers.Location = new Point(10, 46);
            lblOtherPlayers.Name = "lblOtherPlayers";
            lblOtherPlayers.Size = new Size(91, 20);
            lblOtherPlayers.TabIndex = 10;
            lblOtherPlayers.Text = "Ostali igraci:";
            // 
            // lblFavPlayers
            // 
            lblFavPlayers.AutoSize = true;
            lblFavPlayers.Location = new Point(458, 46);
            lblFavPlayers.Name = "lblFavPlayers";
            lblFavPlayers.Size = new Size(109, 20);
            lblFavPlayers.TabIndex = 11;
            lblFavPlayers.Text = "Omiljeni igraci:";
            // 
            // btnPlayerDetails
            // 
            btnPlayerDetails.Location = new Point(761, 41);
            btnPlayerDetails.Margin = new Padding(3, 4, 3, 4);
            btnPlayerDetails.Name = "btnPlayerDetails";
            btnPlayerDetails.Size = new Size(139, 31);
            btnPlayerDetails.TabIndex = 12;
            btnPlayerDetails.Text = "Detalji igraca";
            btnPlayerDetails.UseVisualStyleBackColor = true;
            btnPlayerDetails.Click += btnPlayerDetails_Click;
            // 
            // tlpRankLists
            // 
            tlpRankLists.ColumnCount = 2;
            tlpRankLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.08989F));
            tlpRankLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.91011F));
            tlpRankLists.Controls.Add(panel1, 1, 0);
            tlpRankLists.Controls.Add(panel2, 0, 0);
            tlpRankLists.Location = new Point(10, 79);
            tlpRankLists.Name = "tlpRankLists";
            tlpRankLists.RowCount = 1;
            tlpRankLists.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRankLists.Size = new Size(890, 517);
            tlpRankLists.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbVisitorRankList);
            panel1.Location = new Point(342, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 511);
            panel1.TabIndex = 8;
            // 
            // lbVisitorRankList
            // 
            lbVisitorRankList.FormattingEnabled = true;
            lbVisitorRankList.ItemHeight = 20;
            lbVisitorRankList.Location = new Point(3, 4);
            lbVisitorRankList.Name = "lbVisitorRankList";
            lbVisitorRankList.Size = new Size(536, 504);
            lbVisitorRankList.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbPlayerRankList);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 511);
            panel2.TabIndex = 7;
            // 
            // lbPlayerRankList
            // 
            lbPlayerRankList.FormattingEnabled = true;
            lbPlayerRankList.ItemHeight = 20;
            lbPlayerRankList.Location = new Point(3, 3);
            lbPlayerRankList.Name = "lbPlayerRankList";
            lbPlayerRankList.Size = new Size(327, 504);
            lbPlayerRankList.TabIndex = 0;
            // 
            // lblRankPlayers
            // 
            lblRankPlayers.AutoSize = true;
            lblRankPlayers.Location = new Point(10, 46);
            lblRankPlayers.Name = "lblRankPlayers";
            lblRankPlayers.Size = new Size(49, 20);
            lblRankPlayers.TabIndex = 14;
            lblRankPlayers.Text = "Igraci:";
            // 
            // lblRangVisitors
            // 
            lblRangVisitors.AutoSize = true;
            lblRangVisitors.Location = new Point(352, 46);
            lblRangVisitors.Name = "lblRangVisitors";
            lblRangVisitors.Size = new Size(80, 20);
            lblRangVisitors.TabIndex = 15;
            lblRangVisitors.Text = "Posjetitelji:";
            // 
            // FootbalManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 608);
            Controls.Add(lblRangVisitors);
            Controls.Add(lblRankPlayers);
            Controls.Add(tlpRankLists);
            Controls.Add(tlpPlayersPanels);
            Controls.Add(btnPlayerDetails);
            Controls.Add(lblFavPlayers);
            Controls.Add(lblOtherPlayers);
            Controls.Add(tlpFavouritePlayers);
            Controls.Add(tlpFavouriteTeam);
            Controls.Add(msMainMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = msMainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FootbalManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Football Manager";
            Load += Form1_Load;
            tlpFavouriteTeam.ResumeLayout(false);
            tlpFavouritePlayers.ResumeLayout(false);
            msMainMenu.ResumeLayout(false);
            msMainMenu.PerformLayout();
            pNonFavouritePlayers.ResumeLayout(false);
            pFavouritePlayers.ResumeLayout(false);
            tlpPlayersPanels.ResumeLayout(false);
            tlpRankLists.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox lbAllPlayers;
        private Panel pFavouritePlayers;
        private ListBox lbFavouritePlayers;
        private TableLayoutPanel tlpPlayersPanels;
        private Label lblOtherPlayers;
        private Label lblFavPlayers;
        private Button btnPlayerDetails;
        private ToolStripMenuItem rangListeToolStripMenuItem;
        private TableLayoutPanel tlpRankLists;
        private Panel panel1;
        private ListBox lbVisitorRankList;
        private Panel panel2;
        private ListBox lbPlayerRankList;
        private Label lblRankPlayers;
        private Label lblRangVisitors;
    }
}