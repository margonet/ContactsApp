using System;


namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        private int _number;

        /// <summary>
        /// Свойства номера телефона
        /// </summary>
        public int Number
        {
            get { return _number; }
            set
            {
                if (!Number.ToString().StartsWith("7"))
                {
                    throw new ArgumentException("Номер должен начинаться с 7!");
                }

                if (Number.ToString().Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 цифр!");
                }
            }
        }
    }
}
