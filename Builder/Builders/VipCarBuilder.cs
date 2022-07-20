using Builder.Abstract;
using Builder.Concrete;
using Builder.OutSourceAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class VipCarBuilder : ICarBuilder
    {
        public CarDto ApplyDiscount()
        {
            var vipCar = GetCarData();
            
            vipCar.Discounted = vipCar.DailyPrice - vipCar.DailyPrice * 0.15;
            vipCar.IsDiscounted = true;

            return vipCar;
        }

        public CarDto GetAppliedCar()
        {
            return ApplyDiscount();
        }

        public CarDto GetCarData()
        {
            return new CarsAPI().GetCarDto();
        }
    }
}
