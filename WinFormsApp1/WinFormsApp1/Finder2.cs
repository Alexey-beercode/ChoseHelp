using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace HelperForm
{
    public sealed partial class Finder2 : Form
    {
        int? Min { get; set; }
        int? Max { get; set; }
        string? Subject { get; set; }

        TextBox _minValue = new TextBox();
        TextBox _maxValue = new TextBox();

        Menu _menuForm = new Menu();


        public Finder2()
        {
            InitializeComponent();
            Size = new Size(1200, 800);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
        }

        public Finder2(string? subject)
        {
            InitializeComponent();
            Size = new Size(1200, 800);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Subject = subject;
        }

        public Finder2(int? max, int? min, string? subject)
        {
            InitializeComponent();
            Size = new Size(1200, 800);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Min = min;
            Max = max;
            _minValue.Text = min.ToString();
            _maxValue.Text = max.ToString();
            Subject = subject;
        }

        private void Finder2_Load(object? sender, EventArgs e)
        {
            Button exit = new Button();
            exit.Size = new Size(150, 50);
            exit.BackColor = Color.RosyBrown;
            exit.Text = "Меню";
            exit.Location = new Point(50, 650);
            Button next = new Button();
            next.Size = new Size(150, 50);
            next.BackColor = Color.RosyBrown;
            next.Text = "Далее";
            next.Location = new Point(1000, 650);
            Button last = new Button();
            last.Size = new Size(150, 50);
            last.BackColor = Color.RosyBrown;
            last.Text = "Назад";
            last.Location = new Point(500, 650);
            exit.Click += ButtonExit_Click;
            next.Click += ButtonNext_Click;
            last.Click += ButtonLast_Click;
            _minValue.TextChanged += new EventHandler(minValue_ChangedText);
            _maxValue.TextChanged += new EventHandler(maxValue_ChangedText);
            _maxValue.Location = new Point(500, 430);
            _minValue.Location = new Point(500, 330);
            Controls.Add(last);
            Controls.Add(exit);
            Controls.Add(next);
            Controls.Add(_minValue);
            Controls.Add(_maxValue);
        }

        private void label_Load(object? sender, EventArgs e)
        {
            label1.Location = new Point(270, 100);
            label1.Text = "Введите значения ЦТ";
            Label label2 = new Label();
            label2.Font = new Font("Intro", 15F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point);
            label2.Text = "От :";
            label2.Size = new Size(100, 30);
            Label label3 = new Label();
            label3.Font = new Font("Intro", 15F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point);
            label3.Text = "До :";
            label3.Size = new Size(100, 30);
            label3.Location = new Point(500, 400);
            label2.Location = new Point(500, 300);
            Controls.Add(label2);
            Controls.Add(label3);
        }

        private void ButtonLast_Click(object? sender, EventArgs e)
        {
            Close();
            Finder _lastForm = new Finder(Subject);
            _lastForm.Show();
        }
        private void ButtonExit_Click(object? sender, EventArgs e)
        {
            _menuForm.Show();
            Close();
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            if (Min != null && Max != null)
            {
                if (Min <= Max && Min <= 400 && Min >= 0 && Max >= 0 && Max <= 400)
                {
                    Finder3 finder = new Finder3(Subject, Max, Min);
                    Close();
                    finder.Show();
                }
                else MessageBox.Show("Введены неверные значения");
            }
            else MessageBox.Show("Не введены значения");

        }

        private void minValue_ChangedText(object? sender, EventArgs e)
        {
            try
            {
                Min = int.Parse(_minValue.Text);
            }
            catch
            {
                MessageBox.Show("Введено неверное значение");
                Finder2 finder2 = new Finder2(Subject);
                finder2.Show();
                Close();
            }
        }

        private void maxValue_ChangedText(object? sender, EventArgs e)
        {
            try
            {
                Max = int.Parse(_maxValue.Text);
            }
            catch
            {
                MessageBox.Show("Введено неверное значение");
                Finder2 finder2 = new Finder2(Subject);
                finder2.Show();
                Close();
            }
        }
    }
}
