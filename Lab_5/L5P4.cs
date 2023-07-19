/*Create a class named RBI with calculateInterest() method. Create another 
classes HDFC, SBI, ICICI which overrides calculateInterest() method.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L5P4
    {
        public static void Main()
        {
            RBI rbi = new RBI();
            HDFC hdfc = new HDFC();
            SBI sbi = new SBI();
            ICICI icici = new ICICI();
            rbi.calculateInterest();
            hdfc.calculateInterest();
            sbi.calculateInterest();
            icici.calculateInterest();
        }

        class RBI
        {
            public virtual void calculateInterest()
            {
                Console.WriteLine("Interest of SBI");
            }
        }
        class HDFC : RBI
        {
            public override void calculateInterest()
            {
                Console.WriteLine("Interest of RBI");
            }
        }
        class SBI : RBI
        {
            public override void calculateInterest()
            {
                Console.WriteLine("Interest of SBI");
            }
        }
        class ICICI : RBI
        {
            public override void calculateInterest()
            {
                Console.WriteLine("Interest of ICICI");
            }
        }

    }
}
