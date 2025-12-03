using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6workshop
{
    internal class Price
    {
    public int CalculateFinalPrice(double originalPrice, Func<double, double> strategy) => (int)strategy(originalPrice);

    

    }
}
