using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {


	public float speed = 20f;
	Rigidbody rb;
	
	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
			

	}

	public void FixedUpdate()
	{
		
		

		else if(rb. position.x <= 23.5)
			
			rb.AddForce (Vector3.right * 1f);

		else if(rb.position.x >= 26.5)
			
			rb.AddForce (Vector3.left * 1f);

		if (rb.position.y <= 0.17f)
		{
				Stop();
				Move();
		}	
	}

	public void Move()
	{
		if (rb.position.x > 23.5 && rb.position.x < 26.5)
		{
			float moveX = Input.GetAxis("Horizontal");
			rb.MovePosition (rb.position + Vector3.right * moveX * speed * Time.deltaTime);
		}
		rb.AddForce ((Vector3.up + Vector3.forward) * 200f);
		//rb.MovePosition (rb.position + Vector3.up * speed * Time.deltaTime * 100);
	}

	void Stop()
	{
		rb.Sleep();
		rb.WakeUp();
	}

}
