using UnityEngine;
using UnityEditor;
using System.Collections;

public class CaveGenerator : EditorWindow {
	int width;
	int height;

	[MenuItem ("Window/Cave Generator")]

	public static void  ShowWindow () {
        EditorWindow.GetWindow(typeof(CaveGenerator));
    }
    
    void OnGUI () {
        GUILayout.Label ("Base Settings", EditorStyles.boldLabel);

		width = (int) EditorGUILayout.Slider(width, 0, 1000);
		height = (int) EditorGUILayout.Slider(height, 0, 1000);
    }
}
