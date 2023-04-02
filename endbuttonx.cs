using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class endbuttonx : MonoBehaviour
{
    public static int mwxf;
    public float mwx;
    public int antenhantei;
    public int loadflag;
    public static int qbxf;

    public GameObject Panel;
 

    public void Start()
    {
        
    }
    public void Update()
    {
        if (mwx >= 0 & mwxf >= 1 & mwxf < 2)
        {

            Image chra1 = Panel.GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 0.2f + mwx, 0);



            Panel.SetActive(true);


            mwx += 0.2f;

            if (mwx >= 1f)
            {
                Panel.SetActive(true);
                Image chr1 = Panel.GetComponent<Image>();
                chr1.transform.localScale = new Vector3(1, 1, 0);
                mwxf = 0;
                mwx = 0;
                qbxf = 1;

            }
        }
    

    }
}