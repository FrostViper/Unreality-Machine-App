using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Handler : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;
    private bool flip = false;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }



    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        Vector3 temp = GetMouseWorldPos();
        if (Input.GetKey(KeyCode.Z))
        {
            temp.y = 8.5f;
            temp.z = -0.04f;
            temp.x = 0f;
        }
        else
        {
            temp.y = 6f;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            flip = !flip;
            if (flip)
            {
                transform.rotation = Quaternion.Euler(180, 90, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(this.gameObject);
        }

        transform.position = temp + mOffset;
    }

    private void OnMouseUp()
    {
        Vector3 temp = transform.position;
        temp.y = 6f;
        transform.position = temp;
    }
}

    
    
