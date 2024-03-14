using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class EnemyLocator : MonoBehaviour
    {
       [SerializeField] private Gun gun;
       [SerializeField] private Transform enemyTransform;

       [SerializeField] private Transform playerTransform;


        private void Awake()
        {
            
        }

        private void FixedUpdate()
        {
            if (playerTransform != null)
            {
                enemyTransform.LookAt(playerTransform);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
           if(other.gameObject.CompareTag("Player"))
            {
                playerTransform = other.transform;
                enemyTransform.LookAt(playerTransform);
                gun.SetAgresion(true)   ;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerTransform = null;
                gun.SetAgresion(false);  
            }
        }
    }
}
