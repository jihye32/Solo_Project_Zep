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

    [Header("Change")]
    public InputField ChangeName;

    [Header("Player")]
    public Text playerNameText;
    public GameObject MainCharacter;
    public List<Character> characterList = new List<Character>();


    private int selectCharacter;

    public static GameManager I;

    private void Awake()
    {
        I = this;
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
    }

    public void ChangedCharacter(int index)
    {
        MainCharacter.GetComponent<SpriteRenderer>().sprite = characterList[index].CharacterSprite;
        MainCharacter.GetComponent<Animator>().runtimeAnimatorController = characterList[index].controller;
    }
}
