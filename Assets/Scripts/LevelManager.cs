using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;

     Portal player;

    void Awake(){
        instance = this;
    }

    public bool levelActive;
    private bool LevelDefeat;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Portal>();

        levelActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelActive){
            if(player.currentHealth <= 0){

                levelActive = false;
                LevelDefeat = true;

               UIController.instance.gameOver.SetActive(true);
            }
        }
    }
}
