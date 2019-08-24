using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextResponsive : MonoBehaviour {
    public float YourWidthRatio;
    public float YourHeightRatio;

    public float YourXRatio;
    public float YourYRatio;
    public float YourZRatio;
    public int YourFontSizeRatio;

    int SWidth = 1080;
    int SHeight = 1920;

    Text t_text;

    // Use this for initialization
    void Start()
    {
        this.YourXRatio = this.transform.localPosition.x * 100 / SWidth;
        this.YourYRatio = this.transform.localPosition.y * 100 / SHeight;
        this.YourZRatio = this.transform.localPosition.z;

        RectTransform rt = (RectTransform)this.transform;
        float X = (Screen.width * YourXRatio) / 100;
        float Y = (Screen.height * YourYRatio) / 100;
        float Z = YourZRatio;

        t_text = GetComponent<Text>();
        double s = (double)Screen.height / 1920;
        double d = s * t_text.fontSize;
        double r = (double)Screen.width / 1080;

        this.YourWidthRatio = rt.rect.width * 100 / 1080;
        this.YourHeightRatio = rt.rect.height * 100 / 1920;

        this.transform.localPosition = new Vector3(X, Y, Z);

        if ((this.transform.parent.GetComponent<Button>() != null)
            || (this.transform.parent.GetComponent<InputField>() != null))
        {
            rt.sizeDelta = new Vector2(0, 0);
        }
        else
        {
            RectTransform rp = (RectTransform)this.transform;
            float W = (float)rp.rect.width * (float)r;
            float H = (float)rp.rect.height * (float)s;
            rt.sizeDelta = new Vector2(W, H);
        }

        Debug.Log("dasdsd: " + this.name);
        t_text.resizeTextForBestFit = false;
        t_text.fontSize = (int)d; 
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
