using System.Threading;

namespace WPC.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            Task.Delay(time, _cancellationTokenSource.Token)
                .ContinueWith(x =>
                {
                    _cancellationTokenSource.Dispose();
                    coffeeMachine.State = new IdleState(coffeeMachine);
                });
        }

        public override void Large()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }
    }
}