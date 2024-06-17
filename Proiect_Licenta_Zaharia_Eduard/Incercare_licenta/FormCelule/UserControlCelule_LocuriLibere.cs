using System;
using System.Data.OracleClient;
using System.IO;
using System.Windows.Forms;

namespace Incercare_licenta.FormCelule
{
    public partial class UserControlCelule_LocuriLibere : UserControl
    {
        protected string nume = "", libere = "", maxim = "";
        protected string numeDetinut = "", prenumeDetinut = "", fapta = "",CNPdet="";
        protected bool adaugare = false;
        public UserControlCelule_LocuriLibere()
        {
            InitializeComponent();
            butonDetalii.Visible = false;
            butonEliminare.Visible = false;
            ButonPlus.Visible = false;
            dataGridView2.Visible = false;
            labelAlegereDetinut.Visible = false;
            this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
            this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
        }

        private void UserControlCelule_LocuriLibere_Load(object sender, EventArgs e)
        {
            string filtru = "Locuri_libere > 0";
            cELULABindingSource.Filter = filtru;

            string filtruDetinuti = "Stare <> 'Incarcerat' AND Stare <> 'Liber'";
            dETINUTBindingSource2.Filter = filtruDetinuti;

        }

        private void DetinutArestati()
        {
            string filtruDetinuti = "Stare <> 'Incarcerat' AND Stare <> 'Liber'";
            dETINUTBindingSource2.Filter = filtruDetinuti;
        }

        private void DetinutiCelula(string nume)
        {
            string filtruDetinuti = $"Celula = '{nume}'";
            dETINUTBindingSource2.Filter = filtruDetinuti;
        }


        private void ButonPlus_Click(object sender, EventArgs e)
        {
            adaugare = true;
            DetinutArestati();
            dataGridView2.Visible = true;
            labelAlegereDetinut.Text = "Selectați deținutul pe care doriți să îl adăugați în celula din lista de mai jos";
            labelAlegereDetinut.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                nume = selectedRow.Cells["dENUMIREDataGridViewTextBoxColumn"].Value.ToString();
                libere = selectedRow.Cells["lOCURILIBEREDataGridViewTextBoxColumn"].Value.ToString();
                maxim = selectedRow.Cells["lOCURIMAXIMDataGridViewTextBoxColumn"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selectați un rând înainte de a apăsa butonul Plus.");
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentralCelule.Controls.Clear();
            panelCentralCelule.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void butonDetalii_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UserControlCelulaDubluClick Celule = new UserControlCelulaDubluClick();
                addUserControl(Celule);
            }
            else
            {
                MessageBox.Show("Selectați un rând înainte de a apăsa butonul.");
            }
        }

        private void butonEliminare_Click(object sender, EventArgs e)
        {
            adaugare = false;
            dataGridView2.Visible = true;
            labelAlegereDetinut.Text = "Selectați deținutul pe care doriți să îl scoateți din celulă din lista de mai jos";
            labelAlegereDetinut.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                nume = selectedRow.Cells["dENUMIREDataGridViewTextBoxColumn"].Value.ToString();
                libere = selectedRow.Cells["lOCURILIBEREDataGridViewTextBoxColumn"].Value.ToString();
                maxim = selectedRow.Cells["lOCURIMAXIMDataGridViewTextBoxColumn"].Value.ToString();
                DetinutiCelula(nume);
            }
            else
            {
                MessageBox.Show("Selectați un rând înainte de a apăsa butonul de eliminare.");
            }
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (adaugare)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    // Afișați un MessageBox pentru a întreba utilizatorul dacă este sigur
                    DialogResult result = MessageBox.Show("Sunteți sigur că doriți să adăugați acest deținut?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificați răspunsul utilizatorului
                    if (result == DialogResult.Yes)
                    {
                        if (dataGridView2.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                            numeDetinut = selectedRow.Cells["nUMEDataGridViewTextBoxColumn"].Value.ToString();
                            prenumeDetinut = selectedRow.Cells["pRENUMEDataGridViewTextBoxColumn"].Value.ToString();
                            fapta = selectedRow.Cells["fAPTADataGridViewTextBoxColumn"].Value.ToString();
                            CNPdet = row.Cells["CNP"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Reincercati sa alegeti un detinut!");
                        }
                        ActualizeazaStareDetinut(CNPdet,numeDetinut, prenumeDetinut, fapta);
                        ActualizeazaLocuriLibere(nume);
                        MessageBox.Show("Deținutul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
                        this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
                        labelAlegereDetinut.Visible = false;
                        dataGridView2.Visible = false;
                    }
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Sunteți sigur că doriți să eliminați acest deținut din această celulă?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                        string numeDetinut = row.Cells["nUMEDataGridViewTextBoxColumn"].Value.ToString();
                        string prenumeDetinut = row.Cells["pRENUMEDataGridViewTextBoxColumn"].Value.ToString();
                        string fapta = row.Cells["fAPTADataGridViewTextBoxColumn"].Value.ToString();
                        CNPdet = row.Cells["CNP"].Value.ToString();
                        // Actualizează starea și celula detinutului
                        ActualizeazaStareSiCelulaDetinut(CNPdet, numeDetinut, prenumeDetinut, fapta);

                        // Actualizează numărul de locuri libere în celula
                        ActualizeazaLocuriLibereStergere(nume);

                        MessageBox.Show("Deținutul a fost eliminat cu succes din această celulă!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reîncarcă datele în dataGridView1 și dataGridView2
                        this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
                        this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
                        labelAlegereDetinut.Visible = false;
                        dataGridView2.Visible = false;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                ButonPlus.Visible = true;
                butonDetalii.Visible = true;
                butonEliminare.Visible = true;

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
        }
      
        private void ActualizeazaLocuriLibere(string NumeCelula)
        {
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE Celula SET Locuri_libere = Locuri_libere - 1 WHERE Denumire = '{NumeCelula}'";
                    OracleCommand command = new OracleCommand(query, conn);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Actualizare reușită: Locuri_libere a fost actualizat cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Actualizare eșuată: Celula nu a fost găsită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare în timpul actualizării: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizeazaLocuriLibereStergere(string NumeCelula)
        {
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE Celula SET Locuri_libere = Locuri_libere + 1 WHERE Denumire = '{NumeCelula}'";
                    OracleCommand command = new OracleCommand(query, conn);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Actualizare reușită: Locuri_libere a fost actualizat cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Actualizare eșuată: Celula nu a fost găsită.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare în timpul actualizării: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizeazaStareSiCelulaDetinut(string CNPdet, string numedet, string prenumedet, string faptadet)
        {
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE Detinut SET Stare = 'ARESTAT', Celula = null  WHERE CNP = '{CNPdet}' AND nume='{numedet}' AND prenume='{prenumedet}' AND fapta='{faptadet}'";
                    OracleCommand command = new OracleCommand(query, conn);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Detinutul a fost mutat cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Actualizare eșuată: Detinutul nu a fost găsit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare în timpul actualizării: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ActualizeazaStareDetinut(string CNP,string numeD, string prenumeD, string faptaD)
        {
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True"))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE Detinut SET Stare = 'INCARCERAT', Celula = '{nume}' WHERE CNP='{CNP}' AND Nume = '{numeD}' AND Prenume = '{prenumeD}' AND fapta = '{faptaD}'";
                    OracleCommand command = new OracleCommand(query, conn);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Detinutul a fost mutat cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Actualizare eșuată: Detinutul nu a fost găsit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare în timpul actualizării: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}