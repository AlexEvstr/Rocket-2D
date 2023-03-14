using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GameData
{
    public interface IGameData
    {
        int GetScore { get; }
        int GetCoins { get; }

        void IncreaseScore();
        void IncreaseCoins();
    }
}
