using RocketProject.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RocketProject.UIs
{

    public class GameOverPanel : MonoBehaviour
    {
        public GameObject _gameOverPanel;

        private void Awake()
        {
            if(_gameOverPanel.activeSelf)
            {

                _gameOverPanel.SetActive(false);
            }
        }



        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleGameOver;
        }

    


        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleGameOver;
        }
        private void HandleGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);

            }
        }


        public void restartClick()
        {
            GameManager.Instance.LoadLevelScene(0);
        }


        public void exitClick()
        {
            GameManager.Instance.LoadMenuScene();
        }

        



    }

}