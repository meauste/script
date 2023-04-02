using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecou : MonoBehaviour
{
    public int antenthantei;
    public int titlehantei;
    public Texture2D mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        titlehantei = titlebg.titlehantei;
        antenthantei = ButtonManager.antenthantei;
        if (tpointerenter.tmwxf == 0)
        {
            Cursor.visible = true;
            Cursor.SetCursor(mouse, Vector2.zero, CursorMode.ForceSoftware);
        }
        else
        {
            Cursor.visible = false;
        }
    }
}
