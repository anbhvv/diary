namespace diary
{
    public partial class ����������� : Form
    {
        public �����������()
        {
            InitializeComponent();

            username.Text = "������� ��� ��� ���������";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {

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

        private void �����������_Load(object sender, EventArgs e)
        {

        }

        Point lastPoint;
        private void �����������_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void �����������_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "������� ��� ��� ���������") 
            username.Text = "";
        }

    
    }
}

