using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Incercare_licenta.FormDetinuti
{
    public partial class UserControlDetinuti_Acasa : UserControl
    {
        public UserControlDetinuti_Acasa()
        {
            InitializeComponent();
        }

        public void DetinutiNumar()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarDetinuti = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiTotal.Text = numarDetinuti.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DetinutiLiberi()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut WHERE STARE='LIBER'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarDetinuti = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiLiberi.Text = numarDetinuti.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DetinutiArest()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut WHERE STARE='INCARCERAT'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarDetinuti = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiInCelule.Text = numarDetinuti.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void DetinutiInCelule()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut WHERE STARE='ARESTAT'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarDetinuti = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiInArest.Text = numarDetinuti.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void UserControlDetinuti_Acasa_Load(object sender, EventArgs e)
        {
            DetinutiInCelule();
            DetinutiNumar();
            DetinutiLiberi();
            DetinutiArest();
        }
    }
}
