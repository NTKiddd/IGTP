using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectionPanel : MonoBehaviour
{
    [SerializeField] private Image _imageDiplay;

    public void Toggle(Sprite image)
    {
        if (!gameObject.activeInHierarchy)
        {
            Open(image);
        }
        else
        {
            Close();
        }
    }
    
    public void Open(Sprite image)
    {
        gameObject.SetActive(true);
        _imageDiplay.sprite = image;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
