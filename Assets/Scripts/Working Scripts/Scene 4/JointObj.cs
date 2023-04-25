using UnityEngine;

public class JointObj : MonoBehaviour
{
    private bool isMouseDragging;
    private Vector3  offsetToMouse;
    private Rigidbody rb;
    private ConfigurableJoint cJoint;
    private SpringJoint sJoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cJoint = GetComponent<ConfigurableJoint>();
        sJoint = GetComponent<SpringJoint>();

        // Lock the Z-axis motion of the joint
       //Joint.angularXMotion = ConfigurableJointMotion.Locked;
       //Joint.angularYMotion = ConfigurableJointMotion.Locked;
       //Joint.angularZMotion = ConfigurableJointMotion.Locked;
       //Joint.zMotion = ConfigurableJointMotion.Locked;
    }

    void OnMouseDown()
    {
            isMouseDragging = true;
            //offsetToMouse = transform.position - GetMouseWorldPos();
            //rb.isKinematic = true;
            //cJoint.connectedBody = null; // Disconnect the joint from the anchor points

    }

   

    void OnMouseUp()
    {
        isMouseDragging = false;
        //rb.isKinematic = false;
        //cJoint.connectedBody = transform.parent.GetComponent<Rigidbody>(); // Reconnect the joint to the anchor points
    }

    void Update()
    {
        if (isMouseDragging)
        {
            transform.position = new Vector3(GetMouseWorldPos().x + offsetToMouse.x, GetMouseWorldPos().y + offsetToMouse.y, 0f);
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        //mousePos.z = Camera.main.transform.position.z - transform.position.z;
        mousePos.z = 0;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
