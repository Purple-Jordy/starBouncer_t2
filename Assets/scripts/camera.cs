using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject target;
    public float speed;
    private Vector3 targetPos;

    public BoxCollider2D bound; // Map bound
    private Vector3 minBound;  // Map의 왼쪽 아래
    private Vector3 maxBound; // Map의 오른쪽 위
    private float halfWidth; // 카메라 가로의 절반
    private float halfHeight; // 카메라 세로의 절반
    private Camera theCamera; // 카메라 Size 가 담겨있음

    // Zoom In, Zoom Out 변수 선언
    //private float maxDist = 7.0f; // 최대 줌인
    //private float minDist = 5.0f;  // 줌이웃
    private float zoomSpeed = 1f; //줌 속도
    private float distance;  //카메라로 보이는 영역



    // Start is called before the first frame update
    void Start()
    {
        if (theCamera == null)
            theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;

        distance = Camera.main.GetComponent<Camera>().orthographicSize; //거리 초기화

        
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
