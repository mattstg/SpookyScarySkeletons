using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLinks : MonoBehaviour
{
    private static WorldLinks instance;
    public static WorldLinks Instance { get { return instance ?? (instance = GameObject.FindObjectOfType<WorldLinks>()); } }

    public Transform playerStartLocation;
}
