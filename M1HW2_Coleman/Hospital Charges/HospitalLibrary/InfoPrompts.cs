using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class InfoPrompts
    {
        public static void Days()
        {
            Console.WriteLine("The daily base rate for staying at the hospital is $350.");
            Console.Write("Enter the number of days stayed at the hospital > ");
        }

        public static void Medication()
        {
            Console.Write("Enter the amount of medication costs> ");
        }

        public static void Surgical()
        {
            Console.Write("Enter the amount of surgical costs > ");
        }

        public static void LabFees()
        {
            Console.Write("Enter the amount of lab fees > ");
        }

        public static void Rehab()
        {
            Console.Write("Enter the amount of physical rehabilitation costs > ");
        }
    }
}
