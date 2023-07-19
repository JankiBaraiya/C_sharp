/*write a program to create a delegate calculator to demonstrate the 
example of generic delegate*/


namespace consoleapp1
{
    public delegate t mydel<t>(t n1, t n2);
    internal class l5p8
    {
        public static void main()
        {
            int result = 0;
            int num1 = 0;
            int num2 = 0;
            mydel<int> del1 = new mydel<int>(add);
            mydel<int> del2 = new mydel<int>(sub);
            mydel<int> del3 = new mydel<int>(mul);
            mydel<int> del4 = new mydel<int>(div);
            Console.WriteLine("enter the value of num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of num2: ");
            num2 = int.Parse(Console.ReadLine());
            result = del1(num1, num2);
            Console.WriteLine("addition: " + result);
            result = del2(num1, num2);
            Console.WriteLine("subtraction: " + result);
            result = del3(num1, num2);
            Console.WriteLine("multiplication: " + result);
            result = del4(num1, num2);
            Console.WriteLine("division: " + result);
        }

        static int add(int num1, int num2)
        {
            return (num1 + num2);
        }
        static int sub(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int mul(int num1, int num2)
        {
            return (num1 * num2);
        }
        static int div(int num1, int num2)
        {
            return (num1 / num2);
        }

    }
}
