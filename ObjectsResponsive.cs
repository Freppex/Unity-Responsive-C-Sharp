using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ObjectsResponsive : MonoBehaviour {
    public float YourWidthRatio;
    public float YourHeightRatio;
    public float YourXRatio;
    public float YourYRatio;
    public float YourZRatio;

    int SWidth = 1080;
    int SHeight = 1920;

    // Use this for initialization
    void Start()
    {
        RectTransform rt2 = (RectTransform)this.transform;
        this.YourWidthRatio = rt2.rect.width * 100 / SWidth;
        this.YourHeightRatio = rt2.rect.height * 100 / SHeight;

        this.YourXRatio = this.transform.localPosition.x * 100 / SWidth;
        this.YourYRatio = this.transform.localPosition.y * 100 / SHeight;
        this.YourZRatio = this.transform.localPosition.z;


        RectTransform rt = (RectTransform)this.transform;
        float X = (Screen.width * YourXRatio) / 100;
        float Y = (Screen.height * YourYRatio) / 100;
        float Z = YourZRatio;
        this.transform.localPosition = new Vector3(X, Y, Z);

        float W = Screen.width * YourWidthRatio / 100;
        float H = Screen.height * YourHeightRatio / 100;
        rt.sizeDelta = new Vector2(W, H);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
