namespace WPC.DesignPatterns.Behavioral.State
{
    internal class IdleState : State
    {
        public IdleState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
        }

        public override void Large()
        {
            System.Console.WriteLine("Duża kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 7000);
        }

        public override void Small()
        {
            System.Console.WriteLine("Mała kawa");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 4000);
        }
    }
}