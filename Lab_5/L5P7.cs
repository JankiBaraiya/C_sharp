/*write a program to create a delegate called trafficdel and a class called 
trafficsignal with the following delegate methods.
public static void yellow()
{
console.writeline(“yellow light signal to get ready”);
}
public static void green()
{
console.writeline(“green light signal to go”);
}
public static void red()
{
console.writeline(“red light signal to stop”);
}*/



namespace consoleapp1
{
    public delegate void trafficdel();
    internal class l5p7
    {
        public static void Main(String[] args)
        {
            trafficsignal ts = new trafficsignal();
            ts.identifysignal();
            ts.display();
        }
    }
    class trafficsignal
    {
        public static void yellow()
        {
            Console.WriteLine("yellow light signals to get ready");
        }
        public static void green()
        {
            Console.WriteLine("green light signals to go");
        }
        public static void red()
        {
            Console.WriteLine("red light signals to stop");
        }
        trafficdel[] td = new trafficdel[3];
        public void identifysignal()
        {
            td[0] = new trafficdel(yellow);
            td[1] = new trafficdel(green);
            td[2] = new trafficdel(red);
        }
        public void display()
        {
            td[0]();
            td[1]();
            td[2]();
        }
    }

}
