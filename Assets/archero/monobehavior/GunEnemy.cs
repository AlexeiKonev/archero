
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class GunEnemy : Gun
    {
        public bool agresion = false;
        public float delayShoot = 1f;

        private void Awake()
        {
            StartCoroutine(ShootCoroutine());
        }

        public void SetAgresion(bool value)
        {
            agresion = value;
        }

        IEnumerator ShootCoroutine()
        {
            while (true)
            {
                if (agresion)
                {
                    Debug.Log("x");
                    Shoot();
                    // «десь должен быть ваш код дл€ выстрела
                    yield return new WaitForSeconds(delayShoot);
                }
                else
                {
                    yield return null; // ∆дем следующего кадра, если агресси€ отключена
                }
            }
        }
    }
}