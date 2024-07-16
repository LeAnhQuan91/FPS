using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReferences : MonoBehaviour
{
   
    public GameReferences Instance
    {
        get => instance;
    }
    private static GameReferences instance;

    public GameObject bulletEffectImpactPrefabs;

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
    }
}
