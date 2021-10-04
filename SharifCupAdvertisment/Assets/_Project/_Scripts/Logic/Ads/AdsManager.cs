namespace Sharifcup.Logic.Ads
{
    public class AdsManager
    {
        public IAdsPlayer ActiveApi { get; }

        public AdsManager(IAdsPlayer adsPlayer)
        {
            ActiveApi = adsPlayer;
        }
    }
}