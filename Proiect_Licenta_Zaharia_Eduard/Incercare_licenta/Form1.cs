using AForge.Video.DirectShow;
using Incercare_licenta.Acasa;
using Incercare_licenta.FormDetinuti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Incercare_licenta
{
    public partial class Form1 : Form
    {
        private UserControlStarePuscarie starePuscarieControl;
        private UserControlMesaje mesajeControl;
        private FilterInfoCollection dispozitiveVideo;
        private VideoCaptureDevice cameraVideo;
        private int timpScurs = 0;
        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.WindowState = FormWindowState.Maximized;
            UserControlAcasa Acasa = new UserControlAcasa();
            addUserControl(Acasa);
            this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
        }
        private void addUserControl(UserControl userControl)
        {
            StopCameraIfRunning();
            userControl.Dock = DockStyle.Fill;
            panelContinut.Controls.Clear();
            panelContinut.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void buttonAcasa_Click(object sender, EventArgs e)
        {
            UserControlAcasa Acasa = new UserControlAcasa();
            addUserControl(Acasa);
        }

        public void buttonSetari_Click(object sender, EventArgs e)
        {
            UserControlDetinuti Setari = new UserControlDetinuti();
            addUserControl(Setari);
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
            UserControlIesire Iesire = new UserControlIesire();
            addUserControl(Iesire);
        }

        private void buttonCelule_Click(object sender, EventArgs e)
        {
            UserControlCelule Celule = new UserControlCelule();
            addUserControl(Celule);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            // Detectarea dispozitivelor video disponibile la încărcarea formularului
            dispozitiveVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void butonMesaje_Click(object sender, EventArgs e)
        {
            if (mesajeControl == null)
            {
                mesajeControl = new UserControlMesaje();
                addUserControl(mesajeControl);
            }
            else
            {
                addUserControl(mesajeControl);
            }
        }

        private void butonStatus_Click(object sender, EventArgs e)
        {
            starePuscarieControl = new UserControlStarePuscarie();
            addUserControl(starePuscarieControl);
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

        private void butonStare_Click(object sender, EventArgs e)
        {
            StopCameraIfRunning();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            buttonSetari.PerformClick();
        }

        private void butonContact_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;

            // Pornirea timerului pentru a le face invizibile după 30 de secunde
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timpScurs++; // Incrementăm timpul scurs la fiecare tick al timerului

            if (timpScurs >= 200) // Verificăm dacă au trecut 30 de secunde
            {
                timer1.Stop(); // Oprim timerul
                timpScurs = 0; // Resetăm timpul scurs
                label3.Visible = false; // Facem labelurile invizibile
                label4.Visible = false;
            }
        }
    }
}
