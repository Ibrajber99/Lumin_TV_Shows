using System;

namespace SQLFactories
{
    public class ActorFactory
    {
        public static Func<IActorRepo> ActorRepoFunc { private get; set; }

        public static IActorRepo CreateActorRepo()
        {
            return ActorRepoFunc();
        }
    }
}
