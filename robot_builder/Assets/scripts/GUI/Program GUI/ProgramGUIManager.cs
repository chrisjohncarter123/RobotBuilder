using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ProgramGUIManager : MonoBehaviour {


	public GameObject programFileGraphicPrefab;
	public GameObject programVariableGraphicPrefab;

	public RectTransform programFileParent;
	public RectTransform variableParent;

	List<ProgramGUIProgramFileGraphic> programFileGraphics;
	List<ProgramGUIVariableGraphic> programVariableGraphics;

	static ProgramGUIManager programGUIManager;

	// Use this for initialization
	void Start () {
		programFileGraphics = new List<ProgramGUIProgramFileGraphic> ();
		programVariableGraphics = new List<ProgramGUIVariableGraphic> ();
		programGUIManager = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject AddProgramBlock(ProgramBlock block) {
		GameObject newProgramFileGraphic = GameObject.Instantiate (programVariableGraphicPrefab);
		ProgramGUIVariableGraphic newGraphic = newProgramFileGraphic.GetComponent<ProgramGUIVariableGraphic> ();

		programVariableGraphics.Add(newGraphic);
		newProgramFileGraphic.GetComponent<RectTransform> ().parent = variableParent;
		newProgramFileGraphic.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (
			0,
			150 + (-100 * (programVariableGraphics.Count - 1)));

		return newProgramFileGraphic;
	}
	public static GameObject StaticAddBlock(ProgramBlock variable) {
		return programGUIManager.AddVariable (variable);

	}

	public static GameObject StaticAddVariable(ProgramVariable variable) {
		return programGUIManager.AddVariable (variable);

	}

	public GameObject AddVariable(ProgramVariable variable) {
		GameObject newProgramFileGraphic = GameObject.Instantiate (programVariableGraphicPrefab);
		ProgramGUIVariableGraphic newGraphic = newProgramFileGraphic.GetComponent<ProgramGUIVariableGraphic> ();

		programVariableGraphics.Add(newGraphic);
		newProgramFileGraphic.GetComponent<RectTransform> ().parent = variableParent;
		newProgramFileGraphic.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (
			0,
			150 + (-100 * (programVariableGraphics.Count - 1)));

		return newProgramFileGraphic;
	}

	public static GameObject StaticAddProgramFile(ProgramFile programFile) {
		return programGUIManager.AddProgramFile (programFile);

	}
	public GameObject AddProgramFile(ProgramFile programFile){
		GameObject newProgramFileGraphic = GameObject.Instantiate (programFileGraphicPrefab);
		ProgramGUIProgramFileGraphic newGraphic = newProgramFileGraphic.GetComponent<ProgramGUIProgramFileGraphic> ();

		programFileGraphics.Add(newGraphic);
		newProgramFileGraphic.GetComponent<RectTransform> ().parent = programFileParent;
		newProgramFileGraphic.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (
			0,
			150 + (-100 * (programFileGraphics.Count - 1)));

		return newProgramFileGraphic;
	}

}
