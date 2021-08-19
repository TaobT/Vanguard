using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using System.Collections.Generic;

namespace Vanguard
{
    public class PersistentSettings : MonoBehaviour
    {
        [SerializeField] InputActionAsset actions;

        private void OnEnable()
        {
            string keybinds = PlayerPrefs.GetString("keybinds");
            if (!string.IsNullOrEmpty(keybinds))
            {

            }
        }

        private void OnDisable()
        {
            string keybinds = actions.ToJson();
            PlayerPrefs.SetString("keybinds", keybinds);
        }
    }
}