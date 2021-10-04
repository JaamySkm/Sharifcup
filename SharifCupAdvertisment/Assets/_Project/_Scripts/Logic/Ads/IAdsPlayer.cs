using Sharifcup.Data.Ads;


namespace Sharifcup.Logic.Ads
{
    public interface IAdsPlayer
    {
        public void Initialize();

        public void RequestRewardedAd();
        public void ShowRewardedAd();

        public void RequestInterstitialAd();
        public void ShowRequestInterstitialAd();
    }

    public abstract class AdsPlayerBase : IAdsPlayer
    {
        private readonly IAdsPlayerConfig config;

        protected AdsPlayerBase(IAdsPlayerConfig config)
        {
            this.config = config;
        }

        public abstract void Initialize();
        public abstract void RequestRewardedAd();
        public abstract void ShowRewardedAd();
        public abstract void RequestInterstitialAd();
        public abstract void ShowRequestInterstitialAd();
    }
}

