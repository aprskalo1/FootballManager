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
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(12, 27);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(264, 23);
            this.cbTeams.TabIndex = 0;
            // 
            // lblFavouriteTeam
            // 
            this.lblFavouriteTeam.AutoSize = true;
            this.lblFavouriteTeam.Location = new System.Drawing.Point(12, 9);
            this.lblFavouriteTeam.Name = "lblFavouriteTeam";
            this.lblFavouriteTeam.Size = new System.Drawing.Size(76, 15);
            this.lblFavouriteTeam.TabIndex = 1;
            this.lblFavouriteTeam.Text = "Omiljeni tim:";
            // 
            // btnAddFavouriteTeam
            // 
            this.btnAddFavouriteTeam.Location = new System.Drawing.Point(12, 56);
            this.btnAddFavouriteTeam.Name = "btnAddFavouriteTeam";
            this.btnAddFavouriteTeam.Size = new System.Drawing.Size(264, 23);
            this.btnAddFavouriteTeam.TabIndex = 2;
            this.btnAddFavouriteTeam.Text = "DODAJ";
            this.btnAddFavouriteTeam.UseVisualStyleBackColor = true;
            this.btnAddFavouriteTeam.Click += new System.EventHandler(this.btnAddFavouriteTeam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFavouriteTeam);
            this.Controls.Add(this.lblFavouriteTeam);
            this.Controls.Add(this.cbTeams);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTeams;
        private Label lblFavouriteTeam;
        private Button btnAddFavouriteTeam;
    }
}