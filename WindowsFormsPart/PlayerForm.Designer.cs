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
            btnAddPicture = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavouritePlayerIcon).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            pbPlayerPicture.Location = new Point(12, 12);
            pbPlayerPicture.Name = "pbPlayerPicture";
            pbPlayerPicture.Size = new Size(130, 162);
            pbPlayerPicture.TabIndex = 0;
            pbPlayerPicture.TabStop = false;
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(148, 12);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.ReadOnly = true;
            tbPlayerName.Size = new Size(133, 23);
            tbPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Broj dresa:";
            // 
            // tbShirtNmber
            // 
            tbShirtNmber.Location = new Point(233, 46);
            tbShirtNmber.Name = "tbShirtNmber";
            tbShirtNmber.ReadOnly = true;
            tbShirtNmber.Size = new Size(48, 23);
            tbShirtNmber.TabIndex = 3;
            tbShirtNmber.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPosition
            // 
            tbPosition.Location = new Point(148, 93);
            tbPosition.Name = "tbPosition";
            tbPosition.ReadOnly = true;
            tbPosition.Size = new Size(133, 23);
            tbPosition.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Pozicija:";
            // 
            // pbFavouritePlayerIcon
            // 
            pbFavouritePlayerIcon.BackColor = Color.Transparent;
            pbFavouritePlayerIcon.Image = (Image)resources.GetObject("pbFavouritePlayerIcon.Image");
            pbFavouritePlayerIcon.Location = new Point(12, 12);
            pbFavouritePlayerIcon.Margin = new Padding(3, 2, 3, 2);
            pbFavouritePlayerIcon.Name = "pbFavouritePlayerIcon";
            pbFavouritePlayerIcon.Size = new Size(22, 23);
            pbFavouritePlayerIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavouritePlayerIcon.TabIndex = 7;
            pbFavouritePlayerIcon.TabStop = false;
            // 
            // tbIsCaptain
            // 
            tbIsCaptain.Location = new Point(233, 121);
            tbIsCaptain.Name = "tbIsCaptain";
            tbIsCaptain.ReadOnly = true;
            tbIsCaptain.Size = new Size(48, 23);
            tbIsCaptain.TabIndex = 9;
            tbIsCaptain.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 124);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Kapetan:";
            // 
            // btnAddPicture
            // 
            btnAddPicture.Location = new Point(148, 151);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(133, 23);
            btnAddPicture.TabIndex = 10;
            btnAddPicture.Text = "Dodaj sliku";
            btnAddPicture.UseVisualStyleBackColor = true;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(293, 178);
            Controls.Add(btnAddPicture);
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
        private Button btnAddPicture;
    }
}