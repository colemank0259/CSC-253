using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class Charges
    {
        private int _days;
        private decimal _medication;
        private decimal _surgical;
        private decimal _labFees;
        private decimal _rehab;
        private decimal _stayCharges;
        private decimal _miscCharges;
        private decimal _totalCharges;

        public Charges()
        {
            Days = 0;
            Medication = 0;
            Surgical = 0;
            LabFees = 0;
            Rehab = 0;
            StayCharges = 0;
            MiscCharges = 0;
            TotalCharges = 0;
        }

        public Charges(int days, decimal medication, decimal surgical, decimal labFees, 
            decimal rehab, decimal stayCharges, decimal miscCharges, decimal totalCharges)
        {
            Days = days;
            Medication = medication;
            Surgical = surgical;
            LabFees = labFees;
            Rehab = rehab;
            StayCharges = stayCharges;
            MiscCharges = miscCharges;
            TotalCharges = totalCharges;
        }

        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }

        public decimal Medication
        {
            get { return _medication; }
            set { _medication = value; }
        }

        public decimal Surgical
        {
            get { return _surgical; }
            set { _surgical = value; }
        }

        public decimal LabFees
        {
            get { return _labFees; }
            set { _labFees = value; }
        }

        public decimal Rehab
        {
            get { return _rehab; }
            set { _rehab = value; }
        }

        public decimal StayCharges
        {
            get { return _stayCharges; }
            set { _stayCharges = value; }
        }

        public decimal MiscCharges
        {
            get { return _miscCharges; }
            set { _miscCharges = value; }
        }

        public decimal TotalCharges
        {
            get { return _totalCharges; }
            set { _totalCharges = value; }
        }
    }
}
