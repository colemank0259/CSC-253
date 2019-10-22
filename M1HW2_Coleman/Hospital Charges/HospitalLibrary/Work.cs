using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class Work
    {
        public static Charges GetCharges()
        {
            // Declare the daily base rate of staying at the hospital
            const decimal DAILY_BASE = 350m;

            //Local variables
            Charges charges = new Charges();

            // Get the number of days the patient stayed at the hospital
            InfoPrompts.Days();
            charges.Days = int.Parse(Console.ReadLine());

            // Get the patient's medication costs
            InfoPrompts.Medication();
            charges.Medication = decimal.Parse(Console.ReadLine());

            // Get the patient's surgical costs
            InfoPrompts.Surgical();
            charges.Surgical = decimal.Parse(Console.ReadLine());

            // Get the patient's lab fees
            InfoPrompts.LabFees();
            charges.LabFees = decimal.Parse(Console.ReadLine());

            // Get the patient's physical rehabilitation costs
            InfoPrompts.Rehab();
            charges.Rehab = decimal.Parse(Console.ReadLine());

            // Calculate the cost of the patient's stay at the hospital
            charges.StayCharges = CalcStayCharges(DAILY_BASE, charges.Days);

            // Calculate the patient's total miscellaneous costs
            charges.MiscCharges = CalcMiscCharges(charges.Medication, charges.Surgical,
                charges.LabFees, charges.Rehab);

            // Calculate the the patient's total medical costs
            charges.TotalCharges = CalcTotalCharges(charges.StayCharges, charges.MiscCharges);

            // Display the output
            Console.WriteLine($"STAY CHARGES:");
            Console.WriteLine($"Daily Base rate for Hospital Stay: ${DAILY_BASE.ToString("n2")}");
            Console.WriteLine($"Days Stayed: {charges.Days}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Total Stay Charges: ${charges.StayCharges.ToString("n2")}");
            Console.WriteLine("");
            Console.WriteLine($"MISCELLANEOUS CHARGES:");
            Console.WriteLine($"Medication Costs: ${charges.Medication.ToString("n2")}");
            Console.WriteLine($"Surgical Costs: ${charges.Surgical.ToString("n2")}");
            Console.WriteLine($"Lab Fees: ${charges.LabFees.ToString("n2")}");
            Console.WriteLine($"Physical Rehabilitation Costs: ${charges.Rehab.ToString("n2")}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Total Miscellaneous Charges: ${charges.MiscCharges.ToString("n2")}");
            Console.WriteLine("");
            Console.WriteLine($"TOTAL HOSPITAL CHARGES: ${charges.TotalCharges.ToString("n2")}");
            Console.WriteLine("");

            return charges;
        }

        public static decimal CalcStayCharges(decimal dailyBase, int days)
        {
            decimal stayCharges = 0;

            stayCharges = dailyBase * days;

            return stayCharges;
            
        }

        public static decimal CalcMiscCharges(decimal medication, decimal surgical, 
            decimal labFees, decimal rehab)
        {
            decimal miscCharges = medication + surgical + labFees + rehab;

            return miscCharges;
        }

        public static decimal CalcTotalCharges(decimal stayCharges, decimal miscCharges)
        {
            decimal totalCharges = stayCharges + miscCharges;

            return totalCharges;
        }
    }
}
