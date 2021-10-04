using System;
using UnityEngine;


namespace Sharifcup.Data.Ads
{
    public interface IAdsPlayerConfig
    {
        public string AppId { get; }
        public string RewardedZoneId { get; }
        public string InterstitialZoneId { get; }
    }

    [Serializable]
    public abstract class AdsPlayerConfigBase : ScriptableObject, IAdsPlayerConfig
    {
        [SerializeField] private string appId;
        [SerializeField] private string rewardedZoneId;
        [SerializeField] private string interstitialZoneId;

        public string AppId => appId;
        public string RewardedZoneId => rewardedZoneId;
        public string InterstitialZoneId => interstitialZoneId;
    }
}