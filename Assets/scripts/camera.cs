using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject target;
    public float speed;
    private Vector3 targetPos;

    public BoxCollider2D bound; // Map bound
    private Vector3 minBound;  // Map�� ���� �Ʒ�
    private Vector3 maxBound; // Map�� ������ ��
    private float halfWidth; // ī�޶� ������ ����
    private float halfHeight; // ī�޶� ������ ����
    private Camera theCamera; // ī�޶� Size �� �������

    // Zoom In, Zoom Out ���� ����
    //private float maxDist = 7.0f; // �ִ� ����
    //private float minDist = 5.0f;  // ���̿�
    private float zoomSpeed = 1f; //�� �ӵ�
    private float distance;  //ī�޶�� ���̴� ����



    // Start is called before the first frame update
    void Start()
    {
        if (theCamera == null)
            theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;

        distance = Camera.main.GetComponent<Camera>().orthographicSize; //�Ÿ� �ʱ�ȭ

        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.gameObject != null)
        {
            targetPos.Set(target.transform.position.x,
                      target.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position,
                                      targetPos, speed * Time.deltaTime);

            float clampX = Mathf.Clamp(transform.position.x,
                   minBound.x + halfWidth, maxBound.x - halfWidth);
            float clampY = Mathf.Clamp(transform.position.y,
                       minBound.y + halfHeight, maxBound.y - halfHeight);
            transform.position = new Vector3(clampX, clampY,
                                         transform.position.z);
        
            
        
        }
    }

    void LateUpdate()
    {
        //zoomIn();

    }


    public void zoomIn()
    {

        //distance = 7;
        if (distance < 7)
        {
            distance += zoomSpeed * Time.deltaTime;
            Camera.main.GetComponent<Camera>().orthographicSize = distance;
        }



    }
    
    public void zoomOut()
    {
        distance -= zoomSpeed;
        Camera.main.GetComponent<Camera>().orthographicSize = distance;
    }
    


}
