namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Перечисляет возможные интервалы времени для доставки заказов.
    /// </summary>
    public enum OrderTime
    {
        /// <summary>
        /// Интервал доставки: с 9 до 11 утра.
        /// </summary>
        FromNineToElevenAM,

        /// <summary>
        /// Интервал доставки: с 11 утра до 1 часа дня.
        /// </summary>
        FromElevenToOnePM,

        /// <summary>
        /// Интервал доставки: с 1 до 3 часов дня.
        /// </summary>
        FromOneToThreePM,

        /// <summary>
        /// Интервал доставки: с 3 до 5 часов дня.
        /// </summary>
        FromThreeToFivePM,

        /// <summary>
        /// Интервал доставки: с 5 до 7 часов вечера.
        /// </summary>
        FromFiveToSevenPM,

        /// <summary>
        /// Интервал доставки: с 7 до 9 часов вечера.
        /// </summary>
        FromSevenToNinePM
    }
}
