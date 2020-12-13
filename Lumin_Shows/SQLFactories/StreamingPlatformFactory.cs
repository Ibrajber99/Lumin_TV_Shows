using System;

namespace SQLFactories
{
    public class StreamingPlatformFactory
    {
        public static Func<IStreamingPlatform> StreamingPlatformRepoFunc { private get; set; }

        public static IStreamingPlatform CreateStreamingPlatformRepo()
        {
            return StreamingPlatformRepoFunc();
        }
    }
}
