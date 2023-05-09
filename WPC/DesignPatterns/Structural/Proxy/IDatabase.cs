using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    internal interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}
