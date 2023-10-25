
namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.btnPosudiKnjigu = new System.Windows.Forms.Button();
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.cmbKnjige = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(154, 34);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(141, 23);
            this.btnDodajKorisnika.TabIndex = 0;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Location = new System.Drawing.Point(29, 34);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.Size = new System.Drawing.Size(100, 23);
            this.txtImeKorisnika.TabIndex = 1;
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(305, 84);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(141, 23);
            this.btnDodajKnjigu.TabIndex = 2;
            this.btnDodajKnjigu.Text = "Dodaj Knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Location = new System.Drawing.Point(29, 84);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(100, 23);
            this.txtSerijskiBroj.TabIndex = 3;
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(154, 84);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(136, 23);
            this.txtNazivKnjige.TabIndex = 4;
            // 
            // btnPosudiKnjigu
            // 
            this.btnPosudiKnjigu.Location = new System.Drawing.Point(305, 229);
            this.btnPosudiKnjigu.Name = "btnPosudiKnjigu";
            this.btnPosudiKnjigu.Size = new System.Drawing.Size(141, 23);
            this.btnPosudiKnjigu.TabIndex = 5;
            this.btnPosudiKnjigu.Text = "Posudi knjigu";
            this.btnPosudiKnjigu.UseVisualStyleBackColor = true;
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(29, 229);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(121, 23);
            this.cmbKorisnici.TabIndex = 6;
            // 
            // cmbKnjige
            // 
            this.cmbKnjige.FormattingEnabled = true;
            this.cmbKnjige.Location = new System.Drawing.Point(169, 229);
            this.cmbKnjige.Name = "cmbKnjige";
            this.cmbKnjige.Size = new System.Drawing.Size(121, 23);
            this.cmbKnjige.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbKnjige);
            this.Controls.Add(this.cmbKorisnici);
            this.Controls.Add(this.btnPosudiKnjigu);
            this.Controls.Add(this.txtNazivKnjige);
            this.Controls.Add(this.txtSerijskiBroj);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.Button btnPosudiKnjigu;
        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.ComboBox cmbKnjige;
    }
}

