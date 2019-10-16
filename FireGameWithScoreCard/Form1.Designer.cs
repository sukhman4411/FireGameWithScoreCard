namespace FireGameWithScoreCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBullet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonTry = new System.Windows.Forms.Button();
            this.ButtonShoot = new System.Windows.Forms.Button();
            this.ButtonSpin = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Bullet";
            // 
            // lblBullet
            // 
            this.lblBullet.AutoSize = true;
            this.lblBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBullet.ForeColor = System.Drawing.Color.Azure;
            this.lblBullet.Location = new System.Drawing.Point(141, 25);
            this.lblBullet.Name = "lblBullet";
            this.lblBullet.Size = new System.Drawing.Size(0, 25);
            this.lblBullet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "No of Trigger";
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrigger.ForeColor = System.Drawing.Color.Azure;
            this.lblTrigger.Location = new System.Drawing.Point(161, 97);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(0, 25);
            this.lblTrigger.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources.gun;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(591, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 98);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonTry
            // 
            this.ButtonTry.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources._try;
            this.ButtonTry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTry.Enabled = false;
            this.ButtonTry.Location = new System.Drawing.Point(697, 328);
            this.ButtonTry.Name = "ButtonTry";
            this.ButtonTry.Size = new System.Drawing.Size(100, 98);
            this.ButtonTry.TabIndex = 9;
            this.ButtonTry.UseVisualStyleBackColor = true;
            this.ButtonTry.Click += new System.EventHandler(this.ButtonTry_Click);
            // 
            // ButtonShoot
            // 
            this.ButtonShoot.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources.shoot;
            this.ButtonShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonShoot.Enabled = false;
            this.ButtonShoot.Location = new System.Drawing.Point(485, 328);
            this.ButtonShoot.Name = "ButtonShoot";
            this.ButtonShoot.Size = new System.Drawing.Size(100, 98);
            this.ButtonShoot.TabIndex = 8;
            this.ButtonShoot.UseVisualStyleBackColor = true;
            this.ButtonShoot.Click += new System.EventHandler(this.ButtonShoot_Click);
            // 
            // ButtonSpin
            // 
            this.ButtonSpin.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources.spin;
            this.ButtonSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSpin.Location = new System.Drawing.Point(374, 328);
            this.ButtonSpin.Name = "ButtonSpin";
            this.ButtonSpin.Size = new System.Drawing.Size(100, 98);
            this.ButtonSpin.TabIndex = 7;
            this.ButtonSpin.UseVisualStyleBackColor = true;
            this.ButtonSpin.Click += new System.EventHandler(this.ButtonSpin_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources.load;
            this.ButtonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoad.Location = new System.Drawing.Point(253, 328);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(100, 98);
            this.ButtonLoad.TabIndex = 6;
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::FireGameWithScoreCard.Properties.Resources.start;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(121, 328);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(109, 98);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(260, 39);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(347, 244);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonTry);
            this.Controls.Add(this.ButtonShoot);
            this.Controls.Add(this.ButtonSpin);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblTrigger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lblBullet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBullet;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrigger;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonSpin;
        private System.Windows.Forms.Button ButtonShoot;
        private System.Windows.Forms.Button ButtonTry;
        private System.Windows.Forms.Button button1;
    }
}

