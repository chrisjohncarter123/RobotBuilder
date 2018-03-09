using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgramGUIVariableGraphic : MonoBehaviour {

	public Text variableNameText;
	public Text variableValueText;
	ProgramManager manager;
	ProgramVariable programVariable;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		variableValueText.text = programVariable.GetValue ().ToString();

	}

	public void InitializeGraphic(ProgramManager manager, ProgramVariable programVariable) {
		this.manager = manager;
		this.programVariable = programVariable;
		variableNameText.text = programVariable.GetVariableName ();

	}

	public void OnDeleteButtonClick() {
		manager.DeleteVariable (programVariable);
	}
		
}
