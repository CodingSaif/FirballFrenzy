using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playecontrol : MonoBehaviour
{   
    private float dirX, dirZ;
    Rigidbody rb;
    public float speed;
    public float size;
    public GameObject ball;
    public ParticleSystem ice;
    public Vector3 lastpos;
    
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ice.Play();
        size=1;
        GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover=false;
    }

    // Update is called once per frame
    void Update()
    {
        dirZ = Input.GetAxis("Horizontal") * speed;
        lastpos= gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        if(GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover==false)
        {
            rb.velocity = new Vector3(-speed,-speed , dirZ);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Rock")
        {    
            
            
            if(size==3)
            {
            Scaledecrese(25);
            Destroy(other.gameObject);
            size=2;
            }

            else if(size==2)
            {
            Scaledecrese(10);
            Destroy(other.gameObject);
            size=1;
            }

            else if(size==1)
            {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover=true;
            }

            
        }

        else if(other.gameObject.tag=="Ice")
        {   
            
            //Destroy(part2, 1f);
            if(size==1)
            {
            Scaledecrese(25);
            Destroy(other.gameObject);
            GameObject.Find("Score Manager").GetComponent<ScoreManager>().scoreincrease();
            size=2;
            }

            else if(size==2)
            {
            Scaledecrese(50);
            Destroy(other.gameObject);
            GameObject.Find("Score Manager").GetComponent<ScoreManager>().scoreincrease();
            size=3;
            }

            else if(size==3)
            {
                Destroy(other.gameObject);
                GameObject.Find("Score Manager").GetComponent<ScoreManager>().scoreincrease();
            }

            Destroy(ice, 20f);

        }


         else if(other.gameObject.tag=="Trees")
         {
             Destroy(gameObject);
             GameObject.Find("GameManager").GetComponent<Gamemanager>().gameover=true;
         }
    }

    void Scaledecrese(int n)
    {
        ball.transform.localScale = new Vector3(n,n,n);
    }

    
}
