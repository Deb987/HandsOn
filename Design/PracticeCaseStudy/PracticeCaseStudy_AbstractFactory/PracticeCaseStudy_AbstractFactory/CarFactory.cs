using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeCaseStudy_AbstractFactory.Program;

namespace PracticeCaseStudy_AbstractFactory
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);
    }
}
