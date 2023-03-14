using UnityEngine;
using UnityEngine.UI;

namespace Evstr.GUI
{
    public class GUIService : MonoBehaviour
    {
        [SerializeField] private GameObject _startPanel;
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private Text _textScore;
        [SerializeField] private Text _textCoins;

        private void OnEnable()
        {
            _textScore.text = "0";
            _textCoins.text = "0";
        }

        public void SetVisiblePanelStart(bool value)
        {
            _startPanel.SetActive(value);
        }

        public void SetVisiblePanelGameOver(bool value)
        {
            _gameOverPanel.SetActive(value);
        }

        public void UpdateTextScore(int score)
        {
            _textScore.text = score.ToString();
        }

        public void UpdateTextCoins(int coins)
        {
            _textCoins.text = coins.ToString();
        }
    }
}
