using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one GM in the scene");
        }
        else
        {
            Instance = this;
        }
    }

    private InputController m_InputController;
    public InputController InputController
    {
        // getting InputController script component 
        get
        {
            if (m_InputController == null)
            {
                m_InputController = gameObject.GetComponent<InputController>();
            }
            return m_InputController;
        }
    }

}
