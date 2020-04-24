namespace Russian_Roulette
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

        #region // using (SoundPlayer player = new SoundPlayer(C:\Users\reube\source\repos\Russian Roulette\Russian Roulette\Resources.resx)  //need to put the sound file in 
        //http://soundbible.com/tags-gunshot.htmlWindows 

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFire = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.rrbshoot = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(129, 50);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(109, 58);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.Location = new System.Drawing.Point(283, 50);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(116, 58);
            this.btnshoot.TabIndex = 1;
            this.btnshoot.Text = "Shoot Away";
            this.btnshoot.UseVisualStyleBackColor = true;
            this.btnshoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Location = new System.Drawing.Point(494, 69);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(115, 21);
            this.rbHead.TabIndex = 5;
            this.rbHead.TabStop = true;
            this.rbHead.Text = "Point at Head";
            this.rbHead.UseVisualStyleBackColor = true;
            // 
            // rrbshoot
            // 
            this.rrbshoot.AutoSize = true;
            this.rrbshoot.Location = new System.Drawing.Point(494, 107);
            this.rrbshoot.Name = "rrbshoot";
            this.rrbshoot.Size = new System.Drawing.Size(98, 21);
            this.rrbshoot.TabIndex = 6;
            this.rrbshoot.TabStop = true;
            this.rrbshoot.Text = "Point Away";
            this.rrbshoot.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(220, 370);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(116, 56);
            this.btnRepeat.TabIndex = 8;
            this.btnRepeat.Text = "Start Again";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 148);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rrbshoot);
            this.Controls.Add(this.rbHead);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btnFire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.RadioButton rbHead;
        private System.Windows.Forms.RadioButton rrbshoot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

