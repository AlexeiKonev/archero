using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace archhero
{
    public class GunPlayer : Gun
    {
        public PlayerController pl;
        //[SerializeField]
        //private float delayShoot = 2f;


        public   void Awake()
        {
            StartCoroutine(ShootCoroutine());
        }

        //public override void SetAgresion(bool value)
        //{
        //    agresion = value;
        //}

        private IEnumerator  ShootCoroutine()
        {
            while (true)
            {
                if (aggression && pl.State== CharacterState.stop)
                {
                    Debug.Log("GunPlayer");
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