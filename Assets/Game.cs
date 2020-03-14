using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlappyBird.Popup;
using UnityEngine.Events;

namespace FlappyBird
{
	public static class Game
	{
		public static IPopupManager PopupManager { get; set; }

        public static IGameManager GameManager { get; set; }
    }

    public interface IGameManager
    {
        UnityEvent BeginningGame { get; set; }

        UnityEvent StartingGame { get; set; }

        UnityEvent GameEnding { get; set; }

        void OnBeginningGame();

        void OnStartingGame();

        void OnGameEnding();
    }

    public interface IPopupManager
    {
        T GetPanel<T>() where T : PopupBase;
    }
}