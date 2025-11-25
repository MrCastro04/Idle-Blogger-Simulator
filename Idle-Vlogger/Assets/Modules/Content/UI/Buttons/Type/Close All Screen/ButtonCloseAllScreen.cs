namespace Modules.Content.UI.Buttons.Type.Close_Screen
{
    public class ButtonCloseAllScreen : BaseButton
    {
        protected override void ExecuteEventOnClick()
        {
            EventsButtonClick.ExecuteEventOnCloseScreen();
        }
    }
}