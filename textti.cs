using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Linq;

public class textti : MonoBehaviour
{
    public string filePath;
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
    public static float fsi;
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
    public static string loaddata;
    public static string textall;
    public string[] Bgcon;
    public int sx;
    public StringBuilder tsh;
    public StringBuilder tsl;
    public string[] textc;
    public static int ths;
    public static int bgcs;
    public static int kakudais;
    public static int bgms;
    public static int bgmes;
    public static int bgmefs;
    public static int videos;
    public string[] name;
    public string[] color;
    public string[] textho;
    public int[] bgchantei;
    public string[] bgcnum;
    public int[] bgcdhantei;
    public int[] bgcdg;
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
    public int[] kakudaihantei;
    public string[] kakudainum;
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
    public int[] fadehantei;
    public int[] fadeoiflag;
    public string[] ocolor;
    //キャラ
    public int[] ceventsyl;
    public int[] chrchantei;
    public string[] chrcnum;
    public static int chrcs;
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
    public string[] beventsy = { "背景変化", "背景変化(複数)", "暗転", "アイキャッチ", "拡大" };
    public string[] chapsy = { "1", "2", "3" };
    public string[] chapansy = { "なし", "あり" };
    public string[] kakudaisy = { "1", "2", "3" };
    //音源
    public int[] bgmhantei;
    public int[] bgmehantei;
    public int[] bgmefhantei;
    public string[] bgmnum;
    public string[] bgmenum;
    public string[] bgmefnum;
    public int[] videohantei;
    public string[] videonum;
    //全体設定
    public int[] aehantei;
    //選択肢
    public static int loadf;
    public static int sentakus;
    public static string sentakuf;
    public int[] sentakuhantei;
    public string[] sentakuknum;
    public string[] sentakubnum;
    public string[] sentakudnum;
    public string[] sentakusy = { "なし", "2択", "3択" };
    public int[] sentakutypes;
    public int[] chart;
    public int[] charts;
    public int[] charth;
    public int[] chartx;
    public static int six;
    public string test;
    //UI設定
    public string[] uitnum;
    public string[] uignum;
    //選択肢データ1
    public string[] D1chrmyo;
    public string[] D1chrna;
    public string[] D1partna;
    public int[] D1hyoji;
    public int[] D1seibetsu;
    public string[] D1ctagna;
    public string[] D1colorna;
    public string[] D1chrtext;
    public string[] D1text;
    public string[] D1color;
    public string[] D1name;
    public string[] D1texth;
    public string[] D1textho;
    public string[] D1textcolor;
    public int[] D1bgchantei;
    public string[] D1bgcnum;
    public int[] D1bgcdhantei;
    public int[] D1bgcdg;
    public string[] D1bgcdnum;
    public int[] D1chaphantei;
    public string[] D1chapnum;
    public int[] D1chaptypes;
    public int[] D1chapthantei;
    public string[] D1chaptnum;
    public int[] D1chapans;
    public int[] D1kakudaians;
    public int[] D1kakudaitypes;
    public int[] D1kakudaihantei;
    public string[] D1kakudainum;
    public int[] D1bgswhantei;
    public string[] D1bgswnum;
    public int[] D1bglwhantei;
    public string[] D1bglwnum;
    public int[] D1bgehantei;
    public string[] D1bgenum;
    public int[] D1serioushantei;
    public int[] D1hazimarihantei;
    public string[] D1hazimarinum;
    public int[] D1chrchantei;
    public string[] D1chrcnum;
    public int[] D1chrcdhantei;
    public string[] D1chrcdnum;
    public int[] D1unazhantei;
    public int[] D1unazc;
    public string[] D1unaznum;
    public int[] D1odorokihantei;
    public int[] D1odorokic;
    public string[] D1odorokinum;
    public int[] D1daruhantei;
    public int[] D1daruc;
    public string[] D1darunum;
    public string[] D1ocolor;
    public int[] D1bgmhantei;
    public int[] D1bgmehantei;
    public int[] D1bgmefhantei;
    public string[] D1bgmnum;
    public string[] D1bgmenum;
    public string[] D1bgmefnum;
    public int[] D1videohantei;
    public string[] D1videonum;
    public int[] D1ceventsyl;
    //選択肢データ2
    public string[] D2chrmyo;
    public string[] D2chrna;
    public string[] D2partna;
    public int[] D2hyoji;
    public int[] D2seibetsu;
    public string[] D2ctagna;
    public string[] D2colorna;
    public string[] D2chrtext;
    public string[] D2text;
    public string[] D2color;
    public string[] D2name;
    public string[] D2texth;
    public string[] D2textho;
    public string[] D2textcolor;
    public int[] D2bgchantei;
    public string[] D2bgcnum;
    public int[] D2bgcdhantei;
    public int[] D2bgcdg;
    public string[] D2bgcdnum;
    public int[] D2chaphantei;
    public string[] D2chapnum;
    public int[] D2chaptypes;
    public int[] D2chapthantei;
    public string[] D2chaptnum;
    public int[] D2chapans;
    public int[] D2kakudaians;
    public int[] D2kakudaitypes;
    public int[] D2kakudaihantei;
    public string[] D2kakudainum;
    public int[] D2bgswhantei;
    public string[] D2bgswnum;
    public int[] D2bglwhantei;
    public string[] D2bglwnum;
    public int[] D2bgehantei;
    public string[] D2bgenum;
    public int[] D2serioushantei;
    public int[] D2hazimarihantei;
    public string[] D2hazimarinum;
    public int[] D2chrchantei;
    public string[] D2chrcnum;
    public int[] D2chrcdhantei;
    public string[] D2chrcdnum;
    public int[] D2unazhantei;
    public int[] D2unazc;
    public string[] D2unaznum;
    public int[] D2odorokihantei;
    public int[] D2odorokic;
    public string[] D2odorokinum;
    public int[] D2daruhantei;
    public int[] D2daruc;
    public string[] D2darunum;
    public string[] D2ocolor;
    public int[] D2bgmhantei;
    public int[] D2bgmehantei;
    public int[] D2bgmefhantei;
    public string[] D2bgmnum;
    public string[] D2bgmenum;
    public string[] D2bgmefnum;
    public int[] D2videohantei;
    public string[] D2videonum;
    public int[] D2ceventsyl;
    saveloadk script;
    [SerializeField]
    public class SaveDataE
    {
        public string[] chrmyoe;
        public string[] chrnae;
        public string[] partnae;
        public int[] hyojie;
        public int[] seibetsue;
        public string[] ctagnae;
        public string[] colornae;
        public string[] chrtexte;
        public string[] texte;
        public string[] colore;
        public string[] namee;
        public string[] texthe;
        public string[] texthoe;
        public string[] textcolore;
        public int[] bgchanteie;
        public string[] bgcnume;
        public int[] bgcdhanteie;
        public int[] bgcdge;
        public string[] bgcdnume;
        public int[] chaphanteie;
        public string[] chapnume;
        public int[] chaptypese;
        public int[] chapthanteie;
        public string[] chaptnume;
        public int[] chapanse;
        public int[] kakudaianse;
        public int[] kakudaitypese;
        public int[] kakudaihanteie;
        public string[] kakudainume;
        public int[] bgswhanteie;
        public string[] bgswnume;
        public int[] bglwhanteie;
        public string[] bglwnume;
        public int[] bgehanteie;
        public string[] bgenume;
        public int[] serioushanteie;
        public int[] hazimarihanteie;
        public string[] hazimarinume;
        public int[] chrchanteie;
        public string[] chrcnume;
        public int[] chrcdhanteie;
        public string[] chrcdnume;
        public int[] unazhanteie;
        public int[] unazce;
        public string[] unaznume;
        public int[] odorokihanteie;
        public int[] odorokice;
        public string[] odorokinume;
        public int[] daruhanteie;
        public int[] daruce;
        public string[] darunume;
        public string[] ocolore;
        public int[] bgmhanteie;
        public int[] bgmehanteie;
        public int[] bgmefhanteie;
        public string[] bgmnume;
        public string[] bgmenume;
        public string[] bgmefnume;
        public int[] videohanteie;
        public string[] videonume;
        public int[] ceventsyle;
    }
    SaveDataE e = new SaveDataE();

