using MySql.Data.MySqlClient;

namespace SCTAttendanceSystemUI
{
    public partial class Form1 : Form
    {

        string username, password;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*string cs = "server=localhost;database=login_attendancesystem;uid=root;pwd=root;";
            var con = new MySqlConnection(cs);
            try
            {
                if(textBoxIDNum.Text != "" && textBoxPassword.Text != "")
                {
                con.Open();
                string stm = "select username,password from user WHERE username='" + textBoxIDNum.Text + "' AND password ='" + textBoxPassword.Text + "'";
                var cmd = new MySqlCommand(stm, con);
                    MySqlDataReader row;
                    row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                        }
                        main_form();
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
            con.Close();*/

            this.Hide();
            Home1 form_home1 = new Home1();
            form_home1.ShowDialog();
            this.Close();
        }

        private void main_form()
        {
            this.Hide();
            Home1 form_home1 = new Home1();
            form_home1.ShowDialog();
            this.Close();
        }

        private void textBoxIDNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}