using RocketProject.Managers;
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

            if (player !=null)
            {
                GameManager.Instance.GameOver();
            }

        }





    }



}