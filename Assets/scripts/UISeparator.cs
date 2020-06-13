using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class UISeparator : MonoBehaviour
{
    public int nbperso;
    public int id;
    public RectTransform parentobjct;

    // Start is called before the first frame update
    void Start()
    {
        float tailleParent = parentobjct.rect.width;

        float posX = tailleParent / nbperso * (id + 1);

        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(posX, 0);
    }
}
