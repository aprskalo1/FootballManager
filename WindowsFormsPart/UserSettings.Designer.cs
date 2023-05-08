namespace WindowsFormsPart
{
    partial class UserSettings
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
            this.cbChooseWorldCup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseLanguage = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbChooseWorldCup
            // 
            this.cbChooseWorldCup.FormattingEnabled = true;
            this.cbChooseWorldCup.Items.AddRange(new object[] {
            "Musko",
            "Zensko"});
            this.cbChooseWorldCup.Location = new System.Drawing.Point(12, 75);
            this.cbChooseWorldCup.Name = "cbChooseWorldCup";
            this.cbChooseWorldCup.Size = new System.Drawing.Size(219, 23);
            this.cbChooseWorldCup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabir prvenstva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odabir jezika:";
            // 
            // cbChooseLanguage
            // 
            this.cbChooseLanguage.FormattingEnabled = true;
            this.cbChooseLanguage.Items.AddRange(new object[] {
            "HRV",
            "ENG"});
            this.cbChooseLanguage.Location = new System.Drawing.Point(12, 136);
            this.cbChooseLanguage.Name = "cbChooseLanguage";
            this.cbChooseLanguage.Size = new System.Drawing.Size(219, 23);
            this.cbChooseLanguage.TabIndex = 2;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(11, 183);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(219, 35);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "SPREMI";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "UNOS POSTAVKI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChooseWorldCup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbChooseWorldCup;
        private Label label1;
        private Label label2;
        private ComboBox cbChooseLanguage;
        private Button btnSaveSettings;
        private Label label3;
    }
}