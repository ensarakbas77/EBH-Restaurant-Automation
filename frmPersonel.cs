using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DatabaseProject
{
    public partial class frmPersonel : Form
    {

        public frmPersonel()
        {
            InitializeComponent();
        }

        #region Personle Ekleme Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";
            // Veritabanına eklenecek değerler
            string insertValue1 = gorev.Text.ToString();
            string insertValue2 = f_name.Text;
            string insertValue3 = l_name.Text;
            string insertValue4 = salary.Text.ToString();



            // MySQL bağlantısı ve komutunu oluşturun
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO employee (mission_id,first_name, last_name,salary) VALUES (@insertValue1, @insertValue2,@insertValue3,@insertValue4)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Parametreleri ekleyin
                    command.Parameters.AddWithValue("@insertValue1", insertValue1);
                    command.Parameters.AddWithValue("@insertValue2", insertValue2);
                    command.Parameters.AddWithValue("@insertValue3", insertValue3);
                    command.Parameters.AddWithValue("@insertValue4", insertValue4);

                    // Bağlantıyı açın ve sorguyu çalıştırın
                    connection.Open();
                    command.ExecuteNonQuery();

                };
            };
            // Yeni öğeyi ListView'e ekleyin
            ListViewItem newItem = new ListViewItem();
            newItem.SubItems.Add(insertValue1);
            newItem.SubItems.Add(insertValue2);
            newItem.SubItems.Add(insertValue3);
            newItem.SubItems.Add(insertValue4);
            Bilgiler.Items.Add(newItem);

            //TextBox'ların içini temizleme
            gorev.Clear();
            f_name.Clear();
            l_name.Clear();
            salary.Clear();


        }
        #endregion

        #region Personel Güncelleme Butonu
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";
            if (Bilgiler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Bilgiler.SelectedItems[0];

                // ListView'den seçilen öğenin ID'sini alın
                string itemId = selectedItem.SubItems[0].Text; // Örneğin, ID'nin ilk sütunda olduğunu varsayalım

                // Güncellenecek diğer bilgileri alın
                //string id=textBox1.Text.ToString();
                string updatedValue1 = gorev.Text.ToString();
                string updatedValue2 = f_name.Text;
                string updatedValue3 = l_name.Text;
                string updatedValue4 = salary.Text.ToString(); // Örneğin, güncellenen değeri burada alın

                // Veritabanı güncelleme sorgusunu oluşturun
                string updateQuery = "UPDATE employee SET employee_id=@itemId, mission_id=@uptadeValue1 , first_name = @uptadeValue2 , last_name=@uptadeValue3, salary=@uptadeValue4 WHERE employee_id = @itemId"; // İlgili sütunu güncelleyin

                // MySQL bağlantısı ve komutunu oluşturun
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        // Parametreleri ekleyin
                        command.Parameters.AddWithValue("@uptadeValue1", updatedValue1);
                        command.Parameters.AddWithValue("@uptadeValue2", updatedValue2);
                        command.Parameters.AddWithValue("@uptadeValue3", updatedValue3);
                        command.Parameters.AddWithValue("@uptadeValue4", updatedValue4);
                        command.Parameters.AddWithValue("@itemId", itemId);

                        
                        try
                        {
                            connection.Open();
                            //Sorguyu çalıştırma
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }
                // ListView'deki seçili öğeyi güncelleyin

                selectedItem.SubItems[1].Text = updatedValue1;  //mission_id [1]
                selectedItem.SubItems[2].Text = updatedValue2;  //first_name
                selectedItem.SubItems[3].Text = updatedValue3;  //last_name
                selectedItem.SubItems[4].Text = updatedValue4;  //salary

                gorev.Clear();
                f_name.Clear();
                l_name.Clear(); 
                salary.Clear();
            }
        }
        #endregion

        #region Personel Silme Butonu
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";
            if (Bilgiler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Bilgiler.SelectedItems[0];

                // ListView'den seçilen öğenin ID'sini alın
                string itemId = selectedItem.SubItems[0].Text; // Örneğin, ID'nin ilk sütunda olduğunu varsayalım

                // Veritabanından silme sorgusunu oluşturun
                string deleteQuery = "DELETE FROM employee WHERE employee_id = @itemId"; // ID'yi silme sorgusuna ekleyin

                // MySQL bağlantısı ve komutunu oluşturun
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        // Parametreyi ekleyin
                        command.Parameters.AddWithValue("@itemId", itemId);

                        // Bağlantıyı açın ve sorguyu çalıştırın
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }
                // ListView'den seçilen öğeyi kaldırın
                Bilgiler.Items.Remove(selectedItem);
            }
        }
        #endregion

        #region Görev Ekleme Butonu
        private void grvEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";
            // Veritabanına eklenecek değerler
            string insertValue1 = grvNO.Text.ToString();
            string insertValue2 = grvName.Text;


            // Veritabanı ekleme sorgusunu oluşturun
            // MySQL bağlantısı ve komutunu oluşturun
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO missions (mission_id,mission_name) VALUES (@insertValue1, @insertValue2)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Parametreleri ekleyin

                    command.Parameters.AddWithValue("@insertValue1", insertValue1);
                    command.Parameters.AddWithValue("@insertValue2", insertValue2);

                    // Bağlantıyı açın ve sorguyu çalıştırın
                    connection.Open();
                    command.ExecuteNonQuery();

                };
            };
            // Yeni öğeyi ListView'e ekleyin
            ListViewItem newItem = new ListViewItem(insertValue1);
            newItem.SubItems.Add(insertValue2);
            Gorevler.Items.Add(newItem);

            grvNO.Clear();
            grvName.Clear();
        }
