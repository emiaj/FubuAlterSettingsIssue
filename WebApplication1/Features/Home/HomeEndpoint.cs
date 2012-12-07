namespace WebApplication1.Features.Home
{
    public class HomeEndpoint
    {
        public HomeModel get(HomeInput input)
        {
            return new HomeModel();
        }
    }

    public class HomeInput
    {
    }

    public class HomeModel
    {
    }

}