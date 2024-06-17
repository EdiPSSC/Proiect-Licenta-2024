using System;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Incercare_licenta.FormCelule
{
    public partial class UserControlCelule_Celule : UserControl
    {
        public UserControlCelule_Celule()
        {
            InitializeComponent();
            textBoxIntroducereLocuriDisponibile.Visible = false;
            labelLocuriLibere.Visible = false;
        }
        private void Actualizare_DataGridView()
        {
            this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
        }
        private void UserControlCelule_Acasa_Load(object sender, EventArgs e)
        {
            Actualizare_DataGridView();
        }

        private void textBoxCautareCelula_TextChanged(object sender, EventArgs e)
        {
            string variab = "Denumire like " + "'" + textBoxCautareCelula.Text + "*'";
            this.cELULABindingSource.Filter = variab;
        }

        private void butonResetare_Click(object sender, EventArgs e)
        {
            textBoxIntroducereCapacitateMaxima.Text = "";
            textBoxIntroducereDenumireCelula.Text = "";
            textBoxIntroducereLocuriDisponibile.Text = "";
        }

        private void butonAdaugareCelula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIntroducereDenumireCelula.Text))
            {
                MessageBox.Show("Introduceți denumirea celulei.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereDenumireCelula.Focus(); // Păstrăm focusul pe textBox pentru a putea introduce denumirea
                return;
            }

            // Verificăm dacă capacitatea maximă este completată și este un număr valid
            if (!int.TryParse(textBoxIntroducereCapacitateMaxima.Text, out int capacitateMaxima) || capacitateMaxima <= 0)
            {
                MessageBox.Show("Introduceți o capacitate maximă validă (un număr întreg mai mare decât 0).", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIntroducereCapacitateMaxima.Focus(); // Păstrăm focusul pe textBox pentru a putea corecta valoarea
                return;
            }

            // Verificăm dacă denumirea celulei există deja
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string queryVerificare = "SELECT COUNT(*) FROM Celula WHERE denumire = :denumireCelula";
                OracleCommand cmdVerificare = new OracleCommand(queryVerificare, conn);
                cmdVerificare.Parameters.Add("denumireCelula", OracleType.VarChar, 20).Value = textBoxIntroducereDenumireCelula.Text;
                int numarCeluleExistente = Convert.ToInt32(cmdVerificare.ExecuteScalar());

                if (numarCeluleExistente > 0)
                {
                    MessageBox.Show("Denumirea introdusă este deja asociată unei alte celule. Introduceți o altă denumire.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxIntroducereDenumireCelula.Focus(); // Păstrăm focusul pe textBox pentru a putea introduce o altă denumire
                    return;
                }

                // Dacă totul este în regulă, adăugăm celula în baza de date
                string query = "INSERT INTO Celula(denumire, locuri_libere, locuri_maxim) VALUES (:p1, :p2, :p3)";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("p1", OracleType.VarChar, 20).Value = textBoxIntroducereDenumireCelula.Text;
                cmd.Parameters.Add("p2", OracleType.Int32).Value = capacitateMaxima;
                cmd.Parameters.Add("p3", OracleType.Int32).Value = capacitateMaxima;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Celula a fost adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                butonResetare.PerformClick(); // Resetăm câmpurile de introducere
                Actualizare_DataGridView(); // Actualizăm afișarea în dataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare - date invalide: " + ex.ToString(), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void butonActualizareCelula_Click(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True");

            try
            {
                conn.Open();

                // Obținem numărul de deținuți din celula respectivă
                string queryNumarDetinuti = $"SELECT COUNT(*) FROM Detinut WHERE CELULA = '{textBoxIntroducereDenumireCelula.Text}'";
                OracleCommand cmdNumarDetinuti = new OracleCommand(queryNumarDetinuti, conn);
                int numarDetinuti = Convert.ToInt32(cmdNumarDetinuti.ExecuteScalar());

                // Obținem capacitatea maximă actuală a celulei
                string queryCapacitateMaxima = $"SELECT Locuri_Maxim FROM Celula WHERE Denumire = '{textBoxIntroducereDenumireCelula.Text}'";
                OracleCommand cmdCapacitateMaxima = new OracleCommand(queryCapacitateMaxima, conn);
                int capacitateMaximaActuala = Convert.ToInt32(cmdCapacitateMaxima.ExecuteScalar());

                // Obținem capacitatea maximă nouă introdusă de utilizator
                int capacitateMaximaNoua = Convert.ToInt32(textBoxIntroducereCapacitateMaxima.Text);

                // Verificăm dacă noua capacitate maximă este mai mică decât numărul actual de deținuți
                if (capacitateMaximaNoua < numarDetinuti)
                {
                    MessageBox.Show($"Nu puteți reduce capacitatea maximă sub numărul actual de deținuți ({numarDetinuti}) în celulă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculăm numărul de locuri libere
                int locuriLibere = capacitateMaximaNoua - numarDetinuti;

                // Actualizăm numărul de locuri libere în baza de date
                string queryUpdate = $"UPDATE Celula SET Locuri_libere = {locuriLibere}, Locuri_Maxim = '{textBoxIntroducereCapacitateMaxima.Text}' WHERE Denumire = '{textBoxIntroducereDenumireCelula.Text}'";
                OracleCommand commandUpdate = new OracleCommand(queryUpdate, conn);
                commandUpdate.ExecuteNonQuery();

                Actualizare_DataGridView();
                dataGridView1.Refresh();
                butonResetare.PerformClick();

                MessageBox.Show("Modificările au fost salvate cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare în timpul actualizării datelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "lOCURILIBEREDataGridViewTextBoxColumn")
            {
                // Obțineți valoarea din celula corespunzătoare coloanei "LOCURI_LIBERE" pentru rândul curent
                var locuriLibereCellValue = dataGridView1.Rows[e.RowIndex].Cells["lOCURILIBEREDataGridViewTextBoxColumn"].Value;

                // Verificați dacă valoarea nu este null și faceți ceva cu ea
                if (Convert.ToInt32(locuriLibereCellValue) == 0)
                {
                    // Setarea culorii de fundal a celulei la roșu
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                }
            }

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentralCelule.Controls.Clear();
            panelCentralCelule.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string detinutFisier = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    detinutFisier = selectedRow.Cells["dENUMIREDataGridViewTextBoxColumn"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Reincercati sa alegeti un detinut!");
                }

                try
                {
                    string caleFisier = "C:\\Users\\Edy\\Desktop\\Licenta\\InfoCelula.txt";

                    using (StreamWriter sw = new StreamWriter(caleFisier))
                    {
                        sw.WriteLine(detinutFisier);
                    }

                    Console.WriteLine("Datele au fost scrise cu succes în fișier.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("A apărut o eroare: " + ex.Message);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obțineți valoarea din celula pe care s-a produs dublu clicul
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object cellValue = cell.Value;

                if (cellValue != null)
                {
                    UserControlCelulaDubluClick Celule = new UserControlCelulaDubluClick();
                    addUserControl(Celule);
                }
            }
        }

        private void butonStergere_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            DialogResult result = MessageBox.Show("Ești sigur că vrei să ștergi această celulă?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    if (!string.IsNullOrEmpty(textBoxStergere.Text))
                    {
                        string deleteQuery = "DELETE FROM Celula WHERE Denumire = :denumire";
                        OracleCommand deleteCmd = new OracleCommand(deleteQuery, conn);
                        deleteCmd.Parameters.Add("denumire", OracleType.Char, 20).Value = textBoxStergere.Text;

                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Celula a fost ștearsă cu succes!");
                            string Query = "UPDATE Detinut SET STARE='ARESTAT', Celula=null WHERE Celula = :denumire";
                            OracleCommand updateCmd = new OracleCommand(Query, conn);
                            updateCmd.Parameters.Add("denumire", OracleType.Char, 20).Value = textBoxStergere.Text;
                            int rowsAff = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Au fost scosi din celule " + rowsAff + " detinuti !");
                            }
                            else
                                Console.WriteLine("Celula era goala!");
                        }
                        else
                        {
                            MessageBox.Show("Nu a fost găsită nicio celulă cu această denumire.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu ați introdus o denumire pentru ștergere.");
                    }

                    Actualizare_DataGridView();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                textBoxIntroducereDenumireCelula.Text = "";
                textBoxIntroducereLocuriDisponibile.Text = "";
                textBoxIntroducereCapacitateMaxima.Text = "";
                textBoxStergere.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obținem rândul selectat din dataGridView
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extragem valorile celor trei coloane și le atribuim textBox-urilor corespunzătoare
                textBoxIntroducereDenumireCelula.Text = selectedRow.Cells["dENUMIREDataGridViewTextBoxColumn"].Value.ToString();
                textBoxIntroducereLocuriDisponibile.Text = selectedRow.Cells["lOCURILIBEREDataGridViewTextBoxColumn"].Value.ToString();
                textBoxIntroducereCapacitateMaxima.Text = selectedRow.Cells["lOCURIMAXIMDataGridViewTextBoxColumn"].Value.ToString();
                textBoxStergere.Text = selectedRow.Cells["dENUMIREDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

    }
}