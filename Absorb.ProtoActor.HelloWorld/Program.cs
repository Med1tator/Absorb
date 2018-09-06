using Proto;
using System;
using System.Threading.Tasks;

namespace Absorb.ProtoActor.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var props = Actor.FromProducer(() => new HelloActor());
            var pid = Actor.Spawn(props);

            pid.Tell(new Hello { Who = "Medit Ding" });

            //Console.ReadLine();

            pid.Stop();

            Console.ReadKey();
        }
    }
    class Hello
    {
        public string Who;
    }
    class HelloActor : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            switch (context.Message)
            {
                case Started started:
                    Console.WriteLine("Started");
                    break;
                case Hello hello:
                    Console.WriteLine($"Hello {hello.Who}");
                    break;  
            }
            return Actor.Done;
        }
    }
}

