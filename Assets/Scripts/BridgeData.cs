using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public enum BridgeType
{

}
 [System.Serializable]
public class BridgeData
{
    public BridgeType bridgeType;

    public Vector3 position;

    public Quaternion rotation;
}
