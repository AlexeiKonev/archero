using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace archhero
{
    public class DamageControll : MonoBehaviour,ITakeDamageable
    {
        [SerializeField]
        private int health = 10 ;
        [SerializeField]
        private Slider healthBar  ;
        IDamage bulleto;


        public void TakeDamage(int damage)
        {
            health -= damage;
            healthBar.value -= 0.3f;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("Bullet"))
            {
                GameObject bullet = collision.gameObject;

                bulleto = bullet.GetComponent<IDamage>();

                int damage = bulleto.Damage();

                if (health > 0)
                {
                    TakeDamage(damage);

                    Debug.Log("damaged");

                }
                else if (health < 0)
                {
                    Destroy(this.gameObject);
                }
            }


            
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                GameObject bullet = other.gameObject;

                bulleto = bullet.GetComponent<IDamage>();

                int damage = bulleto.Damage();

                if (health > 0)
                {
                    TakeDamage(damage);

                    Debug.Log("damaged");

                }
                else if (health < 0)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
