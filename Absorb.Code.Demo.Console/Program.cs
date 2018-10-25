using Absorb.Code.Demo.Concrete;
using System;
using static System.Console;

namespace Absorb.Code.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string singerName= Bus<SingerService>.Service.GetSingerNameById(1);
            //string singerName = new Bus2().SingerService(srv => srv.GetSingerNameById(1));
            //string singerName = new Bus2().Singer.GetSingerNameById(1);
            WriteLine(singerName);

            ReadKey();
        }
    }
}
