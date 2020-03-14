using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.Popup
{

    public class PopupStartGame : PopupBase
    {
        private void Awake()
        {
            // TODO: Не нравится мне это.
            // Popup префаб не должен знать что находятся за пределами PopupManager
            Game.GameManager.BeginningGame.AddListener(Show);
        }

        public void OnClicButtonStart()
        {
            Close();
            // TODO: Не нравится мне это.
            // Popup префаб не должен знать что находятся за пределами PopupManager
            Game.GameManager.OnStartingGame();
        }
    }
}