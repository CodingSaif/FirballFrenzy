using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{   
    public bool gameover;
    public GameObject text;
    public GameObject button1;
    public GameObject button2;
    public GameObject img;
    public GameObject text2;
    public GameObject text3;



    // Start is called before the first frame update
    void Start()
    {
        gameover=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            button1.SetActive(true);
            text.SetActive(true);
            img.SetActive(true);
            button2.SetActive(true);
            text2.SetActive(true);
            text3.SetActive(true);
        }

        else if(!gameover)
        {
            button1.SetActive(false);
            text.SetActive(false);
            img.SetActive(false);
            button2.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
        }


    }

    public void Menu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void samescene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
