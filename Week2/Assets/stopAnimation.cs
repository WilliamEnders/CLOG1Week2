using UnityEngine;
using System.Collections;

public class stopAnimation : MonoBehaviour {
	private Animator anim;
	private GameObject maincamera;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		maincamera = GameObject.Find("Camera1");
		anim = maincamera.GetComponent<Animator>();
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (new Vector3 (0, 0, -20) * Input.GetAxis ("Horizontal"));
	}

	void OnTriggerEnter(){
		anim.speed = 0;
	}
	void OnTriggerExit(){
		anim.speed = 1;
	}
}
