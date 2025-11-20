using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Modules.Content.Player.Player_Resources.View
{
    public class ViewPlayerResources : MonoBehaviour
    {
        [SerializeField] private Image _imageBackground;
        [SerializeField] private Image _imageResource;
        [SerializeField] private TMP_Text _textResourceValue;

        public void DisplayResource(int resourceValue)
        {
            _textResourceValue.text = resourceValue.ToString();
        }
    }
}