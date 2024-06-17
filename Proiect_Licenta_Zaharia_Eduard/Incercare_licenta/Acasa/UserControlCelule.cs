using Incercare_licenta.FormCelule;
using System;
using System.Windows.Forms;

namespace Incercare_licenta.Acasa
{
    public partial class UserControlCelule : UserControl
    {

        public UserControlCelule()
        {
            InitializeComponent();
            UserControlCelule_Acasa Acasa = new UserControlCelule_Acasa();
            addUserControl(Acasa);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentralCelule.Controls.Clear();
            panelCentralCelule.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void butonCelule_Click(object sender, EventArgs e)
        {
            UserControlCelule_Celule Celule = new UserControlCelule_Celule();
            addUserControl(Celule);
        }

        private void butonLocuriLibere_Click(object sender, EventArgs e)
        {
            UserControlCelule_LocuriLibere Locuri = new UserControlCelule_LocuriLibere();
            addUserControl(Locuri);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControlCelule_Acasa Acasa = new UserControlCelule_Acasa();
            addUserControl(Acasa);
        }
    }
}
