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
            this.tlpFavouriteTeam.SuspendLayout();
            this.tlpFavouritePlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(3, 36);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(206, 23);
            this.cbTeams.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            this.lblFavouriteTeam.Location = new System.Drawing.Point(3, 0);
            this.lblFavouriteTeam.Name = "lblFavouriteTeam";
            this.lblFavouriteTeam.Size = new System.Drawing.Size(206, 31);
            this.lblFavouriteTeam.TabIndex = 1;
            this.lblFavouriteTeam.Text = "Omiljeni tim:";
            this.lblFavouriteTeam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAddFavouriteTeam
            // 
            this.btnAddFavouriteTeam.Location = new System.Drawing.Point(3, 69);
            this.btnAddFavouriteTeam.Name = "btnAddFavouriteTeam";
            this.btnAddFavouriteTeam.Size = new System.Drawing.Size(206, 25);
            this.btnAddFavouriteTeam.TabIndex = 2;
            this.btnAddFavouriteTeam.Text = "DODAJ";
            this.btnAddFavouriteTeam.UseVisualStyleBackColor = true;
            this.btnAddFavouriteTeam.Click += new System.EventHandler(this.btnAddFavouriteTeam_Click);
            // 
            // tlpFavouriteTeam
            // 
            this.tlpFavouriteTeam.ColumnCount = 1;
            this.tlpFavouriteTeam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.Controls.Add(this.cbTeams, 0, 1);
            this.tlpFavouriteTeam.Controls.Add(this.btnAddFavouriteTeam, 0, 2);
            this.tlpFavouriteTeam.Controls.Add(this.lblFavouriteTeam, 0, 0);
            this.tlpFavouriteTeam.Location = new System.Drawing.Point(302, 157);
            this.tlpFavouriteTeam.Name = "tlpFavouriteTeam";
            this.tlpFavouriteTeam.RowCount = 3;
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouriteTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFavouriteTeam.Size = new System.Drawing.Size(212, 97);
            this.tlpFavouriteTeam.TabIndex = 3;
            // 
            // tlpFavouritePlayers
            // 
            this.tlpFavouritePlayers.ColumnCount = 1;
            this.tlpFavouritePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouritePlayers.Controls.Add(this.btnAddFavouritePlayers, 0, 2);
            this.tlpFavouritePlayers.Controls.Add(this.lblFavouritePlayers, 0, 0);
            this.tlpFavouritePlayers.Controls.Add(this.clbPlayers, 0, 1);
            this.tlpFavouritePlayers.Location = new System.Drawing.Point(520, 157);
            this.tlpFavouritePlayers.Name = "tlpFavouritePlayers";
            this.tlpFavouritePlayers.RowCount = 3;
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.30434F));
            this.tlpFavouritePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpFavouritePlayers.Size = new System.Drawing.Size(212, 266);
            this.tlpFavouritePlayers.TabIndex = 5;
            // 
            // btnAddFavouritePlayers
            // 
            this.btnAddFavouritePlayers.Location = new System.Drawing.Point(3, 215);
            this.btnAddFavouritePlayers.Name = "btnAddFavouritePlayers";
            this.btnAddFavouritePlayers.Size = new System.Drawing.Size(206, 25);
            this.btnAddFavouritePlayers.TabIndex = 2;
            this.btnAddFavouritePlayers.Text = "DODAJ";
            this.btnAddFavouritePlayers.UseVisualStyleBackColor = true;
            this.btnAddFavouritePlayers.Click += new System.EventHandler(this.btnAddFavouritePlayers_Click);
            // 
            // lblFavouritePlayers
            // 
            this.lblFavouritePlayers.Location = new System.Drawing.Point(3, 0);
            this.lblFavouritePlayers.Name = "lblFavouritePlayers";
            this.lblFavouritePlayers.Size = new System.Drawing.Size(206, 18);
            this.lblFavouritePlayers.TabIndex = 1;
            this.lblFavouritePlayers.Text = "Omiljeni igraci:";
            this.lblFavouritePlayers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // clbPlayers
            // 
            this.clbPlayers.FormattingEnabled = true;
            this.clbPlayers.Location = new System.Drawing.Point(3, 21);
            this.clbPlayers.Name = "clbPlayers";
            this.clbPlayers.Size = new System.Drawing.Size(206, 184);
            this.clbPlayers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFavouritePlayers);
            this.Controls.Add(this.tlpFavouriteTeam);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpFavouriteTeam.ResumeLayout(false);
            this.tlpFavouritePlayers.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}