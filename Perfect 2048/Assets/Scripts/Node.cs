using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class Node : NetworkBehaviour
{

    public Vector2 Pos => transform.position;

    public Block OccupiedBlock;
}