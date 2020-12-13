using System;

namespace SQLFactories
{
    public class UserFactory
    {
        public static Func<IUserRepo> UserRepoFunc { private get; set; }

        public static IUserRepo CreateUserRepo()
        {
            return UserRepoFunc();
        }
    }
}
