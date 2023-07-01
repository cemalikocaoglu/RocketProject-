using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace RocketProject.Movments
{
    public class Fuel : MonoBehaviour
    {

        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particle;

        public bool IsEmpty => _currentFuel < 1f;

        public Fuel()
        {
            
        }

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }


        public void FuelIncrease(float increase)
        {
            //fuelValue = value;
            _currentFuel += increase;
            _currentFuel = math.min(_currentFuel, 100);

            if(_particle.isPlaying)
            {
                _particle.Stop();
            }

        }

        public void fuelDecrase(float decrase)
        {
            _currentFuel -= decrase;
            _currentFuel = math.max(_currentFuel, 0);

            if(_particle.isStopped)
            {
                _particle.Play();
            }


        }






    }
}