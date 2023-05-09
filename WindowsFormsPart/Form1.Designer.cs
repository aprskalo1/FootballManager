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
            this.tlpFavouritePlayer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFavouritePlayer.SuspendLayout();
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
            // tlpFavouritePlayer
            // 
            this.tlpFavouritePlayer.ColumnCount = 1;
            this.tlpFavouritePlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouritePlayer.Controls.Add(this.cbTeams, 0, 1);
            this.tlpFavouritePlayer.Controls.Add(this.btnAddFavouriteTeam, 0, 2);
            this.tlpFavouritePlayer.Controls.Add(this.lblFavouriteTeam, 0, 0);
            this.tlpFavouritePlayer.Location = new System.Drawing.Point(302, 157);
            this.tlpFavouritePlayer.Name = "tlpFavouritePlayer";
            this.tlpFavouritePlayer.RowCount = 3;
            this.tlpFavouritePlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouritePlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFavouritePlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFavouritePlayer.Size = new System.Drawing.Size(212, 97);
            this.tlpFavouritePlayer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFavouritePlayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpFavouritePlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbTeams;
        private Label lblFavouriteTeam;
        private Button btnAddFavouriteTeam;
        private TableLayoutPanel tlpFavouritePlayer;
    }
}