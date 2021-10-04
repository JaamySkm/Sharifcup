using Sharifcup.Data;
using UnityEngine;


namespace Sharifcup.Logic.Levels
{
    public class LevelManager
    {
        public void LoadLevel(int levelIndex)
        {
            Resources.Load(AssetFoldersPath.Levels + levelIndex);
        }
    }
}