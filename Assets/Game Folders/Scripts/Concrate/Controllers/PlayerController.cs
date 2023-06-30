
using RocketProject.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace RpcketProject.PlayerControllers
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float force;
        
        Rigidbody _rigidbody;

        DefaultInput _Input;


        bool _forceUp;        
        private void Awake()
        {

            _rigidbody = GetComponent<Rigidbody>();
            _Input = new DefaultInput();
            
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
                _rigidbody.AddForce(Vector3.up * Time.deltaTime * force);

            }
            //_rigidbody.AddForce(Vector3.up * Time.deltaTime * 100);
        }
    }
}