namespace BattleShipClient
{
    partial class Battle_Ship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle_Ship));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnOnlonePlayers = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDestory = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(493, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 353);
            this.panel3.TabIndex = 37;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(109, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 353);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStop.Location = new System.Drawing.Point(419, 370);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(118, 46);
            this.btnStop.TabIndex = 35;
            this.btnStop.Text = "Stop Game";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReady
            // 
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReady.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReady.Location = new System.Drawing.Point(5, 370);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(118, 46);
            this.btnReady.TabIndex = 31;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewGame.Location = new System.Drawing.Point(129, 370);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(118, 46);
            this.btnNewGame.TabIndex = 34;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // btnOnlonePlayers
            // 
            this.btnOnlonePlayers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOnlonePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOnlonePlayers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOnlonePlayers.Location = new System.Drawing.Point(253, 370);
            this.btnOnlonePlayers.Name = "btnOnlonePlayers";
            this.btnOnlonePlayers.Size = new System.Drawing.Size(160, 46);
            this.btnOnlonePlayers.TabIndex = 33;
            this.btnOnlonePlayers.Text = "Online Players";
            this.btnOnlonePlayers.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(52, 99);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDestory);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 201);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 99);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(30, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destory";
            // 
            // btnDestory
            // 
            this.btnDestory.Image = ((System.Drawing.Image)(resources.GetObject("btnDestory.Image")));
            this.btnDestory.Location = new System.Drawing.Point(19, 530);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(72, 73);
            this.btnDestory.TabIndex = 6;
            this.btnDestory.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imageedit_3_5609478924.gif");
            this.imageList1.Images.SetKeyName(1, "QQ截图20141215232626.png");
            this.imageList1.Images.SetKeyName(2, "QQ截图201412152326261.png");
            // 
            // Battle_Ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnOnlonePlayers);
            this.Controls.Add(this.panel1);
            this.Name = "Battle_Ship";
            this.Text = "Battle_Ship";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnOnlonePlayers;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.ImageList imageList1;
    }
}