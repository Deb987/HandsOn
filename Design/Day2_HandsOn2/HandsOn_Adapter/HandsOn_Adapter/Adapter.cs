using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Adapter
{
    public interface Movable
    {
        // returns speed in MPH
        double getSpeed();
        // returns price in USD
        double getPrice();
    }

    public class BugattiVeyron : Movable
    {
        public double getSpeed()
        {
            return 268;
        }
        public double getPrice()
        {
            return 500000;
        }
    }

    public interface MovableAdapter
    {
        // returns speed in KM/H
        double getSpeed();
        // returns price in Euro
        double getPrice();

    }

    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable luxuryCars = new BugattiVeyron();
        // standard constructors
        public double getSpeed()
        {
            return convertMPHtoKMPH(luxuryCars.getSpeed());
        }
        private double convertMPHtoKMPH(double mph)
        {
            return mph * 1.60934;
        }

        public double getPrice()
        {
            return convertUSDtoEuro(luxuryCars.getPrice());
        }
        public double convertUSDtoEuro(double USDPrice)
        {
            return USDPrice * 0.84;
        }
    }
}