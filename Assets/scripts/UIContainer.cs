using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class UIContainer : MonoBehaviour
{
    public RectTransform rectTransform;
    public GameObject prefabUI;
    public int nbperso;
    private UISeparator uISeparator1;
    private UISeparator uISeparator2;
    // Start is called before the first frame update
    void Start()
    {
        float heightSize = this.GetComponentInParent<GraphicRaycaster>().GetComponent<RectTransform>().rect.height;
        float widthSize = this.GetComponentInParent<GraphicRaycaster>().GetComponent<RectTransform>().rect.width;

        Debug.Log(heightSize);
        rectTransform.sizeDelta = new Vector2(0, heightSize * 0.375f);
        rectTransform.anchoredPosition = new Vector2(0, (heightSize * 0.375f) / 2);

        for (int i = -2; i < nbperso-2; i++)
        {
            RectTransform go = Instantiate(prefabUI, new Vector3(0, 0, 0), Quaternion.identity, this.transform).GetComponent<RectTransform>();

            go.sizeDelta = new Vector2(widthSize / nbperso, 0);
            go.anchoredPosition = new Vector2(widthSize / nbperso * i, 0);
        }
        
    }

}
