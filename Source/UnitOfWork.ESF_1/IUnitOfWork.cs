namespace UnitOfWork.ESF_1
{
    public interface IUnitOfWork
    {
        void Begin();
        void Commit();
        void Rollback();
        bool IsStarted { get; }
    }
}
