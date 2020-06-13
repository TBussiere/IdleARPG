using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class UIContainer : MonoBehaviour
{
    public RectTransform rectTransform;
    public GameObject prefabUI;
    private UISeparator uISeparator1;
    private UISeparator uISeparator2;
    // Start is called before the first frame update
    void Start()
    {
        float size = this.GetComponentInParent<GraphicRaycaster>().GetComponent<RectTransform>().rect.height;
        Debug.Log(size);
        rectTransform.sizeDelta = new Vector2(0, size * 0.375f);
        rectTransform.anchoredPosition = new Vector2(0, (size * 0.375f) / 2);
    }

}
