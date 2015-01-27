﻿namespace BattleShipClient
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_DisplayMessages = new System.Windows.Forms.ListBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbWriteChat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnDestory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbShip1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShip2 = new System.Windows.Forms.Label();
            this.lbShip3 = new System.Windows.Forms.Label();
            this.lbShip4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSelectedSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(611, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 353);
            this.panel3.TabIndex = 37;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(255, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 353);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imageedit_3_5609478924.gif");
            this.imageList1.Images.SetKeyName(1, "QQ截图20141215232626.png");
            this.imageList1.Images.SetKeyName(2, "QQ截图201412152326261.png");
            // 
            // lb_DisplayMessages
            // 
            this.lb_DisplayMessages.BackColor = System.Drawing.Color.LightGray;
            this.lb_DisplayMessages.FormattingEnabled = true;
            this.lb_DisplayMessages.Location = new System.Drawing.Point(208, 418);
            this.lb_DisplayMessages.Name = "lb_DisplayMessages";
            this.lb_DisplayMessages.Size = new System.Drawing.Size(646, 95);
            this.lb_DisplayMessages.TabIndex = 45;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(750, 523);
            this.btSend.Margin = new System.Windows.Forms.Padding(2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(104, 46);
            this.btSend.TabIndex = 44;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbWriteChat
            // 
            this.tbWriteChat.Location = new System.Drawing.Point(208, 523);
            this.tbWriteChat.Margin = new System.Windows.Forms.Padding(2);
            this.tbWriteChat.Multiline = true;
            this.tbWriteChat.Name = "tbWriteChat";
            this.tbWriteChat.Size = new System.Drawing.Size(538, 44);
            this.tbWriteChat.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReady);
            this.groupBox1.Controls.Add(this.btnNewGame);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 157);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Menu";
            // 
            // btnReady
            // 
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReady.Location = new System.Drawing.Point(16, 33);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(118, 34);
            this.btnReady.TabIndex = 24;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNewGame.Location = new System.Drawing.Point(16, 73);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(118, 34);
            this.btnNewGame.TabIndex = 27;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStop.Location = new System.Drawing.Point(16, 113);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(118, 34);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop Game";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(164, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(20, 29);
            this.lbName.TabIndex = 56;
            this.lbName.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "Welcome";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "QQ截图20141215232626.png");
            this.imageList2.Images.SetKeyName(1, "QQ截图201412152326261.png");
            this.imageList2.Images.SetKeyName(2, "QQ截图20141215232626 - Copy.png");
            this.imageList2.Images.SetKeyName(3, "green-o-md.png");
            this.imageList2.Images.SetKeyName(4, "download.jpg");
            // 
            // btnDestory
            // 
            this.btnDestory.Image = ((System.Drawing.Image)(resources.GetObject("btnDestory.Image")));
            this.btnDestory.Location = new System.Drawing.Point(30, 536);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(72, 73);
            this.btnDestory.TabIndex = 6;
            this.btnDestory.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(41, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 92);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(76, 126);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(76, 160);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbShip1
            // 
            this.lbShip1.AutoSize = true;
            this.lbShip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShip1.Location = new System.Drawing.Point(26, 58);
            this.lbShip1.Name = "lbShip1";
            this.lbShip1.Size = new System.Drawing.Size(29, 22);
            this.lbShip1.TabIndex = 15;
            this.lbShip1.Text = "4x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Remaining: ";
            // 
            // lbShip2
            // 
            this.lbShip2.AutoSize = true;
            this.lbShip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShip2.Location = new System.Drawing.Point(26, 92);
            this.lbShip2.Name = "lbShip2";
            this.lbShip2.Size = new System.Drawing.Size(29, 22);
            this.lbShip2.TabIndex = 15;
            this.lbShip2.Text = "3x";
            // 
            // lbShip3
            // 
            this.lbShip3.AutoSize = true;
            this.lbShip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShip3.Location = new System.Drawing.Point(26, 126);
            this.lbShip3.Name = "lbShip3";
            this.lbShip3.Size = new System.Drawing.Size(29, 22);
            this.lbShip3.TabIndex = 15;
            this.lbShip3.Text = "2x";
            // 
            // lbShip4
            // 
            this.lbShip4.AutoSize = true;
            this.lbShip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShip4.Location = new System.Drawing.Point(26, 160);
            this.lbShip4.Name = "lbShip4";
            this.lbShip4.Size = new System.Drawing.Size(29, 22);
            this.lbShip4.TabIndex = 15;
            this.lbShip4.Text = "1x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ship length selected: ";
            // 
            // lbSelectedSize
            // 
            this.lbSelectedSize.AutoSize = true;
            this.lbSelectedSize.Location = new System.Drawing.Point(118, 20);
            this.lbSelectedSize.Name = "lbSelectedSize";
            this.lbSelectedSize.Size = new System.Drawing.Size(31, 13);
            this.lbSelectedSize.TabIndex = 17;
            this.lbSelectedSize.Text = "none";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbHorizontal);
            this.panel1.Controls.Add(this.rbVertical);
            this.panel1.Controls.Add(this.lbSelectedSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbShip4);
            this.panel1.Controls.Add(this.lbShip3);
            this.panel1.Controls.Add(this.lbShip2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbShip1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDestory);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 236);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select orientation of ship to be added:";
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Location = new System.Drawing.Point(30, 216);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rbHorizontal.TabIndex = 18;
            this.rbHorizontal.Text = "Horizontal";
            this.rbHorizontal.UseVisualStyleBackColor = true;
            // 
            // rbVertical
            // 
            this.rbVertical.AutoSize = true;
            this.rbVertical.Location = new System.Drawing.Point(108, 216);
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size(60, 17);
            this.rbVertical.TabIndex = 18;
            this.rbVertical.Text = "Vertical";
            this.rbVertical.UseVisualStyleBackColor = true;
            // 
            // Battle_Ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 596);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_DisplayMessages);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbWriteChat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Battle_Ship";
            this.Text = "Battle_Ship";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lb_DisplayMessages;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbWriteChat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbShip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbShip2;
        private System.Windows.Forms.Label lbShip3;
        private System.Windows.Forms.Label lbShip4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSelectedSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.RadioButton rbVertical;
    }
}