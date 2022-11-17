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
    public partial class Finder3 : Form
    {
        private string? _subject;
        private int? _max;
        private int? _min;
        private bool _freePay;
        private int _counter;
        Menu _menuForm = new Menu();

        public Finder3() => InitializeComponent();
        public Finder3(string? subject, int? max, int? min)
        {
            InitializeComponent();
            _subject = subject;
            _max = max;
            _min = min;
        }

        private void ButtonLast_Click(object? sender, EventArgs e)
        {
            Close();
            Finder2 _lastForm = new Finder2(_max, _min, _subject);
            _lastForm.Show();
        }

        private void ButtonExit_Click(object? sender, EventArgs e)
        {
            _menuForm.Show();
            Close();
        }

        private void RadioButton1_CheckChanges(object? sender, EventArgs e)
        {
            RadioButton? button = (RadioButton?)sender;
            if (button != null && button.Checked)
            {
                _freePay = true;
                _counter = 1;
            }
        }

        private void RadioButton2_CheckChanges(object? sender, EventArgs e)
        {
            RadioButton? button = (RadioButton?)sender;
            if (button != null && button.Checked)
            {
                _freePay = false;
                _counter = 1;
            }
        }

        private Speciality.Subjects? SetSubject(string? subject)
        {
            if (subject == "Программирование")
                return Speciality.Subjects.Programming;
            else if (subject == "Менеджмент")
                return Speciality.Subjects.Management;
            else if (subject == "Биология")
                return Speciality.Subjects.Biology;
            else if (subject == "Философия")
                return Speciality.Subjects.Philosophy;
            else if (subject == "Физика")
                return Speciality.Subjects.Physics;
            else if (subject == "Математика")
                return Speciality.Subjects.Math;
            else if (subject == "Искусство")
                return Speciality.Subjects.Art;
            else if (subject == "Химия")
                return Speciality.Subjects.Chemistry;
            else if (subject == "Юриспруденция")
                return Speciality.Subjects.Jurisprudence;
            else if (subject == "Международные отношения")
                return Speciality.Subjects.InternationalRelationships;
            else if (subject == "Медицина")
                return Speciality.Subjects.Medicine;
            else if (subject == "Иностранные языки")
                return Speciality.Subjects.ForeignLanguages;
            else if (subject == "Экономика")
                return Speciality.Subjects.Economy;
            else if (subject == "Робототехника")
                return Speciality.Subjects.Robotics;
            else if (subject == "Радиоэлектроника")
                return Speciality.Subjects.RadioElectronics;
            else if (subject == "Машиностроение")
                return Speciality.Subjects.MechanicalEngineering;
            else if (subject == "История")
                return Speciality.Subjects.History;
            else if (subject == "Маркетинг")
                return Speciality.Subjects.Marketing;
            else if (subject == "Педагогика")
                return Speciality.Subjects.Pedagogy;
            else return null;
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            if (_counter == 1)
            {
                Result result = new Result(Speciality.Finder(_max, _min, SetSubject(_subject), _freePay));
                result.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не выбрана форма обучения");
            }
        }
    }
}
