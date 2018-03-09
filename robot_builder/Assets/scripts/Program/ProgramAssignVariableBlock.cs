using UnityEngine;
using System.Collections;

public class ProgramAssignVariableBlock : MonoBehaviour {

	ProgramBlock programBlock;
	ProgramVariableReference programVariableReference;
	ProgramNumber programNumber;

	float assignmentValue;

	// Use this for initialization
	void Start () {
		programBlock = GetComponent<ProgramBlock> ();
		programBlock.SetProgramBlockName ("Assign Variable");

		programVariableReference = ProgramFile.AddProgramBlock <ProgramVariableReference> (gameObject).GetComponent<ProgramVariableReference>();
		programNumber = ProgramFile.AddProgramBlock <ProgramNumber> (gameObject).GetComponent<ProgramNumber>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RunProgramBlock() {
		//programVariable.

		programVariableReference.AssignValue (programNumber.GetProgramNumberValue());

	}
		


}
