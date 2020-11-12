using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoes_store.Models
{
    public class Shoes
    {
        // ID обуви
        public int Id { get; set; }
        // Фирма обуви
        public string Firma { get; set; }
        // Название модели
        public string Name { get; set; }
        // Размер обуви
        public int Size { get; set; }
        // Цена
        public int Price { get; set; }
    }
}