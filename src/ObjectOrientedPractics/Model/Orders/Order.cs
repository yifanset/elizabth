using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Order
{
    public class Order
    {
        /// <summary>
        /// поле-счетчик
        /// </summary>
        private static int _countId;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Адрес доставки для данного заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Суммарная скидка заказа.
        /// </summary>
        public double DiscountAmount { get; }

        /// <summary>
        /// Вычисляет и возвращает общую стоимость заказа, суммируя стоимость всех товаров.
        /// </summary>
        public double TotalAmount
        {
            get
            {
                double total = 0.0;
                foreach (Item item in _items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        /// <summary>
        /// Возвращает время для объектов данного класса
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает или задает адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает или задает список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает или задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return TotalAmount - DiscountAmount;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/> с указанными адресом доставки и списком товаров.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address deliveryAddress, List<Item> items, double discountAmount)
        {
            _id = _countId++;
            _date = DateTime.Now;
            Address = deliveryAddress;
            Items = items ?? new List<Item>();
            Status = OrderStatus.New;
            DiscountAmount = discountAmount;
        }
    }
}
