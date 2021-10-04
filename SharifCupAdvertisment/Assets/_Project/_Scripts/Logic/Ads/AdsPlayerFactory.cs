using Sharifcup.Data.Ads;
using Sharifcup.Logic.Ads.AdsPlayers;
using UnityEngine;


namespace Sharifcup.Logic.Ads
{
    public class AdsPlayerFactory
    {
        public IAdsPlayer CreateActiveAdsPlayer(AdsConfig config)
        {
            IAdsPlayerConfig playerConfig = config.GetAdsPlayerConfig(config.ActiveAdsPlayerType);

            // NOTE: For sure this switch case should be replaces with a more general way, such as creation via reflection, and holding system.Type instead of this enum.
            switch (config.ActiveAdsPlayerType)
            {
                case AdsConfig.AdsPlayerType.Admob:
                    return new Admob_AdsPlayer(playerConfig);
                case AdsConfig.AdsPlayerType.UnityAds:
                    return new UnityAds_AdvertisementsPlayer(playerConfig);
                case AdsConfig.AdsPlayerType.Tapsell:
                    return new Tapsell_AdvertisementsPlayer(playerConfig);
                case AdsConfig.AdsPlayerType.Yektanet:
                    return new Yektanet_AdvertisementsPlayer(playerConfig);
            }

            Debug.LogError(message: $"AdvertisementsPlayer Creation Error, config active player: {config.ActiveAdsPlayerType}");
            return null;
        }
    }
}