using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoes_store.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        public string Person { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID обуви
        public int ShoesId { get; set; }
        //Комментарий
        public string Comments { get; set; }
        //Оценка товара
        public int Estimation { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}