using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    internal class CarDto
    {
        public string CarType { get; set; }
        public string BrandName { get; set; }
        public double DailyPrice { get; set; }
        public double Discounted { get; set; }
        public bool IsDiscounted { get; set; }
    }
}
