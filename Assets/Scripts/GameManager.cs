using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject buttonCanvas;
    public GameObject _canvas;
    public GameObject playerStatus;
    public GameObject btnManager;
    void Start()
    {
        GameObject newPlayer = Instantiate(player);
        GameObject newButtonCanvas = Instantiate(buttonCanvas);
        GameObject newCanvas = Instantiate(_canvas);
        GameObject newPlayerStatus = Instantiate(playerStatus);
        GameObject enwBtnManager = Instantiate(btnManager);

    }
}
