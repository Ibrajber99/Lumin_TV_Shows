using Models;


namespace SQLFactories
{
    public interface IUserRepo
    {
        int Create(User user);

        int GetUser(User user);
    }
}
