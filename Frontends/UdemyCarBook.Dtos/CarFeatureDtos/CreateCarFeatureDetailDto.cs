using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Dtos.FeatureDtos;

namespace UdemyCarBook.Dtos.CarFeatureDtos
{
    public class CreateCarFeatureDetailDto
    {
        public List<ResultFeatureDto> Features { get; set; }
        public  int  CarID { get; set; }
    }
}
