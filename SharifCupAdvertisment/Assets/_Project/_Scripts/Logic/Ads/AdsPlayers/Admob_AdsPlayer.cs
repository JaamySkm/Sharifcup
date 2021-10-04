using Sharifcup.Data.Ads;
using UnityEngine.Scripting;


namespace Sharifcup.Logic.Ads.AdsPlayers
{
    [Preserve] // NOTE: Marking as preserve in case of creating these via reflection instead of explicitly new ing them.
    public class Admob_AdsPlayer : AdsPlayerBase
    {
        public Admob_AdsPlayer(IAdsPlayerConfig config) : base(config)
        {
        }

        public override void Initialize()
        {
        }

        public override void RequestRewardedAd()
        {
        }

        public override void ShowRewardedAd()
        {
        }

        public override void RequestInterstitialAd()
        {
        }

        public override void ShowRequestInterstitialAd()
        {
        }
    }
}