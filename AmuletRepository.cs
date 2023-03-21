using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet) 
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId) 
        { 
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId) { return amulet; }
            }
            return null; 
        }

        public double GetTotalValue() 
        {
            Utility amuletUtilityObject = new Utility();
            double totalValue = 0;
            foreach (Amulet amulet in amulets)
            {
                double amuletValue = amuletUtilityObject.GetValueOfAmulet(amulet);
                totalValue += amuletValue;
                
            }
            return totalValue;
            return 0; 
        }
    }
}
