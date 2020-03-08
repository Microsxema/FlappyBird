using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlappyBird.BirdPlayer.Controller;

namespace FlappyBird.BirdPlayer.View
{
    public class BirdPlayerView : MonoBehaviour
    {
        [SerializeField]
        private BirdPlayerController _playerController;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _playerController.GameOver();
        }
    }
}
