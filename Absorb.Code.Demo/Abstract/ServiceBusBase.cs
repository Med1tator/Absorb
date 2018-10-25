using System;
using System.Collections.Generic;
using System.Text;

namespace Absorb.Code.Demo.Abstract
{
    public class ServiceBusBase
    {
        public ServiceBusBase() { }

        protected TResult Call<TGenericService, TResult>(TGenericService serviceInstance, Func<TGenericService, TResult> func)
            where TGenericService : IGenricService
        {
            return func(serviceInstance);
        }
    }
}
