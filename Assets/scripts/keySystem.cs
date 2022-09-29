using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class keySystem : MonoBehaviour
{
    public GameObject starLine;
    public int count;
    public GameObject star;
    public GameObject fullShot;
    public GameObject cam;
    public GameObject camBound;
    public GameObject success;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {
            
            star.SetActive(false);
            star.GetComponent<CircleMove>().panel.SetActive(false);
            Invoke("wait", 1);
            cam.GetComponent<camera>().target = fullShot;
            Invoke("name", 4);


            //campoint.target = fullShot;


        }
    }

    void LateUpdate()
    {
        if (count == 3)
        {

            zoomIn();


        }
            
    }




    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {

            ///Invoke("wait", 1);
            //camera campoint = GameObject.Find("Main Camera").GetComponent<camera>();
            
            //GameObject.Find("Circle").SetActive(false);


        }
    }

    void wait()
    {
        starLine.SetActive(true);
    }

    void zoomIn()
    {
        cam.GetComponent<camera>().zoomIn();
        camBound.SetActive(false);
        
    }

    void name()
    {
        success.SetActive(true);
    }

}
