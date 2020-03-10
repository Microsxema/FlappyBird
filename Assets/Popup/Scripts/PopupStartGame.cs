using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.Popup
{

    public class PopupStartGame : PopupBase
    {
        private void Awake()
        {
            Game.GameManager.GameStartingMainMenu.AddListener(Show);

            Game.GameManager.StartingGame.AddListener(Close);
        }
    }

}