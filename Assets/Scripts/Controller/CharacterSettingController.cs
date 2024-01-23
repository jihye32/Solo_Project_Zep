using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Penguin, Wizzard
}

[Serializable]
public class Character
{
    public CharacterType characterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController controller;
}

public class CharacterSettingController : MonoBehaviour
{
    [SerializeField] GameObject selectCharacter;
    protected void SetName(string name)
    {
        PlayerPrefs.SetString("Name", name);
    }

    protected void SetIndex(int index)
    {
        PlayerPrefs.SetInt("Index", index);
    }
}
