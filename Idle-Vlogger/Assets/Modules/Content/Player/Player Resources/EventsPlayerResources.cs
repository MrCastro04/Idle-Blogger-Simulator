using System;

namespace Modules.Content.Player.Player_Resources
{
    public static class EventsPlayerResources
    {
        public static event Action<int> OnDollarValueAdded;

        public static void ExecuteEventOnDollarValueAdded(int value)
        {
            OnDollarValueAdded?.Invoke(value);
        }
    }
}