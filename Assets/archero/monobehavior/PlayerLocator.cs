
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class PlayerLocator : MonoBehaviour
    {
        [SerializeField] private Gun gun;

        [SerializeField] private Transform playerTransform;

        [SerializeField] private Transform targetTransform;

        

        private void Awake()
        {

        }

        private void FixedUpdate()
        {
         

            if (targetTransform != null)
            {
                playerTransform.LookAt(targetTransform);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                targetTransform = other.transform;
                playerTransform.LookAt(targetTransform);
                gun.SetAggression(true);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                targetTransform = null;
                
                    gun.SetAggression(false);
              
            }
        }
    }
}
