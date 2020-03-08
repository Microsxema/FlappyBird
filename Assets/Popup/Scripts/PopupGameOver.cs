using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird.Popup
{
    public class PopupGameOver : PopupBase
    {
        [SerializeField]
        private GameObject[] _buttonInPanel;

        [SerializeField]
        private RectTransform _panelTransform;

        private Vector3 _panelInitialStatePosition;

        [SerializeField]
        private float _panelInPositionY;

        [SerializeField]
        private float _speedAnimationPanel;

        private IEnumerator ShowAnimationPanel()
        {
            while (_panelTransform.localPosition.y < _panelInPositionY)
            {
                _panelTransform.localPosition += new Vector3(0, _speedAnimationPanel * Time.deltaTime, 0);

                yield return null;
            }

            ButtonState(true);
        }

        private void Awake()
        {
            _panelInitialStatePosition = _panelTransform.localPosition;
        }

        public override void Show()
        {
            base.Show();

            StartCoroutine(ShowAnimationPanel());
        }

        public override void Close()
        {
            base.Close();

             _panelTransform.localPosition = _panelInitialStatePosition;

            ButtonState(false);
        }

        private void ButtonState(bool value)
        {
            foreach (var button in _buttonInPanel)
            {
                button.SetActive(value);
            }
        }
    }
}

