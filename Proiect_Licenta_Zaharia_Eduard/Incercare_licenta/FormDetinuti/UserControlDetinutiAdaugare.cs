using Oracle.ManagedDataAccess.Types;
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
    public partial class UserControlDetinutiAdaugare : UserControl
    {
        public UserControlDetinutiAdaugare()
        {
            InitializeComponent();
            labelCelula.Visible = false;
            comboBoxCelula.Visible = false;
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

        private void comboBoxStare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStare.SelectedItem != null)
            {
                string valoareSelectata = comboBoxStare.SelectedItem.ToString();
                comboBoxCelula.Items.Clear();
                if (valoareSelectata == "INCARCERAT")
                {
                    labelCelula.Visible = true;
                    comboBoxCelula.Visible = true;
                    IncarcaCeluleDisponibile();
                }
                else
                {
                    labelCelula.Visible = false;
                    comboBoxCelula.Visible = false;
                }
            }
        }



       private void butonAdaugareDetinut_Click(object sender, EventArgs e)
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
                MessageBox.Show("Introduceți numele deținutului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (comboBoxStare.SelectedItem == null)
            {
                MessageBox.Show("Selectați o stare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxStare.Focus();
                return;
            }

            if (comboBoxStare.SelectedItem != null && comboBoxStare.SelectedItem.ToString() == "INCARCERAT")
            {
                if (comboBoxCelula.SelectedItem == null)
                {
                    MessageBox.Show("Selectați o celulă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxCelula.Focus();
                    return;
                }
            }
            string cel = comboBoxCelula.Text;
            if (!int.TryParse(textBoxAni.Text, out int ani) || ani < 0)
            {
                MessageBox.Show("Introduceți un numar valid de ani (un număr întreg mai mare decât 0).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAni.Focus();
                return;
            }
            if (!int.TryParse(textBoxLuni.Text, out int luni) || luni < 0)
            {
                MessageBox.Show("Introduceți un numar valid de ani (un număr întreg mai mare decât 0).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLuni.Focus();
                return;
            }
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;");
            try
            {
                conn.Open();
                string query = @"INSERT INTO Detinut (CNP, NUME, PRENUME, FAPTA, DURATA_SENTINTA, DATA_INREGISTRARE, DATA_ELIBERARE, STARE, CELULA, POZA) 
VALUES (:p1, :p2, :p3, :p4, :p5, SYSDATE, ADD_MONTHS(SYSDATE, :p5), :p6, :p7, :p8)";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("p1", OracleType.VarChar, 13).Value = textBoxIntroducereCNP.Text;
                cmd.Parameters.Add("p2", OracleType.VarChar, 255).Value = textBoxIntroducereNume.Text;
                cmd.Parameters.Add("p3", OracleType.VarChar, 255).Value = textBoxIntroducerePrenume.Text;
                cmd.Parameters.Add("p4", OracleType.VarChar, 255).Value = textBoxIntroducereFapta.Text;
                cmd.Parameters.Add("p5", OracleType.Int32).Value = (textBoxAni.Text == "" ? 0 : Convert.ToInt32(textBoxAni.Text) * 12) +
                                                                   (textBoxLuni.Text == "" ? 0 : Convert.ToInt32(textBoxLuni.Text));
                cmd.Parameters.Add("p6", OracleType.VarChar, 20).Value = comboBoxStare.Text;
                cmd.Parameters.Add("p7", OracleType.VarChar, 255).Value = comboBoxCelula.Text;
                byte[] pozaBytes = null;
                string pozaPath = textBoxPoza.Text;
                if (!string.IsNullOrEmpty(pozaPath))
                {
                    pozaBytes = File.ReadAllBytes(pozaPath);
                }

                OracleParameter pozaParameter = new OracleParameter("p8", OracleType.Blob);
                if (pozaBytes != null)
                {
                    pozaParameter.Value = pozaBytes;
                }
                else
                {
                    pozaParameter.Value = DBNull.Value;
                }

                cmd.Parameters.Add(pozaParameter);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Detinutul a fost adaugat cu succes!");
                    butonResetare.PerformClick();
                    if (cel != null)
                    {
                        try
                        {
                            // ...Codul anterior care deschide conexiunea și obține datele celulei

                            // Actualizează numărul de locuri libere în tabela Celula
                            string updateQuery = $"UPDATE Celula SET Locuri_Libere = Locuri_Libere - 1 WHERE Denumire = '{cel}'";
                            OracleCommand updateCmd = new OracleCommand(updateQuery, conn);

                            // Execută comanda de actualizare
                            updateCmd.ExecuteNonQuery();
                        }
                        catch (OracleException ex)
                        {
                            // Tratarea excepțiilor legate de baza de date
                            Console.WriteLine("Eroare Oracle: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nu s-a putut adauga detinutul.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void butonIncarcaPoza_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Selectați o imagine";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caleImagine = openFileDialog.FileName;
                textBoxPoza.Text = caleImagine;
            }
        }

        private void butonResetare_Click(object sender, EventArgs e)
        {
            textBoxAni.Text = "";
            textBoxIntroducereCNP.Text = "";
            textBoxIntroducereFapta.Text = "";
            textBoxIntroducereNume.Text = "";
            textBoxIntroducerePrenume.Text = "";
            textBoxLuni.Text = "";
            textBoxPoza.Text = "";
            comboBoxStare.SelectedItem = null;
            comboBoxCelula.SelectedItem = null;
            comboBoxCelula.Items.Clear();

        }
    }
}
