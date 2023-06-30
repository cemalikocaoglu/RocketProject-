
using RocketProject.Inputs;
using RocketProject.Movments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace RpcketProject.PlayerControllers
{
    public class PlayerController : MonoBehaviour
    {
        Mover _mover;

        [SerializeField] float force;
        
        Rigidbody _rigidbody;

        DefaultInput _Input;


        bool _forceUp;        
        private void Awake()
        {

            _rigidbody = GetComponent<Rigidbody>();
            _Input = new DefaultInput();

            _mover = new Mover(GetComponent<Rigidbody>());

            
        }

        private void Update()
        {
            Debug.Log(_Input.IsForceUp);
            
            if(_Input.IsForceUp)
            {
                _forceUp = true;
            }
            else
            {
                _forceUp = false;
            }


        }


        private void FixedUpdate()
        {
            if (_forceUp)
            {
                //_rigidbody.AddForce(Vector3.up * Time.deltaTime * force);

                _mover.FixedTick();
            }
            //_rigidbody.AddForce(Vector3.up * Time.deltaTime * 100);
        }
    }
}