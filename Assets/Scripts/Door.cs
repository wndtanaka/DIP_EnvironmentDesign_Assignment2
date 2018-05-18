using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen = false;
    [SerializeField]
    float rayRange = 2f;
    [SerializeField]
    Vector3 YOffset = new Vector3(0, 1.5f, 0);

    public void DoorRaycast(RaycastHit hit)
    {
        RaycastHit inHit;
        RaycastHit outHit;
        RaycastHit closeHit;

        // The rotation will affect 'Hinge' GameObject
        // get 'Hinge' transform component because 'Hinge' gameobject is the pivot point
        Transform hinge = hit.transform.parent.GetComponent<Transform>();

        // if the door is closed draw ray from both side of the door to locate player position
        if (!isOpen)
        {
            if (Physics.Raycast(hit.transform.position - new Vector3(-0.2f, YOffset.y, 0), transform.position, out inHit, rayRange + 100))
            {
                Debug.DrawRay(hit.transform.position - new Vector3(-0.2f, YOffset.y, 0), transform.position, Color.red);

                if (inHit.transform.gameObject.layer == LayerMask.NameToLayer("Player"))
                {
                    hinge.Rotate(0, 90, 0);
                    Debug.Log("Open out");
                    isOpen = !isOpen;
                    // TODO Animation for the door
                }
            }
            if (Physics.Raycast(hit.transform.position - new Vector3(0.2f, YOffset.y, 0), -transform.position, out outHit, rayRange + 100))
            {
                Debug.DrawRay(hit.transform.position - new Vector3(0.2f, YOffset.y, 0), -transform.position, Color.blue);
                if (outHit.transform.gameObject.layer == LayerMask.NameToLayer("Player"))
                {
                    hinge.Rotate(0, -90, 0);
                    Debug.Log("Open in");
                    isOpen = !isOpen;
                    // TODO Animation for the door
                }
            }
        }
        // if the door is open
        else
        {
            if (Physics.Raycast(hit.transform.position - new Vector3(0.5f, YOffset.y, 0), transform.forward, out closeHit, rayRange + 100))
            {
                Debug.DrawRay(hit.transform.position - new Vector3(0.5f, YOffset.y, 0), transform.forward, Color.black);
                // set rotation position to normal / default
                hinge.rotation = Quaternion.Euler(0, -90, 0);
                Debug.Log("Closed");
                isOpen = !isOpen;
                // TODO Animation for the door
            }
        }
    }

}
