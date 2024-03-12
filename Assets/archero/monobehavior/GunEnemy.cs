
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class GunEnemy : Gun
    {
        public bool agresion = false;
        public float delayShoot = 1f;

        private void Awake()
        {
            StartCoroutine(ShootCoroutine());
        }

        public void SetAgresion(bool value)
        {
            agresion = value;
        }

        IEnumerator ShootCoroutine()
        {
            while (true)
            {
                if (agresion)
                {
                    Debug.Log("x");
                    Shoot();
                    // ����� ������ ���� ��� ��� ��� ��������
                    yield return new WaitForSeconds(delayShoot);
                }
                else
                {
                    yield return null; // ���� ���������� �����, ���� �������� ���������
                }
            }
        }
    }
}