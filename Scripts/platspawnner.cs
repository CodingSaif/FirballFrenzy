using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platspawnner : MonoBehaviour
{   
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform;
    public GameObject Fireball;
    

    Vector3 lastpos;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        lastpos= platform.transform.position;
        size = platform.transform.localScale.x;
        InvokeRepeating("spawnplat",2f,5f);
        InvokeRepeating("Firespawn",2f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==true)
        {
            CancelInvoke("spawnplat");
            CancelInvoke("Firespawn");
        }    

             
    }


    void spawnplat()
    {
        int randnum= Random.Range(0,3);
        if(randnum ==2)
        {
            Spawn1();
             
        }

        else if(randnum ==1)
        {
            Spawn2();
              
        }

        else if(randnum ==0)
        {
            Spawn3();
            
        }

    }

    void Spawn1()
    {
        Vector3 pos=lastpos;
        pos.x += -size;
        lastpos =pos;
        Instantiate(platform1,pos,Quaternion.identity);
    }

    void Spawn2()
    {
        Vector3 pos=lastpos;
        pos.x += -size;
       
        lastpos =pos;
        Instantiate(platform2,pos,Quaternion.identity);
    }

    void Spawn3()
    {
        Vector3 pos=lastpos;
        pos.x += -size;
        
        lastpos =pos;
        Instantiate(platform3,pos,Quaternion.identity);
    }


    void Firespawn()
    {   
        Vector3 pos=lastpos;
        pos=GameObject.Find("Player").GetComponent<Playecontrol>().lastpos;
        pos.x=pos.x-180;
        int dist = Random.Range(80,100);
        pos.y=pos.y+dist;

       int distx = Random.Range(-100,100);
        pos.z=pos.z+distx;

        Instantiate(Fireball,pos,Quaternion.identity);
    }

    
   
}
