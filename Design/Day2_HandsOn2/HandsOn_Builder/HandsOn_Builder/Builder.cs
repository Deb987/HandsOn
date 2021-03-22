using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Builder
{
    public interface IPackageBuilder
    {
        void SetSweet();
        void SetSavory();
        PackageCreator GetPackage();
    }
    

    class Director
    {
        public void Construct(IPackageBuilder builder)
        {
            builder.SetSweet();
            builder.SetSavory();
        }
    }

    public class ChildPackage : IPackageBuilder
    {
        PackageCreator package = new PackageCreator();
        public void SetSweet()
        {
            package.AddSweet(2);
        }
        public void SetSavory()
        {
            package.AddSavory(1);
        }
        public PackageCreator GetPackage()
        {
            return package;
        }
    }
    public class AdultPackage : IPackageBuilder
    {
        PackageCreator package = new PackageCreator();
        public void SetSweet()
        {
            package.AddSweet(2);
        }
        public void SetSavory()
        {
            package.AddSavory(2);
        }
        public PackageCreator GetPackage()
        {
            return package;
        }
    }
    public class PackageCreator
    {
        //private IPackageBuilder _packageBuilder;
        //public PackageCreator(IPackageBuilder packageBuilder)
        //{
        //    _packageBuilder = packageBuilder;
        //}
        //public void CreatePackage()
        //{
        //    _packageBuilder.SetSweet();
        //    _packageBuilder.SetSavory();
        //}
        //public Package GetPackage()
        //{
        //    return _packageBuilder.GetPackage();
        //}

        private int noOfSweet;
        private int noOfSavory;

        public PackageCreator()
        {
            noOfSweet = 0;
            noOfSavory = 0;
        }

        public void AddSweet(int count)
        {
            noOfSweet += count;
        }

        public void AddSavory(int count)
        {
            noOfSavory += count;
        }

        public void Show(string s)
        {
            if (s == "child")
            {
                Console.WriteLine($"ChildPackage  contains {noOfSweet} Sweets and {noOfSavory} Savories");
            }
            else if( s == "adult")
            {
                Console.WriteLine($"AdultPackage  contains {noOfSweet} Sweets and {noOfSavory} Savories");
            }

        }
    }
}
