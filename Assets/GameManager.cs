using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FlappyBird
{
    public class GameManager : MonoBehaviour, IGameManager
    {
        public UnityEvent BeginningGame { get; set; }

        public UnityEvent StartingGame { get; set; }

        public UnityEvent GameEnding { get; set; }

        public void OnBeginningGame()
        {
            BeginningGame?.Invoke();
        }

        public void OnStartingGame()
        {
            StartingGame?.Invoke();
        }

        public void OnGameEnding()
        {
            GameEnding?.Invoke();
        }

        private void Awake()
        {
            Game.GameManager = this;

            BeginningGame = new UnityEvent();
            StartingGame = new UnityEvent();
            GameEnding = new UnityEvent();
        }

        private void Start()
        {
            OnBeginningGame();
        }
    }
}

