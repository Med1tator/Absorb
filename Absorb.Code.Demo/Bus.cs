using Absorb.Code.Demo.Abstract;
using Absorb.Code.Demo.Concrete;
using System;

namespace Absorb.Code.Demo
{
    public class Bus<TGeneriService> where TGeneriService : IGenricService, new()
    {
        public Bus() { }

        public static TGeneriService Service => new TGeneriService();
    }
}
