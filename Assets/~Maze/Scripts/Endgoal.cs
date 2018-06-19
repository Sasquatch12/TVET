using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgoal : MonoBehaviour 
{
	public Rigidbody2D rb;
	public float speed;
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{

			rb.MovePosition (transform.position + -transform.right * speed);
			/*Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;*/
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb.MovePosition (transform.position + transform.right * speed);
			/*Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;*/
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.MovePosition (transform.position + transform.up * speed);
			/*Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;*/
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rb.MovePosition (transform.position + -transform.up * speed);
			/*Vector3 position = this.transform.position;
			position.y--;
			this.transform.position = position;*/
		}
	}
	public void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.CompareTag("Goal"))
		{
			Debug.Log ("Hit");
			Application.LoadLevel("Maze3");
		}
	}
}
