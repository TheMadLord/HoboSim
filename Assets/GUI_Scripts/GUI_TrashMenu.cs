using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_TrashMenu : MonoBehaviour {

    protected List<GameObject> Enviroment_objs;
    public GameObject anchorPoint;
    public Sprite[] sprites;

    void Start() {
        int spritesSize = sprites.Length;
        Enviroment_objs = new List<GameObject>();
        int j = 0;
        foreach (Sprite obj in sprites) {
            Enviroment_objs.Add(new GameObject("Image"));
            Enviroment_objs[j].transform.SetParent(anchorPoint.transform);
            Enviroment_objs[j++].AddComponent<Image>().sprite = obj;
        }
    }

	void Update () {
	}
}
