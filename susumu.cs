using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class susumu : MonoBehaviour
{
    public int sinf;
    public static int sinkf;
    public string filePath;
    public string fPath;
    public static int rwf;
    public InputField titleny;
    textt script;
    edit script2;


    [SerializeField]
    public class SaveDataE
    {
        public string loadnamee;
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
        public string[] namee;
        public string[] colore;
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
        public int[] ceventsyle;
    }
    SaveDataE e = new SaveDataE();

    void Awake()
    {
        filePath = Application.dataPath + "/SAVEDATA/chart/part/" + "s"+sinf + ".json"; e = new SaveDataE();

    }
    void Start()
    {
        fPath= Application.dataPath + "/SAVEDATA/chart/part";
        if (Directory.Exists(fPath)==false)
        {
            Directory.CreateDirectory(fPath);
        }
        DirectoryInfo sfile = new DirectoryInfo(fPath);
        FileInfo[] files = sfile.GetFiles();
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
        script = GameObject.Find("textt").GetComponent<textt>();
    }
    void Update()
    {
        fPath = Application.dataPath + "/SAVEDATA/chart/part";
        if (Directory.Exists(fPath) == false)
        {
            Directory.CreateDirectory(fPath);
        }
        e.loadnamee = edittext.loadname;
        e.texte = script.text;
        e.texthe = script.texth;
        e.namee = script.name;
        e.textcolore = script.color;
        e.chrtexte = script.chrtext;
        e.textcolore = script.textcolor;
        e.chrnae = script.chrna;
        e.partnae = script.partna;
        e.seibetsue = script.seibetsu;
        e.chrmyoe = script.chrmyo;
        e.hyojie = script.hyoji;
        e.ctagnae = script.ctagna;
        e.colornae = script.colorna;
        if (sinkf==1)
        {
            sinkf = 0;
            sinf = edittext.sif % 1000+1;
            Rewrite();
        }
        if (sinkf ==2)
        {
            sinkf = 0;
            sinf = edittext.sif % 1000+1;
            Reload();
        }
    }
    public void Rewrite()
    {
        e.texte = script.text;
        e.texthe = script.texth;
        e.texthoe = script.textho;
        e.chrtexte = script.chrtext;
        e.textcolore = script.textcolor;
        e.chrnae = script.chrna;
        e.partnae = script.partna;
        e.seibetsue = script.seibetsu;
        e.chrmyoe = script.chrmyo;
        e.hyojie = script.hyoji;
        e.ctagnae = script.ctagna;
        e.colornae = script.colorna;
        e.bgchanteie = script.bgchantei;
        e.bgcnume = script.bgcnum;
        e.bgcdhanteie = script.bgcdhantei;
        e.bgcdge = script.bgcdg;
        e.bgcdnume = script.bgcdnum;
        e.unazhanteie = script.unazhantei;
        e.unazce = script.unazc;
        e.unaznume = script.unaznum;
        e.odorokihanteie = script.odorokihantei;
        e.odorokice = script.odorokic;
        e.odorokinume = script.odorokinum;
        e.daruhanteie = script.daruhantei;
        e.daruce = script.daruc;
        e.darunume = script.darunum;
        e.chaphanteie = script.chaphantei;
        e.chapnume = script.chapnum;
        e.chaptypese = script.chaptypes;
        e.chapthanteie = script.chapthantei;
        e.chaptnume = script.chaptnum;
        e.chapanse = script.chapans;
        e.kakudaianse = script.kakudaians;
        e.kakudaitypese = script.kakudaitypes;
        e.kakudaihanteie = script.kakudaihantei;
        e.kakudainume = script.kakudainum;
        e.bgswhanteie = script.bgswhantei;
        e.bgswnume = script.bgswnum;
        e.bglwhanteie = script.bglwhantei;
        e.bglwnume = script.bglwnum;
        e.bgehanteie = script.bgehantei;
        e.bgenume = script.bgenum;
        e.serioushanteie = script.serioushantei;
        e.hazimarihanteie = script.hazimarihantei;
        e.hazimarinume = script.hazimarinum;
        e.chrchanteie = script.chrchantei;
        e.chrcnume = script.chrcnum;
        e.chrcdhanteie = script.chrcdhantei;
        e.chrcdnume = script.chrcdnum;
        script.unazhantei = e.unazhanteie;
        script.unazc = e.unazce;
        script.unaznum = e.unaznume;
        script.odorokihantei = e.odorokihanteie;
        script.odorokic = e.odorokice;
        script.odorokinum = e.odorokinume;
        script.daruhantei = e.daruhanteie;
        script.daruc = e.daruce;
        script.darunum = e.darunume;
        e.ocolore = script.ocolor;
        e.ocolornae = script.ocolorna;
        e.textocolore = script.textocolor;
        e.bikoue = script.bikou;
        e.bgmhanteie = script.bgmhantei;
        e.bgmnume = script.bgmnum;
        e.bgmehanteie = script.bgmehantei;
        e.bgmenume = script.bgmenum;
        e.bgmefhanteie = script.bgmefhantei;
        e.bgmefnume = script.bgmefnum;
        e.videohanteie = script.videohantei;
        e.videonume = script.videonum;
        e.ceventsyle = script.ceventsyl;
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(e);
        writer = new StreamWriter(Application.dataPath + "/SAVEDATA/chart/part/" + "s"+sinf + ".json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
    public void Reload()
    {
        if (File.Exists(Application.dataPath + "/SAVEDATA/chart/part/" + "s"+sinf + ".json"))
        {
            {
                var fs = new FileStream(
                   Application.dataPath + "/SAVEDATA/chart/part/" + "s" + sinf + ".json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string datastr = "";
                StreamReader reader;
                reader = new StreamReader(fs);
                reader = new StreamReader(Application.dataPath + "/SAVEDATA/chart/part/" + "s"+sinf + ".json");
                datastr = reader.ReadToEnd();
                reader.Close();
                e = JsonUtility.FromJson<SaveDataE>(datastr);
                script.chrmyo = e.chrmyoe;
                script.chrna = e.chrnae;
                script.seibetsu = e.seibetsue;
                script.partna = e.partnae;
                script.hyoji = e.hyojie;
                script.ctagna = e.ctagnae;
                script.colorna = e.colornae;
                script.chrtext = e.chrtexte;
                script.textcolor = e.textcolore;
                script.text = e.texte;
                script.color = e.colore;
                script.texth = e.texthe;
                script.textho = e.texthoe;
                script.bgchantei= e.bgchanteie;
                script.bgcnum=e.bgcnume;
                script.bgcdhantei = e.bgcdhanteie;
                script.bgcdg = e.bgcdge;
                script.bgcdnum = e.bgcdnume;
                script.chaphantei = e.chaphanteie;
                script.chapnum = e.chapnume;
                script.chaptypes = e.chaptypese;
                script.chapthantei = e.chapthanteie;
                script.chaptnum = e.chaptnume;
                script.chapans = e.chapanse;
                script.kakudaians = e.kakudaianse;
                script.kakudaitypes = e.kakudaitypese;
                script.kakudaihantei = e.kakudaihanteie;
                script.kakudainum = e.kakudainume;
                script.bgswhantei = e.bgswhanteie;
                script.bgswnum = e.bgswnume;
                script.bglwhantei = e.bglwhanteie;
                script.bglwnum = e.bglwnume;
                script.bgehantei = e.bgehanteie;
                script.bgenum = e.bgenume;
                script.serioushantei = e.serioushanteie;
                script.hazimarihantei = e.hazimarihanteie;
                script.hazimarinum = e.hazimarinume;
                script.chrchantei = e.chrchanteie;
                script.chrcnum = e.chrcnume;
                script.chrcdhantei = e.chrcdhanteie;
                script.chrcdnum = e.chrcdnume;
                edit.tnum = 0;
                edit.num = 0;
                edit.cnum = 0;
                edit.edit_num = script.chrna.Length;
                edit.edit_cnum = script.ctagna.Length;
                edit.edit_tnum = script.text.Length;
                script.ocolor = e.ocolore;
                script.ocolorna = e.ocolornae;
                script.textocolor = e.textocolore;
                script.bikou = e.bikoue;
                script.bgmhantei = e.bgmhanteie;
                script.bgmnum = e.bgmnume;
                script.bgmehantei = e.bgmehanteie;
                script.bgmenum = e.bgmenume;
                script.bgmefhantei = e.bgmefhanteie;
                script.bgmefnum = e.bgmefnume;
                script.videohantei = e.videohanteie;
                script.videonum = e.videonume;
                script.ceventsyl = e.ceventsyle;
                edit.chrc_num = 0;
                edit.chrcd_num = 0;
                edit.chrcdg_num = 0;
                edit.bgc_num = 0;
                edit.bgcd_num = 0;
                edit.chap_num = 0;
                edit.chapt_num = 0;
                edit.kakudai_num = 0;
                edit.bgm_num = 0;
                edit.bgme_num = 0;
                edit.bgmef_num = 0;
                edit.video_num = 0;
                textt.dataload = 1;
            }

        }
    }
}
