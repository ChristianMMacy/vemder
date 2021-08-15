using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoundaries : MonoBehaviour
{
    public GameObject TopRight;
    public GameObject BottomLeft;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetupBoundaries();
    }

    void SetupBoundaries()
    {
        Vector3 topRightPoint = new Vector3();
        Vector3 bottomLeftPoint = new Vector3();

        topRightPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane));
        TopRight.transform.position = topRightPoint;

        bottomLeftPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        BottomLeft.transform.position = bottomLeftPoint;
    }
}
