using UnityEngine;

namespace Modules.Content.UI.Buttons
{
    public class ButtonOpenScreen : BaseButton
    {
        [SerializeField] private TypeScreen _typeScreen;
        
        protected override void ExecuteEventOnClick()
        {
            EventsButtonClick.ExecuteEventOnOpenScreen(_typeScreen);
        }
    }
}