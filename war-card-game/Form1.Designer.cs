
namespace war_card_game
{
    partial class Form1
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
            this.playCard1 = new System.Windows.Forms.Button();
            this.playCard2 = new System.Windows.Forms.Button();
            this.cardsLeft = new System.Windows.Forms.Label();
            this.cardsLeftCount2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardsLeftCount1 = new System.Windows.Forms.Label();
            this.cards2 = new System.Windows.Forms.Label();
            this.cards1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playCard1
            // 
            this.playCard1.Location = new System.Drawing.Point(331, 346);
            this.playCard1.Name = "playCard1";
            this.playCard1.Size = new System.Drawing.Size(75, 23);
            this.playCard1.TabIndex = 0;
            this.playCard1.Text = "Play card";
            this.playCard1.UseVisualStyleBackColor = true;
            this.playCard1.Click += new System.EventHandler(this.playCard1_Click);
            // 
            // playCard2
            // 
            this.playCard2.Location = new System.Drawing.Point(331, 52);
            this.playCard2.Name = "playCard2";
            this.playCard2.Size = new System.Drawing.Size(75, 23);
            this.playCard2.TabIndex = 1;
            this.playCard2.Text = "Play card";
            this.playCard2.UseVisualStyleBackColor = true;
            this.playCard2.Click += new System.EventHandler(this.playCard2_Click);
            // 
            // cardsLeft
            // 
            this.cardsLeft.AutoSize = true;
            this.cardsLeft.Location = new System.Drawing.Point(90, 52);
            this.cardsLeft.Name = "cardsLeft";
            this.cardsLeft.Size = new System.Drawing.Size(54, 13);
            this.cardsLeft.TabIndex = 2;
            this.cardsLeft.Text = "Cards left:";
            // 
            // cardsLeftCount2
            // 
            this.cardsLeftCount2.AutoSize = true;
            this.cardsLeftCount2.Location = new System.Drawing.Point(161, 52);
            this.cardsLeftCount2.Name = "cardsLeftCount2";
            this.cardsLeftCount2.Size = new System.Drawing.Size(13, 13);
            this.cardsLeftCount2.TabIndex = 3;
            this.cardsLeftCount2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cards left:";
            // 
            // cardsLeftCount1
            // 
            this.cardsLeftCount1.AutoSize = true;
            this.cardsLeftCount1.Location = new System.Drawing.Point(161, 346);
            this.cardsLeftCount1.Name = "cardsLeftCount1";
            this.cardsLeftCount1.Size = new System.Drawing.Size(13, 13);
            this.cardsLeftCount1.TabIndex = 5;
            this.cardsLeftCount1.Text = "0";
            // 
            // cards2
            // 
            this.cards2.AutoSize = true;
            this.cards2.Location = new System.Drawing.Point(349, 148);
            this.cards2.Name = "cards2";
            this.cards2.Size = new System.Drawing.Size(35, 13);
            this.cards2.TabIndex = 6;
            this.cards2.Text = "label2";
            // 
            // cards1
            // 
            this.cards1.AutoSize = true;
            this.cards1.Location = new System.Drawing.Point(349, 231);
            this.cards1.Name = "cards1";
            this.cards1.Size = new System.Drawing.Size(35, 13);
            this.cards1.TabIndex = 7;
            this.cards1.Text = "label2";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(349, 403);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(35, 13);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cards1);
            this.Controls.Add(this.cards2);
            this.Controls.Add(this.cardsLeftCount1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardsLeftCount2);
            this.Controls.Add(this.cardsLeft);
            this.Controls.Add(this.playCard2);
            this.Controls.Add(this.playCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playCard1;
        private System.Windows.Forms.Button playCard2;
        private System.Windows.Forms.Label cardsLeft;
        private System.Windows.Forms.Label cardsLeftCount2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardsLeftCount1;
        private System.Windows.Forms.Label cards2;
        private System.Windows.Forms.Label cards1;
        private System.Windows.Forms.Label lbl_status;
    }
}

