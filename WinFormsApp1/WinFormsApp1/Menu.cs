using HelperForm;
namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Size = new Size(1200, 800);
            label1.Text = "Выберете действие :)";
            label1.Size = new Size(300, 200);
            label1.Location = new Point(280, 100);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Size = new Size(300, 150);
            button1.Text = "Найти специальность\nпо параметрам";
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(100, 450);
            button1.Click += Button1_Click;
            Controls.Add(button1);

        }

        private void Second_Load(object sender, EventArgs e)
        {
            Button button2 = new Button();
            button2.Size = new Size(300, 150);
            button2.Text = "Выйти из программы";
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(800, 450);
            button2.Click += Button2_Click;
            Controls.Add(button2);
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            Finder finder = new Finder();
            finder.Show();
            Hide();

        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}