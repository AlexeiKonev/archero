using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class Bullet : MonoBehaviour, IDamage
    {
        private int damage = 3;

        public int Damage()
        {
            return damage;
        }
    }
}
