using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instance;            //A reference to our game control script so we can access it statically.
    public GameObject gameOvertext;                //A reference to the object that displays the text which appears when the player dies.

    public Text scoreText;
    private int score = 0;                        //The player's score.
    public bool gameOver = false;     
    public float scrollSpeed = -3f;


    void Awake() //to enforce singleton pattern
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetKeyDown("space"))
        {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void FrogScored()
    {
        if(gameOver == true)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void FrogDied()
    {
        //Activate the game over text.
        gameOvertext.SetActive(true);
        //Set the game to be over.
        gameOver = true;
    }
}
