
namespace MelodyGuess
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Download = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Subfolders = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRandomPlace = new System.Windows.Forms.CheckBox();
            this.CBDurationGame = new System.Windows.Forms.ComboBox();
            this.CBResponsetime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 186);
            this.listBox1.TabIndex = 0;
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.Download.Location = new System.Drawing.Point(12, 204);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(128, 28);
            this.Download.TabIndex = 1;
            this.Download.Text = "Choose folder";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.Clear.Location = new System.Drawing.Point(146, 204);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(91, 28);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Subfolders
            // 
            this.Subfolders.AutoSize = true;
            this.Subfolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.Subfolders.Location = new System.Drawing.Point(243, 204);
            this.Subfolders.Name = "Subfolders";
            this.Subfolders.Size = new System.Drawing.Size(108, 24);
            this.Subfolders.TabIndex = 3;
            this.Subfolders.Text = "Subfolders";
            this.Subfolders.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.btnOK.Location = new System.Drawing.Point(232, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.btnCancel.Location = new System.Drawing.Point(329, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbRandomPlace);
            this.groupBox1.Controls.Add(this.CBDurationGame);
            this.groupBox1.Controls.Add(this.CBResponsetime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "P";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Q";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(239, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 2";
            // 
            // cbRandomPlace
            // 
            this.cbRandomPlace.AutoSize = true;
            this.cbRandomPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRandomPlace.Location = new System.Drawing.Point(6, 85);
            this.cbRandomPlace.Name = "cbRandomPlace";
            this.cbRandomPlace.Size = new System.Drawing.Size(131, 24);
            this.cbRandomPlace.TabIndex = 4;
            this.cbRandomPlace.Text = "Random place";
            this.cbRandomPlace.UseVisualStyleBackColor = true;
            // 
            // CBDurationGame
            // 
            this.CBDurationGame.FormattingEnabled = true;
            this.CBDurationGame.Items.AddRange(new object[] {
            "20",
            "30",
            "45",
            "60",
            "75",
            "90",
            "120",
            "150",
            "180"});
            this.CBDurationGame.Location = new System.Drawing.Point(133, 25);
            this.CBDurationGame.Name = "CBDurationGame";
            this.CBDurationGame.Size = new System.Drawing.Size(59, 21);
            this.CBDurationGame.TabIndex = 3;
            this.CBDurationGame.Text = "60";
            // 
            // CBResponsetime
            // 
            this.CBResponsetime.FormattingEnabled = true;
            this.CBResponsetime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "7",
            "10",
            "15"});
            this.CBResponsetime.Location = new System.Drawing.Point(133, 58);
            this.CBResponsetime.Name = "CBResponsetime";
            this.CBResponsetime.Size = new System.Drawing.Size(59, 21);
            this.CBResponsetime.TabIndex = 2;
            this.CBResponsetime.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration of the game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Response time";
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Subfolders);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.CheckBox Subfolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBDurationGame;
        private System.Windows.Forms.ComboBox CBResponsetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomPlace;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}