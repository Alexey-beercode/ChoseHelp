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
    public sealed partial class Finder : Form
    {
        Menu _menuForm = new Menu();
        private string? _subject;
        private int _counter;
        public Finder()
        {
            InitializeComponent();
        }

        public Finder(string? subject)
        {
            InitializeComponent();
            _subject = subject;
            _counter = 3;
        }


        private void RadioButtonElse_CheckedChanges(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                _counter = 2;
            }
        }

        private void RadioButton_SetChecked(object sender, EventArgs e)
        {
            if (_counter != 3)
                return;
            else
            {
                RadioButton button = (RadioButton)sender;
                if (button.Text == _subject)
                    button.Checked = true;
            }
        }
        private void ChangePanel()
        {
            Panel panel2 = new Panel();
            panel2.Size = new Size(350, 300);
            panel2.Location = new Point(500, 250);
            panel2.Controls.Add(radioButton11);
            panel2.Controls.Add(radioButton12);
            panel2.Controls.Add(radioButton13);
            panel2.Controls.Add(radioButton14);
            panel2.Controls.Add(radioButton15);
            panel2.Controls.Add(radioButton16);
            panel2.Controls.Add(radioButton17);
            panel2.Controls.Add(radioButton18);
            panel2.Controls.Add(radioButton19);
            panel2.Controls.Add(radioButton20);
            Controls.Add(panel2);

        }

        private void ButtonExit_Click(object? sender, EventArgs e)
        {
            _menuForm.Show();
            Close();
        }

        private void RadioButton_CheckChanges(object? sender, EventArgs e)
        {
            RadioButton? button = (RadioButton?)sender;
            if (button != null && button.Checked)
            {
                _subject = button.Text;
                _counter = 1;
            }
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            if (_counter == 1 || _counter == 3)
            {
                Finder2 finder = new Finder2(_subject);
                Close();
                finder.Show();
            }
            else if (_counter == 2)
            {
                panel1.Hide();
                ChangePanel();
            }
            else
                MessageBox.Show("Не выбрано направление");
        }

        private void ButtonLast_Click(object? sender, EventArgs e)
        {
            _menuForm.Show();
            Close();

        }
    }
}
