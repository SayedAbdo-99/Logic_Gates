﻿namespace Logic_Gates
{
    partial class Not_Form
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
            this.checkBox_OR_A = new System.Windows.Forms.CheckBox();
            this.pictureBox_Not = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Not1 = new System.Windows.Forms.PictureBox();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Not)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Not1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "NOT Gate";
            // 
            // checkBox_OR_A
            // 
            this.checkBox_OR_A.AutoSize = true;
            this.checkBox_OR_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox_OR_A.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_OR_A.ForeColor = System.Drawing.Color.Black;
            this.checkBox_OR_A.Location = new System.Drawing.Point(71, 251);
            this.checkBox_OR_A.Name = "checkBox_OR_A";
            this.checkBox_OR_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_OR_A.Size = new System.Drawing.Size(48, 33);
            this.checkBox_OR_A.TabIndex = 15;
            this.checkBox_OR_A.Text = "A";
            this.checkBox_OR_A.UseVisualStyleBackColor = false;
            this.checkBox_OR_A.CheckedChanged += new System.EventHandler(this.checkBox_OR_A_CheckedChanged);
            // 
            // pictureBox_Not
            // 
            this.pictureBox_Not.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox_Not.Enabled = false;
            this.pictureBox_Not.Image = global::Logic_Gates.Properties.Resources.lampada_desligada;
            this.pictureBox_Not.Location = new System.Drawing.Point(463, 116);
            this.pictureBox_Not.Name = "pictureBox_Not";
            this.pictureBox_Not.Size = new System.Drawing.Size(453, 302);
            this.pictureBox_Not.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Not.TabIndex = 16;
            this.pictureBox_Not.TabStop = false;
            this.pictureBox_Not.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = global::Logic_Gates.Properties.Resources._220px_NOT_gate1;
            this.pictureBox2.Location = new System.Drawing.Point(125, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_Not1
            // 
            this.pictureBox_Not1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox_Not1.Enabled = false;
            this.pictureBox_Not1.Image = global::Logic_Gates.Properties.Resources.cc7b58cbcd341a19a6545d947e48329b;
            this.pictureBox_Not1.Location = new System.Drawing.Point(463, 116);
            this.pictureBox_Not1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Not1.Name = "pictureBox_Not1";
            this.pictureBox_Not1.Size = new System.Drawing.Size(453, 302);
            this.pictureBox_Not1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Not1.TabIndex = 12;
            this.pictureBox_Not1.TabStop = false;
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.Black;
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Home.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.ForeColor = System.Drawing.Color.White;
            this.Btn_Home.Location = new System.Drawing.Point(11, 452);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(115, 53);
            this.Btn_Home.TabIndex = 27;
            this.Btn_Home.Text = "Back";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Black;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(899, 452);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(115, 53);
            this.Btn_Exit.TabIndex = 26;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Not_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1026, 517);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Not);
            this.Controls.Add(this.checkBox_OR_A);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_Not1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Not_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Not)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Not1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Not;
        private System.Windows.Forms.CheckBox checkBox_OR_A;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_Not1;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Button Btn_Exit;
    }
}