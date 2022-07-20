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
        internal CarDto GetCarDto()
        {
            CarDto carDto = new CarDto();
            
            carDto.CarType = "SUV";
            carDto.BrandName = "AUDI";
            carDto.DailyPrice = 100;

            return carDto;
        }
    }
}
