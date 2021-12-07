using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{   
    public GameObject ball;
    Vector3 offset;
    public bool gameOver;
    public float camspeed;
    // Start is called before the first frame update
    void Start()
    {
        offset=ball.transform.position - transform.position;
        gameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==false)
        {
            Follow();
        }
    }


    void Follow()
    {
        Vector3 pos=transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos= Vector3.Lerp(pos,targetPos,camspeed * Time.deltaTime);
        transform.position=pos;
    }
}
