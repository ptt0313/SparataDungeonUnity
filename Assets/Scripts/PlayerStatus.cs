using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStatus", menuName = "ScriptableObjects/PlayerStatus")]
public class PlayerStatus : ScriptableObject
{
    //�÷��̾� ���� ��ũ���ͺ������Ʈ�� �����
    [Header("Stat")]
    public float Atk;
    public float Def;
    public float Hp;
    public float cri;
}
[CreateAssetMenu(fileName = "NewPlayerInfo", menuName = "ScriptableObjects/PlayerInfo" )]
public class PlayerInfo : PlayerStatus
{
    //�÷��̾� ������ ����� �÷��̾� ������ ��ũ���ͺ������Ʈ�� �����

    [Header("Info")]
    public string Name;
    public string Descript;
}


