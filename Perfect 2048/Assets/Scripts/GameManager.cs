using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GameManager : NetworkBehaviour
{
    public NetworkVariable<float> RemainingTime = new NetworkVariable<float>(20f);

    void Update()
    {
        RemainingTime.Value -= Time.deltaTime;
        Debug.Log(RemainingTime.Value);
    }
    
 
}
