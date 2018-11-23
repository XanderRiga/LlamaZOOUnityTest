using UnityEngine;
using UnityEditor;
using System.Collections;


public class CaveGenerator : ScriptableWizard {

	[MenuItem("GameObject/Create Random Cave")]

	static void CreateWizard() {
		ScriptableWizard.DisplayWizard<CaveGenerator> ("Create Cave", "Create");
	}

	void OnWizardCreate() {
		GameObject currentMap = GameObject.Find("Map");
		GameObject currentGround = GameObject.Find("Ground");

		if (currentMap != null && currentGround != null) {
			Destroy(currentMap);
			Destroy(currentGround);
		}
		GameObject caveGO = (GameObject)Instantiate(Resources.Load("Map"));
		caveGO.name = "Map";
		GameObject groundGO = (GameObject)Instantiate(Resources.Load("Ground"));
		groundGO.name = "Ground";
	}

	void OnWizardUpdate() {
		helpString = "Click create to create a random cave";
	}
 }
