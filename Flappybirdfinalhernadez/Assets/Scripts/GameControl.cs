using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;                        //A reference to our game control script so we can acces it statically.
    public Text sxoreText;                                    //A reference to the UI text component that displays the player's score.
    public GameObject gameOvertext;                          //A reference to the object that displays the text which appears when the player dies.

    private int score = 0;                                  //The player's score.
    public bool gameOver = false;                          //Is the game over
    public float scrollSpeed = -1.5f;


    void Awake()
    {
        //If we dont currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetMouseButton(0))
        {
            //..reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene()buildIndex);
        }
    }

    public void BirdScored()
    {
        //The bird cant score if the game is over.
        if (gameOver)
            return;
        //If the game is not over, increase the score...
        score++;
        //...and adjust the score text.
        scoreText.text = "Score: " + score.ToString();
    }