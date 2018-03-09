using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgramGUIProgramFileGraphic : MonoBehaviour {

	public Text programNameText;
	ProgramManager manager;
	ProgramFile programFile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void InitializeGraphic(ProgramManager manager, ProgramFile programFile) {
		this.manager = manager;
		this.programFile = programFile;
		programNameText.text = programFile.GetProgramName ();
	}

	public void OnDeleteButtonClick() {
		manager.DeleteProgram (programFile);
	}

	public void OnOpenButtonClick() {
		manager.OpenProgram (programFile);
	}

	public void OnRunButtonClick() {
		manager.RunProgram (programFile);
	}
}
