using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;

    // Use this for inialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        ) else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    //Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
   
    

 