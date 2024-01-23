using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public void OnClickChangeName()
    {
        GameManager.I.playerNameText.text = GameManager.I.changeName.text;
        GameManager.I.ChangeNameBoard.SetActive(false);
    }

    public void OnClickChangeNameBoard()
    {
        GameManager.I.ChangeNameBoard.SetActive(true);
    }
}
