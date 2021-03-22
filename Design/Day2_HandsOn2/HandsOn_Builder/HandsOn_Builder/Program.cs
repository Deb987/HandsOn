using System;

namespace HandsOn_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var childPackageCreator = new PackageCreator(new ChildPackage());
            //childPackageCreator.CreatePackage();
            //childPackageCreator.GetPackage();

            //var adultPackageCreator = new PackageCreator(new AdultPackage());
            //adultPackageCreator.CreatePackage();
            //adultPackageCreator.GetPackage();

            var director = new Director();

            var child = new ChildPackage();
            var adult = new AdultPackage();

            director.Construct(child);
            var childPackage = child.GetPackage();
            childPackage.Show("child");

            director.Construct(adult);
            var adultPackage = adult.GetPackage();
            adultPackage.Show("adult");

            Console.ReadLine();
        }
    }
}
