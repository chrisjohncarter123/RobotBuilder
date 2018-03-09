using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgramTrueFalseBlock : MonoBehaviour {

	ProgramBlock programBlock;

	// Use this for initialization
	void Start () {


		programBlock = GetComponent<ProgramBlock> ();
		programBlock.SetProgramBlockName ("True False");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool GetTrueFalseValue() {
		return true;
	}
}
