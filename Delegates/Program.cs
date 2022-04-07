using System;

namespace nms
{
    public delegate void Hdelegate(string Msg);

    class del
    {
        public static void Hello(string Message)
        {
            Console.WriteLine(Message);
        }

        public static void Main()
        {
            Hdelegate hd = new Hdelegate(Hello);
            hd("Hello From the OTHER side");
        }

    }
}