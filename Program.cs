using System;
using System.Text;


namespace HelloBangazon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CustomerGreeting().ToString());
        }
        public static string CustomerGreeting()
        {
            var purchaseDate=DateTime.Now;
            var paymentDueDate=purchaseDate.AddDays(30);
            var lastName="Smith"; 
            var firstName="Bill";
            var message= "your payment is due " + paymentDueDate.ToString("d");
            var formalName=firstName + " " + lastName;

            //Build the specific user message
            var sb=new StringBuilder();
            sb.Append("Hello ");
            sb.Append(formalName);
            sb.Append(" ");
            sb.Append(message);
            return sb.ToString();
        }
    }
}
