using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string Itemid { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }


        public Amulet(string itemid, Level quality = Level.medium, string design = "")
        {
            Itemid = itemid;
            Design = design;
            Quality = quality;

        }
        public override string ToString()
        { return $"ItemId: {Itemid}, Quality: {Quality}, Design: {Design}"; }

    }
}
                
               

        

     
   
