using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet a)
        {
            amulets.Add(a);
        }
        public Amulet GetAmulet(string item)
        {
            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId == item)
                {
                    return amulets[i];
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double DidriksLomme = 0;
            for (int i = 0; i < amulets.Count; i++)
            {
                DidriksLomme += Utility.GetValueOfAmulet(amulets[i]);
            }
            return DidriksLomme;
        }
    
    }
}
