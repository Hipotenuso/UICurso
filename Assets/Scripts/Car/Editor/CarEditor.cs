using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;

        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);

        myTarget.speed = EditorGUILayout.IntField("Minha Velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcha", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade total", myTarget.TotalSpeed.ToString());

        EditorGUILayout.HelpBox("Calcule a velocidade total do carro!", MessageType.Info);

        if(myTarget.TotalSpeed > 200)
        {
            EditorGUILayout.HelpBox("Velocidade acima do permitido", MessageType.Error);
        }

        if(GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
    }
}
