using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin : Buildables
{
    public void Start() {
        DiggingScript.MaxTrash += 50;
    }

    public override void Remove()
    {
        DiggingScript.MaxTrash -= 50;
        DiggingScript.AddTrash(0);
        GameObject.Destroy(gameObject);
    }
}
