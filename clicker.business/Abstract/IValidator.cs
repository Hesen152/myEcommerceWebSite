namespace clicker.business.Abstract
{
    public interface IValidator<T>
    {

        string ErrorMessage {get;set;}
        bool Valdiation(T entity);
         
    }
}