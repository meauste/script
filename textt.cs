using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class textt : MonoBehaviour
{
    public int tlnum;
    //テキストマネージャー
    public string[] chrtext;
    public string[] textcolor;
    public string[] texth;
    public string[] textp;
    //キャラエディット
    //ページ1
    public string[] partna;
    public string[] chrmyo;
    public string[] chrna;
    public int[] seibetsu;
    public int[] hyoji;
    //ページ2
    public string[] cpicname;
    public string[][] cpic;
    public string[] chrani;
    //カラーパネル
    public string[] ctagna;
    public string[] colorna;
    public string[] a;
    public int fadeoiflag;
    public static int s1nf;
    public static float texttime;
    public static float autott;
    public static float audiov;
    public static float audioev;
    public static float audioefv;
    public static float audiosofv;
    public static int dataload;
    public int ss;
    public string sss;
    public int chrcf;
    public int topx;
    public int loadflag;
    public int chrcx;
    public int chr1x;
    public string chr1body_num;
    public string savename;
    public saveload sl;
    public static int s1nfl;
    public static int s1nfll;
    public static int s2nfl;
    public static int s3nfl;
    public static int s4nfl;
    public static int s5nfl;
    public static int s6nfl;
    public int unazf;
    public float unazgage;
      public static int gsex;
    public static int gspf;
    public static int outf;
    [SerializeField]
    public string[] textl;
    public string[] cnal;
    public string[] bgl;
    public string[] chl;
    private TextAsset textFile;
    public static string textallct;
    public static int tx;
    public string textData;
    public string[] text;
    public string tshb;
    private TextAsset cnaFile;
    public static string cnaData;
    public string[] cna;
    string filePathb;
    private TextAsset BgcFile;
    public string BgcData;
    public string[] Bgccon;
    string filePathch;
    public TextAsset dcolorFile;
    public string dcolorData;
    public string[] dcolor;
    public int dcolors;
    public string[] colorp;
    public static int cos;
    private TextAsset chrFile;
    public string chrData;
    public string[] chrcon;

    public TextAsset myoFile;
    public string myoData;
    public TextAsset mFile;
    public string mData;
    public TextAsset fFile;
    public string fData;
 
    public string[] myo;
    public string[] mname;
    public string[] fname;
    public static int myos;
    public static int ms;
    public static int fs;
    public int cnau;
    public int cnk;
    public int cnk2;
    public int cnl;
    public int animf = 1;
    public string anim1;
    public int mabatakif;
    public string tsll;
    public string[] textlo;
    public int[] bge;
    public int bgex;
    public int kf;
    public int textf;
    public int textx;
    string filePatht;
    string filePathc;
    public static int fsi;
    public static int nextst;
    public static int fox;
    public edittext ed;
    public int[] tin;
    public int ti;
    public string ct;
    public int conau;
    public int colorx;
    public int tmx;
    public string textall3;
    public string textall6;
    public static string textall;
    public string[] Bgcon;
    public int sx;
    public StringBuilder tsh;
    public StringBuilder tsl;
    public string[] textc;
    public string cn;
    public string tc;
    public string toc;
    public string th;
    public string[] name;
    public string[] color;
    public string[] ocolor;
    public string[] textocolor;
    public string[] textho;
    public string[] ocolorna;
    public int[] bgchantei;
    public static int bgcs;
    public string[] bgcnum;
    public int[] bgcdhantei;
    public int[]bgcdg;
    public string[] bgcdnum;
    public static int bgcds;
    public int[] chaphantei;
    public string[] chapnum;
    public int[] chaptypes;
    public static int chaps;
    public int[] chapthantei;
    public string[] chaptnum;
    public int[] chapans;
    public int[] kakudaians;
    public static int chapts;
    public int[] kakudaitypes;
    public string[] bikou;
    public int[] kakudaihantei;
    public string[] kakudainum;
    public static int kakudais;
    public int[] bgswhantei;
    public string[] bgswnum;
    public static int bgsws;
    public int[] bglwhantei;
    public string[] bglwnum;
    public static int bglws;
    public int[] bgehantei;
    public string[] bgenum;
    public static int bges;
    public int[] serioushantei;
    public static int seriouss;
    public int[] hazimarihantei;
    public string[] hazimarinum;
    public static int hazimaris;
    //キャラ
    public int[] ceventsyl;
    public int[] chrchantei;
    public string[] chrcnum;
    public static int chrcs;
    public static int chrcns;
    public static int chrcdns;
    public int[] chrcdhantei;
    public string[] chrcdnum;
    public static int chrcds;
    public int[] unazhantei;
    public int[] unazc;
    public string[] unaznum;
    public static int unazs;
    public int[] odorokihantei;
    public int[] odorokic;
    public string[] odorokinum;
    public static int odorokis;
    public int[] daruhantei;
    public int[] daruc;
    public string[] darunum;
    public static int darus;
    public string[] ceventsy;
    public string[] ceeventsy;
    public string[] beventsy = { "背景変化", "背景変化(複数)", "暗転", "アイキャッチ", "拡大" ,"","小パネル表示","大パネル表示","グラデーション効果","テキストボックス消去","テキスト中央表示"};
    public string[] chapsy = { "1", "2", "3","未定" };
    public string[] chapansy = { "なし", "あり" };
    public string[] kakudaisy = { "1", "2", "3","未定" };
    //音源
    public int[] bgmhantei;
    public int[] bgmehantei;
    public int[] bgmefhantei;
    public static int bgms;
    public static int bgmes;
    public static int bgmefs;
    public string[] bgmnum;
    public string[] bgmenum;
    public string[] bgmefnum;
    public string[] audiosy = { "BGM", "環境音", "効果音" };
    //映像
    public int[] videohantei;
    public string[] videonum;
    public string[] videosy = {"映像",""};
    public static int videos;
    //選択肢
    public int[] sentakuhantei;
    public string[] sentakuknum;
    public string[] sentakubnum;
    public string[] sentakudnum;
    public string[] sentakusy = { "なし", "2択"};
    public int[] sentakutypes;
    public static int sentakus;
    //UI設定
    public static int gamelogos;
    public static int uits;
    public static int uigs;
    public string[] gamelogohantei;
    public string[] gamelogohanteio;
    public string[] uitnum;
    public string[] uitnumo;
    public string[] uignum;
    public string[] uitypesy = {"タイトル画面","ゲーム画面","起動画面"};
    public string[] uittypes = { "背景", "ロゴ", "パネル(小)", "パネル(大)" };
    public string[] uigtypes = { "テキストパネル", "キャラパネル", "パネル(小)", "パネル(大)","選択肢" };
    //設定
    public int[] aehantei;
    edit script2;
    void Start()
    {
        tx = 0;
        textf = 1;
        textx = 0;
        autott = 1.5f;
        audiov = 0.5f;
        audioev = 0.5f;
        audioefv = 0.5f;
        audiosofv = 0.5f;
        chrtext = new string[5];
        textcolor = new string[5];
        texth = new string[5];
        text= new string[5];
        partna = new string[5];
        chrmyo = new string[5];
        chrna = new string[5];
        cpicname = new string[5];
        chaphantei = new int[5];
        chapans = new int[5];
        kakudaians = new int[5];
        chaptypes = new int[5];
        chapthantei = new int[5];
        kakudaihantei = new int[5];
        kakudaitypes = new int[5];
        chapnum = new string[5];
        chaptnum = new string[10];
        kakudainum=new string[5];
        bgswhantei = new int[10];
        bgswnum = new string[10];
        bglwhantei = new int[10];
        bglwnum = new string[10];
        bgehantei = new int[10];
        bgenum=new string[10];
        serioushantei = new int[10];
        hazimarihantei = new int[10];
        hazimarinum = new string[10];
;        beventsy = new string[11] { "背景変化", "背景変化(複数)", "暗転", "アイキャッチ", "拡大" ,"","小パネル表示","大パネル表示","グラデーション効果","テキストボックス消去","テキスト中央表示"};
        ceventsy = new string[6]{"キャラ変化(2)","キャラ変化(1)","キャラ非表示","上下移動", "上下移動(高速)", "左右移動" };
        chrchantei = new int[5];
        chrcdhantei = new int[5];
        chrcnum = new string[5];
        chrcdnum = new string[10];
        unazhantei = new int[5];
        unazc = new int[5];
        unaznum = new string[5];
        odorokihantei = new int[5];
        odorokic = new int[5];
        odorokinum = new string[5];
        daruhantei = new int[5];
        daruc = new int[5];
        darunum = new string[5];
        ceventsyl = new int[5];
        cpic = new string[6][];
        {
            cpic[0] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
            cpic[1] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
            cpic[2] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
            cpic[3] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
            cpic[4] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
            cpic[5] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
        }
        chrani = new string[5];
        seibetsu = new int[5];
        hyoji = new int[5];
        ctagna = new string[5];
        colorna = new string[5];
        ocolorna = new string[5];
        textocolor=new string[5];
        color=new string[5];
        ocolor=new string[5];
        bgchantei = new int[5];
        bikou = new string[5];
        bgcnum = new string[5];
        bgcdhantei=new int[5];
        bgcdg = new int[5];
        bgcdnum = new string[10];
        bgmhantei = new int[5];
        bgmehantei=new int[5];
        bgmefhantei=new int[5];
        bgmnum= new string[5];
        bgmenum= new string[5];
        bgmefnum=new string[5];
        videohantei = new int[5];
        videonum = new string[5];
        sentakuhantei = new int[5];
        sentakutypes = new int[5];
        sentakuknum = new string[5];
        sentakubnum = new string[10];
        sentakudnum = new string[10];
        colorp = new string[15];
        aehantei = new int[3];
        gamelogohantei = new string[2];
        gamelogohanteio = new string[2];
        uitnum = new string[4];
        uitnumo = new string[4];
        uignum = new string[5];
        //デフォルトカラーデータ
        TextAsset dcolorFile = Resources.Load<TextAsset>("Txt/dcolor");
        dcolorData = dcolorFile.text;
        dcolor = dcolorData.Split(char.Parse(","));
        dcolors = dcolor.Length;
        System.Array.Copy(dcolor, 0, colorp, 0, dcolors);
        //キャラ名データ
        TextAsset myoFile = Resources.Load<TextAsset>("Txt/myoji");
        TextAsset mFile = Resources.Load<TextAsset>("Txt/male");
        TextAsset fFile = Resources.Load<TextAsset>("Txt/female");
        myoData = myoFile.text;
        mData = mFile.text;
        fData = fFile.text;
        myo = myoData.Split(char.Parse("\n"));
        mname = mData.Split(char.Parse("\n"));
        fname = fData.Split(char.Parse("\n"));
        myos = myo.Length;
        ms = mname.Length;
        fs = fname.Length;
    }
    void Update()
    {
        cnau = chrna.Length;
        conau = ctagna.Length;
        cos = colorp.Length;
        //キャラ
        chrcs = chrchantei.Length;
        chrcns = chrcnum.Length;
        chrcdns = chrcdnum.Length;
        unazs = unazhantei.Length;
        odorokis = odorokihantei.Length;
        darus = daruhantei.Length;
        bgcs = bgchantei.Length;
        bgcds = bgcdhantei.Length;
        chaps = chaphantei.Length;
        chapts = chapthantei.Length;
        kakudais = kakudaihantei.Length;
        bgsws = bgswhantei.Length;
        bglws = bglwhantei.Length;
        bges = bgehantei.Length;
        seriouss = serioushantei.Length;
        hazimaris = hazimarihantei.Length;
        bgms = bgmhantei.Length;
        bgmes = bgmehantei.Length;
        bgmefs=bgmefhantei.Length;
        videos = videohantei.Length;
        sentakus = sentakuknum.Length;
        gamelogos = gamelogohantei.Length;
        uits = uittypes.Length;
        uigs = uigtypes.Length;
        if (chrna.Length!=chrmyo.Length|chrna.Length!=seibetsu.Length|chrna.Length!=hyoji.Length)
        {
            System.Array.Resize(ref chrmyo, chrna.Length);
            System.Array.Resize(ref seibetsu, chrna.Length);
            System.Array.Resize(ref hyoji, chrna.Length);
        }
        for(sx=0;sx<seibetsu.Length;sx++)
        {
            if(seibetsu[sx]==null)
            {
                seibetsu[sx] = 0;
            }
            if (hyoji[sx] == null)
            {
                hyoji[sx] = 0;
            }
        }
        if (sx>seibetsu.Length)
        {
            sx = 0;
        }
        ss = chrcontroller.animf;
        tmx = textl.Length-1;
        if (dataload==1)
        {
            if (tx <= tmx)
            {
                if (textx == 0)
                {
                    if (edit.edit_tnum <= 22)
                    {
                        textp = text;
                    }
                    else
                    {
                        textp = new string[23];
                        System.Array.Copy(text, edit.edit_tnum - 23, textp, 0, 23);
                    }
                    var textallv1 = text;
                    var textallv2 = string.Join(",", textallv1);
                    textall3=textallv2;
                    var textallv4 = textp;
                    var textallv5 = string.Join(",", textallv4);
                    cn = string.Join(",", chrtext);
                    tc = string.Join(",", textcolor);
                    toc = string.Join(",", textocolor);
                    th = string.Join(",", texth);
                    textall6 = textallv5;
                    tsh = new System.Text.StringBuilder(textall6);
                    tsl = new System.Text.StringBuilder(textall3);
                }
                tsh.Insert(0,",");
                tsl.Replace("\n,", "\n");
                tsh.Replace(",", " ");
                tsh.Replace("@", "");
                th=th.Replace("@", "");
                tsh.Replace("ANIM", "0");
                for (textx = 0; textx < cnau; textx++)
                {
                    if (partna[cnau - textx - 1] != null&partna[cnau - textx - 1] !="")
                    {
                        if (hyoji[cnau - textx - 1] == 0)
                        {
                            if (chrna[cnau - textx - 1] != "" & chrna[cnau - textx - 1] != null)
                            {
                                tsh.Replace("#" + partna[cnau - textx - 1], chrna[cnau - textx - 1]);
                            }
                            else
                            {
                                tsh.Replace("#" + partna[cnau - textx - 1], "#NONE");
                            }
                            cn =cn.Replace("#" + partna[cnau - textx - 1], chrna[cnau - textx - 1]);
                        }
                        else
                        {
                            if (chrna[cnau - textx - 1] != "" & chrna[cnau - textx - 1] != null)
                            {
                                tsh.Replace("#" + partna[cnau - textx - 1], chrmyo[cnau - textx - 1]);
                            }
                            else
                            {
                                tsh.Replace("#" + partna[cnau - textx - 1], "#NONE");
                            }
                            cn=cn.Replace("#" + partna[cnau - textx - 1], chrmyo[cnau - textx - 1]);
                        }
                    }
                }
                for (colorx = 0; colorx < conau; colorx++)
                {
                    if (ctagna[conau - colorx - 1] != null&ctagna[conau - colorx - 1] != "")
                    {
                        tsh.Replace("$" + ctagna[conau - colorx - 1], colorna[conau - colorx - 1]);
                        tc = tc.Replace("$COLOR", "ffffff");
                        tc =tc.Replace("$" + ctagna[conau - colorx - 1], colorna[conau - colorx - 1]);
                        toc=toc.Replace("$" + ctagna[conau - colorx - 1], ocolorna[conau - colorx - 1]);
                    }
                }
                if (textx >= cnau&colorx>=conau)
                {
                    textall = tsh.ToString();
                    textallct = tsl.ToString();
                    textlo = textallct.Split(char.Parse("\n"));
                    name = cn.Split(char.Parse(","));
                    color = tc.Split(char.Parse(","));
                    ocolor = toc.Split(char.Parse(","));
                    textho =th.Split(char.Parse(","));
                    textx++;
                    tx++;
                }
                if (tx>tmx)
                {
                    dataload = 0;
                    textx = 0;
                    tx = 0;
                }
            }
        }
        if (dataload == 2)
        {
            string textallc = textallct.Replace(",", " ");
            textallct = textallct.Replace("\n", ",");
            textallct = textallct.Replace(" ", ",");
            textc = textallct.Split(char.Parse(","));
            chrtext = System.Array.FindAll(textc, t => t.Contains("#") == true);
            texth = System.Array.FindAll(textc, t => t.Contains("#") == false);
            tlnum = texth.Length;
            textcolor = new string[tlnum];
            textocolor = new string[tlnum];
            color = new string[tlnum];
            ocolor = new string[tlnum];
            name = new string[tlnum];
            text = new string[tlnum];
            textho = texth;
            script2 = GameObject.Find("specialm").GetComponent<edit>();
            script2.textnys = new string[tlnum];
            text = textallc.Split(char.Parse("\n"));
            edit.num = 0;
            edit.tnum = 0;
            edit.cnum = 0;
            dataload = 1;
            textx = 0;
            tx = 0;
        }
            fadeoiflag = Bgcontroller.kakudaix;
        mabatakif = chrcontroller.mabatakif;
        kf = chrcontroller.animf;
      

        loadflag = Load.loadflag;
        chr1x = chrcontroller.chr1x;
        chrcx = Bgcontroller.endflag;
        unazf = chrcontroller.daruf;
        chrcf = chrcontroller.chrcf;
        unazgage = TextManager.tanitime;

        if (gspf == 1 & gsex == 0)
        {
            Screen.SetResolution(1366, 768, false);
            gspf = 0;
        }
        if (gspf == 1 & gsex == 1)
        {
            Screen.SetResolution(1920, 1080, false);
            gspf = 0;
        }
        if (gspf == 1 & gsex == 2)
        {

            Screen.SetResolution(Screen.width, Screen.height, true);
            gspf = 0;
        }
    }
}
