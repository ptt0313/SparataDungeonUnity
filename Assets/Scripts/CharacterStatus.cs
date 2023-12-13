using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    [Serializable]
    public class Status
    {      
        public string characterName;
        public int level;
        public int exp;
        public int gold;
        public PlayerStatus playerstatus;
    }
}
