namespace Gra3
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
            this.components = new System.ComponentModel.Container();
            this.boisko = new System.Windows.Forms.Panel();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.paletka = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.boisko.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).BeginInit();
            this.SuspendLayout();
            // 
            // boisko
            // 
            this.boisko.Controls.Add(this.pilka);
            this.boisko.Controls.Add(this.paletka);
            this.boisko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boisko.Location = new System.Drawing.Point(0, 0);
            this.boisko.Name = "boisko";
            this.boisko.Size = new System.Drawing.Size(622, 369);
            this.boisko.TabIndex = 0;
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.Red;
            this.pilka.Location = new System.Drawing.Point(288, 135);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(25, 25);
            this.pilka.TabIndex = 1;
            this.pilka.TabStop = false;
            // 
            // paletka
            // 
            this.paletka.BackColor = System.Drawing.Color.Black;
            this.paletka.Location = new System.Drawing.Point(208, 293);
            this.paletka.Name = "paletka";
            this.paletka.Size = new System.Drawing.Size(200, 20);
            this.paletka.TabIndex = 0;
            this.paletka.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.boisko);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.boisko.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boisko;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox paletka;
        private System.Windows.Forms.Timer timer1;
    }
}

