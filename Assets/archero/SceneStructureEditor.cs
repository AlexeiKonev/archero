using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace archhero
{
    [CustomEditor(typeof(SceneStructureCreator))]
    public class SceneStructureEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            SceneStructureCreator myScript = (SceneStructureCreator)target;

            if (GUILayout.Button("Создать иерархию сцены"))
            {
                myScript.CreateSceneStructure();
            }
        }
    }
}
