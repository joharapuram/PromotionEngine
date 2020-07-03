using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PriceCalculator
    {
        public int GetTotalPrice(List<SKUProduct> products)
        {
            int counterofA = 0, counterofB = 0, CounterofC = 0, CounterofD = 0;
            
            int priceofA = 50, priceofB = 30, priceofC = 20, priceofD = 15;           

            foreach (SKUProduct pr in products)
            {
                if (pr.Id == "A")
                    counterofA = counterofA + 1;

                else if (pr.Id == "B")
                    counterofB = counterofB + 1;

                else if (pr.Id == "C")
                    CounterofC = CounterofC + 1;

                else if (pr.Id == "D")
                    CounterofD = CounterofD + 1;
            }

            int totalPriceofA = (counterofA * priceofA);
            int totalPriceofB = (counterofB * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);

            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;            
        }
    }
}
