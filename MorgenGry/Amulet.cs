using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public enum Level
    {
        low,
        medium,
        high
    }
    public class Amulet : Merchandise
    {

        private string design;
        private Level quality;

        public string Design { get { return design; }set { design = value; } }
        public Level Quality { get { return quality; }set{ quality = value; } }

        
        public Amulet(string itemId, Level quality, string design) //: base(itemId)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium, "")
        {
        }

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }

    }
}

