using System.Buffers.Text;

namespace ControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1: Conditional Statement
            //1. Write a program that takes the customer's credit score and annual income as input.
            Console.WriteLine("Enter Your Credit Score:");
            int creditScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Annual income:");
            int annualIncome = Convert.ToInt32(Console.ReadLine());

            //2.Use conditional statements(if-else) to determine if the customer is eligible for a loan.
            //3.Display an appropriate message based on eligibility.
            if (creditScore > 700 && annualIncome >= 50000)
            {
                Console.WriteLine("The Customer is eligible for loan.");
            }
            else
            {
                Console.WriteLine("The Customer is not eligible for a loan.");
            }

        }   
    }
}
