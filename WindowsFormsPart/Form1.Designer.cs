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
            cbTeams.Location = new Point(13, 49);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(171, 23);
            cbTeams.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            lblFavouriteTeam.Location = new Point(13, 10);
            lblFavouriteTeam.Name = "lblFavouriteTeam";
            lblFavouriteTeam.Size = new Size(171, 23);
            lblFavouriteTeam.TabIndex = 1;
            lblFavouriteTeam.Text = "Omiljeni tim:";
            lblFavouriteTeam.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAddFavouriteTeam
            // 
            btnAddFavouriteTeam.Location = new Point(13, 85);
            btnAddFavouriteTeam.Name = "btnAddFavouriteTeam";
            btnAddFavouriteTeam.Size = new Size(171, 24);
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
            tlpFavouriteTeam.Location = new Point(302, 157);
            tlpFavouriteTeam.Name = "tlpFavouriteTeam";
            tlpFavouriteTeam.Padding = new Padding(10);
            tlpFavouriteTeam.RowCount = 3;
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFavouriteTeam.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFavouriteTeam.Size = new Size(197, 122);
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
            tlpFavouritePlayers.Location = new Point(302, 96);
            tlpFavouritePlayers.Name = "tlpFavouritePlayers";
            tlpFavouritePlayers.Padding = new Padding(10);
            tlpFavouritePlayers.RowCount = 3;
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Percent, 91.30434F));
            tlpFavouritePlayers.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpFavouritePlayers.Size = new Size(212, 266);
            tlpFavouritePlayers.TabIndex = 5;
            // 
            // btnAddFavouritePlayers
            // 
            btnAddFavouritePlayers.Location = new Point(13, 205);
            btnAddFavouritePlayers.Name = "btnAddFavouritePlayers";
            btnAddFavouritePlayers.Size = new Size(186, 25);
            btnAddFavouritePlayers.TabIndex = 2;
            btnAddFavouritePlayers.Text = "DODAJ";
            btnAddFavouritePlayers.UseVisualStyleBackColor = true;
            btnAddFavouritePlayers.Click += btnAddFavouritePlayers_Click;
            // 
            // lblFavouritePlayers
            // 
            lblFavouritePlayers.Location = new Point(13, 10);
            lblFavouritePlayers.Name = "lblFavouritePlayers";
            lblFavouritePlayers.Size = new Size(186, 16);
            lblFavouritePlayers.TabIndex = 1;
            lblFavouritePlayers.Text = "Omiljeni igraci:";
            lblFavouritePlayers.TextAlign = ContentAlignment.BottomLeft;
            // 
            // clbPlayers
            // 
            clbPlayers.FormattingEnabled = true;
            clbPlayers.Location = new Point(13, 29);
            clbPlayers.Name = "clbPlayers";
            clbPlayers.Size = new Size(186, 148);
            clbPlayers.TabIndex = 6;
            // 
            // msMainMenu
            // 
            msMainMenu.ImageScalingSize = new Size(20, 20);
            msMainMenu.Items.AddRange(new ToolStripItem[] { igraciToolStripMenuItem });
            msMainMenu.Location = new Point(0, 0);
            msMainMenu.Name = "msMainMenu";
            msMainMenu.Padding = new Padding(5, 2, 0, 2);
            msMainMenu.Size = new Size(800, 24);
            msMainMenu.TabIndex = 6;
            msMainMenu.Text = "menuStrip1";
            // 
            // igraciToolStripMenuItem
            // 
            igraciToolStripMenuItem.Name = "igraciToolStripMenuItem";
            igraciToolStripMenuItem.Size = new Size(48, 20);
            igraciToolStripMenuItem.Text = "Igraci";
            // 
            // pNonFavouritePlayers
            // 
            pNonFavouritePlayers.BackColor = Color.White;
            pNonFavouritePlayers.Controls.Add(lbAllPlayers);
            pNonFavouritePlayers.Location = new Point(3, 2);
            pNonFavouritePlayers.Margin = new Padding(3, 2, 3, 2);
            pNonFavouritePlayers.Name = "pNonFavouritePlayers";
            pNonFavouritePlayers.Size = new Size(383, 384);
            pNonFavouritePlayers.TabIndex = 7;
            // 
            // lbAllPlayers
            // 
            lbAllPlayers.FormattingEnabled = true;
            lbAllPlayers.ItemHeight = 15;
            lbAllPlayers.Location = new Point(3, 2);
            lbAllPlayers.Margin = new Padding(3, 2, 3, 2);
            lbAllPlayers.Name = "lbAllPlayers";
            lbAllPlayers.Size = new Size(379, 379);
            lbAllPlayers.TabIndex = 0;
            lbAllPlayers.DragDrop += lbAllPlayers_DragDrop;
            lbAllPlayers.DragEnter += lbAllPlayers_DragEnter;
            lbAllPlayers.MouseDown += lbAllPlayers_MouseDown;
            // 
            // pFavouritePlayers
            // 
            pFavouritePlayers.BackColor = Color.White;
            pFavouritePlayers.Controls.Add(lbFavouritePlayers);
            pFavouritePlayers.Location = new Point(392, 2);
            pFavouritePlayers.Margin = new Padding(3, 2, 3, 2);
            pFavouritePlayers.Name = "pFavouritePlayers";
            pFavouritePlayers.Size = new Size(384, 384);
            pFavouritePlayers.TabIndex = 8;
            // 
            // lbFavouritePlayers
            // 
            lbFavouritePlayers.FormattingEnabled = true;
            lbFavouritePlayers.ItemHeight = 15;
            lbFavouritePlayers.Location = new Point(3, 2);
            lbFavouritePlayers.Margin = new Padding(3, 2, 3, 2);
            lbFavouritePlayers.Name = "lbFavouritePlayers";
            lbFavouritePlayers.Size = new Size(379, 379);
            lbFavouritePlayers.TabIndex = 1;
            lbFavouritePlayers.DragDrop += lbFavouritePlayers_DragDrop;
            lbFavouritePlayers.DragEnter += lbFavouritePlayers_DragEnter;
            lbFavouritePlayers.MouseDown += lbFavouritePlayers_MouseDown;
            // 
            // tlpPlayersPanels
            // 
            tlpPlayersPanels.ColumnCount = 2;
            tlpPlayersPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.Controls.Add(pFavouritePlayers, 1, 0);
            tlpPlayersPanels.Controls.Add(pNonFavouritePlayers, 0, 0);
            tlpPlayersPanels.Location = new Point(10, 52);
            tlpPlayersPanels.Margin = new Padding(3, 2, 3, 2);
            tlpPlayersPanels.Name = "tlpPlayersPanels";
            tlpPlayersPanels.RowCount = 1;
            tlpPlayersPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPlayersPanels.Size = new Size(779, 388);
            tlpPlayersPanels.TabIndex = 9;
            // 
            // lblOtherPlayers
            // 
            lblOtherPlayers.AutoSize = true;
            lblOtherPlayers.Location = new Point(16, 35);
            lblOtherPlayers.Name = "lblOtherPlayers";
            lblOtherPlayers.Size = new Size(72, 15);
            lblOtherPlayers.TabIndex = 10;
            lblOtherPlayers.Text = "Ostali igraci:";
            // 
            // lblFavPlayers
            // 
            lblFavPlayers.AutoSize = true;
            lblFavPlayers.Location = new Point(405, 35);
            lblFavPlayers.Name = "lblFavPlayers";
            lblFavPlayers.Size = new Size(87, 15);
            lblFavPlayers.TabIndex = 11;
            lblFavPlayers.Text = "Omiljeni igraci:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFavPlayers);
            Controls.Add(lblOtherPlayers);
            Controls.Add(tlpPlayersPanels);
            Controls.Add(tlpFavouritePlayers);
            Controls.Add(tlpFavouriteTeam);
            Controls.Add(msMainMenu);
            MainMenuStrip = msMainMenu;
            Name = "Form1";
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
    }
}