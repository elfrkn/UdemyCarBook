using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Dtos.FeatureDtos;

namespace UdemyCarBook.Dtos.CarFeatureDtos
{
    public class CreateCarFeaturesDto
    {
        public int CarID { get; set; }
        public int FeatureID { get; set; }
        public bool Available { get; set; }
    }
}
