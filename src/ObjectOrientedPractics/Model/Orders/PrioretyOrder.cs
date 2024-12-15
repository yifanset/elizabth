using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Order;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Order
{
    /// <summary>
    /// Хранит данные о приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public OrderTime Time { get; set; }

        /// <summary>
        /// Создает экзепляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        public PriorityOrder(
            Address address,
            List<Item> items,
            double discountAmount) : base(address, items, discountAmount)
        {
            Date = DateTime.Now;
        }
    }
}
