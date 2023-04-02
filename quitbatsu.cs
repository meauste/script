using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitbatsu : MonoBehaviour
{
    public GameObject quitmenu;
    public float texttime;
    void Update()
    {
        texttime = textt.texttime;
    }
    void OnApplicationQuit()
    {
       
            Application.CancelQuit();
        if (TextManager.antenhantei==0&Bgcontroller.bgcf == 0 & Bgcontroller.bgcdf == 0 & Bgcontroller.chaptf == 0)
        {
            gpointerevent.mwxf = 1;
            gpointerevent.px = 2;
        }
        
    }
}
