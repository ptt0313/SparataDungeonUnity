using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStatus", menuName = "ScriptableObjects/PlayerStatus",order = 0)]
public class PlayerStatus : ScriptableObject
{
    //플레이어 스탯 스크립터블오브젝트로 만들기
    [Header("Stat")]
    public float atk;
    public float def;
    public float hp;
    public float cri;
    public string nickName;
    public string descript;
    public int exp;
    public int userLv;
    public int Money;
}


