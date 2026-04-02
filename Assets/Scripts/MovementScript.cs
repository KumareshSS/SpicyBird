using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
	public float speed = 2;
	
	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		
		if(transform.position.x <= -20)
		{
			transform.position = new Vector2(50, 0);
		
			gameObject.SetActive(false);
		}
	}

}
