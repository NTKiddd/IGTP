using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour, IInteractable
{
    [SerializeField] private bool isActive;

    private void Start()
    {
        SetTrigger(isActive);
    }

    private void Toggle()
    {
        SetTrigger(!isActive);
    }

    private void SetTrigger(bool value)
    {
        if (value == true)
        {
            isActive = true;
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        {
            isActive = false;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    public void Interact()
    {
        Debug.Log("switched");
        Toggle();
    }
}
