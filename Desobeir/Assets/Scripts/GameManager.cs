using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
            
        //Sets this to not be destroyed when reloading scene
        // use full to keep it until the end of the game.
        DontDestroyOnLoad(gameObject);

        //might be usefull;
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {


    }

    //Update is called every frame.
    void Update()
    {

  //       this test is useless but i'm keeping it :) 
        if (Input.GetKeyDown("space"))
        {
            // Debug.Log("test"); 
            SceneManager.LoadScene("test1");  // load the scene named test1
        }
        

    }
}