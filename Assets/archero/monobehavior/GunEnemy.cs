using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class GunEnemy : Gun
    {

        public bool agresion = false;

        private float delayShoot = 1f;

        private void Awake()
        {
            
        }
        private  void Update()
        {
            if (agresion)
            {
              Invoke("Shoot",delayShoot);
            }
        }


        
    }
}