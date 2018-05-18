using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public bool isRightDoorOpen = false;
    public bool isLeftDoorOpen = false;
    [SerializeField]
    float rayRange = 2f;

    public void GateRaycast(RaycastHit hit)
    {
        Transform hinge = hit.transform.parent.GetComponent<Transform>();
    }
    public void RightDoor(RaycastHit hit)
    {
        Transform hinge = hit.transform.parent.GetComponent<Transform>();

        if (!isRightDoorOpen)
        {
            Debug.Log("Open");
            hinge.transform.Rotate(0, 90, 0);
            isRightDoorOpen = !isRightDoorOpen;
        }
        else
        {
            Debug.Log("Close");
            hinge.rotation = Quaternion.Euler(0, 90, 0);
            isRightDoorOpen = !isRightDoorOpen;   
        }
    }
    public void LeftDoor(RaycastHit hit)
    {
        Transform hinge = hit.transform.parent.GetComponent<Transform>();
        if (!isLeftDoorOpen)
        {
            Debug.Log("Open");
            hinge.transform.Rotate(0, -90, 0);
            isLeftDoorOpen = !isLeftDoorOpen;
        }
        else
        {
            hinge.rotation = Quaternion.Euler(0, 90, 0);
            Debug.Log("Close");
            isLeftDoorOpen = !isLeftDoorOpen;
        }
    }
}
