using Mono.CompilerServices.SymbolWriter;
using RocketProject.Inputs;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using UnityEngine;

namespace RocketProject.Inputs
{
    public class DefaultInput
    {


        DefaultActions _Inputs;

        

        public bool IsForceUp { get; private set; }


        public DefaultInput()
        {
             _Inputs = new DefaultActions();


            _Inputs.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();

            _Inputs.Enable();
        }

        
    }
}