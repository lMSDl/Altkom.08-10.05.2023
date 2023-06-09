﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.State
{
    internal class HeatingUpState : State
    {
        public HeatingUpState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
            Task.Delay(5000).ContinueWith(x => coffeeMachine.State = new IdleState(coffeeMachine));
        }

        public override void Large()
        {
            System.Console.WriteLine("Nie teraz.. Rozgrzewam się..");
        }

        public override void Small()
        {
            Large();
        }
    }
}
