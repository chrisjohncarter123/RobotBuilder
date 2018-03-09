using UnityEngine;
using System.Collections;


public class ProgramIfBlock : MonoBehaviour {

	ProgramBlock programBlock;
	ProgramTrueFalseBlock trueFalseBlock;
	ProgramAssignVariableBlock assignVariableBlock;


	// Use this for initialization
	void Start () {
		programBlock = GetComponent<ProgramBlock> ();
		programBlock.SetProgramBlockName ("If");
		trueFalseBlock = ProgramFile.AddProgramBlock <ProgramTrueFalseBlock> (gameObject).GetComponent<ProgramTrueFalseBlock> ();
		assignVariableBlock = ProgramFile.AddProgramBlock <ProgramAssignVariableBlock> (gameObject).GetComponent<ProgramAssignVariableBlock> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void RunProgramBlock() {
		Debug.Log ("If");
		if (trueFalseBlock.GetTrueFalseValue ()) {
			assignVariableBlock.SendMessage ("RunProgramBlock");

		}

		programBlock.EndProgramBlock ();
	}

}
