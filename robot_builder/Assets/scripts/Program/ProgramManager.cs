using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class ProgramManager : MonoBehaviour {

	List<ProgramFile> programFiles;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddNewProgramFile() {
		GameObject newProgramFile = new GameObject ();
		newProgramFile.AddComponent<ProgramFile> ();
		newProgramFile.transform.parent = transform;
		newProgramFile.GetComponent<ProgramFile> ().SetProgramName ("New Program");
		GameObject graphic = ProgramGUIManager.StaticAddProgramFile (newProgramFile.GetComponent<ProgramFile> ());
		graphic.GetComponent<ProgramGUIProgramFileGraphic> ().InitializeGraphic (this, newProgramFile.GetComponent<ProgramFile>());
	}

	public void RunOpenProgram() {

	}

	public void DeleteProgram(ProgramFile programFile) {
		
	}

	public void RunProgram(ProgramFile programFile) {
		programFile.StartRunningProgramFile ();
	}

	public void OpenProgram(ProgramFile programFile) {

	}
	public void AddNewVariable() {
		GameObject newProgramVariable = new GameObject ();
		newProgramVariable.transform.parent = transform;
		newProgramVariable.AddComponent<ProgramVariable> ();
		newProgramVariable.GetComponent<ProgramVariable> ().SetVariableName ("New Variable");
		GameObject graphic = ProgramGUIManager.StaticAddVariable (newProgramVariable.GetComponent<ProgramVariable> ());
		graphic.GetComponent<ProgramGUIVariableGraphic> ().InitializeGraphic (this, newProgramVariable.GetComponent<ProgramVariable>());

		//newProgramVariable.GetComponent<ProgramVariable> ().SetVariableName (variableName);

	}
	public void DeleteVariable(ProgramVariable variable) {

	}

	public void AddCodeBlockToOpenFile(ProgramBlock programBlock) {
		
	}
}
