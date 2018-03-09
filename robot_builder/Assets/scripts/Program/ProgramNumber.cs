using UnityEngine;
using System.Collections;

public class ProgramNumber : MonoBehaviour {

	ProgramBlock programBlock;

	float programNumberValue;

	// Use this for initialization
	void Start () {

		programBlock = GetComponent<ProgramBlock> ();
		programBlock.SetProgramBlockName ("Number");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float GetProgramNumberValue() {
		return programNumberValue;
	}
}
