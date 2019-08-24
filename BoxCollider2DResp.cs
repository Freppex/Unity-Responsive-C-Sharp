using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollider2DResp : MonoBehaviour {

    public float Width;
    public float Height;
    public BoxCollider2D bc2D;

	// Use this for initialization
	void Start () {
        float widthScript = GetComponent<ObjectsResponsive>().YourWidthRatio;
        float heightScript = GetComponent<ObjectsResponsive>().YourHeightRatio;

        bc2D = GetComponent<BoxCollider2D>();
        bc2D.size = new Vector2((Screen.width * widthScript / 100) * Width / 100,(Screen.height * heightScript / 100) * Height / 100);
        Debug.Log(this.name + " - " + widthScript);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
