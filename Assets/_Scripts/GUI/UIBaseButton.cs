using UnityEngine;
using UnityEngine.UI;

namespace Evstr.GUI
{
    [RequireComponent(typeof(Button))]
    public abstract class UIBaseButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        public virtual void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        public virtual void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        public abstract void OnClick();
    }
}
