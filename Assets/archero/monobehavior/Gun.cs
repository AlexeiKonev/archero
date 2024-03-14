using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace archhero
{

    public class Gun : MonoBehaviour, IShootable, ISetAggression
    {
        [SerializeField] protected float delayShoot = 2f;
        protected bool aggression = false;

        public GameObject bulletPrefab;
        public AudioSource shootSound;

        public void SetAggression(bool value)
        {
            aggression = value;
        }

        public void Shoot()
        {
            if (aggression)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                shootSound.Play();
            }
        }
    }



}
