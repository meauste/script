using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class dataload : MonoBehaviour
{
    public string[] filePaths;
    public string gfilePath;
    public string cfilePath;
    public string ufilePath;
    public string mfilePath;
    public string ePath;
    public string wePath;
    public static int fx;
    public string[] cfilePaths;
    public static int cx;
    public static int cexnum;
    public int cexmnum;
    public static int cxflag;
    public static int cexmpage;
    public Texture2D[] ctexture;
    public Sprite[] csprite;
    public string bfilePath;
    public string[] bfilePaths;
    public static int bx;
    public static int bexnum;
    public int bexmnum;
    public static int datf;
    public static int bxflag;
    public GameObject loadtext;
    public GameObject loadgage;
    public static int bexmpage;
    public Texture2D[] btexture;
    public Sprite[] bsprite;
    public string bgmfilePath;
    public string bgmefilePath;
    public string bgmeffilePath;
    public string vfilePath;
    public GameObject loadpanel;
    public GameObject loadgtext;
    public string bgm;
    //UIファイル
    public static int uixnum;
    public int uixmnum;
    public static int uixmpage;
    public string[] ufilePaths;
    public static int ux;
    public static int uxflag;
    public Texture2D[] utexture;
    public Sprite[] usprite;
    textt script;
    public Dictionary<string, Sprite> chrs;
    public Dictionary<string, Sprite> bgs;
    public Dictionary<string, Sprite> uis;
    // Start is called before the first frame update
    void Start()
    {
        filePaths = new string[9] { "/GAMEDATA", "/GAMEDATA/Chr", "/GAMEDATA/Bg", "/GAMEDATA/UI", "/GAMEDATA/Music", "/GAMEDATA/Music/BGM", "/GAMEDATA/Music/BGMEN", "/GAMEDATA/Music/BGMEF", "/GAMEDATA/Video" };
        gfilePath = Application.dataPath + "/GAMEDATA";
        if (Directory.Exists(gfilePath) == false)
        {
            Directory.CreateDirectory(gfilePath);
        }
        cfilePath = Application.dataPath +"/GAMEDATA/Chr";
        if (Directory.Exists(cfilePath) == false)
        {
            Directory.CreateDirectory(cfilePath);
        }
        bfilePath = Application.dataPath+"/GAMEDATA/Bg";
        if (Directory.Exists(bfilePath) == false)
        {
            Directory.CreateDirectory(bfilePath);
        }
        ufilePath = Application.dataPath + "/GAMEDATA/UI";
        if (Directory.Exists(ufilePath) == false)
        {
            Directory.CreateDirectory(ufilePath);
        }
        mfilePath = Application.dataPath + "/GAMEDATA/Music";
        if (Directory.Exists(mfilePath) == false)
        {
            Directory.CreateDirectory(mfilePath);
        }
        bgmfilePath = Application.dataPath + "/GAMEDATA/Music/BGM";
        if (Directory.Exists(bgmfilePath) == false)
        {
            Directory.CreateDirectory(bgmfilePath);
        }
        bgmefilePath = Application.dataPath + "/GAMEDATA/Music/BGMEN";
        if (Directory.Exists(bgmefilePath) == false)
        {
            Directory.CreateDirectory(bgmefilePath);
        }
        bgmeffilePath = Application.dataPath + "/GAMEDATA/Music/BGMEF";
        if (Directory.Exists(bgmeffilePath) == false)
        {
            Directory.CreateDirectory(bgmeffilePath);
        }
        vfilePath = Application.dataPath + "/GAMEDATA/Video";
        if (Directory.Exists(vfilePath) == false)
        {
            Directory.CreateDirectory(vfilePath);
        }
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
        chrs = new Dictionary<string, Sprite>();
        bgs = new Dictionary<string, Sprite>();
        uis = new Dictionary<string, Sprite>();
        //背景
        string[] bpicnamem = Directory.GetFiles(bfilePath);
        bfilePaths = System.Array.FindAll(bpicnamem, t => t.Contains(".meta") == false & (t.Contains(".png") == true | t.Contains(".jpg") == true | t.Contains(".jpeg") == true));
        //キャラ
        string[] cpicnamem = Directory.GetFiles(cfilePath);
        cfilePaths = System.Array.FindAll(cpicnamem, t => t.Contains(".meta") == false & t.Contains(".png") == true);
        //UI
        string[] upicnamem = Directory.GetFiles(ufilePath);
        ufilePaths = System.Array.FindAll(upicnamem, t => t.Contains(".meta") == false & (t.Contains(".png") == true | t.Contains(".jpg") == true | t.Contains(".jpeg") == true));
        uixmnum = 0;
        cexmnum = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        //ファイル復元
        for (fx = 0; fx < filePaths.Length; fx++)
        {
            if (Directory.Exists(Application.dataPath + filePaths[fx]) == false)
            {
                Directory.CreateDirectory(Application.dataPath + filePaths[fx]);
            }
        }
        //ファイル指定
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (edit.editp == 4)
            {
                //背景
                string[] bpicnamem = Directory.GetFiles(bfilePath);
                bfilePaths = System.Array.FindAll(bpicnamem, t => t.Contains(".meta") == false & (t.Contains(".png") == true | t.Contains(".jpg") == true | t.Contains(".jpeg") == true));
            }
            if (edit.editp == 3)
            {
                //キャラ
                string[] cpicnamem = Directory.GetFiles(cfilePath);
                cfilePaths = System.Array.FindAll(cpicnamem, t => t.Contains(".meta") == false & t.Contains(".png") == true);
            }
            if (edit.editp == 11)
            {
                //UI
                string[] upicnamem = Directory.GetFiles(ufilePath);
                ufilePaths = System.Array.FindAll(upicnamem, t => t.Contains(".meta") == false & (t.Contains(".png") == true | t.Contains(".jpg") == true | t.Contains(".jpeg") == true));
            }
        }
        //キャラ画像ファイル
        cexnum = cfilePaths.Length;
        if (cexnum != 0 & cexnum % 10 == 0)
        {
            cexmpage = (cexnum / 10) - 1;
        }
        else
        {
            cexmpage = cexnum / 10;
        }
        if (cexnum - cexmnum != 0)
        {
            cxflag = 1;
        }
        if (cxflag == 1 & cx < cexnum)
        {
            System.Array.Resize(ref ctexture, cexnum);
            System.Array.Resize(ref csprite, cexnum);
            ctexture[cx] = new Texture2D(0, 0, TextureFormat.RGBA32, false);
            WWW www = new WWW(cfilePaths[cx]);
            www.LoadImageIntoTexture(ctexture[cx]);
            csprite[cx] = Sprite.Create(ctexture[cx], new Rect(0, 0, ctexture[cx].width, ctexture[cx].height), Vector2.zero);
            if (chrs.ContainsKey(cfilePaths[cx].Substring(cfilePaths[cx].LastIndexOf("\\") + 1)) == false)
            {
                chrs.Add(cfilePaths[cx].Substring(cfilePaths[cx].LastIndexOf("\\") + 1), csprite[cx]);
            }
            foreach (KeyValuePair<string, Sprite> item in chrs)
            {
                if (File.Exists(Application.dataPath + "/GAMEDATA/Chr/" + item.Key) == false)
                {
                    script = GameObject.Find("textt").GetComponent<textt>();
                    datf = 1;
                    var chrc = string.Join(",", script.chrcnum);
                    chrc = chrc.Replace(item.Key, string.Empty);
                    script.chrcnum = chrc.Split(char.Parse(","));
                    var chrcd = string.Join(",", script.chrcdnum);
                    chrcd = chrcd.Replace(item.Key, string.Empty);
                    script.chrcdnum = chrcd.Split(char.Parse(","));
                    var unaz = string.Join(",", script.unaznum);
                    unaz = unaz.Replace(item.Key, string.Empty);
                    script.unaznum = unaz.Split(char.Parse(","));
                    var odoroki = string.Join(",", script.odorokinum);
                    odoroki = odoroki.Replace(item.Key, string.Empty);
                    script.odorokinum = odoroki.Split(char.Parse(","));
                    var daru = string.Join(",", script.darunum);
                    daru = daru.Replace(item.Key, string.Empty);
                    script.darunum = daru.Split(char.Parse(","));
                    chrs.Remove(item.Key);
                    edittext.sif = 0;
                    edittext.simf = edittext.sif;
                    susumu.sinkf = 1;
                }
            }
            cx++;
        }
        else
        {
            cxflag = 0;
            cx = 0;
            cexmnum = cexnum;
        }
        foreach (KeyValuePair<string, Sprite> item2 in chrs)
        {
            if (item2.Value == null)
            {
                chrs.Remove(item2.Key);
            }
        }
        //背景画像ファイル
        bexnum = bfilePaths.Length;
        if (bexnum != 0 & bexnum % 10 == 0)
        {
            bexmpage = (bexnum / 10) - 1;
        }
        else
        {
            bexmpage = bexnum / 10;
        }
        if (bexnum - bexmnum != 0)
        {
            bxflag = 1;
        }
        if (bxflag == 1 & bx < bexnum)
        {
            System.Array.Resize(ref btexture, bexnum);
            System.Array.Resize(ref bsprite, bexnum);
            btexture[bx] = new Texture2D(0, 0, TextureFormat.RGBA32, false);
            WWW www = new WWW(bfilePaths[bx]);
            www.LoadImageIntoTexture(btexture[bx]);
            bsprite[bx] = Sprite.Create(btexture[bx], new Rect(0, 0, btexture[bx].width, btexture[bx].height), Vector2.zero);
            if (bgs.ContainsKey(bfilePaths[bx].Substring(bfilePaths[bx].LastIndexOf("\\") + 1)) == false)
            {
                bgs.Add(bfilePaths[bx].Substring(bfilePaths[bx].LastIndexOf("\\") + 1), bsprite[bx]);
            }
                if (SceneManager.GetActiveScene().name=="Title")
                {
                foreach (KeyValuePair<string, Sprite> item in bgs)
                {
                    if (File.Exists(Application.dataPath + "/GAMEDATA/Bg/" + item.Key) == false)
                    {
                        script = GameObject.Find("textt").GetComponent<textt>();
                        datf = 1;
                        var bgc = string.Join(",", script.bgcnum);
                        var bgcd = string.Join(",", script.bgcdnum);
                        var chap = string.Join(",", script.chapnum);
                        var chapt = string.Join(",", script.chaptnum);
                        var kakudai = string.Join(",", script.kakudainum);
                        var bgsw = string.Join(",", script.bgswnum);
                        var bglw = string.Join(",", script.bglwnum);
                        var bge = string.Join(",", script.bgenum);
                        var hazimari = string.Join(",", script.hazimarinum);
                        bgc = bgc.Replace(item.Key, string.Empty);
                        bgcd = bgcd.Replace(item.Key, string.Empty);
                        chap = chap.Replace(item.Key, string.Empty);
                        chapt = chapt.Replace(item.Key, string.Empty);
                        kakudai = kakudai.Replace(item.Key, string.Empty);
                        bgsw = bgsw.Replace(item.Key,string.Empty);
                        bglw = bglw.Replace(item.Key,string.Empty);
                        bge = bge.Replace(item.Key,string.Empty);
                        hazimari = hazimari.Replace(item.Key,string.Empty);
                        script.bgcnum = bgc.Split(char.Parse(","));
                        script.bgcdnum = bgcd.Split(char.Parse(","));
                        script.chapnum = chap.Split(char.Parse(","));
                        script.chaptnum = chapt.Split(char.Parse(","));
                        script.kakudainum = kakudai.Split(char.Parse(","));
                        script.bgswnum = bgsw.Split(char.Parse(","));
                        script.bglwnum = bglw.Split(char.Parse(","));
                        script.bgenum = bge.Split(char.Parse(","));
                        script.hazimarinum = hazimari.Split(char.Parse(","));
                        bgs.Remove(item.Key);
                        edittext.sif =0;
                        edittext.simf = edittext.sif;
                        susumu.sinkf = 1;
                    }
                }
            }
            bx++;
        }
        else
        {
            bxflag = 0;
            bx = 0;
            bexmnum = bexnum;
        }
        //UI画像ファイル
        uixnum = ufilePaths.Length;
        if (uixnum != 0 & uixnum % 10 == 0)
        {
            uixmpage = (uixnum / 10) - 1;
        }
        else
        {
            uixmpage = uixnum / 10;
        }
        if (uixnum - uixmnum != 0)
        {
            uxflag = 1;
        }
        if (uxflag == 1 & ux < uixnum)
        {
            System.Array.Resize(ref utexture, uixnum);
            System.Array.Resize(ref usprite, uixnum);
            utexture[ux] = new Texture2D(0, 0, TextureFormat.RGBA32, false);
            WWW www = new WWW(ufilePaths[ux]);
            www.LoadImageIntoTexture(utexture[ux]);
            usprite[ux] = Sprite.Create(utexture[ux], new Rect(0, 0, utexture[ux].width, utexture[ux].height),  Vector2.zero);
            if (uis.ContainsKey(ufilePaths[ux].Substring(ufilePaths[ux].LastIndexOf("\\") + 1)) == false)
            {
                uis.Add(ufilePaths[ux].Substring(ufilePaths[ux].LastIndexOf("\\") + 1), usprite[ux]);
            }
            foreach (KeyValuePair<string, Sprite> item in uis)
            {
                if (File.Exists(Application.dataPath + "/GAMEDATA/UI/" + item.Key) == false)
                {
                    script = GameObject.Find("textt").GetComponent<textt>();
                    datf = 1;
                    var gamelogohantei = string.Join(",", script.gamelogohantei);
                    gamelogohantei = gamelogohantei.Replace(item.Key, string.Empty);
                    script.gamelogohantei = gamelogohantei.Split(char.Parse(","));
                    var uit = string.Join(",", script.uitnum);
                    uit = uit.Replace(item.Key, string.Empty);
                    script.uitnum = uit.Split(char.Parse(","));
                    var uig = string.Join(",", script.uignum);
                    uig = uig.Replace(item.Key, string.Empty);
                    script.uignum = uig.Split(char.Parse(","));
                    var uito = string.Join(",", script.uitnumo);
                    uito = uito.Replace(item.Key, string.Empty);
                    script.uitnumo = uito.Split(char.Parse(","));
                    var daru = string.Join(",", script.gamelogohanteio);
                    daru = daru.Replace(item.Key, string.Empty);
                    script.gamelogohanteio = daru.Split(char.Parse(","));
                    uis.Remove(item.Key);
                    edittext.dsif = 0;
                    edittext.dsimf = edittext.dsif;
                    susumuk.dsinkf = 1;
                }
            }
            ux++;
        }
        else
        {
            uxflag = 0;
            ux = 0;
            uixmnum = uixnum;
        }
        foreach (KeyValuePair<string, Sprite> item3 in uis)
        {
            if (item3.Value == null)
            {
                uis.Remove(item3.Key);
            }
        }
        //画像ロード画面
        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (ButtonManager.gamelogohantei != 0)
            {
                loadpanel.SetActive(false);
                if (ButtonManager.gamelogohantei == -2)
                {
                    loadtext.SetActive(true);
                    ButtonManager.gamelogohantei = -1;
                }
                if (cexnum == cexmnum & bexnum == bexmnum& uixnum == uixmnum & ButtonManager.gamelogohantei == -1)
                {
                    Text loadg = loadgage.GetComponent<Text>();
                    loadg.text = "100％";
                    loadtext.SetActive(false);
                    if (Bgcontroller.endflag == 1)
                    {
                        ButtonManager.gamelogohantei = 0;
                        Bgcontroller.endflag = 0;
                    }
                    else
                    {
                        ButtonManager.gamelogohantei = 1;
                    }
                }
                else if (bx > 0 | cx > 0|ux>0)
                {
                    anmakt.antent = 1;
                    Text loadg = loadgage.GetComponent<Text>();
                    loadg.text = Mathf.Floor((float)(cx + bx + ux) / (float)(cexnum +bexnum +uixnum) * 100) + "％";
                }
            }
            else
            {
                if (bx>0|cx>0|ux>0)
                {
                    loadpanel.SetActive(true);
                    Text loadg = loadgtext.GetComponent<Text>();
                    loadg.text = Mathf.Floor((float)(cx + bx + ux) / (float)(cexnum +bexnum +uixnum) * 100) + "％";
                }
                if(cexnum == cexmnum & bexnum == bexmnum&uixnum == uixmnum)
                {
                    Text loadg = loadgtext.GetComponent<Text>();
                    loadg.text = "100％";
                    loadpanel.SetActive(false);
                }

            }
        }
    }
}
