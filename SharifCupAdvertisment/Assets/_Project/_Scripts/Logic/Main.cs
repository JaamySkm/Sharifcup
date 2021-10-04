using Sharifcup.Data;
using Sharifcup.Logic.Ads;
using Sharifcup.Logic.Levels;
using UnityEngine;


namespace Sharifcup.Logic
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Configurations configurations;

        public LevelManager LevelManager { get; private set; }
        public AdsManager AdsManager { get; private set; }
        public Configurations Configurations { get; }

        private void Awake()
        {
            InitializeManagers();
        }

        private void InitializeManagers()
        {
            LevelManager = new LevelManager();

            AdsPlayerFactory adsFactory = new AdsPlayerFactory();
            IAdsPlayer adsPlayer = adsFactory.CreateActiveAdsPlayer(Configurations.AdsConfig);
            AdsManager = new AdsManager(adsPlayer);
        }

        private void Start()
        {
            AdsManager.ActiveApi.Initialize();
            LevelManager.LoadLevel(0);
        }
    }
}