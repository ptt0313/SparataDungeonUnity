using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupEquip : MonoBehaviour
{
    public Text infotext;
    public Button confirmBtn;
    public void PopupSetting(ItemSlot slot)
    {
        if (slot.inputData.isEquiped)
        {
            infotext.text = "������ �����Ͻðڽ��ϱ�?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() =>
            {  slot.inputData.isEquiped = false;
               slot.ChangeEquip();
            });
            
        }
        else
        {
            infotext.text = "���� �Ͻðڽ��ϱ�?";
            confirmBtn.onClick.AddListener(() =>
            {  slot.inputData.isEquiped = true;
               slot.ChangeEquip();
            });

        }
    }
}
