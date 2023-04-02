using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class edittext : MonoBehaviour
{
    public int test;
    public string filePath;
    public string[] cnab;
    public int cnas;
    public int a;
    public int edittx;
    public int editx;
    public int editbex;
    public int editcex;
    public int editaux;
    public int editvix;
    public InputField titleny;
    public InputField tousitext;
    public InputField tousictext;
    public InputField tousihani;
    public InputField tousihanim;
    public InputField jsonny;
    public InputField ujsonny;
    public InputField txtny;
    public InputField[] texti;
    public Text usetex;
    public Text etext;
    public string titext;
    public string totext;
    public string toctext;
    public string tohtext;
    public string tohmtext;
    public int thx;
    public int thmx;
    public int tx;
    public int txx;
    public InputField tousioani;
    public InputField tousioanim;
    public string tootext;
    public string toomtext;
    public int tox;
    public int tomx;
    public string ePath;
    public string wePath;
    public static int sf;
    public static int rndmx;
    public static int mrnd;
    public static int frnd;
    public int[] eindex;
    public static int sif;
    public static int startf;
    public static int dstartf;
    public static int simf;
    public static int savef;
    public static int dsif;
    public static int dsimf;
    public static int dsavef;
    public int ex;
    public static string loadname;
    public static int senex;
    public static string titletext;
    public static int titleaf;
    public string sPath;
    public string tPath;
    public GameObject titlea;
    textt script;
    edit script2;
    dataload script3;


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
        public int[] ceventsyle;
    }
    SaveDataE e = new SaveDataE();
    void Awake()
    {
        filePath = Application.dataPath + "/SAVEDATA/json/part/" + edit.jssname + ".json"; e = new SaveDataE();

    }
    void Start()
    {
        eindex = new int[5];
        script = GameObject.Find("textt").GetComponent<textt>();
        script2 = GameObject.Find("specialm").GetComponent<edit>();
        script3 = GameObject.Find("dataload").GetComponent<dataload>();
    }
    void Update()
    {
        ePath = Application.dataPath + "/SAVEDATA/json/part/";
        if (Directory.Exists(ePath) == false)
        {
            Directory.CreateDirectory(ePath);
        }
        wePath = Application.dataPath + "/SAVEDATA/json/whole/";
        if (Directory.Exists(wePath) == false)
        {
            Directory.CreateDirectory(wePath);
        }
        //新規作成
        if (startf == 2)
        {
            script.chrtext = new string[5];
            script.textcolor = new string[5];
            script.texth = new string[5];
            script.text = new string[5];
            script.partna = new string[5];
            script.chrmyo = new string[5];
            script.chrna = new string[5];
            script.cpicname = new string[5];
            script.chaphantei = new int[5];
            script.chapans = new int[5];
            script.kakudaians = new int[5];
            script.chaptypes = new int[5];
            script.chapthantei = new int[5];
            script.kakudaihantei = new int[5];
            script.kakudaitypes = new int[5];
            script.chapnum = new string[5];
            script.chaptnum = new string[10];
            script.kakudainum = new string[5];
            script.bgswhantei = new int[10];
            script.bgswnum = new string[10];
            script.bglwhantei = new int[10];
            script.bglwnum = new string[10];
            script.bgehantei = new int[10];
            script.bgenum = new string[10];
            script.serioushantei = new int[10];
            script.hazimarihantei = new int[10];
            script.hazimarinum = new string[10];
            script.chrchantei = new int[5];
            script.chrcdhantei = new int[5];
            script.chrcnum = new string[5];
            script.chrcdnum = new string[10];
            script.unazhantei = new int[5];
            script.unazc = new int[5];
            script.unaznum = new string[5];
            script.odorokihantei = new int[5];
            script.odorokic = new int[5];
            script.odorokinum = new string[5];
            script.daruhantei = new int[5];
            script.daruc = new int[5];
            script.darunum = new string[5];
            script.chrani = new string[5];
            script.seibetsu = new int[5];
            script.hyoji = new int[5];
            script.ctagna = new string[5];
            script.colorna = new string[5];
            script.ocolorna = new string[5];
            script.textocolor = new string[5];
            script.color = new string[5];
            script.ocolor = new string[5];
            script.bgchantei = new int[5];
            script.bikou = new string[5];
            script.bgcnum = new string[5];
            script.bgcdhantei = new int[5];
            script.bgcdg = new int[5];
            script.bgcdnum = new string[10];
            script.bgmhantei = new int[5];
            script.bgmehantei = new int[5];
            script.bgmefhantei = new int[5];
            script.bgmnum = new string[5];
            script.bgmenum = new string[5];
            script.bgmefnum = new string[5];
            script.videohantei = new int[5];
            script.videonum = new string[5];
            script.ceventsyl = new int[5];
            textco.chflag = 0;
            textco.coflag = 0;
            esaveco.useflag = 0;
            esaveco.jsonflag = 0;
            esaveco.txtflag = 0;
            edit.tnum = 0;
            edit.num = 0;
            edit.cnum = 0;
            edit.bgm_num = 0;
            edit.bgme_num = 0;
            edit.bgmef_num = 0;
            edit.video_num = 0;
            edit.editp = 0;
            edit.jssname = string.Empty;
            loadname = string.Empty;
            titleny.text = string.Empty;
            sif = 0;
            simf = sif;
            susumu.sinkf = 1;
            savef = 0;
            startf = 0;
            dstartf = 0;
        }
        if (dstartf == 2)
        {
            script.sentakuhantei = new int[5];
            script.sentakutypes = new int[5];
            script.sentakuknum = new string[5];
            script.sentakubnum = new string[10];
            script.sentakudnum = new string[10];
            script.aehantei = new int[3];
            script.uitnum = new string[4];
            script.uignum = new string[5];
            edit.sentaku_num = 0;
            textt.sentakus = 5;
            edit.editp = 10;
            edit.jssname = string.Empty;
            loadname = string.Empty;
            titleny.text = string.Empty;
            dsif = 0;
            dsimf = dsif;
            susumuk.dsinkf = 1;
            savef = 0;
            dstartf = 0;
        }
        if (textco.sentakuchf == 0 & textco.sentakucof == 0)
        {
            Text edit_text = etext.GetComponent<Text>();
            edit_text.text = "未選択";
        }
        //テキストのページ
        if (textco.tef > 0)
        {

            if (textco.tikf == 1)
            {
                if (editx >= edit.num)
                {
                    textco.tikf = -1;
                    textco.tef = 0;
                    editx = 0;
                    editco.acf = 0;
                }
            }
            if (textco.teikf == 1)
            {
                for (edittx = 0; edittx < edit.tnum; edittx++)
                {
                    if (script2.textnys[edittx] != string.Empty)
                    {
                        int ed = script.text[edittx].IndexOf(" ") + 1;
                        int edl = script.text[edittx].Length;
                        script.texth.SetValue(script2.textnys[edittx], edittx);
                        script.text[edittx] = script.text[edittx].Replace(script.text[edittx].Substring(ed, edl - ed), script2.textnys[edittx]);
                    }
                }
                if (edittx >= edit.tnum)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    edit.trf = 1;
                    textco.tef = 0;
                    edittx = 0;
                    textco.teikf = 0;
                }
            }
            if (textco.textcf > 0)
            {
                if (edit.num >= textco.sentakuchf + edit.sepage * 12 & textco.sentakuchf > 0)
                {
                    if (etext.text != string.Empty & etext.text != null)
                    {
                        test = edit.edit_tnum - textco.textcf + 2;
                        Text edit_text = etext.GetComponent<Text>();
                        eindex[0] = script.text[edit.edit_tnum - textco.textcf].IndexOf(" ") + 1;
                        script.chrtext.SetValue("#" + edit_text.text, edit.edit_tnum - textco.textcf);
                        script.text[edit.edit_tnum - textco.textcf] = script.text[edit.edit_tnum - textco.textcf].Replace(script.text[edit.edit_tnum - textco.textcf].Substring(0, eindex[0] - 1), "#" + edit_text.text);
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                if (edit.cnum >= textco.sentakucof + edit.sepage * 12 & textco.sentakucof > 0)
                {
                    Text edit_text = etext.GetComponent<Text>();
                    if (etext.text != string.Empty & etext.text != null)
                    {
                        script.textcolor.SetValue("$" + edit_text.text, edit.edit_tnum - textco.textcf);
                        script.textocolor.SetValue("$" + edit_text.text, edit.edit_tnum - textco.textcf);
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                if (textco.sentakuchf == 0 & textco.sentakucof == 0)
                {
                    if (script2.textnys[edit.edit_tnum - textco.textcf].Length != 0)
                    {
                        int ed = script.text[edit.edit_tnum - textco.textcf].IndexOf(" ") + 1;
                        int edl = script.text[edit.edit_tnum - textco.textcf].Length;
                        script.texth.SetValue(script2.textnys[edit.edit_tnum - textco.textcf], edit.edit_tnum - textco.textcf);
                        script.text[edit.edit_tnum - textco.textcf] = script.text[edit.edit_tnum - textco.textcf].Replace(script.text[edit.edit_tnum - textco.textcf].Substring(ed, edl - ed), script2.textnys[edit.edit_tnum - textco.textcf]);
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                    edit.trf = 1;
                }
                textco.tef = 0;
                textco.textcf = 0;
            }
            if (textco.kakkof > 0)
            {
                if (script2.textnys[edit.edit_tnum - textco.kakkof].Length != 0)
                {
                    if (script2.textnys[edit.edit_tnum - textco.kakkof].StartsWith("「") == false)
                    {
                        script2.textnys[edit.edit_tnum - textco.kakkof] = script2.textnys[edit.edit_tnum - textco.kakkof].Insert(0, "「") + "」";
                        texti[5 - (textco.kakkof)].text = script2.textnys[edit.edit_tnum - textco.kakkof];
                    }
                }
                else if (script.textho[edit.edit_tnum - textco.kakkof].Length != 0 & script.textho[edit.edit_tnum - textco.kakkof].StartsWith("「") == false)
                {
                    script.texth[edit.edit_tnum - textco.kakkof] = script.texth[edit.edit_tnum - textco.kakkof].Replace(script.texth[edit.edit_tnum - textco.kakkof], "「" + script.texth[edit.edit_tnum - textco.kakkof] + "」");
                    int ed = script.text[edit.edit_tnum - textco.kakkof].IndexOf(" ") + 1;
                    script.text[edit.edit_tnum - textco.kakkof] = script.text[edit.edit_tnum - textco.kakkof].Insert(ed, "「");
                    int edl = script.text[edit.edit_tnum - textco.kakkof].Length;
                    script.text[edit.edit_tnum - textco.kakkof] = script.text[edit.edit_tnum - textco.kakkof].Insert(edl - 1, "」");
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                }
                textco.kakkof = 0;
                textco.tef = 0;
            }
            if (textco.sentakuchf > 0)
            {
                if (script.partna[12 * edit.sepage + textco.sentakuchf - 1] != null)
                {
                    etext.text = script.partna[12 * edit.sepage + textco.sentakuchf - 1];
                }
                else
                {
                    textco.sentakuchf = 0;
                }
            }
            if (textco.sentakucof > 0)
            {
                if (script.ctagna[12 * edit.sepage + textco.sentakucof - 1] != null)
                {
                    etext.text = script.ctagna[12 * edit.sepage + textco.sentakucof - 1];
                }
                else
                {
                    textco.sentakucof = 0;
                }
            }
            if (textco.coallf == 1)
            {
                Text edit_text = etext.GetComponent<Text>();
                for (tx = 0; tx < edit.tnum; tx++)
                {
                    script.textcolor.SetValue("$" + edit_text.text, tx);
                    script.textocolor.SetValue("$" + edit_text.text, tx);
                    int tex = tx + 1;
                }
                if (tx >= edit.tnum)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    textco.coallf = 0;
                    textco.tef = 0;
                    tx = 0;
                }
            }
            textt.dataload = 1;
        }
        //キャラクターのページ
        if (editco.chf > 0)
        {

            if (editco.acf == 1)
            {
                for (editx = 0; editx < edit.num; editx++)
                {
                    if (script2.tags[editx] != string.Empty)
                    {
                        script.partna.SetValue(script2.tags[editx], editx);
                    }
                    if (script2.myojis[editx] != string.Empty)
                    {
                        script.chrmyo.SetValue(script2.myojis[editx], editx);
                    }
                    if (script2.names[editx] != string.Empty)
                    {
                        script.chrna.SetValue(script2.names[editx], editx);
                    }
                    if (script2.bikous[editx] != string.Empty)
                    {
                        script.bikou.SetValue(script2.bikous[editx], editx);
                    }

                }
                if (editx >= edit.num)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    editco.chf = -1;
                    editx = 0;
                    editco.acf = 0;
                }
            }
            if (editco.roundf > 0)
            {

                var rndm = new System.Random();
                var rndn = new System.Random();
                rndmx = rndm.Next(0, textt.myos - 1);
                mrnd = rndn.Next(0, textt.ms - 1);
                frnd = rndn.Next(0, textt.fs - 1);
                script.chrmyo.SetValue(script.myo[rndmx], edit.edit_num - editco.roundf);
                if (script.seibetsu[edit.edit_num - editco.roundf] == 0)
                {
                    script.chrna.SetValue(script.mname[mrnd], edit.edit_num - editco.roundf);
                }
                else
                {
                    script.chrna.SetValue(script.fname[frnd], edit.edit_num - editco.roundf);
                }
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                editco.chf = -1;
                editco.roundf = 0;
            }
            if (editco.hyojif > 0)
            {
                if (script.hyoji[edit.edit_num - editco.hyojif] == 0)
                {
                    script.hyoji.SetValue(1, edit.edit_num - editco.hyojif);
                }
                else
                {
                    script.hyoji.SetValue(0, edit.edit_num - editco.hyojif);
                }
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                editco.chf = 0;
                editco.hyojif = 0;
            }
            if (editco.seibetsuf > 0)
            {
                if (script.seibetsu[edit.edit_num - editco.seibetsuf] == 0)
                {
                    script.seibetsu.SetValue(1, edit.edit_num - editco.seibetsuf);
                }
                else
                {
                    script.seibetsu.SetValue(0, edit.edit_num - editco.seibetsuf);
                }
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                editco.chf = 0;
                editco.seibetsuf = 0;
            }
            if (editco.toushif == 1)
            {
                InputField tousih = tousihani.GetComponent<InputField>();
                InputField tousihm = tousihanim.GetComponent<InputField>();
                tohtext = tousih.text;
                tohmtext = tousihm.text;
                if (tohtext != string.Empty) { thx = int.Parse(tohtext); } else { tousih.text = string.Empty + 1; thx = 1; }
                if (tohmtext != string.Empty) { thmx = int.Parse(tohmtext); } else { tousihm.text = string.Empty + edit.num; thmx = edit.num; }
                if (tohtext == string.Empty | thx <= 0 | thx > thmx | thx > edit.num) { tousih.text = string.Empty + 1; thx = 1; }
                if (tohmtext == string.Empty | thmx <= 1 | thx > thmx | thmx > edit.num) { tousihm.text = string.Empty + edit.num; thmx = edit.num; }
                for (tx = thx - 1; tx < thmx; tx++)
                {
                    txx += 1;
                    InputField tousic = tousitext.GetComponent<InputField>();
                    totext = tousic.text;
                    int tex = txx;
                    script.partna.SetValue(totext + tex, tx);


                }
                if (tx >= thmx)
                {
                    txx = 0;
                    thx = 0;
                    thmx = 0;
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    editco.chf = -1;
                    tx = 0;
                    editco.toushif = 0;
                    tousitext.text = string.Empty;
                }
            }
            if (editco.pacf == 1 & edit.cpicnumber > 0)
            {
                for (editx = 0; editx < 5; editx++)
                {
                    if (script2.cpics[editx] != string.Empty)
                    {
                        script.cpic[edit.cpicnumber][edit.cpic_num - 5 + editx] = script.cpic[edit.cpicnumber][edit.cpic_num - 5 + editx].Replace(script.cpic[edit.cpicnumber][editx].Substring(0, script.cpic[edit.cpicnumber][edit.cpic_num - 5 + editx].IndexOf("*")), script2.cpics[editx]);
                    }
                }
                if (editx >= 5)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    editco.chf = -1;
                    editx = 0;
                    editco.pacf = 0;
                }
            }
            if (editco.cpicf > 0)
            {
                if (editco.cexf > 0)
                {
                    script.cpic[edit.cpicnumber][edit.cpic_num - (6 - editco.cpicf)] = script.cpic[edit.cpicnumber][edit.cpic_num - (6 - editco.cpicf)].Replace(script.cpic[edit.cpicnumber][edit.cpic_num - (6 - editco.cpicf)].Substring(script.cpic[edit.cpicnumber][edit.cpic_num - (6 - editco.cpicf)].IndexOf("*") + 1), script2.cpicnam[editco.cexf - 1].Substring(script2.cpicnam[editco.cexf - 1].LastIndexOf("/") + 5));
                }
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                editco.chf = 0;
                editco.cpicf = 0;
                editco.cexf = 0;
            }
            textt.dataload = 1;
        }
        //カラーのページ
        if (colorco.cf > 0)
        {

            if (colorco.ccf == 1)
            {
                for (editx = 0; editx < edit.cnum; editx++)
                {
                    if (script2.ctags[editx] != string.Empty)
                    {
                        script.ctagna.SetValue(script2.ctags[editx], editx);
                    }
                }
                if (editx >= edit.cnum)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    colorco.cf = -1;
                    editx = 0;
                    colorco.ccf = 0;
                }
            }
            if (colorco.colorcf > 0 & edit.colort.Length == 6)
            {
                script.colorna.SetValue(edit.colort, edit.edit_cnum - colorco.colorcf);
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                edit.colort = string.Empty;
                colorco.cf = -2;
                colorco.colorcf = 0;
                colorco.colorsf = 0;
            }
            if (colorco.colorcf > 0 & colorco.colorsf > 0 & edit.colort.Length != 6)
            {
                script.colorna.SetValue(script.colorp[colorco.colorsf - 1], edit.edit_cnum - colorco.colorcf);
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                colorco.cf = 0;
                colorco.colorcf = 0;
                colorco.colorsf = 0;
            }
            if (colorco.ocolorcf > 0 & edit.colort.Length == 6)
            {
                script.ocolorna.SetValue(edit.colort, edit.edit_cnum - colorco.ocolorcf);
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                edit.colort = string.Empty;
                colorco.cf = -2;
                colorco.ocolorcf = 0;
                colorco.colorsf = 0;
            }
            if (colorco.ocolorcf > 0 & colorco.colorsf > 0 & edit.colort.Length != 6)
            {
                script.ocolorna.SetValue(script.colorp[colorco.colorsf - 1], edit.edit_cnum - colorco.ocolorcf);
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                colorco.cf = 0;
                colorco.ocolorcf = 0;
                colorco.colorsf = 0;
            }
            if (colorco.toushicf == 1)
            {
                InputField tousio = tousioani.GetComponent<InputField>();
                InputField tousiom = tousioanim.GetComponent<InputField>();
                tootext = tousio.text;
                toomtext = tousiom.text;
                if (tootext != string.Empty) { tox = int.Parse(tootext); } else { tousio.text = string.Empty + 1; tox = 1; }
                if (toomtext != string.Empty) { tomx = int.Parse(toomtext); } else { tousiom.text = string.Empty + edit.cnum; tomx = edit.cnum; }
                if (tootext == string.Empty | tox <= 0 | tox > tomx | tox > edit.cnum) { tousio.text = string.Empty + 1; tox = 1; }
                if (toomtext == string.Empty | tomx <= 1 | tox > tomx | tomx > edit.cnum) { tousiom.text = string.Empty + edit.cnum; tomx = edit.cnum; }
                for (tx = tox - 1; tx < tomx; tx++)
                {
                    txx += 1;
                    InputField tousic = tousictext.GetComponent<InputField>();
                    totext = tousic.text;
                    int tex = txx;
                    script.ctagna.SetValue(totext + tex, tx);


                }
                if (tx >= tomx)
                {
                    txx = 0;
                    tox = 0;
                    tomx = 0;
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    colorco.cf = -1;
                    tx = 0;
                    colorco.toushicf = 0;
                    tousictext.text = string.Empty;
                }
            }

        }
        //キャライベントのページ
        if (eventco.chref > 0)
        {
            if (eventco.cedelnumber > 0)
            {
                if (edit.ceventf == 0)
                {
                    if (script.chrcnum[edit.chrc_num - eventco.cedelnumber] != string.Empty & script.chrcnum[edit.chrc_num - eventco.cedelnumber] != null)
                    {
                        script.chrcnum[edit.chrc_num - eventco.cedelnumber] = string.Empty;
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                eventco.chref = 0;
                eventco.cedelnumber = 0;
            }

            if (eventco.chrcgcf > 0 & eventco.chrenumber > 0 | eventco.chrcgcf > 0 & eventco.chrednumber > 0)
            {
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                if (eventco.chrenumber > 0)
                {
                    if (edit.ceventf == 0)
                    {
                        if (script.ceventsyl[eventco.chrenumber - 1] >= 1)
                        {
                            script.chrcnum[eventco.chrenumber - 1] = script3.cfilePaths[eventco.chrcgcf - 1].Substring(script3.cfilePaths[eventco.chrcgcf - 1].LastIndexOf("\\") + 1);
                            script.ceventsyl[eventco.chrenumber - 1] = 1;
                        }
                    }
                    if (edit.ceventf == 3)
                    {
                        script.unaznum[eventco.chrenumber - 1] = script3.cfilePaths[eventco.chrcgcf - 1].Substring(script3.cfilePaths[eventco.chrcgcf - 1].LastIndexOf("\\") + 1);
                    }
                    if (edit.ceventf == 4)
                    {
                        script.odorokinum[eventco.chrenumber - 1] = script3.cfilePaths[eventco.chrcgcf - 1].Substring(script3.cfilePaths[eventco.chrcgcf - 1].LastIndexOf("\\") + 1);

                    }
                    if (edit.ceventf == 5)
                    {
                        script.darunum[eventco.chrenumber - 1] = script3.cfilePaths[eventco.chrcgcf - 1].Substring(script3.cfilePaths[eventco.chrcgcf - 1].LastIndexOf("\\") + 1);
                    }
                }
                if (eventco.chrednumber > 0)
                {
                    if (script.ceventsyl[(eventco.chrednumber - 1) / 2] == 0)
                    {
                        script.chrcdnum[eventco.chrednumber - 1] = script3.cfilePaths[eventco.chrcgcf - 1].Substring(script3.cfilePaths[eventco.chrcgcf - 1].LastIndexOf("\\") + 1);
                    }
                }
                eventco.chrcgcf = 0;
                eventco.chrenumber = 0;
                eventco.chrednumber = 0;
                eventco.chref = 0;
            }
            if (eventco.cetf > 0)
            {
                if (edit.ceventf == 0)
                {
                    if (script2.chrevents[edit.chrc_num - eventco.cetf] != string.Empty)
                    {
                        if (edit.chrc_num - eventco.cetf > 0)
                        {
                            if (int.Parse(script2.chrevents[edit.chrc_num - eventco.cetf]) >= -1 & int.Parse(script2.chrevents[edit.chrc_num - eventco.cetf]) > script.chrchantei[edit.chrc_num - eventco.cetf - 1])
                            {
                                script.chrchantei[edit.chrc_num - eventco.cetf] = int.Parse(script2.chrevents[edit.chrc_num - eventco.cetf]);
                            }
                        }
                        else
                        {
                            script.chrchantei[edit.chrc_num - eventco.cetf] = int.Parse(script2.chrevents[edit.chrc_num - eventco.cetf]);
                        }
                    }
                }
                if (edit.ceventf == 1)
                {
                    if (script2.chrevents[edit.chrcd_num - eventco.cetf] != string.Empty)
                    {
                        if (edit.chrcd_num - eventco.cetf > 0)
                        {
                            if (int.Parse(script2.chrevents[edit.chrcd_num - eventco.cetf]) >= -1 & int.Parse(script2.chrevents[edit.chrcd_num - eventco.cetf]) > script.chrcdhantei[edit.chrcd_num - eventco.cetf - 1])
                            {
                                script.chrcdhantei[edit.chrcd_num - eventco.cetf] = int.Parse(script2.chrevents[edit.chrcd_num - eventco.cetf]);
                            }
                        }
                        else
                        {
                            script.chrcdhantei[edit.chrcd_num - eventco.cetf] = int.Parse(script2.chrevents[edit.chrcd_num - eventco.cetf]);
                        }
                    }
                }
                if (edit.ceventf == 3)
                {
                    if (script2.chrevents[(edit.unaz_num - eventco.cetf) * 2] != string.Empty)
                    {
                        if (edit.unaz_num - eventco.cetf > 0)
                        {
                            if (int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2]) >= -1 & int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2]) > script.unazhantei[edit.unaz_num - eventco.cetf - 1])
                            {
                                script.unazhantei[edit.unaz_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2]);
                            }
                        }
                        else
                        {
                            script.unazhantei[edit.unaz_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2]);
                        }
                    }
                    if (script2.chrevents[(edit.unaz_num - eventco.cetf) * 2 + 1] != string.Empty)
                    {
                        if (int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2 + 1]) >= 0)
                        {
                            script.unazc[edit.unaz_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.unaz_num - eventco.cetf) * 2 + 1]);
                        }
                    }
                }
                if (edit.ceventf == 4)
                {
                    if (script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2] != string.Empty)
                    {
                        if (edit.odoroki_num - eventco.cetf > 0)
                        {
                            if (int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2]) >= -1 & int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2]) > script.odorokihantei[edit.odoroki_num - eventco.cetf - 1])
                            {
                                script.odorokihantei[edit.odoroki_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2]);
                            }
                        }
                        else
                        {
                            script.odorokihantei[edit.odoroki_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2]);
                        }
                    }
                    if (script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2 + 1] != string.Empty)
                    {
                        if (int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2 + 1]) >= 0)
                        {
                            script.odorokic[edit.odoroki_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.odoroki_num - eventco.cetf) * 2 + 1]);
                        }
                    }
                }
                if (edit.ceventf == 5)
                {
                    if (script2.chrevents[(edit.daru_num - eventco.cetf) * 2] != string.Empty)
                    {
                        if (edit.daru_num - eventco.cetf > 0)
                        {
                            if (int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2]) >= -1 & int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2]) > script.daruhantei[edit.daru_num - eventco.cetf - 1])
                            {
                                script.daruhantei[edit.daru_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2]);
                            }
                        }
                        else
                        {
                            script.daruhantei[edit.daru_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2]);
                        }
                    }
                    if (script2.chrevents[(edit.daru_num - eventco.cetf) * 2 + 1] != string.Empty)
                    {
                        if (int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2 + 1]) >= 0)
                        {
                            script.daruc[edit.daru_num - eventco.cetf] = int.Parse(script2.chrevents[(edit.daru_num - eventco.cetf) * 2 + 1]);
                        }
                    }
                }
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                eventco.cetf = 0;
                eventco.chref = -1;
            }
            if (eventco.ceikf == 1)
            {
                if (edit.ceventf == 0)
                {
                    for (editcex = 0; editcex < textt.chrcs; editcex++)
                    {
                        if (editcex == 0 & (script2.chrevents[0] != string.Empty & script2.chrevents[0] != null))
                        {
                            if (int.Parse(script2.chrevents[0]) >= -1)
                            {
                                script.chrchantei[0] = int.Parse(script2.chrevents[0]);
                            }
                        }
                        if (editcex > 0 & (script2.chrevents[editcex] != string.Empty & script2.chrevents[editcex] != null))
                        {
                            if (int.Parse(script2.chrevents[editcex]) > script.chrchantei[editcex - 1])
                            {
                                script.chrchantei[editcex] = int.Parse(script2.chrevents[editcex]);
                            }
                            else
                            {
                                script.chrchantei[editcex] = 0;
                                editcex = textt.chrcs;
                            }
                        }
                    }
                    if (editcex >= textt.chrcs)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.chref = -1;
                        editcex = 0;
                        eventco.ceikf = 0;
                    }
                }
            }
        }
        //背景イベントのページ
        if (eventco.bgef > 0)
        {


            if (eventco.bgcgcf > 0 & eventco.bgenumber > 0 | eventco.bgcgcf > 0 & eventco.bgednumber > 0)
            {
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                if (edit.beventf == 0)
                {
                    script.bgcnum[eventco.bgenumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 1)
                {
                    script.bgcdnum[eventco.bgednumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 2)
                {
                    if (script.chapansy[script.chapans[eventco.bgenumber - 1]] == "あり")
                    {
                        script.chapnum[eventco.bgenumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                    }
                }
                if (edit.beventf == 3)
                {
                    script.chaptnum[eventco.bgednumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 4)
                {
                    script.kakudainum[eventco.bgenumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 6)
                {
                    script.bgswnum[(eventco.bgenumber - 1) * 2] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 7)
                {
                    script.bglwnum[(eventco.bgenumber - 1) * 2] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 8)
                {
                    script.bgenum[(eventco.bgenumber - 1) * 2] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                if (edit.beventf == 10)
                {
                    script.hazimarinum[eventco.bgednumber - 1] = script3.bfilePaths[eventco.bgcgcf - 1].Substring(script3.bfilePaths[eventco.bgcgcf - 1].LastIndexOf("\\") + 1);
                }
                eventco.bgcgcf = 0;
                eventco.bgenumber = 0;
                eventco.bgednumber = 0;
                eventco.bgef = 0;
            }
            if (eventco.betf > 0)
            {
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                if (edit.beventf == 0)
                {
                    if (script2.bgevents[edit.bgc_num - eventco.betf] != string.Empty)
                    {
                        if (edit.bgc_num - eventco.betf > 0)
                        {
                            if (int.Parse(script2.bgevents[edit.bgc_num - eventco.betf]) >= -1 & int.Parse(script2.bgevents[edit.bgc_num - eventco.betf]) > script.bgchantei[edit.bgc_num - eventco.betf - 1])
                            {
                                script.bgchantei[edit.bgc_num - eventco.betf] = int.Parse(script2.bgevents[edit.bgc_num - eventco.betf]);
                            }
                        }
                        else
                        {
                            script.bgchantei[edit.bgc_num - eventco.betf] = int.Parse(script2.bgevents[edit.bgc_num - eventco.betf]);
                        }
                    }
                }
                if (edit.beventf == 1)
                {
                    if (script2.bgevents[edit.bgcd_num - eventco.betf] != string.Empty)
                    {
                        if (edit.bgcd_num - eventco.betf > 0)
                        {
                            if (int.Parse(script2.bgevents[edit.bgcd_num - eventco.betf]) >= -1 & int.Parse(script2.bgevents[edit.bgcd_num - eventco.betf]) > script.bgcdhantei[edit.bgcd_num - eventco.betf - 1])
                            {
                                script.bgcdhantei[edit.bgcd_num - eventco.betf] = int.Parse(script2.bgevents[edit.bgcd_num - eventco.betf]);
                            }
                        }
                        else
                        {
                            script.bgcdhantei[edit.bgcd_num - eventco.betf] = int.Parse(script2.bgevents[edit.bgcd_num - eventco.betf]);
                        }
                    }
                }
                if (edit.beventf == 2)
                {
                    if (script2.bgevents[edit.chap_num - eventco.betf] != string.Empty)
                    {
                        if (edit.chap_num - eventco.betf > 0)
                        {
                            if (int.Parse(script2.bgevents[edit.chap_num - eventco.betf]) > 0 & int.Parse(script2.bgevents[edit.chap_num - eventco.betf]) > script.chaphantei[edit.chap_num - eventco.betf - 1])
                            {
                                script.chaphantei[edit.chap_num - eventco.betf] = int.Parse(script2.bgevents[edit.chap_num - eventco.betf]);
                            }
                        }
                        else
                        {
                            script.chaphantei[edit.chap_num - eventco.betf] = int.Parse(script2.bgevents[edit.chap_num - eventco.betf]);
                        }
                    }
                }
                if (edit.beventf == 3)
                {
                    if (script2.bgevents[edit.chapt_num - eventco.betf] != string.Empty)
                    {
                        if (edit.chapt_num - eventco.betf > 0)
                        {
                            if (int.Parse(script2.bgevents[edit.chapt_num - eventco.betf]) >= -1 & int.Parse(script2.bgevents[edit.chapt_num - eventco.betf]) > script.chapthantei[edit.chapt_num - eventco.betf - 1])
                            {
                                script.chapthantei[edit.chapt_num - eventco.betf] = int.Parse(script2.bgevents[edit.chapt_num - eventco.betf]);
                            }
                        }
                        else
                        {
                            script.chapthantei[edit.chapt_num - eventco.betf] = int.Parse(script2.bgevents[edit.chapt_num - eventco.betf]);
                        }
                    }
                }
                if (edit.beventf == 4)
                {
                    if (script2.bgevents[edit.kakudai_num - eventco.betf] != string.Empty)
                    {
                        if (edit.kakudai_num - eventco.betf > 0)
                        {
                            if (int.Parse(script2.bgevents[edit.kakudai_num - eventco.betf]) >= -1 & int.Parse(script2.bgevents[edit.kakudai_num - eventco.betf]) > script.kakudaihantei[edit.kakudai_num - eventco.betf - 1])
                            {
                                script.kakudaihantei[edit.kakudai_num - eventco.betf] = int.Parse(script2.bgevents[edit.kakudai_num - eventco.betf]);
                            }
                        }
                        else
                        {
                            script.kakudaihantei[edit.kakudai_num - eventco.betf] = int.Parse(script2.bgevents[edit.kakudai_num - eventco.betf]);
                        }
                    }
                }
                if (edit.beventf == 6)
                {
                    if (script2.bgevents[(edit.bgsw_num - eventco.betf) * 2] != string.Empty)
                    {
                        if ((edit.bgsw_num - eventco.betf) * 2 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2]) >= -1 & int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2]) > script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2 - 1])
                            {
                                script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2]);
                            }
                        }
                        else
                        {
                            script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2]);
                        }
                    }
                    if (script2.bgevents[(edit.bgsw_num - eventco.betf) * 2 + 1] != string.Empty)
                    {
                        if ((edit.bgsw_num - eventco.betf) * 2 + 1 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2 + 1]) >= -1 & int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2 + 1]) > script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2 + 1 - 1])
                            {
                                script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2 + 1]);
                            }
                        }
                        else
                        {
                            script.bgswhantei[(edit.bgsw_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bgsw_num - eventco.betf) * 2 + 1]);
                        }
                    }
                }
                if (edit.beventf == 7)
                {
                    if (script2.bgevents[(edit.bglw_num - eventco.betf) * 2] != string.Empty)
                    {
                        if ((edit.bglw_num - eventco.betf) * 2 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2]) >= -1 & int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2]) > script.bglwhantei[(edit.bglw_num - eventco.betf) * 2 - 1])
                            {
                                script.bglwhantei[(edit.bglw_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2]);
                            }
                        }
                        else
                        {
                            script.bglwhantei[(edit.bglw_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2]);
                        }
                    }
                    if (script2.bgevents[(edit.bglw_num - eventco.betf) * 2 + 1] != string.Empty)
                    {
                        if ((edit.bglw_num - eventco.betf) * 2 + 1 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2 + 1]) >= -1 & int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2 + 1]) > script.bglwhantei[(edit.bglw_num - eventco.betf) * 2 + 1 - 1])
                            {
                                script.bglwhantei[(edit.bglw_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2 + 1]);
                            }
                        }
                        else
                        {
                            script.bglwhantei[(edit.bglw_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bglw_num - eventco.betf) * 2 + 1]);
                        }
                    }
                }
                if (edit.beventf == 8)
                {
                    if (script2.bgevents[(edit.bge_num - eventco.betf) * 2] != string.Empty)
                    {
                        if ((edit.bge_num - eventco.betf) * 2 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2]) >= -1 & int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2]) > script.bgehantei[(edit.bge_num - eventco.betf) * 2 - 1])
                            {
                                script.bgehantei[(edit.bge_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2]);
                            }
                        }
                        else
                        {
                            script.bgehantei[(edit.bge_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2]);
                        }
                    }
                    if (script2.bgevents[(edit.bge_num - eventco.betf) * 2 + 1] != string.Empty)
                    {
                        if ((edit.bge_num - eventco.betf) * 2 + 1 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2 + 1]) >= -1 & int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2 + 1]) > script.bgehantei[(edit.bge_num - eventco.betf) * 2 + 1 - 1])
                            {
                                script.bgehantei[(edit.bge_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2 + 1]);
                            }
                        }
                        else
                        {
                            script.bgehantei[(edit.bge_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.bge_num - eventco.betf) * 2 + 1]);
                        }
                    }
                }
                if (edit.beventf == 9)
                {
                    if (script2.bgevents[(edit.serious_num - eventco.betf) * 2] != string.Empty)
                    {
                        if ((edit.serious_num - eventco.betf) * 2 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2]) >= -1 & int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2]) > script.serioushantei[(edit.serious_num - eventco.betf) * 2 - 1])
                            {
                                script.serioushantei[(edit.serious_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2]);
                            }
                        }
                        else
                        {
                            script.serioushantei[(edit.serious_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2]);
                        }
                    }
                    if (script2.bgevents[(edit.serious_num - eventco.betf) * 2 + 1] != string.Empty)
                    {
                        if ((edit.serious_num - eventco.betf) * 2 + 1 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2 + 1]) >= -1 & int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2 + 1]) > script.serioushantei[(edit.serious_num - eventco.betf) * 2 + 1 - 1])
                            {
                                script.serioushantei[(edit.serious_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2 + 1]);
                            }
                        }
                        else
                        {
                            script.serioushantei[(edit.serious_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.serious_num - eventco.betf) * 2 + 1]);
                        }
                    }
                }
                if (edit.beventf == 10)
                {
                    if (script2.bgevents[(edit.hazimari_num - eventco.betf) * 2] != string.Empty)
                    {
                        if ((edit.hazimari_num - eventco.betf) * 2 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2]) >= -1 & int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2]) > script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2 - 1])
                            {
                                script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2]);
                            }
                        }
                        else
                        {
                            script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2] = int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2]);
                        }
                    }
                    if (script2.bgevents[(edit.hazimari_num - eventco.betf) * 2 + 1] != string.Empty)
                    {
                        if ((edit.hazimari_num - eventco.betf) * 2 + 1 > 0)
                        {
                            if (int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2 + 1]) >= -1 & int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2 + 1]) > script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2 + 1 - 1])
                            {
                                script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2 + 1]);
                            }
                        }
                        else
                        {
                            script.hazimarihantei[(edit.hazimari_num - eventco.betf) * 2 + 1] = int.Parse(script2.bgevents[(edit.hazimari_num - eventco.betf) * 2 + 1]);
                        }
                    }
                }
                eventco.betf = 0;
                eventco.bgef = -1;
            }
            if (eventco.beikf == 1)
            {
                if (edit.beventf == 0)
                {
                    for (editbex = 0; editbex < textt.bgcs; editbex++)
                    {
                        if (editbex == 0 & (script2.bgevents[0] != string.Empty & script2.bgevents[0] != null))
                        {
                            if (int.Parse(script2.bgevents[0]) >= -1)
                            {
                                script.bgchantei[0] = int.Parse(script2.bgevents[0]);
                            }
                        }
                        if (editbex > 0 & (script2.bgevents[editbex] != string.Empty & script2.bgevents[editbex] != null))
                        {
                            if (int.Parse(script2.bgevents[editbex]) > script.bgchantei[editbex - 1])
                            {
                                script.bgchantei[editbex] = int.Parse(script2.bgevents[editbex]);
                            }
                            else
                            {
                                script.bgchantei[editbex] = 0;
                                editbex = textt.bgcs;
                            }
                        }
                    }
                    if (editbex >= textt.bgcs)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.bgef = -1;
                        editbex = 0;
                        eventco.beikf = 0;
                    }
                }
                if (edit.beventf == 1)
                {
                    for (editbex = 0; editbex < textt.bgcds; editbex++)
                    {
                        if (editbex == 0 & (script2.bgevents[0] != string.Empty & script2.bgevents[0] != null))
                        {
                            if (int.Parse(script2.bgevents[0]) >= -1)
                            {
                                script.bgcdhantei[0] = int.Parse(script2.bgevents[0]);
                            }
                        }
                        if (editbex > 0 & (script2.bgevents[editbex] != string.Empty & script2.bgevents[editbex] != null))
                        {
                            if (int.Parse(script2.bgevents[editbex]) > script.bgcdhantei[editbex - 1])
                            {
                                script.bgcdhantei[editbex] = int.Parse(script2.bgevents[editbex]);
                            }
                            else
                            {
                                script.bgcdhantei[editbex] = 0;
                                editbex = textt.bgcds;
                            }
                        }
                    }
                    if (editbex >= textt.bgcds)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.bgef = -1;
                        editbex = 0;
                        eventco.beikf = 0;
                    }
                }
                if (edit.beventf == 2)
                {
                    for (editbex = 0; editbex < textt.chaps; editbex++)
                    {
                        if (editbex == 0 & (script2.bgevents[0] != string.Empty & script2.bgevents[0] != null))
                        {
                            if (int.Parse(script2.bgevents[0]) >= -1)
                            {
                                script.chaphantei[0] = int.Parse(script2.bgevents[0]);
                            }
                        }
                        if (editbex > 0 & (script2.bgevents[editbex] != string.Empty & script2.bgevents[editbex] != null))
                        {
                            if (int.Parse(script2.bgevents[editbex]) > script.chaphantei[editbex - 1])
                            {
                                script.chaphantei[editbex] = int.Parse(script2.bgevents[editbex]);
                            }
                            else
                            {
                                script.chaphantei[editbex] = 0;
                                editbex = textt.chaps;
                            }
                        }
                    }
                    if (editbex >= textt.chaps)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.bgef = -1;
                        editbex = 0;
                        eventco.beikf = 0;
                    }
                }
                if (edit.beventf == 3)
                {
                    for (editbex = 0; editbex < textt.chapts; editbex++)
                    {
                        if (editbex == 0 & (script2.bgevents[0] != string.Empty & script2.bgevents[0] != null))
                        {
                            if (int.Parse(script2.bgevents[0]) >= -1)
                            {
                                script.chapthantei[0] = int.Parse(script2.bgevents[0]);
                            }
                        }
                        if (editbex > 0 & (script2.bgevents[editbex] != string.Empty & script2.bgevents[editbex] != null))
                        {
                            if (int.Parse(script2.bgevents[editbex]) > script.chapthantei[editbex - 1])
                            {
                                script.chapthantei[editbex] = int.Parse(script2.bgevents[editbex]);
                            }
                            else
                            {
                                script.chapthantei[editbex] = 0;
                                editbex = textt.chapts;
                            }
                        }
                    }
                    if (editbex >= textt.chapts)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.bgef = -1;
                        editbex = 0;
                        eventco.beikf = 0;
                    }
                }
                if (edit.beventf == 4)
                {
                    for (editbex = 0; editbex < textt.kakudais; editbex++)
                    {
                        if (editbex == 0 & (script2.bgevents[0] != string.Empty & script2.bgevents[0] != null))
                        {
                            if (int.Parse(script2.bgevents[0]) >= -1)
                            {
                                script.kakudaihantei[0] = int.Parse(script2.bgevents[0]);
                            }
                        }
                        if (editbex > 0 & (script2.bgevents[editbex] != string.Empty & script2.bgevents[editbex] != null))
                        {
                            if (int.Parse(script2.bgevents[editbex]) > script.kakudaihantei[editbex - 1])
                            {
                                script.kakudaihantei[editbex] = int.Parse(script2.bgevents[editbex]);
                            }
                            else
                            {
                                script.kakudaihantei[editbex] = 0;
                                editbex = textt.kakudais;
                            }
                        }
                    }
                    if (editbex >= textt.kakudais)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        eventco.bgef = -1;
                        editbex = 0;
                        eventco.beikf = 0;
                    }
                }
            }
        }
        //音源のページ
        if (audioco.auf > 0)
        {

            if (audioco.audiosebf > 0 & audioco.audiocf > 0)
            {
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;

                if (edit.audiof == 0)
                {
                    script.bgmnum[edit.bgm_num - audioco.audiosebf] = script2.bgmname[audioco.audiocf - 1];
                }
                if (edit.audiof == 1)
                {
                    script.bgmenum[edit.bgme_num - audioco.audiosebf] = script2.bgmename[audioco.audiocf - 1];
                }
                if (edit.audiof == 2)
                {
                    script.bgmefnum[edit.bgmef_num - audioco.audiosebf] = script2.bgmefname[audioco.audiocf - 1];
                }
                audioco.audiosebf = 0;
                audioco.audiocf = 0;
            }
            if (audioco.audiosef > 0)
            {
                if (edit.audiof == 0)
                {
                    if (script2.audios[edit.bgm_num - audioco.audiosef] != string.Empty)
                    {
                        if (edit.bgm_num - audioco.audiosef > 0)
                        {
                            if (int.Parse(script2.audios[edit.bgm_num - audioco.audiosef]) >= -1 & int.Parse(script2.audios[edit.bgm_num - audioco.audiosef]) > script.bgmhantei[edit.bgm_num - audioco.audiosef - 1])
                            {
                                script.bgmhantei[edit.bgm_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgm_num - audioco.audiosef]);
                            }
                        }
                        else
                        {
                            script.bgmhantei[edit.bgm_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgm_num - audioco.audiosef]);
                        }
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                if (edit.audiof == 1)
                {
                    if (script2.audios[edit.bgme_num - audioco.audiosef] != string.Empty)
                    {
                        if (edit.bgme_num - audioco.audiosef > 0)
                        {
                            if (int.Parse(script2.audios[edit.bgme_num - audioco.audiosef]) >= -1 & int.Parse(script2.audios[edit.bgme_num - audioco.audiosef]) > script.bgmehantei[edit.bgme_num - audioco.audiosef - 1])
                            {
                                script.bgmehantei[edit.bgme_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgme_num - audioco.audiosef]);
                            }
                        }
                        else
                        {
                            script.bgmehantei[edit.bgme_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgme_num - audioco.audiosef]);
                        }
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                if (edit.audiof == 2)
                {
                    if (script2.audios[edit.bgmef_num - audioco.audiosef] != string.Empty)
                    {
                        if (edit.bgmef_num - audioco.audiosef > 0)
                        {
                            if (int.Parse(script2.audios[edit.bgmef_num - audioco.audiosef]) >= -1 & int.Parse(script2.audios[edit.bgmef_num - audioco.audiosef]) > script.bgmefhantei[edit.bgmef_num - audioco.audiosef - 1])
                            {
                                script.bgmefhantei[edit.bgmef_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgmef_num - audioco.audiosef]);
                            }
                        }
                        else
                        {
                            script.bgmefhantei[edit.bgmef_num - audioco.audiosef] = int.Parse(script2.audios[edit.bgmef_num - audioco.audiosef]);
                        }
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                    }
                }
                audioco.auf = -1;
            }
            if (audioco.auikf == 1)
            {
                if (edit.audiof == 0)
                {
                    for (editaux = 0; editaux < textt.bgms; editaux++)
                    {
                        if (editaux == 0 & (script2.audios[0] != string.Empty & script2.audios[0] != null))
                        {
                            if (int.Parse(script2.audios[0]) >= -1)
                            {
                                script.bgmhantei[0] = int.Parse(script2.audios[0]);
                            }
                        }
                        if (editaux > 0 & (script2.audios[editaux] != string.Empty & script2.audios[editaux] != null))
                        {
                            if (int.Parse(script2.audios[editaux]) > script.bgmhantei[editaux - 1])
                            {
                                script.bgmhantei[editaux] = int.Parse(script2.audios[editaux]);
                            }
                            else
                            {
                                script.bgmhantei[editaux] = 0;
                                editaux = textt.bgms;
                            }
                        }
                    }
                    if (editaux >= textt.bgms)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        audioco.auf = -1;
                        editaux = 0;
                        audioco.auikf = 0;
                    }
                }
                if (edit.audiof == 1)
                {
                    for (editaux = 0; editaux < textt.bgmes; editaux++)
                    {
                        if (editaux == 0 & (script2.audios[0] != string.Empty & script2.audios[0] != null))
                        {
                            if (int.Parse(script2.audios[0]) >= -1)
                            {
                                script.bgmehantei[0] = int.Parse(script2.audios[0]);
                            }
                        }
                        if (editaux > 0 & (script2.audios[editaux] != string.Empty & script2.audios[editaux] != null))
                        {
                            if (int.Parse(script2.audios[editaux]) > script.bgmehantei[editaux - 1])
                            {
                                script.bgmehantei[editaux] = int.Parse(script2.audios[editaux]);
                            }
                            else
                            {
                                script.bgmehantei[editaux] = 0;
                                editaux = textt.bgmes;
                            }
                        }
                    }
                    if (editaux >= textt.bgmes)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        audioco.auf = -1;
                        editaux = 0;
                        audioco.auikf = 0;
                    }
                }
                if (edit.audiof == 2)
                {
                    for (editaux = 0; editaux < textt.bgmefs; editaux++)
                    {
                        if (editaux == 0 & (script2.audios[0] != string.Empty & script2.audios[0] != null))
                        {
                            if (int.Parse(script2.audios[0]) >= -1)
                            {
                                script.bgmefhantei[0] = int.Parse(script2.audios[0]);
                            }
                        }
                        if (editaux > 0 & (script2.audios[editaux] != string.Empty & script2.audios[editaux] != null))
                        {
                            if (int.Parse(script2.audios[editaux]) > script.bgmefhantei[editaux - 1])
                            {
                                script.bgmefhantei[editaux] = int.Parse(script2.audios[editaux]);
                            }
                            else
                            {
                                script.bgmefhantei[editaux] = 0;
                                editaux = textt.bgmefs;
                            }
                        }
                    }
                    if (editaux >= textt.bgmefs)
                    {
                        sif += 1;
                        simf = sif;
                        susumu.sinkf = 1;
                        audioco.auf = -1;
                        editaux = 0;
                        audioco.auikf = 0;
                    }
                }

            }
        }
        //ビデオのページ
        if (audioco.vif > 0)
        {

            if (audioco.videosebf > 0 & audioco.videocf > 0)
            {
                sif += 1;
                simf = sif;
                susumu.sinkf = 1;
                script.videonum[edit.video_num - audioco.videosebf] = script2.videoname[audioco.videocf - 1];
                audioco.videosebf = 0;
                audioco.videocf = 0;
            }
            if (audioco.videosef > 0)
            {
                if (script2.videos[edit.video_num - audioco.videosef] != string.Empty)
                {
                    if (edit.video_num - audioco.videosef > 0)
                    {
                        if (int.Parse(script2.videos[edit.video_num - audioco.videosef]) >= -1 & int.Parse(script2.videos[edit.video_num - audioco.videosef]) > script.videohantei[edit.video_num - audioco.videosef - 1])
                        {
                            script.videohantei[edit.video_num - audioco.videosef] = int.Parse(script2.videos[edit.video_num - audioco.videosef]);
                        }
                    }
                    else
                    {
                        script.videohantei[edit.video_num - audioco.videosef] = int.Parse(script2.videos[edit.video_num - audioco.videosef]);
                    }
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                }
                audioco.vif = -1;
            }
            if (audioco.viikf == 1)
            {
                for (editvix = 0; editvix < textt.videos; editvix++)
                {
                    if (editvix == 0 & (script2.videos[0] != string.Empty & script2.videos[0] != null))
                    {
                        if (int.Parse(script2.videos[0]) >= -1)
                        {
                            script.videohantei[0] = int.Parse(script2.videos[0]);
                        }
                    }
                    if (editvix > 0 & (script2.videos[editvix] != string.Empty & script2.videos[editvix] != null))
                    {
                        if (int.Parse(script2.videos[editvix]) > script.videohantei[editvix - 1])
                        {
                            script.videohantei[editvix] = int.Parse(script2.videos[editvix]);
                        }
                        else
                        {
                            script.videohantei[editvix] = 0;
                            editvix = textt.videos;
                        }
                    }
                }
                if (editvix >= textt.videos)
                {
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    audioco.vif = -1;
                    editvix = 0;
                    audioco.viikf = 0;
                }
            }
        }


        //セーブのページ
        if (esaveco.esavf > 0)
        {
            if (edit.editp == 5)
            {
                if (esaveco.sentakuusef > 0)
                {
                    int jsx = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                    textti.loaddata = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                    esaveco.sentakuusef = 0;
                }
                if (esaveco.sentakujsonf > 0)
                {
                    int jsx = script2.jsonname[esaveco.sentakujsonf + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                    jsonny.text = script2.jsonname[esaveco.sentakujsonf + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                    esaveco.sentakujsonf = 0;
                }
                if (esaveco.sentakutxtf > 0)
                {
                    int txtx = script2.txtname[esaveco.sentakutxtf + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                    txtny.text = script2.txtname[esaveco.sentakutxtf + 12 * edit.tsepage - 1].Substring(txtx).Replace(".txt", null);
                    esaveco.sentakutxtf = 0;
                }
            }
            //選択肢
            if (edit.editp == 10)
            {
                if (esaveco.senikf == 1)
                {
                    for (senex = 0; senex < textt.sentakus * 2; senex++)
                    {
                        if (script2.sentakubs[senex] != string.Empty)
                        {
                            script.sentakubnum.SetValue(script2.sentakubs[senex], senex);
                        }
                    }
                    if (senex >= textt.sentakus * 2)
                    {
                        dsif += 1;
                        dsimf = dsif;
                        susumuk.dsinkf = 1;
                        esaveco.senf = 1;
                        esaveco.senikf = 0;
                        senex = 0;
                    }
                }
                if (esaveco.sentakuusef > 0)
                {
                    if (esaveco.useflag < 11)
                    {
                        System.Array.Resize(ref script.sentakuknum, textt.sentakus + 1);
                        System.Array.Resize(ref script.sentakubnum, (textt.sentakus + 1) * 2);
                        System.Array.Resize(ref script.sentakudnum, (textt.sentakus + 1) * 2);
                        System.Array.Resize(ref script.sentakuhantei, textt.sentakus + 1);
                        System.Array.Resize(ref script.sentakutypes, textt.sentakus + 1);
                        textt.sentakus += 1;
                        int jsx = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                        script.sentakudnum[edit.sentakut_num - esaveco.useflag] = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                        script.sentakuknum[edit.sentakut_num - esaveco.useflag + 1] = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                        esaveco.sentakuusef = 0;
                        script2.sentakuts = new string[textt.sentakus];
                        script2.sentakubs = new string[textt.sentakus * 2];
                        script2.sentakuds = new string[textt.sentakus * 2];
                    }
                    else
                    {
                        int jsx = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                        script.sentakuknum[0] = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                    }
                    esaveco.sentakuusef = 0;
                    dsif += 1;
                    dsimf = dsif;
                    susumuk.dsinkf = 1;
                }
                esaveco.senf = -1;
            }
            if (edit.editp == 12)
            {
                if (esaveco.sentakuusef > 0)
                {
                    int jsx = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                    textti.loaddata = script2.jsonname[esaveco.sentakuusef + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                    esaveco.sentakuusef = 0;
                    dsif += 1;
                    dsimf = dsif;
                    susumuk.dsinkf = 1;
                }
                if (esaveco.sentakujsonf > 0)
                {
                    int jsx = script2.jsonname[esaveco.sentakujsonf + 12 * edit.tsepage - 1].LastIndexOf("/") + 1;
                    ujsonny.text = script2.jsonname[esaveco.sentakujsonf + 12 * edit.tsepage - 1].Substring(jsx).Replace(".json", null);
                    esaveco.sentakujsonf = 0;
                    dsif += 1;
                    dsimf = dsif;
                    susumuk.dsinkf = 1;
                }
            }
            esaveco.esavf = 0;
        }
        //UI設定
        if (esaveco.uif == 1)
        {
            if (esaveco.uigcf > 0 & esaveco.uinumber > 0)
            {
                dsif += 1;
                dsimf = dsif;
                susumuk.dsinkf = 1;
                if (edit.uipanelf == 0)
                {
                    script.uitnum[esaveco.uinumber - 1] = script3.ufilePaths[esaveco.uigcf - 1].Substring(script3.ufilePaths[esaveco.uigcf - 1].LastIndexOf("\\") + 1);
                }
                else if (edit.uipanelf==1)
                {
                    script.uignum[esaveco.uinumber - 1] = script3.ufilePaths[esaveco.uigcf - 1].Substring(script3.ufilePaths[esaveco.uigcf - 1].LastIndexOf("\\") + 1);
                }
                else
                {
                    script.gamelogohantei[esaveco.uinumber - 1] = script3.ufilePaths[esaveco.uigcf - 1].Substring(script3.ufilePaths[esaveco.uigcf - 1].LastIndexOf("\\") + 1);
                }
                esaveco.uigcf = 0;
                esaveco.uinumber = 0;
                esaveco.uif = 0;
            }
            if (esaveco.uidelnumber > 0)
            {
                if (edit.uipanelf == 0)
                {
                    if (script.uitnum[edit.uit_num - esaveco.uidelnumber] != string.Empty & script.uitnum[edit.uit_num - esaveco.uidelnumber] != null)
                    {
                        script.uitnum[edit.uit_num - esaveco.uidelnumber] = string.Empty;
                        dsif += 1;
                        dsimf = dsif;
                        susumuk.dsinkf = 1;
                    }
                }
                else if(edit.uipanelf == 1)
                {
                    if (script.uignum[edit.uig_num - esaveco.uidelnumber] != string.Empty & script.uignum[edit.uig_num - esaveco.uidelnumber] != null)
                    {
                        script.uignum[edit.uig_num - esaveco.uidelnumber] = string.Empty;
                        dsif += 1;
                        dsimf = dsif;
                        susumuk.dsinkf = 1;
                    }
                }
                else
                {
                    if (script.gamelogohantei[edit.glo_num - esaveco.uidelnumber] != string.Empty & script.gamelogohantei[edit.glo_num - esaveco.uidelnumber] != null)
                    {
                        script.gamelogohantei[edit.glo_num - esaveco.uidelnumber] = string.Empty;
                        dsif += 1;
                        dsimf = dsif;
                        susumuk.dsinkf = 1;
                    }
                }
                esaveco.uidelnumber = 0;
            }
        }
        //保存する変数の更新
        e.texte = script.text;
        e.texthe=script.texth;
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
        e.namee = script.name;
        e.colore = script.color;
        e.cpice = script.cpic;
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
        //セーブ(Json)
        titletext = titleny.text;
        if (titleaf==1)
        {
            titlea.SetActive(true);
            if (titletext.Length>0)
            {
                titlea.SetActive(false);
                titleaf = 0;
            }
        }
        else
        {
            titlea.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)&Input.GetKeyDown(KeyCode.S))
        {
            if (titletext.Length == 0)
            {
                titleaf = 1;
            }
            else
            {
                sf = 2;
            }
        }
        if (edit.editf == 1)
        {
            if (edit.editp != 5)
            {
                edit.jssname = titleny.text;
            }
        }
        else
        {
            saveloadk.ujssname = titleny.text;
        }
            //セーブ
            if (sf == 1)
            {
                sf = 0;
                if (edit.jssname != string.Empty)
                {
                    savef = simf;
                    editco.chf = -1;
                    edit.cf = 1;
                    Rewrite();
                }
            }
            //ロード(Json)
            if (sf == 2)
            {
                sf = 0;
                if (edit.jssname != string.Empty)
                {
                    edit.cf = 1;
                    loadname = edit.jssname;
                    titleny.text = loadname;
                    sif += 1;
                    simf = sif;
                    susumu.sinkf = 1;
                    Reload();
                }
            }
            if (sf == 3)
            {
                sf = 0;
                if (titleny.text != string.Empty)
                {
                    edit.cf = 1;
                    edit.jssname = titleny.text;
                    loadname = titleny.text;
                    edit.editp = 0;
                    sif = 0;
                    simf = sif;
                    susumu.sinkf = 1;
                    Reload();
                }
        }
    }
        public void Rewrite()
    {
        string jsonstr = JsonUtility.ToJson(e);
        var writer = new StreamWriter(Application.dataPath + "/SAVEDATA/json/part/" + edit.jssname + ".json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        textt.dataload = 1;
    }
    public void Reload()
    {
        if (File.Exists(Application.dataPath + "/SAVEDATA/json/part/" + edit.jssname + ".json"))
        {
            var fs = new FileStream(
               Application.dataPath + "/SAVEDATA/json/part/" + edit.jssname + ".json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            string datastr = string.Empty;
            var reader = new StreamReader(fs);
            reader = new StreamReader(Application.dataPath + "/SAVEDATA/json/part/" + edit.jssname + ".json");
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
            script.name = e.namee;
            script.color = e.colore;
            script.texth = e.texthe;
            script.textho = e.texthoe;
            script.cpic = e.cpice;
            script.bgchantei = e.bgchanteie;
            script.bgcnum = e.bgcnume;
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
            script.unazhantei = e.unazhanteie;
            script.unazc = e.unazce;
            script.unaznum = e.unaznume;
            script.odorokihantei = e.odorokihanteie;
            script.odorokic = e.odorokice;
            script.odorokinum = e.odorokinume;
            script.daruhantei = e.daruhanteie;
            script.daruc = e.daruce;
            script.darunum = e.darunume;
            script.chrcdnum = e.chrcdnume;
            script.ocolor=e.ocolore;
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
            edit.tnum = 0;
            edit.num = 0;
            edit.cnum = 0;
            edit.bgmef_num = 0;
            edit.bgme_num = 0;
            edit.bgm_num = 0;
            textt.dataload = 1;

        }
    }
}