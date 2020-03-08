using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlappyBird.BirdPlayer.View;
using FlappyBird.Popup;

namespace FlappyBird.BirdPlayer.Controller
{
    public class BirdPlayerController : MonoBehaviour
    {
        [SerializeField]
        private BirdPlayer _modelPlayer;

        [SerializeField]
        private BirdPlayerView _playerView;

        private bool _isFirstTouch;

        private void Start()
        {
            _isFirstTouch = true;

            _modelPlayer.PlayerInitialState();
        }

        private void Update()
        {
            // GetKeyUp(KeyCode.Space)
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase != TouchPhase.Began)
                {
                    return;
                }

                if (_isFirstTouch)
                {
                    _isFirstTouch = false;

                    _modelPlayer.PlayerGameMode();
                }

                _modelPlayer.JumpBirdPlayer();
            }
        }

        public void GameOver()
        {
            _isFirstTouch = true;

            Game.PopupManager.GetPanel<PopupGameOver>().Show();
        }


    }
}

