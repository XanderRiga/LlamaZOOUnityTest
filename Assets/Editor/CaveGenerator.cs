using UnityEngine;
using UnityEditor;
using System.Collections;


public class CaveGenerator : ScriptableWizard {
	// public MeshFilter walls;
	// public MeshFilter cave;
	

	[MenuItem("GameObject/Create Random Cave")]

	// public static void  ShowWindow () {
    //     EditorWindow.GetWindow(typeof(CaveGenerator));
    // }

	static void CreateWizard() {
		ScriptableWizard.DisplayWizard<CaveGenerator> ("Create Cave", "Create");
	}

	void OnWizardCreate() {
		GameObject caveGO = new GameObject();

		MapGenerator mapComponent = caveGO.AddComponent<MapGenerator>();
		MeshGenerator meshComponent = caveGO.AddComponent<MeshGenerator>();

		// meshComponent.walls = walls;
		// meshComponent.cave = cave;
	}

	void OnWizardUpdate() {
		helpString = "Add meshfilters for cave and walls and click create to make a random cave";
	}   


    // void OnGUI () {
    //     GUILayout.Label ("Base Settings", EditorStyles.boldLabel);

	// 	width = (int) EditorGUILayout.Slider(width, 0, 1000);
	// 	height = (int) EditorGUILayout.Slider(height, 0, 1000);

	// 	isCreatingCave = EditorGUILayout.DropdownButton(new GUIContent("Create Cave"), new FocusType());
    // }

	// void Update() {
	// 	if (isCreatingCave) { // Actually create a cave!
	// 		mapObj = PrefabUtility.InstantiatePrefab(Selection.activeObject as GameObject) as GameObject;
	// 	}
	// }
 }
