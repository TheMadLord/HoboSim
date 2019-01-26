using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_TrashShop : MonoBehaviour {

    protected bool isopen;
    protected List<GameObject> Enviroment_objs;
    public GameObject anchorPoint;
    public Sprite[] sprites;
    public GameObject menu;
    public int heightRect;

    void Start() {
        int spritesSize = sprites.Length;
        heightRect = (int)(spritesSize / 5 * .12f);
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

    public void toggleMenu() {
        menu.SetActive(!menu.activeSelf);
    }
}
