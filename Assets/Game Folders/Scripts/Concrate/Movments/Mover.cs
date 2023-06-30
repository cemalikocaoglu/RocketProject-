using JetBrains.Rider.Unity.Editor;
using RpcketProject.PlayerControllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketProject.Movments
{
    public class Mover
    {
        PlayerController _playerController;
        Rigidbody _rigidbody;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;   
            _rigidbody = playerController.GetComponent<Rigidbody>();
            
        }

        public void FixedTick()
        {

            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }

      





    }
}