﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Detect : MonoBehaviour
{
    // Update is called once per frame
    private Collider2D[] col;
    void Update ()
    {
        if(!Input.GetMouseButton(0))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        ScreenMouseRay();
	}
    public void ScreenMouseRay()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5;
        Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);
        col = Physics2D.OverlapPointAll(v);
        if(col.Length > 0)
        {
            foreach (Collider2D c in col)
            {
                if(c.CompareTag("Button"))
                {
                    if (!Input.GetMouseButton(0))
                    {
                        c.GetComponent<SpriteRenderer>().color = Color.green;
                    }
                    else if(Input.GetMouseButtonDown(0))
                    {
                        c.GetComponent<SpriteRenderer>().color = Color.cyan;
                        Debug.Log("Play");
                        SceneManager.LoadScene(1);
                    }
                }
            }
        }
    }
}
