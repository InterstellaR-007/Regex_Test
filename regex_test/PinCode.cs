using System;
using System.Text.RegularExpressions;

namespace regex_test
{
    class PinCode
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pin Code Verification Program");
            Console.WriteLine("Enter the pincode :");
            String input_PinCode = Console.ReadLine();

            String pattern = "^(![a-zA-Z][0-9]){6}";
            
            Regex regex = new Regex(@pattern);

            Match match = regex.Match(input_PinCode);
            if (match.Success)
            {
                Console.WriteLine("Valid Pincode: " + match.Value);
            }
            else
                Console.WriteLine("Invalid Pincode");

        }
    }
}
