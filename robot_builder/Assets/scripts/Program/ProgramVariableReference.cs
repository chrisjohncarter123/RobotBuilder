using UnityEngine;
using System.Collections;

public class ProgramVariableReference : MonoBehaviour {

	ProgramBlock programBlock;
	ProgramVariable programVariable;

	// Use this for initialization
	void Start () {
		programBlock = GetComponent<ProgramBlock> ();
		programBlock.SetProgramBlockName ("Vairable Reference");
	}

	// Update is called once per frame
	void Update () {

	}
	public void AssignValue(float variableValue) {
		programVariable.AssignValue( variableValue );
	}
	public float GetValue() {
		return programVariable.GetValue ();
	}
}
