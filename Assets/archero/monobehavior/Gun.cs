using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class Gun : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public AudioSource shootSound;
 

        public void Shoot()
        {
            // Instantiate bullet prefab at position and rotation of weapon
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // Apply force to bullet in forward direction of weapon
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            // Play shooting sound
            shootSound.Play();
        }
    }
}