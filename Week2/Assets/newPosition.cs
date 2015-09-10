using UnityEngine;
using System.Collections;

public class newPosition : MonoBehaviour {
	private float Speed = .01f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position =  gameObject.transform.position + new Vector3 (0.1f, 0.1f, 0);
	
		gameObject.transform.Rotate(Vector3.forward);
	}
}
