using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramsProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InvantaryManagement invantaryManagement = new InvantaryManagement();
            invantaryManagement.OfRice();
            invantaryManagement.OfWheet();
            invantaryManagement.OfPulse();

            Console.ReadLine();
        }
    }
}
