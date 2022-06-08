using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _name;

        /// <summary>
        /// Email контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// VK ID контакта
        /// </summary>
        private string _vkID;

        /// <summary>
        /// День рождения контакта
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();

        /// <summary>
        /// Свойства фамилии контакта вместе с проверкой на длину
        /// и изменением регистра первого символа
        /// </summary>
        public string Surname
        {
            get { return _surname; }

            set
            {
                CheckLength(value, 50);
                _surname = ChangeRegisterOfFirstSymbol(value);
            }
        }

        /// <summary>
        /// Свойства имени контакта вместе с проверкой на длину
        /// и изменением регистра первого символа
        /// </summary>
        public string Name
        {
            get { return _name; }

            set
            {
                CheckLength(value, 50);
                _name = ChangeRegisterOfFirstSymbol(value);
            }
        }

        /// <summary>
        /// Свойства Email контакта вместе с проверкой на длину
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                CheckLength(value, 50);
                _email = value;
            }
        }

        /// <summary>
        /// Свойства VK ID контакта вместе с проверкой на длину
        /// </summary>
        public string VKID
        {
            get
            {
                return _vkID;
            }
            set
            {
                CheckLength(value, 15);
                _vkID = value;
            }
        }

        /// <summary>
        /// Свойство день рождения контакта
        /// с проверкой на актуальность даты
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }

            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Год рождения не может быть меньше 1900 года!");
                }
                //TODO: Исправить на null
                //if (Birthday > DateTime.Today)
                //{
                //    throw new ArgumentException("День рождения не может быть больше сегодняшней даты!");
                //}

                _birthday = value;
            }
        }

        /// <summary>
        /// Проверка длины передаваемой строки на допустимый размер
        /// </summary>
        /// <param name="strings">Принимаемая строка</param>
        /// <param name="permissibleLength">Допустимая длина строки</param>
        private void CheckLength(string strings, int permissibleLength)
        {
            if (strings.Length > permissibleLength)
            {
                throw new ArgumentException("Переменная не может содержать больше " + permissibleLength + " символов!");
            }
        }

        private string ChangeRegisterOfFirstSymbol(string value)
        {
            if (value != "")
            {
                string newValue = value.ToUpper()[0] + value.Substring(1);
                return newValue;
            }

            return value;
        }

        public Contact()
        {

        }

        /// <summary>
        /// Конструктор контакта
        /// </summary>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="email">Email</param>
        /// <param name="vkId">VK ID</param>
        /// <param name="birthday">День рождения</param>
        public Contact(PhoneNumber phoneNumber, string surname, string name, string email, string vkId, DateTime birthday)
        {
            PhoneNumber = phoneNumber;
            Surname = surname;
            Name = name;
            Email = email;
            VKID = vkId;
            Birthday = birthday;
        }

        /// <summary>
        /// Копирование объекта
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}