using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeCaseStudy_AbstractFactory.Program;

namespace PracticeCaseStudy_AbstractFactory
{
    public class CarClient
    {
        CarFactory carFactory;
        public CarClient(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void BuilderMicroCar(Location location)
        {
            carFactory.MakeMicroCar(location, CarType.MICRO);
        }
        public void BuildMiniCar(Location location)
        {
            carFactory.MakeMiniCar(location, CarType.MINI);
        }
        public void BuildLuxuryCar(Location location)
        {
            carFactory.MakeLuxuryCar(location, CarType.LUXURY);
        }

    }
}
