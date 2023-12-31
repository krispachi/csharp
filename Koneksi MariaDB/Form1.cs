using MySqlConnector;

namespace Koneksi_MariaDB {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Kode untuk koneksi ke database
            try {
                string teksKoneksi = "server=localhost;database=db_latihan;user=root;password=";
                using (MySqlConnection koneksi = new MySqlConnection(teksKoneksi)) {
                    koneksi.Open();

                    string teksPerintah = "SELECT * FROM user";
                    using (MySqlCommand perintah = new MySqlCommand(teksPerintah, koneksi)) {

                        MySqlDataReader reader = perintah.ExecuteReader();
                        while (reader.Read()) {
                            // Didalam kurung [] adalah nama field/kolom di database
                            int id = Convert.ToInt32(reader["id"]);
                            string username = Convert.ToString(reader["username"]);
                            string password = Convert.ToString(reader["password"]);

                            Console.WriteLine("ID: " + id);
                            Console.WriteLine("Username: " + username);
                            Console.WriteLine("Password: " + password);
                        }

                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Gagal koneksi ke database: " + ex.Message);
            }
        }
    }
}
