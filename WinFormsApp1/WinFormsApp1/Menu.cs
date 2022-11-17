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