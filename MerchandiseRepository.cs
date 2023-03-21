using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> _merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise) 
        {
            _merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId) 
        {
            foreach (Merchandise merchandise in _merchandises)
            {
                if (itemId == merchandise.ItemId) { return merchandise; }
            }
            
            return null;
        }
        Utility utilityObject = new Utility();
        double totalValue = 0;
        public double GettotalValue() 
        {
            foreach  (Merchandise merchandise in _merchandises)
            {
                totalValue += utilityObject.GetValueOfMerchandise(merchandise);
            }
            return 0.0;
        }
    }
}
