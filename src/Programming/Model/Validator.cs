using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Выполняет проверку данных
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что значение положительное
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value)
        {
            if (value <= 0)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет, что значение положительное
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value)
        {
            if (value <= 0)
                throw new ArgumentException(nameof(value));
        }

        /// <summary>
        /// Проверяет что значение находится в заданом диапозоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
        /// <summary>
        /// Проверяет что значение находится в заданом диапозоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, double min, double max)
        {
            if (value < min || value > max)
                throw new ArgumentException(nameof(value));
        }
    }
}
