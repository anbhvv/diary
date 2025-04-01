using MySql.Data.MySqlClient;

namespace diary
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `info`) VALUES (@login, @pass, @name, @info)", dB.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = username.Text;
            command.Parameters.Add("@info", MySqlDbType.VarChar).Value = phoneemail.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
            }
            else
            {
                MessageBox.Show("Ошибка создания аккаунта");
            }

            dB.closeConnection();   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }

        Point lastPoint;

        public string Value { get; private set; }

        private void Регистрация_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void
            Регистрация_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void
            label3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

