using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*=================================================================
 * BackGroundController
 * Student: Lucas Krespi dos Santos, 
 * ID: 101289546
 * Date last Modified: 18/101/2021
 * check logic and change variable names;
 * change logic to portrait mode;
====================================================================
*/
public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
