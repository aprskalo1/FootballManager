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
            pbPlayerPicture = new PictureBox();
            tbPlayerName = new TextBox();
            label1 = new Label();
            tbShirtNmber = new TextBox();
            tbPosition = new TextBox();
            label2 = new Label();
            cbIsCaptain = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            pbPlayerPicture.Location = new Point(12, 12);
            pbPlayerPicture.Name = "pbPlayerPicture";
            pbPlayerPicture.Size = new Size(130, 130);
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
            // cbIsCaptain
            // 
            cbIsCaptain.AutoSize = true;
            cbIsCaptain.Enabled = false;
            cbIsCaptain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbIsCaptain.Location = new Point(148, 125);
            cbIsCaptain.Name = "cbIsCaptain";
            cbIsCaptain.Size = new Size(69, 19);
            cbIsCaptain.TabIndex = 6;
            cbIsCaptain.Text = "Kapetan";
            cbIsCaptain.UseVisualStyleBackColor = true;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 156);
            Controls.Add(cbIsCaptain);
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
        private CheckBox cbIsCaptain;
    }
}