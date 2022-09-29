using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleMove : MonoBehaviour
{

    //public GameObject rotateAround;
    public float rotateSpeed;
    //public float speed;
    public Rigidbody2D rigid;
    //public GameObject rotateAround;
    public GameObject panel;
    
    


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //rigid.gravityScale = 0;
            //bc();
            rigid.velocity = Vector2.zero;
            rigid.AddRelativeForce(Vector2.up * rotateSpeed);

        }

       
       // if (Vector2.Distance(gameObject.transform.position, rotateAround.transform.position) <= 0.9f)
        {
            //transform.RotateAround(rotateAround.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
        }

    }

    public void bc()
    {
        //rigid.AddRelativeForce(Vector2.up * rotateSpeed);
        //rigid.AddForce(transform.forward * rotateSpeed);
        rigid.AddRelativeForce(transform.forward * rotateSpeed);
        //rigid.AddForce(new Vector2(10,10), ForceMode2D.Impulse);
        //rigid.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        //transform.Translate(0, rotateSpeed / 50, 0);
        //rigid.AddForce(Vector3.forward * 10);
        //rigid.velocity = Vector2.up * rotateSpeed / 50;

    }

    void OnBecameInvisible()
    {
        rigid.velocity = Vector2.zero;
        panel.SetActive(true);

       

    }


   



}


    
    




