using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона
    /// </summary>
    public class PhoneNumber : IEquatable<PhoneNumber>
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        private long _number;

        /// <summary>
        /// Свойства номера телефона
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                if (!value.ToString().StartsWith("7"))
                {
                    throw new ArgumentException("Номер должен начинаться с 7!");
                }

                if (value.ToString().Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 цифр!");
                }

                _number = value;
            }
        }

        public bool Equals(PhoneNumber other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _number == other._number;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PhoneNumber)obj);
        }

        public override int GetHashCode()
        {
            return _number.GetHashCode();
        }
    }
}