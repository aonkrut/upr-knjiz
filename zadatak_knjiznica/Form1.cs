using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace zadatak_knjiznica {
    public partial class Form1 : Form {
        private Knjiznica knjiznica;
        private List<Korisnik> korisnici;
        private List<Gradja> gradja;

        public Form1()
        {
            InitializeComponent();
            knjiznica = new Knjiznica();
            korisnici = new List<Korisnik>();
            gradja = new List<Gradja>();
            DodajPocetnePodatke();
            cmbKorisnici.DataSource = korisnici;
            cmbKorisnici.DisplayMember = "Ime";
            cmbKnjige.DataSource = gradja;
            cmbKnjige.DisplayMember = "Naziv";
            
        }
        private void DodajPocetnePodatke()
        {
            
            korisnici.Add(new Korisnik(1, "Marko"));
            korisnici.Add(new Korisnik(2, "Ana"));

            gradja.Add(new Gradja(1, "Harry Potter"));
            gradja.Add(new Gradja(2, "Lord of the Rings"));
        }
        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = txtImeKorisnika.Text;
                Korisnik noviKorisnik = new Korisnik(korisnici.Count + 1, ime);
                korisnici.Add(noviKorisnik);

                cmbKorisnici.DataSource = null;
                cmbKorisnici.DataSource = korisnici;
                cmbKorisnici.DisplayMember = "Ime";
                txtImeKorisnika.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom dodavanja korisnika: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class Knjiznica {
            private List<Gradja> gradja;
            private List<Korisnik> korisnici;

            public Knjiznica()
            {
                gradja = new List<Gradja>();
                korisnici = new List<Korisnik>();
            }

            public void PosudiKnjigu(Korisnik korisnik, Gradja knjiga)
            {
                if (knjiga.Posuđena)
                {
                    MessageBox.Show("Knjiga već posuđena.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    knjiga.Zaduzi(korisnik);
                    
                }
            }
        }

        class Gradja {
            public int SerijskiBroj { get; set; }
            public string Naziv { get; set; }
            public Korisnik PosuđenoKod { get; set; }
            public bool Posuđena { get; set; }

            public Gradja(int serijskiBroj, string naziv)
            {
                SerijskiBroj = serijskiBroj;
                Naziv = naziv;
            }

            public bool Zaduzi(Korisnik korisnik)
            {
                if (!Posuđena)
                {
                    PosuđenoKod = korisnik;
                    Posuđena = true; 
                    return true;
                }
                return false;
            }
        }

        class Korisnik {
            public int Id { get; set; }
            public string Ime { get; set; }

            public Korisnik(int id, string ime)
            {
                Id = id;
                Ime = ime;
            }

            public override string ToString()
            {
                return Ime;
            }
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                int serijskiBroj = Convert.ToInt32(txtSerijskiBroj.Text);
                string naziv = txtNazivKnjige.Text;

                if (gradja.Any(g => g.SerijskiBroj == serijskiBroj))
                {
                    if (gradja.Any(g => g.SerijskiBroj == serijskiBroj))
                    {
                        MessageBox.Show("Serijski broj već postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                if (naziv == "")
                {
                       MessageBox.Show("Molimo unesite naziv knjige.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       return;
                 
                }

                Gradja novaKnjiga = new Gradja(serijskiBroj, naziv);
                gradja.Add(novaKnjiga);

                cmbKnjige.DataSource = null;
                cmbKnjige.DataSource = gradja;
                cmbKnjige.DisplayMember = "Naziv";
                txtSerijskiBroj.Text = "";
                txtNazivKnjige.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom dodavanja knjige: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPosudiKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik odabraniKorisnik = (Korisnik)cmbKorisnici.SelectedItem;
                Gradja odabranaKnjiga = (Gradja)cmbKnjige.SelectedItem;

                if (odabraniKorisnik != null)
                {
                    if (odabranaKnjiga != null)
                    {
                        if (!odabranaKnjiga.Posuđena)
                        {
                            knjiznica.PosudiKnjigu(odabraniKorisnik, odabranaKnjiga);
                            MessageBox.Show("Knjiga uspješno posuđena.", "Info", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Knjiga je već posuđena", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Odaberite knjigu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Odaberite korisnika", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom posuđivanja knjige. Detalji pogreške: " + ex.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
