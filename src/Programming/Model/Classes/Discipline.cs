using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model;

namespace Programming
{
    /// <summary>
    /// Хранит данные о учебной дисциплине
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Название предмета
        /// </summary>
        private string _subject;

        /// <summary>
        /// Имя преподователя
        /// </summary>
        private string _professor;

        /// <summary>
        /// Оценка
        /// </summary>
        private int _grade;

        /// <summary>
        /// Возвращает и задает название предмета
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Возвращает и задает имя профессора
        /// </summary>
        public string Professor { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должна состоять только из цифр
        /// </summary>
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 5);
                _grade = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>
        /// </summary>
        /// <param name="subject">Название предмета</param>
        /// <param name="professor">Имя преподователя</param>
        /// <param name="grade">Оценка. Должна состоять только из цифр</param>
        public Discipline(string subject, string professor, int grade)
        {
            Subject = subject;
            Professor = professor;
            Grade = grade;
        }

        public Discipline() { }
    }
}
