using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==true)
        {
            killer();
        }
    }

    void OnTriggerExit(Collider col)
    {
    if(col.gameObject.tag== "Player")
    {
       killer();
    }
   // Debug.Log("Problem");
    }   

    public void killer()
    {
         Destroy(transform.parent.gameObject, 1f);
    }
}
