using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using UnityEngine.UI;

public class edit : MonoBehaviour
{
    public static int editf;
    public Text edittitle;
    public GameObject ecpanel;
    public GameObject editspanel;
    public GameObject teditpanel;
    public GameObject deditpanel;
    public static int editp;
    public InputField texte;
    //編集項目テキスト
    public Text[] editt;
    //テキスト表
    public GameObject text;
    //テキストマネージャー
    public GameObject textpage1;
    public GameObject textpage2;
    public Text editpanelt;
    public GameObject migi;
    public GameObject hidari;
    public GameObject txt;
    public GameObject editpanel;
    public GameObject editpanelm;
    public Text edittext;
    public Text editmtext;
    public Text editpaneltm;
    public InputField texttxt;
    public InputField cnatxt;
    public InputField Bgtxt;
    public InputField chrrtxt;
    public Text texteb;
    public static int textflag;
    public int tx;
    public static int tnum;
    public static int edit_tnum;
    public static int sepage;
    public static int trf;
    public static int largef;
    public static int tcflag;
    public static int tcoflag;
    public static int thflag;
    //カラー・キャラ
    public Text chara1;
    public Text chara2;
    public Text chara3;
    public Text chara4;
    public Text chara5;
    public Text colora1;
    public Text colora2;
    public Text colora3;
    public Text colora4;
    public Text colora5;
    public Text tcolora1;
    public Text tcolora2;
    public Text tcolora3;
    public Text tcolora4;
    public Text tcolora5;
    public Text tocolora1;
    public Text tocolora2;
    public Text tocolora3;
    public Text tocolora4;
    public Text tocolora5;
    public Text ocolora1;
    public Text ocolora2;
    public Text ocolora3;
    public Text ocolora4;
    public Text ocolora5;
    public Text sentaku1;
    public Text sentaku2;
    public Text sentaku3;
    public Text sentaku4;
    public Text sentaku5;
    public Text sentaku6;
    public Text sentaku7;
    public Text sentaku8;
    public Text sentaku9;
    public Text sentaku10;
    public Text sentaku11;
    public Text sentaku12;
    public Text sepp;
    public GameObject co;
    public GameObject tco;
    public GameObject sem;
    public GameObject set;
    public static int sempage;
    //テキスト
    public GameObject texthp1;
    public GameObject texthp2;
    public GameObject texthp3;
    public GameObject texthp4;
    public GameObject texthp5;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public GameObject textis;
    public InputField texti1;
    public InputField texti2;
    public InputField texti3;
    public InputField texti4;
    public InputField texti5;
    public GameObject texths;
    public string texth1;
    public string texth2;
    public string texth3;
    public string texth4;
    public string texth5;
    public string[] textnys;
    public static string textny1;
    public static string textny2;
    public static string textny3;
    public static string textny4;
    public static string textny5;
    public static int tenum;
    public int kf;
    //キャラエディット
    public GameObject chr;
    public GameObject chrpage1;
    public GameObject chrpage2;
    public GameObject cmigi;
    public GameObject chidari;
    //ページ1
    public static int chrpage;
    public static int num;
    public static int edit_num;
    public InputField myoji1;
    public InputField myoji2;
    public InputField myoji3;
    public InputField myoji4;
    public InputField myoji5;
    public InputField name1;
    public InputField name2;
    public InputField name3;
    public InputField name4;
    public InputField name5;
    public InputField tag1;
    public InputField tag2;
    public InputField tag3;
    public InputField tag4;
    public InputField tag5;
    public InputField bikou1;
    public InputField bikou2;
    public InputField bikou3;
    public InputField bikou4;
    public InputField bikou5;
    public static string names1;
    public static string names2;
    public static string names3;
    public static string names4;
    public static string names5;
    public static string tags1;
    public static string tags2;
    public static string tags3;
    public static string tags4;
    public static string tags5;
    public static int name1l;
    public static int name2l;
    public static int name3l;
    public static int name4l;
    public static int name5l;
    public static int tag1l;
    public static int tag2l;
    public static int tag3l;
    public static int tag4l;
    public static int tag5l;
    public static int tf;
    public static string rtext1;
    public static string rtext2;
    public static string rtext3;
    public static string rtext4;
    public static string rtext5;
    public static string rtext1p;
    public static string rtext2p;
    public static string rtext3p;
    public static string rtext4p;
    public static string rtext5p;
    public string[] myojis;
    public string[] names;
    public string[] tags;
    public string[] bikous;
    public Text chr1y;
    public Text chr2y;
    public Text chr3y;
    public Text chr4y;
    public Text chr5y;
    public Text chr1;
    public Text chr2;
    public Text chr3;
    public Text chr4;
    public Text chr5;
    public Text seibetsu1;
    public Text seibetsu2;
    public Text seibetsu3;
    public Text seibetsu4;
    public Text seibetsu5;
    public Text hyoji1;
    public Text hyoji2;
    public Text hyoji3;
    public Text hyoji4;
    public Text hyoji5;
    public Text hyojimn1;
    public Text hyojimn2;
    public Text hyojimn3;
    public Text hyojimn4;
    public Text hyojimn5;
    public string[] sename = { "男", "女" };
    public string[] mn = { "名前", "苗字" };
    public int cn1;
    public int cn2;
    public int cn3;
    public int cn4;
    public int cn5;
    public int cn1l;
    public int cn2l;
    public int cn3l;
    public int cn4l;
    public int cn5l;
    //ページ2
    public int[] cnums;
    public int chx;
    public string cfilePath;
    public string[] cpicnam;
    public static int cexnum;
    public string[] cfilenam;
    public int cfilenum;
    public static int cpicnum;
    public static int cpic_num;
    public int cex_num;
    public GameObject animeedit;
    public GameObject cpicex;
    public GameObject cfileex;
    public Text chrnum1;
    public Text chrnum2;
    public Text chrnum3;
    public Text chrnum4;
    public Text chrnum5;
    public Text cname1;
    public Text cname2;
    public Text cname3;
    public Text cname4;
    public Text cname5;
    public Text cpicname1;
    public Text cpicname2;
    public Text cpicname3;
    public Text cpicname4;
    public Text cpicname5;
    public string[] cpics;
    public InputField cpicny1;
    public InputField cpicny2;
    public InputField cpicny3;
    public InputField cpicny4;
    public InputField cpicny5;
    public GameObject cpicup;
    public GameObject cpicdown;
    public static int cexapage;
    public static int cexmpage;
    public static int cpicnumber;
    public GameObject cexahidari;
    public GameObject cexamigi;
    public Text cexapt;
    public GameObject[] cpic;
    public GameObject[] cpicd;
    public Image cpic1;
    public Image cpic2;
    public Image cpic3;
    public Image cpic4;
    public Image cpic5;
    public Image cex1;
    public Image cex2;
    public Image cex3;
    public Image cex4;
    public Image cex5;
    public Image cex6;
    public Image cex7;
    public Image cex8;
    public Image cex9;
    public Image cex10;
    public Text cani;
    public Text cpict;
    public string test;
    //カラーパネル
    public int[] conum;
    public int cox;
    public GameObject color;
    public string[] ctags;
    public string[] cnames;
    public static int cnum;
    public static int edit_cnum;
    public Text colnum1;
    public Text colnum2;
    public Text colnum3;
    public Text colnum4;
    public Text colnum5;
    public Text colortag1;
    public Text colortag2;
    public Text colortag3;
    public Text colortag4;
    public Text colortag5;
    public Text colorname1;
    public Text colorname2;
    public Text colorname3;
    public Text colorname4;
    public Text colorname5;
    public Text ocolorname1;
    public Text ocolorname2;
    public Text ocolorname3;
    public Text ocolorname4;
    public Text ocolorname5;
    public Text csample1;
    public Text csample2;
    public Text csample3;
    public Text csample4;
    public Text csample5;
    public InputField ctag1;
    public InputField ctag2;
    public InputField ctag3;
    public InputField ctag4;
    public InputField ctag5;
    public InputField colortext;
    public string ctagt1;
    public string ctagt2;
    public string ctagt3;
    public string ctagt4;
    public string ctagt5;
    public static string colort;
    public Color colcolor;
    public static int cppage;
    public Image colorpanel;
    public Image colorpanel1;
    public Image colorpanel2;
    public Image colorpanel3;
    public Image colorpanel4;
    public Image colorpanel5;
    public Image colorpanel6;
    public Image colorpanel7;
    public Image colorpanel8;
    public Image colorpanel9;
    public Image colorpanel10;
    public Image colorpanel11;
    public Image colorpanel12;
    public Image colorpanel13;
    public Image colorpanel14;
    public Image colorpanel15;
    //ページ4
    public Text[]chreptype;
    public static int cexpage;
    public static int cetpage;
    public Text cexpt;
    public GameObject chre;
    public GameObject cexhidari;
    public GameObject cexmigi;
    public Image cex1m;
    public Image cex2m;
    public Image cex3m;
    public Image cex4m;
    public Image cex5m;
    public Image cex6m;
    public Image cex7m;
    public Image cex8m;
    public Image cex9m;
    public Image cex10m;
    public Image cexd1m;
    public Image cexd2m;
    public Image cexd3m;
    public Image cexd4m;
    public Image cexd5m;
    public Image cexd6m;
    public Image cexd7m;
    public Image cexd8m;
    public Image cexd9m;
    public Image cexd10m;
    public static int ceventf;
    public string[] chrevents;
    public GameObject cevents;
    public GameObject ceevents;
    public InputField[] ceventx;
    public InputField[] ceventwx;
    public GameObject cebh;
    public Text chrenum1;
    public Text chrenum2;
    public Text chrenum3;
    public Text chrenum4;
    public Text chrenum5;
    public Text chretype1;
    public Text chretype2;
    public Text chretype3;
    public Text chretype4;
    public Text chretype5;
    public Text ctype1;
    public Text ctype2;
    public Text ctype3;
    public Text ctype4;
    public Text ctype5;
    //chrc
    public static int chrc_num;
    public static int chrcg_num;
    public int cc;
    public GameObject chrc;
    public Image chrcpic1;
    public Image chrcpic2;
    public Image chrcpic3;
    public Image chrcpic4;
    public Image chrcpic5;
    public Sprite[] chrcpics;
    //chrcd
    public static int chrcd_num;
    public static int chrcdg_num;
    public int ccd;
    public GameObject chrcd;
    public Image chrcdpic1;
    public Image chrcdpic2;
    public Image chrcdpic3;
    public Image chrcdpic4;
    public Image chrcdpic5;
    public Image chrcdpic6;
    public Image chrcdpic7;
    public Image chrcdpic8;
    public Image chrcdpic9;
    public Image chrcdpic10;
    //unaz
    public static int unaz_num;
    //odoroki
    public static int odoroki_num;
    //daru
    public static int daru_num;
    //ページ5
    public static int bexpage;
    public static int bgef;
    public Text bexpt;
    public GameObject bge;
    public GameObject bexhidari;
    public GameObject bexmigi;
    public static int betpage;
    public Text[] bgeptype;
    public Image bex1m;
    public Image bex2m;
    public Image bex3m;
    public Image bex4m;
    public Image bex5m;
    public Image bex6m;
    public Image bex7m;
    public Image bex8m;
    public Image bex9m;
    public Image bexd1m;
    public Image bexd2m;
    public Image bexd3m;
    public Image bexd4m;
    public Image bexd5m;
    public Image bexd6m;
    public Image bexd7m;
    public Image bexd8m;
    public Image bexd9m;
    public static int beventf;
    public string[] bgevents;
    public InputField beventx1;
    public InputField beventx2;
    public InputField beventx3;
    public InputField beventx4;
    public InputField beventx5;
    public InputField[] beventwx;
    public GameObject bebh;
    public GameObject bedbh;
    public GameObject eventpos;
    public GameObject eeventpos;
    public Text bgenum1;
    public Text bgenum2;
    public Text bgenum3;
    public Text bgenum4;
    public Text bgenum5;
    public Text bgetype1;
    public Text bgetype2;
    public Text bgetype3;
    public Text bgetype4;
    public Text bgetype5;
    public Text btype1;
    public Text btype2;
    public Text btype3;
    public Text btype4;
    public Text btype5;
    //bgc
    public static int bgc_num;
    public int c;
    public GameObject bgc;
    public Image bgcpic1;
    public Image bgcpic2;
    public Image bgcpic3;
    public Image bgcpic4;
    public Image bgcpic5;
    public Sprite[] bgcpics;
    //bgcd
    public static int bgcd_num;
    public static int bgcdg_num;
    public int cd;
    public GameObject bgcd;
    public Image bgcdpic1;
    public Image bgcdpic2;
    public Image bgcdpic3;
    public Image bgcdpic4;
    public Image bgcdpic5;
    public Image bgcdpic6;
    public Image bgcdpic7;
    public Image bgcdpic8;
    public Image bgcdpic9;
    public Image bgcdpic10;
    //chap
    public GameObject chap;
    public static int chap_num;
    public int ch;
    public Text chapan1;
    public Text chapan2;
    public Text chapan3;
    public Text chapan4;
    public Text chapan5;
    //chapt
    public static int chapt_num;
    public static int chaptg_num;
    public int ct;
    //kakudai
    public GameObject kakudai;
    public static int kakudai_num;
    public int k;
    public Text ktype1;
    public Text ktype2;
    public Text ktype3;
    public Text ktype4;
    public Text ktype5;
    //bgsw
    public GameObject bgw;
    public static int bgsw_num;
    //bglw
    public static int bglw_num;
    //bge
    public static int bge_num;
    //serious
    public static int serious_num;
    //hazimari
    public GameObject hazimari;
    public static int hazimari_num;
    //ページ7
    public GameObject audiopanel;
    public string bgmPath;
    public string bgmePath;
    public string bgmefPath;
    public string[] bgmname;
    public string[] bgmename;
    public string[] bgmefname;
    public static int asepage;
    public static int asempage;
    public Text asept;
    public GameObject aubh;
    public static int bgmnum;
    public static int bgmenum;
    public static int bgmefnum;
    public static int audiof;
    public Text asentaku1;
    public Text asentaku2;
    public Text asentaku3;
    public Text asentaku4;
    public Text asentaku5;
    public Text asentaku6;
    public Text asentaku7;
    public Text asentaku8;
    public Text asentaku9;
    public Text asentaku10;
    public Text asentaku11;
    public Text asentaku12;
    public Text asedntaku1;
    public Text asedntaku2;
    public Text asedntaku3;
    public Text asedntaku4;
    public Text asedntaku5;
    public Text asedntaku6;
    public Text asedntaku7;
    public Text asedntaku8;
    public Text asedntaku9;
    public Text asedntaku10;
    public Text asedntaku11;
    public Text asedntaku12;
    public Image[] audioplay;
    public GameObject asemigi;
    public GameObject asehidari;
    public static int audiopf;
    public static int audioph;
    public static int audiosf;
    public AudioSource audioe;
    public InputField audiox1;
    public InputField audiox2;
    public InputField audiox3;
    public InputField audiox4;
    public InputField audiox5;
    public Text audionum1;
    public Text audionum2;
    public Text audionum3;
    public Text audionum4;
    public Text audionum5;
    public Text audiotype1;
    public Text audiotype2;
    public Text audiotype3;
    public Text audiotype4;
    public Text audiotype5;
    public Text audiotx1;
    public Text audiotx2;
    public Text audiotx3;
    public Text audiotx4;
    public Text audiotx5;
    public string[] audios;
    public static int bgm_num;
    public static int bgme_num;
    public static int bgmef_num;
    //ページ8
    public int vx;
    public GameObject videopanel;
    public GameObject videonpanel;
    public GameObject vibh;
    public Text videoont;
    public string videoPath;
    public string[] videoname;
    public static int vsepage;
    public static int vsempage;
    public Text vsept;
    public static int videonum;
    public static float videof;
    public static int videopf;
    public static int videosf;
    public static int videoph;
    public VideoPlayer video;
    public Text vsentaku1;
    public Text vsentaku2;
    public Text vsentaku3;
    public Text vsentaku4;
    public Text vsentaku5;
    public Text vsentaku6;
    public Text vsentaku7;
    public Text vsentaku8;
    public Text vsentaku9;
    public Text vsentaku10;
    public Text vsentaku11;
    public Text vsentaku12;
    public Text vsedntaku1;
    public Text vsedntaku2;
    public Text vsedntaku3;
    public Text vsedntaku4;
    public Text vsedntaku5;
    public Text vsedntaku6;
    public Text vsedntaku7;
    public Text vsedntaku8;
    public Text vsedntaku9;
    public Text vsedntaku10;
    public Text vsedntaku11;
    public Text vsedntaku12;
    public GameObject vsemigi;
    public GameObject vsehidari;
    public Image videoplay;
    public InputField videox1;
    public InputField videox2;
    public InputField videox3;
    public InputField videox4;
    public InputField videox5;
    public Text videonum1;
    public Text videonum2;
    public Text videonum3;
    public Text videonum4;
    public Text videonum5;
    public Text videotype1;
    public Text videotype2;
    public Text videotype3;
    public Text videotype4;
    public Text videotype5;
    public Text videotx1;
    public Text videotx2;
    public Text videotx3;
    public Text videotx4;
    public Text videotx5;
    public string[] videos;
    public static int video_num;
    //ページ9
    public GameObject ui;
    //ページ10
    public GameObject sentaku;
    public GameObject sentaku0;
    public Text sentaku0t;
    public static int sentaku_num;
    public static int sentakut_num;
    public string[] sentakuknum;
    public Text[] sentakunum;
    public Text[] sentakutype;
    public GameObject[] n;
    public GameObject[] nd;
    public Text[] stype;
    public string[] sentakuts;
    public InputField[] sentakub;
    public string[] sentakubs;
    public Text[] sentakud;
    public string[] sentakuds;
    //ページ6
    public string jsonPath;
    public string txtPath;
    public string[] jsonname;
    public string[] txtname;
    public static int jsonnum;
    public static int txtnum;
    public InputField ctny;
    public InputField jssny;
    public static string ctname;
    public static string jssname;
    public GameObject filepanel;
    public Text tsentaku1;
    public Text tsentaku2;
    public Text tsentaku3;
    public Text tsentaku4;
    public Text tsentaku5;
    public Text tsentaku6;
    public Text tsentaku7;
    public Text tsentaku8;
    public Text tsentaku9;
    public Text tsentaku10;
    public Text tsentaku11;
    public Text tsentaku12;
    public Text tsepp;
    public GameObject tsem;
    public GameObject tset;
    public static int tsepage;
    public static int tsempage;
    public Text tpanelt;
    public static int cf;
    public int firstf;
    public GameObject data;
    public GameObject gsfms;
    public int m;
    public int me;
    public int mef;
    //全体データセーブ・ロード
    public GameObject aldata;
    public Text austx;
    public InputField ajssny;
    //全体設定
    public GameObject aleditp;
    public Image[] aep;
    //UI設定
    public Image[] uix;
    public Image[] uixd;
    public Text[] uinum;
    public Text[] uitype;
    public Text[] uiptype;
    public Text[] uitx;
    public Image[] uitpic;
    public Image[] uigpic;
    public Image uikpic;
    public Text uixpt;
    public GameObject uixmigi;
    public GameObject uixhidari;
    public static int uixpage;
    public GameObject uipmigi;
    public GameObject uiphidari;
    public static int uippage;
    public static int uitpage;
    public static int uigpage;
    public Text uipt;
    public GameObject[] uip;
    public static int uipanelf;
    public static int glo_num;
    public static int uit_num;
    public static int uig_num;
    public GameObject uibh;
    //背景
    textt script;
    dataload script2;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("textt").GetComponent<textt>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();
        firstf = 1;
        color.SetActive(false);
        chr.SetActive(false);
        txt.SetActive(false);
        chre.SetActive(false);
        bge.SetActive(false);
        ecpanel.SetActive(false);
        audiopanel.SetActive(false);
        videopanel.SetActive(false);
        data.SetActive(false);
        editpanel.SetActive(false);
        editpanelm.SetActive(false);
        teditpanel.SetActive(false);
        deditpanel.SetActive(false);
        filepanel.SetActive(false);
        textco.chflag = 0;
        textco.coflag = 0;
        esaveco.useflag = 0;
        esaveco.jsonflag = 0;
        esaveco.txtflag =0;
        ceventf = 0;
        beventf = 0;
        bgc_num = 0;
        bgcd_num = 0;
        chap_num = 0;
        chapt_num = 0;
        kakudai_num = 0;
        bgsw_num = 0;
        bglw_num = 0;
        bge_num = 0;
        serious_num = 0;
        hazimari_num = 0;
        chrc_num = 0;
        chrcd_num = 0;
        chrcdg_num = 0;
        unaz_num = 0;
        odoroki_num = 0;
        daru_num = 0;
        bgm_num =0;
        bgme_num =0;
        bgmef_num = 0;
        video_num = 0;
        editf = 0;
        editp = 0;
        textt.dataload = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //選択画面
        if (editf == 0)
        {
            editspanel.SetActive(true);
            edittitle.text = "―エディットモード―";
        }
        else
        {
            editspanel.SetActive(false);
        }
        //ロード
        if (num == 0)
        {
            num = script.chrna.Length;
            edit_num = num;
            myojis = new string[num];
            names = new string[num];
            tags = new string[num];
            bikous = new string[num];
        }
        if (cnum == 0)
        {
            cnum = script.colorna.Length;
            edit_cnum = cnum;
            cnames = new string[cnum];
            ctags = new string[cnum];
        }
        if (tnum == 0)
        {
            tnum = script.chrtext.Length;
            edit_tnum = script.chrtext.Length;
            System.Array.Resize(ref script.text, script.chrtext.Length);
            textnys = new string[tnum];
        }
        if (tnum > 0)
        {
            for (tx = 0; tx < tnum; tx++)
            {
                if (script.text[tx] == null | script.text[tx] == string.Empty)
                {
                    script.text[tx] = "#NONE TEXT";
                }
                if (script.chrtext[tx] == null | script.chrtext[tx] == string.Empty)
                {
                    script.chrtext[tx] = "#NONE";
                }
                if (script.textcolor[tx] == null | script.textcolor[tx] == string.Empty)
                {
                    script.textcolor[tx] = "$COLOR";
                    script.textocolor[tx] = "ffffff";
                }
                if (script.color[tx] == null | script.color[tx] == string.Empty | script.textcolor[tx] == "$COLOR")
                {
                    script.color[tx] = "ffffff";
                }
                if (script.ocolor[tx] == null | script.ocolor[tx] == string.Empty | script.ocolor[tx] == "$COLOR")
                {
                    script.ocolor[tx] = "ffffff";
                }
                if (script.texth[tx] == null | script.texth[tx] == string.Empty)
                {
                    script.texth[tx] = "TEXT";
                }
                int tlx = script.text[tx].Length;
                if (script.text[tx].Contains("\n") == false)
                {
                    script.text[tx] = script.text[tx].Insert(tlx, "\n");
                }
                int tnx = tx + 1;
                script.text[tx] = script.text[tx].Replace("NUM", string.Empty + tnx);
            }
            if (tx >= tnum)
            {
                textt.dataload = 1;
                if (firstf > 0)
                {
                    firstf = 0;
                    susumu.sinkf = 1;
                    susumuk.dsinkf = 1;
                }
                tx = 0;
            }
        }
        for (cc = 0; cc < textt.chrcs; cc++)
        {
            if (script.chrchantei[cc] == 0)
            {
                script.chrchantei[cc] = 99999;
            }
            if (script.chrcnum[cc] == string.Empty | script.chrcnum[cc] == null)
            {
                script.ceventsyl[cc] = 2;
            }
        }
        for (int unaz = 0; unaz < textt.unazs; unaz++)
        {
            if (script.unazhantei[unaz] == 0)
            {
                script.unazhantei[unaz] = 99999;
            }
        }
        for (int odoroki = 0; odoroki < textt.odorokis; odoroki++)
        {
            if (script.odorokihantei[odoroki] == 0)
            {
                script.odorokihantei[odoroki] = 99999;
            }
        }
        for (int daru = 0; daru < textt.darus; daru++)
        {
            if (script.daruhantei[daru] == 0)
            {
                script.daruhantei[daru] = 99999;
            }
        }
        for (c = 0; c < textt.bgcs; c++)
        {
            if (script.bgchantei[c] == 0)
            {
                script.bgchantei[c] = 99999;
            }
        }
        for (cd = 0; cd < textt.bgcds; cd++)
        {
            if (script.bgcdhantei[cd] == 0)
            {
                script.bgcdhantei[cd] = 99999;
            }
            script.bgcdg[cd] = 2;
        }
        for (ch = 0; ch < textt.chaps; ch++)
        {
            if (script.chaphantei[ch] == 0)
            {
                script.chaphantei[ch] = 99999;
            }
            if (script.chaphantei[ch] == 99999)
            {
                script.chaptypes[ch] = 3;
            }
            else
            {
                if(script.chaptypes[ch] ==3)
                {
                    script.chaptypes[ch] = 0;
                }
            }
        }
        for (ct = 0; ct < textt.chapts; ct++)
        {
            if (script.chapthantei[ct] == 0)
            {
                script.chapthantei[ct] = 99999;
            }
        }
        for (int k = 0; k < textt.kakudais; k++)
        {
            if (script.kakudaihantei[k] == 0)
            {
                script.kakudaihantei[k] = 99999;
            }
            if (script.kakudaihantei[k] == 99999)
            {
                script.kakudaitypes[k] = 5;
            }
            else
            {
                if (script.kakudaitypes[k] == 5)
                {
                    script.kakudaitypes[k] = 0;
                }
            }
        }
        for (int sw = 0; sw < textt.bgsws; sw++)
        {
            if (script.bgswhantei[sw] == 0)
            {
                script.bgswhantei[sw] = 99999;
            }
        }
        for (int lw = 0; lw < textt.bglws; lw++)
        {
            if (script.bglwhantei[lw] == 0)
            {
                script.bglwhantei[lw] = 99999;
            }
        }
        for (int e = 0; e < textt.bges; e++)
        {
            if (script.bgehantei[e] == 0)
            {
                script.bgehantei[e] = 99999;
            }
        }
        for (int se = 0; se < textt.seriouss; se++)
        {
            if (script.serioushantei[se] == 0)
            {
                script.serioushantei[se] = 99999;
            }
        }
        for (int ha = 0; ha < textt.hazimaris; ha++)
        {
            if (script.hazimarihantei[ha] == 0)
            {
                script.hazimarihantei[ha] = 99999;
            }
        }
        for (m = 0; m < textt.bgms; m++)
        {
            if (script.bgmhantei[m] == 0)
            {
                script.bgmhantei[m] = 99999;
            }
        }
        for (me = 0; me < textt.bgmes; me++)
        {
            if (script.bgmehantei[me] == 0)
            {
                script.bgmehantei[me] = 99999;
            }
        }
        for (mef = 0; mef < textt.bgmefs; mef++)
        {
            if (script.bgmefhantei[mef] == 0)
            {
                script.bgmefhantei[mef] = 99999;
            }
        }
        for (vx = 0; vx < textt.videos; vx++)
        {
            if (script.videohantei[vx] == 0)
            {
                script.videohantei[vx] = 99999;
            }
        }
        if (editf==0)
        {
            ecpanel.SetActive(false);
        }
        else
        {
            ecpanel.SetActive(true);
        }
        //ロード終了
        if (editp != 5 & editp != 10)
        {
            filepanel.SetActive(false);
        }
        for (int etx = 0; etx < 14; etx++)
        {
            if (etx == editp)
            {
                editt[etx].color = new Color(255, 255, 0, 1);
            }
            else
            {
                editt[etx].color = new Color(255, 255, 255, 1);
            }
                    
        }
        //個別データ編集
        if (editf == 1)
        {
            edittitle.text = "ー個別データ編集―";
            teditpanel.SetActive(true);
            //テキストマネージャー
            if (editp == 0)
            {
                text.SetActive(true);
                texteb.text = textt.textall;
                txt.SetActive(true);
                textpage1.SetActive(true);
                if (tcflag == 0)
                {
                    if (edit_tnum >= 1) { chara1.text = script.chrtext[edit_tnum - 1]; }
                    if (edit_tnum >= 2) { chara2.text = script.chrtext[edit_tnum - 2]; }
                    if (edit_tnum >= 3) { chara3.text = script.chrtext[edit_tnum - 3]; }
                    if (edit_tnum >= 4) { chara4.text = script.chrtext[edit_tnum - 4]; }
                    if (edit_tnum >= 5) { chara5.text = script.chrtext[edit_tnum - 5]; }
                }
                else
                {
                    if (edit_tnum >= 1) { chara1.text = script.name[edit_tnum - 1]; }
                    if (edit_tnum >= 2) { chara2.text = script.name[edit_tnum - 2]; }
                    if (edit_tnum >= 3) { chara3.text = script.name[edit_tnum - 3]; }
                    if (edit_tnum >= 4) { chara4.text = script.name[edit_tnum - 4]; }
                    if (edit_tnum >= 5) { chara5.text = script.name[edit_tnum - 5]; }
                }
                if (tcoflag == 0)
                {
                    tco.SetActive(false);
                    co.SetActive(true);
                    colora1.text = script.textcolor[edit_tnum - 1];
                    colora2.text = script.textcolor[edit_tnum - 2];
                    colora3.text = script.textcolor[edit_tnum - 3];
                    colora4.text = script.textcolor[edit_tnum - 4];
                    colora5.text = script.textcolor[edit_tnum - 5];
                }
                else
                {
                    co.SetActive(false);
                    tco.SetActive(true);
                    tcolora1.text = script.ocolor[edit_tnum - 1];
                    tcolora2.text = script.ocolor[edit_tnum - 2];
                    tcolora3.text = script.ocolor[edit_tnum - 3];
                    tcolora4.text = script.ocolor[edit_tnum - 4];
                    tcolora5.text = script.ocolor[edit_tnum - 5];
                    tocolora1.text = script.color[edit_tnum - 1];
                    tocolora2.text = script.color[edit_tnum - 2];
                    tocolora3.text = script.color[edit_tnum - 3];
                    tocolora4.text = script.color[edit_tnum - 4];
                    tocolora5.text = script.color[edit_tnum - 5];
                }
                if (textco.chflag == 1)
                {
                    if (largef == 0)
                    {
                        textco.sentakucof = 0;
                        editpanel.SetActive(true);
                        editpanelm.SetActive(false);
                        num = script.partna.Length;
                        sempage = (num - 1) / 12 + 1;
                        if (sepage < 1)
                        {
                            sem.SetActive(false);
                        }
                        else
                        {
                            sem.SetActive(true);
                        }
                        if (sepage + 2 > sempage)
                        {
                            set.SetActive(false);
                        }
                        else
                        {
                            set.SetActive(true);
                        }
                        sepp.text = sepage + 1 + "/" + sempage;
                        editpanelt.text = "キャラクター";
                        if (tcflag == 0)
                        {
                            if (num > 11 + sepage * 12) { if (script.partna[11] != null & script.partna[11] != string.Empty) { sentaku12.text = script.partna[11 + sepage * 12]; } else { sentaku12.text = "NONE"; } } else { sentaku12.text = "NONE"; }
                            if (num > 10 + sepage * 12) { if (script.partna[10] != null & script.partna[10] != string.Empty) { sentaku11.text = script.partna[10 + sepage * 12]; } else { sentaku11.text = "NONE"; } } else { sentaku11.text = "NONE"; }
                            if (num > 9 + sepage * 12) { if (script.partna[9] != null & script.partna[9] != string.Empty) { sentaku10.text = script.partna[9 + sepage * 12]; } else { sentaku10.text = "NONE"; } } else { sentaku10.text = "NONE"; }
                            if (num > 8 + sepage * 12) { if (script.partna[8] != null & script.partna[8] != string.Empty) { sentaku9.text = script.partna[8 + sepage * 12]; } else { sentaku9.text = "NONE"; } } else { sentaku9.text = "NONE"; }
                            if (num > 7 + sepage * 12) { if (script.partna[7] != null & script.partna[7] != string.Empty) { sentaku8.text = script.partna[7 + sepage * 12]; } else { sentaku8.text = "NONE"; } } else { sentaku8.text = "NONE"; }
                            if (num > 6 + sepage * 12) { if (script.partna[6] != null & script.partna[6] != string.Empty) { sentaku7.text = script.partna[6 + sepage * 12]; } else { sentaku7.text = "NONE"; } } else { sentaku7.text = "NONE"; }
                            if (num > 5 + sepage * 12) { if (script.partna[5] != null & script.partna[5] != string.Empty) { sentaku6.text = script.partna[5 + sepage * 12]; } else { sentaku6.text = "NONE"; } } else { sentaku6.text = "NONE"; }
                            if (num > 4 + sepage * 12) { if (script.partna[4] != null & script.partna[4] != string.Empty) { sentaku5.text = script.partna[4 + sepage * 12]; } else { sentaku5.text = "NONE"; } } else { sentaku5.text = "NONE"; }
                            if (num > 3 + sepage * 12) { if (script.partna[3] != null & script.partna[3] != string.Empty) { sentaku4.text = script.partna[3 + sepage * 12]; } else { sentaku4.text = "NONE"; } } else { sentaku4.text = "NONE"; }
                            if (num > 2 + sepage * 12) { if (script.partna[2] != null & script.partna[2] != string.Empty) { sentaku3.text = script.partna[2 + sepage * 12]; } else { sentaku3.text = "NONE"; } } else { sentaku3.text = "NONE"; }
                            if (num > 1 + sepage * 12) { if (script.partna[1] != null & script.partna[1] != string.Empty) { sentaku2.text = script.partna[1 + sepage * 12]; } else { sentaku2.text = "NONE"; } } else { sentaku2.text = "NONE"; }
                            if (num > 0 + sepage * 12) { if (script.partna[0] != null & script.partna[0] != string.Empty) { sentaku1.text = script.partna[0 + sepage * 12]; } else { sentaku1.text = "NONE"; } } else { sentaku1.text = "NONE"; }
                        }
                        else
                        {
                            if (num > 11 + sepage * 12) { if (script.chrna[11] != null & script.chrna[11] != string.Empty) { sentaku12.text = script.chrna[11 + sepage * 12]; } else { sentaku12.text = "NONE"; } } else { sentaku12.text = "NONE"; }
                            if (num > 10 + sepage * 12) { if (script.chrna[10] != null & script.chrna[10] != string.Empty) { sentaku11.text = script.chrna[10 + sepage * 12]; } else { sentaku11.text = "NONE"; } } else { sentaku11.text = "NONE"; }
                            if (num > 9 + sepage * 12) { if (script.chrna[9] != null & script.chrna[9] != string.Empty) { sentaku10.text = script.chrna[9 + sepage * 12]; } else { sentaku10.text = "NONE"; } } else { sentaku10.text = "NONE"; }
                            if (num > 8 + sepage * 12) { if (script.chrna[8] != null & script.chrna[8] != string.Empty) { sentaku9.text = script.chrna[8 + sepage * 12]; } else { sentaku9.text = "NONE"; } } else { sentaku9.text = "NONE"; }
                            if (num > 7 + sepage * 12) { if (script.chrna[7] != null & script.chrna[7] != string.Empty) { sentaku8.text = script.chrna[7 + sepage * 12]; } else { sentaku8.text = "NONE"; } } else { sentaku8.text = "NONE"; }
                            if (num > 6 + sepage * 12) { if (script.chrna[6] != null & script.chrna[6] != string.Empty) { sentaku7.text = script.chrna[6 + sepage * 12]; } else { sentaku7.text = "NONE"; } } else { sentaku7.text = "NONE"; }
                            if (num > 5 + sepage * 12) { if (script.chrna[5] != null & script.chrna[5] != string.Empty) { sentaku6.text = script.chrna[5 + sepage * 12]; } else { sentaku6.text = "NONE"; } } else { sentaku6.text = "NONE"; }
                            if (num > 4 + sepage * 12) { if (script.chrna[4] != null & script.chrna[4] != string.Empty) { sentaku5.text = script.chrna[4 + sepage * 12]; } else { sentaku5.text = "NONE"; } } else { sentaku5.text = "NONE"; }
                            if (num > 3 + sepage * 12) { if (script.chrna[3] != null & script.chrna[3] != string.Empty) { sentaku4.text = script.chrna[3 + sepage * 12]; } else { sentaku4.text = "NONE"; } } else { sentaku4.text = "NONE"; }
                            if (num > 2 + sepage * 12) { if (script.chrna[2] != null & script.chrna[2] != string.Empty) { sentaku3.text = script.chrna[2 + sepage * 12]; } else { sentaku3.text = "NONE"; } } else { sentaku3.text = "NONE"; }
                            if (num > 1 + sepage * 12) { if (script.chrna[1] != null & script.chrna[1] != string.Empty) { sentaku2.text = script.chrna[1 + sepage * 12]; } else { sentaku2.text = "NONE"; } } else { sentaku2.text = "NONE"; }
                            if (num > 0 + sepage * 12) { if (script.chrna[0] != null & script.chrna[0] != string.Empty) { sentaku1.text = script.chrna[0 + sepage * 12]; } else { sentaku1.text = "NONE"; } } else { sentaku1.text = "NONE"; }
                        }
                    }
                    else
                    {
                        editmtext.text = edittext.text;
                        editpanel.SetActive(false);
                        editpanelm.SetActive(true);
                        editpaneltm.text = "キャラクター";

                    }
                }
                else
                {
                    textco.sentakuchf = 0;
                }
                if (textco.coflag == 1)
                {
                    if (largef == 0)
                    {
                        textco.sentakuchf = 0;
                        editpanel.SetActive(true);
                        editpanelm.SetActive(false);
                        cnum = script.ctagna.Length;
                        sempage = (cnum - 1) / 12 + 1;
                        if (sepage < 1)
                        {
                            sem.SetActive(false);
                        }
                        else
                        {
                            sem.SetActive(true);
                        }
                        if (sepage + 2 > sempage)
                        {
                            set.SetActive(false);
                        }
                        else
                        {
                            set.SetActive(true);
                        }
                        sepp.text = sepage + 1 + "/" + sempage;

                        editpanelt.text = "フォントカラー";
                        if (tcoflag == 0)
                        {
                            if (cnum > 11 + sepage * 12) { if (script.ctagna[11] != null & script.ctagna[11] != string.Empty) { sentaku12.text = script.ctagna[11 + sepage * 12]; } else { sentaku12.text = "NONE"; } } else { sentaku12.text = "NONE"; }
                            if (cnum > 10 + sepage * 12) { if (script.ctagna[10] != null & script.ctagna[10] != string.Empty) { sentaku11.text = script.ctagna[10 + sepage * 12]; } else { sentaku11.text = "NONE"; } } else { sentaku11.text = "NONE"; }
                            if (cnum > 9 + sepage * 12) { if (script.ctagna[9] != null & script.ctagna[9] != string.Empty) { sentaku10.text = script.ctagna[9 + sepage * 12]; } else { sentaku10.text = "NONE"; } } else { sentaku10.text = "NONE"; }
                            if (cnum > 8 + sepage * 12) { if (script.ctagna[8] != null & script.ctagna[8] != string.Empty) { sentaku9.text = script.ctagna[8 + sepage * 12]; } else { sentaku9.text = "NONE"; } } else { sentaku9.text = "NONE"; }
                            if (cnum > 7 + sepage * 12) { if (script.ctagna[7] != null & script.ctagna[7] != string.Empty) { sentaku8.text = script.ctagna[7 + sepage * 12]; } else { sentaku8.text = "NONE"; } } else { sentaku8.text = "NONE"; }
                            if (cnum > 6 + sepage * 12) { if (script.ctagna[6] != null & script.ctagna[6] != string.Empty) { sentaku7.text = script.ctagna[6 + sepage * 12]; } else { sentaku7.text = "NONE"; } } else { sentaku7.text = "NONE"; }
                            if (cnum > 5 + sepage * 12) { if (script.ctagna[5] != null & script.ctagna[5] != string.Empty) { sentaku6.text = script.ctagna[5 + sepage * 12]; } else { sentaku6.text = "NONE"; } } else { sentaku6.text = "NONE"; }
                            if (cnum > 4 + sepage * 12) { if (script.ctagna[4] != null & script.ctagna[4] != string.Empty) { sentaku5.text = script.ctagna[4 + sepage * 12]; } else { sentaku5.text = "NONE"; } } else { sentaku5.text = "NONE"; }
                            if (cnum > 3 + sepage * 12) { if (script.ctagna[3] != null & script.ctagna[3] != string.Empty) { sentaku4.text = script.ctagna[3 + sepage * 12]; } else { sentaku4.text = "NONE"; } } else { sentaku4.text = "NONE"; }
                            if (cnum > 2 + sepage * 12) { if (script.ctagna[2] != null & script.ctagna[2] != string.Empty) { sentaku3.text = script.ctagna[2 + sepage * 12]; } else { sentaku3.text = "NONE"; } } else { sentaku3.text = "NONE"; }
                            if (cnum > 1 + sepage * 12) { if (script.ctagna[1] != null & script.ctagna[1] != string.Empty) { sentaku2.text = script.ctagna[1 + sepage * 12]; } else { sentaku2.text = "NONE"; } } else { sentaku2.text = "NONE"; }
                            if (cnum > 0 + sepage * 12) { if (script.ctagna[0] != null & script.ctagna[0] != string.Empty) { sentaku1.text = script.ctagna[0 + sepage * 12]; } else { sentaku1.text = "NONE"; } } else { sentaku1.text = "NONE"; }
                        }
                        else
                        {
                            if (cnum > 11 + sepage * 12) { if (script.colorna[11] != null & script.colorna[11] != string.Empty) { sentaku12.text = sentaku1.text = "内部" + script.ocolorna[11 + sepage * 12] + "　外部" + script.colorna[11 + sepage * 12]; } else { sentaku12.text = "NONE"; } } else { sentaku12.text = "NONE"; }
                            if (cnum > 10 + sepage * 12) { if (script.colorna[10] != null & script.colorna[10] != string.Empty) { sentaku11.text = sentaku1.text = "内部" + script.ocolorna[10 + sepage * 12] + "　外部" + script.colorna[10 + sepage * 12]; } else { sentaku11.text = "NONE"; } } else { sentaku11.text = "NONE"; }
                            if (cnum > 9 + sepage * 12) { if (script.colorna[9] != null & script.colorna[9] != string.Empty) { sentaku10.text = sentaku1.text = "内部" + script.ocolorna[9 + sepage * 12] + "　外部" + script.colorna[9 + sepage * 12]; } else { sentaku10.text = "NONE"; } } else { sentaku10.text = "NONE"; }
                            if (cnum > 8 + sepage * 12) { if (script.colorna[8] != null & script.colorna[8] != string.Empty) { sentaku9.text = sentaku1.text = "内部" + script.ocolorna[8 + sepage * 12] + "　外部" + script.colorna[8 + sepage * 12]; } else { sentaku9.text = "NONE"; } } else { sentaku9.text = "NONE"; }
                            if (cnum > 7 + sepage * 12) { if (script.colorna[7] != null & script.colorna[7] != string.Empty) { sentaku8.text = sentaku1.text = "内部" + script.ocolorna[7 + sepage * 12] + "　外部" + script.colorna[7 + sepage * 12]; } else { sentaku8.text = "NONE"; } } else { sentaku8.text = "NONE"; }
                            if (cnum > 6 + sepage * 12) { if (script.colorna[6] != null & script.colorna[6] != string.Empty) { sentaku7.text = sentaku1.text = "内部" + script.ocolorna[6 + sepage * 12] + "　外部" + script.colorna[6 + sepage * 12]; } else { sentaku7.text = "NONE"; } } else { sentaku7.text = "NONE"; }
                            if (cnum > 5 + sepage * 12) { if (script.colorna[5] != null & script.colorna[5] != string.Empty) { sentaku6.text = sentaku1.text = "内部" + script.ocolorna[5 + sepage * 12] + "　外部" + script.colorna[5 + sepage * 12]; } else { sentaku6.text = "NONE"; } } else { sentaku6.text = "NONE"; }
                            if (cnum > 4 + sepage * 12) { if (script.colorna[4] != null & script.colorna[4] != string.Empty) { sentaku5.text = sentaku1.text = "内部" + script.ocolorna[4 + sepage * 12] + "　外部" + script.colorna[4 + sepage * 12]; } else { sentaku5.text = "NONE"; } } else { sentaku5.text = "NONE"; }
                            if (cnum > 3 + sepage * 12) { if (script.colorna[3] != null & script.colorna[3] != string.Empty) { sentaku4.text = sentaku1.text = "内部" + script.ocolorna[3 + sepage * 12] + "　外部" + script.colorna[3 + sepage * 12]; } else { sentaku4.text = "NONE"; } } else { sentaku4.text = "NONE"; }
                            if (cnum > 2 + sepage * 12) { if (script.colorna[2] != null & script.colorna[2] != string.Empty) { sentaku3.text = sentaku1.text = "内部" + script.ocolorna[2 + sepage * 12] + "　外部" + script.colorna[2 + sepage * 12]; } else { sentaku3.text = "NONE"; } } else { sentaku3.text = "NONE"; }
                            if (cnum > 1 + sepage * 12) { if (script.colorna[1] != null & script.colorna[1] != string.Empty) { sentaku2.text = sentaku1.text = "内部" + script.ocolorna[1 + sepage * 12] + "　外部" + script.colorna[1 + sepage * 12]; } else { sentaku2.text = "NONE"; } } else { sentaku2.text = "NONE"; }
                            if (cnum > 0 + sepage * 12) { if (script.colorna[0] != null & script.colorna[0] != string.Empty) { sentaku1.text = sentaku1.text = "内部" + script.ocolorna[0 + sepage * 12] + "　外部" + script.colorna[0 + sepage * 12]; } else { sentaku1.text = "NONE"; } } else { sentaku1.text = "NONE"; }
                        }
                    }
                    else
                    {
                        editmtext.text = edittext.text;
                        editpanel.SetActive(false);
                        editpanelm.SetActive(true);
                        editpaneltm.text = "フォントカラー";

                    }
                }
                else
                {
                    textco.sentakucof = 0;
                }
                if (textco.chflag == 0 & textco.coflag == 0)
                {
                    editpanel.SetActive(false);
                    editpanelm.SetActive(false);
                    textco.sentakuchf = 0;
                    textco.sentakucof = 0;
                    largef = 0;
                }

                for (kf = 0; kf < tnum; kf++)
                {
                    script.text[kf] = script.text[kf].Replace("l", "\n");
                }
                if (kf >= tnum)
                {
                    kf = 0;
                }
                if (thflag == 0)
                {
                    textis.SetActive(true);
                    texths.SetActive(false);
                    Graphic t1 = texti1.placeholder;
                    Graphic t2 = texti2.placeholder;
                    Graphic t3 = texti3.placeholder;
                    Graphic t4 = texti4.placeholder;
                    Graphic t5 = texti5.placeholder;
                    if (edit_tnum >= 1) { ((Text)t1).text = script.texth[edit_tnum - 1]; }
                    if (edit_tnum >= 2) { ((Text)t2).text = script.texth[edit_tnum - 2]; }
                    if (edit_tnum >= 3) { ((Text)t3).text = script.texth[edit_tnum - 3]; }
                    if (edit_tnum >= 4) { ((Text)t4).text = script.texth[edit_tnum - 4]; }
                    if (edit_tnum >= 5) { ((Text)t5).text = script.texth[edit_tnum - 5]; }
                    textny1 = textnys[edit_tnum - 1] = texti1.text;
                    textny2 = textnys[edit_tnum - 2] = texti2.text;
                    textny3 = textnys[edit_tnum - 3] = texti3.text;
                    textny4 = textnys[edit_tnum - 4] = texti4.text;
                    textny5 = textnys[edit_tnum - 5] = texti5.text;
                    if (trf > 0)
                    {
                        texti1.text = null;
                        texti2.text = null;
                        texti3.text = null;
                        texti4.text = null;
                        texti5.text = null;
                        trf = 0;
                    }
                }
                else
                {
                    textis.SetActive(false);
                    texths.SetActive(true);
                    if (edit_tnum >= 1) { if (script.textho[edit_tnum - 1].StartsWith("「") == true) { text5.text = script.textho[edit_tnum - 1].Replace("/", "\n　"); } else { text5.text = script.textho[edit_tnum - 1].Replace("/", "\n"); } }
                    if (edit_tnum >= 2) { if (script.textho[edit_tnum - 2].StartsWith("「") == true) { text4.text = script.textho[edit_tnum - 2].Replace("/", "\n　"); } else { text4.text = script.textho[edit_tnum - 2].Replace("/", "\n"); } }
                    if (edit_tnum >= 3) { if (script.textho[edit_tnum - 3].StartsWith("「") == true) { text3.text = script.textho[edit_tnum - 3].Replace("/", "\n　"); } else { text3.text = script.textho[edit_tnum - 3].Replace("/", "\n"); } }
                    if (edit_tnum >= 4) { if (script.textho[edit_tnum - 4].StartsWith("「") == true) { text2.text = script.textho[edit_tnum - 4].Replace("/", "\n　"); } else { text2.text = script.textho[edit_tnum - 4].Replace("/", "\n"); } }
                    if (edit_tnum >= 5) { if (script.textho[edit_tnum - 5].StartsWith("「") == true) { text1.text = script.textho[edit_tnum - 5].Replace("/", "\n　"); } else { text1.text = script.textho[edit_tnum - 5].Replace("/", "\n"); } }
                }
            }
            else
            {
                textco.chflag = 0;
                textco.coflag = 0;
                txt.SetActive(false);
                text.SetActive(false);
            }
            //キャラエディット
            if (editp == 1)
            {
                chr.SetActive(true);
                //ページ１:キャラ名
                if (chrpage == 0)
                {
                    chrpage1.SetActive(true);
                    chrpage2.SetActive(false);
                    cmigi.SetActive(false);
                    chidari.SetActive(false);
                    if (edit_num == 0)
                    {
                        edit_num = script.chrna.Length;
                    }
                    if (editco.zg > 0)
                    {
                        myoji5.text = myojis[edit_num - 5];
                        myoji4.text = myojis[edit_num - 4];
                        myoji3.text = myojis[edit_num - 3];
                        myoji2.text = myojis[edit_num - 2];
                        if (editco.zg == 2)
                        {
                            myoji1.text = string.Empty;
                        }
                        else
                        {
                            myoji1.text = myojis[edit_num - 1];
                        }
                        name5.text = names[edit_num - 5];
                        name4.text = names[edit_num - 4];
                        name3.text = names[edit_num - 3];
                        name2.text = names[edit_num - 2];
                        if (editco.zg == 2)
                        {
                            name1.text = string.Empty;
                        }
                        else
                        {
                            name1.text = names[edit_num - 1];
                        }
                        tag5.text = tags[edit_num - 5];
                        tag4.text = tags[edit_num - 4];
                        tag3.text = tags[edit_num - 3];
                        tag2.text = tags[edit_num - 2];
                        if (editco.zg == 2)
                        {
                            tag1.text = string.Empty;
                        }
                        else
                        {
                            tag1.text = tags[edit_num - 1];
                        }
                        editco.zg = 0;
                    }
                    if (editco.zg < 0)
                    {

                        myoji1.text = myojis[edit_num - 1];
                        myoji2.text = myojis[edit_num - 2];
                        myoji3.text = myojis[edit_num - 3];
                        myoji4.text = myojis[edit_num - 4];
                        if (editco.zg == -2)
                        {
                            myoji5.text = string.Empty;
                        }
                        else
                        {
                            myoji5.text = myojis[edit_num - 5];
                        }
                        name1.text = names[edit_num - 1];
                        name2.text = names[edit_num - 2];
                        name3.text = names[edit_num - 3];
                        name4.text = names[edit_num - 4];
                        if (editco.zg == -2)
                        {
                            name5.text = string.Empty;
                        }
                        else
                        {
                            name5.text = names[edit_num - 5];
                        }
                        tag1.text = tags[edit_num - 1];
                        tag2.text = tags[edit_num - 2];
                        tag3.text = tags[edit_num - 3];
                        tag4.text = tags[edit_num - 4];
                        if (editco.zg == 2)
                        {
                            tag5.text = string.Empty;
                        }
                        else
                        {
                            tag5.text = tags[edit_num - 5];
                        }
                        editco.zg = 0;
                    }
                    if (num > 4)
                    {
                        //タグ+苗字+名前+性別
                        Graphic cht1 = tag1.placeholder;
                        Graphic cht2 = tag2.placeholder;
                        Graphic cht3 = tag3.placeholder;
                        Graphic cht4 = tag4.placeholder;
                        Graphic cht5 = tag5.placeholder;
                        Graphic cmy1 = myoji1.placeholder;
                        Graphic cmy2 = myoji2.placeholder;
                        Graphic cmy3 = myoji3.placeholder;
                        Graphic cmy4 = myoji4.placeholder;
                        Graphic cmy5 = myoji5.placeholder;
                        Graphic cna1 = name1.placeholder;
                        Graphic cna2 = name2.placeholder;
                        Graphic cna3 = name3.placeholder;
                        Graphic cna4 = name4.placeholder;
                        Graphic cna5 = name5.placeholder;
                        Graphic bik1 = bikou1.placeholder;
                        Graphic bik2 = bikou2.placeholder;
                        Graphic bik3 = bikou3.placeholder;
                        Graphic bik4 = bikou4.placeholder;
                        Graphic bik5 = bikou5.placeholder;
                        chrnum1.text = "No." + (edit_num + 1 - 1);
                        chrnum2.text = "No." + (edit_num + 1 - 2);
                        chrnum3.text = "No." + (edit_num + 1 - 3);
                        chrnum4.text = "No." + (edit_num + 1 - 4);
                        chrnum5.text = "No." + (edit_num + 1 - 5);
                        if (edit_num >= 1) { ((Text)cht1).text = "●" + script.partna[edit_num - 1]; ((Text)cmy1).text = script.chrmyo[edit_num - 1]; ((Text)cna1).text = script.chrna[edit_num - 1]; seibetsu1.text = sename[script.seibetsu[edit_num - 1]]; ((Text)bik1).text = script.bikou[edit_num - 1]; }
                        if (edit_num >= 2) { ((Text)cht2).text = "●" + script.partna[edit_num - 2]; ((Text)cmy2).text = script.chrmyo[edit_num - 2]; ((Text)cna2).text = script.chrna[edit_num - 2]; seibetsu2.text = sename[script.seibetsu[edit_num - 2]]; ((Text)bik2).text = script.bikou[edit_num - 2]; }
                        if (edit_num >= 3) { ((Text)cht3).text = "●" + script.partna[edit_num - 3]; ((Text)cmy3).text = script.chrmyo[edit_num - 3]; ((Text)cna3).text = script.chrna[edit_num - 3]; seibetsu3.text = sename[script.seibetsu[edit_num - 3]]; ((Text)bik3).text = script.bikou[edit_num - 3]; }
                        if (edit_num >= 4) { ((Text)cht4).text = "●" + script.partna[edit_num - 4]; ((Text)cmy4).text = script.chrmyo[edit_num - 4]; ((Text)cna4).text = script.chrna[edit_num - 4]; seibetsu4.text = sename[script.seibetsu[edit_num - 4]]; ((Text)bik4).text = script.bikou[edit_num - 4]; }
                        if (edit_num >= 5) { ((Text)cht5).text = "●" + script.partna[edit_num - 5]; ((Text)cmy5).text = script.chrmyo[edit_num - 5]; ((Text)cna5).text = script.chrna[edit_num - 5]; seibetsu5.text = sename[script.seibetsu[edit_num - 5]]; ((Text)bik5).text = script.bikou[edit_num - 5]; }
                        if (edit_num >= 1 & script.hyoji[edit_num - 1] == 0) { hyojimn1.text = mn[script.hyoji[edit_num - 1]]; hyoji1.text = script.chrna[edit_num - 1]; } else { hyojimn1.text = mn[script.hyoji[edit_num - 1]]; hyoji1.text = script.chrmyo[edit_num - 1]; }
                        if (edit_num >= 2 & script.hyoji[edit_num - 2] == 0) { hyojimn2.text = mn[script.hyoji[edit_num - 2]]; hyoji2.text = script.chrna[edit_num - 2]; } else { hyojimn2.text = mn[script.hyoji[edit_num - 3]]; hyoji2.text = script.chrmyo[edit_num - 2]; }
                        if (edit_num >= 3 & script.hyoji[edit_num - 3] == 0) { hyojimn3.text = mn[script.hyoji[edit_num - 3]]; hyoji3.text = script.chrna[edit_num - 3]; } else { hyojimn3.text = mn[script.hyoji[edit_num - 3]]; hyoji3.text = script.chrmyo[edit_num - 3]; }
                        if (edit_num >= 4 & script.hyoji[edit_num - 4] == 0) { hyojimn4.text = mn[script.hyoji[edit_num - 4]]; hyoji4.text = script.chrna[edit_num - 4]; } else { hyojimn4.text = mn[script.hyoji[edit_num - 4]]; hyoji4.text = script.chrmyo[edit_num - 4]; }
                        if (edit_num >= 5 & script.hyoji[edit_num - 5] == 0) { hyojimn5.text = mn[script.hyoji[edit_num - 5]]; hyoji5.text = script.chrna[edit_num - 5]; } else { hyojimn5.text = mn[script.hyoji[edit_num - 5]]; hyoji5.text = script.chrmyo[edit_num - 5]; }
                        names1 = names[edit_num - 1] = name1.text;
                        names2 = names[edit_num - 2] = name2.text;
                        names3 = names[edit_num - 3] = name3.text;
                        names4 = names[edit_num - 4] = name4.text;
                        names5 = names[edit_num - 5] = name5.text;
                        tags1 = tags[edit_num - 1] = tag1.text;
                        tags2 = tags[edit_num - 2] = tag2.text;
                        tags3 = tags[edit_num - 3] = tag3.text;
                        tags4 = tags[edit_num - 4] = tag4.text;
                        tags5 = tags[edit_num - 5] = tag5.text;
                        myojis[edit_num - 1] = myoji1.text;
                        myojis[edit_num - 2] = myoji2.text;
                        myojis[edit_num - 3] = myoji3.text;
                        myojis[edit_num - 4] = myoji4.text;
                        myojis[edit_num - 5] = myoji5.text;
                        bikous[edit_num - 1] = bikou1.text;
                        bikous[edit_num - 2] = bikou2.text;
                        bikous[edit_num - 3] = bikou3.text;
                        bikous[edit_num - 4] = bikou4.text;
                        bikous[edit_num - 5] = bikou5.text;
                    }

                    if (names1 == string.Empty & names2 == string.Empty & names3 == string.Empty & names4 == string.Empty & names5 == string.Empty & tags1 == string.Empty & tags2 == string.Empty & tags3 == string.Empty & tags4 == string.Empty & tags5 == string.Empty)
                    {
                        tf = 0;
                    }

                    if (editco.chf == -1)
                    {
                        bikou1.text = string.Empty;
                        bikou2.text = string.Empty;
                        bikou3.text = string.Empty;
                        bikou4.text = string.Empty;
                        bikou5.text = string.Empty;
                        myoji1.text = string.Empty;
                        myoji2.text = string.Empty;
                        myoji3.text = string.Empty;
                        myoji4.text = string.Empty;
                        myoji5.text = string.Empty;
                        name1.text = string.Empty;
                        name2.text = string.Empty;
                        name3.text = string.Empty;
                        name4.text = string.Empty;
                        name5.text = string.Empty;
                        tag1.text = string.Empty;
                        tag2.text = string.Empty;
                        tag3.text = string.Empty;
                        tag4.text = string.Empty;
                        tag5.text = string.Empty;
                        editco.chf = 0;
                    }
                }
                if (chrpage == 100)
                {
                    cfilePath = "Assets/GAMEDATA/Chr";
                    chrpage1.SetActive(false);
                    chrpage2.SetActive(true);
                    chidari.SetActive(true);
                    cmigi.SetActive(false);
                    animeedit.SetActive(false);
                    cpicex.SetActive(true);
                    cfileex.SetActive(false);
                    //アニメーション設定
                    if (script.chrani[0] != null) { cani.text = script.chrani[0]; } else { cani.text = "●NONE"; }
                    //画像ファイル
                    cexmpage = cexnum / 10;
                    if (cexpage == 0) { cexhidari.SetActive(false); } else { cexhidari.SetActive(true); }
                    if (cexpage == dataload.cexmpage) { cexmigi.SetActive(false); } else { cexmigi.SetActive(true); }
                    cexpt.text = "画像ファイル：" + (cexpage + 1) + "/" + (dataload.cexmpage + 1);
                    if (dataload.cexnum > 1 + cexpage * 10) { cex1.sprite = script2.csprite[1 + cexpage * 10]; } else { cex1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 2 + cexpage * 10) { cex2.sprite = script2.csprite[2 + cexpage * 10]; } else { cex2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 3 + cexpage * 10) { cex3.sprite = script2.csprite[3 + cexpage * 10]; } else { cex3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 4 + cexpage * 10) { cex4.sprite = script2.csprite[4 + cexpage * 10]; } else { cex4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 5 + cexpage * 10) { cex5.sprite = script2.csprite[5 + cexpage * 10]; } else { cex5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 6 + cexpage * 10) { cex6.sprite = script2.csprite[6 + cexpage * 10]; } else { cex6.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 7 + cexpage * 10) { cex7.sprite = script2.csprite[7 + cexpage * 10]; } else { cex7.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 8 + cexpage * 10) { cex8.sprite = script2.csprite[8 + cexpage * 10]; } else { cex8.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 9 + cexpage * 10) { cex9.sprite = script2.csprite[9 + cexpage * 10]; } else { cex9.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 10 + cexpage * 10) { cex10.sprite = script2.csprite[10 + cexpage * 10]; } else { cex10.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    cpic_num = 0;
                    cpicnumber = 0;
                    cex_num = 0;
                }
            }
            else
            {
                chr.SetActive(false);
                chrpage = 0;
                edit_num = 0;
            }
            //カラーエディット
            if (editp == 2)
            {
                color.SetActive(true);
                if (edit_cnum == 0)
                {
                    edit_cnum = script.ctagna.Length;
                }
                if (colorco.zgc > 0)
                {
                    tag5.text = ctags[edit_cnum - 5];
                    tag4.text = ctags[edit_cnum - 4];
                    tag3.text = ctags[edit_cnum - 3];
                    tag2.text = ctags[edit_cnum - 2];
                    if (colorco.zgc == 2)
                    {
                        tag1.text = string.Empty;
                    }
                    else
                    {
                        tag1.text = ctags[edit_cnum - 1];
                    }
                    colorco.zgc = 0;
                }
                if (colorco.zgc < 0)
                {
                    tag1.text = ctags[edit_cnum - 1];
                    tag2.text = ctags[edit_cnum - 2];
                    tag3.text = ctags[edit_cnum - 3];
                    tag4.text = ctags[edit_cnum - 4];
                    if (colorco.zgc == 2)
                    {
                        tag5.text = string.Empty;
                    }
                    else
                    {
                        tag5.text = ctags[edit_cnum - 5];
                    }
                    colorco.zgc = 0;
                }
                if (cnum > 4)
                {
                    Graphic cona1 = ctag1.placeholder;
                    Graphic cona2 = ctag2.placeholder;
                    Graphic cona3 = ctag3.placeholder;
                    Graphic cona4 = ctag4.placeholder;
                    Graphic cona5 = ctag5.placeholder;
                    colnum1.text = "No." + (edit_cnum + 1 - 1);
                    colnum2.text = "No." + (edit_cnum + 1 - 2);
                    colnum3.text = "No." + (edit_cnum + 1 - 3);
                    colnum4.text = "No." + (edit_cnum + 1 - 4);
                    colnum5.text = "No." + (edit_cnum + 1 - 5);
                    if (edit_cnum >= 1) { ((Text)cona1).text = "●" + script.ctagna[edit_cnum - 1]; }
                    if (edit_cnum >= 2) { ((Text)cona2).text = "●" + script.ctagna[edit_cnum - 2]; }
                    if (edit_cnum >= 3) { ((Text)cona3).text = "●" + script.ctagna[edit_cnum - 3]; }
                    if (edit_cnum >= 4) { ((Text)cona4).text = "●" + script.ctagna[edit_cnum - 4]; }
                    if (edit_cnum >= 5) { ((Text)cona5).text = "●" + script.ctagna[edit_cnum - 5]; }
                    if (script.colorna[edit_cnum - 1] != null & script.colorna[edit_cnum - 1] != string.Empty) { colorname1.text = script.colorna[edit_cnum - 1]; } else { colorname1.text = "ffffff"; }
                    if (script.colorna[edit_cnum - 2] != null & script.colorna[edit_cnum - 2] != string.Empty) { colorname2.text = script.colorna[edit_cnum - 2]; } else { colorname2.text = "ffffff"; }
                    if (script.colorna[edit_cnum - 3] != null & script.colorna[edit_cnum - 3] != string.Empty) { colorname3.text = script.colorna[edit_cnum - 3]; } else { colorname3.text = "ffffff"; }
                    if (script.colorna[edit_cnum - 4] != null & script.colorna[edit_cnum - 4] != string.Empty) { colorname4.text = script.colorna[edit_cnum - 4]; } else { colorname4.text = "ffffff"; }
                    if (script.colorna[edit_cnum - 5] != null & script.colorna[edit_cnum - 5] != string.Empty) { colorname5.text = script.colorna[edit_cnum - 5]; } else { colorname5.text = "ffffff"; }
                    if (script.ocolorna[edit_cnum - 1] != null & script.ocolorna[edit_cnum - 1] != string.Empty) { ocolorname1.text = script.ocolorna[edit_cnum - 1]; } else { ocolorname1.text = "ffffff"; }
                    if (script.ocolorna[edit_cnum - 2] != null & script.ocolorna[edit_cnum - 2] != string.Empty) { ocolorname2.text = script.ocolorna[edit_cnum - 2]; } else { ocolorname2.text = "ffffff"; }
                    if (script.ocolorna[edit_cnum - 3] != null & script.ocolorna[edit_cnum - 3] != string.Empty) { ocolorname3.text = script.ocolorna[edit_cnum - 3]; } else { ocolorname3.text = "ffffff"; }
                    if (script.ocolorna[edit_cnum - 4] != null & script.ocolorna[edit_cnum - 4] != string.Empty) { ocolorname4.text = script.ocolorna[edit_cnum - 4]; } else { ocolorname4.text = "ffffff"; }
                    if (script.ocolorna[edit_cnum - 5] != null & script.ocolorna[edit_cnum - 5] != string.Empty) { ocolorname5.text = script.ocolorna[edit_cnum - 5]; } else { ocolorname5.text = "ffffff"; }
                    ctagt1 = ctags[edit_cnum - 1] = ctag1.text;
                    ctagt2 = ctags[edit_cnum - 2] = ctag2.text;
                    ctagt3 = ctags[edit_cnum - 3] = ctag3.text;
                    ctagt4 = ctags[edit_cnum - 4] = ctag4.text;
                    ctagt5 = ctags[edit_cnum - 5] = ctag5.text;
                    if (colorname1.text != string.Empty & colorname1.text != null) { ColorUtility.TryParseHtmlString("#" + script.colorna[edit_cnum - 1], out colcolor); csample1.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; csample1.color = colcolor; }
                    if (colorname2.text != string.Empty & colorname2.text != null) { ColorUtility.TryParseHtmlString("#" + script.colorna[edit_cnum - 2], out colcolor); csample2.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; csample2.color = colcolor; }
                    if (colorname3.text != string.Empty & colorname3.text != null) { ColorUtility.TryParseHtmlString("#" + script.colorna[edit_cnum - 3], out colcolor); csample3.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; csample3.color = colcolor; }
                    if (colorname4.text != string.Empty & colorname4.text != null) { ColorUtility.TryParseHtmlString("#" + script.colorna[edit_cnum - 4], out colcolor); csample4.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; csample4.color = colcolor; }
                    if (colorname5.text != string.Empty & colorname5.text != null) { ColorUtility.TryParseHtmlString("#" + script.colorna[edit_cnum - 5], out colcolor); csample5.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; csample5.color = colcolor; }
                    if (ocolorname1.text != string.Empty & ocolorname1.text != null) { Outline chrli1 = csample1.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#" + script.ocolorna[edit_cnum - 1], out colcolor); chrli1.effectColor = colcolor; } else { Outline chrli1 = csample1.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; chrli1.effectColor = colcolor; }
                    if (ocolorname2.text != string.Empty & ocolorname2.text != null) { Outline chrli2 = csample2.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#" + script.ocolorna[edit_cnum - 2], out colcolor); chrli2.effectColor = colcolor; } else { Outline chrli2 = csample2.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; chrli2.effectColor = colcolor; }
                    if (ocolorname3.text != string.Empty & ocolorname3.text != null) { Outline chrli3 = csample3.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#" + script.ocolorna[edit_cnum - 3], out colcolor); chrli3.effectColor = colcolor; } else { Outline chrli3 = csample3.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; chrli3.effectColor = colcolor; }
                    if (ocolorname4.text != string.Empty & ocolorname4.text != null) { Outline chrli4 = csample4.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#" + script.ocolorna[edit_cnum - 4], out colcolor); chrli4.effectColor = colcolor; } else { Outline chrli4 = csample4.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; chrli4.effectColor = colcolor; }
                    if (ocolorname5.text != string.Empty & ocolorname5.text != null) { Outline chrli5 = csample5.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#" + script.ocolorna[edit_cnum - 5], out colcolor); chrli5.effectColor = colcolor; } else { Outline chrli5 = csample5.GetComponent<Outline>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; chrli5.effectColor = colcolor; }
                }
                if (ctagt1 == string.Empty & ctagt2 == string.Empty & ctagt3 == string.Empty & ctagt4 == string.Empty & ctagt5 == string.Empty)
                {
                    tf = 0;
                }

                if (colorco.cf == -1)
                {
                    ctag1.text = string.Empty;
                    ctag2.text = string.Empty;
                    ctag3.text = string.Empty;
                    ctag4.text = string.Empty;
                    ctag5.text = string.Empty;
                    colorco.cf = 0;
                }
                if (colorco.cf == -2)
                {
                    colortext.text = string.Empty;
                    cf = 0;
                }
                //カラーパレット
                if (textt.cos > 14 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[14 + cppage * 15], out colcolor); ; colorpanel15.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 13 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[13 + cppage * 15], out colcolor); ; colorpanel14.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 12 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[12 + cppage * 15], out colcolor); ; colorpanel13.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 11 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[11 + cppage * 15], out colcolor); ; colorpanel12.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 10 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[10 + cppage * 15], out colcolor); ; colorpanel11.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 9 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[9 + cppage * 15], out colcolor); ; colorpanel10.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 8 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[8 + cppage * 15], out colcolor); ; colorpanel9.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 7 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[7 + cppage * 15], out colcolor); ; colorpanel8.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 6 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[6 + cppage * 15], out colcolor); ; colorpanel7.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 5 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[5 + cppage * 15], out colcolor); ; colorpanel6.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 4 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[4 + cppage * 15], out colcolor); ; colorpanel5.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 3 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[3 + cppage * 15], out colcolor); ; colorpanel4.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 2 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[2 + cppage * 15], out colcolor); ; colorpanel3.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 1 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[1 + cppage * 15], out colcolor); ; colorpanel2.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                if (textt.cos > 0 + 0 * 15) { ColorUtility.TryParseHtmlString("#" + script.colorp[0 + cppage * 15], out colcolor); ; colorpanel1.color = colcolor; } else { ColorUtility.TryParseHtmlString("#ffffff", out colcolor); ; colorpanel15.color = colcolor; }
                //色の追加
                colort = colortext.text;
                if (colort.Length == 6)
                {
                    Image col = colorpanel.GetComponent<Image>(); ColorUtility.TryParseHtmlString("#" + colort, out colcolor); colorpanel.color = colcolor;
                    col.sprite = Resources.Load<Sprite>("NONE");
                }
                else
                {
                    Image col = colorpanel.GetComponent<Image>(); ColorUtility.TryParseHtmlString("#ffffff", out colcolor); colorpanel.color = colcolor;
                    col.sprite = Resources.Load<Sprite>("/UI/filenone");
                }
            }
            else
            {
                color.SetActive(false);
            }
            //キャライベント
            if (editp == 3)
            {
                if (eventco.chrcgcf > 0) { cebh.SetActive(false); } else { cebh.SetActive(true); }
                chre.SetActive(true);
                //キャライベントの種類
                chreptype[0].text = script.ceventsy[0 + cetpage * 3];
                chreptype[1].text = script.ceventsy[1 + cetpage * 3];
                chreptype[2].text = script.ceventsy[2 + cetpage * 3];
                //画像ファイル
                if (dataload.cxflag == 0)
                {
                    if (cexpage == 0) { cexhidari.SetActive(false); } else { cexhidari.SetActive(true); }
                    if (cexpage == dataload.cexmpage) { cexmigi.SetActive(false); } else { cexmigi.SetActive(true); }
                    if (cexpage > dataload.cexmpage) { cexpage = dataload.cexmpage; }
                    cexpt.text = "画像ファイル：" + (cexpage + 1) + "/" + (dataload.cexmpage + 1);
                    if (dataload.cexnum > cexpage * 10) { cex1m.sprite = script2.csprite[0 + cexpage * 10]; } else { cex1m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 1 + cexpage * 10) { cex2m.sprite = script2.csprite[1 + cexpage * 10]; } else { cex2m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 2 + cexpage * 10) { cex3m.sprite = script2.csprite[2 + cexpage * 10]; } else { cex3m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 3 + cexpage * 10) { cex4m.sprite = script2.csprite[3 + cexpage * 10]; } else { cex4m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 4 + cexpage * 10) { cex5m.sprite = script2.csprite[4 + cexpage * 10]; } else { cex5m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 5 + cexpage * 10) { cex6m.sprite = script2.csprite[5 + cexpage * 10]; } else { cex6m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 6 + cexpage * 10) { cex7m.sprite = script2.csprite[6 + cexpage * 10]; } else { cex7m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 7 + cexpage * 10) { cex8m.sprite = script2.csprite[7 + cexpage * 10]; } else { cex8m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 8 + cexpage * 10) { cex9m.sprite = script2.csprite[8 + cexpage * 10]; } else { cex9m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 9 + cexpage * 10) { cex10m.sprite = script2.csprite[9 + cexpage * 10]; } else { cex10m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > cexpage * 10) { cexd1m.sprite = script2.csprite[0 + cexpage * 10]; } else { cexd1m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 1 + cexpage * 10) { cexd2m.sprite = script2.csprite[1 + cexpage * 10]; } else { cexd2m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 2 + cexpage * 10) { cexd3m.sprite = script2.csprite[2 + cexpage * 10]; } else { cexd3m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 3 + cexpage * 10) { cexd4m.sprite = script2.csprite[3 + cexpage * 10]; } else { cexd4m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 4 + cexpage * 10) { cexd5m.sprite = script2.csprite[4 + cexpage * 10]; } else { cexd5m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 5 + cexpage * 10) { cexd6m.sprite = script2.csprite[5 + cexpage * 10]; } else { cexd6m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 6 + cexpage * 10) { cexd7m.sprite = script2.csprite[6 + cexpage * 10]; } else { cexd7m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 7 + cexpage * 10) { cexd8m.sprite = script2.csprite[7 + cexpage * 10]; } else { cexd8m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 8 + cexpage * 10) { cexd9m.sprite = script2.csprite[8 + cexpage * 10]; } else { cexd9m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.cexnum > 9 + cexpage * 10) { cexd10m.sprite = script2.csprite[9 + cexpage * 10]; } else { cexd10m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                Graphic ctx1 = ceventx[0].placeholder;
                Graphic ctx2 = ceventx[1].placeholder;
                Graphic ctx3 = ceventx[2].placeholder;
                Graphic ctx4 = ceventx[3].placeholder;
                Graphic ctx5 = ceventx[4].placeholder;
                Graphic ctwx1 = ceventwx[0].placeholder;
                Graphic ctwx2 = ceventwx[1].placeholder;
                Graphic ctwx3 = ceventwx[2].placeholder;
                Graphic ctwx4 = ceventwx[3].placeholder;
                Graphic ctwx5 = ceventwx[4].placeholder;
                Graphic ctwx6 = ceventwx[5].placeholder;
                Graphic ctwx7 = ceventwx[6].placeholder;
                Graphic ctwx8 = ceventwx[7].placeholder;
                Graphic ctwx9 = ceventwx[8].placeholder;
                Graphic ctwx10 = ceventwx[9].placeholder;
                if (eventco.chref == -1)
                {
                    ceventx[0].text = string.Empty;
                    ceventx[1].text = string.Empty;
                    ceventx[2].text = string.Empty;
                    ceventx[3].text = string.Empty;
                    ceventx[4].text = string.Empty;
                    ceventwx[1].text = string.Empty;
                    ceventwx[2].text = string.Empty;
                    ceventwx[3].text = string.Empty;
                    ceventwx[4].text = string.Empty;
                    ceventwx[5].text = string.Empty;
                    ceventwx[6].text = string.Empty;
                    ceventwx[7].text = string.Empty;
                    ceventwx[8].text = string.Empty;
                    ceventwx[9].text = string.Empty;
                    ceventwx[0].text = string.Empty;
                    eventco.chref = 0;
                }
                if (ceventf >= 3)
                {
                    cevents.SetActive(false);
                }
                else
                {
                    unaz_num = 0;
                    odoroki_num = 0;
                    daru_num = 0;
                    ceevents.SetActive(false);
                }
                //chrc
                if (ceventf == 0)
                {
                    if (chrc_num == 0) { chrc_num = textt.chrcs; chrevents = new string[textt.chrcs]; chrcg_num = textt.chrcns; chrcdg_num = textt.chrcdns; }
                    chrc.SetActive(true);
                    cevents.SetActive(true);
                    chrenum5.text = "No." + (chrc_num + 1 - 1);
                    chrenum4.text = "No." + (chrc_num + 1 - 2);
                    chrenum3.text = "No." + (chrc_num + 1 - 3);
                    chrenum2.text = "No." + (chrc_num + 1 - 4);
                    chrenum1.text = "No." + (chrc_num + 1 - 5);
                    chretype1.text = script.ceventsy[script.ceventsyl[chrc_num - 5]];
                    chretype2.text = script.ceventsy[script.ceventsyl[chrc_num - 4]];
                    chretype3.text = script.ceventsy[script.ceventsyl[chrc_num - 3]];
                    chretype4.text = script.ceventsy[script.ceventsyl[chrc_num - 2]];
                    chretype5.text = script.ceventsy[script.ceventsyl[chrc_num - 1]];
                    chrevents[chrc_num - 1] = ceventx[4].text;
                    chrevents[chrc_num - 2] = ceventx[3].text;
                    chrevents[chrc_num - 3] = ceventx[2].text;
                    chrevents[chrc_num - 4] = ceventx[1].text;
                    chrevents[chrc_num - 5] = ceventx[0].text;
                    ((Text)ctx5).text = string.Empty + script.chrchantei[chrc_num - 1];
                    ((Text)ctx4).text = string.Empty + script.chrchantei[chrc_num - 2];
                    ((Text)ctx3).text = string.Empty + script.chrchantei[chrc_num - 3];
                    ((Text)ctx2).text = string.Empty + script.chrchantei[chrc_num - 4];
                    ((Text)ctx1).text = string.Empty + script.chrchantei[chrc_num - 5];
                    //キャラ1
                    if (script.ceventsyl[chrc_num - 1] >= 1) { cpic[4].SetActive(true); cpicd[4].SetActive(false); } else { cpic[4].SetActive(false); cpicd[4].SetActive(true); }
                    if (script.ceventsyl[chrc_num - 2] >= 1) { cpic[3].SetActive(true); cpicd[3].SetActive(false); } else { cpic[3].SetActive(false); cpicd[3].SetActive(true); }
                    if (script.ceventsyl[chrc_num - 3] >= 1) { cpic[2].SetActive(true); cpicd[2].SetActive(false); } else { cpic[2].SetActive(false); cpicd[2].SetActive(true); }
                    if (script.ceventsyl[chrc_num - 4] >= 1) { cpic[1].SetActive(true); cpicd[1].SetActive(false); } else { cpic[1].SetActive(false); cpicd[1].SetActive(true); }
                    if (script.ceventsyl[chrc_num - 5] >= 1) { cpic[0].SetActive(true); cpicd[0].SetActive(false); } else { cpic[0].SetActive(false); cpicd[0].SetActive(true); }
                    if (script.ceventsyl[chrc_num - 1] == 1 & script.chrcnum[chrc_num - 1] != null & script.chrcnum[chrc_num - 1] != string.Empty) { chrcpic5.sprite = script2.chrs[script.chrcnum[chrc_num - 1]]; } else { chrcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.ceventsyl[chrc_num - 2] == 1 & script.chrcnum[chrc_num - 2] != null & script.chrcnum[chrc_num - 2] != string.Empty) { chrcpic4.sprite = script2.chrs[script.chrcnum[chrc_num - 2]]; } else { chrcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.ceventsyl[chrc_num - 3] == 1 & script.chrcnum[chrc_num - 3] != null & script.chrcnum[chrc_num - 3] != string.Empty) { chrcpic3.sprite = script2.chrs[script.chrcnum[chrc_num - 3]]; } else { chrcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.ceventsyl[chrc_num - 4] == 1 & script.chrcnum[chrc_num - 4] != null & script.chrcnum[chrc_num - 4] != string.Empty) { chrcpic2.sprite = script2.chrs[script.chrcnum[chrc_num - 4]]; } else { chrcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.ceventsyl[chrc_num - 5] == 1 & script.chrcnum[chrc_num - 5] != null & script.chrcnum[chrc_num - 5] != string.Empty) { chrcpic1.sprite = script2.chrs[script.chrcnum[chrc_num - 5]]; } else { chrcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    //キャラ2・キャラ3
                    if (ceventf == 999)
                    {
                        if (script.ceventsyl[chrc_num - 1] == 0 & script.chrcdnum[chrcdg_num - 1] != null & script.chrcdnum[chrcdg_num - 1] != string.Empty) { chrcdpic10.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 1]]; } else { chrcdpic10.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 1] == 0 & script.chrcdnum[chrcdg_num - 2] != null & script.chrcdnum[chrcdg_num - 2] != string.Empty) { chrcdpic9.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 2]]; } else { chrcdpic9.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 2] == 0 & script.chrcdnum[chrcdg_num - 3] != null & script.chrcdnum[chrcdg_num - 3] != string.Empty) { chrcdpic8.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 3]]; } else { chrcdpic8.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 2] == 0 & script.chrcdnum[chrcdg_num - 4] != null & script.chrcdnum[chrcdg_num - 4] != string.Empty) { chrcdpic7.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 4]]; } else { chrcdpic7.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 3] == 0 & script.chrcdnum[chrcdg_num - 5] != null & script.chrcdnum[chrcdg_num - 5] != string.Empty) { chrcdpic6.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 5]]; } else { chrcdpic6.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 3] == 0 & script.chrcdnum[chrcdg_num - 6] != null & script.chrcdnum[chrcdg_num - 6] != string.Empty) { chrcdpic5.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 6]]; } else { chrcdpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 4] == 0 & script.chrcdnum[chrcdg_num - 7] != null & script.chrcdnum[chrcdg_num - 7] != string.Empty) { chrcdpic4.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 7]]; } else { chrcdpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 4] == 0 & script.chrcdnum[chrcdg_num - 8] != null & script.chrcdnum[chrcdg_num - 8] != string.Empty) { chrcdpic3.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 8]]; } else { chrcdpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 5] == 0 & script.chrcdnum[chrcdg_num - 9] != null & script.chrcdnum[chrcdg_num - 9] != string.Empty) { chrcdpic2.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 9]]; } else { chrcdpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                        if (script.ceventsyl[chrc_num - 5] == 0 & script.chrcdnum[chrcdg_num - 10] != null & script.chrcdnum[chrcdg_num - 10] != string.Empty) { chrcdpic1.sprite = script2.chrs[script.chrcdnum[chrcdg_num - 10]]; } else { chrcdpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    }
                }
                else
                { chrc_num = 0; }
                //うなずき
                if (ceventf == 3)
                {
                    bedbh.SetActive(false);
                    if (eventco.chrcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    chrc.SetActive(true);
                    ceevents.SetActive(true);
                    if (unaz_num == 0) { unaz_num = textt.unazs; chrevents = new string[textt.unazs * 2]; }
                    chrenum5.text = "No." + (unaz_num + 1 - 1);
                    chrenum4.text = "No." + (unaz_num + 1 - 2);
                    chrenum3.text = "No." + (unaz_num + 1 - 3);
                    chrenum2.text = "No." + (unaz_num + 1 - 4);
                    chrenum1.text = "No." + (unaz_num + 1 - 5);
                    chretype1.text = script.ceventsy[3];
                    chretype2.text = script.ceventsy[3];
                    chretype3.text = script.ceventsy[3];
                    chretype4.text = script.ceventsy[3];
                    chretype5.text = script.ceventsy[3];
                    chrevents[(unaz_num - 1) * 2 + 1] = ceventwx[9].text;
                    chrevents[(unaz_num - 1) * 2] = ceventwx[8].text;
                    chrevents[(unaz_num - 2) * 2 + 1] = ceventwx[7].text;
                    chrevents[(unaz_num - 2) * 2] = ceventwx[6].text;
                    chrevents[(unaz_num - 3) * 2 + 1] = ceventwx[5].text;
                    chrevents[(unaz_num - 3) * 2] = ceventwx[4].text;
                    chrevents[(unaz_num - 4) * 2 + 1] = ceventwx[3].text;
                    chrevents[(unaz_num - 4) * 2] = ceventwx[2].text;
                    chrevents[(unaz_num - 5) * 2 + 1] = ceventwx[1].text;
                    chrevents[(unaz_num - 5) * 2] = ceventwx[0].text;
                    ((Text)ctwx10).text = string.Empty + script.unazc[(unaz_num - 1)];
                    ((Text)ctwx8).text = string.Empty + script.unazc[(unaz_num - 2)];
                    ((Text)ctwx6).text = string.Empty + script.unazc[(unaz_num - 3)];
                    ((Text)ctwx4).text = string.Empty + script.unazc[(unaz_num - 4)];
                    ((Text)ctwx2).text = string.Empty + script.unazc[(unaz_num - 5)];
                    ((Text)ctwx9).text = string.Empty + script.unazhantei[(unaz_num - 1)];
                    ((Text)ctwx7).text = string.Empty + script.unazhantei[(unaz_num - 2)];
                    ((Text)ctwx5).text = string.Empty + script.unazhantei[(unaz_num - 3)];
                    ((Text)ctwx3).text = string.Empty + script.unazhantei[(unaz_num - 4)];
                    ((Text)ctwx1).text = string.Empty + script.unazhantei[(unaz_num - 5)];
                    if (script.unaznum[(unaz_num - 1)] != null & script.unaznum[(unaz_num - 1)] != string.Empty) { chrcpic5.sprite = script2.chrs[script.unaznum[(unaz_num - 1)]]; } else { chrcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.unaznum[(unaz_num - 2)] != null & script.unaznum[(unaz_num - 2)] != string.Empty) { chrcpic4.sprite = script2.chrs[script.unaznum[(unaz_num - 2)]]; } else { chrcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.unaznum[(unaz_num - 3)] != null & script.unaznum[(unaz_num - 3)] != string.Empty) { chrcpic3.sprite = script2.chrs[script.unaznum[(unaz_num - 3)]]; } else { chrcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.unaznum[(unaz_num - 4)] != null & script.unaznum[(unaz_num - 4)] != string.Empty) { chrcpic2.sprite = script2.chrs[script.unaznum[(unaz_num - 4)]]; } else { chrcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.unaznum[(unaz_num - 5)] != null & script.unaznum[(unaz_num - 5)] != string.Empty) { chrcpic1.sprite = script2.chrs[script.unaznum[(unaz_num - 5)]]; } else { chrcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    unaz_num = 0;
                }
                //驚き
                if (ceventf == 4)
                {
                    bedbh.SetActive(false);
                    if (eventco.chrcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    chrc.SetActive(true);
                    ceevents.SetActive(true);
                    if (odoroki_num == 0) { odoroki_num = textt.odorokis; chrevents = new string[textt.odorokis * 2]; }
                    chrenum5.text = "No." + (odoroki_num + 1 - 1);
                    chrenum4.text = "No." + (odoroki_num + 1 - 2);
                    chrenum3.text = "No." + (odoroki_num + 1 - 3);
                    chrenum2.text = "No." + (odoroki_num + 1 - 4);
                    chrenum1.text = "No." + (odoroki_num + 1 - 5);
                    chretype1.text = script.ceventsy[4];
                    chretype2.text = script.ceventsy[4];
                    chretype3.text = script.ceventsy[4];
                    chretype4.text = script.ceventsy[4];
                    chretype5.text = script.ceventsy[4];
                    chrevents[(odoroki_num - 1) * 2 + 1] = ceventwx[9].text;
                    chrevents[(odoroki_num - 1) * 2] = ceventwx[8].text;
                    chrevents[(odoroki_num - 2) * 2 + 1] = ceventwx[7].text;
                    chrevents[(odoroki_num - 2) * 2] = ceventwx[6].text;
                    chrevents[(odoroki_num - 3) * 2 + 1] = ceventwx[5].text;
                    chrevents[(odoroki_num - 3) * 2] = ceventwx[4].text;
                    chrevents[(odoroki_num - 4) * 2 + 1] = ceventwx[3].text;
                    chrevents[(odoroki_num - 4) * 2] = ceventwx[2].text;
                    chrevents[(odoroki_num - 5) * 2 + 1] = ceventwx[1].text;
                    chrevents[(odoroki_num - 5) * 2] = ceventwx[0].text;
                    ((Text)ctwx10).text = string.Empty + script.odorokic[(odoroki_num - 1)];
                    ((Text)ctwx8).text = string.Empty + script.odorokic[(odoroki_num - 2)];
                    ((Text)ctwx6).text = string.Empty + script.odorokic[(odoroki_num - 3)];
                    ((Text)ctwx4).text = string.Empty + script.odorokic[(odoroki_num - 4)];
                    ((Text)ctwx2).text = string.Empty + script.odorokic[(odoroki_num - 5)];
                    ((Text)ctwx9).text = string.Empty + script.odorokihantei[(odoroki_num - 1)];
                    ((Text)ctwx7).text = string.Empty + script.odorokihantei[(odoroki_num - 2)];
                    ((Text)ctwx5).text = string.Empty + script.odorokihantei[(odoroki_num - 3)];
                    ((Text)ctwx3).text = string.Empty + script.odorokihantei[(odoroki_num - 4)];
                    ((Text)ctwx1).text = string.Empty + script.odorokihantei[(odoroki_num - 5)];
                    if (script.odorokinum[(odoroki_num - 1)] != null & script.odorokinum[(odoroki_num - 1)] != string.Empty) { chrcpic5.sprite = script2.chrs[script.odorokinum[(odoroki_num - 1)]]; } else { chrcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.odorokinum[(odoroki_num - 2)] != null & script.odorokinum[(odoroki_num - 2)] != string.Empty) { chrcpic4.sprite = script2.chrs[script.odorokinum[(odoroki_num - 2)]]; } else { chrcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.odorokinum[(odoroki_num - 3)] != null & script.odorokinum[(odoroki_num - 3)] != string.Empty) { chrcpic3.sprite = script2.chrs[script.odorokinum[(odoroki_num - 3)]]; } else { chrcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.odorokinum[(odoroki_num - 4)] != null & script.odorokinum[(odoroki_num - 4)] != string.Empty) { chrcpic2.sprite = script2.chrs[script.odorokinum[(odoroki_num - 4)]]; } else { chrcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.odorokinum[(odoroki_num - 5)] != null & script.odorokinum[(odoroki_num - 5)] != string.Empty) { chrcpic1.sprite = script2.chrs[script.odorokinum[(odoroki_num - 5)]]; } else { chrcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    odoroki_num = 0;
                }
                //だる
                if (ceventf == 5)
                {
                    bedbh.SetActive(false);
                    if (eventco.chrcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    chrc.SetActive(true);
                    ceevents.SetActive(true);
                    if (daru_num == 0) { daru_num = textt.darus; chrevents = new string[textt.darus * 2]; }
                    chrenum5.text = "No." + (daru_num + 1 - 1);
                    chrenum4.text = "No." + (daru_num + 1 - 2);
                    chrenum3.text = "No." + (daru_num + 1 - 3);
                    chrenum2.text = "No." + (daru_num + 1 - 4);
                    chrenum1.text = "No." + (daru_num + 1 - 5);
                    chretype1.text = script.ceventsy[5];
                    chretype2.text = script.ceventsy[5];
                    chretype3.text = script.ceventsy[5];
                    chretype4.text = script.ceventsy[5];
                    chretype5.text = script.ceventsy[5];
                    chrevents[(daru_num - 1) * 2 + 1] = ceventwx[9].text;
                    chrevents[(daru_num - 1) * 2] = ceventwx[8].text;
                    chrevents[(daru_num - 2) * 2 + 1] = ceventwx[7].text;
                    chrevents[(daru_num - 2) * 2] = ceventwx[6].text;
                    chrevents[(daru_num - 3) * 2 + 1] = ceventwx[5].text;
                    chrevents[(daru_num - 3) * 2] = ceventwx[4].text;
                    chrevents[(daru_num - 4) * 2 + 1] = ceventwx[3].text;
                    chrevents[(daru_num - 4) * 2] = ceventwx[2].text;
                    chrevents[(daru_num - 5) * 2 + 1] = ceventwx[1].text;
                    chrevents[(daru_num - 5) * 2] = ceventwx[0].text;
                    ((Text)ctwx10).text = string.Empty + script.daruc[(daru_num - 1)];
                    ((Text)ctwx8).text = string.Empty + script.daruc[(daru_num - 2)];
                    ((Text)ctwx6).text = string.Empty + script.daruc[(daru_num - 3)];
                    ((Text)ctwx4).text = string.Empty + script.daruc[(daru_num - 4)];
                    ((Text)ctwx2).text = string.Empty + script.daruc[(daru_num - 5)];
                    ((Text)ctwx9).text = string.Empty + script.daruhantei[(daru_num - 1)];
                    ((Text)ctwx7).text = string.Empty + script.daruhantei[(daru_num - 2)];
                    ((Text)ctwx5).text = string.Empty + script.daruhantei[(daru_num - 3)];
                    ((Text)ctwx3).text = string.Empty + script.daruhantei[(daru_num - 4)];
                    ((Text)ctwx1).text = string.Empty + script.daruhantei[(daru_num - 5)];
                    if (script.darunum[(daru_num - 1)] != null & script.darunum[(daru_num - 1)] != string.Empty) { chrcpic5.sprite = script2.chrs[script.darunum[(daru_num - 1)]]; } else { chrcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.darunum[(daru_num - 2)] != null & script.darunum[(daru_num - 2)] != string.Empty) { chrcpic4.sprite = script2.chrs[script.darunum[(daru_num - 2)]]; } else { chrcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.darunum[(daru_num - 3)] != null & script.darunum[(daru_num - 3)] != string.Empty) { chrcpic3.sprite = script2.chrs[script.darunum[(daru_num - 3)]]; } else { chrcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.darunum[(daru_num - 4)] != null & script.darunum[(daru_num - 4)] != string.Empty) { chrcpic2.sprite = script2.chrs[script.darunum[(daru_num - 4)]]; } else { chrcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.darunum[(daru_num - 5)] != null & script.darunum[(daru_num - 5)] != string.Empty) { chrcpic1.sprite = script2.chrs[script.darunum[(daru_num - 5)]]; } else { chrcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    daru_num = 0;
                }
            }
            else
            {
                chrc_num = 0;
                chrcd_num = 0;
                chrcdg_num = 0;
                unaz_num = 0;
                odoroki_num = 0;
                daru_num = 0;
                chre.SetActive(false);
            }
            //背景イベント
            if (editp == 4)
            {
                bge.SetActive(true);
                //背景イベントの種類
                bgeptype[0].text = script.beventsy[0 + betpage * 6];
                bgeptype[1].text = script.beventsy[1 + betpage * 6];
                bgeptype[2].text = script.beventsy[2 + betpage * 6];
                bgeptype[3].text = script.beventsy[3 + betpage * 6];
                bgeptype[4].text = script.beventsy[4 + betpage * 6];
                //背景画像ファイル
                if (dataload.bxflag == 0)
                {
                    if (bexpage == 0) { bexhidari.SetActive(false); } else { bexhidari.SetActive(true); }
                    if (bexpage == dataload.bexmpage) { bexmigi.SetActive(false); } else { bexmigi.SetActive(true); }
                    if (bexpage > dataload.bexmpage) { bexpage = dataload.bexmpage; }
                    bexpt.text = "画像ファイル：" + (bexpage + 1) + "/" + (dataload.bexmpage + 1);
                    if (dataload.bexnum > 0 + bexpage * 9) { bex1m.sprite = script2.bsprite[0 + bexpage * 9]; } else { bex1m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 1 + bexpage * 9) { bex2m.sprite = script2.bsprite[1 + bexpage * 9]; } else { bex2m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 2 + bexpage * 9) { bex3m.sprite = script2.bsprite[2 + bexpage * 9]; } else { bex3m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 3 + bexpage * 9) { bex4m.sprite = script2.bsprite[3 + bexpage * 9]; } else { bex4m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 4 + bexpage * 9) { bex5m.sprite = script2.bsprite[4 + bexpage * 9]; } else { bex5m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 5 + bexpage * 9) { bex6m.sprite = script2.bsprite[5 + bexpage * 9]; } else { bex6m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 6 + bexpage * 9) { bex7m.sprite = script2.bsprite[6 + bexpage * 9]; } else { bex7m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 7 + bexpage * 9) { bex8m.sprite = script2.bsprite[7 + bexpage * 9]; } else { bex8m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 8 + bexpage * 9) { bex9m.sprite = script2.bsprite[8 + bexpage * 9]; } else { bex9m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 0 + bexpage * 9) { bexd1m.sprite = script2.bsprite[0 + bexpage * 9]; } else { bexd1m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 1 + bexpage * 9) { bexd2m.sprite = script2.bsprite[1 + bexpage * 9]; } else { bexd2m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 2 + bexpage * 9) { bexd3m.sprite = script2.bsprite[2 + bexpage * 9]; } else { bexd3m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 3 + bexpage * 9) { bexd4m.sprite = script2.bsprite[3 + bexpage * 9]; } else { bexd4m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 4 + bexpage * 9) { bexd5m.sprite = script2.bsprite[4 + bexpage * 9]; } else { bexd5m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 5 + bexpage * 9) { bexd6m.sprite = script2.bsprite[5 + bexpage * 9]; } else { bexd6m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 6 + bexpage * 9) { bexd7m.sprite = script2.bsprite[6 + bexpage * 9]; } else { bexd7m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 7 + bexpage * 9) { bexd8m.sprite = script2.bsprite[7 + bexpage * 9]; } else { bexd8m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.bexnum > 8 + bexpage * 9) { bexd9m.sprite = script2.bsprite[8 + bexpage * 9]; } else { bexd9m.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                //背景変化
                Graphic btx1 = beventx1.placeholder;
                Graphic btx2 = beventx2.placeholder;
                Graphic btx3 = beventx3.placeholder;
                Graphic btx4 = beventx4.placeholder;
                Graphic btx5 = beventx5.placeholder;
                //背景効果
                Graphic btwx1 = beventwx[0].placeholder;
                Graphic btwx2 = beventwx[1].placeholder;
                Graphic btwx3 = beventwx[2].placeholder;
                Graphic btwx4 = beventwx[3].placeholder;
                Graphic btwx5 = beventwx[4].placeholder;
                Graphic btwx6 = beventwx[5].placeholder;
                Graphic btwx7 = beventwx[6].placeholder;
                Graphic btwx8 = beventwx[7].placeholder;
                Graphic btwx9 = beventwx[8].placeholder;
                Graphic btwx10 = beventwx[9].placeholder;
                if (eventco.bgef == -1)
                {
                    beventx1.text = string.Empty;
                    beventx2.text = string.Empty;
                    beventx3.text = string.Empty;
                    beventx4.text = string.Empty;
                    beventx5.text = string.Empty;
                    beventwx[1].text = string.Empty;
                    beventwx[2].text = string.Empty;
                    beventwx[3].text = string.Empty;
                    beventwx[4].text = string.Empty;
                    beventwx[5].text = string.Empty;
                    beventwx[6].text = string.Empty;
                    beventwx[7].text = string.Empty;
                    beventwx[8].text = string.Empty;
                    beventwx[9].text = string.Empty;
                    beventwx[0].text = string.Empty;
                    eventco.bgef = 0;
                }
                if (beventf == 0)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    if (bgc_num == 0) { bgc_num = textt.bgcs; bgevents = new string[textt.bgcs]; }
                    bgc.SetActive(true);
                    bgenum5.text = "No." + (bgc_num + 1 - 1);
                    bgenum4.text = "No." + (bgc_num + 1 - 2);
                    bgenum3.text = "No." + (bgc_num + 1 - 3);
                    bgenum2.text = "No." + (bgc_num + 1 - 4);
                    bgenum1.text = "No." + (bgc_num + 1 - 5);
                    bgetype1.text = script.beventsy[0];
                    bgetype2.text = script.beventsy[0];
                    bgetype3.text = script.beventsy[0];
                    bgetype4.text = script.beventsy[0];
                    bgetype5.text = script.beventsy[0];
                    bgevents[bgc_num - 1] = beventx5.text;
                    bgevents[bgc_num - 2] = beventx4.text;
                    bgevents[bgc_num - 3] = beventx3.text;
                    bgevents[bgc_num - 4] = beventx2.text;
                    bgevents[bgc_num - 5] = beventx1.text;
                    ((Text)btx5).text = string.Empty + script.bgchantei[bgc_num - 1];
                    ((Text)btx4).text = string.Empty + script.bgchantei[bgc_num - 2];
                    ((Text)btx3).text = string.Empty + script.bgchantei[bgc_num - 3];
                    ((Text)btx2).text = string.Empty + script.bgchantei[bgc_num - 4];
                    ((Text)btx1).text = string.Empty + script.bgchantei[bgc_num - 5];
                    if (script.bgcnum[bgc_num - 1] != null & script.bgcnum[bgc_num - 1] != string.Empty) { bgcpic5.sprite = script2.bgs[script.bgcnum[bgc_num - 1]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcnum[bgc_num - 2] != null & script.bgcnum[bgc_num - 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.bgcnum[bgc_num - 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcnum[bgc_num - 3] != null & script.bgcnum[bgc_num - 3] != string.Empty) { bgcpic3.sprite = script2.bgs[script.bgcnum[bgc_num - 3]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcnum[bgc_num - 4] != null & script.bgcnum[bgc_num - 4] != string.Empty) { bgcpic2.sprite = script2.bgs[script.bgcnum[bgc_num - 4]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcnum[bgc_num - 5] != null & script.bgcnum[bgc_num - 5] != string.Empty) { bgcpic1.sprite = script2.bgs[script.bgcnum[bgc_num - 5]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    bgc_num = 0;
                }
                if (beventf == 1)
                {
                    bebh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bedbh.SetActive(false); } else { bedbh.SetActive(true); }
                    bgc.SetActive(false);
                    bgcd.SetActive(true);
                    if (bgcd_num == 0) { bgcd_num = textt.bgcds; bgcdg_num = bgcd_num * 2; bgevents = new string[textt.bgcds]; }
                    bgenum5.text = "No." + (bgcd_num + 1 - 1);
                    bgenum4.text = "No." + (bgcd_num + 1 - 2);
                    bgenum3.text = "No." + (bgcd_num + 1 - 3);
                    bgenum2.text = "No." + (bgcd_num + 1 - 4);
                    bgenum1.text = "No." + (bgcd_num + 1 - 5);
                    bgetype1.text = script.beventsy[1];
                    bgetype2.text = script.beventsy[1];
                    bgetype3.text = script.beventsy[1];
                    bgetype4.text = script.beventsy[1];
                    bgetype5.text = script.beventsy[1];
                    bgevents[bgcd_num - 1] = beventx5.text;
                    bgevents[bgcd_num - 2] = beventx4.text;
                    bgevents[bgcd_num - 3] = beventx3.text;
                    bgevents[bgcd_num - 4] = beventx2.text;
                    bgevents[bgcd_num - 5] = beventx1.text;
                    ((Text)btx5).text = string.Empty + script.bgcdhantei[bgcd_num - 1];
                    ((Text)btx4).text = string.Empty + script.bgcdhantei[bgcd_num - 2];
                    ((Text)btx3).text = string.Empty + script.bgcdhantei[bgcd_num - 3];
                    ((Text)btx2).text = string.Empty + script.bgcdhantei[bgcd_num - 4];
                    ((Text)btx1).text = string.Empty + script.bgcdhantei[bgcd_num - 5];
                    if (script.bgcdnum[bgcdg_num - 1] != null & script.bgcdnum[bgcdg_num - 1] != string.Empty) { bgcdpic10.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 1]]; } else { bgcdpic10.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 2] != null & script.bgcdnum[bgcdg_num - 2] != string.Empty) { bgcdpic9.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 2]]; } else { bgcdpic9.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 3] != null & script.bgcdnum[bgcdg_num - 3] != string.Empty) { bgcdpic8.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 3]]; } else { bgcdpic8.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 4] != null & script.bgcdnum[bgcdg_num - 4] != string.Empty) { bgcdpic7.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 4]]; } else { bgcdpic7.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 5] != null & script.bgcdnum[bgcdg_num - 5] != string.Empty) { bgcdpic6.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 5]]; } else { bgcdpic6.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 6] != null & script.bgcdnum[bgcdg_num - 6] != string.Empty) { bgcdpic5.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 6]]; } else { bgcdpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 7] != null & script.bgcdnum[bgcdg_num - 7] != string.Empty) { bgcdpic4.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 7]]; } else { bgcdpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 8] != null & script.bgcdnum[bgcdg_num - 8] != string.Empty) { bgcdpic3.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 8]]; } else { bgcdpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 9] != null & script.bgcdnum[bgcdg_num - 9] != string.Empty) { bgcdpic2.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 9]]; } else { bgcdpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgcdnum[bgcdg_num - 10] != null & script.bgcdnum[bgcdg_num - 10] != string.Empty) { bgcdpic1.sprite = script2.bgs[script.bgcdnum[bgcdg_num - 10]]; } else { bgcdpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    bgcd_num = 0;
                }
                if (beventf == 2)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    chap.SetActive(true);
                    if (chap_num == 0) { chap_num = textt.chaps; bgevents = new string[textt.chaps]; }
                    chap.SetActive(true);
                    bgenum5.text = "No." + (chap_num + 1 - 1);
                    bgenum4.text = "No." + (chap_num + 1 - 2);
                    bgenum3.text = "No." + (chap_num + 1 - 3);
                    bgenum2.text = "No." + (chap_num + 1 - 4);
                    bgenum1.text = "No." + (chap_num + 1 - 5);
                    bgetype1.text = script.beventsy[2];
                    bgetype2.text = script.beventsy[2];
                    bgetype3.text = script.beventsy[2];
                    bgetype4.text = script.beventsy[2];
                    bgetype5.text = script.beventsy[2];
                    bgevents[chap_num - 1] = beventx5.text;
                    bgevents[chap_num - 2] = beventx4.text;
                    bgevents[chap_num - 3] = beventx3.text;
                    bgevents[chap_num - 4] = beventx2.text;
                    bgevents[chap_num - 5] = beventx1.text;
                    btype5.text = script.chapsy[script.chaptypes[chap_num - 1]];
                    btype4.text = script.chapsy[script.chaptypes[chap_num - 2]];
                    btype3.text = script.chapsy[script.chaptypes[chap_num - 3]];
                    btype2.text = script.chapsy[script.chaptypes[chap_num - 4]];
                    btype1.text = script.chapsy[script.chaptypes[chap_num - 5]];
                    chapan5.text = script.chapansy[script.chapans[chap_num - 1]];
                    chapan4.text = script.chapansy[script.chapans[chap_num - 2]];
                    chapan3.text = script.chapansy[script.chapans[chap_num - 3]];
                    chapan2.text = script.chapansy[script.chapans[chap_num - 4]];
                    chapan1.text = script.chapansy[script.chapans[chap_num - 5]];
                    ((Text)btx5).text = string.Empty + script.chaphantei[chap_num - 1];
                    ((Text)btx4).text = string.Empty + script.chaphantei[chap_num - 2];
                    ((Text)btx3).text = string.Empty + script.chaphantei[chap_num - 3];
                    ((Text)btx2).text = string.Empty + script.chaphantei[chap_num - 4];
                    ((Text)btx1).text = string.Empty + script.chaphantei[chap_num - 5];
                    if (script.chapnum[chap_num - 1] != null & script.chapnum[chap_num - 1] != string.Empty) { bgcpic5.sprite = script2.bgs[script.chapnum[chap_num - 1]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chapnum[chap_num - 2] != null & script.chapnum[chap_num - 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.chapnum[chap_num - 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chapnum[chap_num - 3] != null & script.chapnum[chap_num - 3] != string.Empty) { bgcpic3.sprite = script2.bgs[script.chapnum[chap_num - 3]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chapnum[chap_num - 4] != null & script.chapnum[chap_num - 4] != string.Empty) { bgcpic2.sprite = script2.bgs[script.chapnum[chap_num - 4]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chapnum[chap_num - 5] != null & script.chapnum[chap_num - 5] != string.Empty) { bgcpic1.sprite = script2.bgs[script.chapnum[chap_num - 5]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    chap.SetActive(false);
                    chap_num = 0;
                }
                if (beventf == 3)
                {
                    bebh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bedbh.SetActive(false); } else { bedbh.SetActive(true); }
                    bgcd.SetActive(true);
                    if (chapt_num == 0) { chapt_num = textt.chapts; chaptg_num = textt.chapts * 2; bgevents = new string[textt.chapts]; }
                    bgenum5.text = "No." + (chapt_num + 1 - 1);
                    bgenum4.text = "No." + (chapt_num + 1 - 2);
                    bgenum3.text = "No." + (chapt_num + 1 - 3);
                    bgenum2.text = "No." + (chapt_num + 1 - 4);
                    bgenum1.text = "No." + (chapt_num + 1 - 5);
                    bgetype1.text = script.beventsy[3];
                    bgetype2.text = script.beventsy[3];
                    bgetype3.text = script.beventsy[3];
                    bgetype4.text = script.beventsy[3];
                    bgetype5.text = script.beventsy[3];
                    bgevents[chapt_num - 1] = beventx5.text;
                    bgevents[chapt_num - 2] = beventx4.text;
                    bgevents[chapt_num - 3] = beventx3.text;
                    bgevents[chapt_num - 4] = beventx2.text;
                    bgevents[chapt_num - 5] = beventx1.text;
                    ((Text)btx5).text = string.Empty + script.chapthantei[chapt_num - 1];
                    ((Text)btx4).text = string.Empty + script.chapthantei[chapt_num - 2];
                    ((Text)btx3).text = string.Empty + script.chapthantei[chapt_num - 3];
                    ((Text)btx2).text = string.Empty + script.chapthantei[chapt_num - 4];
                    ((Text)btx1).text = string.Empty + script.chapthantei[chapt_num - 5];
                    if (script.chaptnum[chaptg_num - 1] != null & script.chaptnum[chaptg_num - 1] != string.Empty) { bgcdpic10.sprite = script2.bgs[script.chaptnum[chaptg_num - 1]]; } else { bgcdpic10.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 2] != null & script.chaptnum[chaptg_num - 2] != string.Empty) { bgcdpic9.sprite = script2.bgs[script.chaptnum[chaptg_num - 2]]; } else { bgcdpic9.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 3] != null & script.chaptnum[chaptg_num - 3] != string.Empty) { bgcdpic8.sprite = script2.bgs[script.chaptnum[chaptg_num - 3]]; } else { bgcdpic8.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 4] != null & script.chaptnum[chaptg_num - 4] != string.Empty) { bgcdpic7.sprite = script2.bgs[script.chaptnum[chaptg_num - 4]]; } else { bgcdpic7.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 5] != null & script.chaptnum[chaptg_num - 5] != string.Empty) { bgcdpic6.sprite = script2.bgs[script.chaptnum[chaptg_num - 5]]; } else { bgcdpic6.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 6] != null & script.chaptnum[chaptg_num - 6] != string.Empty) { bgcdpic5.sprite = script2.bgs[script.chaptnum[chaptg_num - 6]]; } else { bgcdpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 7] != null & script.chaptnum[chaptg_num - 7] != string.Empty) { bgcdpic4.sprite = script2.bgs[script.chaptnum[chaptg_num - 7]]; } else { bgcdpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 8] != null & script.chaptnum[chaptg_num - 8] != string.Empty) { bgcdpic3.sprite = script2.bgs[script.chaptnum[chaptg_num - 8]]; } else { bgcdpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 9] != null & script.chaptnum[chaptg_num - 9] != string.Empty) { bgcdpic2.sprite = script2.bgs[script.chaptnum[chaptg_num - 9]]; } else { bgcdpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.chaptnum[chaptg_num - 10] != null & script.chaptnum[chaptg_num - 10] != string.Empty) { bgcdpic1.sprite = script2.bgs[script.chaptnum[chaptg_num - 10]]; } else { bgcdpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    chapt_num = 0;
                }
                if (beventf != 1 & beventf != 3 & beventf != 10)
                {
                    bgcd.SetActive(false);
                }
                else
                {
                    bgc.SetActive(false);
                }
                if (beventf < 6)
                {
                    eventpos.SetActive(true);
                    eeventpos.SetActive(false);
                }
                else
                {
                    eeventpos.SetActive(true);
                    eventpos.SetActive(false);
                }
                if (beventf == 4)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    kakudai.SetActive(true);
                    if (kakudai_num == 0) { kakudai_num = textt.kakudais; bgevents = new string[textt.kakudais]; }
                    kakudai.SetActive(true);
                    bgenum5.text = "No." + (kakudai_num + 1 - 1);
                    bgenum4.text = "No." + (kakudai_num + 1 - 2);
                    bgenum3.text = "No." + (kakudai_num + 1 - 3);
                    bgenum2.text = "No." + (kakudai_num + 1 - 4);
                    bgenum1.text = "No." + (kakudai_num + 1 - 5);
                    bgetype1.text = script.beventsy[4];
                    bgetype2.text = script.beventsy[4];
                    bgetype3.text = script.beventsy[4];
                    bgetype4.text = script.beventsy[4];
                    bgetype5.text = script.beventsy[4];
                    bgevents[kakudai_num - 1] = beventx5.text;
                    bgevents[kakudai_num - 2] = beventx4.text;
                    bgevents[kakudai_num - 3] = beventx3.text;
                    bgevents[kakudai_num - 4] = beventx2.text;
                    bgevents[kakudai_num - 5] = beventx1.text;
                    ktype5.text = script.kakudaisy[script.kakudaitypes[kakudai_num - 1]];
                    ktype4.text = script.kakudaisy[script.kakudaitypes[kakudai_num - 2]];
                    ktype3.text = script.kakudaisy[script.kakudaitypes[kakudai_num - 3]];
                    ktype2.text = script.kakudaisy[script.kakudaitypes[kakudai_num - 4]];
                    ktype1.text = script.kakudaisy[script.kakudaitypes[kakudai_num - 5]];
                    ((Text)btx5).text = string.Empty + script.kakudaihantei[kakudai_num - 1];
                    ((Text)btx4).text = string.Empty + script.kakudaihantei[kakudai_num - 2];
                    ((Text)btx3).text = string.Empty + script.kakudaihantei[kakudai_num - 3];
                    ((Text)btx2).text = string.Empty + script.kakudaihantei[kakudai_num - 4];
                    ((Text)btx1).text = string.Empty + script.kakudaihantei[kakudai_num - 5];
                    if (script.kakudainum[kakudai_num - 1] != null & script.kakudainum[kakudai_num - 1] != string.Empty) { bgcpic5.sprite = script2.bgs[script.kakudainum[kakudai_num - 1]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.kakudainum[kakudai_num - 2] != null & script.kakudainum[kakudai_num - 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.kakudainum[kakudai_num - 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.kakudainum[kakudai_num - 3] != null & script.kakudainum[kakudai_num - 3] != string.Empty) { bgcpic3.sprite = script2.bgs[script.kakudainum[kakudai_num - 3]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.kakudainum[kakudai_num - 4] != null & script.kakudainum[kakudai_num - 4] != string.Empty) { bgcpic2.sprite = script2.bgs[script.kakudainum[kakudai_num - 4]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.kakudainum[kakudai_num - 5] != null & script.kakudainum[kakudai_num - 5] != string.Empty) { bgcpic1.sprite = script2.bgs[script.kakudainum[kakudai_num - 5]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    kakudai.SetActive(false);
                    kakudai_num = 0;
                }
                //小パネル表示
                if (beventf == 6)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    bgw.SetActive(true);
                    if (bgsw_num == 0) { bgsw_num = textt.bgsws / 2; bgevents = new string[textt.bgsws]; }
                    bgenum5.text = "No." + (bgsw_num + 1 - 1);
                    bgenum4.text = "No." + (bgsw_num + 1 - 2);
                    bgenum3.text = "No." + (bgsw_num + 1 - 3);
                    bgenum2.text = "No." + (bgsw_num + 1 - 4);
                    bgenum1.text = "No." + (bgsw_num + 1 - 5);
                    bgetype1.text = script.beventsy[6];
                    bgetype2.text = script.beventsy[6];
                    bgetype3.text = script.beventsy[6];
                    bgetype4.text = script.beventsy[6];
                    bgetype5.text = script.beventsy[6];
                    bgevents[(bgsw_num - 1) * 2 + 1] = beventwx[9].text;
                    bgevents[(bgsw_num - 1) * 2] = beventwx[8].text;
                    bgevents[(bgsw_num - 2) * 2 + 1] = beventwx[7].text;
                    bgevents[(bgsw_num - 2) * 2] = beventwx[6].text;
                    bgevents[(bgsw_num - 3) * 2 + 1] = beventwx[5].text;
                    bgevents[(bgsw_num - 3) * 2] = beventwx[4].text;
                    bgevents[(bgsw_num - 4) * 2 + 1] = beventwx[3].text;
                    bgevents[(bgsw_num - 4) * 2] = beventwx[2].text;
                    bgevents[(bgsw_num - 5) * 2 + 1] = beventwx[1].text;
                    bgevents[(bgsw_num - 5) * 2] = beventwx[0].text;
                    ((Text)btwx10).text = string.Empty + script.bgswhantei[(bgsw_num - 1) * 2 + 1];
                    ((Text)btwx9).text = string.Empty + script.bgswhantei[(bgsw_num - 1) * 2];
                    ((Text)btwx8).text = string.Empty + script.bgswhantei[(bgsw_num - 2) * 2 + 1];
                    ((Text)btwx7).text = string.Empty + script.bgswhantei[(bgsw_num - 2) * 2];
                    ((Text)btwx6).text = string.Empty + script.bgswhantei[(bgsw_num - 3) * 2 + 1];
                    ((Text)btwx5).text = string.Empty + script.bgswhantei[(bgsw_num - 3) * 2];
                    ((Text)btwx4).text = string.Empty + script.bgswhantei[(bgsw_num - 4) * 2 + 1];
                    ((Text)btwx3).text = string.Empty + script.bgswhantei[(bgsw_num - 4) * 2];
                    ((Text)btwx2).text = string.Empty + script.bgswhantei[(bgsw_num - 5) * 2 + 1];
                    ((Text)btwx1).text = string.Empty + script.bgswhantei[(bgsw_num - 5) * 2];
                    if (script.bgswnum[(bgsw_num - 1) * 2] != null & script.bgswnum[(bgsw_num - 1) * 2] != string.Empty) { bgcpic5.sprite = script2.bgs[script.bgswnum[(bgsw_num - 1) * 2]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgswnum[(bgsw_num - 2) * 2] != null & script.bgswnum[(bgsw_num - 2) * 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.bgswnum[(bgsw_num - 2) * 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgswnum[(bgsw_num - 3) * 2] != null & script.bgswnum[(bgsw_num - 3) * 2] != string.Empty) { bgcpic3.sprite = script2.bgs[script.bgswnum[(bgsw_num - 3) * 2]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgswnum[(bgsw_num - 4) * 2] != null & script.bgswnum[(bgsw_num - 4) * 2] != string.Empty) { bgcpic2.sprite = script2.bgs[script.bgswnum[(bgsw_num - 4) * 2]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgswnum[(bgsw_num - 5) * 2] != null & script.bgswnum[(bgsw_num - 5) * 2] != string.Empty) { bgcpic1.sprite = script2.bgs[script.bgswnum[(bgsw_num - 5) * 2]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    bgw.SetActive(false);
                    bgsw_num = 0;
                }
                //大パネル表示
                if (beventf == 7)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    bgw.SetActive(true);
                    if (bglw_num == 0) { bglw_num = textt.bglws / 2; bgevents = new string[textt.bglws]; }
                    bgenum5.text = "No." + (bglw_num + 1 - 1);
                    bgenum4.text = "No." + (bglw_num + 1 - 2);
                    bgenum3.text = "No." + (bglw_num + 1 - 3);
                    bgenum2.text = "No." + (bglw_num + 1 - 4);
                    bgenum1.text = "No." + (bglw_num + 1 - 5);
                    bgetype1.text = script.beventsy[7];
                    bgetype2.text = script.beventsy[7];
                    bgetype3.text = script.beventsy[7];
                    bgetype4.text = script.beventsy[7];
                    bgetype5.text = script.beventsy[7];
                    bgevents[(bglw_num - 1) * 2 + 1] = beventwx[9].text;
                    bgevents[(bglw_num - 1) * 2] = beventwx[8].text;
                    bgevents[(bglw_num - 2) * 2 + 1] = beventwx[7].text;
                    bgevents[(bglw_num - 2) * 2] = beventwx[6].text;
                    bgevents[(bglw_num - 3) * 2 + 1] = beventwx[5].text;
                    bgevents[(bglw_num - 3) * 2] = beventwx[4].text;
                    bgevents[(bglw_num - 4) * 2 + 1] = beventwx[3].text;
                    bgevents[(bglw_num - 4) * 2] = beventwx[2].text;
                    bgevents[(bglw_num - 5) * 2 + 1] = beventwx[1].text;
                    bgevents[(bglw_num - 5) * 2] = beventwx[0].text;
                    ((Text)btwx10).text = string.Empty + script.bglwhantei[(bglw_num - 1) * 2 + 1];
                    ((Text)btwx9).text = string.Empty + script.bglwhantei[(bglw_num - 1) * 2];
                    ((Text)btwx8).text = string.Empty + script.bglwhantei[(bglw_num - 2) * 2 + 1];
                    ((Text)btwx7).text = string.Empty + script.bglwhantei[(bglw_num - 2) * 2];
                    ((Text)btwx6).text = string.Empty + script.bglwhantei[(bglw_num - 3) * 2 + 1];
                    ((Text)btwx5).text = string.Empty + script.bglwhantei[(bglw_num - 3) * 2];
                    ((Text)btwx4).text = string.Empty + script.bglwhantei[(bglw_num - 4) * 2 + 1];
                    ((Text)btwx3).text = string.Empty + script.bglwhantei[(bglw_num - 4) * 2];
                    ((Text)btwx2).text = string.Empty + script.bglwhantei[(bglw_num - 5) * 2 + 1];
                    ((Text)btwx1).text = string.Empty + script.bglwhantei[(bglw_num - 5) * 2];
                    if (script.bglwnum[(bglw_num - 1) * 2] != null & script.bglwnum[(bglw_num - 1) * 2] != string.Empty) { bgcpic5.sprite = script2.bgs[script.bglwnum[(bglw_num - 1) * 2]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bglwnum[(bglw_num - 2) * 2] != null & script.bglwnum[(bglw_num - 2) * 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.bglwnum[(bglw_num - 2) * 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bglwnum[(bglw_num - 3) * 2] != null & script.bglwnum[(bglw_num - 3) * 2] != string.Empty) { bgcpic3.sprite = script2.bgs[script.bglwnum[(bglw_num - 3) * 2]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bglwnum[(bglw_num - 4) * 2] != null & script.bglwnum[(bglw_num - 4) * 2] != string.Empty) { bgcpic2.sprite = script2.bgs[script.bglwnum[(bglw_num - 4) * 2]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bglwnum[(bglw_num - 5) * 2] != null & script.bglwnum[(bglw_num - 5) * 2] != string.Empty) { bgcpic1.sprite = script2.bgs[script.bglwnum[(bglw_num - 5) * 2]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    bgw.SetActive(false);
                    bglw_num = 0;
                }
                //グラデーション効果
                if (beventf == 8)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    bgw.SetActive(true);
                    if (bge_num == 0) { bge_num = textt.bges / 2; bgevents = new string[textt.bges]; }
                    bgenum5.text = "No." + (bge_num + 1 - 1);
                    bgenum4.text = "No." + (bge_num + 1 - 2);
                    bgenum3.text = "No." + (bge_num + 1 - 3);
                    bgenum2.text = "No." + (bge_num + 1 - 4);
                    bgenum1.text = "No." + (bge_num + 1 - 5);
                    bgetype1.text = script.beventsy[8];
                    bgetype2.text = script.beventsy[8];
                    bgetype3.text = script.beventsy[8];
                    bgetype4.text = script.beventsy[8];
                    bgetype5.text = script.beventsy[8];
                    bgevents[(bge_num - 1) * 2 + 1] = beventwx[9].text;
                    bgevents[(bge_num - 1) * 2] = beventwx[8].text;
                    bgevents[(bge_num - 2) * 2 + 1] = beventwx[7].text;
                    bgevents[(bge_num - 2) * 2] = beventwx[6].text;
                    bgevents[(bge_num - 3) * 2 + 1] = beventwx[5].text;
                    bgevents[(bge_num - 3) * 2] = beventwx[4].text;
                    bgevents[(bge_num - 4) * 2 + 1] = beventwx[3].text;
                    bgevents[(bge_num - 4) * 2] = beventwx[2].text;
                    bgevents[(bge_num - 5) * 2 + 1] = beventwx[1].text;
                    bgevents[(bge_num - 5) * 2] = beventwx[0].text;
                    ((Text)btwx10).text = string.Empty + script.bgehantei[(bge_num - 1) * 2 + 1];
                    ((Text)btwx9).text = string.Empty + script.bgehantei[(bge_num - 1) * 2];
                    ((Text)btwx8).text = string.Empty + script.bgehantei[(bge_num - 2) * 2 + 1];
                    ((Text)btwx7).text = string.Empty + script.bgehantei[(bge_num - 2) * 2];
                    ((Text)btwx6).text = string.Empty + script.bgehantei[(bge_num - 3) * 2 + 1];
                    ((Text)btwx5).text = string.Empty + script.bgehantei[(bge_num - 3) * 2];
                    ((Text)btwx4).text = string.Empty + script.bgehantei[(bge_num - 4) * 2 + 1];
                    ((Text)btwx3).text = string.Empty + script.bgehantei[(bge_num - 4) * 2];
                    ((Text)btwx2).text = string.Empty + script.bgehantei[(bge_num - 5) * 2 + 1];
                    ((Text)btwx1).text = string.Empty + script.bgehantei[(bge_num - 5) * 2];
                    if (script.bgenum[(bge_num - 1) * 2] != null & script.bgenum[(bge_num - 1) * 2] != string.Empty) { bgcpic5.sprite = script2.bgs[script.bgenum[(bge_num - 1) * 2]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgenum[(bge_num - 2) * 2] != null & script.bgenum[(bge_num - 2) * 2] != string.Empty) { bgcpic4.sprite = script2.bgs[script.bgenum[(bge_num - 2) * 2]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgenum[(bge_num - 3) * 2] != null & script.bgenum[(bge_num - 3) * 2] != string.Empty) { bgcpic3.sprite = script2.bgs[script.bgenum[(bge_num - 3) * 2]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgenum[(bge_num - 4) * 2] != null & script.bgenum[(bge_num - 4) * 2] != string.Empty) { bgcpic2.sprite = script2.bgs[script.bgenum[(bge_num - 4) * 2]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.bgenum[(bge_num - 5) * 2] != null & script.bgenum[(bge_num - 5) * 2] != string.Empty) { bgcpic1.sprite = script2.bgs[script.bgenum[(bge_num - 5) * 2]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    bgw.SetActive(false);
                    bge_num = 0;
                }
                //テキストボックス非表示
                if (beventf == 9)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgc.SetActive(true);
                    bgw.SetActive(true);
                    if (serious_num == 0) { serious_num = textt.seriouss / 2; bgevents = new string[textt.seriouss]; }
                    bgenum5.text = "No." + (serious_num + 1 - 1);
                    bgenum4.text = "No." + (serious_num + 1 - 2);
                    bgenum3.text = "No." + (serious_num + 1 - 3);
                    bgenum2.text = "No." + (serious_num + 1 - 4);
                    bgenum1.text = "No." + (serious_num + 1 - 5);
                    bgetype1.text = script.beventsy[9];
                    bgetype2.text = script.beventsy[9];
                    bgetype3.text = script.beventsy[9];
                    bgetype4.text = script.beventsy[9];
                    bgetype5.text = script.beventsy[9];
                    bgevents[(serious_num - 1) * 2 + 1] = beventwx[9].text;
                    bgevents[(serious_num - 1) * 2] = beventwx[8].text;
                    bgevents[(serious_num - 2) * 2 + 1] = beventwx[7].text;
                    bgevents[(serious_num - 2) * 2] = beventwx[6].text;
                    bgevents[(serious_num - 3) * 2 + 1] = beventwx[5].text;
                    bgevents[(serious_num - 3) * 2] = beventwx[4].text;
                    bgevents[(serious_num - 4) * 2 + 1] = beventwx[3].text;
                    bgevents[(serious_num - 4) * 2] = beventwx[2].text;
                    bgevents[(serious_num - 5) * 2 + 1] = beventwx[1].text;
                    bgevents[(serious_num - 5) * 2] = beventwx[0].text;
                    ((Text)btwx10).text = string.Empty + script.serioushantei[(serious_num - 1) * 2 + 1];
                    ((Text)btwx9).text = string.Empty + script.serioushantei[(serious_num - 1) * 2];
                    ((Text)btwx8).text = string.Empty + script.serioushantei[(serious_num - 2) * 2 + 1];
                    ((Text)btwx7).text = string.Empty + script.serioushantei[(serious_num - 2) * 2];
                    ((Text)btwx6).text = string.Empty + script.serioushantei[(serious_num - 3) * 2 + 1];
                    ((Text)btwx5).text = string.Empty + script.serioushantei[(serious_num - 3) * 2];
                    ((Text)btwx4).text = string.Empty + script.serioushantei[(serious_num - 4) * 2 + 1];
                    ((Text)btwx3).text = string.Empty + script.serioushantei[(serious_num - 4) * 2];
                    ((Text)btwx2).text = string.Empty + script.serioushantei[(serious_num - 5) * 2 + 1];
                    ((Text)btwx1).text = string.Empty + script.serioushantei[(serious_num - 5) * 2];
                }
                else
                {
                    bgw.SetActive(false);
                    serious_num = 0;
                }
                //テキスト中央表示
                if (beventf == 10)
                {
                    bedbh.SetActive(false);
                    if (eventco.bgcgcf > 0) { bebh.SetActive(false); } else { bebh.SetActive(true); }
                    bgcd.SetActive(true);
                    hazimari.SetActive(true);
                    if (hazimari_num == 0) { hazimari_num = textt.hazimaris / 2; bgevents = new string[textt.hazimaris]; }
                    bgenum5.text = "No." + (hazimari_num + 1 - 1);
                    bgenum4.text = "No." + (hazimari_num + 1 - 2);
                    bgenum3.text = "No." + (hazimari_num + 1 - 3);
                    bgenum2.text = "No." + (hazimari_num + 1 - 4);
                    bgenum1.text = "No." + (hazimari_num + 1 - 5);
                    bgetype1.text = script.beventsy[10];
                    bgetype2.text = script.beventsy[10];
                    bgetype3.text = script.beventsy[10];
                    bgetype4.text = script.beventsy[10];
                    bgetype5.text = script.beventsy[10];
                    bgevents[(hazimari_num - 1) * 2 + 1] = beventwx[9].text;
                    bgevents[(hazimari_num - 1) * 2] = beventwx[8].text;
                    bgevents[(hazimari_num - 2) * 2 + 1] = beventwx[7].text;
                    bgevents[(hazimari_num - 2) * 2] = beventwx[6].text;
                    bgevents[(hazimari_num - 3) * 2 + 1] = beventwx[5].text;
                    bgevents[(hazimari_num - 3) * 2] = beventwx[4].text;
                    bgevents[(hazimari_num - 4) * 2 + 1] = beventwx[3].text;
                    bgevents[(hazimari_num - 4) * 2] = beventwx[2].text;
                    bgevents[(hazimari_num - 5) * 2 + 1] = beventwx[1].text;
                    bgevents[(hazimari_num - 5) * 2] = beventwx[0].text;
                    ((Text)btwx10).text = string.Empty + script.hazimarihantei[(hazimari_num - 1) * 2 + 1];
                    ((Text)btwx9).text = string.Empty + script.hazimarihantei[(hazimari_num - 1) * 2];
                    ((Text)btwx8).text = string.Empty + script.hazimarihantei[(hazimari_num - 2) * 2 + 1];
                    ((Text)btwx7).text = string.Empty + script.hazimarihantei[(hazimari_num - 2) * 2];
                    ((Text)btwx6).text = string.Empty + script.hazimarihantei[(hazimari_num - 3) * 2 + 1];
                    ((Text)btwx5).text = string.Empty + script.hazimarihantei[(hazimari_num - 3) * 2];
                    ((Text)btwx4).text = string.Empty + script.hazimarihantei[(hazimari_num - 4) * 2 + 1];
                    ((Text)btwx3).text = string.Empty + script.hazimarihantei[(hazimari_num - 4) * 2];
                    ((Text)btwx2).text = string.Empty + script.hazimarihantei[(hazimari_num - 5) * 2 + 1];
                    ((Text)btwx1).text = string.Empty + script.hazimarihantei[(hazimari_num - 5) * 2];
                    if (script.hazimarinum[(hazimari_num - 1) * 2 + 1] != null & script.hazimarinum[(hazimari_num - 1) * 2 + 1] != string.Empty) { bgcpic5.sprite = script2.bgs[script.hazimarinum[(hazimari_num - 1) * 2 + 1]]; } else { bgcpic5.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.hazimarinum[(hazimari_num - 2) * 2 + 1] != null & script.hazimarinum[(hazimari_num - 2) * 2 + 1] != string.Empty) { bgcpic4.sprite = script2.bgs[script.hazimarinum[(hazimari_num - 2) * 2 + 1]]; } else { bgcpic4.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.hazimarinum[(hazimari_num - 3) * 2 + 1] != null & script.hazimarinum[(hazimari_num - 3) * 2 + 1] != string.Empty) { bgcpic3.sprite = script2.bgs[script.hazimarinum[(hazimari_num - 3) * 2 + 1]]; } else { bgcpic3.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.hazimarinum[(hazimari_num - 4) * 2 + 1] != null & script.hazimarinum[(hazimari_num - 4) * 2 + 1] != string.Empty) { bgcpic2.sprite = script2.bgs[script.hazimarinum[(hazimari_num - 4) * 2 + 1]]; } else { bgcpic2.sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (script.hazimarinum[(hazimari_num - 5) * 2 + 1] != null & script.hazimarinum[(hazimari_num - 5) * 2 + 1] != string.Empty) { bgcpic1.sprite = script2.bgs[script.hazimarinum[(hazimari_num - 5) * 2 + 1]]; } else { bgcpic1.sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                else
                {
                    hazimari.SetActive(false);
                    hazimari_num = 0;
                }
            }
            else
            {
                bge.SetActive(false);
                bgc_num = 0;
                bgcd_num = 0;
                chap_num = 0;
                chapt_num = 0;
                kakudai_num = 0;
                bgsw_num = 0;
                bglw_num = 0;
                bge_num = 0;
                serious_num = 0;
                hazimari_num = 0;
            }
            //音源設定
            if (editp == 6)
            {
                if (audioco.audiocf > 0) { aubh.SetActive(false); } else { aubh.SetActive(true); }
                audiopanel.SetActive(true);
                bgmPath = Application.dataPath + "/GAMEDATA/MUSIC/BGM";
                bgmePath = Application.dataPath + "/GAMEDATA/MUSIC/BGMEN";
                bgmefPath = Application.dataPath + "/GAMEDATA/MUSIC/BGMEF";
                string[] bgmnamem = Directory.GetFiles(bgmPath);
                string[] bgmenamem = Directory.GetFiles(bgmePath);
                string[] bgmefnamem = Directory.GetFiles(bgmefPath);
                bgmname = System.Array.FindAll(bgmnamem, t => (t.Contains(".mp3") == true | t.Contains(".wav") == true | t.Contains(".ogg") == true) & t.Contains(".meta") == false);
                bgmename = System.Array.FindAll(bgmenamem, t => (t.Contains(".mp3") == true | t.Contains(".wav") == true | t.Contains(".ogg") == true) & t.Contains(".meta") == false);
                bgmefname = System.Array.FindAll(bgmefnamem, t => (t.Contains(".mp3") == true | t.Contains(".wav") == true | t.Contains(".ogg") == true) & t.Contains(".meta") == false);
                bgmnum = bgmname.Length;
                bgmenum = bgmename.Length;
                bgmefnum = bgmefname.Length;
                Graphic atx1 = audiox1.placeholder;
                Graphic atx2 = audiox2.placeholder;
                Graphic atx3 = audiox3.placeholder;
                Graphic atx4 = audiox4.placeholder;
                Graphic atx5 = audiox5.placeholder;
                if (audioco.auf == -1)
                {
                    audiox1.text = string.Empty;
                    audiox2.text = string.Empty;
                    audiox3.text = string.Empty;
                    audiox4.text = string.Empty;
                    audiox5.text = string.Empty;
                    audioco.auf = 0;
                }
                if (audiof == 0)
                {
                    //音源ファイル
                    asempage = (bgmnum - 1) / 12 + 1;
                    if (asepage == 0) { asehidari.SetActive(false); } else { asehidari.SetActive(true); }
                    if (asepage + 1 == asempage) { asemigi.SetActive(false); } else { asemigi.SetActive(true); }
                    asept.text = "BGMファイル：" + (asepage + 1) + "/" + asempage;
                    if (bgmnum > 11 + asepage * 12) { asentaku12.text = bgmname[11 + asepage * 12].Substring(bgmname[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku12.text = "NONE"; }
                    if (bgmnum > 10 + asepage * 12) { asentaku11.text = bgmname[10 + asepage * 12].Substring(bgmname[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku11.text = "NONE"; }
                    if (bgmnum > 9 + asepage * 12) { asentaku10.text = bgmname[9 + asepage * 12].Substring(bgmname[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku10.text = "NONE"; }
                    if (bgmnum > 8 + asepage * 12) { asentaku9.text = bgmname[8 + asepage * 12].Substring(bgmname[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku9.text = "NONE"; }
                    if (bgmnum > 7 + asepage * 12) { asentaku8.text = bgmname[7 + asepage * 12].Substring(bgmname[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku8.text = "NONE"; }
                    if (bgmnum > 6 + asepage * 12) { asentaku7.text = bgmname[6 + asepage * 12].Substring(bgmname[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku7.text = "NONE"; }
                    if (bgmnum > 5 + asepage * 12) { asentaku6.text = bgmname[5 + asepage * 12].Substring(bgmname[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku6.text = "NONE"; }
                    if (bgmnum > 4 + asepage * 12) { asentaku5.text = bgmname[4 + asepage * 12].Substring(bgmname[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku5.text = "NONE"; }
                    if (bgmnum > 3 + asepage * 12) { asentaku4.text = bgmname[3 + asepage * 12].Substring(bgmname[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku4.text = "NONE"; }
                    if (bgmnum > 2 + asepage * 12) { asentaku3.text = bgmname[2 + asepage * 12].Substring(bgmname[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku3.text = "NONE"; }
                    if (bgmnum > 1 + asepage * 12) { asentaku2.text = bgmname[1 + asepage * 12].Substring(bgmname[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku2.text = "NONE"; }
                    if (bgmnum > 0 + asepage * 12) { asentaku1.text = bgmname[0 + asepage * 12].Substring(bgmname[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku1.text = "NONE"; }
                    if (bgmnum > 11 + asepage * 12) { asedntaku12.text = bgmname[11 + asepage * 12].Substring(bgmname[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku12.text = "NONE"; }
                    if (bgmnum > 10 + asepage * 12) { asedntaku11.text = bgmname[10 + asepage * 12].Substring(bgmname[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku11.text = "NONE"; }
                    if (bgmnum > 9 + asepage * 12) { asedntaku10.text = bgmname[9 + asepage * 12].Substring(bgmname[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku10.text = "NONE"; }
                    if (bgmnum > 8 + asepage * 12) { asedntaku9.text = bgmname[8 + asepage * 12].Substring(bgmname[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku9.text = "NONE"; }
                    if (bgmnum > 7 + asepage * 12) { asedntaku8.text = bgmname[7 + asepage * 12].Substring(bgmname[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku8.text = "NONE"; }
                    if (bgmnum > 6 + asepage * 12) { asedntaku7.text = bgmname[6 + asepage * 12].Substring(bgmname[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku7.text = "NONE"; }
                    if (bgmnum > 5 + asepage * 12) { asedntaku6.text = bgmname[5 + asepage * 12].Substring(bgmname[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku6.text = "NONE"; }
                    if (bgmnum > 4 + asepage * 12) { asedntaku5.text = bgmname[4 + asepage * 12].Substring(bgmname[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku5.text = "NONE"; }
                    if (bgmnum > 3 + asepage * 12) { asedntaku4.text = bgmname[3 + asepage * 12].Substring(bgmname[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku4.text = "NONE"; }
                    if (bgmnum > 2 + asepage * 12) { asedntaku3.text = bgmname[2 + asepage * 12].Substring(bgmname[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku3.text = "NONE"; }
                    if (bgmnum > 1 + asepage * 12) { asedntaku2.text = bgmname[1 + asepage * 12].Substring(bgmname[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku2.text = "NONE"; }
                    if (bgmnum > 0 + asepage * 12) { asedntaku1.text = bgmname[0 + asepage * 12].Substring(bgmname[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku1.text = "NONE"; }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 1) { audioplay[0].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[0].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 2) { audioplay[1].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[1].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 3) { audioplay[2].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[2].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 4) { audioplay[3].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[3].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 5) { audioplay[4].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[4].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 6) { audioplay[5].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[5].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 7) { audioplay[6].sprite=Resources.Load<Sprite>("UI/stop");} else { audioplay[6].sprite=Resources.Load<Sprite>("UI/go");}
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 8) { audioplay[7].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[7].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 9) { audioplay[8].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[8].sprite=Resources.Load<Sprite>("UI/go");}
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 10) { audioplay[9].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[9].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph / 12 == asepage & audioph % 12 == 11) { audioplay[10].sprite=Resources.Load<Sprite>("UI/stop"); } else { audioplay[10].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audioph & audioph > 0 & audioph / 12 == asepage + 1 & audioph % 12 == 0) { audioplay[11].sprite=Resources.Load<Sprite>("UI/stop");  } else { audioplay[11].sprite=Resources.Load<Sprite>("UI/go"); }
                    if (bgmnum >= audiopf & audiopf > 0)
                    {
                        audioe.Stop();
                        if (bgmname[audiopf - 1] != null & bgmname[audiopf - 1] != string.Empty)
                        {
                            WWW bgmu = new WWW(bgmname[audiopf - 1]);
                            audioe.clip = bgmu.GetAudioClip(true, true);
                            audioe.Play();
                        }
                        audiopf = 0;
                    }
                    if (audiosf > 0)
                    {
                        audioe.Stop();
                        audiosf = 0;
                    }
                    //登録
                    if (bgm_num == 0) { bgm_num = textt.bgms; audios = new string[textt.bgms]; }
                    audionum5.text = "No." + (bgm_num + 1 - 1);
                    audionum4.text = "No." + (bgm_num + 1 - 2);
                    audionum3.text = "No." + (bgm_num + 1 - 3);
                    audionum2.text = "No." + (bgm_num + 1 - 4);
                    audionum1.text = "No." + (bgm_num + 1 - 5);
                    audiotype1.text = script.audiosy[0];
                    audiotype2.text = script.audiosy[0];
                    audiotype3.text = script.audiosy[0];
                    audiotype4.text = script.audiosy[0];
                    audiotype5.text = script.audiosy[0];
                    audios[bgm_num - 1] = audiox5.text;
                    audios[bgm_num - 2] = audiox4.text;
                    audios[bgm_num - 3] = audiox3.text;
                    audios[bgm_num - 4] = audiox2.text;
                    audios[bgm_num - 5] = audiox1.text;
                    ((Text)atx5).text = string.Empty + script.bgmhantei[bgm_num - 1];
                    ((Text)atx4).text = string.Empty + script.bgmhantei[bgm_num - 2];
                    ((Text)atx3).text = string.Empty + script.bgmhantei[bgm_num - 3];
                    ((Text)atx2).text = string.Empty + script.bgmhantei[bgm_num - 4];
                    ((Text)atx1).text = string.Empty + script.bgmhantei[bgm_num - 5];
                    if (script.bgmnum[bgm_num - 1] != null & script.bgmnum[bgm_num - 1] != string.Empty) { audiotx5.text = script.bgmnum[bgm_num - 1].Substring(script.bgmnum[bgm_num - 1].LastIndexOf("\\") + 1); } else { audiotx5.text = "NONE"; }
                    if (script.bgmnum[bgm_num - 2] != null & script.bgmnum[bgm_num - 2] != string.Empty) { audiotx4.text = script.bgmnum[bgm_num - 2].Substring(script.bgmnum[bgm_num - 2].LastIndexOf("\\") + 1); } else { audiotx4.text = "NONE"; }
                    if (script.bgmnum[bgm_num - 3] != null & script.bgmnum[bgm_num - 3] != string.Empty) { audiotx3.text = script.bgmnum[bgm_num - 3].Substring(script.bgmnum[bgm_num - 3].LastIndexOf("\\") + 1); } else { audiotx3.text = "NONE"; }
                    if (script.bgmnum[bgm_num - 4] != null & script.bgmnum[bgm_num - 4] != string.Empty) { audiotx2.text = script.bgmnum[bgm_num - 4].Substring(script.bgmnum[bgm_num - 4].LastIndexOf("\\") + 1); } else { audiotx2.text = "NONE"; }
                    if (script.bgmnum[bgm_num - 5] != null & script.bgmnum[bgm_num - 5] != string.Empty) { audiotx1.text = script.bgmnum[bgm_num - 5].Substring(script.bgmnum[bgm_num - 5].LastIndexOf("\\") + 1); } else { audiotx1.text = "NONE"; }
                }
                if (audiof == 1)
                {
                    asempage = (bgmenum - 1) / 12 + 1;
                    if (asepage == 0) { asehidari.SetActive(false); } else { asehidari.SetActive(true); }
                    if (asepage + 1 == asempage) { asemigi.SetActive(false); } else { asemigi.SetActive(true); }
                    asept.text = "環境音ファイル：" + (asepage + 1) + "/" + asempage;
                    if (bgmenum > 11 + asepage * 12) { asentaku12.text = bgmename[11 + asepage * 12].Substring(bgmename[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku12.text = "NONE"; }
                    if (bgmenum > 10 + asepage * 12) { asentaku11.text = bgmename[10 + asepage * 12].Substring(bgmename[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku11.text = "NONE"; }
                    if (bgmenum > 9 + asepage * 12) { asentaku10.text = bgmename[9 + asepage * 12].Substring(bgmename[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku10.text = "NONE"; }
                    if (bgmenum > 8 + asepage * 12) { asentaku9.text = bgmename[8 + asepage * 12].Substring(bgmename[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku9.text = "NONE"; }
                    if (bgmenum > 7 + asepage * 12) { asentaku8.text = bgmename[7 + asepage * 12].Substring(bgmename[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku8.text = "NONE"; }
                    if (bgmenum > 6 + asepage * 12) { asentaku7.text = bgmename[6 + asepage * 12].Substring(bgmename[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku7.text = "NONE"; }
                    if (bgmenum > 5 + asepage * 12) { asentaku6.text = bgmename[5 + asepage * 12].Substring(bgmename[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku6.text = "NONE"; }
                    if (bgmenum > 4 + asepage * 12) { asentaku5.text = bgmename[4 + asepage * 12].Substring(bgmename[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku5.text = "NONE"; }
                    if (bgmenum > 3 + asepage * 12) { asentaku4.text = bgmename[3 + asepage * 12].Substring(bgmename[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku4.text = "NONE"; }
                    if (bgmenum > 2 + asepage * 12) { asentaku3.text = bgmename[2 + asepage * 12].Substring(bgmename[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku3.text = "NONE"; }
                    if (bgmenum > 1 + asepage * 12) { asentaku2.text = bgmename[1 + asepage * 12].Substring(bgmename[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku2.text = "NONE"; }
                    if (bgmenum > 0 + asepage * 12) { asentaku1.text = bgmename[0 + asepage * 12].Substring(bgmename[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku1.text = "NONE"; }
                    if (bgmenum > 11 + asepage * 12) { asedntaku12.text = bgmename[11 + asepage * 12].Substring(bgmename[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku12.text = "NONE"; }
                    if (bgmenum > 10 + asepage * 12) { asedntaku11.text = bgmename[10 + asepage * 12].Substring(bgmename[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku11.text = "NONE"; }
                    if (bgmenum > 9 + asepage * 12) { asedntaku10.text = bgmename[9 + asepage * 12].Substring(bgmename[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku10.text = "NONE"; }
                    if (bgmenum > 8 + asepage * 12) { asedntaku9.text = bgmename[8 + asepage * 12].Substring(bgmename[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku9.text = "NONE"; }
                    if (bgmenum > 7 + asepage * 12) { asedntaku8.text = bgmename[7 + asepage * 12].Substring(bgmename[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku8.text = "NONE"; }
                    if (bgmenum > 6 + asepage * 12) { asedntaku7.text = bgmename[6 + asepage * 12].Substring(bgmename[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku7.text = "NONE"; }
                    if (bgmenum > 5 + asepage * 12) { asedntaku6.text = bgmename[5 + asepage * 12].Substring(bgmename[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku6.text = "NONE"; }
                    if (bgmenum > 4 + asepage * 12) { asedntaku5.text = bgmename[4 + asepage * 12].Substring(bgmename[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku5.text = "NONE"; }
                    if (bgmenum > 3 + asepage * 12) { asedntaku4.text = bgmename[3 + asepage * 12].Substring(bgmename[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku4.text = "NONE"; }
                    if (bgmenum > 2 + asepage * 12) { asedntaku3.text = bgmename[2 + asepage * 12].Substring(bgmename[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku3.text = "NONE"; }
                    if (bgmenum > 1 + asepage * 12) { asedntaku2.text = bgmename[1 + asepage * 12].Substring(bgmename[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku2.text = "NONE"; }
                    if (bgmenum > 0 + asepage * 12) { asedntaku1.text = bgmename[0 + asepage * 12].Substring(bgmename[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku1.text = "NONE"; }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 1) { audioplay[0].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[0].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 2) { audioplay[1].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[1].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 3) { audioplay[2].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[2].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 4) { audioplay[3].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[3].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 5) { audioplay[4].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[4].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 6) { audioplay[5].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[5].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 7) { audioplay[6].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[6].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 8) { audioplay[7].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[7].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 9) { audioplay[8].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[8].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 10) { audioplay[9].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[9].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph / 12 == asepage & audioph % 12 == 11) { audioplay[10].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[10].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audioph & audioph > 0 & audioph / 12 == asepage + 1 & audioph % 12 == 0) { audioplay[11].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[11].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmenum >= audiopf & audiopf > 0)
                    {
                        audioe.Stop();
                        if (bgmename[audiopf - 1] != null & bgmename[audiopf - 1] != string.Empty)
                        {

                            WWW bgmeu = new WWW(bgmename[audiopf - 1]);
                            audioe.clip = bgmeu.GetAudioClip(true, true);
                            audioe.Play();
                        }
                        audiopf = 0;
                    }
                    if (audiosf > 0)
                    {
                        audioe.Stop();
                        audiosf = 0;
                    }
                    //登録
                    if (bgme_num == 0) { bgme_num = textt.bgmes; audios = new string[textt.bgmes]; }
                    audionum5.text = "No." + (bgme_num + 1 - 1);
                    audionum4.text = "No." + (bgme_num + 1 - 2);
                    audionum3.text = "No." + (bgme_num + 1 - 3);
                    audionum2.text = "No." + (bgme_num + 1 - 4);
                    audionum1.text = "No." + (bgme_num + 1 - 5);
                    audiotype1.text = script.audiosy[1];
                    audiotype2.text = script.audiosy[1];
                    audiotype3.text = script.audiosy[1];
                    audiotype4.text = script.audiosy[1];
                    audiotype5.text = script.audiosy[1];
                    audios[bgme_num - 1] = audiox5.text;
                    audios[bgme_num - 2] = audiox4.text;
                    audios[bgme_num - 3] = audiox3.text;
                    audios[bgme_num - 4] = audiox2.text;
                    audios[bgme_num - 5] = audiox1.text;
                    ((Text)atx5).text = string.Empty + script.bgmehantei[bgme_num - 1];
                    ((Text)atx4).text = string.Empty + script.bgmehantei[bgme_num - 2];
                    ((Text)atx3).text = string.Empty + script.bgmehantei[bgme_num - 3];
                    ((Text)atx2).text = string.Empty + script.bgmehantei[bgme_num - 4];
                    ((Text)atx1).text = string.Empty + script.bgmehantei[bgme_num - 5];
                    if (script.bgmenum[bgme_num - 1] != null & script.bgmenum[bgme_num - 1] != string.Empty) { audiotx5.text = script.bgmenum[bgme_num - 1].Substring(script.bgmenum[bgme_num - 1].LastIndexOf("\\") + 1); } else { audiotx5.text = "NONE"; }
                    if (script.bgmenum[bgme_num - 2] != null & script.bgmenum[bgme_num - 2] != string.Empty) { audiotx4.text = script.bgmenum[bgme_num - 2].Substring(script.bgmenum[bgme_num - 2].LastIndexOf("\\") + 1); } else { audiotx4.text = "NONE"; }
                    if (script.bgmenum[bgme_num - 3] != null & script.bgmenum[bgme_num - 3] != string.Empty) { audiotx3.text = script.bgmenum[bgme_num - 3].Substring(script.bgmenum[bgme_num - 3].LastIndexOf("\\") + 1); } else { audiotx3.text = "NONE"; }
                    if (script.bgmenum[bgme_num - 4] != null & script.bgmenum[bgme_num - 4] != string.Empty) { audiotx2.text = script.bgmenum[bgme_num - 4].Substring(script.bgmenum[bgme_num - 4].LastIndexOf("\\") + 1); } else { audiotx2.text = "NONE"; }
                    if (script.bgmenum[bgme_num - 5] != null & script.bgmenum[bgme_num - 5] != string.Empty) { audiotx1.text = script.bgmenum[bgme_num - 5].Substring(script.bgmenum[bgme_num - 5].LastIndexOf("\\") + 1); } else { audiotx1.text = "NONE"; }
                }
                if (audiof == 2)
                {
                    asempage = (bgmefnum - 1) / 12 + 1;
                    if (asepage == 0) { asehidari.SetActive(false); } else { asehidari.SetActive(true); }
                    if (asepage + 1 == asempage) { asemigi.SetActive(false); } else { asemigi.SetActive(true); }
                    asept.text = "効果音ファイル：" + (asepage + 1) + "/" + asempage;
                    if (bgmefnum > 11 + asepage * 12) { asentaku12.text = bgmefname[11 + asepage * 12].Substring(bgmefname[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku12.text = "NONE"; }
                    if (bgmefnum > 10 + asepage * 12) { asentaku11.text = bgmefname[10 + asepage * 12].Substring(bgmefname[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku11.text = "NONE"; }
                    if (bgmefnum > 9 + asepage * 12) { asentaku10.text = bgmefname[9 + asepage * 12].Substring(bgmefname[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku10.text = "NONE"; }
                    if (bgmefnum > 8 + asepage * 12) { asentaku9.text = bgmefname[8 + asepage * 12].Substring(bgmefname[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku9.text = "NONE"; }
                    if (bgmefnum > 7 + asepage * 12) { asentaku8.text = bgmefname[7 + asepage * 12].Substring(bgmefname[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku8.text = "NONE"; }
                    if (bgmefnum > 6 + asepage * 12) { asentaku7.text = bgmefname[6 + asepage * 12].Substring(bgmefname[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku7.text = "NONE"; }
                    if (bgmefnum > 5 + asepage * 12) { asentaku6.text = bgmefname[5 + asepage * 12].Substring(bgmefname[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku6.text = "NONE"; }
                    if (bgmefnum > 4 + asepage * 12) { asentaku5.text = bgmefname[4 + asepage * 12].Substring(bgmefname[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku5.text = "NONE"; }
                    if (bgmefnum > 3 + asepage * 12) { asentaku4.text = bgmefname[3 + asepage * 12].Substring(bgmefname[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku4.text = "NONE"; }
                    if (bgmefnum > 2 + asepage * 12) { asentaku3.text = bgmefname[2 + asepage * 12].Substring(bgmefname[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku3.text = "NONE"; }
                    if (bgmefnum > 1 + asepage * 12) { asentaku2.text = bgmefname[1 + asepage * 12].Substring(bgmefname[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku2.text = "NONE"; }
                    if (bgmefnum > 0 + asepage * 12) { asentaku1.text = bgmefname[0 + asepage * 12].Substring(bgmefname[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asentaku1.text = "NONE"; }
                    if (bgmefnum > 11 + asepage * 12) { asedntaku12.text = bgmefname[11 + asepage * 12].Substring(bgmefname[11 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku12.text = "NONE"; }
                    if (bgmefnum > 10 + asepage * 12) { asedntaku11.text = bgmefname[10 + asepage * 12].Substring(bgmefname[10 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku11.text = "NONE"; }
                    if (bgmefnum > 9 + asepage * 12) { asedntaku10.text = bgmefname[9 + asepage * 12].Substring(bgmefname[9 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku10.text = "NONE"; }
                    if (bgmefnum > 8 + asepage * 12) { asedntaku9.text = bgmefname[8 + asepage * 12].Substring(bgmefname[8 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku9.text = "NONE"; }
                    if (bgmefnum > 7 + asepage * 12) { asedntaku8.text = bgmefname[7 + asepage * 12].Substring(bgmefname[7 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku8.text = "NONE"; }
                    if (bgmefnum > 6 + asepage * 12) { asedntaku7.text = bgmefname[6 + asepage * 12].Substring(bgmefname[6 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku7.text = "NONE"; }
                    if (bgmefnum > 5 + asepage * 12) { asedntaku6.text = bgmefname[5 + asepage * 12].Substring(bgmefname[5 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku6.text = "NONE"; }
                    if (bgmefnum > 4 + asepage * 12) { asedntaku5.text = bgmefname[4 + asepage * 12].Substring(bgmefname[4 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku5.text = "NONE"; }
                    if (bgmefnum > 3 + asepage * 12) { asedntaku4.text = bgmefname[3 + asepage * 12].Substring(bgmefname[3 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku4.text = "NONE"; }
                    if (bgmefnum > 2 + asepage * 12) { asedntaku3.text = bgmefname[2 + asepage * 12].Substring(bgmefname[2 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku3.text = "NONE"; }
                    if (bgmefnum > 1 + asepage * 12) { asedntaku2.text = bgmefname[1 + asepage * 12].Substring(bgmefname[1 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku2.text = "NONE"; }
                    if (bgmefnum > 0 + asepage * 12) { asedntaku1.text = bgmefname[0 + asepage * 12].Substring(bgmefname[0 + asepage * 12].LastIndexOf("\\") + 1); } else { asedntaku1.text = "NONE"; }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 1) { audioplay[0].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[0].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 2) { audioplay[1].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[1].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 3) { audioplay[2].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[2].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 4) { audioplay[3].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[3].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 5) { audioplay[4].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[4].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 6) { audioplay[5].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[5].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 7) { audioplay[6].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[6].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 8) { audioplay[7].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[7].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 9) { audioplay[8].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[8].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 10) { audioplay[9].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[9].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph / 12 == asepage & audioph % 12 == 11) { audioplay[10].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[10].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audioph & audioph > 0 & audioph / 12 == asepage + 1 & audioph % 12 == 0) { audioplay[11].sprite = Resources.Load<Sprite>("UI/stop"); } else { audioplay[11].sprite = Resources.Load<Sprite>("UI/go"); }
                    if (bgmefnum >= audiopf & audiopf > 0)
                    {
                        audioe.Stop();
                        if (bgmefname[audiopf - 1] != null & bgmefname[audiopf - 1] != string.Empty)
                        {

                            WWW bgmefu = new WWW(bgmefname[audiopf - 1]);
                            audioe.clip = bgmefu.GetAudioClip(true, true);
                            audioe.Play();
                        }
                        audiopf = 0;
                    }
                    if (audiosf > 0)
                    {
                        audioe.Stop();
                        audiosf = 0;
                    }
                    //登録
                    if (bgmef_num == 0) { bgmef_num = textt.bgmefs; audios = new string[textt.bgmefs]; }
                    audionum5.text = "No." + (bgmef_num + 1 - 1);
                    audionum4.text = "No." + (bgmef_num + 1 - 2);
                    audionum3.text = "No." + (bgmef_num + 1 - 3);
                    audionum2.text = "No." + (bgmef_num + 1 - 4);
                    audionum1.text = "No." + (bgmef_num + 1 - 5);
                    audiotype1.text = script.audiosy[2];
                    audiotype2.text = script.audiosy[2];
                    audiotype3.text = script.audiosy[2];
                    audiotype4.text = script.audiosy[2];
                    audiotype5.text = script.audiosy[2];
                    audios[bgmef_num - 1] = audiox5.text;
                    audios[bgmef_num - 2] = audiox4.text;
                    audios[bgmef_num - 3] = audiox3.text;
                    audios[bgmef_num - 4] = audiox2.text;
                    audios[bgmef_num - 5] = audiox1.text;
                    ((Text)atx5).text = string.Empty + script.bgmefhantei[bgmef_num - 1];
                    ((Text)atx4).text = string.Empty + script.bgmefhantei[bgmef_num - 2];
                    ((Text)atx3).text = string.Empty + script.bgmefhantei[bgmef_num - 3];
                    ((Text)atx2).text = string.Empty + script.bgmefhantei[bgmef_num - 4];
                    ((Text)atx1).text = string.Empty + script.bgmefhantei[bgmef_num - 5];
                    if (script.bgmefnum[bgmef_num - 1] != null & script.bgmefnum[bgmef_num - 1] != string.Empty) { audiotx5.text = script.bgmefnum[bgmef_num - 1].Substring(script.bgmefnum[bgmef_num - 1].LastIndexOf("\\") + 1); } else { audiotx5.text = "NONE"; }
                    if (script.bgmefnum[bgmef_num - 2] != null & script.bgmefnum[bgmef_num - 2] != string.Empty) { audiotx4.text = script.bgmefnum[bgmef_num - 2].Substring(script.bgmefnum[bgmef_num - 2].LastIndexOf("\\") + 1); } else { audiotx4.text = "NONE"; }
                    if (script.bgmefnum[bgmef_num - 3] != null & script.bgmefnum[bgmef_num - 3] != string.Empty) { audiotx3.text = script.bgmefnum[bgmef_num - 3].Substring(script.bgmefnum[bgmef_num - 3].LastIndexOf("\\") + 1); } else { audiotx3.text = "NONE"; }
                    if (script.bgmefnum[bgmef_num - 4] != null & script.bgmefnum[bgmef_num - 4] != string.Empty) { audiotx2.text = script.bgmefnum[bgmef_num - 4].Substring(script.bgmefnum[bgmef_num - 4].LastIndexOf("\\") + 1); } else { audiotx2.text = "NONE"; }
                    if (script.bgmefnum[bgmef_num - 5] != null & script.bgmefnum[bgmef_num - 5] != string.Empty) { audiotx1.text = script.bgmefnum[bgmef_num - 5].Substring(script.bgmefnum[bgmef_num - 5].LastIndexOf("\\") + 1); } else { audiotx1.text = "NONE"; }
                }
            }
            else
            {
                audioe.Stop();
                audioco.audiocf = 0;
                audioco.audiosef = 0;
                audioco.audiosebf = 0;
                bgm_num = 0;
                bgme_num = 0;
                bgmef_num = 0;
                audiopf = 0;
                audiosf = 0;
                audioph = 0;
                audiopanel.SetActive(false);
            }
            //映像
            if (editp == 7)
            {
                videopanel.SetActive(true);
                if (audioco.videocf > 0) { vibh.SetActive(false); } else { vibh.SetActive(true); }
                videoPath = Application.dataPath + "/GAMEDATA/Video";
                string[] videonamem = Directory.GetFiles(videoPath);
                videoname = System.Array.FindAll(videonamem, t => t.Contains(".mp4") == true & t.Contains(".meta") == false);
                videonum = videoname.Length;
                vsempage = (videonum - 1) / 12 + 1;
                Graphic vtx1 = videox1.placeholder;
                Graphic vtx2 = videox2.placeholder;
                Graphic vtx3 = videox3.placeholder;
                Graphic vtx4 = videox4.placeholder;
                Graphic vtx5 = videox5.placeholder;
                if (audioco.vif == -1)
                {
                    videox1.text = string.Empty;
                    videox2.text = string.Empty;
                    videox3.text = string.Empty;
                    videox4.text = string.Empty;
                    videox5.text = string.Empty;
                    audioco.vif = 0;
                }
                vsept.text = "映像ファイル：" + (vsepage + 1) + "/" + vsempage;
                if (vsepage == 0) { vsehidari.SetActive(false); } else { vsehidari.SetActive(true); }
                if (vsepage + 1 == vsempage) { vsemigi.SetActive(false); } else { vsemigi.SetActive(true); }
                if (videonum > 11 + vsepage * 12) { vsentaku12.text = videoname[11 + vsepage * 12].Substring(videoname[11 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku12.text = "NONE"; }
                if (videonum > 10 + vsepage * 12) { vsentaku11.text = videoname[10 + vsepage * 12].Substring(videoname[10 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku11.text = "NONE"; }
                if (videonum > 9 + vsepage * 12) { vsentaku10.text = videoname[9 + vsepage * 12].Substring(videoname[9 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku10.text = "NONE"; }
                if (videonum > 8 + vsepage * 12) { vsentaku9.text = videoname[8 + vsepage * 12].Substring(videoname[8 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku9.text = "NONE"; }
                if (videonum > 7 + vsepage * 12) { vsentaku8.text = videoname[7 + vsepage * 12].Substring(videoname[7 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku8.text = "NONE"; }
                if (videonum > 6 + vsepage * 12) { vsentaku7.text = videoname[6 + vsepage * 12].Substring(videoname[6 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku7.text = "NONE"; }
                if (videonum > 5 + vsepage * 12) { vsentaku6.text = videoname[5 + vsepage * 12].Substring(videoname[5 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku6.text = "NONE"; }
                if (videonum > 4 + vsepage * 12) { vsentaku5.text = videoname[4 + vsepage * 12].Substring(videoname[4 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku5.text = "NONE"; }
                if (videonum > 3 + vsepage * 12) { vsentaku4.text = videoname[3 + vsepage * 12].Substring(videoname[3 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku4.text = "NONE"; }
                if (videonum > 2 + vsepage * 12) { vsentaku3.text = videoname[2 + vsepage * 12].Substring(videoname[2 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku3.text = "NONE"; }
                if (videonum > 1 + vsepage * 12) { vsentaku2.text = videoname[1 + vsepage * 12].Substring(videoname[1 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku2.text = "NONE"; }
                if (videonum > 0 + vsepage * 12) { vsentaku1.text = videoname[0 + vsepage * 12].Substring(videoname[0 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsentaku1.text = "NONE"; }
                if (videonum > 11 + vsepage * 12) { vsedntaku12.text = videoname[11 + vsepage * 12].Substring(videoname[11 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku12.text = "NONE"; }
                if (videonum > 10 + vsepage * 12) { vsedntaku11.text = videoname[10 + vsepage * 12].Substring(videoname[10 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku11.text = "NONE"; }
                if (videonum > 9 + vsepage * 12) { vsedntaku10.text = videoname[9 + vsepage * 12].Substring(videoname[9 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku10.text = "NONE"; }
                if (videonum > 8 + vsepage * 12) { vsedntaku9.text = videoname[8 + vsepage * 12].Substring(videoname[8 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku9.text = "NONE"; }
                if (videonum > 7 + vsepage * 12) { vsedntaku8.text = videoname[7 + vsepage * 12].Substring(videoname[7 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku8.text = "NONE"; }
                if (videonum > 6 + vsepage * 12) { vsedntaku7.text = videoname[6 + vsepage * 12].Substring(videoname[6 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku7.text = "NONE"; }
                if (videonum > 5 + vsepage * 12) { vsedntaku6.text = videoname[5 + vsepage * 12].Substring(videoname[5 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku6.text = "NONE"; }
                if (videonum > 4 + vsepage * 12) { vsedntaku5.text = videoname[4 + vsepage * 12].Substring(videoname[4 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku5.text = "NONE"; }
                if (videonum > 3 + vsepage * 12) { vsedntaku4.text = videoname[3 + vsepage * 12].Substring(videoname[3 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku4.text = "NONE"; }
                if (videonum > 2 + vsepage * 12) { vsedntaku3.text = videoname[2 + vsepage * 12].Substring(videoname[2 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku3.text = "NONE"; }
                if (videonum > 1 + vsepage * 12) { vsedntaku2.text = videoname[1 + vsepage * 12].Substring(videoname[1 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku2.text = "NONE"; }
                if (videonum > 0 + vsepage * 12) { vsedntaku1.text = videoname[0 + vsepage * 12].Substring(videoname[0 + vsepage * 12].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { vsedntaku1.text = "NONE"; }
                if (video_num == 0) { video_num = textt.videos; videos = new string[textt.videos]; }
                videonum5.text = "No." + (video_num + 1 - 1);
                videonum4.text = "No." + (video_num + 1 - 2);
                videonum3.text = "No." + (video_num + 1 - 3);
                videonum2.text = "No." + (video_num + 1 - 4);
                videonum1.text = "No." + (video_num + 1 - 5);
                videotype1.text = script.videosy[0];
                videotype2.text = script.videosy[0];
                videotype3.text = script.videosy[0];
                videotype4.text = script.videosy[0];
                videotype5.text = script.videosy[0];
                videos[video_num - 1] = videox5.text;
                videos[video_num - 2] = videox4.text;
                videos[video_num - 3] = videox3.text;
                videos[video_num - 4] = videox2.text;
                videos[video_num - 5] = videox1.text;
                ((Text)vtx5).text = string.Empty + script.videohantei[video_num - 1];
                ((Text)vtx4).text = string.Empty + script.videohantei[video_num - 2];
                ((Text)vtx3).text = string.Empty + script.videohantei[video_num - 3];
                ((Text)vtx2).text = string.Empty + script.videohantei[video_num - 4];
                ((Text)vtx1).text = string.Empty + script.videohantei[video_num - 5];
                if (script.videonum[video_num - 1] != null & script.videonum[video_num - 1] != string.Empty) { videotx5.text = script.videonum[video_num - 1].Substring(script.videonum[video_num - 1].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videotx5.text = "NONE"; }
                if (script.videonum[video_num - 2] != null & script.videonum[video_num - 2] != string.Empty) { videotx4.text = script.videonum[video_num - 2].Substring(script.videonum[video_num - 2].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videotx4.text = "NONE"; }
                if (script.videonum[video_num - 3] != null & script.videonum[video_num - 3] != string.Empty) { videotx3.text = script.videonum[video_num - 3].Substring(script.videonum[video_num - 3].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videotx3.text = "NONE"; }
                if (script.videonum[video_num - 4] != null & script.videonum[video_num - 4] != string.Empty) { videotx2.text = script.videonum[video_num - 4].Substring(script.videonum[video_num - 4].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videotx2.text = "NONE"; }
                if (script.videonum[video_num - 5] != null & script.videonum[video_num - 5] != string.Empty) { videotx1.text = script.videonum[video_num - 5].Substring(script.videonum[video_num - 5].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videotx1.text = "NONE"; }
                if (videoph >= 1) { videoplay.sprite = Resources.Load<Sprite>("UI/stop"); } else { videoplay.sprite = Resources.Load<Sprite>("UI/go"); }
                if (videoph == 0) { videonpanel.SetActive(true); if (audioco.videoonf > 0) { videoont.text = "選択中のビデオ:" + videoname[audioco.videoonf - 1].Substring(videoname[audioco.videoonf - 1].LastIndexOf("\\") + 1).Replace(".mp4", string.Empty); } else { videoont.text = "未選択"; } } else { videonpanel.SetActive(false); }
                if (audioco.videoonf > 0 & videopf > 0)
                {
                    if (videoname[audioco.videoonf - 1] != null & videoname[audioco.videoonf - 1] != string.Empty)
                    {
                        video.Stop();
                        string videou = videoname[audioco.videoonf - 1];
                        video.url = videou;
                        videoph = 1;
                        video.Play();
                    }
                    videopf = 0;
                }
                if (video.isPlaying == true)
                {
                    videof += Time.deltaTime;
                }
                if (videosf > 0 | (videof > 5 & videof >= video.length))
                {
                    video.Stop();
                    videof = 0;
                    videoph = 0;
                    videosf = 0;
                }
            }
            else
            {
                video.Stop();
                audioco.videoonf = 0;
                audioco.videocf = 0;
                audioco.videosebf = 0;
                videoph = 0;
                videopf = 0;
                videosf = 0;
                video_num = 0;
                videopanel.SetActive(false);
            }
            //セーブロード
            if (editp == 5)
            {
                data.SetActive(true);
                ctname = ctny.text;
                jssname = jssny.text;
              
                if (cf > 0)
                {
                    ctny.text = null;
                    jssny.text = null;
                    cf = 0;
                }
                if (esaveco.useflag == 0 & esaveco.jsonflag == 0 & esaveco.txtflag == 0)
                {
                    filepanel.SetActive(false);
                    esaveco.sentakujsonf = 0;
                    esaveco.sentakutxtf = 0;
                }
                if (esaveco.useflag == 1 | esaveco.jsonflag == 1)
                {
                    if (esaveco.useflag == 1)
                    {
                        jssny.text = null;
                    }
                    if (esaveco.jsonflag == 1)
                    {
                        ctny.text = null;
                    }
                    esaveco.sentakujsonf = 0;
                    jsonPath = Application.dataPath + "/SAVEDATA/json/part/";
                    string[] jsonnamem = Directory.GetFiles(jsonPath);
                    jsonname = System.Array.FindAll(jsonnamem, t => t.Contains(".meta") == false & t.Contains("/.json") == false);
                    filepanel.SetActive(true);
                    jsonnum = jsonname.Length;
                    tsempage = (jsonnum - 1) / 12 + 1;
                    if (tsepage < 1)
                    {
                        tsem.SetActive(false);
                    }
                    else
                    {
                        tsem.SetActive(true);
                    }
                    if (tsepage + 2 > tsempage)
                    {
                        tset.SetActive(false);
                    }
                    else
                    {
                        tset.SetActive(true);
                    }
                    tsepp.text = tsepage + 1 + "/" + tsempage;

                    tpanelt.text = "jsonファイル";
                    if (jsonnum > 11 + tsepage * 12) { tsentaku12.text = jsonname[11 + tsepage * 12].Substring(jsonname[11 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku12.text = "NONE"; }
                    if (jsonnum > 10 + tsepage * 12) { tsentaku11.text = jsonname[10 + tsepage * 12].Substring(jsonname[10 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku11.text = "NONE"; }
                    if (jsonnum > 9 + tsepage * 12) { tsentaku10.text = jsonname[9 + tsepage * 12].Substring(jsonname[9 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku10.text = "NONE"; }
                    if (jsonnum > 8 + tsepage * 12) { tsentaku9.text = jsonname[8 + tsepage * 12].Substring(jsonname[8 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku9.text = "NONE"; }
                    if (jsonnum > 7 + tsepage * 12) { tsentaku8.text = jsonname[7 + tsepage * 12].Substring(jsonname[7 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku8.text = "NONE"; }
                    if (jsonnum > 6 + tsepage * 12) { tsentaku7.text = jsonname[6 + tsepage * 12].Substring(jsonname[6 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku7.text = "NONE"; }
                    if (jsonnum > 5 + tsepage * 12) { tsentaku6.text = jsonname[5 + tsepage * 12].Substring(jsonname[5 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku6.text = "NONE"; }
                    if (jsonnum > 4 + tsepage * 12) { tsentaku5.text = jsonname[4 + tsepage * 12].Substring(jsonname[4 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku5.text = "NONE"; }
                    if (jsonnum > 3 + tsepage * 12) { tsentaku4.text = jsonname[3 + tsepage * 12].Substring(jsonname[3 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku4.text = "NONE"; }
                    if (jsonnum > 2 + tsepage * 12) { tsentaku3.text = jsonname[2 + tsepage * 12].Substring(jsonname[2 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku3.text = "NONE"; }
                    if (jsonnum > 1 + tsepage * 12) { tsentaku2.text = jsonname[1 + tsepage * 12].Substring(jsonname[1 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku2.text = "NONE"; }
                    if (jsonnum > 0 + tsepage * 12) { tsentaku1.text = jsonname[0 + tsepage * 12].Substring(jsonname[0 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku1.text = "NONE"; }
                }
                if (esaveco.txtflag == 1)
                {
                    jssny.text = null;
                    esaveco.sentakutxtf = 0;
                    txtPath = Application.dataPath + "/SAVEDATA/txt/";
                    string[] txtnamem = Directory.GetFiles(txtPath);
                    txtname = System.Array.FindAll(txtnamem, t => t.Contains(".meta") == false);
                    filepanel.SetActive(true);
                    txtnum = txtname.Length;
                    tsempage = (txtnum - 1) / 12 + 1;
                    if (tsepage < 1)
                    {
                        tsem.SetActive(false);
                    }
                    else
                    {
                        tsem.SetActive(true);
                    }
                    if (tsepage + 2 > tsempage)
                    {
                        tset.SetActive(false);
                    }
                    else
                    {
                        tset.SetActive(true);
                    }
                    tsepp.text = tsepage + 1 + "/" + tsempage;

                    tpanelt.text = "txtファイル";
                    if (txtnum > 11 + tsepage * 12) { tsentaku12.text = txtname[11 + tsepage * 12].Substring(txtname[11 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku12.text = "NONE"; }
                    if (txtnum > 10 + tsepage * 12) { tsentaku11.text = txtname[10 + tsepage * 12].Substring(txtname[10 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku11.text = "NONE"; }
                    if (txtnum > 9 + tsepage * 12) { tsentaku10.text = txtname[9 + tsepage * 12].Substring(txtname[9 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku10.text = "NONE"; }
                    if (txtnum > 8 + tsepage * 12) { tsentaku9.text = txtname[8 + tsepage * 12].Substring(txtname[8 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku9.text = "NONE"; }
                    if (txtnum > 7 + tsepage * 12) { tsentaku8.text = txtname[7 + tsepage * 12].Substring(txtname[7 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku8.text = "NONE"; }
                    if (txtnum > 6 + tsepage * 12) { tsentaku7.text = txtname[6 + tsepage * 12].Substring(txtname[6 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku7.text = "NONE"; }
                    if (txtnum > 5 + tsepage * 12) { tsentaku6.text = txtname[5 + tsepage * 12].Substring(txtname[5 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku6.text = "NONE"; }
                    if (txtnum > 4 + tsepage * 12) { tsentaku5.text = txtname[4 + tsepage * 12].Substring(txtname[4 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku5.text = "NONE"; }
                    if (txtnum > 3 + tsepage * 12) { tsentaku4.text = txtname[3 + tsepage * 12].Substring(txtname[3 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku4.text = "NONE"; }
                    if (txtnum > 2 + tsepage * 12) { tsentaku3.text = txtname[2 + tsepage * 12].Substring(txtname[2 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku3.text = "NONE"; }
                    if (txtnum > 1 + tsepage * 12) { tsentaku2.text = txtname[1 + tsepage * 12].Substring(txtname[1 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku2.text = "NONE"; }
                    if (txtnum > 0 + tsepage * 12) { tsentaku1.text = txtname[0 + tsepage * 12].Substring(txtname[0 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku1.text = "NONE"; }
                }
            }
            else
            {
                data.SetActive(false);
            }
        }
        else
        {
            teditpanel.SetActive(false);
        }
        //全体データ編集
        if (editf == 2)
        {
            edittitle.text = "ー全体データ編集―";
            deditpanel.SetActive(true);
            //選択肢
            if (editp == 10)
            {
                if (esaveco.useflag > 0)
                {
                    esaveco.sentakujsonf = 0;
                    jsonPath = Application.dataPath + "/SAVEDATA/json/part/";
                    string[] sjsonnamem = Directory.GetFiles(jsonPath);
                    jsonname = System.Array.FindAll(sjsonnamem, t => t.Contains(".meta") == false & t.Contains("/.json") == false);
                    filepanel.SetActive(true);
                    jsonnum = jsonname.Length;
                    tsempage = (jsonnum - 1) / 12 + 1;
                    if (tsepage < 1)
                    {
                        tsem.SetActive(false);
                    }
                    else
                    {
                        tsem.SetActive(true);
                    }
                    if (tsepage + 2 > tsempage)
                    {
                        tset.SetActive(false);
                    }
                    else
                    {
                        tset.SetActive(true);
                    }
                    tsepp.text = tsepage + 1 + "/" + tsempage;

                    tpanelt.text = "jsonファイル";
                    if (jsonnum > 11 + tsepage * 12) { tsentaku12.text = jsonname[11 + tsepage * 12].Substring(jsonname[11 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku12.text = "NONE"; }
                    if (jsonnum > 10 + tsepage * 12) { tsentaku11.text = jsonname[10 + tsepage * 12].Substring(jsonname[10 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku11.text = "NONE"; }
                    if (jsonnum > 9 + tsepage * 12) { tsentaku10.text = jsonname[9 + tsepage * 12].Substring(jsonname[9 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku10.text = "NONE"; }
                    if (jsonnum > 8 + tsepage * 12) { tsentaku9.text = jsonname[8 + tsepage * 12].Substring(jsonname[8 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku9.text = "NONE"; }
                    if (jsonnum > 7 + tsepage * 12) { tsentaku8.text = jsonname[7 + tsepage * 12].Substring(jsonname[7 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku8.text = "NONE"; }
                    if (jsonnum > 6 + tsepage * 12) { tsentaku7.text = jsonname[6 + tsepage * 12].Substring(jsonname[6 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku7.text = "NONE"; }
                    if (jsonnum > 5 + tsepage * 12) { tsentaku6.text = jsonname[5 + tsepage * 12].Substring(jsonname[5 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku6.text = "NONE"; }
                    if (jsonnum > 4 + tsepage * 12) { tsentaku5.text = jsonname[4 + tsepage * 12].Substring(jsonname[4 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku5.text = "NONE"; }
                    if (jsonnum > 3 + tsepage * 12) { tsentaku4.text = jsonname[3 + tsepage * 12].Substring(jsonname[3 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku4.text = "NONE"; }
                    if (jsonnum > 2 + tsepage * 12) { tsentaku3.text = jsonname[2 + tsepage * 12].Substring(jsonname[2 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku3.text = "NONE"; }
                    if (jsonnum > 1 + tsepage * 12) { tsentaku2.text = jsonname[1 + tsepage * 12].Substring(jsonname[1 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku2.text = "NONE"; }
                    if (jsonnum > 0 + tsepage * 12) { tsentaku1.text = jsonname[0 + tsepage * 12].Substring(jsonname[0 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku1.text = "NONE"; }
                }
                else
                {
                    filepanel.SetActive(false);
                }
                sentaku.SetActive(true);
                if (sentaku_num == 0) { sentaku_num = textt.sentakus; sentakut_num = textt.sentakus * 2; sentakuts = new string[textt.sentakus]; sentakubs = new string[textt.sentakus * 2]; sentakuds = new string[textt.sentakus * 2]; }
                sentaku.SetActive(true);
                sentakunum[4].text = "No." + (sentaku_num + 1 - 1);
                sentakunum[3].text = "No." + (sentaku_num + 1 - 2);
                sentakunum[2].text = "No." + (sentaku_num + 1 - 3);
                sentakunum[1].text = "No." + (sentaku_num + 1 - 4);
                sentakunum[0].text = "No." + (sentaku_num + 1 - 5);
                sentakutype[4].text = script.sentakuknum[sentaku_num - 1];
                sentakutype[3].text = script.sentakuknum[sentaku_num - 2];
                sentakutype[2].text = script.sentakuknum[sentaku_num - 3];
                sentakutype[1].text = script.sentakuknum[sentaku_num - 4];
                if (sentaku_num - 5 != 0) { sentaku0.SetActive(false); sentakutype[0].text = script.sentakuknum[sentaku_num - 5]; } else { sentakutype[0].text = string.Empty; sentaku0.SetActive(true); sentaku0t.text = script.sentakuknum[0]; }
                stype[4].text = script.sentakusy[script.sentakutypes[sentaku_num - 1]];
                stype[3].text = script.sentakusy[script.sentakutypes[sentaku_num - 2]];
                stype[2].text = script.sentakusy[script.sentakutypes[sentaku_num - 3]];
                stype[1].text = script.sentakusy[script.sentakutypes[sentaku_num - 4]];
                stype[0].text = script.sentakusy[script.sentakutypes[sentaku_num - 5]];
                //選択肢文章
                Graphic senb1 = sentakub[0].placeholder;
                Graphic senb2 = sentakub[1].placeholder;
                Graphic senb3 = sentakub[2].placeholder;
                Graphic senb4 = sentakub[3].placeholder;
                Graphic senb5 = sentakub[4].placeholder;
                Graphic senb6 = sentakub[5].placeholder;
                Graphic senb7 = sentakub[6].placeholder;
                Graphic senb8 = sentakub[7].placeholder;
                Graphic senb9 = sentakub[8].placeholder;
                Graphic senb10 = sentakub[9].placeholder;
                if (script.sentakutypes[sentaku_num - 5] == 0)
                {
                    nd[0].SetActive(false); 
                    n[0].SetActive(true);
                }
                else
                {
                    n[0].SetActive(false);
                    nd[0].SetActive(true);
                    sentakubs[(sentaku_num - 5) * 2 + 1] = sentakub[1].text;
                    sentakubs[(sentaku_num - 5) * 2] = sentakub[0].text;
                    ((Text)senb2).text = string.Empty + script.sentakubnum[sentakut_num - 9];
                    ((Text)senb1).text = string.Empty + script.sentakubnum[sentakut_num - 10];
                    sentakud[1].text = string.Empty + script.sentakudnum[sentakut_num - 9];
                    sentakud[0].text = string.Empty + script.sentakudnum[sentakut_num - 10];
                }
                if (script.sentakutypes[sentaku_num - 4] == 0)
                {
                    nd[1].SetActive(false); n[1].SetActive(true);
                }
                else
                {
                    n[1].SetActive(false);
                    nd[1].SetActive(true);
                    sentakubs[(sentaku_num - 4) * 2 + 1] = sentakub[3].text;
                    sentakubs[(sentaku_num - 4) * 2] = sentakub[2].text;
                    ((Text)senb4).text = string.Empty + script.sentakubnum[sentakut_num - 7];
                    ((Text)senb3).text = string.Empty + script.sentakubnum[sentakut_num - 8];
                    sentakud[3].text = string.Empty + script.sentakudnum[sentakut_num - 7];
                    sentakud[2].text = string.Empty + script.sentakudnum[sentakut_num - 8];
                }
                if (script.sentakutypes[sentaku_num - 3] == 0)
                {
                    nd[2].SetActive(false); n[2].SetActive(true);
                }
                else
                {
                    n[2].SetActive(false);
                    nd[2].SetActive(true);
                    sentakubs[(sentaku_num - 3) * 2 + 1] = sentakub[5].text;
                    sentakubs[(sentaku_num - 3) * 2] = sentakub[4].text;
                    ((Text)senb6).text = string.Empty + script.sentakubnum[sentakut_num - 5];
                    ((Text)senb5).text = string.Empty + script.sentakubnum[sentakut_num - 6];
                    sentakud[5].text = string.Empty + script.sentakudnum[sentakut_num - 5];
                    sentakud[4].text = string.Empty + script.sentakudnum[sentakut_num - 6];
                }
                if (script.sentakutypes[sentaku_num - 2] == 0)
                {
                    nd[3].SetActive(false); n[3].SetActive(true);
                }
                else
                {
                    n[3].SetActive(false);
                    nd[3].SetActive(true);
                    sentakubs[(sentaku_num - 2) * 2 + 1] = sentakub[7].text;
                    sentakubs[(sentaku_num - 2) * 2] = sentakub[6].text;
                    ((Text)senb8).text = string.Empty + script.sentakubnum[sentakut_num - 3];
                    ((Text)senb7).text = string.Empty + script.sentakubnum[sentakut_num - 4];
                    sentakud[7].text = string.Empty + script.sentakudnum[sentakut_num - 3];
                    sentakud[6].text = string.Empty + script.sentakudnum[sentakut_num - 4];
                }
                if (script.sentakutypes[sentaku_num - 1] == 0)
                {
                    nd[4].SetActive(false); n[4].SetActive(true);
                }
                else
                {
                    n[4].SetActive(false);
                    nd[4].SetActive(true);
                    sentakubs[(sentaku_num - 1) * 2 + 1] = sentakub[9].text;
                    sentakubs[(sentaku_num - 1) * 2] = sentakub[8].text;
                    ((Text)senb10).text = string.Empty + script.sentakubnum[sentakut_num - 1];
                    ((Text)senb9).text = string.Empty + script.sentakubnum[sentakut_num - 2];
                    sentakud[9].text = string.Empty + script.sentakudnum[sentakut_num - 1];
                    sentakud[8].text = string.Empty + script.sentakudnum[sentakut_num - 2];
                }
                if (esaveco.senf == -1)
                {
                    //選択肢文章
                    sentakub[0].text = string.Empty;
                    sentakub[1].text = string.Empty;
                    sentakub[2].text = string.Empty;
                    sentakub[3].text = string.Empty;
                    sentakub[4].text = string.Empty;
                    sentakub[5].text = string.Empty;
                    sentakub[6].text = string.Empty;
                    sentakub[7].text = string.Empty;
                    sentakub[8].text = string.Empty;
                    sentakub[9].text = string.Empty;
                    //選択肢データ
                    sentakud[0].text = string.Empty;
                    sentakud[1].text = string.Empty;
                    sentakud[2].text = string.Empty;
                    sentakud[3].text = string.Empty;
                    sentakud[4].text = string.Empty;
                    sentakud[5].text = string.Empty;
                    sentakud[6].text = string.Empty;
                    sentakud[7].text = string.Empty;
                    sentakud[8].text = string.Empty;
                    sentakud[9].text = string.Empty;
                    esaveco.senf = 0;
                }
            }
            else
            {
                sentaku.SetActive(false);
                filepanel.SetActive(false);
            }
            //UI
            if (editp == 11)
            {
                ui.SetActive(true);
                uiptype[0].text = script.uitypesy[0];
                uiptype[1].text = script.uitypesy[1];
                uiptype[2].text = script.uitypesy[2];
                if (esaveco.uigcf > 0) { uibh.SetActive(false); } else { uibh.SetActive(true); }
                //UI画像ファイル
                if (dataload.uxflag == 0)
                {
                    if (uixpage == 0) { uixhidari.SetActive(false); } else { uixhidari.SetActive(true); }
                    if (uixpage == dataload.uixmpage) { uixmigi.SetActive(false); } else { uixmigi.SetActive(true); }
                    if (uixpage > dataload.uixmpage) { uixpage = dataload.uixmpage; }
                    uixpt.text = "画像ファイル：" + (uixpage + 1) + "/" + (dataload.uixmpage + 1);
                    if (dataload.uixnum > uixpage * 10) { uix[0].sprite = script2.usprite[0 + uixpage * 10]; } else { uix[0].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 1 + uixpage * 10) { uix[1].sprite = script2.usprite[1 + uixpage * 10]; } else { uix[1].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 2 + uixpage * 10) { uix[2].sprite = script2.usprite[2 + uixpage * 10]; } else { uix[2].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 3 + uixpage * 10) { uix[3].sprite = script2.usprite[3 + uixpage * 10]; } else { uix[3].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 4 + uixpage * 10) { uix[4].sprite = script2.usprite[4 + uixpage * 10]; } else { uix[4].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 5 + uixpage * 10) { uix[5].sprite = script2.usprite[5 + uixpage * 10]; } else { uix[5].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 6 + uixpage * 10) { uix[6].sprite = script2.usprite[6 + uixpage * 10]; } else { uix[6].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 7 + uixpage * 10) { uix[7].sprite = script2.usprite[7 + uixpage * 10]; } else { uix[7].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 8 + uixpage * 10) { uix[8].sprite = script2.usprite[8 + uixpage * 10]; } else { uix[8].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 9 + uixpage * 10) { uix[9].sprite = script2.usprite[9 + uixpage * 10]; } else { uix[9].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > uixpage * 10) { uixd[0].sprite = script2.usprite[0 + uixpage * 10]; } else { uixd[0].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 1 + uixpage * 10) { uixd[1].sprite = script2.usprite[1 + uixpage * 10]; } else { uixd[1].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 2 + uixpage * 10) { uixd[2].sprite = script2.usprite[2 + uixpage * 10]; } else { uixd[2].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 3 + uixpage * 10) { uixd[3].sprite = script2.usprite[3 + uixpage * 10]; } else { uixd[3].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 4 + uixpage * 10) { uixd[4].sprite = script2.usprite[4 + uixpage * 10]; } else { uixd[4].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 5 + uixpage * 10) { uixd[5].sprite = script2.usprite[5 + uixpage * 10]; } else { uixd[5].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 6 + uixpage * 10) { uixd[6].sprite = script2.usprite[6 + uixpage * 10]; } else { uixd[6].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 7 + uixpage * 10) { uixd[7].sprite = script2.usprite[7 + uixpage * 10]; } else { uixd[7].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 8 + uixpage * 10) { uixd[8].sprite = script2.usprite[8 + uixpage * 10]; } else { uixd[8].sprite = Resources.Load<Sprite>("UI/filenone"); }
                    if (dataload.uixnum > 9 + uixpage * 10) { uixd[9].sprite = script2.usprite[9 + uixpage * 10]; } else { uixd[9].sprite = Resources.Load<Sprite>("UI/filenone"); }
                }
                if (uipanelf <2) { uip[3].SetActive(true); uip[4].SetActive(true); } else { uip[3].SetActive(false); uip[4].SetActive(false); }
                //起動画面
                if (uipanelf == 2)
                {
                    uipt.text = "プレビュー";
                    uippage = 0;
                    uip[2].SetActive(true);
                    uipmigi.SetActive(false);
                    uiphidari.SetActive(false);
                    //画面プレビュー
                    if (script.gamelogohantei[0] != null & script.gamelogohantei[0] != string.Empty) { uikpic.sprite = script2.uis[script.gamelogohantei[0]]; } else { uikpic.sprite = Resources.Load<Sprite>("UI/titleb1"); }
                    //設定画面
                    if (glo_num == 0) { glo_num = textt.gamelogos; }
                    uinum[1].text = "No." + (glo_num + 1 - 1);
                    uinum[0].text = "No." + (glo_num + 1 - 2);
                    uitype[1].text = (glo_num + 1 - 1) + "枚目";
                    uitype[0].text = (glo_num + 1 - 2) + "枚目";
                    if (textt.gamelogos > 1) {if (script.gamelogohantei[glo_num - 1] != null & script.gamelogohantei[glo_num - 1] != string.Empty) { uitx[1].text = script.gamelogohantei[glo_num - 1].Substring(script.gamelogohantei[glo_num - 1].LastIndexOf("\\") + 1); } else { uitx[1].text = "NONE"; }} else { uitx[1].text = "NONE"; }
                    if (textt.gamelogos > 0) { if (script.gamelogohantei[glo_num - 2] != null & script.gamelogohantei[glo_num - 2] != string.Empty) { uitx[0].text = script.gamelogohantei[glo_num - 2].Substring(script.gamelogohantei[glo_num - 2].LastIndexOf("\\") + 1); } else { uitx[0].text = "NONE"; } } else { uitx[0].text = "NONE"; }
                }
                else
                {
                    uip[2].SetActive(false);
                }
                //タイトル画面
                if (uipanelf == 0)
                {
                    uitpage = 1;
                    uip[0].SetActive(true);
                    uipt.text = "プレビュー";
                    uipmigi.SetActive(false);
                    uiphidari.SetActive(false);
                    //画面プレビュー
                    if (script.uitnum[0] != null & script.uitnum[0] != string.Empty) { uitpic[0].sprite = script2.uis[script.uitnum[0]]; } else { uitpic[0].sprite = Resources.Load<Sprite>("UI/bgsample"); }
                    if (script.uitnum[1] != null & script.uitnum[1] != string.Empty) { uitpic[1].sprite = script2.uis[script.uitnum[1]]; } else { uitpic[1].sprite = Resources.Load<Sprite>("UI/titlelogo"); }
                    if (script.uitnum[2] != null & script.uitnum[2] != string.Empty) { uitpic[2].sprite = script2.uis[script.uitnum[2]]; } else { uitpic[2].sprite = Resources.Load<Sprite>("UI/panelte"); }
                    if (script.uitnum[3] != null & script.uitnum[3] != string.Empty) { uitpic[3].sprite = script2.uis[script.uitnum[3]]; } else { uitpic[3].sprite = Resources.Load<Sprite>("UI/panelte"); }
                    //設定画面
                    if (uit_num == 0) { uit_num = textt.uits; }
                    uinum[1].text = "No." + (uit_num + 1 - 1);
                    uinum[0].text = "No." + (uit_num + 1 - 2);
                    uitype[1].text = script.uittypes[uit_num - 1];
                    uitype[0].text = script.uittypes[uit_num - 2];
                    if (script.uitnum[uit_num - 1] != null & script.uitnum[uit_num - 1] != string.Empty) { uitx[1].text = script.uitnum[uit_num - 1].Substring(script.uitnum[uit_num - 1].LastIndexOf("\\") + 1); } else { uitx[1].text = "NONE"; }
                    if (script.uitnum[uit_num - 2] != null & script.uitnum[uit_num - 2] != string.Empty) { uitx[0].text = script.uitnum[uit_num - 2].Substring(script.uitnum[uit_num - 2].LastIndexOf("\\") + 1); } else { uitx[0].text = "NONE"; }
                }
                else
                {
                    uip[0].SetActive(false);
                }
                //ゲーム画面
                if (uipanelf == 1)
                {
                    uigpage = 1;
                    uip[1].SetActive(true);
                    uipt.text = "プレビュー";
                    uipmigi.SetActive(false);
                    uiphidari.SetActive(false);
                    //画面プレビュー
                    if (script.uignum[0] != null & script.uignum[0] != string.Empty) { uigpic[0].sprite = script2.uis[script.uignum[0]]; } else { uigpic[0].sprite = Resources.Load<Sprite>("UI/mess"); }
                    if (script.uignum[1] != null & script.uignum[1] != string.Empty) { uigpic[1].sprite = script2.uis[script.uignum[1]]; } else { uigpic[1].sprite = Resources.Load<Sprite>("UI/chrna"); }
                    if (script.uignum[2] != null & script.uignum[2] != string.Empty) { uigpic[2].sprite = script2.uis[script.uignum[2]]; } else { uigpic[2].sprite = Resources.Load<Sprite>("UI/panelte"); }
                    if (script.uignum[3] != null & script.uignum[3] != string.Empty) { uigpic[3].sprite = script2.uis[script.uignum[3]]; } else { uigpic[3].sprite = Resources.Load<Sprite>("UI/panelte"); }
                    if (script.uignum[4] != null & script.uignum[4] != string.Empty) { uigpic[4].sprite = script2.uis[script.uignum[4]]; } else { uigpic[4].sprite = Resources.Load<Sprite>("UI/sentakubar"); }
                    if (script.uignum[4] != null & script.uignum[4] != string.Empty) { uigpic[5].sprite = script2.uis[script.uignum[4]]; } else { uigpic[5].sprite = Resources.Load<Sprite>("UI/sentakubar"); }
                    //設定画面
                    if (uig_num == 0) { uig_num = textt.uigs; }
                    uinum[1].text = "No." + (uig_num + 1 - 1);
                    uinum[0].text = "No." + (uig_num + 1 - 2);
                    uitype[1].text = script.uigtypes[uig_num - 1];
                    uitype[0].text = script.uigtypes[uig_num - 2];
                    if (script.uignum[uig_num - 1] != null & script.uignum[uig_num - 1] != string.Empty) { uitx[1].text = script.uignum[uig_num - 1].Substring(script.uignum[uig_num - 1].LastIndexOf("\\") + 1); } else { uitx[1].text = "NONE"; }
                    if (script.uignum[uig_num - 2] != null & script.uignum[uig_num - 2] != string.Empty) { uitx[0].text = script.uignum[uig_num - 2].Substring(script.uignum[uig_num - 2].LastIndexOf("\\") + 1); } else { uitx[0].text = "NONE"; }
                }
                else
                {
                    uip[1].SetActive(false);
                }
            }
            else
            {
                ui.SetActive(false);
                uippage = 0;
                uit_num = 0;
                uig_num = 0;
            }
            //全体データセーブ・ロード
            if (editp == 12)
            {
                aldata.SetActive(true);
                ctname = ctny.text;
                saveloadk.ujssname = ajssny.text;
                austx.text = textti.loaddata;
                if (textti.loaddata == string.Empty & textti.loaddata == null)
                {
                    gsfms.SetActive(true);
                }
                else
                {
                    gsfms.SetActive(false);
                }
                if (cf > 0)
                {
                    ctny.text = null;
                    ajssny.text = null;
                    cf = 0;
                }
                if (esaveco.useflag == 0 & esaveco.jsonflag == 0 & esaveco.txtflag == 0)
                {
                    filepanel.SetActive(false);
                    esaveco.sentakujsonf = 0;
                    esaveco.sentakutxtf = 0;
                }
                if (esaveco.useflag == 1 | esaveco.jsonflag == 1)
                {
                    if (esaveco.useflag == 1)
                    {
                        ajssny.text = null;
                    }
                    if (esaveco.jsonflag == 1)
                    {
                        ctny.text = null;
                    }
                    esaveco.sentakujsonf = 0;
                    jsonPath = Application.dataPath + "/SAVEDATA/json/whole/";
                    string[] jsonnamem = Directory.GetFiles(jsonPath);
                    jsonname = System.Array.FindAll(jsonnamem, t => t.Contains(".meta") == false & t.Contains("/.json") == false);
                    filepanel.SetActive(true);
                    jsonnum = jsonname.Length;
                    tsempage = (jsonnum - 1) / 12 + 1;
                    if (tsepage < 1)
                    {
                        tsem.SetActive(false);
                    }
                    else
                    {
                        tsem.SetActive(true);
                    }
                    if (tsepage + 2 > tsempage)
                    {
                        tset.SetActive(false);
                    }
                    else
                    {
                        tset.SetActive(true);
                    }
                    tsepp.text = tsepage + 1 + "/" + tsempage;

                    tpanelt.text = "jsonファイル";
                    if (jsonnum > 11 + tsepage * 12) { tsentaku12.text = jsonname[11 + tsepage * 12].Substring(jsonname[11 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku12.text = "NONE"; }
                    if (jsonnum > 10 + tsepage * 12) { tsentaku11.text = jsonname[10 + tsepage * 12].Substring(jsonname[10 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku11.text = "NONE"; }
                    if (jsonnum > 9 + tsepage * 12) { tsentaku10.text = jsonname[9 + tsepage * 12].Substring(jsonname[9 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku10.text = "NONE"; }
                    if (jsonnum > 8 + tsepage * 12) { tsentaku9.text = jsonname[8 + tsepage * 12].Substring(jsonname[8 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku9.text = "NONE"; }
                    if (jsonnum > 7 + tsepage * 12) { tsentaku8.text = jsonname[7 + tsepage * 12].Substring(jsonname[7 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku8.text = "NONE"; }
                    if (jsonnum > 6 + tsepage * 12) { tsentaku7.text = jsonname[6 + tsepage * 12].Substring(jsonname[6 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku7.text = "NONE"; }
                    if (jsonnum > 5 + tsepage * 12) { tsentaku6.text = jsonname[5 + tsepage * 12].Substring(jsonname[5 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku6.text = "NONE"; }
                    if (jsonnum > 4 + tsepage * 12) { tsentaku5.text = jsonname[4 + tsepage * 12].Substring(jsonname[4 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku5.text = "NONE"; }
                    if (jsonnum > 3 + tsepage * 12) { tsentaku4.text = jsonname[3 + tsepage * 12].Substring(jsonname[3 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku4.text = "NONE"; }
                    if (jsonnum > 2 + tsepage * 12) { tsentaku3.text = jsonname[2 + tsepage * 12].Substring(jsonname[2 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku3.text = "NONE"; }
                    if (jsonnum > 1 + tsepage * 12) { tsentaku2.text = jsonname[1 + tsepage * 12].Substring(jsonname[1 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku2.text = "NONE"; }
                    if (jsonnum > 0 + tsepage * 12) { tsentaku1.text = jsonname[0 + tsepage * 12].Substring(jsonname[0 + tsepage * 12].LastIndexOf("/") + 1).Replace(".json", string.Empty); } else { tsentaku1.text = "NONE"; }
                }
                if (esaveco.txtflag == 1)
                {
                    jssny.text = null;
                    esaveco.sentakutxtf = 0;
                    txtPath = Application.dataPath + "/SAVEDATA/txt/";
                    string[] txtnamem = Directory.GetFiles(txtPath);
                    txtname = System.Array.FindAll(txtnamem, t => t.Contains(".meta") == false);
                    filepanel.SetActive(true);
                    txtnum = txtname.Length;
                    tsempage = (txtnum - 1) / 12 + 1;
                    if (tsepage < 1)
                    {
                        tsem.SetActive(false);
                    }
                    else
                    {
                        tsem.SetActive(true);
                    }
                    if (tsepage + 2 > tsempage)
                    {
                        tset.SetActive(false);
                    }
                    else
                    {
                        tset.SetActive(true);
                    }
                    tsepp.text = tsepage + 1 + "/" + tsempage;

                    tpanelt.text = "txtファイル";
                    if (txtnum > 11 + tsepage * 12) { tsentaku12.text = txtname[11 + tsepage * 12].Substring(txtname[11 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku12.text = "NONE"; }
                    if (txtnum > 10 + tsepage * 12) { tsentaku11.text = txtname[10 + tsepage * 12].Substring(txtname[10 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku11.text = "NONE"; }
                    if (txtnum > 9 + tsepage * 12) { tsentaku10.text = txtname[9 + tsepage * 12].Substring(txtname[9 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku10.text = "NONE"; }
                    if (txtnum > 8 + tsepage * 12) { tsentaku9.text = txtname[8 + tsepage * 12].Substring(txtname[8 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku9.text = "NONE"; }
                    if (txtnum > 7 + tsepage * 12) { tsentaku8.text = txtname[7 + tsepage * 12].Substring(txtname[7 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku8.text = "NONE"; }
                    if (txtnum > 6 + tsepage * 12) { tsentaku7.text = txtname[6 + tsepage * 12].Substring(txtname[6 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku7.text = "NONE"; }
                    if (txtnum > 5 + tsepage * 12) { tsentaku6.text = txtname[5 + tsepage * 12].Substring(txtname[5 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku6.text = "NONE"; }
                    if (txtnum > 4 + tsepage * 12) { tsentaku5.text = txtname[4 + tsepage * 12].Substring(txtname[4 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku5.text = "NONE"; }
                    if (txtnum > 3 + tsepage * 12) { tsentaku4.text = txtname[3 + tsepage * 12].Substring(txtname[3 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku4.text = "NONE"; }
                    if (txtnum > 2 + tsepage * 12) { tsentaku3.text = txtname[2 + tsepage * 12].Substring(txtname[2 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku3.text = "NONE"; }
                    if (txtnum > 1 + tsepage * 12) { tsentaku2.text = txtname[1 + tsepage * 12].Substring(txtname[1 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku2.text = "NONE"; }
                    if (txtnum > 0 + tsepage * 12) { tsentaku1.text = txtname[0 + tsepage * 12].Substring(txtname[0 + tsepage * 12].LastIndexOf("/") + 1).Replace(".txt", string.Empty); } else { tsentaku1.text = "NONE"; }
                }
            }
            else
            {
                aldata.SetActive(false);
            }
            //全体設定
            if (editp==13)
            {
                aleditp.SetActive(true);
                //キャラデータは1つ目のデータを使用
                if (script.aehantei[0] == 0) { aep[0].sprite=Resources.Load<Sprite>("UI/checkn"); } else { aep[0].sprite=Resources.Load<Sprite>("UI/checka"); }
                //キャラ表示時にフェードイン効果
                if (script.aehantei[1] == 0) { aep[1].sprite=Resources.Load<Sprite>("UI/checkn"); } else { aep[1].sprite=Resources.Load<Sprite>("UI/checka"); }
                //キャラのアニメーション効果
                if (script.aehantei[2] == 0) { aep[2].sprite=Resources.Load<Sprite>("UI/checkn"); } else { aep[2].sprite=Resources.Load<Sprite>("UI/checka"); }
            }
            else
            {
                aleditp.SetActive(false);
            }
        }
        else
        {
            deditpanel.SetActive(false);
            sentaku_num = 0;
        }
    }
}

