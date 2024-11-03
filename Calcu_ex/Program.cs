namespace Calcu_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 값을 입력하세요");
            string value1= Console.ReadLine();

            Console.Write("두번째 값을 입력하세요");
            string value2 = Console.ReadLine();

            double dvalue1 =Double.Parse(value1);
            double dvalue2 =Double.Parse(value2);

            Console.WriteLine("{0}+{1}={2}",dvalue1,dvalue2,dvalue1+dvalue2);
            Console.WriteLine("{0}*{1}={2}",dvalue1,dvalue2,dvalue1*dvalue2);
            Console.WriteLine("{0}-{1}={2}",dvalue1,dvalue2,dvalue1-dvalue2);
            Console.WriteLine("{0}/{1}={2}",dvalue1,dvalue2,dvalue1/dvalue2);
           Console.Read();
        }
    }
}
