using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternDoor : MonoBehaviour
{
    [SerializeField] private bool _interactable;
    [SerializeField] private List<Direction> _directions;

    private Direction _playerInputDirection;
    [SerializeField] private int _correctInputCount;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _interactable = false;
        }
    }

    private void Update()
    {
        if (!_interactable) return;
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckInput(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckInput(Direction.Down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckInput(Direction.Left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckInput(Direction.Right);
        }
    }

    private void CheckInput(Direction direction)
    {
        if (direction == _directions[_correctInputCount])
        {
            _correctInputCount += 1;
            Debug.Log("correct");
            if (_correctInputCount == _directions.Count)
            {
                Debug.Log("DOOR OPENED");
                _correctInputCount = 0;
            }
        }
        else
        {
            _correctInputCount = 0;
        }
    }

    public enum Direction
    {
        Up,
        Left,
        Down,
        Right
    }
}
