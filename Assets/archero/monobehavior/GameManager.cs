using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private int score = 0;

        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void AddScore(int amount)
        {
            score += amount;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
