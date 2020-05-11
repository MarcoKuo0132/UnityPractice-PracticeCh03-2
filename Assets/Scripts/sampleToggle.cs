using UnityEngine;
using System.Collections;

public class sampleToggle : MonoBehaviour {
	
	private bool toggle;
	private float val;
	
	// Use this for initialization
	void Start () {
		val = 0.0f;
		toggle = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		float SW = Screen.width;
		float SH = Screen.height;

		toggle = GUI.Toggle(
			new Rect(SW/3, SH/5, SW/3, SH/5), 
			toggle, "test");
		val = GUI.VerticalSlider(
			new Rect(SW/5, SH/3, SW/10, SH/3), 
			val, -100.0f, 100.0f);
		
		if(toggle){
			GUI.Box(
				new Rect(SW/3, SH*2/5, SW/3, SH/5), 
				val.ToString());
		}
	}
}
