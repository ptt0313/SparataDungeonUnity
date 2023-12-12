using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    public GameObject buttonCanvas;
    public GameObject playerStatus;
    public GameObject _inventory;
   
    public void OnClickStatus()
    {
        FalseButtonCanvas();
        playerStatus.SetActive(true);
    }

    public void OnClickIventory()
    {
        FalseButtonCanvas();
        _inventory.SetActive(true);

    }

    private void FalseButtonCanvas()
    {
        buttonCanvas.SetActive(false);
    }

    public void OnClickReturn()
    {
        buttonCanvas.SetActive(true);
        playerStatus.SetActive(false);
        _inventory.SetActive(false);
    }
}
