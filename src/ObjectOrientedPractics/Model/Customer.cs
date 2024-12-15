using ObjectOrientedPractics;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о клиентах
    /// </summary>
    public class Customer
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
        /// ФИО
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адресс
        /// </summary>
        private Address _address;

        /// <summary>
        /// Поле для хранения корзины клиента
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Поле для хранения списка товаро
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает флаг, приоритетный ли покупатель.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Возвращает и задает ФИО. Длина небольше 200 символов
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                Validator.AssertStringOnLength(value, 200, "ФИО");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс. Длина небольше 500 символов
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса
        /// </summary>
        public int Id
        {
            get { return _id; }
        }


        /// <summary>
        /// Свойство для получения корзины клиента
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
        }

        /// <summary>
        /// Заказы клиента.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задает скидки покупателя.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">ФИО, длина небольше 200 смиволов</param>
        /// <param name="address">Адресс, длина небольше 500 смиволов</param>
        public Customer(string fullname, Address address)
        {
            _countId += 1;
            _id = _countId;
            _cart = new Cart();
            Fullname = fullname;
            Address = address;
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}
