namespace clicker.business.Abstract
{
    public interface IValid<T>
    {

        string ErrorMessage {get;set;}
        bool Valdiation(T entity);
         
    }
}