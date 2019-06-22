using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
 int a = 0, b = 0, c = 0, flag = 0;
            string Digit = "";
            string[] digits = equation.Replace("*", ",").Replace("=", ",").Split(",");
            if (digits[0].Contains("?"))
            {
                b = Int32.Parse(digits[1]);
                c = Int32.Parse(digits[2]);
                if (c % b == 0)
                    a = c / b;
                else
                    return -1;
            }
            else if (digits[1].Contains("?"))
            {

                a = Int32.Parse(digits[0]);
                c = Int32.Parse(digits[2]);
                if (c % a == 0)
                    b = c / a;
                else
                    return -1;

            }
            else
            {
                b = Int32.Parse(digits[1]);
                a = Int32.Parse(digits[0]);
                c = a * b;


            }

            string ce = $"{a}*{b}={c}";
            if (ce.Length == equation.Length)
                for (int i = 0; i < equation.Length; i++)
                {
                    if (equation[i] == '?')
                        Digit = ce[i].ToString();
                    else
                    if (equation[i] != ce[i])
                        return -1;
                }
            else
                return -1;
            return Int32.Parse(Digit); throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}
