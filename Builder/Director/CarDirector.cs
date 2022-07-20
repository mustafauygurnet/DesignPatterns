using Builder.Abstract;
using Builder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    internal class CarDirector : ICarDirector
    {
        ICarBuilder _carBuilder;
        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public CarDto GenerateCarBuilder()
        {
            _carBuilder.GetCarData();
            _carBuilder.ApplyDiscount();

            return _carBuilder.GetAppliedCar();
        }
    }
}
