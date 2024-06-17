using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Incercare_licenta.Acasa
{
    public partial class UserControlMesaje : UserControl
    {
        private List<string> coduriPrimite = new List<string>();

        public UserControlMesaje()
        {
            InitializeComponent();
            IncarcaListaCoduri();
        }
        private void IncarcaListaCoduri()
        {
            string caleFisier = "C:\\Users\\Edy\\Desktop\\Licenta\\Lista_coduri.txt";

            if (File.Exists(caleFisier))
            {
                try
                {
                    // Citește codurile din fișier
                    string[] coduri = File.ReadAllLines(caleFisier);

                    // Afișează sau folosește codurile după cum este necesar
                    foreach (string cod in coduri)
                    {
                        // Exemplu: Adaugă codurile într-un ListBox
                        listBoxCoduri1.Items.Add(cod);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la citirea fișierului: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fișierul Lista_coduri.txt nu a fost găsit.");
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void butonExit_Click(object sender, System.EventArgs e)
        {
            UserControlStarePuscarie Stare = new UserControlStarePuscarie();
            addUserControl(Stare);
        }
    }
}
