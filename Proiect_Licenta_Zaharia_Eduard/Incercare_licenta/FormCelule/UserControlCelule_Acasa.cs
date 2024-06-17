using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace Incercare_licenta.FormCelule
{
    public partial class UserControlCelule_Acasa : UserControl
    {
        public UserControlCelule_Acasa()
        {
            InitializeComponent();
        }

        private void UserControlCelule_Acasa_Load(object sender, EventArgs e)
        {
            DetinutiInCelule();
            NumarTotalCelule();
            NumarTotalLocuriLibere();
            CapacitateMaximaPuscarie();
        }

        public void NumarTotalCelule()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarCelule = Convert.ToInt32(cmd.ExecuteScalar());
                labelNumarCelule.Text = numarCelule.ToString();
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

        public void DetinutiInCelule()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Detinut WHERE STARE='INCARCERAT'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarCelule = Convert.ToInt32(cmd.ExecuteScalar());
                labelNrCelule.Text = numarCelule.ToString();
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

        public void CapacitateMaximaPuscarie()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT SUM(locuri_maxim) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarlocuri = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiCelule.Text = numarlocuri.ToString();
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

        public void DetinutiCelule()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID = student; Password = student; Unicode = True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                int numarCelule = Convert.ToInt32(cmd.ExecuteScalar());
                labelDetinutiCelule.Text = numarCelule.ToString();
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
        public void NumarTotalLocuriLibere()
        {
            OracleConnection conn = new OracleConnection("Data Source=xe;User ID=student;Password=student;Unicode=True");
            try
            {
                conn.Open();
                string query = "SELECT SUM(locuri_libere) FROM Celula";
                OracleCommand cmd = new OracleCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int numarLocuriLibere = Convert.ToInt32(result);
                    labelNrLocuriLibere.Text = numarLocuriLibere.ToString();
                }
                else
                {
                    labelNrLocuriLibere.Text = "Nu există locuri libere disponibile.";
                }

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
    }
}
