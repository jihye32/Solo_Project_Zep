using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{

    GameManager gameManager;
    Transform MainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.I;
        MainCharacter = gameManager.MainCharacter.transform;
    }

    public float DistanceToCharacter(GameObject gameObject)
    {
        return Vector3.Distance(gameObject.transform.position, MainCharacter.position);
    }
}
