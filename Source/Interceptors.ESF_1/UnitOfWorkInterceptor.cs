using Composition.ESF_1;
using UnitOfWork.ESF_1;

namespace Interceptors.ESF_1
{
    public class UnitOfWorkInterceptor : IServiceInterceptor
    {
        private readonly IUnitOfWork unitOfWork;

        public UnitOfWorkInterceptor(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Intercept(IInterceptionContext interceptionContext)
        {
            if (!unitOfWork.IsStarted)
            {
                unitOfWork.Begin();
            }

            try
            {
                interceptionContext.Proceed();
            }
            catch
            {
                unitOfWork.Rollback();

                throw;
            }

            unitOfWork.Commit();
        }
    }
}
