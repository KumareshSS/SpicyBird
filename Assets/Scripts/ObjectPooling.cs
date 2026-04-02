using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPooling : MonoBehaviour
{
	public static ObjectPooling sharedinstance;
	public List<GameObject> poolobjects;
	public GameObject objecttopool;
	public int AmountPool;

    private void Awake()
	{
		sharedinstance = this;
	}

	void Start()
	{
		poolobjects = new List<GameObject>();
		GameObject pipe;


		for (int i = 0; i < AmountPool; i++)
		{
			pipe = Instantiate(objecttopool);
			pipe.transform.position = new Vector2(50, 0);
			pipe.SetActive(false);	
            poolobjects.Add(pipe);
        


        }
    }

	public GameObject GetPooledObject()
	{
		for (int i = 0; i < AmountPool; i++)
		{
			if (!poolobjects[i].activeSelf)
			{
				return poolobjects[i];
			}
		}
		return null;
	}
}
	