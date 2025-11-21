using Modules.Content.Player.Player_Resources;
using UnityEngine;
using UnityEngine.UI;

namespace Modules.Boot
{
    public class ButtonAddResource : MonoBehaviour
    {
        [SerializeField] private Button _button;
        
        public void Init()
        {
            _button.onClick.AddListener(() => EventsPlayerResources.ExecuteEventOnDollarValueAdded(100));
        }
    }
}