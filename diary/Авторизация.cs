using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace diary;

public partial class Авторизация : Form
{
    public Авторизация()
    {
        InitializeComponent();
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Label1_Click(object sender, EventArgs e)
    {

    }

    private void Label2_Click(object sender, EventArgs e)
    {

    }

    private void TextBox1_login(object sender, EventArgs e)
    {

    }

    private void TextBox2_password(object sender, EventArgs e)
    {

    }

    private void Label4_Click(object sender, EventArgs e)
    {

    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void PictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void Авторизация_Load(object sender, EventArgs e)
    {

    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {

    }
    Point lastPoint;
    private void Авторизация_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            this.Left += e.X - lastPoint.X;
            this.Top += e.Y - lastPoint.Y;
        }
    }

    private void Авторизация_MouseDown(object sender, MouseEventArgs e)
    {
        lastPoint = new Point(e.X, e.Y);
    }

    private void Buttonlogin_Click(object sender, EventArgs e)
    {
        String loginUser = login.Text;
        String passUser = password.Text;

        DB db = new();

        DataTable table = new();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
        command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
        command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

        adapter.SelectCommand = command;
        adapter.Fill(table);

        if (table.Rows.Count > 0)
            MessageBox.Show("Пользователь авторизован.") ;
        else
            MessageBox.Show("Пользователь не авторизован. Повторите попытку.");
    }
}
