using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour 
{
	public float time = 5;
	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
