using System;

namespace Modules.Content.UI.Buttons
{
    public static class EventsButtonClick
    {
        public static event Action<TypeScreen> OnOpenScreen;
        public static event Action OnCloseAllScreen;

        public static void ExecuteEventOnOpenScreen(TypeScreen typeScreen)
        {
            OnOpenScreen?.Invoke(typeScreen);
        }

        public static void ExecuteEventOnCloseScreen()
        {
            OnCloseAllScreen?.Invoke();
        }
    }
}