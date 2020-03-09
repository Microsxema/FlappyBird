using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.Popup
{
    public class PopupManager : MonoBehaviour
    {
        public PopupBase[] PanelstPrefab;

        private PopupBase[] _panels;

        public T GetPanel<T>() where T : PopupBase
        {
            T result = null;

            foreach(var panel in _panels)
            {
                if(panel.GetType() == typeof(T))
                {
                    result = (T)panel;
                }
            }

            return result;
        }

        private void Awake()
        {
            Game.PopupManager = this;

            _panels = new PopupBase[PanelstPrefab.Length];

            for (int i = 0; i < PanelstPrefab.Length; i++)
            {
                _panels[i] = Instantiate(PanelstPrefab[i], transform);
                _panels[i].Close();
            }
        }
    }
}
