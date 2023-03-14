using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GameConfig
{
    public interface IGameData
    {
        int GetScore { get; }
        int GetCoins { get; }

        void IncreaseScore();
        void IncreaseCoins();
    }
}
