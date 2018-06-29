﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour {


	public float speed = 5f;
	Rigidbody rb;
	
	public bool isgrounded = false;

	public int directionInput;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody>();
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
			

	}

	public void FixedUpdate()
	{
		


		if (rb.position.x > 23.5 && rb.position.x < 26.5)
		{
			float moveX = Input.GetAxis("Horizontal");
			rb.MovePosition (rb.position + Vector3.right * moveX * speed * Time.deltaTime);
		}

		else if(rb. position.x <= 23.5)
			
			rb.AddForce (Vector3.right * 1f);

		else if(rb.position.x >= 26.5)
			
			rb.AddForce (Vector3.left * 1f);

		

		

	}

	void OnMouseDrag()
	{
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			rb.position = Vector3.MoveTowards(rb.position, new Vector3(mousePos.x, rb.position.y, rb.position.z), speed * Time.deltaTime);		

		
	}

	public void Move()
	{
		rb.AddForce ((Vector3.up + Vector3.forward) * 200f);
		//rb.MovePosition (rb.position + Vector3.up * speed * Time.deltaTime * 100);
	}

	public void Move(int InputAxis)
	{
		directionInput = InputAxis;
		Debug.Log(InputAxis);

		
	}

	void Stop()
	{
		rb.Sleep();
		rb.WakeUp();
	}

	void OnCollisionEnter (Collision touch)
	{
		if (touch.gameObject.tag == "Ground")
		{
			isgrounded = true;
		}
		if(isgrounded)
		{
			Stop();
			Move();
		}

		if (touch.gameObject.tag == "Finish")
			GameOverMenu();

		if (touch.gameObject.tag == "NextLevel")
			SceneManager.LoadScene("Scene2");
	}

	void ReloadLvl ()
	{
		SceneManager.LoadScene("Scene1");

	}

	void GameOverMenu()
	{
		SceneManager.LoadScene("GameOverMenu");
	}

			

}
