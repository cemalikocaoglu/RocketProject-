using RocketProject.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketProject.Controllers
{

    public class FinishFloorController : MonoBehaviour
    {


        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finishLight;


        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player == null && !player.canMove )  return; 


            if(collision.GetContact(0).normal.y ==-1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
                

            }
            else
            {
                
                    GameManager.Instance.GameOver();
                
            }
        }


    }

}