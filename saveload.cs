using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveload : MonoBehaviour
{

    string filePath;
    public int text_lnum;
    public int chrcxl;
    public int chr1xl;
    public int chr2xl;
    public int chr3xl;
    public static int loadf;
    public int text_snum;
    public int bgcxl;
    public int bgcdxl;
    public int bgcduxl;
    public int chapxl;
    public int chaptxl;
    public string savename;
    public static string savesname;
    public static int savef;
    public float savetime;
    public static int sllf;
    textti script;

    [SerializeField]
    public class SaveData
    {
        //テスト用の文字列
        public int text_lnum;
        public int chrcxl;
        public int chr1xl;
        public int chr2xl;
        public int chr3xl;
        public string chr1bodyl;
        public string chr2bodyl;
        public string chr3bodyl;
        public int bgcxl;
        public int bgcdxl;
        public int bgcduxl;
        public int chapxl;
        public int chappxl;
        public int chaptxl;
        public int fadexl;
        public int cpxl;
        public int unazxl;
        public int odorokixl;
        public int arrivexl;
       public int daruxl;
        public int okiagarixl;
        public int unaz1xl;
        public int unaz2xl;
        public int unaz3xl;
        public int odoroki1xl;
        public int odoroki2xl;
        public int odoroki3xl;
        public int daru1xl;
        public int daru2xl;
        public int daru3xl;
        public int okiagari1xl;
        public int okiagari2xl;
        public int okiagari3xl;
        public int kakudaixl;
        public int[] charte;
        public int sixe;
        public string[] chrmyoe;
        public string[] chrnae;
        public string[] partnae;
        public int[] hyojie;
        public int[] seibetsue;
        public string[] ctagnae;
        public string[] colornae;
        public string[] chrtexte;
        public string[] texte;
        public string[] texthe;
        public string[] texthoe;
        public string[] textcolore;
        public string[] namee;
        public string[] colore;
        public string[][] cpice;
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
        public string[] ocolornae;
        public string[] textocolore;
        public string[] ocolore;
        public string[] bikoue;
        public int[] bgmhanteie;
        public int[] bgmehanteie;
        public int[] bgmefhanteie;
        public string[] bgmnume;
        public string[] bgmenume;
        public string[] bgmefnume;
        public int[] videohanteie;
        public string[] videonume;
        public int sentakuxe;
        public int[] chartxe;
        public int[] charthe;
        public int[] chartse;
        public int[] ceventsyle;
        public int[] aehanteie;
        public int cx;
    }
    SaveData save = new SaveData();
    void Awake()
    {
        filePath = Application.dataPath + "/SAVEDATA/savedata/"+textti.loaddata+"/" + savesname+ ".json"; save = new SaveData();

    }
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            script = GameObject.Find("textti").GetComponent<textti>();
        }
        savef = 0;
    }
    void Update()
    {
        text_snum = TextManager.text_num;
        save.text_lnum = TextManager.text_num;
        save.chrcxl = chrcontroller.chrcx;
        save.chr1xl = chrcontroller.chr1x;
        save.chr2xl = chrcontroller.chr2x;
        save.chr3xl = chrcontroller.chr3x;
        save.unazxl = chrcontroller.unazx;
        save.odorokixl = chrcontroller.odorokix;
        save.arrivexl = chrcontroller.arrivex;
        save.daruxl = chrcontroller.darux;
        save.fadexl = Bgcontroller.fadex;
        save.okiagarixl = chrcontroller.okiagarix;
        save.bgcxl = Bgcontroller.bgcx;
        save.bgcdxl = Bgcontroller.bgcdx;
        save.bgcduxl = Bgcontroller.bgcdux;
        save.chapxl = Bgcontroller.chapx;
        save.chappxl = Bgcontroller.chappx;
        save.chaptxl = Bgcontroller.chaptx;
        save.kakudaixl = Bgcontroller.kakudaix;
        save.unaz1xl = chrcontroller.unaz1x;
        save.unaz2xl = chrcontroller.unaz2x;
        save.unaz3xl = chrcontroller.unaz3x;
        save.odoroki1xl = chrcontroller.odoroki1x;
        save.odoroki2xl = chrcontroller.odoroki2x;
        save.odoroki3xl = chrcontroller.odoroki3x;
        save.daru1xl = chrcontroller.daru1x;
        save.daru2xl = chrcontroller.daru2x;
        save.daru3xl = chrcontroller.daru3x;
        save.okiagari1xl = chrcontroller.okiagari1x;
        save.okiagari2xl = chrcontroller.okiagari2x;
        save.okiagari3xl = chrcontroller.okiagari3x;
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            save.charte = script.chart;
            save.chartxe = script.chartx;
            save.charthe = script.charth;
            save.sixe = textti.six;
            save.texte = script.text;
            save.texthe = script.texth;
            save.texthoe = script.textho;
            save.chrtexte = script.chrtext;
            save.chrnae = script.chrna;
            save.partnae = script.partna;
            save.seibetsue = script.seibetsu;
            save.chrmyoe = script.chrmyo;
            save.hyojie = script.hyoji;
            save.ctagnae = script.ctagna;
            save.colornae = script.colorna;
            save.namee = script.name;
            save.colore = script.color;
            save.cpice = script.cpic;
            save.bgchanteie = script.bgchantei;
            save.bgcnume = script.bgcnum;
            save.bgcdhanteie = script.bgcdhantei;
            save.bgcdge = script.bgcdg;
            save.bgcdnume = script.bgcdnum;
            save.unazhanteie = script.unazhantei;
            save.unazce = script.unazc;
            save.unaznume = script.unaznum;
            save.odorokihanteie = script.odorokihantei;
            save.odorokice = script.odorokic;
            save.odorokinume = script.odorokinum;
            save.daruhanteie = script.daruhantei;
            save.daruce = script.daruc;
            save.darunume = script.darunum;
            save.chaphanteie = script.chaphantei;
            save.chapnume = script.chapnum;
            save.chaptypese = script.chaptypes;
            save.chapthanteie = script.chapthantei;
            save.chaptnume = script.chaptnum;
            save.chapanse = script.chapans;
            save.kakudaianse = script.kakudaians;
            save.kakudaitypese = script.kakudaitypes;
            save.kakudaihanteie = script.kakudaihantei;
            save.kakudainume = script.kakudainum;
            save.bgswhanteie = script.bgswhantei;
            save.bgswnume = script.bgswnum;
            save.bglwhanteie = script.bglwhantei;
            save.bglwnume = script.bglwnum;
            save.bgehanteie = script.bgehantei;
            save.bgenume = script.bgenum;
            save.serioushanteie = script.serioushantei;
            save.hazimarihanteie = script.hazimarihantei;
            save.hazimarinume = script.hazimarinum;
            save.chrchanteie = script.chrchantei;
            save.chrcnume = script.chrcnum;
            save.chrcdhanteie = script.chrcdhantei;
            save.chrcdnume = script.chrcdnum;
            save.ocolore = script.ocolor;
            save.bgmhanteie = script.bgmhantei;
            save.bgmnume = script.bgmnum;
            save.bgmehanteie = script.bgmehantei;
            save.bgmenume = script.bgmenum;
            save.bgmefhanteie = script.bgmefhantei;
            save.bgmefnume = script.bgmefnum;
            save.videohanteie = script.videohantei;
            save.videonume = script.videonum;
            save.sentakuxe = Bgcontroller.sentakux;
            save.chartse = script.charts;
            save.ceventsyle = script.ceventsyl;
        }
        if (savef>=1&savetime<=1)
        {
            savetime += Time.deltaTime;
        }
        else
        {
            savef = 0;
            savetime = 0;
        }
        if (sllf==1)
        {
            if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + savesname + ".json"))
            {
                sllf = 0;
                TextManager.antenhantei = 1;
                Load();
            }
            else
            {
                sllf = 0;
            }
        }
    }
    public void Save()
    {
       
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(save);
        writer = new StreamWriter(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + savesname + ".json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        
    }
    public void Load()
    {
            string datastr = "";
            var fs = new FileStream(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + savesname + ".json"
        , FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader reader;
            reader = new StreamReader(fs);
            reader = new StreamReader(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + savesname + ".json");
            datastr = reader.ReadToEnd();
            reader.Close();

            save = JsonUtility.FromJson<SaveData>(datastr);
            script.chart = save.charte;
            script.chartx = save.chartxe;
            script.charth = save.charthe;
            textti.six = save.sixe;
            Bgcontroller.sentakux = save.sentakuxe;
            script.charts = save.chartse;
            script.chrmyo = save.chrmyoe;
            script.chrna = save.chrnae;
            script.seibetsu = save.seibetsue;
            script.partna = save.partnae;
            script.hyoji = save.hyojie;
            script.ctagna = save.ctagnae;
            script.colorna = save.colornae;
            script.chrtext = save.chrtexte;
            script.text = save.texte;
            script.name = save.namee;
            script.color = save.colore;
            script.texth = save.texthe;
            script.textho = save.texthoe;
            script.cpic = save.cpice;
            script.bgchantei = save.bgchanteie;
            script.bgcnum = save.bgcnume;
            script.bgcdhantei = save.bgcdhanteie;
            script.bgcdg = save.bgcdge;
            script.bgcdnum = save.bgcdnume;
            script.chaphantei = save.chaphanteie;
            script.chapnum = save.chapnume;
            script.chaptypes = save.chaptypese;
            script.chapthantei = save.chapthanteie;
            script.chaptnum = save.chaptnume;
            script.chapans = save.chapanse;
            script.kakudaians = save.kakudaianse;
            script.kakudaitypes = save.kakudaitypese;
            script.kakudaihantei = save.kakudaihanteie;
            script.kakudainum = save.kakudainume;
            script.bgswhantei = save.bgswhanteie;
            script.bgswnum = save.bgswnume;
            script.bglwhantei = save.bglwhanteie;
            script.bglwnum = save.bglwnume;
            script.bgehantei = save.bgehanteie;
            script.bgenum = save.bgenume;
            script.serioushantei = save.serioushanteie;
            script.hazimarihantei = save.hazimarihanteie;
            script.hazimarinum = save.hazimarinume;
            script.chrchantei = save.chrchanteie;
            script.chrcnum = save.chrcnume;
            script.chrcdhantei = save.chrcdhanteie;
            script.unazhantei = save.unazhanteie;
            script.unazc = save.unazce;
            script.unaznum = save.unaznume;
            script.odorokihantei = save.odorokihanteie;
            script.odorokic = save.odorokice;
            script.odorokinum = save.odorokinume;
            script.daruhantei = save.daruhanteie;
            script.daruc = save.daruce;
            script.darunum = save.darunume;
            script.chrcdnum = save.chrcdnume;
            script.ocolor = save.ocolore;
            script.bgmhantei = save.bgmhanteie;
            script.bgmnum = save.bgmnume;
            script.bgmehantei = save.bgmehanteie;
            script.bgmenum = save.bgmenume;
            script.bgmefhantei = save.bgmefhanteie;
            script.bgmefnum = save.bgmefnume;
            script.videohantei = save.videohanteie;
            script.videonum = save.videonume;
            script.ceventsyl = save.ceventsyle;
            if (saveloadl.loadfl == 0)
            {
                TextManager.text_num = save.text_lnum;
            }
            chrcontroller.chrcx = save.chrcxl;
            chrcontroller.chr1x = save.chr1xl;
            chrcontroller.chr2x = save.chr2xl;
            chrcontroller.chr3x = save.chr3xl;
            chrcontroller.unazx = save.unazxl;
            chrcontroller.odorokix = save.odorokixl;
            chrcontroller.darux = save.daruxl;
            chrcontroller.arrivex = save.arrivexl;
            chrcontroller.okiagarix = save.okiagarixl;
            Bgcontroller.bgcx = save.bgcxl;
            Bgcontroller.bgcdx = save.bgcdxl;
            Bgcontroller.bgcdux = save.bgcduxl;
            Bgcontroller.chapx = save.chapxl;
            Bgcontroller.chappx = save.chappxl;
            if (saveloadl.loadfl == 0 & save.fadexl >= 1)
            {
                Bgcontroller.fadex = save.fadexl - 1;
            }
            else
            {
                Bgcontroller.fadex = save.fadexl;
            }
            if (saveloadl.loadfl == 0 & save.kakudaixl >= 1)
            {
                Bgcontroller.kakudaix = save.kakudaixl - 1;
            }
            else
            {
                Bgcontroller.kakudaix = save.kakudaixl;
            }
            Bgcontroller.chaptx = save.chaptxl;
            chrcontroller.unaz1x = save.unaz1xl;
            chrcontroller.unaz2x = save.unaz2xl;
            chrcontroller.unaz3x = save.unaz3xl;
            chrcontroller.odoroki1x = save.odoroki1xl;
            chrcontroller.odoroki2x = save.odoroki2xl;
            chrcontroller.odoroki3x = save.odoroki3xl;
            chrcontroller.daru1x = save.daru1xl;
            chrcontroller.daru2x = save.daru2xl;
            chrcontroller.daru3x = save.daru3xl;
            chrcontroller.okiagari1x = save.okiagari1xl;
            chrcontroller.okiagari2x = save.okiagari2xl;
            chrcontroller.okiagari3x = save.okiagari3xl;
            loadf = 1;
    }
}