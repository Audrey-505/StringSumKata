namespace SumStringKata
{

    public class SumString
    {
        public static string EmptyString()
        {
            return "";
        }

        public static string StringSum(string num1, string num2)
        {
            int value1 = int.Parse(num1);
            int value2 = int.Parse(num2);
            int result = NaturalChecker(value1, value2);
            return result.ToString();
        }

        public static int NaturalChecker(int value1, int value2)
        {
            value1 = (value1 < 0) ? 0 : value1;
            value2 = (value2 < 0) ? 0 : value2;
            return value1 + value2;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string result = SumString.StringSum("2", "-2");
            Console.WriteLine(int.Parse(result));
        }
    }
}