using UnityEngine;
using System.Collections;

public class ProgramVariable : MonoBehaviour {

	float variableValue = 0;
	string variableName;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetVariableName(string variableName) {
		this.variableName = variableName;
		this.name = "Variable:" + variableName;
	}
	public string GetVariableName() {
		return variableName;
	}
	public void AssignValue(float variableValue) {
		this.variableValue = variableValue;
	}
	public float GetValue() {
		return variableValue;
	}
}
