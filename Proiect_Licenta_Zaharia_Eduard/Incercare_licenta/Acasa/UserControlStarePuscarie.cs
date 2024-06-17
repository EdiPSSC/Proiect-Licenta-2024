using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.IO;
using System.IO.Ports;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Incercare_licenta.Acasa
{
    public partial class UserControlStarePuscarie : UserControl
    {
        private List<string> coduriPrimite = new List<string>();
        public int Contor_coduri = 0;
        protected bool StareAlarma = true;
        private static readonly object lockObject = new object();
        private static SerialPort serialPort;
        private Thread serialThread;
        private static string datePrimite;
        protected float temp = 0, umid = 0;
        protected int aer = 0, limitaTemperatura = 200, limitaUmiditate = 200, limitaAer = 300;
        protected string cod = "";
        private bool handlerAdded = false;

        private void ProceseazaDate(string date)
        {
            lock (lockObject)
            {
                if (date != null)
                {
                    string[] valori = date.Split(',');
                    if (valori.Length == 4)
                    {
                        temp = float.Parse(valori[1]);
                        umid = float.Parse(valori[2]);
                        aer = int.Parse(valori[3]);
                        cod = valori[0];

                        Console.WriteLine("Temperatura: " + temp);
                        Console.WriteLine("Umiditate: " + umid);
                        Console.WriteLine("Valoare senzor MQ-135: " + aer);
                        Console.WriteLine("Codul este: " + cod);

                        string rezultat = validare_cod(cod);
                        if (rezultat != null)
                        {
                            Contor_coduri++;
                            coduriPrimite.Add(rezultat);
                        }
                    }
                    else if (valori.Length == 3)
                    {
                        temp = float.Parse(valori[0]);
                        umid = float.Parse(valori[1]);
                        aer = int.Parse(valori[2]);

                        Console.WriteLine("Temperatura: " + temp);
                        Console.WriteLine("Umiditate: " + umid);
                        Console.WriteLine("Valoare senzor MQ-135: " + aer);
                        Console.WriteLine("Nu a fost receptionat niciun cod !");
                    }
                    else
                    {
                        Console.WriteLine("Datele primite nu sunt în formatul corect.");
                    }

                    if (butonMesaje.InvokeRequired)
                    {
                        butonMesaje.Invoke((MethodInvoker)delegate
                        {
                            butonMesaje.Text = "Mesaje (" + Contor_coduri + ")";
                        });
                    }
                    else
                    {
                        butonMesaje.Text = "Mesaje (" + Contor_coduri + ")";
                    }

                    Console.WriteLine("Numarul total de coduri receptionate este : " + Contor_coduri);
                }
                else
                {
                    return;
                }
            }
        }
        private string validare_cod(string cod)
        {
            string rezultat = null;

            string connString = "Data Source=xe;User ID=student;Password=student;";
            string query = "SELECT Mesaj FROM Coduri WHERE Cod = :cod";

            using (OracleConnection conn = new OracleConnection(connString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("cod", cod));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string mesaj = reader["Mesaj"].ToString();
                            rezultat = "Codul " + cod + " : " + mesaj;
                        }
                    }
                }
            }

            return rezultat;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializarePortSerial();
            InterceptareDate();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                if (serialThread != null && serialThread.IsAlive)
                {
                    serialThread.Abort();
                }
            }
            base.Dispose(disposing);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContinut.Controls.Clear();
            panelContinut.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string date = serialPort.ReadLine();
                    if (date != null)
                    {
                        ProceseazaDate(date);

                        this.Invoke((MethodInvoker)delegate
                        {
                            labelTemperatura.Text = "Temperatura: " + temp.ToString() + " °C";
                            labelUmiditate.Text = "Umiditate: " + umid.ToString() + " %";
                            labelCalitateAer.Text = "Calitate aer: " + aer.ToString() + " PPM";

                            if (temp > limitaTemperatura || umid > limitaUmiditate || aer > limitaAer)
                            {
                                if (StareAlarma)
                                {
                                    TrimitereComandaBuzzer("LED01");
                                    labelstatus.Text = "NOK";
                                    labelstatus.ForeColor = System.Drawing.Color.Red;
                                }
                                else
                                {
                                    TrimitereComandaBuzzer("LED00");
                                    labelstatus.Text = "NOK";
                                    labelstatus.ForeColor = System.Drawing.Color.Red;
                                }
                            }
                            else
                            {
                                labelstatus.Text = "OK";
                                labelstatus.ForeColor = System.Drawing.Color.Green;
                                TrimitereComandaBuzzer("LED00");
                            }
                        });
                    }
                    else
                    {
                        Console.WriteLine("Nu s-au primit date valide de la portul serial.");
                    }
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Timeout la citirea datelor de pe portul serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la citirea datelor de pe portul serial: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Portul serial nu este deschis.");
            }
        }

        private void InterceptareDate()
        {
            if (!handlerAdded)
            {
                serialPort.DataReceived += SerialPort_DataReceived;
                handlerAdded = true;
            }
        }

        private void InitializarePortSerial()
        {
            string[] portNames = SerialPort.GetPortNames();

            if (portNames.Length == 0)
            {
                Console.WriteLine("Nu s-a detectat niciun port serial disponibil.");
                return;
            }

            Console.WriteLine("Porturi seriale disponibile:");
            foreach (string port in portNames)
            {
                Console.WriteLine(port);
            }

            string selectedPort = portNames[0];
            Console.WriteLine("Conectare la portul: " + selectedPort);

            if (serialPort == null || !serialPort.IsOpen)
            {
                serialPort = new SerialPort(selectedPort, 9600);

                try
                {
                    serialPort.Open();
                    serialPort.DataReceived += SerialPort_DataReceived;

                    Console.WriteLine("Așteptare date de la Arduino...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare la deschiderea portului serial: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Portul serial este deja deschis.");
            }
        }
        private void TrimitereComandaBuzzer(string comanda)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    Console.WriteLine("Portul serial nu este deschis.");
                    return;
                }

                serialPort.WriteLine(comanda);
                Console.WriteLine($"Comanda trimisă către Arduino: {comanda}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la trimiterea comenzii: " + ex.Message);
            }
        }

        private void pornireBuzzer_Click(object sender, EventArgs e)
        {
            TrimitereComandaBuzzer("1");
        }

        private void oprireBuzzer_Click(object sender, EventArgs e)
        {
            TrimitereComandaBuzzer("0");
        }
        private void butonAlarma_Click(object sender, EventArgs e)
        {
            string parola = "";
            string connString = "Data Source=xe;User ID=student;Password=student;";
            string query = "SELECT Parola FROM Limite";

            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                parola = reader["Parola"].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Nu s-au găsit date pentru parola în tabelul Limite.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string salt = SecurityUtils.GetSalt();
            if (CriptareParola(textBoxAlarma.Text, salt) == parola)
            {
                TrimitereComandaBuzzer("0");
                butonArmare.PerformClick();
                textBoxAlarma.Text = "";
            }
            else
            {
                MessageBox.Show("Parola introdusa este incorecta!");
                textBoxAlarma.Text = "";
            }
        }

        public UserControlStarePuscarie()
        {
            InitializeComponent();
            Contor_coduri = 0;
            LimiteBazaDate();
            labelTemperatura.Text = "Temperatura: 30 °C";
            labelUmiditate.Text = "Umiditate: 50%";
            labelCalitateAer.Text = "Calitate aer: 180 PPM";
        }
        private void ModificaLimite()
        {
            int temperatura = int.Parse(textBoxLimitaTemp.Text);
            int umiditate = int.Parse(textBoxLimitaUmid.Text);
            int aer = int.Parse(textBoxLimitaAer.Text);

            string connString = "Data Source=xe;User ID=student;Password=student;";
            string query = $"UPDATE Limite SET temperatura = {temperatura}, umiditate = {umiditate}, aer = {aer}";

            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            limitaUmiditate = umiditate;
                            limitaAer = aer;
                            limitaTemperatura = temperatura;
                            MessageBox.Show("Limitele au fost actualizate cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Console.WriteLine("Nu au fost modificate.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butonSchimbareParola_Click(object sender, EventArgs e)
        {
            string parolaCorecta = "";

            try
            {
                string connectionString = "Data Source=xe;User ID=student;Password=student;Unicode=True";
                string query = "SELECT Parola FROM limite";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(query, connection);
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        parolaCorecta = reader["Parola"].ToString();
                        Console.WriteLine(parolaCorecta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("A apărut o eroare la conectare! ");
            }
            string salt = SecurityUtils.GetSalt();
            string parola_din_textBox = CriptareParola(textBoxResetareParola.Text, salt);
            Console.WriteLine($"Parola din textbox: {parola_din_textBox}");
            if (parola_din_textBox != parolaCorecta)
            {
                MessageBox.Show("Parola existenta a fost introdusa gresit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResetareParolaNoua.Text = "";
                textBoxResetareParola.Text = "";
                textBoxResetareParolaConfirmare.Text = "";
                return;
            }
            else
            {
                string parolaNoua = textBoxResetareParolaNoua.Text;
                string confirmareParola = textBoxResetareParolaConfirmare.Text;

                if (string.IsNullOrEmpty(parolaNoua) || string.IsNullOrEmpty(confirmareParola))
                {
                    MessageBox.Show("Introduceți o nouă parolă și confirmați-o.");
                    textBoxResetareParolaNoua.Text = "";
                    textBoxResetareParolaConfirmare.Text = "";
                    return;
                }

                if (parolaNoua.Length < 3 || confirmareParola.Length < 3)
                {
                    MessageBox.Show("Parola trebuie să conțină cel puțin 4 caractere.");
                    textBoxResetareParolaNoua.Text = "";
                    textBoxResetareParolaConfirmare.Text = "";
                    return;
                }

                if (parolaNoua != confirmareParola)
                {
                    MessageBox.Show("Parola și confirmarea parolei nu sunt identice.");
                    textBoxResetareParolaNoua.Text = "";
                    textBoxResetareParolaConfirmare.Text = "";
                    return;
                }
                string parolaCriptata = CriptareParola(textBoxResetareParolaNoua.Text, salt);
                Console.WriteLine($"Parola este corectă: {parolaCriptata}");
                string connectionString = "Data Source=xe;User ID=student;Password=student;Unicode=True";
                string query = $"UPDATE limite SET Parola = '{parolaCriptata}'";

                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        connection.Open();
                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Parola a fost actualizată cu succes în baza de date.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare în timpul actualizării parolei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBoxResetareParolaNoua.Text = "";
                textBoxResetareParola.Text = "";
                textBoxResetareParolaConfirmare.Text = "";
            }
        }

        public static class SecurityUtils
        {
            private static string salt;
            static SecurityUtils()
            {
                if (File.Exists("C:\\Users\\Edy\\Desktop\\Licenta\\salt.txt"))
                {
                    salt = File.ReadAllText("C:\\Users\\Edy\\Desktop\\Licenta\\salt.txt");
                }
                else
                {
                    salt = GenerateSalt();
                    File.WriteAllText("C:\\Users\\Edy\\Desktop\\Licenta\\salt.txt", salt);
                }
            }
            private static string GenerateSalt()
            {
                byte[] saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                return Convert.ToBase64String(saltBytes);
            }

            public static string GetSalt()
            {
                return salt;
            }
        }
        public static string CriptareParola(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static bool VerifyPassword(string inputPassword, string storedHash, string salt)
        {
            string inputHash = CriptareParola(inputPassword, salt);
            return inputHash == storedHash;
        }
        private void SalveazaListaCoduri()
        {
            try
            {
                string caleFisier = "C:\\Users\\Edy\\Desktop\\Licenta\\Lista_coduri.txt";

                using (StreamWriter sw = new StreamWriter(caleFisier))
                {
                    foreach (var cod in coduriPrimite)
                    {
                        sw.WriteLine(cod);
                    }
                }

                Console.WriteLine("Datele au fost scrise cu succes în fișier.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("A apărut o eroare: " + ex.Message);
            }
        }
        private void butonMesaje_Click(object sender, EventArgs e)
        {
            SalveazaListaCoduri();
            UserControlMesaje mesaje = new UserControlMesaje();
            addUserControl(mesaje);
        }

        private void butonStergereMesaje_Click(object sender, EventArgs e)
        {
            butonMesaje.Text = "Mesaje (0)";
            Contor_coduri = 0;
            coduriPrimite.Clear();
        }

        private void LimiteBazaDate()
        {
            string connString = "Data Source=xe;User ID=student;Password=student;";

            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT temperatura, umiditate, aer FROM Limite";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                float temperatura = float.Parse(reader["temperatura"].ToString());
                                float umiditate = float.Parse(reader["umiditate"].ToString());
                                int aer = int.Parse(reader["aer"].ToString());

                                limitaTemperatura = (int)temperatura;
                                limitaUmiditate = (int)umiditate;
                                limitaAer = aer;

                                textBoxLimitaAer.Text = aer.ToString();
                                textBoxLimitaTemp.Text = temperatura.ToString();
                                textBoxLimitaUmid.Text = umiditate.ToString();
                            }
                            else
                            {
                                Console.WriteLine("Nu s-au găsit date în tabelul Limite.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare: " + ex.Message);
                }
            }
        }

        private void butonSetare_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esti sigur ca vrei sa modifici limitele actuale?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ModificaLimite();
            }
        }

        private void butonArmare_Click(object sender, EventArgs e)
        {
            if (StareAlarma == false)
            {
                labelArmare.Text = "Dezarmare sistem:";
                StareAlarma = true;
            }
            else
            {
                labelArmare.Text = "Armare sistem:";
                StareAlarma = false;
            }
        }

        private void UserControlStarePuscarie_Load(object sender, EventArgs e)
        {
            InitializarePortSerial();
            InterceptareDate();
        }
    }
}