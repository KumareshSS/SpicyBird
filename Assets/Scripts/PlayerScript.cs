using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
	public Rigidbody2D rb;
	public GameObject gameover;
	public TMP_Text scoreText;
	public TMP_Text HighscoreText;
	public int Highscore = 0;
	// public Text LifeText;	
	public int score = 0;
	// public static int life = 3;
//	public float impulseForce = 15;
public float Force;


	void Start()
	{
		scoreText.text = "Score:" + score;
		HighscoreText.text = PlayerPrefs.GetInt("HighScore:").ToString();
		//LifeText.text = "Life: " +life;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			rb.linearVelocity = Vector2.up*Force;
			//rb.AddForce(Vector2.up * impulseForce, ForceMode2D.Impulse);
		}
		scoreText.text = $"Score: {score}";
		HighscoreText.text =  PlayerPrefs.GetInt("HighScore", 0).ToString();



	}
	 private void HighScore()
	 {
	 	if(score> PlayerPrefs.GetInt("HighScore",0))
		 {
		 	PlayerPrefs.SetInt("HighScore",score);
			HighscoreText.text =  PlayerPrefs.GetInt("HighScore", 0).ToString();

			 
		 }
	 }
 	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.gameObject.tag == "Point")
		{
			score += 1;
			HighScore();
		}
		if (other.gameObject.tag == "Pipe")
		{
			Destroy(gameObject);
			gameover.SetActive(true);

		}


	}



}

