using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask _interactableLayerMask;
    [SerializeField] private Collider2D _interactionRange;
    [SerializeField] private Text _interactUI;

    [SerializeField] private IInteractable _currentInteractable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IInteractable interactable))
        {
            _currentInteractable = interactable;
            _interactUI.gameObject.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IInteractable interactable) && _currentInteractable == interactable)
        {
            _currentInteractable = null;
            _interactUI.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _currentInteractable != null)
        {
            _currentInteractable.Interact();
            
        }
    }
}
