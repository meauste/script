using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;
using System.IO;

public class gpointerevent : MonoBehaviour
{
    public Text savet;
    public Text loadt;
    public Text qsavet;
    public Text qloadt;
    public Text LOGt;
    public Text autot;
    public Text autokt;
    public Text configt;
    public Text titlet;
    public Text endt;
    public Text whidet;
    public Text warrivet;
    public static int logflag;
    public static int px;
    public static int mwxf;
    public float mwx;
    public int mwahf;
    public static int endgflag;
    public GameObject bti;
    public GameObject savehp;
    public GameObject[] Panel;
    public GameObject LOG;
    public GameObject mw;
    public GameObject Nexttext;
    public GameObject autoon;
    public GameObject autooff;
    public GameObject autogage;
    public GameObject bt;
    public GameObject quit;
    public GameObject quitpanel;
    public GameObject mwa;
    public GameObject mwh;
    public GameObject warrivehy;
    public Text btt;
    public saveload sl;
    public string st;
    public DateTime nowtime;
    textti script;
    dataload script2;
    // Start is called before the first frame update
    void Start()
    {
        mwa.SetActive(false);
        Panel[0].SetActive(false);
        Panel[1].SetActive(false);
        Panel[2].SetActive(false);
        Panel[3].SetActive(false);
        Panel[4].SetActive(false);
        script = GameObject.Find("textti").GetComponent<textti>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TextManager.antenhantei >= 1 | Load.loadflag >= 1 | Bgcontroller.mwxf == 1)
        {
            bt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
            bti.SetActive(false);
        }
        if (anmak.antenflag == 0 | anmak.antenflag > 100|mwa==false)
        {
            for (int ppx = 0; ppx < Panel.Length; ppx++)
            {
                if (ppx <= 2|ppx==7)
                {
                    Image panels = Panel[ppx].GetComponent<Image>();
                    if (script.uignum[2] != null & script.uignum[2] != "") { panels.sprite = script2.uis[script.uignum[2]]; } else { panels.sprite = Resources.Load<Sprite>("UI/panelte"); }
                }
                else if (ppx<=6)
                {
                    Image panell = Panel[ppx].GetComponent<Image>();
                    if (script.uignum[3] != null & script.uignum[3] != "") { panell.sprite = script2.uis[script.uignum[3]]; } else { panell.sprite = Resources.Load<Sprite>("UI/panelte"); }
                }
                else
                {
                    Image panelsen = Panel[ppx].GetComponent<Image>();
                    if (script.uignum[4] != null & script.uignum[4] != "") { panelsen.sprite = script2.uis[script.uignum[4]]; } else { panelsen.sprite = Resources.Load<Sprite>("UI/sentakubar"); }
                }
            }
        }
        //ウィンドウ表示
        if (mwx >= 0 & mwxf ==1)
        {
            Panel[px].SetActive(true);
            Image chra1 = Panel[px].GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 0.2f + mwx, 0);
            mwx += 0.2f;

