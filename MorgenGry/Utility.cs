using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class Utility
    {
        public static double GetValueOfBook(Book b1)
        {
            return b1.Price;
        }

        public static double GetValueOfAmulet(Amulet a11)
        {
            if (a11.Quality.ToString() == "low")
            {
                return 12.5;
            }
            else if (a11.Quality.ToString() == "high")
            {
                return 27.5;
            }
            else
            {
                return 20.0;
            }
        }

        public static double GetValueOfCourse(Course c111)
        {
            double heletimer= c111.DurationInMinutes / 60;
            double rest = c111.DurationInMinutes % 60;
            if(rest > 30)
            {
                return (heletimer + 1) * 875;
            }
            else
            {
                return heletimer * 875;
            }
        }
    }
}
