using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStatus : MonoBehaviour
{
    [SerializeField] Text atkText;
    [SerializeField] Text defText;
    [SerializeField] Text hpText;
    [SerializeField] Text criText;
    [SerializeField] Text moneyText;

    private void Start()
    {
        atkText.text = CharacterStatusManager.instance.playerStatus.atk.ToString();
        defText.text = CharacterStatusManager.instance.playerStatus.def.ToString();
        hpText.text = CharacterStatusManager.instance.playerStatus.hp.ToString();
        criText.text = CharacterStatusManager.instance.playerStatus.cri.ToString();
        moneyText.text = CharacterStatusManager.instance.playerStatus.Money.ToString();
    }
}