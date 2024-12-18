using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : Singleton<RoomManager>
{
    private Dictionary<Vector2, Room> _rooms = new();
    
    [SerializeField] private int _width, _height;
    [SerializeField] private Room _roomPrefab;
    public Room currentRoom;

    private void Start()
    {
        GenerateRoom();
        Debug.Log(_roomPrefab.GetComponent<BoxCollider2D>().size);
    }

    private void Update()
    {
        
    }

    // private void UpdateCurrentRoom()
    // { 
    //     Vector2 newRoom = new Vector2(
    //         Mathf.Floor(_player.transform.position.x / _roomSize.x),
    //         Mathf.Floor(_player.transform.position.y / _roomSize.y)
    //     );
    //
    //     if (newRoom != currentRoom)
    //     {
    //         currentRoom = newRoom;
    //         MoveCameraToRoom(newRoom);
    //     }
    // }

    private Vector2 PlayerPosition()
    {
        // Assuming the player has the tag "Player"
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        return player.transform.position;
    }

    private void MoveCameraToRoom(Vector2 room)
    {
        // Vector3 newCameraPos = new Vector3(
        //     (room.x + 0.5f) * _roomSize.x,
        //     (room.y + 0.5f) * _roomSize.y,
        //     Camera.main.transform.position.z
        // );
    }
    
    public void GenerateRoom()
    {
        Vector2 roomSize = _roomPrefab.GetComponent<BoxCollider2D>().size;

        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                Room spawnedRoom = Instantiate(_roomPrefab, new Vector3((i * roomSize.x) + roomSize.x / 2f, (j * roomSize.y) + roomSize.y / 2f), Quaternion.identity);
                spawnedRoom.name = "Room " + i + ", " + j;

                _rooms.Add(new Vector2(i, j), spawnedRoom);
            }
        }
        
        //_cam.position = new Vector3(_width / 2f - 0.5f, _height / 2f - 0.5f, -10);
    }
}
