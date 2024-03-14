using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace archhero
{

    public abstract class Gun : MonoBehaviour, IShootable, ISetAgres
    {
        [SerializeField]
        protected float delayShoot = 2f;

        protected  bool agresion = false;

        public GameObject bulletPrefab;

        public AudioSource shootSound;

        public  void SetAgresion(bool value)
        {
            agresion = value;
        }

        //public  void Awake()
        //{
        //    StartCoroutine(ShootCoroutine());
        //}


        public void Shoot()
        {
            // Instantiate bullet prefab at position and rotation of weapon
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // Apply force to bullet in forward direction of weapon
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            // Play shooting sound
            shootSound.Play();
        }


        //protected virtual IEnumerator ShootCoroutine()
        //{
        //    while (true)
        //    {
        //        if (agresion)
        //        {
        //            Debug.Log("Gun");
        //            Shoot();

        //            // «десь должен быть ваш код дл€ выстрела
        //            yield return new WaitForSeconds(delayShoot);
        //        }
        //        else
        //        {
        //            yield return null; // ∆дем следующего кадра, если агресси€ отключена
        //        }
        //    }
        //}

    }

    
}
