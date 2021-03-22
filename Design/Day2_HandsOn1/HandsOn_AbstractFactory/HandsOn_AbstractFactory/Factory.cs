using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_AbstractFactory
{
    public abstract class Factory
    {
        public abstract Headlight makeHeadLight();
        public abstract Tire makeTire();
    }

    public class Headlight
    {
        public Headlight() { }
    }
    public class Tire
    {
        public Tire() { }
    }

    public class AudiFactory : Factory
    {
        public override Headlight makeHeadLight()
        {
            Headlight headlight = new Headlight();
            Console.WriteLine("Making Headlight of Audi.");
            return headlight;
        }
        public override Tire makeTire()
        {
            Tire tire = new Tire();
            Console.WriteLine("Making Tire of Audi.");
            return tire;
        }
    }

    public class MercedesFactory : Factory
    {
        public override Headlight makeHeadLight()
        {
            Headlight headLight = new Headlight();
            Console.WriteLine("Making Headlight of Merecedes.");
            return headLight;
        }
        public override Tire makeTire()
        {
            Tire tire = new Tire();
            Console.WriteLine("Making Tire of Merecedes.");
            return tire;
        }
    }

    public class AutoFactory
    {
        public Factory GetFactory(string factoryType)
        {
            if (factoryType == null)
            {
                return null;
            }
            else if (factoryType.Equals("Audi", StringComparison.InvariantCultureIgnoreCase))
            {
                return (new AudiFactory());
            }
            else if (factoryType.Equals("Mercedes", StringComparison.InvariantCultureIgnoreCase))
            {
                return (new MercedesFactory());
            }
            return null;
        }
    }
}

