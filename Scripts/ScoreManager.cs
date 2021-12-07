using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{   
    int Score,ice;
    public Text mytext;
    public Text newtext;


    // Start is called before the first frame update
    void Start()
    {
        Score=0;
        ice=0;
    }

    // Update is called once per frame
    void Update()
    {
         if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==false)
        {
            Score++;
        }   

        else if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==true) 
        {
            mytext.text="Your Score is  " + Score ;
            newtext.text="Ice Collected  " + ice ;
            
        }
    }

    public void scoreincrease()
    {
        Score = Score + 50;
        ice= ice+1;
    }
}
