using RocketProject.Managers;
using RocketProject.UIs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketProject.Controllers
{


    public class WallController : MonoBehaviour
    {
       

        

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player !=null && player.canMove)
            {
                GameManager.Instance.GameOver();
               

            }

        }





    }



}