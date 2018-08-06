using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{

    public event System.Action<Player> OnLocalPlayerJoined;

    private GameObject gameObjectManager;
    private static GameManager m_Instance;

    public static GameManager Instance
    {
        get
        {
            if(m_Instance == null)
            {
                m_Instance = new GameManager();
                m_Instance.gameObjectManager = new GameObject("_gameManager");
                m_Instance.gameObjectManager.AddComponent<InputController>();
            }
            return m_Instance;
        }
    }


    private InputController m_InputController;
    public InputController InputController
    {
        get
        {
            if(m_InputController == null)
            {
                m_InputController = gameObjectManager.GetComponent<InputController>();
            }
            return m_InputController;
        }
    }

    private Player m_localPlayer;
    public Player LocalPlayer
    {
        get
        {
            return m_localPlayer;
        }
        set
        {
            m_localPlayer = value;
            if(m_localPlayer != null)
            {
                OnLocalPlayerJoined(m_localPlayer);
            }
        }
    }

}
