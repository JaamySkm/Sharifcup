using Sharifcup.Data.Ads;
using UnityEngine;


namespace Sharifcup.Data
{
    public class Configurations : MonoBehaviour
    {
        [SerializeField] private AdsConfig adsConfig;

        public AdsConfig AdsConfig => adsConfig;
    }
}