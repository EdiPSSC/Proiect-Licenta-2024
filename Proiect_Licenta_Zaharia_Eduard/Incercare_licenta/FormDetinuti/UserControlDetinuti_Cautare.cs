using System;
using System.Data.OracleClient;
using System.IO;
using System.Windows.Forms;

namespace Incercare_licenta.FormDetinuti
{
    public partial class UserControlDetinuti_Cautare : UserControl
    {
        public UserControlDetinuti_Cautare()
        {
            InitializeComponent();
            this.dETINUTTableAdapter1.Fill(dataSet3.DETINUT);
        }

        private void FiltrareDetinuti()
        {
            string filtru = "";
            if (!string.IsNullOrEmpty(textBoxCautareDetinut.Text))
            {
                filtru += "nume LIKE '" + textBoxCautareDetinut.Text + "%' AND ";
            }

            if (!string.IsNullOrEmpty(textBoxPrenume.Text))
            {
                filtru += "prenume LIKE '" + textBoxPrenume.Text + "%' AND ";
            }

            if (!string.IsNullOrEmpty(textBoxFapta.Text))
            {
                filtru += "fapta LIKE '" + textBoxFapta.Text + "%' AND ";
            }

            if (!string.IsNullOrEmpty(textBoxCelula.Text))
            {
                filtru += "celula LIKE '" + textBoxCelula.Text + "%' AND ";
            }

            if (filtru.EndsWith("AND "))
            {
                filtru = filtru.Substring(0, filtru.Length - 5);
            }

            dETINUTBindingSource2.Filter = filtru;

        }

        private void textBoxCautareDetinut_TextChanged(object sender, System.EventArgs e)
        {
            FiltrareDetinuti();
        }

