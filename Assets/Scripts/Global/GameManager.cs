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
    public Text timeText;
    public Text playerNameText;

    public GameObject MainCharacter;
    
    private Character character = new Character();
    public List<Character> characterList = new List<Character>();
    int selectCharacter;

    private void Start()
    {
        playerNameText.text = PlayerPrefs.GetString("Name");
        selectCharacter = PlayerPrefs.GetInt("Index");
        ChangedCharacter();
    }

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    private void ChangedCharacter()
    {
        MainCharacter.GetComponent<SpriteRenderer>().sprite = characterList[selectCharacter].CharacterSprite;
        MainCharacter.GetComponent<Animator>().runtimeAnimatorController = characterList[selectCharacter].controller;
    }
}
