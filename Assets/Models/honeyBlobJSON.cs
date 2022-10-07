using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class honeyBlobJSON
{
    public honeyBlob[] blobArray;

    public static honeyBlobJSON CreateFromJSON(string jsonString)
    {
        return UnityEngine.JsonUtility.FromJson<honeyBlobJSON>(jsonString);
    }
}
