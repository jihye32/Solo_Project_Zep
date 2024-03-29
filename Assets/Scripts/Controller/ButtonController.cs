using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void OnClickChangeName()
    {
        GameManager.I.playerNameText.text = GameManager.I.ChangeName.text;
        GameManager.I.ChangeNameBoard.SetActive(false);
    }

    public void OnClickChangeNameBoard()
    {
        GameManager.I.ChangeNameBoard.SetActive(true);
    }

    public void OnClickChangeCharacter(int index)
    {
        GameManager.I.ChangedCharacter(index);
        GameManager.I.ChangeCharacterBoard.SetActive(false);
    }

    public void OnClickChangeCharacterBoard()
    {
        GameManager.I.ChangeCharacterBoard.SetActive(true);
    }

    public void OnClickCallBell()
    {
        GameManager.I.CallBellMessage.SetActive(true);
        GameManager.I.CallBell.SetActive(false);
        GameManager.I.OnMessage = true;
    }

    public void OnClickCallEnd()
    {
        GameManager.I.CallBellMessage.SetActive(false);
        GameManager.I.CallBell.SetActive(true);
        GameManager.I.OnMessage = false;
    }
}
