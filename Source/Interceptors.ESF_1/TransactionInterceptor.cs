using System.Transactions;
using Composition.ESF_1;

namespace Interceptors.ESF_1
{
    public class TransactionInterceptor : IServiceInterceptor
    {
        public void Intercept(IInterceptionContext interceptionContext)
        {
            using (var trxScope = new TransactionScope())
            {
                interceptionContext.Proceed();

                trxScope.Complete();
            }
        }
    }
}