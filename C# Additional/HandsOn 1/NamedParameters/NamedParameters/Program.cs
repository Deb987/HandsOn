using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void GetCohortDetails(string Cohort, int GenC, string Mode, string Track, string Current)
        {
            Console.WriteLine($"It is {Cohort} with {GenC} GenCs undergoing training for {Track} thru {Mode}. The Current module of training is {Current}");
        }
        static void Main(string[] args)
        {
            GetCohortDetails("ABC1",10,"OBL",".NET","Threading");
            GetCohortDetails(Cohort: "ABC1", GenC: 10, Mode: "OBL", Track: ".NET", Current: "Threading");
            GetCohortDetails(GenC: 10, Cohort: "ABC1", Track: ".NET", Current: "Threading", Mode: "OBL");
            Console.ReadLine();
        }
    }
}
