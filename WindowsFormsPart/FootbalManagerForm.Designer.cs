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
            pNonFavouritePlayers = new Panel();
            lbAllPlayers = new ListBox();
            pFavouritePlayers = new Panel();
            lbFavouritePlayers = new ListBox();
            tlpPlayersPanels = new TableLayoutPanel();
            lblOtherPlayers = new Label();
            lblFavPlayers = new Label();
            btnPlayerDetails = new Button();
            tlpFavouriteTeam.SuspendLayout();
            tlpFavouritePlayers.SuspendLayout();
            msMainMenu.SuspendLayout();
            pNonFavouritePlayers.SuspendLayout();
            pFavouritePlayers.SuspendLayout();
            tlpPlayersPanels.SuspendLayout();
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
            msMainMenu.Items.AddRange(new ToolStripItem[] { igraciToolStripMenuItem });
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
            lblOtherPlayers.Location = new Point(18, 47);
            lblOtherPlayers.Name = "lblOtherPlayers";
            lblOtherPlayers.Size = new Size(91, 20);
            lblOtherPlayers.TabIndex = 10;
            lblOtherPlayers.Text = "Ostali igraci:";
            // 
            // lblFavPlayers
            // 
            lblFavPlayers.AutoSize = true;
            lblFavPlayers.Location = new Point(463, 47);
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
            // FootbalManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 608);
            Controls.Add(btnPlayerDetails);
            Controls.Add(lblFavPlayers);
            Controls.Add(lblOtherPlayers);
            Controls.Add(tlpPlayersPanels);
            Controls.Add(tlpFavouritePlayers);
            Controls.Add(tlpFavouriteTeam);
            Controls.Add(msMainMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = msMainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FootbalManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tlpFavouriteTeam.ResumeLayout(false);
            tlpFavouritePlayers.ResumeLayout(false);
            msMainMenu.ResumeLayout(false);
            msMainMenu.PerformLayout();
            pNonFavouritePlayers.ResumeLayout(false);
            pFavouritePlayers.ResumeLayout(false);
            tlpPlayersPanels.ResumeLayout(false);
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
    }
}