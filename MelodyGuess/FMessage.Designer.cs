
namespace MelodyGuess
{
    partial class FMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMessage));
            this.LBLmes = new System.Windows.Forms.Label();
            this.BTNYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Label();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLmes
            // 
            this.LBLmes.AutoSize = true;
            this.LBLmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBLmes.Location = new System.Drawing.Point(113, 63);
            this.LBLmes.Name = "LBLmes";
            this.LBLmes.Size = new System.Drawing.Size(0, 33);
            this.LBLmes.TabIndex = 0;
            // 
            // BTNYes
            // 
            this.BTNYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BTNYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNYes.Location = new System.Drawing.Point(29, 217);
            this.BTNYes.Name = "BTNYes";
            this.BTNYes.Size = new System.Drawing.Size(120, 52);
            this.BTNYes.TabIndex = 1;
            this.BTNYes.Text = "Yes";
            this.BTNYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(194, 217);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(120, 52);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.AutoSize = true;
            this.Timer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer2.Location = new System.Drawing.Point(148, 124);
            this.Timer2.Name = "Timer2";
            this.Timer2.Size = new System.Drawing.Size(35, 37);
            this.Timer2.TabIndex = 3;
            this.Timer2.Text = "0";
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.AutoSize = true;
            this.lblShowAnswer.Location = new System.Drawing.Point(96, 181);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(87, 13);
            this.lblShowAnswer.TabIndex = 4;
            this.lblShowAnswer.Text = "Показать ответ";
            this.lblShowAnswer.Click += new System.EventHandler(this.lblShowAnswer_Click);
            // 
            // FMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 325);
            this.Controls.Add(this.lblShowAnswer);
            this.Controls.Add(this.Timer2);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.BTNYes);
            this.Controls.Add(this.LBLmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMessage_FormClosed);
            this.Load += new System.EventHandler(this.FMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBLmes;
        private System.Windows.Forms.Button BTNYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer2;
        private System.Windows.Forms.Label lblShowAnswer;
    }
}