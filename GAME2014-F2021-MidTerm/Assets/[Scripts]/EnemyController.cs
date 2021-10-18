using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*=================================================================
 * EnemyController
 * Student: Lucas Krespi dos Santos, 
 * ID: 101289546
 * Date last Modified: 18/101/2021
 * check logic and change variable names;
 * change logic to portrait mode;
====================================================================
*/
public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
