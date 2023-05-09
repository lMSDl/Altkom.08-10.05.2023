using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private readonly int _intValue;
        //private string _stringValue;

        private PrivateClassData _privateClassData;

        public ClassData(int intValue, string stringValue)
        {
            _privateClassData = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {
            //_intValue = 2;
            _privateClassData.GetStringValue();
        }
    }

}
