using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Accounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int accountId, float amount)
        {
            var account = FindAccountById(accountId);
            return account?.Charge(amount) ?? false;
        }

        private PaymentAccount? FindAccountById(int accountId)
        {
            return Accounts.Where(x => x.IsActive).SingleOrDefault(x => x.Id == accountId);
        }

        public void Fund(int accountId, float amount)
        {
            var account = FindAccountById(accountId);
            account?.Fund(amount);
        }
    }
}
