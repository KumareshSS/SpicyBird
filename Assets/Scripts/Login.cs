using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
	public GameObject Ingame;
	public GameObject Start;
	public AudioSource startClip;

	public void StartPressed()
	{
		Start.gameObject.SetActive(false);

		Ingame.gameObject.SetActive(true);
	
	}
	public void reload()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void StartGameAudio()
	{
		startClip.Play();
	}
}
