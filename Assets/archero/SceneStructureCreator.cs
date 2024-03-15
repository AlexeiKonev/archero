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
            Debug.Log("Создание иерархии сцены начато..."); // Создание главной камеры
            GameObject mainCamera = new GameObject("Главная камера");
            mainCamera.AddComponent<Camera>();
            mainCamera.tag = "MainCamera";

            // Создание источника освещения
            GameObject light = new GameObject("Освещение");
            light.AddComponent<Light>();
            light.transform.position = new Vector3(0, 10, 0);

            // Создание игрока
            GameObject player = new GameObject("Игрок");
            GameObject playerModel = new GameObject("Модель игрока");
            playerModel.transform.parent = player.transform;
            // Добавьте здесь компонент модели игрока, если это необходимо

            // Добавление скрипта управления
            player.AddComponent<PlayerController>(); // Предполагается, что у вас есть скрипт PlayerController

            // Создание врагов
            GameObject enemies = new GameObject("Враги");
            GameObject enemy1 = new GameObject("Враг 1");
            GameObject enemy1Model = new GameObject("Модель врага");
            enemy1Model.transform.parent = enemy1.transform;
            // Добавьте здесь компонент модели врага, если это необходимо

            // Добавление скрипта AI
           /* enemy1.AddComponent<EnemyAI>();*/ // Предполагается, что у вас есть скрипт EnemyAI

            GameObject enemy2 = new GameObject("Враг 2");
            GameObject enemy2Model = new GameObject("Модель врага");
            enemy2Model.transform.parent = enemy2.transform;
            // Добавьте здесь компонент модели врага, если это необходимо

            // Добавление скрипта AI
           /* enemy2.AddComponent<EnemyAI>();*/ // Предполагается, что у вас есть скрипт EnemyAI

            // Создание предметов
            GameObject items = new GameObject("Предметы");
            GameObject item1 = new GameObject("Предмет 1");
            GameObject item2 = new GameObject("Предмет 2");
            // Добавьте здесь компоненты предметов, если это необходимо

            // Создание статических объектов
            GameObject staticObjects = new GameObject("Статические объекты");
            GameObject building = new GameObject("Здание");
            GameObject tree = new GameObject("Дерево");
            // Добавьте здесь компоненты статических объектов, если это необходимо

            // Создание интерфейса пользователя
            GameObject ui = new GameObject("Интерфейс пользователя");
            GameObject scorePanel = new GameObject("Панель счета");
            GameObject pauseMenu = new GameObject("Меню паузы");
         
            // Добавьте здесь компоненты интерфейса пользователя, если это необходимо
        }
    }
}
