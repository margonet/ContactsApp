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
    public partial class ContactForm : Form
    {

        private Contact _contact;
        public ContactForm()
        {
            InitializeComponent();
        }

        private Color successColor = Color.White;
        private Color errorColor = Color.Brown;

        public Contact Contact
        {
            get { return _contact; }

            set
            {
                _contact = new Contact(value.PhoneNumber, value.Surname,
                    value.Name, value.Email, value.VKID, value.Birthday);
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            if (_contact != null)
            {
                surnameBox.Text = _contact.Surname;
                nameBox.Text = _contact.Name;
                birthdayDateTimePicker.Value = _contact.Birthday;
                phoneBox.Text = _contact.PhoneNumber.Number.ToString();
                emailBox.Text = _contact.Email;
                vkBox.Text = _contact.VKID;
            }
            else
            {
                _contact = new Contact();
                _contact.Birthday = DateTime.Now;
                birthdayDateTimePicker.Value = DateTime.Now;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show
            ("Do you want close this form? Data will not save.",
                "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// При нажатии на кнопку ОК проходит првоерка на корректность введенных данных
        /// В случае наличия неправильных данных появляется окно со списком ошибок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            string inputError = "Error list:\n";

            if ((surnameBox.BackColor == errorColor) || (surnameBox.Text == ""))
            {
                inputError += "incorrect surname.\n";
            }

            if ((nameBox.BackColor == errorColor) || (nameBox.Text == ""))
            {
                inputError += "incorrect name.\n";
            }

            if (birthdayDateTimePicker.BackColor == errorColor)
            {
                inputError += "incorrect date.\n";
            }

            if ((phoneBox.BackColor == errorColor) || (phoneBox.Text == ""))
            {
                inputError += "incorrect phone.\n";
            }

            if ((emailBox.BackColor == errorColor) || (emailBox.Text == ""))
            {
                inputError += "incorrect e-mail.\n";
            }

            if ((vkBox.BackColor == errorColor) || (vkBox.Text == ""))
            {
                inputError += "incorrect vk.com.";
            }

            if (inputError != "Error list:\n")
            {
                MessageBox.Show(inputError, "Error");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            surnameBox.BackColor = successColor;
            try
            {
                _contact.Surname = surnameBox.Text;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                surnameBox.BackColor = errorColor;
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            nameBox.BackColor = successColor;
            try
            {
                _contact.Name = nameBox.Text;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                nameBox.BackColor = errorColor;
            }
        }

        private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            birthdayDateTimePicker.BackColor = successColor;
            try
            {
                _contact.Birthday = birthdayDateTimePicker.Value;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                birthdayDateTimePicker.BackColor = errorColor;
                birthdayDateTimePicker.Invalidate();
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneBox.BackColor = successColor;
            if ((phoneBox.Text.All(char.IsDigit)) && (phoneBox.Text != ""))
            {
                try
                {
                    PhoneNumber value = new PhoneNumber();
                    value.Number = long.Parse(phoneBox.Text);
                    _contact.PhoneNumber = value;
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception);
                    phoneBox.BackColor = errorColor;
                }
            }
            else
            {
                phoneBox.BackColor = errorColor;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailBox.BackColor = successColor;
            try
            {
                _contact.Email = emailBox.Text;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                emailBox.BackColor = errorColor;
            }
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            vkBox.BackColor = successColor;
            try
            {
                _contact.VKID = vkBox.Text;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception);
                vkBox.BackColor = errorColor;
            }
        }
    }
}
