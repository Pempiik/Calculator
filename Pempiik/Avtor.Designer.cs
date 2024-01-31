namespace Pempiik
{
    partial class Avtor
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
            this.glazz = new System.Windows.Forms.PictureBox();
            this.krest = new System.Windows.Forms.PictureBox();
            this.loginn = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.ymen1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glazz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginn)).BeginInit();
            this.SuspendLayout();
            // 
            // glazz
            // 
            this.glazz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glazz.Image = global::Pempiik.Properties.Resources.photo_5305458571607135193_x;
            this.glazz.Location = new System.Drawing.Point(630, 341);
            this.glazz.Name = "glazz";
            this.glazz.Size = new System.Drawing.Size(41, 43);
            this.glazz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.glazz.TabIndex = 20;
            this.glazz.TabStop = false;
            this.glazz.Click += new System.EventHandler(this.glazz_Click);
            // 
            // krest
            // 
            this.krest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krest.Image = global::Pempiik.Properties.Resources.photo_5301216479653515989_m;
            this.krest.Location = new System.Drawing.Point(789, 11);
            this.krest.Name = "krest";
            this.krest.Size = new System.Drawing.Size(34, 34);
            this.krest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.krest.TabIndex = 19;
            this.krest.TabStop = false;
            this.krest.Click += new System.EventHandler(this.krest_Click);
            // 
            // loginn
            // 
            this.loginn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginn.Image = global::Pempiik.Properties.Resources.photo_5301216479653515990_x;
            this.loginn.Location = new System.Drawing.Point(296, 438);
            this.loginn.Name = "loginn";
            this.loginn.Size = new System.Drawing.Size(236, 65);
            this.loginn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginn.TabIndex = 18;
            this.loginn.TabStop = false;
            this.loginn.Click += new System.EventHandler(this.loginn_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(281, 341);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(334, 43);
            this.pass.TabIndex = 17;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(281, 202);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(334, 43);
            this.login.TabIndex = 16;
            // 
            // ymen1
            // 
            this.ymen1.AutoSize = true;
            this.ymen1.BackColor = System.Drawing.Color.Transparent;
            this.ymen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ymen1.Font = new System.Drawing.Font("TS Remarker", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ymen1.ForeColor = System.Drawing.Color.White;
            this.ymen1.Location = new System.Drawing.Point(230, 546);
            this.ymen1.Name = "ymen1";
            this.ymen1.Size = new System.Drawing.Size(359, 45);
            this.ymen1.TabIndex = 15;
            this.ymen1.Text = "У меня еще нет аккаунта";
            this.ymen1.Click += new System.EventHandler(this.ymen1_Click);
            this.ymen1.MouseEnter += new System.EventHandler(this.ymen1_MouseEnter);
            this.ymen1.MouseLeave += new System.EventHandler(this.ymen1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TS Remarker", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(373, 90);
            this.label1.TabIndex = 14;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pempiik.Properties.Resources.photo_5301216479653515738_y;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 623);
            this.Controls.Add(this.glazz);
            this.Controls.Add(this.krest);
            this.Controls.Add(this.loginn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.ymen1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avtor";
            this.Text = "Avtor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avtor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avtor_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.glazz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox glazz;
        private System.Windows.Forms.PictureBox krest;
        private System.Windows.Forms.PictureBox loginn;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label ymen1;
        private System.Windows.Forms.Label label1;
    }
}