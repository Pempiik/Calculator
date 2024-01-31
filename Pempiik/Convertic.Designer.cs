namespace Pempiik
{
    partial class Convertic
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
            this.iz = new System.Windows.Forms.TextBox();
            this.perevesti = new System.Windows.Forms.Button();
            this.resul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chislo = new System.Windows.Forms.TextBox();
            this.avtor = new System.Windows.Forms.Label();
            this.krest = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.krest)).BeginInit();
            this.SuspendLayout();
            // 
            // iz
            // 
            this.iz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iz.Location = new System.Drawing.Point(578, 336);
            this.iz.Multiline = true;
            this.iz.Name = "iz";
            this.iz.Size = new System.Drawing.Size(77, 43);
            this.iz.TabIndex = 37;
            // 
            // perevesti
            // 
            this.perevesti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perevesti.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perevesti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.perevesti.Location = new System.Drawing.Point(105, 540);
            this.perevesti.Name = "perevesti";
            this.perevesti.Size = new System.Drawing.Size(252, 69);
            this.perevesti.TabIndex = 36;
            this.perevesti.Text = "Перевести";
            this.perevesti.UseVisualStyleBackColor = true;
            this.perevesti.Click += new System.EventHandler(this.perevesti_Click);
            // 
            // resul
            // 
            this.resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resul.Location = new System.Drawing.Point(861, 336);
            this.resul.Multiline = true;
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(356, 43);
            this.resul.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(940, 245);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(217, 65);
            this.label4.TabIndex = 34;
            this.label4.Text = "Результат:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v.Location = new System.Drawing.Point(318, 425);
            this.v.Multiline = true;
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(77, 43);
            this.v.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(52, 413);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(248, 65);
            this.label2.TabIndex = 32;
            this.label2.Text = "Перевести в";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 325);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(472, 65);
            this.label1.TabIndex = 31;
            this.label1.Text = "Его система счисления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chislo
            // 
            this.chislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo.Location = new System.Drawing.Point(376, 255);
            this.chislo.Multiline = true;
            this.chislo.Name = "chislo";
            this.chislo.Size = new System.Drawing.Size(279, 43);
            this.chislo.TabIndex = 30;
            this.chislo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chislo_KeyPress);
            // 
            // avtor
            // 
            this.avtor.AutoSize = true;
            this.avtor.BackColor = System.Drawing.Color.Transparent;
            this.avtor.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtor.ForeColor = System.Drawing.SystemColors.Control;
            this.avtor.Location = new System.Drawing.Point(52, 245);
            this.avtor.Name = "avtor";
            this.avtor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.avtor.Size = new System.Drawing.Size(305, 65);
            this.avtor.TabIndex = 29;
            this.avtor.Text = "Введите число";
            this.avtor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // krest
            // 
            this.krest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krest.Image = global::Pempiik.Properties.Resources.photo_5301216479653515989_m;
            this.krest.Location = new System.Drawing.Point(1234, 12);
            this.krest.Name = "krest";
            this.krest.Size = new System.Drawing.Size(34, 34);
            this.krest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.krest.TabIndex = 38;
            this.krest.TabStop = false;
            this.krest.Click += new System.EventHandler(this.krest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(508, 33);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(263, 65);
            this.label3.TabIndex = 39;
            this.label3.Text = "Калькулятор";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("TS Remarker", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(452, 116);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(378, 65);
            this.label5.TabIndex = 40;
            this.label5.Text = "систем счисления";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Convertic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pempiik.Properties.Resources.photo_5314590522481954800_y;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.krest);
            this.Controls.Add(this.iz);
            this.Controls.Add(this.perevesti);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chislo);
            this.Controls.Add(this.avtor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convertic";
            this.Text = "Convertic";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Convertic_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Convertic_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.krest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iz;
        private System.Windows.Forms.Button perevesti;
        private System.Windows.Forms.TextBox resul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chislo;
        private System.Windows.Forms.Label avtor;
        private System.Windows.Forms.PictureBox krest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}