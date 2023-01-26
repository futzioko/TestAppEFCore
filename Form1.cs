using System;
using System.Linq;
using System.Windows.Forms;
using Test.Models;
using Test.Models.Entities;

namespace Test
{
    public partial class StudentForm : Form
    {
        private TestContext _testContext;

        public StudentForm()
        {
            InitializeComponent();
            _testContext = new TestContext();

            UpdateComboBox();

            UpdateListBox();
        }

        private void UpdateComboBox()
        {
            foreach (var group in _testContext.Groups.ToList())
            {
                comboBoxGroupNumber.Items.Add(group.Number);
            }
        }

        private void buttonAddGroup_Click(object sender, System.EventArgs e)
        {
            if (textBoxGroupNumber.Text != String.Empty)
            {
                _testContext.Groups.Add(new Groups() { Number = Convert.ToInt32(textBoxGroupNumber.Text) });
                _testContext.SaveChanges();
            }

            comboBoxGroupNumber.Items.Clear();
            UpdateComboBox();
            //listBoxGroups.Items.Clear();
            //UpdateListBox();
        }

        private void UpdateListBox()
        {
            foreach (var student in _testContext.Students.ToList())
            {
                listBoxGroups.Items.Add(student.Name + " " + student.Groups.Number);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxGroupNumber.Text != String.Empty)
            {
                _testContext.Students.Add(new Students()
                {
                    Name = textBoxStudentName.Text,
                    Groups = _testContext.Groups.FirstOrDefault(g => g.Number == Convert.ToInt32(comboBoxGroupNumber.Text))
                });
                _testContext.SaveChanges();
            }

            listBoxGroups.Items.Clear();
            UpdateListBox();
        }
    }
}
