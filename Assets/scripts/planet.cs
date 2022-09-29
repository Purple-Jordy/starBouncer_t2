using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class planet : MonoBehaviour
{

    public float rotateSpeed;
    public GameObject star;
    public GameObject key;
    
    public Animator anim;
    public GameObject camTartget;
    bool touchStar = false;
    bool meet;
    

    void Update()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

        //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();
        //k = GameObject.Find("Circle").GetComponent<Transform>();
        //monster1.transform.RotateAround(gameObject.transform.position, Vector3.forward, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Vector2.Distance(gameObject.transform.position, star.transform.position) <= 0.7f)

        if (meet == true)
        {

            
            star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
            star.transform.RotateAround(gameObject.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
            star.GetComponent<CircleMove>().rotateSpeed = rotateSpeed;
            

            //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();
            //move.speed = go;


            if (Input.GetMouseButtonDown(0))
            {
                star.GetComponent<CircleMove>().bc();
                //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();  
                //move.bc();

            }
        }

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {
            star.transform.localEulerAngles = new Vector3(0, 0, 90);
            meet = true;
            anim.SetBool("touched", true);
            //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();
            //move.rigid.velocity = Vector2.zero;
            //move.transform.localEulerAngles = new Vector3(0, 0, 180);

            


            camera campoint = GameObject.Find("Main Camera").GetComponent<camera>();
            campoint.target = camTartget;

            if (touchStar == false)
            {
                key.GetComponent<keySystem>().count += 1;
                touchStar = true;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        meet = false;
    }



    private void ab()
    {           
        //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();


       // CircleMove.GetComponent<CircleMove>().rotateAround = gameObject;
        //CircleMove.GetComponent<CircleMove>().rotateSpeed = rotateSpeed;
        //CircleMove.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
        
        

        //move.transform.RotateAround(gameObject.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);
        //move.rigid.velocity = Vector2.zero;

    }
    
    public void clear()
    {
        //gameObject.GetComponent<DrawLine>().enabled = true;
    }


}