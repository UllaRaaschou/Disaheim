using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim;



public class Utility
{
   
    

    
    
    public double GetValueOfMerchandise(Merchandise merchandise) 
    {
        
        if (merchandise is Amulet amulet) 
        {
            switch (amulet.Quality)
            {
                case Level.low: return 12.5;
                    break;
                case Level.medium: return 20.0;
                    break;
                case Level.high: return 27.5;
                default: return 0.0;
                    break;
            }
        }
        if (merchandise is Book book) 
        {
            return book.Price;
        }
        return 0.0;
    }
    
    
    
    public double GetValueOfBook(Book book)
    {
        return book.Price;

    }
    public double GetValueOfAmulet(Amulet amulet)
    {
        if (amulet.Quality == Level.low) { return 12.5; }
        if (amulet.Quality == Level.medium) { return 20; }
        if (amulet.Quality == Level.high) { return 27.5; }
        return 0;
    }

}
