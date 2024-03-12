using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class GunPlayer : Gun
    {
         

      private  void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        
    }
}