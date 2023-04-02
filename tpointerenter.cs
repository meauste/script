using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class tpointerenter : MonoBehaviour
{
    public static int px;
    public static int tmwxf;
    public static int tloadf;
    public static int mwxf;
    public static float mwx;
    public static int endtflag;
    public static int endf;
    public GameObject cpanel;
    public GameObject quitha;
    public GameObject[] Panel;
    public Text cptext;
    public Vector3 cpv;
    textt script;
    dataload script2;
    // Start is called before the first frame update
    void Start()
    {
        endf = 0;
        tloadf = 0;
        Panel[0].SetActive(false);
        Panel[1].SetActive(false);
        Panel[2].SetActive(false);
        Panel[3].SetActive(false);
        Panel[4].SetActive(false);
        Panel[5].SetActive(false);
        cpv=cpanel.transform.position;
        cpanel.SetActive(false);
        script = GameObject.Find("textt").GetComponent<textt>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonManager.gamelogohantei==0)
        {
            for (int ppx = 0; ppx < Panel.Length; ppx++)
            {
                if (ppx >=3)
                {
                    Image panels = Panel[ppx].GetComponent<Image>();
                    if (script.uitnum[2] != null & script.uitnum[2] != "") { panels.sprite = script2.uis[script.uitnum[2]]; } else { panels.sprite = Resources.Load<Sprite>("UI/panelte"); }
                }
                else if (ppx<2)
                {
                    Image panell = Panel[ppx].GetComponent<Image>();
                    if (script.uitnum[3] != null & script.uitnum[3] != "") { panell.sprite = script2.uis[script.uitnum[3]]; } else { panell.sprite = Resources.Load<Sprite>("UI/panelte"); }
                }
            }
        }
        if (mwx >= 0 & mwxf ==2)
        {
            ButtonManager.titlebx = -1;
            Image bgcdb = Panel[px].GetComponent<Image>();
            bgcdb.GetComponent<Image>().color = new Color(255, 255, 255, 1 - mwx);
            mwx += 0.12f;
            if (mwx > 0.75f)
            {
                mwxf = 0;
                mwx = 0;
                Panel[px].SetActive(false);
                Image bgcdben = Panel[px].GetComponent<Image>();
                bgcdben.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
                if (px == 2) { if (edit.editf == 1) { edit.editp = 0; } else { edit.editp = 10; } }
            }
        }
        if (mwx >= 0 & mwxf ==1)
        {

            Image chra1 = Panel[px].GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 0.2f + mwx, 0);
            Panel[px].SetActive(true);
            mwx += 0.2f;
            if (mwx >= 1f)
            {
                Panel[px].SetActive(true);
                Image chr1 = Panel[px].GetComponent<Image>();
                chr1.transform.localScale = new Vector3(1, 1, 0);
                mwxf = 0;
                mwx = 0;
            }
        }
    }
    public void Point(string e)
    {
        switch (e)
        {
            //タイトル画面
            case "newgame":
                if (ButtonManager.titlebx != 1 & ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    ButtonManager.titlebx = 1;
                }
                break;
            case "newgameb":
                if (endf <= 0 & tloadf <= 0 & ButtonManager.jsons > 0 & textti.loaddata != "" & textti.loaddata != null&File.Exists(Application.dataPath + "/SAVEDATA/json/whole/" + textti.loaddata + ".json")==true & ButtonManager.gamelogohantei == 0)
                {
                    TextManager.text_num = 0;
                    sound.soundflag = 6;
                    ButtonManager.antenthantei = 1;
                    tmwxf = 1;
                }
                else
                {
                    sound.soundflag = 7;
                    px = 4;
                    mwxf = 1;
                }
                break;
            case "continue":
                if (ButtonManager.titlebx != 2 & ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    ButtonManager.titlebx = 2;
                }
                break;
            case "continueb":
                if (endf <= 0 & tloadf <= 0 & textti.loaddata != "" & textti.loaddata != null & ButtonManager.gamelogohantei == 0)
                {
                    Image msw = Panel[0].GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
                    tload1.mwxftl = 1;
                    Panel[0].SetActive(true);
                    sound.soundflag = 6;
                    tloadf = 1;
                }
                else
                {
                    sound.soundflag = 7;
                    px = 4;
                    mwxf = 1;
                }
                break;
            case "continuebm":
                px = 0;
                tloadf = 0;
                mwxf = 2;
                break;
            case "config":
                if (ButtonManager.titlebx != 3 & ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    ButtonManager.titlebx = 3;
                }
                break;
            case "configb":
                if (ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 6;
                    Panel[1].SetActive(true);
                }
                break;
            case "configbm":
                px = 1;
                if (configco.csavef == 0)
                {
                    configco.csavef = 1;
                }
                mwxf = 2;
                break;
            case "edit":
                if (ButtonManager.titlebx != 4 & ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    ButtonManager.titlebx = 4;
                }
                break;
            case "editb":
                if (ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 6;
                    edit.editf = 0;
                    edittext.startf = 2;
                    Panel[2].SetActive(true);
                }
                break;
            case "editbm":
                if (edittext.savef == edittext.simf)
                {
                    px = 2;
                    tloadf = 0;
                    mwxf = 2;
                }
                else
                {
                    sound.soundflag = 7;
                    px = 5;
                    mwxf = 1;
                }
                break;
            case "editcy":
                if (edittext.startf == 1)
                {
                    Panel[5].SetActive(false);
                    edittext.sif = 0;
                    edittext.simf = edittext.sif;
                    edittext.savef = 0;
                    if (edit.editf == 1)
                    {
                        edittext.startf = 2;
                    }
                    else
                    {
                        edittext.dstartf = 2;
                    }
                }
                else if (esaveco.loadcf == 1)
                {
                    if (edit.editf == 1)
                    {
                        Panel[5].SetActive(false);
                        edittext.sif = 0;
                        edittext.simf = edittext.sif;
                        esaveco.loadcf = 0;
                        edittext.savef = 0;
                        edittext.sf = 3;
                    }
                    else
                    {
                        Panel[5].SetActive(false);
                        edittext.dsif = 0;
                        edittext.dsimf = edittext.dsif;
                        esaveco.loadcf = 0;
                        edittext.dsavef = 0;
                        saveloadk.usf = 2;
                    }
                }
                else
                {
                    Panel[5].SetActive(false);
                    px = 2;
                    tloadf = 0;
                    mwxf = 2;
                }
                break;
            case "editcn":
                if (edittext.startf == 1)
                {
                    edittext.startf = 0;
                    edittext.dstartf = 0;
                }
                if (esaveco.loadcf==1)
                {
                    esaveco.loadcf = 0;
                }
                    px = 5;
                    mwxf = 2;

                break;
            case "end":
                if (ButtonManager.titlebx != 5& ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    ButtonManager.titlebx = 5;
                }
                break;
            case "endb":
                if (endf <= 0 & tloadf <= 0 & ButtonManager.gamelogohantei == 0)
                {
                    sound.soundflag = 5;
                    px = 3;
                    mwxf = 1;
                    endf = 1;
                }
                break;
            case "endy":
                sound.soundflag = 1;
                endtflag = 1;
                ButtonManager.antenthantei = 1;
                quitha.SetActive(false);
                Panel[3].SetActive(false);
                break;
            case "endn":
                endf = 0;
                Panel[3].SetActive(false);
                ButtonManager.titlebx = -1;
                break;
            case "thanasu":
                if (endf <= 0 & tloadf <= 0)
                {
                    ButtonManager.titlebx = -1;
                }
                break;
            case "sncautionb":
                Panel[4].SetActive(false);
                ButtonManager.titlebx = -1;
                break;
            //編集コマンド
            case "new":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(0, 0, 0);
                cptext.text = "新規作成";
                break;
            case "save":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(0.5f, 0, 0);
                cptext.text = "セーブ";
                break;
            case "load":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(1, 0, 0);
                cptext.text = "ロード";
                break;
            case "convert":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(1.5f, 0, 0);
                cptext.text = "txt変換";
                break;
            case "folder":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(2, 0, 0);
                cptext.text = "フォルダを開く";
                break;
            case "modoru":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(0, -0.4f, 0);
                cptext.text = "一つ戻る";
                break;
            case "susumu":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(0.5f, -0.4f, 0);
                cptext.text = "一つ進む";
                break;
            case "delete":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(1, -0.4f, 0);
                cptext.text = "削除モード";
                break;
            case "manual":
                cpanel.SetActive(true);
                cpanel.transform.position = cpv;
                cpanel.transform.Translate(1.5f, -0.4f, 0);
                cptext.text = "マニュアルを開く";
                break;
            case "hanasu":
                cptext.text = "";
                cpanel.SetActive(false);
                break;
        }
    }
}
