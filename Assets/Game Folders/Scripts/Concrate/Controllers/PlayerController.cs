
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

        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 75f;


        Mover _mover;

        //[SerializeField] float force;
        
        Rigidbody _rigidbody;

        DefaultInput _Input;
        float _leftRight;

        Rotator _rotator;

        public  float TurnSpeed => _turnSpeed;
        public float Force => _force;

        


        bool _forceUp;        
        private void Awake()
        {

            _rigidbody = GetComponent<Rigidbody>();
            _Input = new DefaultInput();

            _mover = new Mover(this);

            _rotator = new Rotator(this);
            
        }

        private void Update()
        {
            Debug.Log(_Input.LeftRight);
            
            if(_Input.IsForceUp)
            {
                _forceUp = true;
            }
            else
            {
                _forceUp = false;
            }

            _leftRight = _Input.LeftRight;

        }


        private void FixedUpdate()
        {
            if (_forceUp)
            {
                //_rigidbody.AddForce(Vector3.up * Time.deltaTime * force);

                _mover.FixedTick();
            }


            _rotator.FixedTick(_leftRight);
            //_rigidbody.AddForce(Vector3.up * Time.deltaTime * 100);
        }
    }
}