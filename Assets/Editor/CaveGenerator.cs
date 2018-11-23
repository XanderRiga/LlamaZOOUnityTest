using UnityEngine;
using UnityEditor;
using System.Collections;


public class CaveGenerator : ScriptableWizard {

	[MenuItem("GameObject/Create Random Cave")]

	static void CreateWizard() {
		ScriptableWizard.DisplayWizard<CaveGenerator> ("Create Cave", "Create");
	}

	void OnWizardCreate() {
		GameObject caveGO = (GameObject)Instantiate(Resources.Load("Map"));
		GameObject groundGO = (GameObject)Instantiate(Resources.Load("Ground"));
	}

	void OnWizardUpdate() {
		helpString = "Click create to create a random cave";
	}
 }
