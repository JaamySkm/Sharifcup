using System;
using System.Collections.Generic;
using UnityEngine;


namespace Sharifcup.Data.Ads
{
    [CreateAssetMenu(menuName = "SharifCup/Configs/Ads")]
    public class AdsConfig : ScriptableObject
    {
        // NOTE : this config can be fetched from server, and also we can use system.Type and reflection instead of holding an enum.
        public enum AdsPlayerType
        {
            Admob,
            UnityAds,
            Tapsell,
            Yektanet
        }

        [Serializable]
        private class AdsPlayerConfigContainer
        {
            public AdsPlayerType playerType;
            public AdsPlayerConfigBase adsPlayerConfig;
        }

        [SerializeField] private AdsPlayerType activeAdsPlayerType;
        [SerializeField] private List<AdsPlayerConfigContainer> adsPlayersConfigs;

        public AdsPlayerType ActiveAdsPlayerType => activeAdsPlayerType;

        public IAdsPlayerConfig GetAdsPlayerConfig(AdsPlayerType adsPlayerType)
        {
            return adsPlayersConfigs.Find(config => config.playerType == activeAdsPlayerType).adsPlayerConfig;
        }
    }
}