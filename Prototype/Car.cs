using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Car
    {
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public CarStyle CarStyle {get;set;}

        public Car ShallowCopy()
        {
            return (Car) this.MemberwiseClone();
        }

        public Car DeepCopy()
        {
            Car car = (Car)this.MemberwiseClone();
            car.CarStyle = new CarStyle(this.CarStyle.Style);

            return car;
        }
    }
}
