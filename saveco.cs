using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class saveco : MonoBehaviour
{
    public static int savepage;
    public static int chapsf;
    public static int s1f;
    public int text_num;
    public string st;
    public int loadpage;
    public int hazimarif;
    public int mwxf;
    public float mwx;
    public DateTime nowtime;
    public saveload sl;
    public GameObject Nexttext;
    public GameObject endselect;
    public GameObject ms;
    public saveloadc slc;
    textti script;
    // Start is called before the first frame update
    void Start()
    {

        savepage = 1;
    }
    public void Update()
    {
        text_num = TextManager.text_num;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            chapsf = 1;
            savepage += 1;
            if (savepage > 500)
            {
                savepage = 1;
            }
            sound.soundflag = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            chapsf = 1;
            savepage -= 1;
            sound.soundflag = 1;
        }
        if (savepage < 1)
        {
            savepage = 500;
        }
        loadpage = Loadco.loadpage;

        hazimarif = Bgcontroller.hazimarif;
        if (mwx >= 0 & mwxf >= 1)
        {

            Image bgcdb = endselect.GetComponent<Image>();
            bgcdb.GetComponent<Image>().color = new Color(255, 255, 255, mwx);
            mwx -= 0.12f;
            if (mwx < 0)
            {

                Loadco.loadpage = 1;
                savepage = 1;
                mwxf = 0;
                mwx = 0;
                endselect.SetActive(false);
                Image bgcdben = endselect.GetComponent<Image>();
                bgcdben.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
            }
        }
    }
    public void TappedButton(string button)
    {

        script = GameObject.Find("textti").GetComponent<textti>();
        switch (button)
        {
            case "smae":
                sound.soundflag = 1;
                chapsf = 1;

                savepage -= 1;
                break;
            case "stsugi":
                chapsf = 1;
                savepage += 1;
                if (savepage > 500)
                {
                    savepage = 1;

                }
                sound.soundflag = 1;
                break;
            case "s10mae":
                chapsf = 1;

                savepage -= 10;
                sound.soundflag = 2;
                break;
            case "s10tsugi":
                chapsf = 1;
                savepage += 10;
                if (savepage > 500)
                {
                    savepage = 1;
                }
                sound.soundflag = 2;
                break;
            case "smin":
                chapsf = 1;
                savepage = 1;
                sound.soundflag = 2;
                break;
            case "smax":
                chapsf = 1;
                savepage = 500;
                sound.soundflag = 2;
                break;
            case "sbn":
                    if (saveload.savef == 0)
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
                    break;
            case "s1":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 1;
                    SaveManager.s1nfl = savepage;
                    saveload.savef = 1;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save1, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save1at, st);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save1text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6 - 5).ToString();
                    sl.Save();
                    sound.soundflag = 2;
                }
                break;
            case "s2":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 2;
                    SaveManager.s2nf = savepage;
                    saveload.savef = 2;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save2a, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save2at, st);
                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save2text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6 - 4).ToString();
                    sl.Save();

                   
                    sound.soundflag = 2;
                }
                break;

            case "s3":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 3;
                    SaveManager.s3nf = savepage;
                    saveload.savef = 3;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save3a, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save3at, st);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save3text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6 - 3).ToString();
                    sl.Save();
                    sound.soundflag = 2;

                }
                break;

            case "s4":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 4;
                    SaveManager.s4nf = savepage;
                    saveload.savef = 4;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save4a, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save4at, st);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save4text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6 - 2).ToString();
                    sl.Save();
                    sound.soundflag = 2;

                }
                break;
            case "s5":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 5;
                    SaveManager.s5nf = savepage;
                    saveload.savef = 5;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save5a, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save5at, st);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save5text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6 - 1).ToString();
                    sl.Save();
                    sound.soundflag = 2;

                }
                break;
            case "s6":
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    textt.s1nf = 6;
                    SaveManager.s6nf = savepage;
                    saveload.savef = 6;
                    text_num = TextManager.text_num;

                    PlayerPrefs.SetInt(SaveManager.save6a, text_num);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save6at, st);

                    PlayerPrefs.Save();
                    PlayerPrefs.SetString(SaveManager.save6text, script.textho[text_num]);

                    PlayerPrefs.Save();
                    saveload.savesname = (savepage * 6).ToString();
                    sl.Save();
                    sound.soundflag = 2;

                }
                break;
            default:
                break;
        }
    }
}
