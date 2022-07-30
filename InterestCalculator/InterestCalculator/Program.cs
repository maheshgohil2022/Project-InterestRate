namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Following Information: ");
            Console.Write("Principle Amount: ");
            String strPrinciple = Console.ReadLine();

            Console.Write("Interest Rate (in%): ");
            String strInterestRate = Console.ReadLine();

            Console.Write("Please Enter Duration in Years: ");
            String strDuration = Console.ReadLine();


            Console.Write("\nSelect Duration of the Payment " +
                          "\nEnter 1 for Weekly" +
                          "\nEnter 2 for Bi-Weekly" +
                          "\nEnter 3 for Monthly" +
                          "\nPayment Duration : ");
            String strPaymentType = Console.ReadLine();

            Console.Write("\nSelect Type of Interest" +
                          "\nEnter 1 for Simple" +
                          "\nEnter 2 for compound" +
                          "\nInterest Type : ");
            String strInterestType = Console.ReadLine();


            //Console.WriteLine(strPrinciple + " " + strInterestRate + " " + strDuration + " " + strPaymentType + " " + strInterestType);

            //CALCULATION

            //Convert Values into Numbers
            Double principle = double.Parse(strPrinciple);
            float interestRate = float.Parse(strInterestRate);
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


            switch (interestType)
            {
                case 1:
                    strInterestType = "Simple Interest";
                    break;

                case 2:
                    strInterestType = "Compound Interest";
                    break;

                default:
                    Console.WriteLine("Invalid Input for Interest Type");
                    break;
            }

            //Console.WriteLine(principle + " " + interestRate + " " + duration + " " + strPaymentType + " " + strInterestType);

            //Simple Interest Calculation
            Double interestAmount = (principle * interestRate * duration) / 100;

            double finalAmount = principle + interestAmount;
            double installment = finalAmount / (duration * paymentType);

            installment = Math.Round(installment, 2);

            Console.WriteLine("\n\nInterest Amount: $ " + interestAmount + "\nInstallment: $ " + installment + " " + strPaymentType + "\nFinal amount: $ " + finalAmount);


            //Compund Interest Calculation
        }
    }
}