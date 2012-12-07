using FubuMVC.Core;
using WebApplication1.Features.Home;

namespace WebApplication1
{
    public class AppRegistry : FubuRegistry
    {
        public AppRegistry()
        {
            Routes.HomeIs<HomeEndpoint>(x => x.get(null));
        }
    }
}