using UnityEngine;
using System.Collections;

public class elevatorScript : MonoBehaviour {
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 5) {
			rb.AddForce (new Vector3 (0, 30, 0) * Input.GetAxis ("Vertical"));
		} else {
			rb.AddForce (new Vector3 (0, -30, 0) * Input.GetAxis ("Vertical"));
		}

	}
}
