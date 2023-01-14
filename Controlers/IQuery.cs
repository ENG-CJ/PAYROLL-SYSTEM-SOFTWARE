namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    public abstract class IQuery
    {

        public abstract bool QueryHasError { get; set; }
        public abstract string ErrorMessage { get; set; }
    }
}
