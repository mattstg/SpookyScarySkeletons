using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow 
{
    #region Singleton
    public static GameFlow Instance
    {
        get
        {
            if (instance == null)
                instance = new GameFlow();
            return instance;
        }
    }

    private static GameFlow instance;

    private GameFlow() { }
    #endregion

    public void Initialize()
    {
        EnemyManager.Instance.Initialize();
        NPCManager.Instance.Initialize();
        PlayerManager.Instance.Initialize();

    }

    public void PostInitialize()
    {
        EnemyManager.Instance.PostInitialize();
        NPCManager.Instance.PostInitialize();
        PlayerManager.Instance.PostInitialize();

    }

    public void Refresh()
    {
        EnemyManager.Instance.Refresh();
        NPCManager.Instance.Refresh();
        PlayerManager.Instance.Refresh();

    }

    public void PhysicsRefresh()
    {
        EnemyManager.Instance.PhysicsRefresh();
        NPCManager.Instance.PhysicsRefresh();
        PlayerManager.Instance.PhysicsRefresh();

    }
}