#endregion

        #region Görev Silme Butonu
        private void grvSil_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";
            if (Gorevler.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = Gorevler.SelectedItems[0];

                // ListView'den seçilen öğenin ID'sini alın
                string itemId = selectedItem.SubItems[0].Text; // Örneğin, ID'nin ilk sütunda olduğunu varsayalım

                // Veritabanından silme sorgusunu oluşturun
                string deleteQuery = "DELETE FROM missions WHERE mission_id = @itemId"; // ID'yi silme sorgusuna ekleyin

                // MySQL bağlantısı ve komutunu oluşturun
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        // Parametreyi ekleyin
                        command.Parameters.AddWithValue("@itemId", itemId);

                        // Bağlantıyı açın ve sorguyu çalıştırın

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }

                    }
                }
                // ListView'den seçilen öğeyi kaldırın
                Gorevler.Items.Remove(selectedItem);
            }
        }
        #endregion


        private void frmPersonel_Load(object sender, EventArgs e)
        {
            #region Görev Bilgilerini Listeleme
            Gorevler.Items.Clear();
            // MySQL bağlantı bilgileri
            string connectionString = "server=localhost;uid=root;pwd=12345;database=mydb";

            // MySQL bağlantısı oluştur
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri çekme sorgusu
                string query = "SELECT mission_id,mission_name FROM missions";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Verileri oku
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Her satırı ListView'e ekle
                    while (reader.Read())
                    {
                        int m_id = reader.GetInt32("mission_id");
                        string gorevId = m_id.ToString();
                        string m_name = reader.GetString("mission_name");


                        ListViewItem item = new ListViewItem(gorevId);
                        item.SubItems.Add(m_name);
                        Gorevler.Items.Add(item);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Close();

            }
            #endregion

            #region Personel Bilgilerini Listeleme
            Bilgiler.Items.Clear();
            // MySQL bağlantı bilgileri
            string connectionString2 = "server=localhost;uid=root;pwd=12345;database=mydb";

            // MySQL bağlantısı oluştur
            MySqlConnection connection2 = new MySqlConnection(connectionString2);

            try
            {
                // Bağlantıyı aç
                connection2.Open();

                // Veritabanından veri çekme sorgusu
                string query2 = "SELECT employee_id,mission_id,first_name,last_name,salary FROM employee";
                //string query2 = "SELECT missions.mission_id,missions.mission_name,employee.first_name,employee.last_name,employee.salary,employee.employee_id FROM missions INNER JOIN employee ON missions.mission_id=employee.mission_id";
                MySqlCommand command2 = new MySqlCommand(query2, connection2);

                // Verileri oku
                using (MySqlDataReader reader2 = command2.ExecuteReader())
                {
                    // Her satırı ListView'e ekle
                    while (reader2.Read())
                    {
                        int emp_id = reader2.GetInt32("employee_id");
                        string employee_id = emp_id.ToString();

                        int m_id = reader2.GetInt32("mission_id");
                        string mission_id = m_id.ToString();

                        string f_name = reader2.GetString("first_name");
                        string l_name = reader2.GetString("last_name");

                        double salary = reader2.GetDouble("salary");
                        string iPrice = salary.ToString();

                        ListViewItem item = new ListViewItem(employee_id);
                        item.SubItems.Add(mission_id);
                        item.SubItems.Add(f_name);
                        item.SubItems.Add(l_name);
                        item.SubItems.Add(iPrice);
                        Bilgiler.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection2.Close();

            }

            #endregion

        }
    }
}
