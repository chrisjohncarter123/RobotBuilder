using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgramFile : MonoBehaviour {

	string programFileName = "Unamed Program File";

	List<ProgramBlock> programBlocks;
	List<ProgramVariable> programVariables;

	bool programIsRunning = false;
	int programBlockRunning = -1;

	public string GetProgramName() {
		return programFileName;
	}
	public void SetProgramName(string programFileName) {
		this.programFileName = programFileName;
		name = programFileName;
	}
	// Use this for initialization
	void Start () {
		programBlocks = new List<ProgramBlock> ();

		GameObject newProgramBlock = AddProgramBlock <ProgramIfBlock> (gameObject);
		programBlocks.Add (newProgramBlock.GetComponent<ProgramBlock>());


	}


	// Update is called once per frame
	void Update () {
		if (programIsRunning) {
			if (programBlocks [programBlockRunning].GetProgramBlockRunningState () == ProgramBlock.ProgramBlockRunningState.notRunning) {
				RunNextLine ();
			}
		}

	}
	void RunNextLine() {
		programBlocks [programBlockRunning].SendMessage ("EndProgramBlock");
		if (programBlockRunning >= programBlocks.Count) {
			EndRunningProgramFile ();
		} else {
			programBlockRunning += 1;
			StartRunningCurrentProgramBlock ();
		}
	}
	void EndRunningProgramFile() {
		programIsRunning = false;
	}
	public void StartRunningCurrentProgramBlock() {
		programBlocks[0].SendMessage ("RunProgramBlock");
	}
	public void StartRunningProgramFile() {
		programBlockRunning = 0;
		StartRunningCurrentProgramBlock ();

	}
	public static GameObject AddProgramBlock<ProgramBlockType>(GameObject parentBlock) where ProgramBlockType : UnityEngine.Component{
		GameObject newProgramBlock = new GameObject ();
		newProgramBlock.transform.parent = parentBlock.transform;
		newProgramBlock.AddComponent<ProgramBlock> ();

		newProgramBlock.AddComponent<ProgramBlockType> ();

		return newProgramBlock;


	}
}
