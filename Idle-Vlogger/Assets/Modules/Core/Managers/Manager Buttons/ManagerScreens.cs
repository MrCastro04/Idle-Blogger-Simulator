using System;
using System.Collections.Generic;
using Modules.Content.UI.Buttons;
using Modules.Content.UI.Screens.Base;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Modules.Core.Managers.Manager_Buttons
{
    public class ManagerScreens : SerializedMonoBehaviour
    {
        [OdinSerialize] private Dictionary<TypeScreen, BaseViewScreen> _screens;

        private BaseViewScreen _currentScreen = null;

        private void OnEnable()
        {
            EventsButtonClick.OnOpenScreen += OpenScreen;
            EventsButtonClick.OnCloseAllScreen += CloseCurrentScreen;
        }

        private void OnDisable()
        {
            EventsButtonClick.OnOpenScreen -= OpenScreen;
            EventsButtonClick.OnCloseAllScreen -= CloseCurrentScreen;
        }

        private void OpenScreen(TypeScreen typeScreen)
        {
            CloseCurrentScreen();
            
            if (_screens.TryGetValue(typeScreen, out var screen) == false)
            {
                Debug.Log("Нету такого скрина");
                return;
            }

            _currentScreen = screen;

            _currentScreen.Open();
        }

        private void CloseCurrentScreen()
        {
            if (_currentScreen == null)
            {
                Debug.Log("Ничего не произошло");
            }
            else
            {
                Debug.Log("нажата кнопка закрытия всех скринов");

                _currentScreen.Close();
                
                _currentScreen = null;
            }
        }
    }
}