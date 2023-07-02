using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace RocketProject.Controllers
{
    public class MoverWallController : WallController
    {

        [SerializeField] Vector3 _direction;
        [SerializeField] float _factor;
        [SerializeField] float _speed = 1f;

        private const float FULL_CIRCLE = Mathf.PI * 2f;
        Vector3 _startPosition;

        private void Awake()
        {
           
            _startPosition = transform.position;

        }


        private void Update()
        {
            float cycle = Time.time / _speed;

            float sinValue= Mathf.Sin(cycle * FULL_CIRCLE);

            _factor = Mathf.Abs(sinValue);


            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }


    }
}