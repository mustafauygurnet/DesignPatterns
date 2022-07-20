using Builder.Abstract;
using Builder.Concrete;
using Builder.OutSourceAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    internal class SuvCarBuilder : ICarBuilder
    {
        public CarDto ApplyDiscount()
        {
            var suvCar = GetCarData();
            suvCar.Discounted = suvCar.DailyPrice;
            suvCar.IsDiscounted = false;
            
            return suvCar;
        }

        public CarDto GetCarData()
        {
            return new CarsAPI().GetCarDto();
            
        }

        public CarDto GetAppliedCar() 
        {
            return ApplyDiscount();
        }
    }
}
