using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Incercare_licenta.FormCelule
{
    public partial class UserControlCelulaDubluClick : UserControl
    {
        protected string NumeCelula = "";
        private FilterInfoCollection dispozitiveVideo;
        private VideoCaptureDevice cameraVideo;
        public UserControlCelulaDubluClick()
        {
            NumeCelula = File.ReadLines(@"C:\Users\Edy\Desktop\Licenta\InfoCelula.txt").First();
            InitializeComponent();
            labelTitlu.Text = NumeCelula;
            this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
            groupBox3.Visible = false;
            IncarcaCamereDisponibile();
        }

        private void IncarcaCamereDisponibile()
        {
            dispozitiveVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in dispozitiveVideo)
            {
                comboBoxCamere.Items.Add(device.Name);
            }
            if (comboBoxCamere.Items.Count > 0)
            {
                comboBoxCamere.SelectedIndex = 0;
            }
        }

        private void camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        
        private void FiltrareDetinutiDupaCelula(string numeCelula)
        {
            if (!string.IsNullOrEmpty(numeCelula))
            {
                dETINUTBindingSource1.Filter = $"CELULA = '{numeCelula}'";
            }
            else
            {
                dETINUTBindingSource1.RemoveFilter();
            }
        }
        private void addUserControl(UserControl userControl)
        {
            StopCameraIfRunning();
            userControl.Dock = DockStyle.Fill;
            panelCentralCelule.Controls.Clear();
            panelCentralCelule.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void StopCameraIfRunning()
        {
            // Oprește camera video principală, dacă este activă
            if (cameraVideo != null && cameraVideo.IsRunning)
            {
                cameraVideo.Stop();
                cameraVideo = null;
            }

            // Oprește toate dispozitivele video detectate
            if (dispozitiveVideo != null)
            {
                foreach (FilterInfo device in dispozitiveVideo)
                {
                    VideoCaptureDevice videoDevice = new VideoCaptureDevice(device.MonikerString);
                    if (videoDevice.IsRunning)
                    {
                        videoDevice.Stop();
                    }
                }
            }
        }

        private void butonExit_Click(object sender, EventArgs e)
        {
            if (cameraVideo != null && cameraVideo.IsRunning)
            {
                // Oprirea camerei și golirea pictureBox-ului
                cameraVideo.Stop();
                cameraVideo = null;
                pictureBoxCamera.Image = null;
            }
            UserControlCelule_Celule Celule = new UserControlCelule_Celule();
            addUserControl(Celule);
        }

        private void UserControlCelulaDubluClick_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            Console.WriteLine(NumeCelula);
            string connString = "Data Source=xe;User ID=student;Password=student;";
            OracleConnection conn = new OracleConnection(connString);

            try
            {
                conn.Open();
                string query = $"SELECT Denumire,Locuri_libere,Locuri_Maxim FROM Celula WHERE Denumire = '{NumeCelula}'";
                OracleCommand cmd = new OracleCommand(query, conn);

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string denumire = reader["Denumire"].ToString();
                        string locuriLibere = reader["Locuri_libere"].ToString();
                        string locuriMaxime = reader["Locuri_Maxim"].ToString();

                        labelDenumireCelula.Text = "Denumire: " + denumire;
                        labelLoc2.Text = locuriMaxime;
                        labelLoc1.Text = locuriLibere;
                        Console.WriteLine("Denumire: " + denumire);
                        Console.WriteLine("Locuri Libere: " + locuriLibere);
                        Console.WriteLine("Locuri Maxime: " + locuriMaxime);
                    }
                    else
                    {
                        Console.WriteLine("Nu s-au găsit date pentru celula specificată.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            FiltrareDetinutiDupaCelula(NumeCelula);
        }
        private void IncarcaCeluleDisponibile()
        {
            string connString = "Data Source=xe;User ID=student;Password=student;"; 

            string query = "SELECT Denumire FROM Celula WHERE Locuri_libere > 0"; 

            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
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

        private void butonStergereDetinut_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să eliminați detinutul din celulă?", "Confirmare Eliminare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string CNPDetinut = dataGridView2.SelectedRows[0].Cells["cNPDataGridViewTextBoxColumn"].Value.ToString();

                    using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student"))
                    {
                        conn.Open();

                        string query = $"UPDATE Detinut SET STARE = 'ARESTAT', CELULA = '' WHERE CNP = '{CNPDetinut}'";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                        ActualizareCelula(NumeCelula, 1);
                        groupBox3.Visible = false;
                        this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
                        ReloadData();

                        MessageBox.Show("Deținutul a fost scos din această celulă cu succes!");
                    }
                }
                else
                {
                    MessageBox.Show("Selectați un detinut pentru a-l muta în celula selectată.");
                }
            }
        }

        private void butonMutareDetinut_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                comboBoxCelula.Items.Clear();
                groupBox3.Visible = true;
                IncarcaCeluleDisponibile();
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un detinut înainte de a continua.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butonRenuntare_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void butonMutareFinalizata_Click(object sender, EventArgs e)
        {
            if (comboBoxCelula.SelectedItem != null)
            {
                string celulaDestinatie = comboBoxCelula.SelectedItem.ToString();

                if (dataGridView2.SelectedRows.Count > 0)
                {
                    string CNPDetinut = dataGridView2.SelectedRows[0].Cells["cNPDataGridViewTextBoxColumn"].Value.ToString();

                    ActualizareCelula(celulaDestinatie, -1);

                    ActualizareCelula(NumeCelula, 1);

                    MutareDetinut(CNPDetinut, celulaDestinatie);
                    groupBox3.Visible = false;
                    this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
                    ReloadData();

                    MessageBox.Show("Detinutul a fost mutat cu succes în celula selectată.");
                }
                else
                {
                    MessageBox.Show("Selectați un detinut din dataGridView2 pentru a-l muta în celula selectată.");
                }
            }
            else
            {
                MessageBox.Show("Nu ați selectat o celulă existentă în comboBoxCelula.");
            }
        }
        private void ActualizareCelula(string denumireCelula, int modificareLocuriLibere)
        {
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student"))
            {
                conn.Open();
                string query = $"UPDATE Celula SET Locuri_libere = Locuri_libere + {modificareLocuriLibere} WHERE Denumire = '{denumireCelula}'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        private void MutareDetinut(string CNPDetinut, string celulaDestinatie)
        {
            // Deschideți conexiunea la baza de date
            using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student"))
            {
                conn.Open();

                // Actualizați coloana CELULA a detinutului cu celulaDestinatie
                string query = $"UPDATE Detinut SET CELULA = '{celulaDestinatie}' WHERE CNP = '{CNPDetinut}'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Închideți conexiunea
                conn.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox3.Visible = false;
            comboBoxCelula.Items.Clear();

        }

        private void butonStergereTotiDetinutii_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să eliminați detinutii din celulă?", "Confirmare Eliminare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int detinutiEliminati = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string CNPDetinut = row.Cells["cNPDataGridViewTextBoxColumn"].Value.ToString();
                        using (OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student"))
                        {
                            conn.Open();

                            string query = $"UPDATE Detinut SET STARE = 'ARESTAT', CELULA = '' WHERE CNP = '{CNPDetinut}'";
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                        detinutiEliminati++;
                    }
                }
                ActualizareCelula(NumeCelula, detinutiEliminati);
                groupBox3.Visible = false;
                this.dETINUTTableAdapter.Fill(dataSet3.DETINUT);
                ReloadData();
                MessageBox.Show($"Au fost scoși {detinutiEliminati} detinuti din această celula cu succes!");
            }
        }

        private void butonCamera_Click(object sender, EventArgs e)
        {
            if (cameraVideo != null && cameraVideo.IsRunning)
            {
                // Oprirea camerei și golirea pictureBox-ului
                cameraVideo.Stop();
                cameraVideo = null;
                pictureBoxCamera.Image = null;
                butonCamera.Text = "Porniți camera"; // Actualizare text buton
            }
            else
            {
                if (comboBoxCamere.SelectedIndex >= 0)
                {
                    // Pornirea camerei
                    cameraVideo = new VideoCaptureDevice(dispozitiveVideo[comboBoxCamere.SelectedIndex].MonikerString);
                    cameraVideo.NewFrame += new NewFrameEventHandler(camera_NewFrame);
                    cameraVideo.Start();
                    butonCamera.Text = "Opriți camera"; // Actualizare text buton
                }
            }
        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (cameraVideo != null && cameraVideo.IsRunning)
            {
                cameraVideo.SignalToStop();
                cameraVideo.WaitForStop();
                cameraVideo = null;
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            // Verificați dacă controlul devine invizibil și camera este activă
            if (!this.Visible && cameraVideo != null && cameraVideo.IsRunning)
            {
                // Opriți camera
                cameraVideo.SignalToStop();
                cameraVideo.WaitForStop();
                cameraVideo = null;
            }
        }
    }
}