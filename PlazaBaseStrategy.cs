using System;
using System.Collections.Generic;
using StockSharp.BusinessEntities;
// Для работы с коллекциямии
// Для LINQ запросов

// Для отправки почты
// Для работы с файлами

namespace PrismaBoy
{
    abstract class PlazaBaseStrategy: MyBaseStrategy
    {
        /// <summary>
        /// Конструктор класса PlazaBaseStrategy
        /// </summary>
        protected PlazaBaseStrategy(List<Security> securityList, Dictionary<string, decimal> securityVolumeDictionary, TimeSpan timeFrame, decimal stopLossPercent, decimal takeProfitPercent)
            : base(securityList, securityVolumeDictionary, timeFrame, stopLossPercent, takeProfitPercent)
        {            
            
        }
    }


}
