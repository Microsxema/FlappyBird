using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.BirdPlayer
{
    public class BirdPlayer : MonoBehaviour
    {
        public Transform PlayerTransform { get; private set; }

        public Rigidbody2D PlayeRigidbody { get; private set; }

        public Animator MotionAnimation { get; private set; }

        public float JumpForce => _jumpForce;

        [SerializeField]
        private Vector3 _playerStartingPosition;

        [SerializeField]
        private float _jumpForce;

        private void Awake()
        {
            Game.GameManager.GameStartingMainMenu.AddListener(HideBirdPlayer);
            Game.GameManager.StartingGame.AddListener(ShowBirdPlayer);

            MotionAnimation = GetComponent<Animator>();
            PlayerTransform = GetComponent<Transform>();
            PlayeRigidbody = GetComponent<Rigidbody2D>();
        }

        private void HideBirdPlayer()
        {
            gameObject.SetActive(false);
        }

        private void ShowBirdPlayer()
        {
            gameObject.SetActive(true);

            PlayerInitialState();
        }

        public void PlayerInitialState()
        {
            PlayeRigidbody.isKinematic = true;

            MotionAnimation.enabled = true;

            PlayeRigidbody.velocity = Vector3.zero;

            PlayerTransform.position = _playerStartingPosition;
        }

        public void JumpBirdPlayer()
        {
            var force = Vector2.up * (JumpForce - PlayeRigidbody.velocity.y);

            PlayeRigidbody.AddForce(force, ForceMode2D.Impulse);
        }

        public void PlayerGameMode()
        {
            PlayeRigidbody.isKinematic = false;

            MotionAnimation.enabled = false;
        }
    }

}
