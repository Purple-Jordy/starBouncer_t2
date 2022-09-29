using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    
    public float rotateSpeed;
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(gameObject.transform.position, star.transform.position) <= 0.9f)
        {
            star.transform.RotateAround(gameObject.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
            star.GetComponent<CircleMove>().rotateSpeed = rotateSpeed;
        }

    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {
            //star.transform.localEulerAngles = new Vector3(0, 0, 180);
            //CircleMove move = GameObject.Find("Circle").GetComponent<CircleMove>();
            //move.rigid.velocity = Vector2.zero;
            //move.transform.localEulerAngles = new Vector3(0, 0, 0);

        }
    }
}
