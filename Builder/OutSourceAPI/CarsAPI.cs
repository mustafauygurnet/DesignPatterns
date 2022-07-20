using Builder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.OutSourceAPI
{
    internal class CarsAPI
    {
        internal CarDto GetSuvCarDto()
        {
            CarDto carDto = new CarDto();
            
            carDto.CarType = "SUV";
            carDto.BrandName = "AUDI";
            carDto.DailyPrice = 100;

            return carDto;
        }

        internal CarDto GetVipCarDto()
        {
            CarDto carDto = new CarDto();

            carDto.CarType = "VIP";
            carDto.BrandName = "MERCEDES";
            carDto.DailyPrice = 200;

            return carDto;
        }
    }
}
