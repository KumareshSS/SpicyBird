using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepatationScript : MonoBehaviour
{
	public GameObject pipe;
	public Vector2 pos;

	void Start()
	{
		StartCoroutine(Genratepipes());
	}

	IEnumerator Genratepipes()
	{
		while (true)
		{

			yield return new WaitForSeconds(3f);
			float rocky = Random.Range(1, -5f);
			pos = new Vector2(transform.position.x, rocky);
			Debug.Log(pos);
			// GameObject pipe1 =  Instantiate(pipe,  pos, Quaternion.identity);
			// pipe1.SetActive(true);
			GameObject pipe = ObjectPooling.sharedinstance.GetPooledObject();
			pipe.SetActive(true);
			pipe.transform.position = pos;
		}

	}
}

