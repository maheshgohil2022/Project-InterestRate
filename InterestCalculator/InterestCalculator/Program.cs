
/*
 * Interest Installment Calculator

Inputs:
Loan Amount
Interest Rate
Calculation - Simple/compound
Payment/Installment Frequency - Weekly/Monthly
Total Duration - In weeks/Months/Years

Output: <for each installment>
Installment Amount
Paid Interest
Paid Capital
Remaining Capital

Possible Inclusion: Switching Frequency of payment in between the period
*/

namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program Inputs
            string strPrinciple, strInterestRate, strDuration, strPaymentType, strInterestType;
            CalculationInputs(out strPrinciple, out strInterestRate, out strDuration, out strPaymentType, out strInterestType);



            //CALCULATION

            //Convert Values into Numbers
            Double principle = double.Parse(strPrinciple);
            float interestRate = float.Parse(strInterestRate) / 100;
            int duration = int.Parse(strDuration);

            int paymentType = int.Parse(strPaymentType);
            int interestType = int.Parse(strInterestType);

            switch (paymentType)
            {
                case 1:
                    strPaymentType = "Weekly";
                    paymentType = 52;
                    break;

                case 2:
                    strPaymentType = "Bi-Weekly";
                    paymentType = 26;
                    break;

                case 3:
                    strPaymentType = "Monthly";
                    paymentType = 12;
                    break;

                default:
                    Console.WriteLine("Invalid Input for Payment Type");
                    break;
            }

            Console.WriteLine("\n---OUTPUT---");
            switch (interestType)
            {
                case 1:
                    {
                        strInterestType = "Simple Interest";

                        //Simple Interest Calculation
                        Double interestAmount = (principle * interestRate * duration) / 100;

                        double finalAmount = principle + interestAmount;
                        double installment = finalAmount / (duration * paymentType);

                        installment = Math.Round(installment, 2);

                        Console.WriteLine("\n\nInterest Amount: $ " + interestAmount + "\nInstallment: $ " + installment + " " + strPaymentType + "\nFinal amount: $ " + finalAmount);
                    }
                    break;

                case 2:
                    {
                        strInterestType = "Compound Interest";

                        //Compund Interest Calculation
                        int annualCompound = 1;
                        double Total = principle * Math.Pow((1 + interestRate / annualCompound),
                                 (annualCompound * duration));
                        Console.WriteLine("Compound Interest: " + Total.ToString("C2"));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input for Interest Type");
                    break;
            }

            //PAYMENT TABLE CALCULATION
            /*double monthlyInterest = interestRate / 12;
            double numberOfPayments = duration * 12;

            double remainingAmount = principle * (
                                     (Math.Pow(1 + monthlyInterest, numberOfPayments), numberOfPayments)) / 
                                     (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);
            //Console.WriteLine(principle + " " + interestRate + " " + duration + " " + strPaymentType + " " + strInterestType);
            
            public static double calculateMortgage(
            int principal,
            float annualInterest,
            byte years) {

        float monthlyInterest = annualInt
        float numberOfPayments = years * MONTHS_IN_YEAR;

        double mortgage = principal
                * (monthlyInterest * Math.pow(1 + monthlyInterest, numberOfPayments))
                / (Math.pow(1 + monthlyInterest, numberOfPayments) - 1);

        return mortgage;
    }
          */


        }

        private static void CalculationInputs(out string strPrinciple, out string strInterestRate, out string strDuration, out string strPaymentType, out string strInterestType)
        {
            Console.WriteLine("Please Enter The Following Information: ");
            Console.Write("Principle Amount: ");
            strPrinciple = Console.ReadLine();
            Console.Write("Interest Rate (in%): ");
            strInterestRate = Console.ReadLine();
            Console.Write("Please Enter Duration in Years: ");
            strDuration = Console.ReadLine();
            Console.Write("\nSelect Duration of the Payment " +
                          "\nEnter 1 for Weekly" +
                          "\nEnter 2 for Bi-Weekly" +
                          "\nEnter 3 for Monthly" +
                          "\nPayment Duration : ");
            strPaymentType = Console.ReadLine();
            Console.Write("\nSelect Type of Interest" +
                          "\nEnter 1 for Simple" +
                          "\nEnter 2 for compound" +
                          "\nInterest Type : ");
            strInterestType = Console.ReadLine();

            //Console.WriteLine(strPrinciple + " " + strInterestRate + " " + strDuration + " " + strPaymentType + " " + strInterestType);
        }
    }
}