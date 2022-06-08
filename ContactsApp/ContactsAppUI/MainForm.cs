using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса Project
        /// </summary>
        private Project _project = ProjectManager.LoadFromFile
            (ProjectManager.MyPath, ProjectManager.FileName);

        /// <summary>
        /// Список контактов
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _contacts = _project.Contacts;
            InsertToListBox();
            if (_contacts.Count > 0)
            {
                surnameListBox.SelectedIndex = 0;
                InputInformationOfContact(0);
            }
            SearchBirthdaySurnames();
        }

        /// <summary>
        /// Выводит информацию о контакте по индексу
        /// </summary>
        /// <param name="index">индекс контакта</param>
        private void InputInformationOfContact(int index)
        {
            if (index == -1) return;

            var contact = _contacts[index];
            surnameBox.Text = contact.Surname;
            nameBox.Text = contact.Name;
            birthdayDateTimePicker.Value = contact.Birthday;
            phoneTextBox.Text = contact.PhoneNumber.Number.ToString();
            vkTextBox.Text = contact.VKID;
            emailTextBox.Text = contact.Email;
        }

        /// <summary>
        /// Выводит все контакты в список
        /// </summary>
        private void InsertToListBox()
        {
            _contacts = new List<Contact>();
            _contacts = _project.SearchContactByString(findBox.Text);
            _contacts = _contacts.OrderBy(t => t.Surname).ToList();

            for (int index = 0; index < _contacts.Count; index++)
            {
                surnameListBox.Items.Insert(index, _contacts[index].Surname);
            }
        }

        /// <summary>
        /// Удаляет выбранный контакт
        /// </summary>
        private void DeleteContact()
        {
            if (surnameListBox.SelectedItem == null)
            {
                MessageBox.Show("Select contact!");
                return;
            }
            int index = surnameListBox.SelectedIndex;
            DialogResult result =
                MessageBox.Show("Do you really want to remove this contact: " +
                                $"{_contacts[index].Surname}",
                    "Remove Contact", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(_project.Contacts.IndexOf(
                    _contacts[index]));
            }
            ProjectManager.SaveToFile(_project, ProjectManager.FileName);
            surnameListBox.Items.Clear();
            InsertToListBox();
            if (_contacts.Count > 0)
            {
                surnameListBox.SelectedIndex = 0;
                InputInformationOfContact(0);
            }
            else
            {
                ClearInformationOfContact();
            }

            SearchBirthdaySurnames();
        }

        /// <summary>
        /// Чистит информацию во всех TextBox
        /// </summary>
        private void ClearInformationOfContact()
        {
            surnameBox.Text = "";
            nameBox.Text = "";
            phoneTextBox.Text = "";
            vkTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void findBox_TextChanged(object sender, EventArgs e)
        {
            _contacts = new List<Contact>();
            string searchString = findBox.Text;
            _contacts = _project.SearchContactByString(searchString);
            surnameListBox.Items.Clear();
            InsertToListBox();
            if (_contacts.Count > 0)
            {
                surnameListBox.SelectedIndex = 0;
                InputInformationOfContact(0);
            }
        }

        private void OpenAddForm()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();

            if (contactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(contactForm.Contact);
                ProjectManager.SaveToFile(_project, ProjectManager.FileName);
                _contacts = _project.Contacts;
                surnameListBox.Items.Clear();
                InsertToListBox();
            }
            SearchBirthdaySurnames();
        }

        private void OpenEditForm()
        {
            if (surnameListBox.SelectedItem == null)
            {
                MessageBox.Show("Select contact");
                return;
            }

            int index = surnameListBox.SelectedIndex;
            ContactForm contact = new ContactForm();
            contact.Contact = (Contact)_contacts[index].Clone();
            contact.ShowDialog();
            if (contact.DialogResult == DialogResult.OK)
            {
                var contactIndex = _project.Contacts.IndexOf(
                    _contacts[index]);
                _project.Contacts[contactIndex]
                    = (Contact)contact.Contact.Clone();
            }
            ProjectManager.SaveToFile(_project, ProjectManager.FileName);
            surnameListBox.Items.Clear();
            InsertToListBox();
            SearchBirthdaySurnames();
        }

        private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (surnameListBox.SelectedIndex != -1)
            {
                birthdayDateTimePicker.Value = _contacts[surnameListBox.SelectedIndex].Birthday;
            }
            else
            {
                birthdayDateTimePicker.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// находит контакты у которых сегодня день рождения 
        /// </summary>
        void SearchBirthdaySurnames()
        {
            surnameBLabel.Text = "";
            surnameBLabel.Text = _project.SearchSurnamesByBirthday(_contacts);
            if (surnameBLabel.Text != "")
            {
                panelBirthday.Visible = true;
            }
            else if (surnameBLabel.Text == "")
            {
                panelBirthday.Visible = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddForm();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenAddForm();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void surnameListBox_Click(object sender, EventArgs e)
        {
            int index = surnameListBox.SelectedIndex;
            InputInformationOfContact(index);
        }
    }
}