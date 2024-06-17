using Incercare_licenta.FormCelule;
using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Incercare_licenta.Acasa
{
    public partial class UserControlAcasa : UserControl
    {
        public UserControlAcasa()
        {
            InitializeComponent();
            this.cELULATableAdapter.Fill(this.dataSet1.CELULA);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void butonCelule_Click(object sender, System.EventArgs e)
        {

        }

        private void butonDetinuti_Click(object sender, System.EventArgs e)
        {
            UserControlCelule cel = new UserControlCelule();
            addUserControl(cel);
        }

        private void butonStare_Click(object sender, System.EventArgs e)
        {
            UserControlStarePuscarie Stare = new UserControlStarePuscarie();
            addUserControl(Stare);
        }

        private void butonContact_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        public void IncarcaCelule()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarCelule = Convert.ToInt32(cmd.ExecuteScalar());
                labelCelule.Text = numarCelule.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare‐ date invalide " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void IncarcaDetinuti()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarCelule = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinuti.Text = numarCelule.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void IncarcaCapacitate()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT SUM(locuri_maxim) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarlocuri = Convert.ToInt32(cmd.ExecuteScalar());
                labelCapacitate.Text = numarlocuri.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void UserControlAcasa_Load(object sender, System.EventArgs e)
        {
            IncarcaDetinuti();
            IncarcaCelule();
            IncarcaCapacitate();
        }
    }
}
