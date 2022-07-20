using Builder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Abstract
{
    internal interface ICarBuilder
    {
        CarDto GetCarData();
        CarDto ApplyDiscount();
        CarDto GetAppliedCar();
    }
}
