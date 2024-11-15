using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    
    public static Game obj;

    public int maxLives = 5;

    public bool gamePaused = false;

    void Awake()
    {
        obj = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
       
    }

    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnDestroy()
    {
        obj = null;
    }
}


