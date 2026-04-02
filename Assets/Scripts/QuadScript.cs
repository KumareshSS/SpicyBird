	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScript : MonoBehaviour
{
	public float Height;
	public float Width;
	public float offset;
	 
	
	
	
	
	// Start is called before the first frame update
	void Start()
	{
		Height = Camera.main.orthographicSize * 2f;
		Width = Height * Screen.width / Screen.height;
		transform.localScale = new Vector3(Width, Height, 0.5f);

	}

	// Update is called once per frame
	void Update()
	{
		offset += Time.deltaTime * 0.1f;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
	}
}
