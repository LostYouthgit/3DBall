using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {


	public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (25f,1f, ball.transform.position.z - 2f);
	}
}
