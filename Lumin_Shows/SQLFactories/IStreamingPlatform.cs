using System.Data;

namespace SQLFactories
{
    public interface IStreamingPlatform
    {
        DataTable GetStreamingPlatforms();

        string GetStreamingPlatformName(string platformId);
    }
}
