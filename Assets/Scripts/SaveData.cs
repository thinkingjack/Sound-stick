using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SaveData : MonoBehaviour
{
    public static SaveData current;

    public List<BridgeData> bridge;
}
