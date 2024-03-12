using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class EnemyLocator : MonoBehaviour
    {
       [SerializeField] private GunEnemy gun;

        private void Awake()
        {
            
        }
        private void OnTriggerEnter(Collider other)
        {
           if(other.gameObject.CompareTag("Player"))
            {
                gun.agresion = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                gun.agresion = false;
            }
        }
    }
}
