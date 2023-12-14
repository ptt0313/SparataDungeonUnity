using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStatus", menuName = "ScriptableObjects/PlayerStatus",order = 0)]
public class PlayerStatus : ScriptableObject
{
    //�÷��̾� ���� ��ũ���ͺ������Ʈ�� �����
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


