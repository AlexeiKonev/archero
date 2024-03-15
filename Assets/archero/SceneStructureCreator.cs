using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace archhero
{
    public class SceneStructureCreator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        internal void CreateSceneStructure()
        {
            Debug.Log("�������� �������� ����� ������..."); // �������� ������� ������
            GameObject mainCamera = new GameObject("������� ������");
            mainCamera.AddComponent<Camera>();
            mainCamera.tag = "MainCamera";

            // �������� ��������� ���������
            GameObject light = new GameObject("���������");
            light.AddComponent<Light>();
            light.transform.position = new Vector3(0, 10, 0);

            // �������� ������
            GameObject player = new GameObject("�����");
            GameObject playerModel = new GameObject("������ ������");
            playerModel.transform.parent = player.transform;
            // �������� ����� ��������� ������ ������, ���� ��� ����������

            // ���������� ������� ����������
            player.AddComponent<PlayerController>(); // ��������������, ��� � ��� ���� ������ PlayerController

            // �������� ������
            GameObject enemies = new GameObject("�����");
            GameObject enemy1 = new GameObject("���� 1");
            GameObject enemy1Model = new GameObject("������ �����");
            enemy1Model.transform.parent = enemy1.transform;
            // �������� ����� ��������� ������ �����, ���� ��� ����������

            // ���������� ������� AI
           /* enemy1.AddComponent<EnemyAI>();*/ // ��������������, ��� � ��� ���� ������ EnemyAI

            GameObject enemy2 = new GameObject("���� 2");
            GameObject enemy2Model = new GameObject("������ �����");
            enemy2Model.transform.parent = enemy2.transform;
            // �������� ����� ��������� ������ �����, ���� ��� ����������

            // ���������� ������� AI
           /* enemy2.AddComponent<EnemyAI>();*/ // ��������������, ��� � ��� ���� ������ EnemyAI

            // �������� ���������
            GameObject items = new GameObject("��������");
            GameObject item1 = new GameObject("������� 1");
            GameObject item2 = new GameObject("������� 2");
            // �������� ����� ���������� ���������, ���� ��� ����������

            // �������� ����������� ��������
            GameObject staticObjects = new GameObject("����������� �������");
            GameObject building = new GameObject("������");
            GameObject tree = new GameObject("������");
            // �������� ����� ���������� ����������� ��������, ���� ��� ����������

            // �������� ���������� ������������
            GameObject ui = new GameObject("��������� ������������");
            GameObject scorePanel = new GameObject("������ �����");
            GameObject pauseMenu = new GameObject("���� �����");
         
            // �������� ����� ���������� ���������� ������������, ���� ��� ����������
        }
    }
}
