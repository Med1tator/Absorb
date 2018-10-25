using Absorb.Code.Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.Code.Demo.Concrete
{
    public class SingerService : ISingerService
    {
        public string GetSingerNameById(int singerId)
        {
            return "Jay Chou";
        }
    }
}
