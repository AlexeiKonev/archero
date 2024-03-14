
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class GunEnemy : Gun
    {

        //public float delayShoot = 1f;

        private void Awake()
        {
            StartCoroutine(ShootCoroutine());
        }

        //public override void SetAgresion(bool value)
        //{
        //    agresion = value;
        //}

        IEnumerator ShootCoroutine()
        {
            while (true)
            {
                if (aggression)
                {
                    Debug.Log("GunEnemy");
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