using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveloadl : MonoBehaviour
{
    [SerializeField]
    private TextAsset textFile;
    private string textData;
    public string[] chrcon;
    [SerializeField]
    private TextAsset BgcText;

    private string BgcData;
    public string[] Bgccon;
    public string filePath;
    public int text_lonum;
    public int bgchantei;
    public int bgcdhantei;
    public int bgcdghantei;
    public int chapthantei;
    public int chrachantei;
    public int unazhantei;
    public int odorokihantei;
    public int okiagarihantei;
    public int daruhantei;
    public int arrivehantei;
    public int chrcf;
    public int unazf;
    public int odorokif;
    public int okiagarif;
    public int daruf;
    public int arrivef;
    public int bgcf;
    public int bgcdf;
    public int chaptf;
    public int syutugen;
    public int unazchr;
    public int odorokichr;
    public int okiagarichr;
    public int daruchr;
    public static int loadfl;
    public static int savesnamel;
    public int text_lnum;
    public int bgchanteit;
    public int bgcdhanteit;
    public int bgcdghanteit;
    public int chapthanteit;
    public int chrachanteit;
    public int unazhanteit;
    public int odorokihanteit;
    public int okiagarihanteit;
    public int daruhanteit;
    public int arrivehanteit;
    public int chaphantei;
    public int chaphanteit;
    public int kakudaihantei;
    public int kakudaihanteit;
    public int bgcsx;
    public int bgcdsx;
    public int chapsx;
    public int chaptsx;
    public int chrcsx;
    public int unazsx;
    public int odorokisx;
    public int arrivesx;
    public int darusx;
    public int okiagarisx;
    public int chappxl;
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
    public int chaptxl;
    public int kakudaixl;
    public int cpxl;
    public int unazxl;
    public int odorokixl;
    public saveload sl;
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
    public int fadexl;
    public int fadesx;
    public int kakudaisx;
    public int fadehantei;
    public int fadehanteit;
    public int slf;
    public static int lognum;
    public static int lslf;
    public string gfilePath;
    public string cfilePath;
    public string sfilePath;
    textti script;
    [SerializeField]
    public class SaveDatal
    {
        //テスト用の文字列
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
        public int chaptxl;
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
        public int chrcxlo;
        public int chr1xlo;
        public int chr2xlo;
        public int chr3xlo;
        public int bgcxlo;
        public int bgcdxlo;
        public int bgcduxlo;
        public int chapxlo;
        public int chappxlo;
        public int chaptxlo;
        public int fadexlo;
        public int unazxlo;
        public int odorokixlo;
        public int arrivexlo;
       public int daruxlo;
        public int okiagarixlo;
        public int unaz1xlo;
        public int unaz2xlo;
        public int unaz3xlo;
        public int odoroki1xlo;
        public int odoroki2xlo;
        public int odoroki3xlo;
        public int daru1xlo;
        public int daru2xlo;
        public int daru3xlo;
        public int okiagari1xlo;
        public int okiagari2xlo;
        public int okiagari3xlo;
        public int kakudaixlo;
        public int[] charte;
        public int[] chartxe;
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
        public int[] chartse;
        public int[] charthe;
        public int[] ceventsyle;

    }
    SaveDatal save = new SaveDatal();
    void Awake()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            script = GameObject.Find("textti").GetComponent<textti>();
        }
        filePath = Application.dataPath + "/SAVEDATA/log/"+textti.loaddata+"/"+(lognum-1)+".json"; save = new SaveDatal();
    }
    void Start()
    {

        textData = textFile.text;
        
        // 改行で分割して配列に代入
        chrcon = textData.Split(char.Parse("\n"));
        BgcData = BgcText.text;

        // 改行で分割して配列に代入
        Bgccon = BgcData.Split(char.Parse("\n"));
        lognum = 0;
        gfilePath = Application.dataPath + "/SAVEDATA/log";
        if (Directory.Exists(gfilePath) == false)
        {
            Directory.CreateDirectory(gfilePath);
        }
        cfilePath = Application.dataPath + "/SAVEDATA/config";
        if (Directory.Exists(cfilePath) == false)
        {
            Directory.CreateDirectory(cfilePath);
        }
        sfilePath = Application.dataPath + "/SAVEDATA/savedata";
        if (Directory.Exists(sfilePath) == false)
        {
            Directory.CreateDirectory(sfilePath);
        }
    }
    void Update()
    {
        gfilePath = Application.dataPath + "/SAVEDATA/log";
        if (Directory.Exists(gfilePath) == false)
        {
            Directory.CreateDirectory(gfilePath);
        }
        cfilePath = Application.dataPath + "/SAVEDATA/config";
        if (Directory.Exists(cfilePath) == false)
        {
            Directory.CreateDirectory(cfilePath);
        }
        sfilePath = Application.dataPath + "/SAVEDATA/savedata";
        if (Directory.Exists(sfilePath) == false)
        {
            Directory.CreateDirectory(sfilePath);
        }
        script = GameObject.Find("textti").GetComponent<textti>();
        chrcxl = chrcontroller.chrcx;
        chr1xl = chrcontroller.chr1x;
        chr2xl = chrcontroller.chr2x;
        chr3xl = chrcontroller.chr3x;
        unazxl = chrcontroller.unazx;
        odorokixl = chrcontroller.odorokix;
        arrivexl = chrcontroller.arrivex;
        daruxl = chrcontroller.darux;
        okiagarixl = chrcontroller.okiagarix;
        bgcxl = Bgcontroller.bgcx;
        bgcdxl = Bgcontroller.bgcdx;
        bgcduxl = Bgcontroller.bgcdux;
        chapxl = Bgcontroller.chapx;
        chappxl = Bgcontroller.chappx;
        chaptxl = Bgcontroller.chaptx;
        kakudaixl = Bgcontroller.kakudaix;
        fadexl = Bgcontroller.fadex;
        unaz1xl = chrcontroller.unaz1x;
        unaz2xl = chrcontroller.unaz2x;
        unaz3xl = chrcontroller.unaz3x;
        odoroki1xl = chrcontroller.odoroki1x;
        odoroki2xl = chrcontroller.odoroki2x;
        odoroki3xl = chrcontroller.odoroki3x;
        daru1xl = chrcontroller.daru1x;
        daru2xl = chrcontroller.daru2x;
        daru3xl = chrcontroller.daru3x;
        okiagari1xl = chrcontroller.okiagari1x;
        okiagari2xl = chrcontroller.okiagari2x;
        okiagari3xl = chrcontroller.okiagari3x;
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
        save.ceventsyle = script.ceventsyl;
        save.chartse = script.charts;
        if (TextManager.antenhantei==0)
        {
            lognum = TextManager.text_num / 100;
            if (TextManager.text_num == 0 + (lognum * 100))
            {
                if (File.Exists(Application.dataPath + "/SAVEDATA/log/" + textti.loaddata + "/" + lognum + ".json") == false)
                {
                    Save();
                }
            }
        }
        if (loadfl == 1)
        {
            lognum = TextManager.text_num / 100;
            loadfl = 2;
            Load();
        }
    }
    public void Save()
    {
        StreamWriter writerl;

        string jsonstrl = JsonUtility.ToJson(save);
        writerl = new StreamWriter(Application.dataPath + "/SAVEDATA/log/"+textti.loaddata+"/"+lognum+".json", false);
        writerl.Write(jsonstrl);
        writerl.Flush();
        writerl.Close();
    }
    public void Load()
    {
        string datastrl = "";
        StreamReader readerl;
        readerl = new StreamReader(Application.dataPath + "/SAVEDATA/log/"+textti.loaddata+"/"+lognum+".json");
        datastrl = readerl.ReadToEnd();
        readerl.Close();

        save = JsonUtility.FromJson<SaveDatal>(datastrl);
        script.chart = save.charte;
        script.chartx = save.chartxe;
        textti.six = save.sixe;
        Bgcontroller.sentakux = save.sentakuxe;
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
        chrcontroller.chrcx = save.chrcxlo;
        chrcontroller.chr1x = save.chr1xlo;
        chrcontroller.chr2x = save.chr2xlo;
        chrcontroller.chr3x = save.chr3xlo;
        chrcontroller.unazx= save.unazxlo;
        chrcontroller.odorokix = save.odorokixlo;
        chrcontroller.darux = save.daruxlo;
        chrcontroller.arrivex = save.arrivexlo;
        chrcontroller.okiagarix = save.okiagarixlo;
        Bgcontroller.fadex = save.fadexlo;
        Bgcontroller.bgcx=save.bgcxlo;
        Bgcontroller.bgcdx=save.bgcdxlo;
        Bgcontroller.bgcdux=save.bgcduxlo;
        Bgcontroller.chaptx = save.chaptxlo;
        Bgcontroller.kakudaix = save.kakudaixlo;
        Bgcontroller.chapx = save.chapxlo;
        Bgcontroller.chappx = save.chappxlo;
        chrcontroller.unaz1x=save.unaz1xlo;
        chrcontroller.unaz2x=save.unaz2xlo;
        chrcontroller.unaz3x=save.unaz3xlo;
        chrcontroller.odoroki1x=save.odoroki1xlo;
        chrcontroller.odoroki2x=save.odoroki2xlo;
        chrcontroller.odoroki3x=save.odoroki3xlo;
        chrcontroller.daru1x=save.daru1xlo;
        chrcontroller.daru2x=save.daru2xlo;
        chrcontroller.daru3x=save.daru3xlo;
        chrcontroller.okiagari1x=save.okiagari1xlo;
        chrcontroller.okiagari2x =save.okiagari2xlo ;
        chrcontroller.okiagari3x=save.okiagari3xlo;
        loadfl = 4;
    }
}
