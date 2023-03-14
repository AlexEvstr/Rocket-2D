using Evstr.GUI;
using System;

namespace Evstr.GameConfig
{
    [Serializable]
    public class GameData : IGameData
    {
        [NonSerialized] private int _score;
        private int _coins;

        public int GetScore
        {
            get => _score;
        }

        public int GetCoins
        {
            get => _coins;
        }

        [NonSerialized] private GUIService _guiService;

        public void TransferDependency(GUIService guiService)
        {
            _guiService = guiService;
        }

        public void IncreaseCoins()
        {
            _score++;
            _guiService.UpdateTextScore(_score);
        }

        public void IncreaseScore()
        {
            _coins++;
            _guiService.UpdateTextCoins(_coins);
        }
    }
}
