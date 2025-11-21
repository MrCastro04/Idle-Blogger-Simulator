using System;
using Modules.Content.Player.Player_Resources.View;
using Modules.Core.Extensions;

namespace Modules.Content.Player.Player_Resources
{
    public class PresenterPlayerResources : IDisposable
    {
        private readonly ModelPlayerResources _modelPlayerResources;
        private readonly ViewPlayerResources _viewPlayerResources;

        public PresenterPlayerResources(ModelPlayerResources modelPlayerResources, ViewPlayerResources viewPlayerResources)
        {
            _modelPlayerResources = modelPlayerResources;
            _viewPlayerResources = viewPlayerResources;

            SubEvents();
            
            _modelPlayerResources.ChangeValueResource(TypeResources.Dollars, TypeMathOperation.Add, 100);
        }

        private void SubEvents()
        {
            EventsPlayerResources.OnDollarValueAdded += AddDollarValue; 
            
            _modelPlayerResources.Dollars.OnValueChanged += _viewPlayerResources.DisplayResource;
        }

        public void Dispose()
        {
            EventsPlayerResources.OnDollarValueAdded -= AddDollarValue; 

            _modelPlayerResources.Dollars.OnValueChanged -= _viewPlayerResources.DisplayResource;
        }

        private void AddDollarValue(int value)
        {
            _modelPlayerResources.ChangeValueResource(TypeResources.Dollars, TypeMathOperation.Add, value);
        }
    }
}