        private void butonStergere_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxStergere.Text))
            {
                string cnp = textBoxStergere.Text;
                DialogResult result = MessageBox.Show("Sunteți sigur că doriți să ștergeți deținutul cu CNP-ul " + cnp + "?","Confirmare ștergere",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string stareDetinut = "";

                    using (OracleConnection connStareDetinut = new OracleConnection("Data Source=xe;User ID=student;Password=student;"))
                    {
                        try
                        {
                            connStareDetinut.Open();
                            string queryStareDetinut = "SELECT STARE, CELULA FROM Detinut WHERE CNP = :cnp";
                            using (OracleCommand cmdStareDetinut = new OracleCommand(queryStareDetinut, connStareDetinut))
                            {
                                cmdStareDetinut.Parameters.Add("cnp", OracleType.VarChar).Value = cnp;
                                OracleDataReader reader = cmdStareDetinut.ExecuteReader();
                                if (reader.Read())
                                {
                                    stareDetinut = reader["STARE"].ToString();
                                    string denumireCelula = reader["CELULA"].ToString();
                                    reader.Close();

                                    if (stareDetinut == "INCARCERAT")
                                    {
                                        string queryActualizareLocuri = "UPDATE Celula SET LOCURI_LIBERE = LOCURI_LIBERE + 1 WHERE DENUMIRE = :denumireCelula";
                                        using (OracleCommand cmdActualizareLocuri = new OracleCommand(queryActualizareLocuri, connStareDetinut))
                                        {
                                            cmdActualizareLocuri.Parameters.Add("denumireCelula", OracleType.VarChar).Value = denumireCelula;
                                            int rowsAffectedLocuri = cmdActualizareLocuri.ExecuteNonQuery();
                                            if (rowsAffectedLocuri > 0)
                                            {
                                                Console.WriteLine("Numărul de locuri disponibile în celula " + denumireCelula + " a fost actualizat cu succes!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu s-au putut actualiza locurile disponibile în celula " + denumireCelula);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nu s-au găsit date pentru detinutul cu CNP-ul " + cnp + ".");
                                    return;
                                }
                                textBoxStergere.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare la obținerea stării detinutului: " + ex.Message);
                            return;
                        }
                    }

                    // Ștergem detinutul din baza de date
                    using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;"))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Detinut WHERE CNP = :cnp";
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.Parameters.Add("cnp", OracleType.VarChar).Value = cnp;
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    this.dETINUTTableAdapter1.Fill(dataSet3.DETINUT);
                                    MessageBox.Show("Detinutul cu CNP-ul " + cnp + " a fost șters cu succes din baza de date!");
                                }
                                else
                                {
                                    MessageBox.Show("Nu s-a putut șterge detinutul cu CNP-ul " + cnp + " din baza de date. Verificați CNP-ul introdus.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare: " + ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("Ștergerea a fost anulată!");
            }
            else
            {
                MessageBox.Show("Introduceți CNP-ul deținutului pentru a putea efectua ștergerea!");
            }
        }

        private void textBoxPrenume_TextChanged(object sender, EventArgs e)
        {
            FiltrareDetinuti();
        }

        private void butonStergere2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string cnp = dataGridView2.SelectedRows[0].Cells["CNP"].Value.ToString();

                DialogResult result = MessageBox.Show("Sunteți sigur că doriți să ștergeți deținutul cu CNP-ul " + cnp + "?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string stareDetinut = "";
                    string denumireCelula = "";

                    using (OracleConnection connStareCelula = new OracleConnection("Data Source=xe;User ID=student;Password=student;"))
                    {
                        try
                        {
                            connStareCelula.Open();
                            string queryStareCelula = "SELECT STARE, CELULA FROM Detinut WHERE CNP = :cnp";
                            using (OracleCommand cmdStareCelula = new OracleCommand(queryStareCelula, connStareCelula))
                            {
                                cmdStareCelula.Parameters.Add("cnp", OracleType.VarChar).Value = cnp;
                                OracleDataReader reader = cmdStareCelula.ExecuteReader();
                                if (reader.Read())
                                {
                                    stareDetinut = reader["STARE"].ToString();
                                    denumireCelula = reader["CELULA"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nu s-au găsit date pentru detinutul cu CNP-ul " + cnp + ".");
                                    return;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare la obținerea stării și denumirii celulei: " + ex.Message);
                            return;
                        }
                    }

                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

                    using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;"))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Detinut WHERE CNP = :cnp";
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.Parameters.Add("cnp", OracleType.VarChar).Value = cnp;
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Detinutul a fost șters cu succes din baza de date!");
                                    textBoxStergere.Text = "";
                                    if (!string.IsNullOrEmpty(denumireCelula) && stareDetinut == "INCARCERAT")
                                    {
                                        string queryActualizareLocuri = "UPDATE Celula SET LOCURI_LIBERE = LOCURI_LIBERE + 1 WHERE DENUMIRE = :denumireCelula";
                                        using (OracleCommand cmdActualizareLocuri = new OracleCommand(queryActualizareLocuri, conn))
                                        {
                                            cmdActualizareLocuri.Parameters.Add("denumireCelula", OracleType.VarChar).Value = denumireCelula;
                                            int rowsAffectedLocuri = cmdActualizareLocuri.ExecuteNonQuery();
                                            if (rowsAffectedLocuri > 0)
                                            {
                                                Console.WriteLine("Numărul de locuri disponibile în celula " + denumireCelula + " a fost actualizat cu succes!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu s-au putut actualiza locurile disponibile în celula " + denumireCelula);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nu s-a putut șterge detinutul din baza de date.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare: " + ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("Ștergerea a fost anulată!");
            }
            else
            {
                MessageBox.Show("Selectați un rând din tabel pentru a îl putea șterge!");
            }

        }

        private void textBoxCelula_TextChanged(object sender, EventArgs e)
        {
            FiltrareDetinuti();
        }

        private void textBoxFapta_TextChanged(object sender, EventArgs e)
        {
            FiltrareDetinuti();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContinutCentral.Controls.Clear();
            panelContinutCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CNPFisier = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row1 = dataGridView2.Rows[e.RowIndex];
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    CNPFisier = selectedRow.Cells["CNP"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Reincercati sa alegeti un detinut!");
                }

                try
                {
                    string caleFisier = "C:\\Users\\Edy\\Desktop\\Licenta\\InfoDetinut.txt";

                    using (StreamWriter sw = new StreamWriter(caleFisier))
                    {
                        sw.WriteLine(CNPFisier);
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
                DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object cellValue = cell.Value;

                if (cellValue != null)
                {
                    UserControlDubluClick Detinut = new UserControlDubluClick();
                    addUserControl(Detinut);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

               textBoxStergere.Text=selectedRow.Cells["CNP"].Value.ToString();
            }
        }
    }
}
