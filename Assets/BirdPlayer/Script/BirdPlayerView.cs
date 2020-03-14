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

        [SerializeField]
        private int IGNORE;

        [SerializeField]
        private int POINTS_UP;

        private void OnCollisionEnter2D(Collision2D collision)
        {

            int collisionLayer = collision.gameObject.layer;

            if (collisionLayer == IGNORE)
            {

            }

            else if(collisionLayer == POINTS_UP)
            {
                _playerController.PointsUp();
            }

            else
            {
                _playerController.GameOver();
            }
        }
    }
}
