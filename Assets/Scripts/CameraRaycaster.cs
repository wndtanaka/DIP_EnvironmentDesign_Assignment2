using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public enum Interactable
    {
        DOOR,
        GATE,
        THRONE
    }
    public class CameraRaycaster : MonoBehaviour
    {
        [SerializeField]
        float rayRange = 2;
        [SerializeField]
        LayerMask layerMask;
        [SerializeField]
        GameObject interactPanel;
        [SerializeField]
        Text interactText;

        CameraLook cameraLook;
        RigidbodyFirstPersonController rb;

        bool isOpen = false;
        bool isSeated = false;

        InputController controller;



        void Start()
        {
            rb = GetComponent<RigidbodyFirstPersonController>();
            cameraLook = GetComponent<CameraLook>();
            controller = GameManager.Instance.InputController;
        }

        void Update()
        {
            if (isSeated)
            {
                interactPanel.SetActive(true);
                interactText.text = "'E' to Stand";

                cameraLook.enabled = true;
                if (controller.Interact)
                {
                    cameraLook.enabled = false;
                    rb.enabled = true;
                    isSeated = false;
                }
                return;
            }
            // raycast from the player
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, rayRange, layerMask))
            {
                #region Door Raycaster
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Door"))
                {
                    interactPanel.SetActive(true);
                    interactText.text = "'E' to Open";
                    // Open and close door mechanics, door able to open outwards depends on player position
                    if (controller.Interact)
                    {
                        Door door = hit.transform.GetComponent<Door>();
                        door.DoorRaycast(hit);
                    }
                }

                #endregion

                #region Throne Raycaster
                // checking if it raycast hit gameObject layered Throne
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Throne"))
                {
                    interactPanel.SetActive(true);
                    interactText.text = "'E' to Sit";
                    // check interact button is called
                    if (controller.Interact)
                    {
                        Debug.Log("Sit");
                        transform.position = hit.transform.position + new Vector3(.5f, 0, 0);
                        rb.enabled = false;
                        transform.rotation = Quaternion.Euler(0, 90, 0);
                        isSeated = true;
                    }
                }
                #endregion
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Gate"))
                {
                    Gate gate = hit.transform.GetComponent<Gate>();
                    interactPanel.SetActive(true);
                    if (gate.isRightDoorOpen)
                    {
                        interactText.text = "'E' to Close";
                    }
                    else
                    {
                        interactText.text = "'E' to Open";
                    }

                    if (controller.Interact)
                    {

                        if (hit.transform.name == "RightDoor")
                        {
                            gate.RightDoor(hit);
                        }
                        if (hit.transform.name == "LeftDoor")
                        {
                            gate.LeftDoor(hit);
                        }
                        //Transform hinge = hit.transform.parent.GetComponent<Transform>();
                        //Debug.Log("ok");
                        //if (hit.transform.name == "RightDoor")
                        //{
                        //    hinge.transform.Rotate(0, 90, 0);
                        //}
                        //else if (hit.transform.name == "LeftDoor")
                        //{
                        //    hinge.transform.Rotate(0, -90, 0);
                        //}
                    }
                }
            }
            else
            {
                interactPanel.SetActive(false);
            }
        }
    }
}