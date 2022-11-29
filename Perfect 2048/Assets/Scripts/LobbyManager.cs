using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyManager : NetworkBehaviour
{

    public GameObject playerScrollContent;
    public Button btnStart;
    public Button btnReady;



    public void Awake()
    {

    }

    public void Start()
    {
        if (IsHost)
        {

            btnStart.onClick.AddListener(HostOnBtnStartClick);
        }

    }
    

    private void HostOnBtnStartClick()
    {
        Debug.Log("Start Game");
    }



}
