using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class Timer : NetworkBehaviour
{
    public NetworkVariable<float> RemainingTime = new NetworkVariable<float>(20f);

    public TMPro.TMP_Text txtTime;

    void Update()
    {
        if (IsHost)
        {
            RemainingTime.Value -= Time.deltaTime;
            txtTime.text = RemainingTime.Value.ToString();
        }

        if (IsClient)
        {
            RemainingTime.OnValueChanged += ClientOnTimeChanged;
        }

    }

    private void ClientOnTimeChanged(float previous, float current)
    {
        txtTime.text = RemainingTime.Value.ToString();
    }

}