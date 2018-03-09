using UnityEngine;
using System.Collections;

public class ProgramGUICodeBlockGraphic : MonoBehaviour {

	public Text programNameText;
	ProgramManager manager;
	ProgramBlock programBlock;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void InitializeGraphic(ProgramManager manager, ProgramBlock programBlock) {
		this.manager = manager;
		this.programBlock = programBlock;
	}

	/*
	public void OnDeleteButtonClick() {
		manager.DeleteProgram (programFile);
	}
	*/

}
