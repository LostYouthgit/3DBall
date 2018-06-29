using UnityEngine;
using System.Collections;

public class RightCube : MonoBehaviour {


	public GameObject ball;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3 (26f,1f, ball.transform.position.z - 1f);
	}

	  void OnMouseDrag()
    {        
        if (rb.position.x > 23.5 && rb.position.x < 26.5)
        {
            rb.MovePosition(rb.position + Vector3.right * 3f * Time.deltaTime);
        }

        else if (rb.position.x <= 23.5)

            rb.AddForce(Vector3.right * 1f);

        else if (rb.position.x >= 26.5)

            rb.AddForce(Vector3.left * 1f);
    }
}

