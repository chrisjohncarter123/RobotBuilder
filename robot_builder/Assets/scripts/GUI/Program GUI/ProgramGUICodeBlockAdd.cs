using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgramGUICodeBlockAdd : MonoBehaviour {

	ProgramManager programManager;

	public GameObject codeBlock;

	Vector2 startDragPoint;
	Vector2 endDragPoint;
	RectTransform dragLineGraphic;

	DragMode dragMode;
	enum DragMode {
		NotDragging,
		Dragging
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (dragMode == DragMode.Dragging) {


			if (Input.GetMouseButtonUp (0)) {
				ExitDragMode ();
			} 


			dragLineGraphic.rotation.eulerAngles = Vector2.Angle (startDragPoint, endDragPoint);


		}


	}

	public void EnterDragMode() {

	}

	public void ExitDragMode() {
		Vector2 mouse = Input.mousePosition;

		List<ProgramGUICodeBlockGraphic> codeBlockGraphics;
		for (int i = 0; i < codeBlockGraphics.Count; i++) {
			RectTransform ret = codeBlockGraphics [i].GetComponent<RectTransform> ();
			if (ret.rect.Contains (mouse)) {
				programManager.AddCodeBlockToOpenFile(codeBlockGraphics[i].Get
			}
		}
	}
}