    void Start()
    {
        chart = new int[1];
        charth = new int[1];
        charts = new int[1];
        chartx=new int[1];
        chart[chart.Length - 1] = 0;
        six = 0;
        ceventsy = new string[2] { "キャラ変化(1)", "キャラ変化(2)" };
        tx = 0;
        textf = 1;
        textx = 0;
        configco.csavef = 2;
    }
    void Update()
    {
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
        if (loadf == 1 & Bgcontroller.sentakuflag == 1)
        {
            loadf = 0;
            Reload();
        }
        if (loadf == 2 & Bgcontroller.sentakuflag == 1)
        {
            loadf = 0;
            ReloadD1();
            ReloadD2();
        }
        else
        {
            loadf = 0;
        }
        mabatakif = chrcontroller.mabatakif;
        kf = chrcontroller.animf;
        ths = textho.Length - 1;

        loadflag = Load.loadflag;
        chr1x = chrcontroller.chr1x;
        chrcx = Bgcontroller.endflag;
        unazf = chrcontroller.daruf;
        chrcf = chrcontroller.chrcf;
        unazgage = TextManager.tanitime;
        chrcs = chrchantei.Length;
        bgcs = bgchantei.Length;
        bgcds = bgcdhantei.Length;
        odorokis = odorokihantei.Length;
        unazs = unazhantei.Length;
        darus = daruhantei.Length;
        bgcs = bgchantei.Length;
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
        bgmefs = bgmefhantei.Length;
        videos = videohantei.Length;
    }
    public void Reload()
    {
        filePath = Application.dataPath + "/SAVEDATA/json/part/" + sentakuknum[0] + ".json"; e = new SaveDataE();
        if (File.Exists(Application.dataPath + "/SAVEDATA/json/part/" + sentakuknum[0] + ".json"))
        {
            {
                var fs = new FileStream(
                   filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string datastr = "";
                StreamReader reader;
                reader = new StreamReader(fs);
                reader = new StreamReader(Application.dataPath + "/SAVEDATA/json/part/" + sentakuknum[0] + ".json");
                datastr = reader.ReadToEnd();
                reader.Close();
                e = JsonUtility.FromJson<SaveDataE>(datastr);
                chrmyo = e.chrmyoe;
                chrna = e.chrnae;
                seibetsu = e.seibetsue;
                partna = e.partnae;
                hyoji = e.hyojie;
                ctagna = e.ctagnae;
                colorna = e.colornae;
                chrtext = e.chrtexte;
                name = e.namee;
                color = e.colore;
                textcolor = e.textcolore;
                text = e.texte;
                texth = e.texthe;
                textho = e.texthoe;
                bgchantei = e.bgchanteie;
                bgcnum = e.bgcnume;
                bgcdhantei = e.bgcdhanteie;
                bgcdg = e.bgcdge;
                bgcdnum = e.bgcdnume;
                chaphantei = e.chaphanteie;
                chapnum = e.chapnume;
                chaptypes = e.chaptypese;
                chapthantei = e.chapthanteie;
                chaptnum = e.chaptnume;
                chapans = e.chapanse;
                kakudaians = e.kakudaianse;
                kakudaitypes = e.kakudaitypese;
                kakudaihantei = e.kakudaihanteie;
                kakudainum = e.kakudainume;
                bgswhantei = e.bgswhanteie;
                bgswnum = e.bgswnume;
                bglwhantei = e.bglwhanteie;
                bglwnum = e.bglwnume;
                bgehantei = e.bgehanteie;
                bgenum = e.bgenume;
                serioushantei = e.serioushanteie;
                hazimarihantei = e.hazimarihanteie;
                hazimarinum = e.hazimarinume;
                chrchantei = e.chrchanteie;
                chrcnum = e.chrcnume;
                List<string> list = new List<string>(chrcnum);
                list.RemoveAll(item => item == "");
                chrcnum = list.ToArray();
                chrcdhantei = e.chrcdhanteie;
                chrcdnum = e.chrcdnume;
                unazhantei = e.unazhanteie;
                unazc = e.unazce;
                unaznum = e.unaznume;
                odorokihantei = e.odorokihanteie;
                odorokic = e.odorokice;
                odorokinum = e.odorokinume;
                daruhantei = e.daruhanteie;
                daruc = e.daruce;
                darunum = e.darunume;
                ocolor = e.ocolore;
                bgmhantei = e.bgmhanteie;
                bgmnum = e.bgmnume;
                bgmehantei = e.bgmehanteie;
                bgmenum = e.bgmenume;
                bgmefhantei = e.bgmefhanteie;
                bgmefnum = e.bgmefnume;
                videohantei = e.videohanteie;
                videonum = e.videonume;
                ceventsyl = e.ceventsyle;
                if (aehantei[1] == 1)
                {
                    fadehantei = chrchantei;
                    fadeoiflag = ceventsyl;
                }
                edit.tnum = 0;
                edit.num = 0;
                edit.cnum = 0;
                edit.edit_num = chrna.Length;
                edit.edit_cnum = ctagna.Length;
                edit.edit_tnum = text.Length;
                chrcs = chrchantei.Length;
                bgcs = bgchantei.Length;
                bgcds = bgcdhantei.Length;
                odorokis = odorokihantei.Length;
                unazs = unazhantei.Length;
                darus = daruhantei.Length;
                bgcs = bgchantei.Length;
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
                bgmefs = bgmefhantei.Length;
                videos = videohantei.Length;
                charth[0] = textho.Length - 1;
                sentakus = 99999;
            }
            loadf = 2;
        }
        else
        {
            textho = new string[1] { "データがありません" };
            name = new string[1] { "" };
            color = new string[1] { "ffffff" };
            ocolor = new string[1] { "000000" };
        }
    }
    public void ReloadD1()
    {
        filePath = Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux)] + ".json"; e = new SaveDataE();
        if (File.Exists(Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux)] + ".json"))
        {
            {
                var fs = new FileStream(
                   filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string datastr = "";
                StreamReader reader;
                reader = new StreamReader(fs);
                reader = new StreamReader(Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux)] + ".json");
                datastr = reader.ReadToEnd();
                reader.Close();
                e = JsonUtility.FromJson<SaveDataE>(datastr);
                D1chrmyo = e.chrmyoe;
                D1chrna = e.chrnae;
                D1seibetsu = e.seibetsue;
                D1partna = e.partnae;
                D1hyoji = e.hyojie;
                D1ctagna = e.ctagnae;
                D1colorna = e.colornae;
                D1chrtext = e.chrtexte;
                D1name = e.namee;
                D1color = e.colore;
                D1textcolor = e.textcolore;
                D1text = e.texte;
                D1texth = e.texthe;
                D1textho = e.texthoe;
                D1bgchantei = e.bgchanteie;
                D1bgcnum = e.bgcnume;
                D1bgcdhantei = e.bgcdhanteie;
                D1bgcdg = e.bgcdge;
                D1bgcdnum = e.bgcdnume;
                D1chaphantei = e.chaphanteie;
                D1chapnum = e.chapnume;
                D1chaptypes = e.chaptypese;
                D1chapthantei = e.chapthanteie;
                D1chaptnum = e.chaptnume;
                D1chapans = e.chapanse;
                D1kakudaians = e.kakudaianse;
                D1kakudaitypes = e.kakudaitypese;
                D1kakudaihantei = e.kakudaihanteie;
                D1kakudainum = e.kakudainume;
                D1bgswhantei = e.bgswhanteie;
                D1bgswnum = e.bgswnume;
                D1bglwhantei = e.bglwhanteie;
                D1bglwnum = e.bglwnume;
                D1bgehantei = e.bgehanteie;
                D1bgenum = e.bgenume;
                D1serioushantei = e.serioushanteie;
                D1hazimarihantei = e.hazimarihanteie;
                D1hazimarinum = e.hazimarinume;
                D1chrchantei = e.chrchanteie;
                D1chrcnum = e.chrcnume;
                List<string> D1list = new List<string>(D1chrcnum);
                D1list.RemoveAll(item => item == "");
                D1chrcnum = D1list.ToArray();
                D1chrcdhantei = e.chrcdhanteie;
                D1chrcdnum = e.chrcdnume;
                D1unazhantei = e.unazhanteie;
                D1unazc = e.unazce;
                D1unaznum = e.unaznume;
                D1odorokihantei = e.odorokihanteie;
                D1odorokic = e.odorokice;
                D1odorokinum = e.odorokinume;
                D1daruhantei = e.daruhanteie;
                D1daruc = e.daruce;
                D1darunum = e.darunume;
                D1ocolor = e.ocolore;
                D1bgmhantei = e.bgmhanteie;
                D1bgmnum = e.bgmnume;
                D1bgmehantei = e.bgmehanteie;
                D1bgmenum = e.bgmenume;
                D1bgmefhantei = e.bgmefhanteie;
                D1bgmefnum = e.bgmefnume;
                D1videohantei = e.videohanteie;
                D1videonum = e.videonume;
                D1ceventsyl = e.ceventsyle;
            }

        }
    }
    public void ReloadD2()
    {
        filePath = Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux) + 1] + ".json"; e = new SaveDataE();
        if (File.Exists(Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux) + 1] + ".json"))
        {
            {
                var fs = new FileStream(
                   filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string datastr = "";
                StreamReader reader;
                reader = new StreamReader(fs);
                reader = new StreamReader(Application.dataPath + "/SAVEDATA/json/part/" + sentakudnum[2 * (Bgcontroller.sentakux) + 1] + ".json");
                datastr = reader.ReadToEnd();
                reader.Close();
                e = JsonUtility.FromJson<SaveDataE>(datastr);
                D2chrmyo = e.chrmyoe;
                D2chrna = e.chrnae;
                D2seibetsu = e.seibetsue;
                D2partna = e.partnae;
                D2hyoji = e.hyojie;
                D2ctagna = e.ctagnae;
                D2colorna = e.colornae;
                D2chrtext = e.chrtexte;
                D2name = e.namee;
                D2color = e.colore;
                D2textcolor = e.textcolore;
                D2text = e.texte;
                D2texth = e.texthe;
                D2textho = e.texthoe;
                D2bgchantei = e.bgchanteie;
                D2bgcnum = e.bgcnume;
                D2bgcdhantei = e.bgcdhanteie;
                D2bgcdg = e.bgcdge;
                D2bgcdnum = e.bgcdnume;
                D2chaphantei = e.chaphanteie;
                D2chapnum = e.chapnume;
                D2chaptypes = e.chaptypese;
                D2chapthantei = e.chapthanteie;
                D2chaptnum = e.chaptnume;
                D2chapans = e.chapanse;
                D2kakudaians = e.kakudaianse;
                D2kakudaitypes = e.kakudaitypese;
                D2kakudaihantei = e.kakudaihanteie;
                D2kakudainum = e.kakudainume;
                D2bgswhantei = e.bgswhanteie;
                D2bgswnum = e.bgswnume;
                D2bglwhantei = e.bglwhanteie;
                D2bglwnum = e.bglwnume;
                D2bgehantei = e.bgehanteie;
                D2bgenum = e.bgenume;
                D2serioushantei = e.serioushanteie;
                D2hazimarihantei = e.hazimarihanteie;
                D2hazimarinum = e.hazimarinume;
                D2chrchantei = e.chrchanteie;
                D2chrcnum = e.chrcnume;
                List<string> D2list = new List<string>(D2chrcnum);
                D2list.RemoveAll(item => item == "");
                D2chrcnum = D2list.ToArray();
                D2chrcdhantei = e.chrcdhanteie;
                D2chrcdnum = e.chrcdnume;
                D2unazhantei = e.unazhanteie;
                D2unazc = e.unazce;
                D2unaznum = e.unaznume;
                D2odorokihantei = e.odorokihanteie;
                D2odorokic = e.odorokice;
                D2odorokinum = e.odorokinume;
                D2daruhantei = e.daruhanteie;
                D2daruc = e.daruce;
                D2darunum = e.darunume;
                D2ocolor = e.ocolore;
                D2bgmhantei = e.bgmhanteie;
                D2bgmnum = e.bgmnume;
                D2bgmehantei = e.bgmehanteie;
                D2bgmenum = e.bgmenume;
                D2bgmefhantei = e.bgmefhanteie;
                D2bgmefnum = e.bgmefnume;
                D2videohantei = e.videohanteie;
                D2videonum = e.videonume;
                D2ceventsyl = e.ceventsyle;
            }

        }
    }
    public void Concat1()
    {
        List<string> D1texthol = new List<string>(textho);
        D1texthol.RemoveAll(item => item == "選択肢");
        textho = D1texthol.ToArray();
        List<string> D1namel = new List<string>(name);
        D1namel.RemoveAll(item => item == "選択肢");
        name = D1namel.ToArray();
        List<string> D1colorl = new List<string>(color);
        D1colorl.RemoveAll(item => item == "選択肢");
        color = D1colorl.ToArray();
        List<string> D1ocolorl = new List<string>(ocolor);
        D1ocolorl.RemoveAll(item => item == "選択肢");
        ocolor = D1ocolorl.ToArray();
        System.Array.Resize(ref chart, six + 1);
        System.Array.Resize(ref charts, six + 2);
        System.Array.Resize(ref charth, six + 2);
        System.Array.Resize(ref chartx, six + 2);
        chart[chart.Length - 1] = textho.Length;
        charts[six] = 1;
        D1bgchantei = System.Array.ConvertAll(D1bgchantei, delegate (int i) { return i + textho.Length ; });
        D1bgcdhantei = System.Array.ConvertAll(D1bgcdhantei, delegate (int i) { return i + textho.Length ; });
        D1chaphantei = System.Array.ConvertAll(D1chaphantei, delegate (int i) { return i + textho.Length ; });
        D1chapthantei = System.Array.ConvertAll(D1chapthantei, delegate (int i) { return i + textho.Length ; });
        D1kakudaihantei = System.Array.ConvertAll(D1kakudaihantei, delegate (int i) { return i + textho.Length ; });
        D1bgswhantei = System.Array.ConvertAll(D1bgswhantei, delegate (int i) { return i + textho.Length ; });
        D1bglwhantei = System.Array.ConvertAll(D1bglwhantei, delegate (int i) { return i + textho.Length ; });
        D1bgehantei = System.Array.ConvertAll(D1bgehantei, delegate (int i) { return i + textho.Length ; });
        D1serioushantei = System.Array.ConvertAll(D1serioushantei, delegate (int i) { return i + textho.Length ; });
        D1hazimarihantei = System.Array.ConvertAll(D1hazimarihantei, delegate (int i) { return i + textho.Length ; });
        D1chrchantei = System.Array.ConvertAll(D1chrchantei, delegate (int i) { return i + textho.Length ; });
        D1chrcdhantei = System.Array.ConvertAll(D1chrcdhantei, delegate (int i) { return i + textho.Length ; });
        D1unazhantei = System.Array.ConvertAll(D1unazhantei, delegate (int i) { return i + textho.Length ; });
        D1odorokihantei = System.Array.ConvertAll(D1odorokihantei, delegate (int i) { return i + textho.Length ; });
        D1daruhantei = System.Array.ConvertAll(D1daruhantei, delegate (int i) { return i + textho.Length ; });
        if (Bgcontroller.sentakux == 0) { Bgcontroller.sentakux += 1; chartx[chartx.Length - 1] = 1; } else { if (sentakutypes[Bgcontroller.sentakux] != 0) {Bgcontroller.sentakux += sentakutypes[Bgcontroller.sentakux] + 1; chartx[chartx.Length - 1] = sentakutypes[Bgcontroller.sentakux] + 1; } }
        chrmyo = chrmyo.Concat(D1chrmyo).ToArray();
        chrna = chrna.Concat(D1chrna).ToArray();
        seibetsu = seibetsu.Concat(D1seibetsu).ToArray();
        partna = partna.Concat(D1partna).ToArray();
        hyoji = hyoji.Concat(D1hyoji).ToArray();
        ctagna = ctagna.Concat(D1ctagna).ToArray();
        colorna = colorna.Concat(D1colorna).ToArray();
        chrtext = chrtext.Concat(D1chrtext).ToArray();
        name = name.Concat(D1name).ToArray();
        color = color.Concat(D1color).ToArray();
        textcolor = textcolor.Concat(D1textcolor).ToArray();
        text = text.Concat(D1text).ToArray();
        texth = texth.Concat(D1texth).ToArray();
        textho = textho.Concat(D1textho).ToArray();
        bgchantei = bgchantei.Concat(D1bgchantei).ToArray();
        bgcnum = bgcnum.Concat(D1bgcnum).ToArray();
        bgcdhantei = bgcdhantei.Concat(D1bgcdhantei).ToArray();
        bgcdg = bgcdg.Concat(D1bgcdg).ToArray();
        bgcdnum = bgcdnum.Concat(D1bgcdnum).ToArray();
        chaphantei = chaphantei.Concat(D1chaphantei).ToArray();
        chapnum = chapnum.Concat(D1chapnum).ToArray();
        chaptypes = chaptypes.Concat(D1chaptypes).ToArray();
        chapthantei = chapthantei.Concat(D1chapthantei).ToArray();
        chaptnum = chaptnum.Concat(D1chaptnum).ToArray();
        chapans = chapans.Concat(D1chapans).ToArray();
        kakudaians = kakudaians.Concat(D1kakudaians).ToArray();
        kakudaitypes = kakudaitypes.Concat(D1kakudaitypes).ToArray();
        kakudaihantei = kakudaihantei.Concat(D1kakudaihantei).ToArray();
        kakudainum = kakudainum.Concat(D1kakudainum).ToArray();
        bgswhantei = bgswhantei.Concat(D1bgswhantei).ToArray();
        bgswnum = bgswnum.Concat(D1bgswnum).ToArray();
        bglwhantei = bglwhantei.Concat(D1bglwhantei).ToArray();
        bglwnum = bglwnum.Concat(D1bglwnum).ToArray();
        bgehantei = bgehantei.Concat(D1bgehantei).ToArray();
        bgenum = bgenum.Concat(D1bgenum).ToArray();
        serioushantei = serioushantei.Concat(D1serioushantei).ToArray();
        hazimarihantei = hazimarihantei.Concat(D1hazimarihantei).ToArray();
        hazimarinum = hazimarinum.Concat(D1hazimarinum).ToArray();
        chrchantei = chrchantei.Concat(D1chrchantei).ToArray();
        chrcnum = chrcnum.Concat(D1chrcnum).ToArray();
        chrcdhantei = chrcdhantei.Concat(D1chrcdhantei).ToArray();
        chrcdnum = chrcdnum.Concat(D1chrcdnum).ToArray();
        unazhantei = unazhantei.Concat(D1unazhantei).ToArray();
        unazc = unazc.Concat(D1unazc).ToArray();
        unaznum = unaznum.Concat(D1unaznum).ToArray();
        odorokihantei = odorokihantei.Concat(D1odorokihantei).ToArray();
        odorokic = odorokic.Concat(D1odorokic).ToArray();
        odorokinum = odorokinum.Concat(D1odorokinum).ToArray();
        daruhantei = daruhantei.Concat(D1daruhantei).ToArray();
        daruc = daruc.Concat(D1daruc).ToArray();
        darunum = darunum.Concat(D1darunum).ToArray();
        ocolor = ocolor.Concat(D1ocolor).ToArray();
        bgmhantei = bgmhantei.Concat(D1bgmhantei).ToArray();
        bgmnum = bgmnum.Concat(D1bgmnum).ToArray();
        bgmehantei = bgmehantei.Concat(D1bgmehantei).ToArray();
        bgmenum = bgmenum.Concat(D1bgmenum).ToArray();
        bgmefhantei = bgmefhantei.Concat(D1bgmefhantei).ToArray();
        bgmefnum = bgmefnum.Concat(D1bgmefnum).ToArray();
        videohantei = videohantei.Concat(D1videohantei).ToArray();
        videonum = videonum.Concat(D1videonum).ToArray();
        ceventsyl = ceventsyl.Concat(D1ceventsyl).ToArray();
        //背景変化
        List<int> D1bgchanteil = new List<int>(bgchantei);
        D1bgchanteil.RemoveAll(item => item >=99999);
        bgchantei = D1bgchanteil.ToArray();
        List<string> D1bgcnuml = new List<string>(bgcnum);
        D1bgcnuml.RemoveAll(item => item == "" | item == null);
        bgcnum = D1bgcnuml.ToArray();
        //背景変化(複数)
        List<int> D1bgcdhanteil = new List<int>(bgcdhantei);
        D1bgcdhanteil.RemoveAll(item => item >=99999);
        bgcdhantei = D1bgcdhanteil.ToArray();
        List<int> D1bgcdgl = new List<int>(bgcdg);
        D1bgcdgl.RemoveAll(item => item == 0);
        bgcdg = D1bgcdgl.ToArray();
        List<string> D1bgcdnuml = new List<string>(bgcdnum);
        D1bgcdnuml.RemoveAll(item => item == "" | item == null);
        bgcdnum = D1bgcdnuml.ToArray();
        //暗幕
        List<int> D1chaphanteil = new List<int>(chaphantei);
        D1chaphanteil.RemoveAll(item => item >=99999);
        chaphantei = D1chaphanteil.ToArray();
        List<string> D1chapnuml = new List<string>(chapnum);
        D1chapnuml.RemoveAll(item => item == "" | item == null);
        chapnum = D1chapnuml.ToArray();
        List<int> D1chaptypesl = new List<int>(chaptypes);
        D1chaptypesl.RemoveAll(item => item ==3);
        chaptypes = D1chaptypesl.ToArray();
        //アイキャッチ
        List<int> D1chapthanteil = new List<int>(chapthantei);
        D1chapthanteil.RemoveAll(item => item >=99999);
        chapthantei = D1chapthanteil.ToArray();
        List<string> D1chaptnuml = new List<string>(chaptnum);
        D1chaptnuml.RemoveAll(item => item == "" | item == null);
        chaptnum = D1chaptnuml.ToArray();
        List<int> D1chapansl = new List<int>(chapans);
        D1chapansl.RemoveAll(item => item >=99999);
        chapans = D1chapansl.ToArray();
        //拡大
        List<int> D1kakudaiansl = new List<int>(kakudaians);
        D1kakudaiansl.RemoveAll(item => item >=99999);
        kakudaians = D1kakudaiansl.ToArray();
        List<int> D1kakudaitypesl = new List<int>(kakudaitypes);
        D1kakudaitypesl.RemoveAll(item => item ==5);
        kakudaitypes = D1kakudaitypesl.ToArray();
        List<int> D1kakudaihanteil = new List<int>(kakudaihantei);
        D1kakudaihanteil.RemoveAll(item => item >=99999);
        kakudaihantei = D1kakudaihanteil.ToArray();
        List<string> D1kakudainuml = new List<string>(kakudainum);
        D1kakudainuml.RemoveAll(item => item == "" | item == null);
        kakudainum = D1kakudainuml.ToArray();
        //小パネル表示
        List<int> D1bgswhanteil = new List<int>(bgswhantei);
        D1bgswhanteil.RemoveAll(item => item >=99999);
        bgswhantei = D1bgswhanteil.ToArray();
        //大パネル表示
        List<int> D1bglwhanteil = new List<int>(bglwhantei);
        D1bglwhanteil.RemoveAll(item => item >=99999);
        bglwhantei = D1bglwhanteil.ToArray();
        //背景効果
        List<int> D1bgehanteil = new List<int>(bgehantei);
        D1bgehanteil.RemoveAll(item => item >=99999);
        bgehantei = D1bgehanteil.ToArray();
        List<string> D1bgenuml = new List<string>(bgenum);
        D1bgenuml.RemoveAll(item => item == "" | item == null);
        bgenum = D1bgenuml.ToArray();
        //テキストパネル非表示
        List<int> D1serioushanteil = new List<int>(serioushantei);
        D1serioushanteil.RemoveAll(item => item >=99999);
        serioushantei = D1serioushanteil.ToArray();
        //テキスト中央表示
        List<int> D1hazimarihanteil = new List<int>(hazimarihantei);
        D1hazimarihanteil.RemoveAll(item => item >=99999);
        hazimarihantei = D1hazimarihanteil.ToArray();
        List<string> D1hazimarinuml = new List<string>(hazimarinum);
        D1hazimarinuml.RemoveAll(item => item == "" | item == null);
        hazimarinum = D1hazimarinuml.ToArray();
        //キャラ表示(1)
        List<int> D1chrchanteil = new List<int>(chrchantei);
        D1chrchanteil.RemoveAll(item => item >=99999);
        chrchantei = D1chrchanteil.ToArray();
        List<string> D1chrcnuml = new List<string>(chrcnum);
        D1chrcnuml.RemoveAll(item => item == "" | item == null);
        chrcnum = D1chrcnuml.ToArray();
        List<int> D1ceventsyll = new List<int>(ceventsyl);
        D1ceventsyll.RemoveAll(item => item ==2);
        ceventsyl = D1ceventsyll.ToArray();
        //キャラ表示(2)
        List<int> D1chrcdhanteil = new List<int>(chrcdhantei);
        D1chrcdhanteil.RemoveAll(item => item >=99999);
        chrcdhantei = D1chrcdhanteil.ToArray();
        List<string> D1chrcdnuml = new List<string>(chrcdnum);
        D1chrcdnuml.RemoveAll(item => item == "" | item == null);
        chrcdnum = D1chrcdnuml.ToArray();
        //上下移動
        List<int> D1unazhanteil = new List<int>(unazhantei);
        D1unazhanteil.RemoveAll(item => item >=99999);
        unazhantei = D1unazhanteil.ToArray();
        List<int> D1unazcl = new List<int>(unazc);
        D1unazcl.RemoveAll(item => item >=99999);
        unazc = D1unazcl.ToArray();
        List<string> D1unaznuml = new List<string>(unaznum);
        D1unaznuml.RemoveAll(item => item == "" | item == null);
        unaznum = D1unaznuml.ToArray();
        //上下移動(高速)
        List<int> D1odorokihanteil = new List<int>(odorokihantei);
        D1odorokihanteil.RemoveAll(item => item >=99999);
        odorokihantei = D1odorokihanteil.ToArray();
        List<int> D1odorokicl = new List<int>(odorokic);
        D1odorokicl.RemoveAll(item => item >=99999);
        odorokic = D1odorokicl.ToArray();
        List<string> D1odorokinuml = new List<string>(odorokinum);
        D1odorokinuml.RemoveAll(item => item == "" | item == null);
        odorokinum = D1odorokinuml.ToArray();
        //左右移動
        List<int> D1daruhanteil = new List<int>(daruhantei);
        D1daruhanteil.RemoveAll(item => item >=99999);
        daruhantei = D1daruhanteil.ToArray();
        List<int> D1darucl = new List<int>(daruc);
        D1darucl.RemoveAll(item => item >=99999);
        daruc = D1darucl.ToArray();
        List<string> D1darunuml = new List<string>(darunum);
        D1darunuml.RemoveAll(item => item == "" | item == null);
        darunum = D1darunuml.ToArray();
        //BGM
        List<int> D1bgmhanteil = new List<int>(bgmhantei);
        D1bgmhanteil.RemoveAll(item => item >=99999);
        bgmhantei = D1bgmhanteil.ToArray();
        List<string> D1bgmnuml = new List<string>(bgmnum);
        D1bgmnuml.RemoveAll(item => item == "" | item == null);
        bgmnum = D1bgmnuml.ToArray();
        //環境音
        List<int> D1bgmehanteil = new List<int>(bgmehantei);
        D1bgmehanteil.RemoveAll(item => item >=99999);
        bgmehantei = D1bgmehanteil.ToArray();
        List<string> D1bgmenuml = new List<string>(bgmenum);
        D1bgmenuml.RemoveAll(item => item == "" | item == null);
        bgmenum = D1bgmenuml.ToArray();
        //効果音
        List<int> D1bgmefhanteil = new List<int>(bgmefhantei);
        D1bgmefhanteil.RemoveAll(item => item >=99999);
        bgmefhantei = D1bgmefhanteil.ToArray();
        List<string> D1bgmefnuml = new List<string>(bgmefnum);
        D1bgmefnuml.RemoveAll(item => item == "" | item == null);
        bgmefnum = D1bgmefnuml.ToArray();
        //映像
        List<int> D1videohanteil = new List<int>(videohantei);
        D1videohanteil.RemoveAll(item => item >=99999);
        videohantei = D1videohanteil.ToArray();
        List<string> D1videonuml = new List<string>(videonum);
        D1videonuml.RemoveAll(item => item == "" | item == null);
        videonum = D1videonuml.ToArray();
        chrcs = chrchantei.Length;
        bgcs = bgchantei.Length;
        bgcds = bgcdhantei.Length;
        odorokis = odorokihantei.Length;
        unazs = unazhantei.Length;
        darus = daruhantei.Length;
        bgcs = bgchantei.Length;
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
        bgmefs = bgmefhantei.Length;
        videos = videohantei.Length;
        if (aehantei[1] == 1)
        {
            fadehantei = chrchantei;
            fadeoiflag = ceventsyl;
        }
        charth[six+1] = textho.Length-1;
        loadf = 2;
    }
    public void Concat2()
    {
        List<string> D2texthol = new List<string>(textho);
        D2texthol.RemoveAll(item => item == "選択肢");
        textho = D2texthol.ToArray();
        List<string> D2namel = new List<string>(name);
        D2namel.RemoveAll(item => item == "選択肢");
        name = D2namel.ToArray();
        List<string> D2colorl = new List<string>(color);
        D2colorl.RemoveAll(item => item == "選択肢");
        color = D2colorl.ToArray();
        List<string> D2ocolorl = new List<string>(ocolor);
        D2ocolorl.RemoveAll(item => item == "選択肢");
        ocolor = D2ocolorl.ToArray();
        System.Array.Resize(ref chart, six+2);
        System.Array.Resize(ref charts, six+1);
        System.Array.Resize(ref charth, six+2);
        System.Array.Resize(ref chartx, six+2);
        chart[chart.Length - 1] = textho.Length;
        charts[six] = 2;
        D2bgchantei = System.Array.ConvertAll(D2bgchantei, delegate (int i) { return i + textho.Length ; });
        D2bgcdhantei = System.Array.ConvertAll(D2bgcdhantei, delegate (int i) { return i + textho.Length ; });
        D2chaphantei = System.Array.ConvertAll(D2chaphantei, delegate (int i) { return i + textho.Length ; });
        D2chapthantei = System.Array.ConvertAll(D2chapthantei, delegate (int i) { return i + textho.Length ; });
        D2kakudaihantei = System.Array.ConvertAll(D2kakudaihantei, delegate (int i) { return i + textho.Length ; });
        D2bgswhantei = System.Array.ConvertAll(D2bgswhantei, delegate (int i) { return i + textho.Length ; });
        D2bglwhantei = System.Array.ConvertAll(D2bglwhantei, delegate (int i) { return i + textho.Length ; });
        D2bgehantei = System.Array.ConvertAll(D2bgehantei, delegate (int i) { return i + textho.Length ; });
        D2serioushantei = System.Array.ConvertAll(D2serioushantei, delegate (int i) { return i + textho.Length ; });
        D2hazimarihantei = System.Array.ConvertAll(D2hazimarihantei, delegate (int i) { return i + textho.Length ; });
        D2chrchantei = System.Array.ConvertAll(D2chrchantei, delegate (int i) { return i + textho.Length ; });
        D2chrcdhantei = System.Array.ConvertAll(D2chrcdhantei, delegate (int i) { return i + textho.Length ; });
        D2unazhantei = System.Array.ConvertAll(D2unazhantei, delegate (int i) { return i + textho.Length ; });
        D2odorokihantei = System.Array.ConvertAll(D2odorokihantei, delegate (int i) { return i + textho.Length ; });
        D2daruhantei = System.Array.ConvertAll(D2daruhantei, delegate (int i) { return i + textho.Length ; });
        if (Bgcontroller.sentakux == 0) { Bgcontroller.sentakux += 2; chartx[chartx.Length - 1] = 2; } else { if (sentakutypes[Bgcontroller.sentakux] != 0) { Bgcontroller.sentakux += sentakutypes[Bgcontroller.sentakux-1]+ 2; chartx[chartx.Length - 1] = sentakutypes[Bgcontroller.sentakux]+ 2; } }
        chrmyo = chrmyo.Concat(D2chrmyo).ToArray();
        chrna = chrna.Concat(D2chrna).ToArray();
        seibetsu = seibetsu.Concat(D2seibetsu).ToArray();
        partna = partna.Concat(D2partna).ToArray();
        hyoji = hyoji.Concat(D2hyoji).ToArray();
        ctagna = ctagna.Concat(D2ctagna).ToArray();
        colorna = colorna.Concat(D2colorna).ToArray();
        chrtext = chrtext.Concat(D2chrtext).ToArray();
        name = name.Concat(D2name).ToArray();
        color = color.Concat(D2color).ToArray();
        textcolor = textcolor.Concat(D2textcolor).ToArray();
        text = text.Concat(D2text).ToArray();
        texth = texth.Concat(D2texth).ToArray();
        textho = textho.Concat(D2textho).ToArray();
        bgchantei = bgchantei.Concat(D2bgchantei).ToArray();
        bgcnum = bgcnum.Concat(D2bgcnum).ToArray();
        bgcdhantei = bgcdhantei.Concat(D2bgcdhantei).ToArray();
        bgcdg = bgcdg.Concat(D2bgcdg).ToArray();
        bgcdnum = bgcdnum.Concat(D2bgcdnum).ToArray();
        chaphantei = chaphantei.Concat(D2chaphantei).ToArray();
        chapnum = chapnum.Concat(D2chapnum).ToArray();
        chaptypes = chaptypes.Concat(D2chaptypes).ToArray();
        chapthantei = chapthantei.Concat(D2chapthantei).ToArray();
        chaptnum = chaptnum.Concat(D2chaptnum).ToArray();
        chapans = chapans.Concat(D2chapans).ToArray();
        kakudaians = kakudaians.Concat(D2kakudaians).ToArray();
        kakudaitypes = kakudaitypes.Concat(D2kakudaitypes).ToArray();
        kakudaihantei = kakudaihantei.Concat(D2kakudaihantei).ToArray();
        kakudainum = kakudainum.Concat(D2kakudainum).ToArray();
        bgswhantei = bgswhantei.Concat(D2bgswhantei).ToArray();
        bgswnum = bgswnum.Concat(D2bgswnum).ToArray();
        bglwhantei = bglwhantei.Concat(D2bglwhantei).ToArray();
        bglwnum = bglwnum.Concat(D2bglwnum).ToArray();
        bgehantei = bgehantei.Concat(D2bgehantei).ToArray();
        bgenum = bgenum.Concat(D2bgenum).ToArray();
        serioushantei = serioushantei.Concat(D2serioushantei).ToArray();
        hazimarihantei = hazimarihantei.Concat(D2hazimarihantei).ToArray();
        hazimarinum = hazimarinum.Concat(D2hazimarinum).ToArray();
        chrchantei = chrchantei.Concat(D2chrchantei).ToArray();
        chrcnum = chrcnum.Concat(D2chrcnum).ToArray();
        chrcdhantei = chrcdhantei.Concat(D2chrcdhantei).ToArray();
        chrcdnum = chrcdnum.Concat(D2chrcdnum).ToArray();
        unazhantei = unazhantei.Concat(D2unazhantei).ToArray();
        unazc = unazc.Concat(D2unazc).ToArray();
        unaznum = unaznum.Concat(D2unaznum).ToArray();
        odorokihantei = odorokihantei.Concat(D2odorokihantei).ToArray();
        odorokic = odorokic.Concat(D2odorokic).ToArray();
        odorokinum = odorokinum.Concat(D2odorokinum).ToArray();
        daruhantei = daruhantei.Concat(D2daruhantei).ToArray();
        daruc = daruc.Concat(D2daruc).ToArray();
        darunum = darunum.Concat(D2darunum).ToArray();
        ocolor = ocolor.Concat(D2ocolor).ToArray();
        bgmhantei = bgmhantei.Concat(D2bgmhantei).ToArray();
        bgmnum = bgmnum.Concat(D2bgmnum).ToArray();
        bgmehantei = bgmehantei.Concat(D2bgmehantei).ToArray();
        bgmenum = bgmenum.Concat(D2bgmenum).ToArray();
        bgmefhantei = bgmefhantei.Concat(D2bgmefhantei).ToArray();
        bgmefnum = bgmefnum.Concat(D2bgmefnum).ToArray();
        videohantei = videohantei.Concat(D2videohantei).ToArray();
        videonum = videonum.Concat(D2videonum).ToArray();
        ceventsyl = ceventsyl.Concat(D2ceventsyl).ToArray();
        //背景変化
        List<int> D2bgchanteil = new List<int>(bgchantei);
        D2bgchanteil.RemoveAll(item => item >=99999);
        bgchantei = D2bgchanteil.ToArray();
        List<string> D2bgcnuml = new List<string>(bgcnum);
        D2bgcnuml.RemoveAll(item => item == "" | item == null);
        bgcnum = D2bgcnuml.ToArray();
        //背景変化(複数)
        List<int> D2bgcdhanteil = new List<int>(bgcdhantei);
        D2bgcdhanteil.RemoveAll(item => item >=99999);
        bgcdhantei = D2bgcdhanteil.ToArray();
        List<int> D2bgcdgl = new List<int>(bgcdg);
        D2bgcdgl.RemoveAll(item => item == 0);
        bgcdg = D2bgcdgl.ToArray();
        List<string> D2bgcdnuml = new List<string>(bgcdnum);
        D2bgcdnuml.RemoveAll(item => item == "" | item == null);
        bgcdnum = D2bgcdnuml.ToArray();
        //暗幕
        List<int> D2chaphanteil = new List<int>(chaphantei);
        D2chaphanteil.RemoveAll(item => item >=99999);
        chaphantei = D2chaphanteil.ToArray();
        List<string> D2chapnuml = new List<string>(chapnum);
        D2chapnuml.RemoveAll(item => item == "" | item == null);
        chapnum = D2chapnuml.ToArray();
        List<int> D2chaptypesl = new List<int>(chaptypes);
        D2chaptypesl.RemoveAll(item => item ==3);
        chaptypes = D2chaptypesl.ToArray();
        //アイキャッチ
        List<int> D2chapthanteil = new List<int>(chapthantei);
        D2chapthanteil.RemoveAll(item => item >=99999);
        chapthantei = D2chapthanteil.ToArray();
        List<string> D2chaptnuml = new List<string>(chaptnum);
        D2chaptnuml.RemoveAll(item => item == "" | item == null);
        chaptnum = D2chaptnuml.ToArray();
        List<int> D2chapansl = new List<int>(chapans);
        D2chapansl.RemoveAll(item => item >=99999);
        chapans = D2chapansl.ToArray();
        //拡大
        List<int> D2kakudaiansl = new List<int>(kakudaians);
        D2kakudaiansl.RemoveAll(item => item >=99999);
        kakudaians = D2kakudaiansl.ToArray();
        List<int> D2kakudaitypesl = new List<int>(kakudaitypes);
        D2kakudaitypesl.RemoveAll(item => item ==5);
        kakudaitypes = D2kakudaitypesl.ToArray();
        List<int> D2kakudaihanteil = new List<int>(kakudaihantei);
        D2kakudaihanteil.RemoveAll(item => item >=99999);
        kakudaihantei = D2kakudaihanteil.ToArray();
        List<string> D2kakudainuml = new List<string>(kakudainum);
        D2kakudainuml.RemoveAll(item => item == "" | item == null);
        kakudainum = D2kakudainuml.ToArray();
        //小パネル表示
        List<int> D2bgswhanteil = new List<int>(bgswhantei);
        D2bgswhanteil.RemoveAll(item => item >=99999);
        bgswhantei = D2bgswhanteil.ToArray();
        //大パネル表示
        List<int> D2bglwhanteil = new List<int>(bglwhantei);
        D2bglwhanteil.RemoveAll(item => item >=99999);
        bglwhantei = D2bglwhanteil.ToArray();
        //背景効果
        List<int> D2bgehanteil = new List<int>(bgehantei);
        D2bgehanteil.RemoveAll(item => item >=99999);
        bgehantei = D2bgehanteil.ToArray();
        List<string> D2bgenuml = new List<string>(bgenum);
        D2bgenuml.RemoveAll(item => item == "" | item == null);
        bgenum = D2bgenuml.ToArray();
        //テキストパネル非表示
        List<int> D2serioushanteil = new List<int>(serioushantei);
        D2serioushanteil.RemoveAll(item => item >=99999);
        serioushantei = D2serioushanteil.ToArray();
        //テキスト中央表示
        List<int> D2hazimarihanteil = new List<int>(hazimarihantei);
        D2hazimarihanteil.RemoveAll(item => item >=99999);
        hazimarihantei = D2hazimarihanteil.ToArray();
        List<string> D2hazimarinuml = new List<string>(hazimarinum);
        D2hazimarinuml.RemoveAll(item => item == "" | item == null);
        hazimarinum = D2hazimarinuml.ToArray();
        //キャラ表示(1)
        List<int> D2chrchanteil = new List<int>(chrchantei);
        D2chrchanteil.RemoveAll(item => item >=99999);
        chrchantei = D2chrchanteil.ToArray();
        List<string> D2chrcnuml = new List<string>(chrcnum);
        D2chrcnuml.RemoveAll(item => item == "" | item == null);
        chrcnum = D2chrcnuml.ToArray();
        List<int> D2ceventsyll = new List<int>(ceventsyl);
        D2ceventsyll.RemoveAll(item => item ==2);
        ceventsyl = D2ceventsyll.ToArray();
        //キャラ表示(2)
        List<int> D2chrcdhanteil = new List<int>(chrcdhantei);
        D2chrcdhanteil.RemoveAll(item => item >=99999);
        chrcdhantei = D2chrcdhanteil.ToArray();
        List<string> D2chrcdnuml = new List<string>(chrcdnum);
        D2chrcdnuml.RemoveAll(item => item == "" | item == null);
        chrcdnum = D2chrcdnuml.ToArray();
        //上下移動
        List<int> D2unazhanteil = new List<int>(unazhantei);
        D2unazhanteil.RemoveAll(item => item >=99999);
        unazhantei = D2unazhanteil.ToArray();
        List<int> D2unazcl = new List<int>(unazc);
        D2unazcl.RemoveAll(item => item >=99999);
        unazc = D2unazcl.ToArray();
        List<string> D2unaznuml = new List<string>(unaznum);
        D2unaznuml.RemoveAll(item => item == "" | item == null);
        unaznum = D2unaznuml.ToArray();
        //上下移動(高速)
        List<int> D2odorokihanteil = new List<int>(odorokihantei);
        D2odorokihanteil.RemoveAll(item => item >=99999);
        odorokihantei = D2odorokihanteil.ToArray();
        List<int> D2odorokicl = new List<int>(odorokic);
        D2odorokicl.RemoveAll(item => item >=99999);
        odorokic = D2odorokicl.ToArray();
        List<string> D2odorokinuml = new List<string>(odorokinum);
        D2odorokinuml.RemoveAll(item => item == "" | item == null);
        odorokinum = D2odorokinuml.ToArray();
        //左右移動
        List<int> D2daruhanteil = new List<int>(daruhantei);
        D2daruhanteil.RemoveAll(item => item >=99999);
        daruhantei = D2daruhanteil.ToArray();
        List<int> D2darucl = new List<int>(daruc);
        D2darucl.RemoveAll(item => item >=99999);
        daruc = D2darucl.ToArray();
        List<string> D2darunuml = new List<string>(darunum);
        D2darunuml.RemoveAll(item => item == "" | item == null);
        darunum = D2darunuml.ToArray();
        //BGM
        List<int> D2bgmhanteil = new List<int>(bgmhantei);
        D2bgmhanteil.RemoveAll(item => item >=99999);
        bgmhantei = D2bgmhanteil.ToArray();
        List<string> D2bgmnuml = new List<string>(bgmnum);
        D2bgmnuml.RemoveAll(item => item == "" | item == null);
        bgmnum = D2bgmnuml.ToArray();
        //環境音
        List<int> D2bgmehanteil = new List<int>(bgmehantei);
        D2bgmehanteil.RemoveAll(item => item >=99999);
        bgmehantei = D2bgmehanteil.ToArray();
        List<string> D2bgmenuml = new List<string>(bgmenum);
        D2bgmenuml.RemoveAll(item => item == "" | item == null);
        bgmenum = D2bgmenuml.ToArray();
        //効果音
        List<int> D2bgmefhanteil = new List<int>(bgmefhantei);
        D2bgmefhanteil.RemoveAll(item => item >=99999);
        bgmefhantei = D2bgmefhanteil.ToArray();
        List<string> D2bgmefnuml = new List<string>(bgmefnum);
        D2bgmefnuml.RemoveAll(item => item == "" | item == null);
        bgmefnum = D2bgmefnuml.ToArray();
        //映像
        List<int> D2videohanteil = new List<int>(videohantei);
        D2videohanteil.RemoveAll(item => item >=99999);
        videohantei = D2videohanteil.ToArray();
        List<string> D2videonuml = new List<string>(videonum);
        D2videonuml.RemoveAll(item => item == "" | item == null);
        videonum = D2videonuml.ToArray();
        chrcs = chrchantei.Length;
        bgcs = bgchantei.Length;
        bgcds = bgcdhantei.Length;
        odorokis = odorokihantei.Length;
        unazs = unazhantei.Length;
        darus = daruhantei.Length;
        bgcs = bgchantei.Length;
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
        bgmefs = bgmefhantei.Length;
        videos = videohantei.Length;
        if (aehantei[1] == 1)
        {
            fadehantei = chrchantei;
            fadeoiflag = ceventsyl;
        }
        charth[six+1] = textho.Length-1;
        loadf = 2;
    }
}
