using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class rotaion_script : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject rotBtn;
	public Animator houseAni;


	// Use this for initialization
	void Start () {
		rotBtn = GameObject.Find ("ROTATION");
		rotBtn.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		houseAni.GetComponent<Animator> ();
		
		
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{

		houseAni.Play ("houseanimation");
		Debug.Log ("BTN Pressed");

	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){

		houseAni.Play ("none");
		Debug.Log ("BTN Released");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
