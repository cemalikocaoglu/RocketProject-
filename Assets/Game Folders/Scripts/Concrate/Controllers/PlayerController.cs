

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

using RocketProject.Inputs;
using RocketProject.Movments;
using RocketProject.Managers;

namespace RocketProject.Controllers
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
        Fuel _fuel;

        public  float TurnSpeed => _turnSpeed;
        public float Force => _force;

        public bool canMove => _canMove;


        bool _canMove;

        bool _canForceUp;        
        private void Awake()
        {

            _rigidbody = GetComponent<Rigidbody>();
            _Input = new DefaultInput();

            _mover = new Mover(this);

            _rotator = new Rotator(this);

            _fuel = GetComponent<Fuel>();

            
        }

        private void Start()
        {
            _canMove = true;
        }


        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced += HandleOnEventTrigger;
        }


        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced -= HandleOnEventTrigger;

        }




        private void Update()
        {

            if (!_canMove) return;

            
            if(_Input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.1f);
            }

            _leftRight = _Input.LeftRight;

        }


        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                //_rigidbody.AddForce(Vector3.up * Time.deltaTime * force);

                _mover.FixedTick();
                _fuel.fuelDecrase(0.2f);
            }


            _rotator.FixedTick(_leftRight);
            //_rigidbody.AddForce(Vector3.up * Time.deltaTime * 100);
        }




        private void HandleOnEventTrigger()
        {

            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);




        }



    }
}