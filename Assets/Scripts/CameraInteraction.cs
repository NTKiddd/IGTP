using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    public CinemachineVirtualCamera _virtualCamera;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bounds"))
        {
            Debug.Log("Player entered the camera trigger");
            _virtualCamera.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, -10);
        }
    }
}
