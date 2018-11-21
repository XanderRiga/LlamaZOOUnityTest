using UnityEngine;
using UnityEditor;
using System.Collections;

public class CaveGenerator : EditorWindow {
	int width;
	int height;
	bool isCreatingCave;

	[MenuItem ("Window/Cave Generator")]

	public static void  ShowWindow () {
        EditorWindow.GetWindow(typeof(CaveGenerator));
    }
    
    void OnGUI () {
        GUILayout.Label ("Base Settings", EditorStyles.boldLabel);

		width = (int) EditorGUILayout.Slider(width, 0, 1000);
		height = (int) EditorGUILayout.Slider(height, 0, 1000);

		isCreatingCave = EditorGUILayout.DropdownButton(new GUIContent("Create Cave"), new FocusType());
    }

	void Update() {
		if (isCreatingCave) { // Actually create a cave!
			// MapGenerator.GenerateMap(); // TODO Modify this code to work in a static context or bring it into this file
		}
	}
 }
