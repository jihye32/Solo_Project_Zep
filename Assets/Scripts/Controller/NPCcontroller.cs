using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{

    GameManager gameManager;
    Transform MainCharacter;

    [Header("NPC")]
    public GameObject tutor;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.I;
        MainCharacter = gameManager.MainCharacter.transform;
    }

    public float DistanceToCharacter()
    {
        return Vector3.Distance(tutor.transform.position, MainCharacter.position);
    }
}
