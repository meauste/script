using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quittbatsu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject quitmenu;
    public bool qh;
    void OnApplicationQuit()
    {
        qh = quitmenu.activeSelf;
        Application.CancelQuit();
        if (tpointerenter.tmwxf==0)
        {
            tpointerenter.mwxf = 1;
            tpointerenter.px = 3;
            tpointerenter.endf = 1;
        }
    }
}
