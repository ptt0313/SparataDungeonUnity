using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatusManager : MonoBehaviour
{
    public static CharacterStatusManager instance;

    public PlayerStatus playerStatus;
    private void Awake()
    {
        instance = this;
    }

}
