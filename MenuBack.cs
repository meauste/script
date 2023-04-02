using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBack : MonoBehaviour
{
    public int mwxf;
    public float mwx;
    public int loadpage;
    public int savepage;
    public GameObject Nexttext;
    public GameObject endselect;
    public GameObject qm;
    public GameObject ms;
    public void Update()
    {
      
        if (mwx >=0 & mwxf >= 1)
        {

            Image bgcdb = endselect.GetComponent<Image>();
            bgcdb.GetComponent<Image>().color = new Color(255, 255, 255, mwx);
           




            mwx -= 0.12f;
            if (mwx <0)
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
    }
        public void Onclick()
    {
        sound.soundflag = 1;
        if (LOGktext.loglf == 0)
        {
            if (qm == false)
            {
                ms.SetActive(true);


                Nexttext.SetActive(true);
            }
        }
        endselect.SetActive(false);
        LOGktext.loglf = 0;
        
        
    }
}