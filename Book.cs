using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public class Book:Merchandise
    {
      
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId, string title = "", double price = 0)
            
        { 
            base.ItemId = itemId; 
            Title = title; 
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

        public override double GetValue()
        {
            return 0.0;
        }
    }
}
