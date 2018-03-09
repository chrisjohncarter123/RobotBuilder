using UnityEngine;
using System.Collections;

public class ProgramBlock : MonoBehaviour {

	bool programBlockIsRunning = false;
	ProgramBlockRunningState programBlockRunningState;
	string programBlockName;

	public enum ProgramBlockRunningState {
		notRunning,
		isRunning
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetProgramBlockName(string programBlockName) {
		this.programBlockName = programBlockName;
		this.name = programBlockName;
	}
	public string GetProgramBlockName() {
		return programBlockName;
	}
	public ProgramBlockRunningState GetProgramBlockRunningState() {
		return programBlockRunningState;
	}
	public void RunProgramBlock() {
		programBlockRunningState = ProgramBlockRunningState.isRunning;
	}
	public void EndProgramBlock() {
		programBlockRunningState = ProgramBlockRunningState.notRunning;
	}
}
