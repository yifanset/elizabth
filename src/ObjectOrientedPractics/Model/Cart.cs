﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о корзине
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Класс для представления корзины, содержащей список товаров.
        /// Позволяет управлять элементами корзины и вычислять общую стоимость.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список элементов, содержащихся в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Общая стоимость элементов в корзине.
        /// Если корзина пуста, возвращает 0.
        /// </summary>
        public double Amount
        {
            get
            {
                double sum = 0.0;
                if (_items.Count == 0 || _items == null)
                {
                    return 0.0;
                }
                foreach (var item in _items)
                {
                    sum += item.Cost;
                }
                return sum;
            }
        }
    }
}
