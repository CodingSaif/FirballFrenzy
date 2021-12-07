using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirballControll : MonoBehaviour
{   
    Rigidbody rb;
    public float speed;
    private float dirZ;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        firedestroy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {   
        int x;
        x=Random.Range(-1,1);
        if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==false)
        {
            rb.velocity = new Vector3(speed,-speed*2 ,speed*x);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(other.gameObject);
            GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover=true;
        }
    }

    void firedestroy()
    {
         Destroy(gameObject,1.8f);
    }
}
