using UnityEngine;
using UnityEngine.UI;

namespace Modules.Content.UI.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class BaseButton : MonoBehaviour
    {
        protected Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(() => ExecuteEventOnClick());
        }

        private void OnDisable()
        {
            _button.onClick.RemoveAllListeners();
        }

        protected abstract void ExecuteEventOnClick();
    }
}