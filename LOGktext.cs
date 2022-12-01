using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGktext : MonoBehaviour
{
    public static int loglflag;
    public static int loglx;
    public static int loglf;
    public static int mwxfl;
    public float mwxl;
    public GameObject LOGkp;
    public GameObject LOGp;
    public GameObject nexttext;
    // Start is called before the first frame update
    void Start()
    {
        LOGkp.SetActive(false);
        loglf = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (mwxl >= 0 & mwxfl ==1)
        {

            Image chra1 = LOGkp.GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 0.2f + mwxl, 0);



            LOGkp.SetActive(true);


            mwxl += 0.2f;

            if (mwxl >= 1f)
            {
                LOGkp.SetActive(true);
                Image chr1 = LOGkp.GetComponent<Image>();
                chr1.transform.localScale = new Vector3(1, 1, 0);
                mwxfl = 0;
                mwxl = 0;

            }

        }

    }
        public void Onclick()
        {
        LOGtext.fki = "";
        sound.soundflag = 4;
        loglflag = 1;
        LOGkp.SetActive(false);
            LOGp.SetActive(false);
            nexttext.SetActive(true);
        if (LOGtext.resm > 0)
        {
            TextManager.text_num = LOGtext.text_rsnum;
        }
        else
        {
            TextManager.text_num = LOGtext.text_snum - loglx;
            saveloadl.loadfl = 1;
        }
        TextManager.antenhantei = 1;
        
        Load.loadflag = 1;
        loglf = 0;
        }
    }

