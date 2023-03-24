using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository

    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string itemId)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                    if (merchandise.ItemId == itemId) return valuable;
                if (valuable is Course course)
                    if (course.Name == itemId) return course;
            }
            return null;

        }


        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (IValuable valuable in valuables)
            {
                totalValue += valuable.GetValue();
            }
            return totalValue;

        }



        public int Count()

        {
            int count = 0;
            foreach (IValuable valuable in valuables)
            { count++; }
            return count;
        }

    }
}
