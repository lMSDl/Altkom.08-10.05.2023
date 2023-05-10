using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger<T, TService> where TService : IDisposable
    {

        public void Log(string message)
        {
            //BeforePrepareMessage();
            message = PrepareMessage(message);
            //AfterPrepareMessage();
            //var service = GetService();

            using var service = GetService();
            T item = CreateItem(message);
            Save(item, service);
            
            //    service?.Dispose();
        }

        /*protected virtual void AfterPrepareMessage()
        {
        }

        protected virtual void BeforePrepareMessage()
        {
        }*/

        protected abstract void Save(T? item, TService service);
        protected abstract T CreateItem(string message);
        protected abstract TService GetService();

        private string PrepareMessage(string message)
        {
            return $"{DateTime.Now}: {message}";
        }
    }
}
