using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    public GameObject buttonCanvas;
    public GameObject playerStatus;

    public void OnClickStatus()
    {
        FalseButtonCanvas();
        playerStatus.SetActive(true);
    }

    public void OnClickIventory()
    {
        FalseButtonCanvas();
    }

    private void FalseButtonCanvas()
    {
        buttonCanvas.SetActive(false);
    }

}
