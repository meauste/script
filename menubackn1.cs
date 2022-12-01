using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menubackn1 : MonoBehaviour
{
    public int mwxf;
    public float mwx;
    public int loadpage;
    public int savepage;
    public saveloadc slc;
    public int hazimarif;
    public GameObject Nexttext;
    public GameObject endselect;
    public GameObject ms;
    public void Update()
    {
     
        hazimarif = Bgcontroller.hazimarif;
        if (mwx >= 0 & mwxf >= 1)
        {
            ButtonManager.titlebx = -1;
            Image bgcdb = endselect.GetComponent<Image>();
            bgcdb.GetComponent<Image>().color = new Color(255, 255, 255, mwx);
            mwx -= 0.12f;
            if (mwx < 0)
            {

               Loadco.loadpage = 1;
                saveco.savepage = 1;
                mwxf = 0;
                mwx = 0;
                endselect.SetActive(false);
                Image bgcdben = endselect.GetComponent<Image>();
                bgcdben.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
            }
        }
        if (endselect==true&Input.GetKeyDown(KeyCode.Escape))
        {
            saveloadc.savecf = 1;
            if (saveloadc.savecf == 1)
            {
                endselect.SetActive(false);
                Nexttext.SetActive(false);
                if (hazimarif <= 0)
                {
                    Bgcontroller.mwxf = 1;

                }
                else
                {
                    ms.SetActive(true);
                }
            }
        }
    }
    public void Onclick()
    {
        sound.soundflag = 1;

        saveloadc.savecf = 1;
        configco.csavef = 1;
        if (saveloadc.savecf == 1)
        {
            if (hazimarif <= 0)
            {
                Bgcontroller.mwxf = 1;

            }
            else
            {
                ms.SetActive(true);
            }
            endselect.SetActive(false);
            Nexttext.SetActive(false);
        }

    }
}
