using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public Text timeText;
    public GameObject ChangeNameBoard;
    public GameObject ChangeCharacterBoard;
    public GameObject CallBell;
    public GameObject CallBellMessage;
    public bool OnMessage = false;
    [Header("Change")]
    public InputField ChangeName;

    [Header("Player")]
    public Text playerNameText;
    public GameObject MainCharacter;
    public List<Character> characterList = new List<Character>();

    private NPCcontroller n_controller;
    private int selectCharacter;

    public static GameManager I;

    private void Awake()
    {
        I = this;
        n_controller = GetComponent<NPCcontroller>();
    }

    private void Start()
    {
        playerNameText.text = PlayerPrefs.GetString("Name");
        selectCharacter = PlayerPrefs.GetInt("Index");
        ChangedCharacter(selectCharacter);
    }

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
        if(n_controller.DistanceToCharacter() < 3f && !OnMessage)
        {
            CallBell.SetActive(true);
        }
        else { CallBell.SetActive(false); }
    }

    public void ChangedCharacter(int index)
    {
        MainCharacter.GetComponent<SpriteRenderer>().sprite = characterList[index].CharacterSprite;
        MainCharacter.GetComponent<Animator>().runtimeAnimatorController = characterList[index].controller;
    }


}
