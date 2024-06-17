using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incercare_licenta.FormDetinuti
{
    public partial class UserControlDubluClick : UserControl
    {
        protected string CNPDetinutFisier = "";
        protected string nume = "", prenume = "", fapta = "", stare = "", poza = "", celula = "";
        protected int durata = 0;
        protected DateTime? dataInregistrare = null;
        protected DateTime? dataEliberare = null;
        private int locuriLibere;
        private int capacitateMaxima;

        private void butonResetare_Click(object sender, EventArgs e)
        {
            textBoxIntroducerePoza.Text = null;
            textBoxIntroducereNume.Text = nume;
            textBoxIntroducerePrenume.Text = prenume;
            textBoxIntroducereFapta.Text = fapta;
            textBoxIntroducereCNP.Text = CNPDetinutFisier;
            comboBoxStare.SelectedItem = stare;
            textBoxIntroducereSentinta.Text = Convert.ToString(durata);
            comboBoxCelula.Text = celula;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Selectați o imagine";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caleImagine = openFileDialog.FileName;
                textBoxIntroducerePoza.Text = caleImagine;
            }
        }

        private void butonActualizareDetinut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIntroducereCNP.Text))
            {
                MessageBox.Show("Introduceți CNP-ul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereCNP.Focus(); // Păstrăm focusul pe textBox pentru a putea introduce CNP-ul
                return;
            }

            if (textBoxIntroducereCNP.Text.Length != 13)
            {
                MessageBox.Show("CNP-ul trebuie să conțină exact 13 cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereCNP.Focus(); // Păstrăm focusul pe textBox pentru a putea introduce CNP-ul
                return;
            }

            if (!textBoxIntroducereCNP.Text.All(char.IsDigit))
            {
                MessageBox.Show("CNP-ul trebuie să conțină doar cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereCNP.Focus();
                return;
            }
            if (!textBoxIntroducereNume.Text.All(char.IsLetter))
            {
                MessageBox.Show("Numele trebuie să conțină doar litere.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereNume.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxIntroducereNume.Text))
            {
                MessageBox.Show("Introduceți numele detinutului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereNume.Focus();
                return;
            }

            if (!Regex.IsMatch(textBoxIntroducerePrenume.Text, @"^[a-zA-Z\-]+$"))
            {
                MessageBox.Show("Prenumele trebuie să conțină doar litere și caracterul -.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducerePrenume.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxIntroducerePrenume.Text))
            {
                MessageBox.Show("Introduceți prenumele detinutului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducerePrenume.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxIntroducereFapta.Text))
            {
                MessageBox.Show("Introduceți fapta pe care a comis-o detinutul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereFapta.Focus();
                return;
            }
            if (comboBoxStare.SelectedItem?.ToString() == "INCARCERAT" && string.IsNullOrWhiteSpace(comboBoxCelula.Text))
            {
                MessageBox.Show("Selectați o celulă pentru detinutul incarcerat.", "Eroare introducere celula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCelula.Focus();
                return;
            }
            if (!int.TryParse(textBoxIntroducereSentinta.Text, out int luni) || luni < 0)
            {
                MessageBox.Show("Introduceți un numar valid de luni (un număr întreg mai mare decât 0).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereSentinta.Focus();
                return;
            }
            string dataInregistrareText = textBoxIntroducereDataInregistrare.Text;

            // Definim formatul corect al datei
            string formatData = "yyyy-MM-dd";

            // Definim expresia regulată pentru a verifica formatul datei
            Regex regex = new Regex(@"^\d{4}-\d{2}-\d{2}$");

            // Verificăm dacă textul introdus corespunde formatului datei și dacă poate fi parsat într-o dată
            if (!regex.IsMatch(dataInregistrareText) || !DateTime.TryParseExact(dataInregistrareText, formatData, null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Introduceți o dată validă în formatul YYYY-MM-DD.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereDataInregistrare.Focus();
                return;
            }

            string connString = "Data Source=xe;User ID=student;Password=student;";
            OracleConnection conn = new OracleConnection(connString);
            try
            {
                conn.Open();

                byte[] pozaBytes = null;
                string pozaPath = textBoxIntroducerePoza.Text;

                // Verificăm dacă calea specificată este validă
                if (!string.IsNullOrEmpty(pozaPath) && File.Exists(pozaPath))
                {
                    pozaBytes = File.ReadAllBytes(pozaPath);
                }
                else if (!string.IsNullOrEmpty(pozaPath))
                {
                    MessageBox.Show("Calea specificată pentru poză nu este validă.", "Atenție la poza introdusă", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string updateQuery = $@"UPDATE Detinut 
                    SET Nume = '{textBoxIntroducereNume.Text}', 
                        Prenume = '{textBoxIntroducerePrenume.Text}',
                        Fapta ='{textBoxIntroducereFapta.Text}',
                        CNP = '{textBoxIntroducereCNP.Text}',
                        Durata_sentinta = '{textBoxIntroducereSentinta.Text}',
                        Data_Inregistrare = TO_DATE('{textBoxIntroducereDataInregistrare.Text}', 'YYYY-MM-DD'),
                        Stare = '{comboBoxStare.SelectedItem}',
                        Celula = '{comboBoxCelula.SelectedItem}'";
                if (!string.IsNullOrEmpty(pozaPath))
                {
                    updateQuery += ", Poza = :pozaParameter";
                }

                updateQuery += $" WHERE CNP = '{CNPDetinutFisier}'";

                // Creăm obiectul OracleCommand
                OracleCommand cmd = new OracleCommand(updateQuery, conn);

                // Adăugăm parametrul pentru imagine dacă este specificată o cale pentru poza
                if (!string.IsNullOrEmpty(pozaPath))
                {
                    // Adăugăm parametrul pentru imagine
                    OracleParameter pozaParameter = new OracleParameter(":pozaParameter", OracleType.Blob);
                    if (pozaBytes != null)
                    {
                        pozaParameter.Value = pozaBytes;
                    }
                    else
                    {
                        pozaParameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(pozaParameter);
                }

                // Executăm interogarea de actualizare
                int rowsAffected = cmd.ExecuteNonQuery();

                // Verificăm dacă s-au actualizat rânduri și afișăm un mesaj corespunzător
                if (rowsAffected > 0)
                {
                    if (comboBoxCelula.SelectedItem != null && comboBoxCelula.SelectedItem.ToString() != celula)
                    {
                        ActualizareNumarLocuriDisponibile(celula, comboBoxCelula.SelectedItem.ToString());
                    }
                    IncarcareDate();
                    MessageBox.Show("Actualizare reușită!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nu s-au efectuat modificări.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OracleException ex)
            {
                // Tratarea excepțiilor legate de baza de date
                MessageBox.Show("Eroare Oracle: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tratarea altor excepții
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Închidem conexiunea
                conn.Close();
            }
        }


        public UserControlDubluClick()
        {
            InitializeComponent();
            CNPDetinutFisier = File.ReadLines(@"C:\Users\Edy\Desktop\Licenta\InfoDetinut.txt").First();
            comboBoxCelula.Visible = false;
            label9.Visible = false;
        }

        private void comboBoxStare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStare.SelectedItem != null)
            {
                string valoareSelectata = comboBoxStare.SelectedItem.ToString();
                comboBoxCelula.Items.Clear();
                if (valoareSelectata == "INCARCERAT")
                {
                    label9.Visible = true;
                    comboBoxCelula.Visible = true;
                    IncarcaCeluleDisponibile();
                }
                else
                {
                    label9.Visible = false;
                    comboBoxCelula.Visible = false;
                }
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContinutCentral.Controls.Clear();
            panelContinutCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void butonExit_Click_1(object sender, EventArgs e)
        {
            UserControlDetinuti_Cautare Detinuti = new UserControlDetinuti_Cautare();
            addUserControl(Detinuti);
        }

        private void UserControlDubluClick_Load(object sender, EventArgs e)
        {
            IncarcareDate();
        }
        private void IncarcareDate()
        {
            Console.WriteLine(CNPDetinutFisier);
            string connString = "Data Source=xe;User ID=student;Password=student;";
            OracleConnection conn = new OracleConnection(connString);

            try
            {
                conn.Open();
                string query = $"SELECT Nume,Prenume,Fapta,Durata_Sentinta,Data_Inregistrare,Data_Eliberare,Stare,Celula,Poza FROM Detinut WHERE CNP = '{CNPDetinutFisier}'";
                OracleCommand cmd = new OracleCommand(query, conn);

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nume = reader["Nume"].ToString();
                        prenume = reader["Prenume"].ToString();
                        fapta = reader["Fapta"].ToString();
                        durata = Convert.ToInt32(reader["Durata_Sentinta"]);
                        stare = reader["Stare"].ToString();
                        celula = reader["Celula"].ToString();
                        dataInregistrare = reader["Data_Inregistrare"] == DBNull.Value ? null : (DateTime?)reader["Data_Inregistrare"];
                        dataEliberare = reader["Data_Eliberare"] == DBNull.Value ? null : (DateTime?)reader["Data_Eliberare"];

                        textBoxIntroducereSentinta.Text = Convert.ToString(durata);
                        labelNume.Text = "Nume: " + nume;
                        textBoxIntroducereNume.Text = nume;
                        labelPrenume.Text = "Prenume: " + prenume;
                        textBoxIntroducerePrenume.Text = prenume;
                        labelFapta.Text = "Fapta: " + fapta;
                        textBoxIntroducereFapta.Text = fapta;
                        labelCNP.Text = "CNP: " + CNPDetinutFisier;
                        textBoxIntroducereCNP.Text = CNPDetinutFisier;
                        labelStare.Text = "Stare: " + stare;
                        comboBoxStare.SelectedItem = stare;
                        textBoxIntroducereDataInregistrare.Text = dataInregistrare.HasValue ? dataInregistrare.Value.ToString("yyyy-MM-dd") : "";

                        if (stare == "LIBER" || stare == "ARESTAT")
                        {
                            labelDetinutCelula.Text = "Deținutul nu se află în nicio celulă în prezent.";
                            label9.Visible = false;
                            comboBoxCelula.Visible = false;
                            labelCapacitateMaxima.Visible = false;
                            labelLocuriCelula.Visible = false;
                        }
                        else if (!string.IsNullOrWhiteSpace(celula))
                        {
                            try
                            {
                                string queryCelula = $"SELECT Locuri_Libere, Locuri_Maxim FROM Celula WHERE Denumire = '{celula}'";
                                OracleCommand cmdCelula = new OracleCommand(queryCelula, conn);

                                using (OracleDataReader readerCelula = cmdCelula.ExecuteReader())
                                {
                                    if (readerCelula.Read())
                                    {
                                        locuriLibere = readerCelula.GetInt32(0);
                                        capacitateMaxima = readerCelula.GetInt32(1);
                                    }
                                }
                            }
                            catch (OracleException ex)
                            {
                                Console.WriteLine("Eroare Oracle: " + ex.Message);
                            }
                            labelDetinutCelula.Visible = true;
                            labelLocuriCelula.Visible = true;
                            labelCapacitateMaxima.Visible = true;
                            labelDetinutCelula.Text = "Deținutul se află în celula " + celula;
                            labelLocuriCelula.Text = "În celulă mai sunt " + locuriLibere + " locuri libere.";
                            labelCapacitateMaxima.Text = "Celula are o capacitate maximă de " + capacitateMaxima + " deținuți.";
                            comboBoxCelula.Text = celula;
                        }

                        if (durata > 0)
                        {
                            labelSentinta.Text = "Durată sentință: " + durata + " luni";
                        }
                        else
                            labelSentinta.Text = "Sentința încă nu a fost propusă!";

                        TimeSpan diff;
                        if (dataEliberare.HasValue)
                        {
                            diff = dataEliberare.Value.Date - DateTime.Today;
                        }
                        else
                        {
                            diff = TimeSpan.Zero;
                        }

                        string statusEliberare;
                        if (diff.TotalDays == 0)
                        {
                            statusEliberare = "Liber";
                        }
                        else
                        if(diff.TotalDays < 0)
                        {
                            statusEliberare = "Deținutul și-a săvârșit pedeapsa";

                        }
                        else
                        {
                            statusEliberare = diff.TotalDays.ToString() + " zile  rămase";
                        }
                        labelStatusEliberare.Text = "Status eliberare: " + statusEliberare;

                        // Adăugăm și celelalte informații
                        if (dataInregistrare.HasValue)
                        {
                            labelDataInregistrare.Text = "Dată înregistrare: " + dataInregistrare.Value.ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            labelDataInregistrare.Text = "Dată înregistrare: -";
                        }

                        if (dataEliberare.HasValue)
                        {
                            labelDataEliberare.Text = "Dată eliberare: " + dataEliberare.Value.ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            labelDataEliberare.Text = "Dată eliberare: -";
                        }

                        // Afisam poza detinutului in PictureBox
                        if (reader["Poza"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["Poza"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBoxPoza.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            labelPoza.Text = " Deținutul nu are poză de profil.";
                            pictureBoxPoza.Image = null;
                            //pictureBoxPoza.Image = Properties.Resources.DefaultImage; // Înlocuiți DefaultImage cu imaginea implicită dorită
                        }

                        Console.WriteLine("Nume: " + nume);
                        Console.WriteLine("Prenume: " + prenume);
                        Console.WriteLine("Fapta: " + fapta);
                    }
                    else
                    {
                        Console.WriteLine("Nu s-au găsit date pentru deținutul specificat.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.ToString());
            }

            labelTitlu.Text = "Profilul deținutului " + nume + " " + prenume;

        }
        private void ActualizareNumarLocuriDisponibile(string celulaInitiala, string celulaFinala)
        {
            if (celulaInitiala == celulaFinala)
                Console.WriteLine("Deținutul a rămas în aceeași celulă!");
            else
            {
                string connString = "Data Source=xe;User ID=student;Password=student;";
                OracleConnection conn = new OracleConnection(connString);

                try
                {
                    conn.Open();

                    // Actualizare număr de locuri disponibile pentru celula inițială
                    string updateCelulaInitialaQuery = $"UPDATE Celula SET Locuri_Libere = Locuri_Libere + 1 WHERE Denumire = '{celulaInitiala}'";
                    OracleCommand cmdInitiala = new OracleCommand(updateCelulaInitialaQuery, conn);
                    cmdInitiala.ExecuteNonQuery();

                    // Actualizare număr de locuri disponibile pentru celula finală
                    string updateCelulaFinalaQuery = $"UPDATE Celula SET Locuri_Libere = Locuri_Libere - 1 WHERE Denumire = '{celulaFinala}'";
                    OracleCommand cmdFinala = new OracleCommand(updateCelulaFinalaQuery, conn);
                    cmdFinala.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la actualizarea numărului de locuri disponibile pentru celule: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void IncarcaCeluleDisponibile()
        {
            string connString = "Data Source=xe;User ID=student;Password=student;"; // Stringul de conexiune la baza de date

            string query = "SELECT Denumire FROM Celula WHERE Locuri_libere > 0"; // Interogare pentru a selecta numele celulelor cu Locuri_libere diferite de 0

            // Utilizăm o conexiune Oracle și un obiect de comandă Oracle pentru a executa interogarea
            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open(); // Deschideți conexiunea

                    // Creăm un obiect de comandă cu interogarea și conexiunea asociată
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        // Utilizăm un cititor de date Oracle pentru a citi rezultatele interogării
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Parcurgem fiecare rând din rezultatele interogării
                            while (reader.Read())
                            {
                                // Adăugăm numele celulelor la comboBoxCelula
                                comboBoxCelula.Items.Add(reader["Denumire"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}