using RocketProject.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketProject.UIs
{
    public class WinPanel : MonoBehaviour
    {
        public GameObject winPanel;

        private void Awake()
        {
            if(winPanel.activeSelf)
            {
                winPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleWinPanel;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleWinPanel;
        }

        private void HandleWinPanel()
        {
            if(!winPanel.activeSelf)
            { 
                winPanel.SetActive(true);
            }

        }

        public void nextClick()
        {

            GameManager.Instance.LoadLevelScene(1);

        }

    }
}