using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Shoes_store.Models
{
    public class ShoesDbInitializer:DropCreateDatabaseAlways<ShoesContext>
    {
        protected override void Seed(ShoesContext db)
        {
            db.Shoes.Add(new Shoes { Firma = "Adidas", Name = "Easy boost 350", Size = 41, Price = 3220 });
            db.Shoes.Add(new Shoes { Firma = "Reebok", Name = "Classic", Size = 42, Price = 5180 });
            db.Shoes.Add(new Shoes { Firma = "Puma", Name = "Turin", Size = 43, Price = 7150 });

            base.Seed(db);
        }
    }
}