using Absorb.Code.Demo.Abstract;
using Absorb.Code.Demo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.Code.Demo
{
    public class Bus2:ServiceBusBase
    {
        public Bus2() { }

        #region Mode 1
        public ISingerService Singer => new SingerService(); 
        #endregion

        #region Mode 2
        private ISingerService _singService => new SingerService();

        public void SingerService(Action<ISingerService> action)
        {
            SingerService(srv => { action(srv); return true; });
        }

        public TResult SingerService<TResult>(Func<ISingerService, TResult> func)
        {
            return Call(_singService, func);
        } 
        #endregion
    }
}
