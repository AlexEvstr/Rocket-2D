using System;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.GUI
{
    public class GUIService : MonoBehaviour
    {
        [SerializeField] private GameObject _startPanel;
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private Text _textScore;

        public int _score = 0;

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
        private void Start()
        {
            InvokeRepeating("IncreaseScore", 0, 0.3f);
        }

        public void IncreaseScore()
        {
            if (!_startPanel.activeInHierarchy)
            { 
                _score += 1;
                UpdateTextScore(_score);
            }
        }
    }
}
