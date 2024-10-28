using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour, IInteractable
{
    [SerializeField] private Sprite _image;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Interact()
    { 
        UIManager.Instance._inspectionUIPanel.Toggle(_image);
    }
}
