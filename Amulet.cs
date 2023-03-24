using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet:Merchandise
    {
        
        public string Design { get; set; }
        public Level Quality { get; set; }

        static double LowQualityValue { get; set; } = 12.5;
        static double MediumQualityValue { get; set; } = 20.0;
        static double HighQualityValue { get; set; } = 27.5;


        public Amulet(string itemId , Level quality = Level.medium, string design = "")
           
        {
            base.ItemId = itemId;
            Design = design;
            Quality = quality;

        }
        public override string ToString()
        { return $"ItemId: {base.ItemId}, Quality: {Quality}, Design: {Design}"; }

        public override double GetValue() 
        {
            return 0.0;
        }
    }
}
                
               

        

     
   
