using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string persons = "SELECT * FROM PersonTest ORDER BY Id";
            List<string[]> data = new List<string[]>();
            using (var connection = new SqlConnection(Db.connection))
            {
                connection.Open();
                using (var getPersons = new SqlCommand(persons, connection))
                {
                    SqlDataReader reader = getPersons.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                }
            }

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        bool isValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            empty.Visible = false;
            emailError.Visible = false;
            if (nameInput.Text.Trim() == "" || surnameInput.Text.Trim() == "" || phoneInput.Text.Trim() == "" || emailInput.Text.Trim() == "")
            {
                empty.Visible = true;
                return;
            }
            else if (!isValid(emailInput.Text.Trim()))
            {
                emailError.Visible = true;
            }
            else
            {
                string addPersons = $"INSERT INTO PersonTest (Name, Surname, Phone, Email)  VALUES('{nameInput.Text}', '{surnameInput.Text}', '{phoneInput.Text}', '{emailInput.Text}')";
                using (var connection = new SqlConnection(Db.connection))
                {
                    connection.Open();
                    using (var getPersons = new SqlCommand(addPersons, connection))
                    {
                        getPersons.ExecuteNonQuery();
                    }
                }
                dataGridView1.Rows.Clear();
                LoadData();

                nameInput.Text = "";
                surnameInput.Text = "";
                phoneInput.Text = "";
                emailInput.Text = "";
            }
        }
    }
}
