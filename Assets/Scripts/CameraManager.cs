using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    private Collider2D _currentRoom;
    public CinemachineVirtualCamera _virtualCamera;

    public void SetCamera(Vector2 pos)
    {
        _virtualCamera.transform.position = new Vector3(pos.x, pos.y, _virtualCamera.transform.position.z);
    }
}
