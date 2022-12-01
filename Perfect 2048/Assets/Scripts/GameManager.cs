using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GameManager : NetworkBehaviour
{
    public NetworkVariable<float> RemainingTime = new NetworkVariable<float>(20f);

    void Update()
    {
        if (IsHost)
        {
            RemainingTime.Value -= Time.deltaTime;
            Debug.Log("Host time changed");
            Debug.Log(RemainingTime.Value);
        }

        if (IsClient)
        {
            RemainingTime.OnValueChanged += ClientOnTimeChanged;
        }

    }

    private void ClientOnTimeChanged(float previous, float current)
    {
        Debug.Log("Client time changed");
        Debug.Log(RemainingTime.Value);
    }

}
