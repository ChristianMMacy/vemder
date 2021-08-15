using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoundaries : MonoBehaviour
{
    public GameObject TopRight;
    public GameObject BottomLeft;

    // Update is called once per frame
    void Update()
    {
        UpdateBoundaries();
    }

    void UpdateBoundaries()
    {
        // Move the top right boundary to the top right of the current screen resolution
        var topRightPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane));
        TopRight.transform.position = topRightPoint;

        // Move the bottom left boundary to the bottom left of the current screen resolution
        var bottomLeftPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        BottomLeft.transform.position = bottomLeftPoint;
    }
}
