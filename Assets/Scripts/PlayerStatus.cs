using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStatus", menuName = "ScriptableObjects/PlayerStatus")]
public class PlayerStatus : ScriptableObject
{
    //플레이어 스탯 스크립터블오브젝트로 만들기
    [Header("Stat")]
    public float Atk;
    public float Def;
    public float Hp;
    public float cri;
}
[CreateAssetMenu(fileName = "NewPlayerInfo", menuName = "ScriptableObjects/PlayerInfo" )]
public class PlayerInfo : PlayerStatus
{
    //플레이어 스탯을 상속한 플레이어 인포를 스크립터블오브젝트로 만들기

    [Header("Info")]
    public string Name;
    public string Descript;
}