            if (mwx >= 1f)
            {
                Image chr1 = Panel[px].GetComponent<Image>();
                chr1.transform.localScale = new Vector3(1, 1, 0);
                mwxf = 0;
                mwx = 0;
                px = 0;
            }
        }
        //ウィンドウ表示(LOG)
        if (mwx >= 0 & mwxf == 2)
        {
            Image bgcdb = Panel[px].GetComponent<Image>();
            bgcdb.GetComponent<Image>().color = new Color(255, 255, 255, mwx);
            mwx -= 0.12f;
            if (mwx < 0)
            {
                mwxf = 0;
                mwx = 0;
                px = 0;
                Panel[px].SetActive(true);
                Image bgcdben = Panel[px].GetComponent<Image>();
                bgcdben.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
            }
        }
        //ウィンドウ非表示
        if (mwxf == 0 & Input.GetKeyDown(KeyCode.W))
        {
            if (mwahf >= 0 & Bgcontroller.hazimarif <= 0)
            {
                mwh.SetActive(false);
                mwa.SetActive(true);
                Bgcontroller.mwxf = -1;
                mwahf = -1;
            }
            else
            {
                mwh.SetActive(false);
                mwa.SetActive(true);
                mw.SetActive(false);
            }
        }
        //ウィンドウ表示
        if (mwxf == 0 & Input.GetKeyDown(KeyCode.X))
        {
            if (Bgcontroller.hazimarif <= 0 & mwahf < 0)
            {
                mwh.SetActive(true);
                mwa.SetActive(false);
                Bgcontroller.mwxf = 1;
                mwahf = 1;
            }
            else
            {
                mwh.SetActive(true);
                mwa.SetActive(false);
                mw.SetActive(true);
            }
        }
    }
    public void Point(string e)
    {
        switch (e)
        {
            //選択肢1
            case "sentakushi1":
                sound.soundflag = 6;
                Bgcontroller.sentakuf = 2;
                script.Concat1();
                break;
            case "sentakushi2":
                sound.soundflag = 6;
                Bgcontroller.sentakuf = 3;
                script.Concat2();
                break;
            //セーブ
            case "save":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                savet.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―セーブ―";
                break;
            case "saveh":
                bti.SetActive(false);
                savet.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "saveb":
                sound.soundflag = 1;
                Nexttext.SetActive(false);
                mwxf = 1;
                px = 0;
                bti.SetActive(false);
                break;
            case "savey":
                sound.soundflag = 1;
                SaveManager.mwxfs = 1;
                Image mswy = savehp.GetComponent<Image>();
                mswy.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
                mw.SetActive(false);
                savehp.SetActive(true);
                saveco.chapsf = 1;
                Panel[0].SetActive(false);
                break;
            case "saven":
                Panel[0].SetActive(false);
                break;
            //ロード
            case "load":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                loadt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―ロード―";
                break;
            case "loadh":
                bti.SetActive(false);
                loadt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "loadb":
                sound.soundflag = 1;
                Text texl = loadt.GetComponent<Text>();
                texl.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                Bgcontroller.mwxf = -1;
                Image mswl = Panel[5].GetComponent<Image>();
                mswl.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
                Panel[5].SetActive(true);
                Bgcontroller.mwxf = -1;
                Load.mwxfl = 1;
                bti.SetActive(false);
                Loadco.chapsf = 1;
                break;
            //クイックセーブ
            case "qsave":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                qsavet.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―クイックセーブ―";
                break;
            case "qsaveh":
                bti.SetActive(false);
                qsavet.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "qsaveb":
                sound.soundflag = 2;
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                if (saveload.savef == 0)
                {
                    PlayerPrefs.SetInt("Dataq" + textti.loaddata, TextManager.text_num);
                    PlayerPrefs.Save();
                    PlayerPrefs.SetString("DataqT" + textti.loaddata, st);
                    PlayerPrefs.Save();
                    PlayerPrefs.SetString("DataqTE" + textti.loaddata, script.textho[TextManager.text_num]);
                    PlayerPrefs.Save();
                    saveload.savesname = "quick";
                    sl.Save();

                    TextManager.qsf = 1;
                }
                break;
            //クイックロード
            case "qload":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                qloadt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―クイックロード―";
                break;
            case "qloadh":
                bti.SetActive(false);
                qloadt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "qloadb":
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + "quick.json"))
                {
                    sound.soundflag = 4;
                    saveload.savesname = "quick";
                    sl.Load();
                    TextManager.qlf = 1;
                    TextManager.antenhantei = 1;
                    TextManager.auto = 0;
                    TextManager.autoflag = 0;
                    autoon.SetActive(true);
                    bti.SetActive(false);
                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                else
                {
                    sound.soundflag = 7;
                }
                break;
            //ログ
            case "LOG":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                LOGt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―ログ―";
                break;
            case "LOGh":
                bti.SetActive(false);
                LOGt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "LOGb":
                sound.soundflag = 1;
                if (TextManager.text_num > 0)
                {
                    px = 3;
                    Text tex = LOGt.GetComponent<Text>();
                    tex.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                    bti.SetActive(false);
                    Image mw = Panel[px].GetComponent<Image>();
                    mw.GetComponent<Image>().color = new Color(255, 255, 255, 0);
                    Image msw = Panel[px].GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
                    Panel[px].SetActive(true);
                    Bgcontroller.mwxf = -1;
                    Nexttext.SetActive(true);
                    logflag = 1;
                    LOGtext.mwxfl = 1;
                }
                break;
            case "LOGbm":
                if (LOGktext.loglf == 0)
                {
                    LOGtext.mwxfl = -1;
                }
                break;
            //オート
            case "auto":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                autot.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―オート―";
                break;
            case "autoh":
                bti.SetActive(false);
                autot.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "autob":
                sound.soundflag = 3;
                bt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                TextManager.autoflag = 1;
                Thread.Sleep(100);
                autoon.SetActive(false);
                autooff.SetActive(true);
                bti.SetActive(false);
                break;
            //オート解除
            case "autok":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                autokt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―オート解除―";
                break;
            case "autokh":
                bti.SetActive(false);
                autokt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "autokb":
                sound.soundflag = 1;
                bt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                TextManager.autoflag = 0;
                Thread.Sleep(100);
                autoon.SetActive(true);
                autooff.SetActive(false);
                autogage.SetActive(false);
                bti.SetActive(false);
                break;
            //コンフィグ
            case "config":
                sound.soundflag = 1;
                bt.SetActive(true);
                bti.SetActive(true);
                configt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―メニューを開く―";
                break;
            case "configh":
                bti.SetActive(false);
                configt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "configb":
                sound.soundflag = 1;
                Text texc = configt.GetComponent<Text>();
                texc.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                bti.SetActive(false);
                px = 4;
                Image a = Panel[px].GetComponent<Image>();
                a.GetComponent<Image>().color = new Color(255, 255, 255, 0);
                Panel[px].SetActive(true);
                Bgcontroller.mwxf = -1;
                Nexttext.SetActive(true);
                configmenu.mwxfc = 1;
                configmenu.mwxc = 0;
                break;
            case "configbm":
                if (configco.csavef==0)
                {
                    configco.csavef = 1;
                }
                px = 4;
                Panel[px].SetActive(false);
                Bgcontroller.mwxf = 1;
                break;
            //タイトル
            case "title":
                sound.soundflag = 1;
                bti.SetActive(true);
                bt.SetActive(true);
                titlet.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―タイトルに戻る―";
                break;
            case "titleh":
                bti.SetActive(false);
                bt.SetActive(true);
                titlet.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "titleb":
                sound.soundflag = 1;
                Nexttext.SetActive(false);
                mwxf = 1;
                px = 1;
                bti.SetActive(false);
                break;
            case "titley":
                sound.soundflag = 1;
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                PlayerPrefs.SetInt("Datae" + textti.loaddata, TextManager.text_num);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("DataeT" + textti.loaddata, st);
                PlayerPrefs.Save();
                script = GameObject.Find("textti").GetComponent<textti>();
                PlayerPrefs.SetString("DataeTE" + textti.loaddata, script.textho[TextManager.text_num]);
                PlayerPrefs.Save();
                saveload.savesname = "end";
                sl.Save();
                Bgcontroller.endflag = 1;
                TextManager.antenhantei = 1;
                Panel[1].SetActive(false);
                break;
            case "titlen":
                sound.soundflag = 1;
                mw.SetActive(true);
                Nexttext.SetActive(true);
                Panel[1].SetActive(false);
                break;
            //終了
            case "end":
                sound.soundflag = 1;
                bti.SetActive(true);
                bt.SetActive(true);
                endt.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―ゲームを終了する―";
                break;
            case "endh":
                bti.SetActive(false);
                bt.SetActive(true);
                endt.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "endb":
                sound.soundflag = 1;
                Nexttext.SetActive(false);
                mwxf = 1;
                px = 2;
                bti.SetActive(true);
                break;
            case "endy":
                sound.soundflag = 1;
                nowtime = DateTime.Now;
                st = nowtime.ToString();
                PlayerPrefs.Save();
                PlayerPrefs.SetString("DataeT" + textti.loaddata, st);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Datae" + textti.loaddata, TextManager.text_num);
                PlayerPrefs.Save();
                script = GameObject.Find("textti").GetComponent<textti>();
                PlayerPrefs.SetString("DataeTE" + textti.loaddata, script.textho[TextManager.text_num]);
                PlayerPrefs.Save();
                saveload.savesname = "end";
                sl.Save();
                endgflag = 1;
                TextManager.antenhantei = 1;
                quit.SetActive(false);
                Panel[2].SetActive(false);
                break;
            case "endn":
                Nexttext.SetActive(true);
                Panel[2].SetActive(false);
                break;
            //ウィンドウ非表示
            case "whide":
                sound.soundflag = 1;
                bti.SetActive(true);
                bt.SetActive(true);
                whidet.GetComponent<Text>().color = new Color(128, 128, 0, 255);
                btt.text = "―ウィンドウ非表示―";
                break;
            case "whideh":
                bti.SetActive(false);
                whidet.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                break;
            case "whideb":
                sound.soundflag = 1;
                whidet.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                bti.SetActive(false);
                Thread.Sleep(100);
                mwh.SetActive(false);
                if (mwxf == 0)
                {
                    Bgcontroller.mwxf = -1;
                    mwahf = -1;
                }
                mwa.SetActive(true);
                break;
            //ウィンドウ表示
            case "warrive":
                sound.soundflag = 1;
                bti.SetActive(true);
                bt.SetActive(true);
                warrivehy.SetActive(true);
                btt.text = "―ウィンドウ表示―";
                break;
            case "warriveh":
                bti.SetActive(false);
                warrivehy.SetActive(false);
                break;
            case "warriveb":
                sound.soundflag = 1;
                warrivehy.SetActive(false);
                mwxf = Bgcontroller.mwxf;
                Thread.Sleep(100);
                mwh.SetActive(true);
                if (mwxf == 0)
                {
                    Bgcontroller.mwxf = 1;
                    mwahf = 1;
                }
                mwa.SetActive(false);
                break;
        }
    }
}
