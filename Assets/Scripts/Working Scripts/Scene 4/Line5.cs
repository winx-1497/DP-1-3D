using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line5 : MonoBehaviour
{
    public LineRenderer line;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;

    public Vector3 Vector3pos4;
    public JointObj jointObj;

    void Start()
    {
        line.positionCount = 3;
    }

 
    void FixedUpdate()
    {
        line.SetPosition(0, pos1.position);
        line.SetPosition(1, pos2.position);
        line.SetPosition(2, pos3.position);

        if (Input.GetMouseButton(0))
        {
            Vector3 screenMousePos = Input.mousePosition;
            Vector3pos4 = Camera.main.ScreenToWorldPoint(new Vector3(screenMousePos.x, screenMousePos.y, screenMousePos.z));
            jointObj.transform.position = Vector3pos4;
        }
    }

   }
