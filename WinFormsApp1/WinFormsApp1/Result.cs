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
    public partial class Result : Form
    {
        private readonly List<Speciality?>? _list;

        public Result() => InitializeComponent();

        public Result(List<Speciality?> list)
        {
            InitializeComponent();
            _list = list;
            if (list.Count == 0)
            {
                label1.Text = "Специальности не найдены";
                label1.Location = new Point(180, 100);
                checkedListBox1.Hide();
                find.Hide();
            }
            else
                foreach (var speciality in _list)
                {
                    checkedListBox1.Items.Add(speciality.Name);
                }
        }
        private void checkedListBoxItem_ChechedChanges(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
        }

        private void ButtonLast_Click(object? sender, EventArgs e)
        {
            Close();
            Finder3 form = new();
            form.Show();
        }

        private void ButtonExit_Click(object? sender, EventArgs e)
        {
            Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            foreach (var speciality in _list)
            {
                if (speciality.Name == checkedListBox1.SelectedItem)
                {
                    ExtraResult result = new ExtraResult(speciality, this);
                    Hide();
                    result.Show();
                }
            }
        }
    }
}
