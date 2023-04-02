using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class LOGtext : MonoBehaviour
{
    public int text_num = TextManager.text_num;
    public static int text_snum;
    public int logflag;
    public int loadflag;
    public int antenhantei;
    public int hazimarif;
    public static int mwxfl;
    public float mwxl;
    public int cnx1;
    public int cnx2;
    public int cnx3;
    public int cnx4;
    public int cnx5;
    public Text LOGn1;
    public Text LOGn2;
    public Text LOGn3;
    public Text LOGn4;
    public Text LOGn5;
    public Text LOG;
    public Text LOG2;
    public Text LOG3;
    public Text LOG4;
    public Text LOG5;
    public GameObject re1;
    public GameObject re2;
    public GameObject re3;
    public GameObject re4;
    public GameObject re5;
    public GameObject LOGp;
    public GameObject LOGkp;
    public GameObject nexttext;
    public GameObject ms;
    public Slider LOGgage;
    public string texth1;
    public string texthm1;
    public string texth2;
    public string texthm2;
    public string texth3;
    public string texthm3;
    public string texth4;
    public string texthm4;
    public string texth5;
    public string texthm5;
    public int cnx1m;
    public int cnx2m;
    public int cnx3m;
    public int cnx4m;
    public int cnx5m;
    textti script;
    public string[] kt;
    public InputField fontken;
    public GameObject fontk;
    public string fk;
    public static string fki;

    public int fks;
    public int fkl;
    public string chrk;
    public string[] re;
    public static int text_rnum;
    public static int text_rsnum;
    public string result;
    public int res;
    public int[] rein;
    public int[] rin;
    public static int resm;
    public int rx;
    public static int rflag;
    public static int logrx;
    void Start()
    {
        fk = "";
        re1.SetActive(false);
        re2.SetActive(false);
        re3.SetActive(false);
        re4.SetActive(false);
        re5.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        text_num = TextManager.text_num;
        logflag = gpointerevent.logflag;
        loadflag = Load.loadflag;
        if (gpointerevent.logflag >= 1)
        {

            text_snum = TextManager.text_num;
            LOGgage.minValue = 1;
            LOGgage.value=LOGgage.maxValue = TextManager.text_num;
            fontken.text = "";
            resm = 0;
            nexttext.SetActive(false);
            gpointerevent.logflag = 0;
            if (LOGbutton15.chaptshanteif + 1 <= LOGtext.text_snum)
            {
                LOGbutton15.chaptsf = 1;
            }
        }
        if (text_num >= text_snum)
        {
            script = GameObject.Find("textti").GetComponent<textti>();
            if (resm == 0)
            {
                re1.SetActive(false);
                re2.SetActive(false);
                re3.SetActive(false);
                re4.SetActive(false);
                re5.SetActive(false);
                if (textti.ths >= 1 & text_snum >= 1) { script.name[text_snum - 1] = script.name[text_snum - 1].Replace("#NONE", ""); LOGn1.text = script.name[text_snum - 1]; if (script.textho[text_snum - 1].StartsWith("「") == true) { LOG.text = script.textho[text_snum - 1].Replace("/", "\n　"); } else { LOG.text = script.textho[text_snum - 1].Replace("/", "\n"); } } else { LOGn1.text = ""; LOG.text = ""; }
                if (textti.ths >= 2 & text_snum >= 2) { script.name[text_snum - 2] = script.name[text_snum - 2].Replace("#NONE", ""); LOGn2.text = script.name[text_snum - 2]; if (script.textho[text_snum - 2].StartsWith("「") == true) { LOG2.text = script.textho[text_snum - 2].Replace("/", "\n　"); } else { LOG2.text = script.textho[text_snum - 2].Replace("/", "\n"); } } else { LOGn2.text = ""; LOG2.text = ""; }
                if (textti.ths >= 3 & text_snum >= 3) { script.name[text_snum - 3] = script.name[text_snum - 3].Replace("#NONE", ""); LOGn3.text = script.name[text_snum - 3]; if (script.textho[text_snum - 3].StartsWith("「") == true) { LOG3.text = script.textho[text_snum - 3].Replace("/", "\n　"); } else { LOG3.text = script.textho[text_snum - 3].Replace("/", "\n"); } } else { LOGn3.text = ""; LOG3.text = ""; }
                if (textti.ths >= 4 & text_snum >= 4) { script.name[text_snum - 4] = script.name[text_snum - 4].Replace("#NONE", ""); LOGn4.text = script.name[text_snum - 4]; if (script.textho[text_snum - 4].StartsWith("「") == true) { LOG4.text = script.textho[text_snum - 4].Replace("/", "\n　"); } else { LOG4.text = script.textho[text_snum - 4].Replace("/", "\n"); } } else { LOGn4.text = ""; LOG4.text = ""; }
                if (textti.ths >= 5 & text_snum >= 5) { script.name[text_snum - 5] = script.name[text_snum - 5].Replace("#NONE", ""); LOGn5.text = script.name[text_snum - 5]; if (script.textho[text_snum - 5].StartsWith("「") == true) { LOG5.text = script.textho[text_snum - 5].Replace("/", "\n　"); } else { LOG5.text = script.textho[text_snum - 5].Replace("/", "\n"); } } else { LOGn5.text = ""; LOG5.text = ""; }
            }
            else
            {
                if (fks >= 1 & text_rnum >= 1) { LOGn1.text = re[text_rnum - 1].Substring(re[text_rnum - 1].IndexOf("@") + 1); if (re[text_rnum - 1].Substring(re[text_rnum - 1].IndexOf("@") + 1).StartsWith("「") == true) { LOG.text = re[text_rnum - 1].Substring(re[text_rnum - 1].IndexOf("@") + 1).Replace("/", "\n　"); } else { LOG.text = re[text_rnum - 1].Substring(re[text_rnum - 1].IndexOf("@") + 1).Replace("/", "\n"); } } else { LOGn1.text = ""; LOG.text = ""; }
                if (fks >= 2 & text_rnum >= 2) { LOGn2.text = re[text_rnum - 2].Substring(re[text_rnum - 2].IndexOf("@") + 1); if (re[text_rnum - 2].Substring(re[text_rnum - 2].IndexOf("@") + 1).StartsWith("「") == true) { LOG2.text = re[text_rnum - 2].Substring(re[text_rnum - 2].IndexOf("@") + 1).Replace("/", "\n　"); } else { LOG2.text = re[text_rnum - 2].Substring(re[text_rnum - 2].IndexOf("@") + 1).Replace("/", "\n"); } } else { LOGn2.text = ""; LOG2.text = ""; }
                if (fks >= 3 & text_rnum >= 3) { LOGn3.text = re[text_rnum - 3].Substring(re[text_rnum - 3].IndexOf("@") + 1); if (re[text_rnum - 3].Substring(re[text_rnum - 3].IndexOf("@") + 1).StartsWith("「") == true) { LOG3.text = re[text_rnum - 3].Substring(re[text_rnum - 3].IndexOf("@") + 1).Replace("/", "\n　"); } else { LOG3.text = re[text_rnum - 3].Substring(re[text_rnum - 3].IndexOf("@") + 1).Replace("/", "\n"); } } else { LOGn3.text = ""; LOG3.text = ""; }
                if (fks >= 4 & text_rnum >= 4) { LOGn4.text = re[text_rnum - 4].Substring(re[text_rnum - 4].IndexOf("@") + 1); if (re[text_rnum - 4].Substring(re[text_rnum - 4].IndexOf("@") + 1).StartsWith("「") == true) { LOG4.text = re[text_rnum - 4].Substring(re[text_rnum - 4].IndexOf("@") + 1).Replace("/", "\n　"); } else { LOG4.text = re[text_rnum - 4].Substring(re[text_rnum - 4].IndexOf("@") + 1).Replace("/", "\n"); } } else { LOGn4.text = ""; LOG4.text = ""; }
                if (fks >= 5 & text_rnum >= 5) { LOGn5.text = re[text_rnum - 5].Substring(re[text_rnum -5].IndexOf("@") + 1); if (re[text_rnum - 5].Substring(re[text_rnum -5].IndexOf("@") + 1).StartsWith("「") == true) { LOG5.text = re[text_rnum - 5].Substring(re[text_rnum -5].IndexOf("@") + 1).Replace("/", "\n　"); } else { LOG5.text = re[text_rnum - 5].Substring(re[text_rnum -5].IndexOf("@") + 1).Replace("/", "\n"); } } else { LOGn5.text = ""; LOG5.text = ""; }
            }

        }
        if ((mwxl < 0.9f & mwxfl == 1))
        {



            if (mwxl <= 0.32f)
            {
                Image msw = LOGp.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
            }

            Image mw = LOGp.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);



            mwxl += 0.08f;
            if (mwxl > 0.75f)
            {
                Image mwf = LOGp.GetComponent<Image>();
                mwf.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
                mwxfl = 0;
                mwxl = 0;
            }

        }
        text_num = TextManager.text_num;
        logflag = gpointerevent.logflag;
        loadflag = Load.loadflag;
        if ((mwxl < 0.9f & mwxfl == -1))
        {

            fki = "";

            if (mwxl <= 0.32f)
            {
                Image msw = LOGp.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
            }

            Image mw = LOGp.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);



            mwxl += 0.08f;
            if (mwxl > 0.75f)
            {
                Image mwf = LOGp.GetComponent<Image>();
                mwf.GetComponent<Image>().color = new Color(255, 255, 255, 0);
                Image msw = LOGp.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, 0.5f, 0);
                LOGp.SetActive(false);
                hazimarif = Bgcontroller.hazimarif;
                if (hazimarif <= 0)
                {
                    Bgcontroller.mwxf = 1;
                }
                else
                {
                    ms.SetActive(true);
                    nexttext.SetActive(true);
                }
                mwxfl = 0;
                mwxl = 0;
            }
        }
        LOGgage.value = text_snum;
        if (mwxfl == 0)
        {
            if (resm <= 0 & LOGktext.loglf == 0&text_snum>1 & Input.GetKeyDown(KeyCode.UpArrow))
            {
                sound.soundflag = 1;
                text_snum -= 1;
            }
            if (text_rnum > 5 & Input.GetKeyDown(KeyCode.UpArrow))
            {
                sound.soundflag = 1;
                text_rnum -= 1;
            }
            if (LOGktext.loglf == 0 & (Input.GetKeyDown(KeyCode.DownArrow)))
            {

                if (resm <= 0)
                { if ((text_snum <= text_num))
                    {
                        text_snum += 1;
                        sound.soundflag = 1;
                    }
                }
                else
                {
                    if (resm > 4 & text_rnum < resm)
                    {
                        sound.soundflag = 1;
                        text_rnum += 1;
                    }
                }

            }
            if ((text_snum > text_num))
            {
                sound.soundflag = 2;
                text_snum -= 1;
                mwxfl = -1;

            }
        }
    }
    public void slide()
    {
            text_snum = (int)LOGgage.value;
    }

}

