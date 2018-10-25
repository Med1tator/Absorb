using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.Code.Demo.Abstract
{
    public interface ISingerService : IGenricService
    {
        string GetSingerNameById(int singerId);
    }
}
