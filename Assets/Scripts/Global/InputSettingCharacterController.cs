using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;



public class InputSettingCharacterController : CharacterSettingController
{
    public InputField inputName;
    private string Name;

    public GameObject selectBoard;
    public GameObject selectPlayer;

    public List<Character> characterList = new List<Character>();
    private int index;

    public void OnLoadScene()
    {
        Name = inputName.text;
        if (Name.Length >= 2 && Name.Length <= 10)
        {
            SetName(Name);
            SetIndex(index);
            SceneManager.LoadScene("MainScene");
        }
        else return;
    }    

    public void SelectCharacterBoard()
    {
        selectBoard.SetActive(true);
    }

    public void ChangeImage(int index)
    {
        this.index = index;
        selectPlayer.GetComponent<Image>().sprite = characterList[index].CharacterSprite;
        if (index == 1)
        {
            selectPlayer.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 1);
            selectPlayer.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 10, 0);
            selectPlayer.GetComponent<Image>().SetNativeSize();
        }
        else
        {
            selectPlayer.GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 1);
            selectPlayer.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 30, 0);
            selectPlayer.GetComponent<Image>().SetNativeSize();
        }
        selectBoard.SetActive(false);
    }
}
