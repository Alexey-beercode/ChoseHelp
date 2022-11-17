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
    public partial class ExtraResult : Form
    {
        Result _lastForm;
        Speciality _result;
        public ExtraResult()
        {
            InitializeComponent();
        }

        public ExtraResult(Speciality result, Result resultForm)
        {
            InitializeComponent();
            label1.Text = result.Name;
            _lastForm = resultForm;
            _result = result;
        }

        private void LinkLabel_CheackedChanges(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_result.Link);
        }
        private void ButtonLast_Click(object? sender, EventArgs e)
        {
            _lastForm.Show();
            Close();
        }

        private void ButtonExit_Click(object? sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
