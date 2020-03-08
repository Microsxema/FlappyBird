using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.Popup
{
    public class PopupBase : MonoBehaviour
    {
        public virtual void Show()
        {
            gameObject.SetActive(true);
        }

        public virtual void Close()
        {
            gameObject.SetActive(false);
        }
    }
}
