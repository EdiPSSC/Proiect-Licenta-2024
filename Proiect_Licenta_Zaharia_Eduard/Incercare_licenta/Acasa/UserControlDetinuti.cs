using Incercare_licenta.FormDetinuti;
using System;
using System.Windows.Forms;

namespace Incercare_licenta.Acasa
{
    public partial class UserControlDetinuti : UserControl
    {
        public UserControlDetinuti()
        {
            InitializeComponent();
            UserControlDetinuti_Acasa Acasa = new UserControlDetinuti_Acasa();
            addUserControl(Acasa);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContinut.Controls.Clear();
            panelContinut.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonCautareDetinut_Click(object sender, EventArgs e)
        {
            UserControlDetinuti_Cautare Lista = new UserControlDetinuti_Cautare();
            addUserControl(Lista);
        }

        private void guna2Acasa_Click(object sender, EventArgs e)
        {
            UserControlDetinuti_Acasa Acasa = new UserControlDetinuti_Acasa();
            addUserControl(Acasa);
        }

        private void butonAdaugare_Click(object sender, EventArgs e)
        {
            UserControlDetinutiAdaugare Acasa = new UserControlDetinutiAdaugare();
            addUserControl(Acasa);
        }

        private void butonSchimbareStare_Click(object sender, EventArgs e)
        {
            UserControlDetinutiSchimbare Acasa = new UserControlDetinutiSchimbare();
            addUserControl(Acasa);
        }

        private void butonStergere_Click(object sender, EventArgs e)
        {
            UserControlDetinuti_Cautare Stergere = new UserControlDetinuti_Cautare();
            addUserControl(Stergere);
        }
    }
}
