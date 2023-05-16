namespace WindowsFormsPart
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            pbPlayerPicture = new PictureBox();
            tbPlayerName = new TextBox();
            label1 = new Label();
            tbShirtNmber = new TextBox();
            tbPosition = new TextBox();
            label2 = new Label();
            pbFavouritePlayerIcon = new PictureBox();
            tbIsCaptain = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavouritePlayerIcon).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            pbPlayerPicture.Location = new Point(14, 16);
            pbPlayerPicture.Margin = new Padding(3, 4, 3, 4);
            pbPlayerPicture.Name = "pbPlayerPicture";
            pbPlayerPicture.Size = new Size(149, 173);
            pbPlayerPicture.TabIndex = 0;
            pbPlayerPicture.TabStop = false;
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(169, 16);
            tbPlayerName.Margin = new Padding(3, 4, 3, 4);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.ReadOnly = true;
            tbPlayerName.Size = new Size(151, 27);
            tbPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Broj dresa:";
            // 
            // tbShirtNmber
            // 
            tbShirtNmber.Location = new Point(266, 61);
            tbShirtNmber.Margin = new Padding(3, 4, 3, 4);
            tbShirtNmber.Name = "tbShirtNmber";
            tbShirtNmber.ReadOnly = true;
            tbShirtNmber.Size = new Size(54, 27);
            tbShirtNmber.TabIndex = 3;
            tbShirtNmber.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(169, 124);
            tbPosition.Margin = new Padding(3, 4, 3, 4);
            tbPosition.Name = "tbPosition";
            tbPosition.ReadOnly = true;
            tbPosition.Size = new Size(151, 27);
            tbPosition.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Pozicija:";
            // 
            // pbFavouritePlayerIcon
            // 
            pbFavouritePlayerIcon.Image = (Image)resources.GetObject("pbFavouritePlayerIcon.Image");
            pbFavouritePlayerIcon.Location = new Point(14, 16);
            pbFavouritePlayerIcon.Name = "pbFavouritePlayerIcon";
            pbFavouritePlayerIcon.Size = new Size(44, 43);
            pbFavouritePlayerIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavouritePlayerIcon.TabIndex = 7;
            pbFavouritePlayerIcon.TabStop = false;
            // 
            // tbIsCaptain
            // 
            tbIsCaptain.Location = new Point(266, 162);
            tbIsCaptain.Margin = new Padding(3, 4, 3, 4);
            tbIsCaptain.Name = "tbIsCaptain";
            tbIsCaptain.ReadOnly = true;
            tbIsCaptain.Size = new Size(54, 27);
            tbIsCaptain.TabIndex = 9;
            tbIsCaptain.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 165);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Kapetan:";
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(335, 208);
            Controls.Add(tbIsCaptain);
            Controls.Add(label3);
            Controls.Add(pbFavouritePlayerIcon);
            Controls.Add(tbPosition);
            Controls.Add(label2);
            Controls.Add(tbShirtNmber);
            Controls.Add(label1);
            Controls.Add(tbPlayerName);
            Controls.Add(pbPlayerPicture);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalji igraca";
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFavouritePlayerIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPlayerPicture;
        private TextBox tbPlayerName;
        private Label label1;
        private TextBox tbShirtNmber;
        private TextBox tbPosition;
        private Label label2;
        private PictureBox pbFavouritePlayerIcon;
        private TextBox tbIsCaptain;
        private Label label3;
    }
}