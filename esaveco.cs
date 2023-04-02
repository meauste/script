using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esaveco : MonoBehaviour
{
    public static int jsonflag;
    public static int txtflag;
    public static int useflag;
    public static int sentakujsonf;
    public static int sentakutxtf;
    public static int sentakuusef;
    public static int loadcf;
    public static int esavf;
    public static int senikf;
    public static int senf;
    public GameObject editpanel;
    //UI
    public static int uif;
    public static int uinumber;
    public static int uidelnumber;
    public static int uigcf;
    public GameObject[] ufilep;
    public GameObject[] ufiled;
    public GameObject dragp;
    public Vector3 epp;
    public Vector3 mousep;
    textt script;
    // Start is called before the first frame update
    void Start()
    {
        epp = editpanel.transform.position;
        script = GameObject.Find("textt").GetComponent<textt>();
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 m_position = Input.mousePosition;
            mousep = Camera.main.ScreenToWorldPoint(m_position);
            mousep.z = 0;
        //一つ戻る
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.Z))
        {
            if (edit.editf == 1)
            {
                if (edittext.sif > 0 & edittext.simf - edittext.sif < 999)
                {
                    edittext.sif -= 1;
                    susumu.sinkf = 2;
                }
            }
            else
            {
                if (edittext.dsif > 0 & edittext.dsimf - edittext.dsif < 999)
                {
                    edittext.dsif -= 1;
                    susumuk.dsinkf = 2;
                }
            }
        }
        //一つ進む
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.Y))
        {
            if (edit.editf == 1)
            {
                if (edittext.sif < edittext.simf)
                {
                    edittext.sif += 1;
                    susumu.sinkf = 2;
                }
            }
            else
            {
                if (edittext.dsif < edittext.dsimf)
                {
                    edittext.dsif += 1;
                    susumuk.dsinkf = 2;
                }
            }
        }
        //新規作成
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.N))
        {
            edittext.startf = 1;
            if (edit.editf == 1)
            {
                if (edittext.savef == edittext.simf)
                {
                    edittext.startf = 2;
                }
                else
                {
                    sound.soundflag = 7;
                    tpointerenter.px = 5;
                    tpointerenter.mwxf = 1;
                }
            }
            else
            {
                if (edittext.dsavef == edittext.dsimf)
                {
                    edittext.dstartf = 2;
                }
                else
                {
                    sound.soundflag = 7;
                    tpointerenter.px = 5;
                    tpointerenter.mwxf = 1;
                }
            }
        }
        //セーブ
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.S))
        {
            if (edittext.titletext != "" & edittext.titletext != null)
            {
                edit.jssname = edittext.titletext;
                if (edit.editf == 1)
                {
                    edittext.sf = 1;
                }
                else
                {
                    saveloadk.usf = 1;
                }
            }
            else
            {
                edittext.titleaf = 1;
            }
        }
        //ロード
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.L))
        {
            if (edittext.titletext != "" & edittext.titletext != null)
            {
                if (edittext.savef == edittext.simf)
                {
                    if (edit.editf == 1)
                    {
                        edittext.sf = 3;
                    }
                    else
                    {
                        saveloadk.usf = 2;
                    }
                }
                else
                {
                    loadcf = 1;
                    sound.soundflag = 7;
                    tpointerenter.px = 5;
                    tpointerenter.mwxf = 1;
                }
            }
            else
            {
                edittext.titleaf = 1;
            }
        }
        //テキスト変換
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.L))
        {
            convertt.csf = 1;
        }
        //フォルダを開く
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.F))
        {
            if (edit.editp == 0)
            {
                Application.OpenURL(Application.dataPath + "/SAVEDATA");
            }
            else if (edit.editp == 1 | edit.editp == 3)
            {
                Application.OpenURL(Application.dataPath + "/GAMEDATA/Chr");
            }
            else if (edit.editp == 4)
            {
                Application.OpenURL(Application.dataPath + "/GAMEDATA/Bg");
            }
            else if (edit.editp == 6)
            {
                if (edit.audiof == 0) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGM"); }
                if (edit.audiof == 1) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGMEN"); }
                if (edit.audiof == 2) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGMEF"); }
            }
            else if (edit.editp == 8)
            {
                Application.OpenURL(Application.dataPath + "/GAMEDATA/Video");
            }
            else
            {
                Application.OpenURL(Application.dataPath + "/SAVEDATA");
            }
        }
        //マニュアルを開く
        if (Input.GetKey(KeyCode.LeftControl) & Input.GetKeyDown(KeyCode.M))
        {
            Application.OpenURL("https://drive.google.com/file/d/1eZSb7F97D47-iGhr6yTC-U-VW9AWUG-D/view?usp=sharing");
        }
    }
    public void TappedButton(string button)
    {
        switch (button)
        {
            //データ編集推移
            case "sedit":
                edit.editf = 0;
                edit.editp = 0;
                break;
            case "tedit":
                edit.editf = 1;
                edit.editp = 0;
                break;
            case "dedit":
                edit.editf = 2;
                edit.editp = 10;
                break;
            //個別データ編集
            //セーブロード
            case "data":
                useflag = 0;
                if (edit.editf == 1) { edit.editp = 5; }
                if (edit.editf == 2) { edit.editp = 12; }
                break;
            case "json":
                edit.tsepage = 0;
                if (jsonflag == 0)
                {
                    editpanel.transform.position = epp;
                    jsonflag = 1;
                    txtflag = 0;
                    useflag = 0;

                }
                else
                {
                    jsonflag = 0;
                    txtflag = 0;
                    useflag = 0;
                }
                break;
            case "txt":
                edit.tsepage = 0;
                if (txtflag == 0)
                {
                    editpanel.transform.position = epp;
                    jsonflag = 0;
                    txtflag = 1;
                    useflag = 0;
                }
                else
                {
                    jsonflag = 0;
                    txtflag = 0;
                    useflag = 0;
                }
                break;
            case "use":
                edit.tsepage = 0;
                if (useflag == 0)
                {
                    editpanel.transform.position = epp;
                    jsonflag = 0;
                    txtflag = 0;
                    useflag = 1;
                }
                else
                {
                    jsonflag = 0;
                    txtflag = 0;
                    useflag = 0;
                }
                break;
            case "batsu":
                    jsonflag = 0;
                    txtflag = 0;
                    useflag = 0;
                break;
            case "epd":
                editpanel.transform.position = mousep;
                break;
            case "tse1":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 12 + edit.tsepage * 12) { sentakujsonf = 12; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 12 + edit.tsepage * 12) { sentakutxtf = 12; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=12+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=12;}}
                break;
            case "tse2":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 11 + edit.tsepage * 12) { sentakujsonf = 11; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 11 + edit.tsepage * 12) { sentakutxtf = 11; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=11+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=11;}}
                break;
            case "tse3":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 10 + edit.tsepage * 12) { sentakujsonf = 10; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 10 + edit.tsepage * 12) { sentakutxtf = 10; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=10+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=10;}}
                break;
            case "tse4":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 9 + edit.tsepage * 12) { sentakujsonf = 9; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 9 + edit.tsepage * 12) { sentakutxtf = 9; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=9+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=9;}}
                break;
            case "tse5":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 8 + edit.tsepage * 12) { sentakujsonf = 8; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 8 + edit.tsepage * 12) { sentakutxtf = 8; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=8+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=8;}}
                break;
            case "tse6":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 7 + edit.tsepage * 12) { sentakujsonf = 7; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 7 + edit.tsepage * 12) { sentakutxtf = 7; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=7+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=7;}}
                break;
            case "tse7":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 6 + edit.tsepage * 12) { sentakujsonf = 6; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 6 + edit.tsepage * 12) { sentakutxtf = 6; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=6+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=6;}}
                break;
            case "tse8":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 5 + edit.tsepage * 12) { sentakujsonf = 5; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 5 + edit.tsepage * 12) { sentakutxtf = 5; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=5+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=5;}}
                break;
            case "tse9":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 4 + edit.tsepage * 12) { sentakujsonf = 4; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 4 + edit.tsepage * 12) { sentakutxtf = 4; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=4+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=4;}}
                break;
            case "tse10":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 3 + edit.tsepage * 12) { sentakujsonf = 3; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 3 + edit.tsepage * 12) { sentakutxtf = 3; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=3+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=3;}}
                break;
            case "tse11":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 2 + edit.tsepage * 12) { sentakujsonf = 2; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 2 + edit.tsepage * 12) { sentakutxtf = 2; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=2+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=2;}}
                break;
            case "tse12":
                esavf = 1;
                if (jsonflag==1) { if (edit.jsonnum >= 1 + edit.tsepage * 12) { sentakujsonf = 1; sentakutxtf=0;sentakuusef=0; } } else if (txtflag==1) { if (edit.txtnum >= 1 + edit.tsepage * 12) { sentakutxtf = 1; sentakujsonf=0;sentakuusef=0; } }else{if (edit.jsonnum>=1+edit.tsepage*12){sentakutxtf=0;sentakujsonf=0;sentakuusef=1;}}
                break;
            case "tsepm":
                if (edit.tsepage > 0)
                {
                    edit.tsepage -= 1;
                }
                else
                {
                    edit.tsepage = 0;
                }
                break;
            case "tsept":
                if (edit.tsempage > edit.tsepage)
                {
                    edit.tsepage += 1;
                }
                break;
            case "tc":
                if (edit.ctname != null)
                {
                    convertt.csf = 1;
                }
                break;
            case "ct":
                if (edit.ctname != null)
                {
                    edittext.sif = 0;
                    edittext.simf = edittext.sif;
                    convertt.csf = 2;
                }
                break;
            case "jss":
                if (edit.jssname != null)
                {
                    if (edit.editf == 1)
                    {
                        edittext.sf = 1;
                    }
                }
                if (saveloadk.ujssname != null)
                {
                    if (edit.editf == 2)
                    {
                        saveloadk.usf = 1;
                    }
                }
                break;
            case "jsl":
                if (edit.jssname != null)
                {
                    if (edit.editf == 1)
                    {
                        edittext.sf = 2;
                        edittext.sif = 0;
                        edittext.simf = edittext.sif;
                    }
                }
                if (saveloadk.ujssname != null)
                {
                    if (edit.editf == 2)
                    {
                        saveloadk.usf = 2;
                        edittext.sif = 0;
                        edittext.simf = edittext.sif;
                    }
                }
                break;
            case "uss":
                saveloadk.usf = 3;
                break;
            //全体データ編集
            //選択肢
            case "senup":
                if (edit.sentaku_num > 5)
                {
                    edit.sentaku_num -= 1;
                    edit.sentakut_num -= 2;
                }
                break;
            case "sendown":
                if (edit.sentaku_num < textt.sentakus)
                {
                    edit.sentaku_num += 1;
                    edit.sentakut_num += 2;
                }
                break;
            case "senmin":
                if (edit.sentaku_num > 5)
                {
                    edit.sentaku_num = 5;
                    edit.sentakut_num = 5 * 2;
                }
                break;
            case "senmax":
                edit.sentaku_num = textt.sentakus;
                edit.sentakut_num = textt.sentakus * 2;
                break;
            case "senik":
                esavf = 1;
                senikf = 1;
                break;
            case "senac":
                script.sentakuhantei = new int[5];
                script.sentakutypes = new int[5];
                script.sentakuknum = new string[10];
                script.sentakubnum = new string[10];
                script.sentakudnum = new string[10];
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "sentakuu0":
                if (useflag == 11) { useflag = 0; } else { useflag = 11; }
                break;
            case "sentakuu1":
                if (useflag == 10) { useflag = 0; } else { useflag = 10; }
                break;
            case "sentakuu2":
                if (useflag == 9) { useflag = 0; } else { useflag = 9; }
                break;
            case "sentakuu3":
                if (useflag == 8) { useflag = 0; } else { useflag = 8; }
                break;
            case "sentakuu4":
                if (useflag == 7) { useflag = 0; } else { useflag = 7; }
                break;
            case "sentakuu5":
                if (useflag == 6) { useflag = 0; } else { useflag = 6; }
                break;
            case "sentakuu6":
                if (useflag == 5) { useflag = 0; } else { useflag = 5; }
                break;
            case "sentakuu7":
                if (useflag == 4) { useflag = 0; } else { useflag = 4; }
                break;
            case "sentakuu8":
                if (useflag == 3) { useflag = 0; } else { useflag = 3; }
                break;
            case "sentakuu9":
                if (useflag == 2) { useflag = 0; } else { useflag = 2; }
                break;
            case "sentakuu10":
                if (useflag == 1) { useflag = 0; } else { useflag = 1; }
                break;
            case "stype5":
                if (script.sentakutypes[edit.sentaku_num - 1] < script.sentakusy.Length - 1) { script.sentakutypes[edit.sentaku_num - 1] += 1; } else { script.sentakutypes[edit.sentaku_num - 1] = 0; };
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "stype4":
                if (script.sentakutypes[edit.sentaku_num - 2] < script.sentakusy.Length - 1) { script.sentakutypes[edit.sentaku_num - 2] += 1; } else { script.sentakutypes[edit.sentaku_num - 2] = 0; };
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "stype3":
                if (script.sentakutypes[edit.sentaku_num - 3] < script.sentakusy.Length - 1) { script.sentakutypes[edit.sentaku_num - 3] += 1; } else { script.sentakutypes[edit.sentaku_num - 3] = 0; };
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "stype2":
                if (script.sentakutypes[edit.sentaku_num - 4] < script.sentakusy.Length - 1) { script.sentakutypes[edit.sentaku_num - 4] += 1; } else { script.sentakutypes[edit.sentaku_num - 4] = 0; };
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "stype1":
                if (script.sentakutypes[edit.sentaku_num - 5] < script.sentakusy.Length - 1) { script.sentakutypes[edit.sentaku_num - 5] += 1; } else { script.sentakutypes[edit.sentaku_num - 5] = 0; }
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            //全体データセーブ・ロード
            case "aldata":
                edit.editp = 11;
                break;
            //UI設定
            case "hazimariga":
                edit.uipanelf = 2;
                edit.uippage = 0;
                break;
            case "titlega":
                edit.uipanelf = 0;
                edit.uippage = 0;
                break;
            case "gamega":
                edit.uipanelf = 1;
                edit.uippage = 0;
                break;
            case "uixmigi":
                if (edit.uixpage < dataload.uixmpage) { edit.uixpage += 1; }
                break;
            case "uixhidari":
                if (edit.uixpage > 0) { edit.uixpage -= 1; }
                break;
            case "ui1":
                if (edit.uipanelf == 0) { uinumber = edit.uit_num - 1; } else if (edit.uipanelf==1) { uinumber = edit.uig_num - 1; } else { uinumber = edit.glo_num - 1; }
                break;
            case "ui2":
                if (edit.uipanelf == 0) { uinumber = edit.uit_num; } else if (edit.uipanelf == 1) { uinumber = edit.uig_num; } else { uinumber = edit.glo_num; }
                break;
            case "uidel1":
                uif = 1; uidelnumber = 2;
                break;
            case "uidel2":
                uif = 1; uidelnumber = 1;
                break;
            case "uix10":
                if (dataload.uixnum >= 10 + edit.uixpage * 10) { uif = 1; uigcf = 10 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[9].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix9":
                if (dataload.uixnum >= 9 + edit.uixpage * 10) { uif = 1; uigcf = 9 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[8].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix8":
                if (dataload.uixnum >= 8 + edit.uixpage * 10) { uif = 1; uigcf = 8 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[7].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix7":
                if (dataload.uixnum >= 7 + edit.uixpage * 10) { uif = 1; uigcf = 7 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[6].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix6":
                if (dataload.uixnum >= 6 + edit.uixpage * 10) { uif = 1; uigcf = 6 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[5].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix5":
                if (dataload.uixnum >= 5 + edit.uixpage * 10) { uif = 1; uigcf = 5 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[4].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix4":
                if (dataload.uixnum >= 4 + edit.uixpage * 10) { uif = 1; uigcf = 4 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[3].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix3":
                if (dataload.uixnum >= 3 + edit.uixpage * 10) { uif = 1; uigcf = 3 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[2].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix2":
                if (dataload.uixnum >= 2 + edit.uixpage * 10) { uif = 1; uigcf = 2 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[1].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uix1":
                if (dataload.uixnum >= 1 + edit.uixpage * 10) { uif = 1; uigcf = 1 + edit.uixpage * 10; dragp.transform.position = mousep; dragp.SetActive(true); ufiled[0].transform.position = mousep; } else { uigcf = 0; }
                break;
            case "uixd10":
                ufiled[9].transform.position = ufilep[9].transform.position; dragp.SetActive(false);
                break;
            case "uixd9":
                ufiled[8].transform.position = ufilep[8].transform.position; dragp.SetActive(false);
                break;
            case "uixd8":
                ufiled[7].transform.position = ufilep[7].transform.position; dragp.SetActive(false);
                break;
            case "uixd7":
                ufiled[6].transform.position = ufilep[6].transform.position; dragp.SetActive(false);
                break;
            case "uixd6":
                ufiled[5].transform.position = ufilep[5].transform.position; dragp.SetActive(false);
                break;
            case "uixd5":
                ufiled[4].transform.position = ufilep[4].transform.position; dragp.SetActive(false);
                break;
            case "uixd4":
                ufiled[3].transform.position = ufilep[3].transform.position; dragp.SetActive(false);
                break;
            case "uixd3":
                ufiled[2].transform.position = ufilep[2].transform.position; dragp.SetActive(false);
                break;
            case "uixd2":
                ufiled[1].transform.position = ufilep[1].transform.position; dragp.SetActive(false);
                break;
            case "uixd1":
                ufiled[0].transform.position = ufilep[0].transform.position; dragp.SetActive(false);
                break;
            case "umigi":
                edit.uippage += 1;
                break;
            case "uhidari":
                edit.uippage -= 1;
                break;
            case "uhu":
                if (edit.uipanelf == 2)
                {
                    System.Array.Resize(ref script.gamelogohantei, textt.gamelogos + 1);
                    textt.gamelogos++;
                    edit.glo_num = 0;
                    edittext.dsif += 1;
                    edittext.dsimf = edittext.dsif;
                    susumuk.dsinkf = 1;
                }
                break;
            case "uhe":
                if (edit.uipanelf == 2)
                {
                    if (textt.gamelogos > 2)
                    {
                        System.Array.Resize(ref script.gamelogohantei, textt.gamelogos - 1);
                        textt.gamelogos--;
                        edit.glo_num = 0;
                        edittext.dsif += 1;
                        edittext.dsimf = edittext.dsif;
                        susumuk.dsinkf = 1;
                    }
                }
                break;
            case "uup":
                if (edit.uipanelf == 0) { if (edit.uit_num > 2) { edit.uit_num -= 1; } } else if (edit.uipanelf == 1) { if (edit.uig_num > 2) { edit.uig_num -= 1; } }else { if (edit.glo_num > 2) { edit.glo_num -= 1; } }
                break;
            case "udown":
                if (edit.uipanelf == 0) { if (edit.uit_num <textt.uits) { edit.uit_num += 1; } } else if (edit.uipanelf == 1) { if (edit.uig_num <textt.uigs) { edit.uig_num += 1; } }else { if (edit.glo_num < textt.gamelogos) { edit.glo_num += 1; } }
                break;
            case "umin":
                if (edit.uipanelf == 0) { edit.uit_num =2;  } else if (edit.uipanelf == 1) {  edit.uig_num =2; } else { edit.glo_num = 2; }
                break;
            case "umax":
                if (edit.uipanelf == 0) { edit.uit_num = textt.uits; } else if (edit.uipanelf == 1) { edit.uig_num = textt.uigs; } else { edit.glo_num = textt.gamelogos; }
                break;
            //全体設定
            case "aledit":
                edit.editp = 13;
                break;
            case "alpc1":
                if (script.aehantei[0] == 0) { script.aehantei[0] = 1; } else { script.aehantei[0] = 0; }
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "alpc2":
                if (script.aehantei[1] == 0) { script.aehantei[1] = 1; } else { script.aehantei[1] = 0; }
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            case "alpc3":
                if (script.aehantei[2] == 0) { script.aehantei[2] = 1; } else { script.aehantei[2] = 0; }
                edittext.dsif += 1;
                edittext.dsimf = edittext.dsif;
                susumuk.dsinkf = 1;
                break;
            //コマンド
            case "new":
                edittext.startf = 1;
                if (edit.editf == 1)
                {
                    if (edittext.savef == edittext.simf)
                    {
                        edittext.startf = 2;
                    }
                    else
                    {
                        sound.soundflag = 7;
                        tpointerenter.px = 5;
                        tpointerenter.mwxf = 1;
                    }
                }
                else
                {
                    if (edittext.dsavef == edittext.dsimf)
                    {
                        edittext.dstartf = 2;
                    }
                    else
                    {
                        sound.soundflag = 7;
                        tpointerenter.px = 5;
                        tpointerenter.mwxf = 1;
                    }
                }
                break;
            case "load":
                if (edittext.titletext != "" & edittext.titletext != null)
                {
                    if (edit.editf == 1)
                    {
                        if (edittext.savef == edittext.simf)
                        {
                            edittext.sf = 3;
                        }
                        else
                        {
                            loadcf = 1;
                            sound.soundflag = 7;
                            tpointerenter.px = 5;
                            tpointerenter.mwxf = 1;
                        }
                    }
                    else
                    {
                        if (edittext.dsavef == edittext.dsimf)
                        {
                            saveloadk.usf = 2;
                        }
                        else
                        {
                            loadcf = 1;
                            sound.soundflag = 7;
                            tpointerenter.px = 5;
                            tpointerenter.mwxf = 1;
                        }
                    }
                }
                else
                {
                    edittext.titleaf = 1;
                }
                break;
            case "convert":
                convertt.csf = 1;
                break;
            case "modoru":
                if (edit.editf == 1)
                {
                    if (edittext.sif > 0 & edittext.simf - edittext.sif < 999)
                    {
                        edittext.sif -= 1;
                        susumu.sinkf = 2;
                    }
                }
                else
                {
                    if (edittext.dsif > 0 & edittext.dsimf - edittext.dsif < 999)
                    {
                        edittext.dsif -= 1;
                        susumuk.dsinkf = 2;
                    }
                }
                break;
            case "susumu":
                if (edit.editf == 1)
                {
                    if (edittext.sif < edittext.simf)
                    {
                        edittext.sif += 1;
                        susumu.sinkf = 2;
                    }
                }
                else
                {
                    if (edittext.dsif < edittext.dsimf)
                    {
                        edittext.dsif += 1;
                        susumuk.dsinkf = 2;
                    }
                }
                break;
            case "usave":
                if (edittext.titletext != ""& edittext.titletext != null)
                {
                    edit.jssname = edittext.titletext;
                    if (edit.editf == 1)
                    {
                        edittext.sf = 1;
                    }
                    else
                    {
                        saveloadk.usf = 1;
                    }
                }
                else
                {
                    edittext.titleaf = 1;
                }
                break;
            case "openf":
                if (edit.editp == 0)
                {
                    Application.OpenURL(Application.dataPath + "/SAVEDATA");
                }
                else if (edit.editp == 1 | edit.editp == 3)
                {
                    Application.OpenURL(Application.dataPath + "/GAMEDATA/Chr");
                }
                else if (edit.editp == 4)
                {
                    Application.OpenURL(Application.dataPath + "/GAMEDATA/Bg");
                }
                else if (edit.editp == 6)
                {
                    if (edit.audiof == 0) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGM"); }
                    if (edit.audiof == 1) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGMEN"); }
                    if (edit.audiof == 2) { Application.OpenURL(Application.dataPath + "/GAMEDATA/Music/BGMEF"); }
                }
                else if (edit.editp == 8)
                {
                    Application.OpenURL(Application.dataPath + "/GAMEDATA/Video");
                }
                else
                {
                    Application.OpenURL(Application.dataPath+"/SAVEDATA");
                }
                break;
            case "manual":
                Application.OpenURL("https://drive.google.com/file/d/1eZSb7F97D47-iGhr6yTC-U-VW9AWUG-D/view?usp=sharing");
                break;
            default:
                break;
        }
    }
}
