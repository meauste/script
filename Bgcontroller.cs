using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Threading;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Bgcontroller : MonoBehaviour
{
    public Image Bg;
    private Sprite Bgsp;
    public static int openingflag;
    public float ofadep;
    public int ott;
    public float otm;
    public int texto_num;
    public string[] texto;
    public GameObject textop;
    public static int startflag;
    public static int firstf;
    public int hazimarix;
    public int fadew1;
    public int fadew2;
    public int fadew3;
    public static int hazimarihantei;
    public static int hazimarihanteif;
    public static int hazimarihanteit;
    public int hazimariex;
    public string hazimarinam;
    public static int hazimariehantei;
    public static int hazimariehanteif;
    public static int hazimariehanteit;
    public static int hazimarif;
    public static int hazimaritt;
    public static float hazimaritm;
    public static int hazimarief;
    public static int bgx;
    public int bghantei;
    public int bghanteit;
    public int bgchantei;
    public static int bgcx;
    public static int bgcdx;
    public static int fadex;
    public int bgcdg;
    public int fadeoi;
    public static int fadehantei;
    public int fadehanteit;
    public int fadehanteif;
    public static int fadeoiflag;
    public static int chaphanteit;
    public static int bgcdhantei;
    public static int bgcdhanteit;
    public int bgcdghantei;
    public static int bgchanteit;
    public static float bgcgage;
    public int bgcfflag;
    public int bgswhantei;
    public string bgswnam;
    public string bgswname;
    public int bgswx;
    public float bgfgage;
    public int bglwhantei;
    public string bglwnam;
    public string bglwname;
    public int bglwx;
    public float bgflgage;
    public int chaphantei;
    public int chapthantei;
    public static int chapthanteit;
    public string chaptername;
    public int bgehantei;
    public int bgeflag;
    public int bgefl;
    public int camhantei;
    public Sprite chaptpx;
    public static int chapx;
    public static int chaptx;
    public int bgex;
    public string bgexnam;
    public int bgcflag;
    public static int bgcf;
    public static int chaptf;
    public static int fadef;
    public float fadep;
    public float fadepx;
    public float fadecp;
    public float chrdl;
    public int chrdlf;
    public int f2rlf;
    public static int fadetime;
    public static int bgcdf;
    public int bgcdt;
    public static int bgcdux;
    public static int camf;
    public int chrcgage;
    public float camgage;
    public int serioushantei;
    public static int seriousf;
    public int seriousx;
    public int seriousehantei;
    public int seriousex;
    public int seriousfhantei;
    public static int mwxf;
    public int mwxt;
    public static int bgcmwx;
    public float mwx;
    public string bgname;
    public string bgcname;
    public string bgcdname;
    public string chapname;
    public string chaptname;
    public string chaptlname;
    public string bgename;
    public int text_num;
    public int antenhantei;
    public int antenflag;
    public static int chappx;
    public int kakudaihantei;
    public static int kakudaihanteit;
    public int kakudaiehantei;
    public static int kakudaix;
    public int kakudaiex;
    public static int kakudaiflag;
    public float fadekp;
    public float kakudaitx;
    public float kakudaimx;
    public float kakudaimmx;
    public float kakudaimy;
    public float kakudaimmy;
    public float kakudaimkx;
    public float kakudaimky;
    public AudioClip[] clips;
    public AudioSource audios;
    public AudioClip[] clipes;
    public AudioSource audioes;
    public AudioClip[] clipefs;
    public int[] chaptnum;
    public string chrmsnam;
    public int chrmsx;
    public int chrmshantei;
    public AudioSource audioefs;
    public int audiox;
    public int audioex;
    public int audioefx;
    public int BGMe_frag;
    public int BGMef_frag;
    public int BGM_frag = 0;
    public string BGM_num;
    public string BGMe_num;
    public string BGMef_num;
    public float audiov;
    public float audioev;
    public float audioefv;
    public int videohantei;
    public VideoPlayer video;
    public VideoClip[] vclips;
    public int[] videonum;
    public int videox;
    public float videof;
    public int sentakuhantei;
    public static int sentakuflag;
    public static int sentakuf;
    public static int sentakux;
    public static int endhantei;
    public static int endflag;
    public string[] abgname;
    public int loadflag;
    public int tloadflag;
    public GameObject chapt;
    public GameObject ms;
    public Image msi;
    public Image chi;
    public GameObject chrna;
    public GameObject chrnat;
    public GameObject tex;
    public TextMeshProUGUI text;
    public GameObject nexttext;
    public GameObject chrms;
    public GameObject autogage;
    public GameObject qlh;
    public GameObject qsh;
    public GameObject bgc;
    public GameObject bge;
    public GameObject bgfla;
    public GameObject bgflal;
    public GameObject bgf;
    public GameObject BGl;
    public GameObject chr1;
    public GameObject chr1c;
    public GameObject chr2;
    public GameObject chr2c;
    public GameObject chr3;
    public GameObject chr3c;
    public Texture2D mouse;
    public GameObject bt;
    public GameObject menu;
    public GameObject next;
    public GameObject videop;
    public Vector3 Bglo;
    public GameObject bti;
    public GameObject senpanel1;
    public GameObject senpanel2;
    public Text sentakutext1;
    public Text sentakutext2;
    public float time;
    public float timem;
    public int videoflag;
    public Vector3 chr1l;
    public Vector3 chr2l;
    public Vector3 chr3l;
    public Vector3 bgl;
    textti script;
    dataload script2;
    // Use this for initialization
    void Start()
    {
        time = 0;
        timem = 0;
        // 改行で分割して配列に代入
        loadflag = Load.loadflag;
        chr1l = chr1.transform.position;
        chr2l = chr2.transform.position;
        chr3l = chr3.transform.position;
        bgl = Bg.transform.position;
        bgcgage = 0;
        if (loadflag <= 0)
        {
            bgx = 0;
            chapx = 0;
            openingflag = 0;
            antenhantei = 1;
            anmak.antenflag = 1;
            sentakux = 0;
            if (openingflag == 1)
            {
                nexttext.SetActive(false);
                Image ne = ms.GetComponent<Image>();
                ne.GetComponent<Image>().transform.Translate(0, -3, 0);


                ofadep = 1.8f;
            }


            seriousf = 0;


            BGM_frag = 0;
            BGMe_frag = 0;
            BGMef_frag = 0;
            hazimarif = 0;
            hazimarief = 0;
            hazimaritm = 0;
            chappx = 0;
            chrmsx = 0;
            TextManager.antennum = 0;
            bgx = 0;
            chapx = 0;
            chaptx = 0;
            bgcx = 0;
            bgcdx = 0;
            bgcdux = 0;
            fadex = 0;
            fadep = 1f;
            this.transform.localScale = new Vector3(fadep, fadep, 0);

            BGM_frag = 0;
            BGMe_frag = 0;
            BGMef_frag = 0;
            audios.Stop();
            audioes.Stop();
            audioefs.Stop();
            kakudaix = 0;
            videox = 0;
            bgex = 0;
            bgswx = 0;
            bglwx = 0;
            bgfgage = 0;
            chappx = 0;
            seriousf = 0;
            seriousx = 0;
            seriousex = 0;
            hazimarix = 0;
            hazimariex = 0;
            hazimarief = 0;
            kakudaiflag = 0;
            Bglo = BGl.transform.position;

        }
        bge.SetActive(false);
        bgfla.SetActive(false);
        bgflal.SetActive(false);
        BGl.SetActive(false);
        audiov = textti.audiov;
        audioev = textti.audioev;
        audioefv = textti.audioefv;
        audios.volume = textti.audiov;
        audioes.volume = textti.audioev;
        audioes = GetComponent<AudioSource>();
        audioes.volume = textti.audioefv;
        bgc.SetActive(false);
        bge.SetActive(false);
        bgf.SetActive(false);
        bgfla.SetActive(false);
        bgflal.SetActive(false);
        BGl.SetActive(false);
        videop.SetActive(false);
        chrms.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        script = GameObject.Find("textti").GetComponent<textti>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();

        text_num = TextManager.text_num;
        if (loadflag == 0)
        {
            if (sentakuf == 0&sentakux<script.charth.Length) {  endhantei = script.charth[sentakux]; } else { endhantei = script.textho.Length - 1; }
            if (sentakux < textti.sentakus)
            {
                if (script.sentakuknum[(sentakux)] != "" & script.sentakuknum[(sentakux)] != null)
                {
                    sentakuflag = script.sentakutypes[sentakux];
                }
                else
                {
                    sentakuflag = 0;
                }
            }
            else
            {
                sentakuflag = 0;
            }

            if (sentakuf == 0 & endhantei < text_num)
            {
                if (sentakuflag == 0)
                {
                    TextManager.text_num -= 1;
                    TextManager.antenhantei = 1;
                    endflag = 1;
                }
                else
                {
                    int icx = script.textho.Length + 1;
                    System.Array.Resize(ref script.textho, icx);
                    System.Array.Resize(ref script.name, icx);
                    System.Array.Resize(ref script.color, icx);
                    System.Array.Resize(ref script.ocolor, icx);
                    script.textho[script.textho.Length - 1] = "選択肢";
                    script.name[script.textho.Length - 1] = "選択肢";
                    script.color[script.textho.Length - 1] = "選択肢";
                    script.ocolor[script.textho.Length - 1] = "選択肢";
                    script.ReloadD1();
                    script.ReloadD2();
                    mwxf = -1;
                    endhantei = 99999;
                    sentakuf = 1;
                    if (TextManager.antenhantei == 0)
                    {
                        sound.soundflag = 5;
                    }
                }
            }
            if (sentakuf == 1)
            {
                Image bgcdms = ms.GetComponent<Image>();
                bgcdms.GetComponent<Image>().color = new Color(255, 255, 255, 0);
                ms.SetActive(false);
                senpanel1.SetActive(true);
                senpanel2.SetActive(true);
                Image bgcdbc = senpanel1.GetComponent<Image>();
                bgcdbc.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image bgcdbc2 = senpanel2.GetComponent<Image>();
                bgcdbc2.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                sentakutext1.text = script.sentakubnum[2 * (sentakux)];
                sentakutext2.text = script.sentakubnum[2 * (sentakux)+1];
                mwxf = 0;
            }
            else if (sentakuf >= 2)
            {
                int icx = script.textho.Length - 1;
                endhantei = script.charth[textti.six];
                sentaku();
                textti.six += 1;
                mwxf = 1;
                sentakuf = 0;
            }
            else
            {
                senpanel1.SetActive(false);
                senpanel2.SetActive(false);
            }
        }
        if (loadflag == 0)
        {
            if (hazimarix < textti.hazimaris) { hazimarihantei = script.hazimarihantei[hazimarix]; } else { hazimarihantei = 99999; }
            if (textti.hazimaris > 0) { hazimarihanteif = script.hazimarihantei[0]; } else { hazimarihantei = 99999; }
            if (hazimariex < textti.hazimaris) { hazimariehantei = script.hazimarihantei[hazimariex]; } else { hazimariehantei = 99999; }
            if (hazimariex > 0) { hazimariehanteif = script.hazimarihantei[0]; } else { hazimarihanteif = 99999; }
            if (bgcx < textti.bgcs) { bgchantei = script.bgchantei[bgcx]; } else { bgchantei = 99999; }
            if (BGM_frag < textti.bgms) { audiox = script.bgmhantei[BGM_frag]; BGM_num = script.bgmnum[BGM_frag]; } else { audiox = 99999; }
            if (BGMe_frag < textti.bgmes) { audioex = script.bgmehantei[BGMe_frag]; BGMe_num = script.bgmenum[BGMe_frag]; } else { audioex = 99999; }
            if (BGMef_frag < textti.bgmefs) { audioefx = script.bgmefhantei[BGMef_frag]; BGMef_num = script.bgmefnum[BGMef_frag]; } else { audioefx = 99999; }
            if (bgcdx < textti.bgcds) { bgcdhantei = script.bgcdhantei[bgcdx]; } else { bgcdhantei = 99999; }
            if (chaptx < textti.chapts) { chapthantei = script.chapthantei[chaptx]; } else { chapthantei = 99999; }
            if (videox < textti.videos) { videohantei = script.videohantei[videox]; } else { videohantei = 99999; }
            if (script.aehantei[1] == 1 & fadex < textti.chrcs) { fadehantei = script.fadehantei[fadex]; } else { fadehantei = 99999; }
            fadehanteif = -2;
            if (chapx < textti.chaps) { chaphantei = script.chaphantei[chapx]; } else { chaphantei = 99999; };
            if (bgex < textti.bges) { bgehantei = script.bgehantei[bgex]; } else { bgehantei = 99999; }
            if (bgswx < textti.bgsws) { bgswhantei = script.bgswhantei[bgswx]; } else { bgswhantei = 99999; }
            if (bglwx < textti.bglws) { bglwhantei = script.bglwhantei[bglwx]; } else { bglwhantei = 99999; }
            chrmshantei = 99999;
            if (seriousx < textti.seriouss) { serioushantei = script.serioushantei[seriousx]; } else { serioushantei = 99999; }
            if (seriousx > 0) { seriousfhantei = script.serioushantei[0]; } else { seriousfhantei = 99999; }
            if (seriousex < textti.seriouss) { seriousehantei = script.serioushantei[seriousex]; } else { seriousehantei = 99999; }
            if (kakudaix < textti.kakudais) { kakudaihantei = script.kakudaihantei[kakudaix]; } else { kakudaihantei = 99999; }
        }
        kakudaiehantei = 9999;
        antenhantei = TextManager.antenhantei;
        loadflag = Load.loadflag;
        if (loadflag >= 2 & loadflag < 3)
        {
            TextManager.antennum = 0;
            bgx = 0;
            chapx = 0;
            chaptx = 0;
            bgcx = 0;
            bgcdx = 0;
            bgcdux = 0;
            bge.SetActive(false);
            bgfla.SetActive(false);
            bgflal.SetActive(false);
            BGl.SetActive(false);
            BGM_frag = 0;
            BGMe_frag = 0;
            BGMef_frag = 0;
            audios.Stop();
            audioes.Stop();
            audioefs.Stop();
            kakudaix = 0;
            videox = 0;
            bgex = 0;
            bgswx = 0;
            bglwx = 0;
            bgfgage = 0;
            chappx = 0;
            seriousf = 0;
            seriousx = 0;
            seriousex = 0;
            hazimarix = 0;
            hazimariex = 0;
            hazimarief = 0;
            kakudaiflag = 0;
            endhantei = script.textho.Length-1;
            sentakuf=0;
            BGl.transform.position = Bglo;
            if (tloadflag >= 1)
            {
                hazimarif = 0;
            }
            data();
        }
        if (loadflag == 3 & anmak.loadtime < 60)
        {
            if (textti.hazimaris > 0) { hazimarihanteif = script.hazimarihantei[0]; }
            if (textti.hazimaris > 0) { hazimariehanteif = script.hazimarihantei[0]; }
            if (hazimarix < textti.hazimaris) { hazimarihantei = script.hazimarihantei[hazimarix]; } else { hazimarihantei = 99999; }
            if (textti.hazimaris > 0) { hazimarihanteif = script.hazimarihantei[0]; } else { hazimarihantei = 99999; }
            if (hazimariex < textti.hazimaris) { hazimariehantei = script.hazimarihantei[hazimariex]; } else { hazimariehantei = 99999; }
            if (hazimariex > 0) { hazimariehanteif = script.hazimarihantei[0]; } else { hazimarihanteif = 99999; }
            if (bgcx < textti.bgcs) { bgchantei = script.bgchantei[bgcx]; } else { bgchantei = 99999; }
            if (BGM_frag < textti.bgms) { audiox = script.bgmhantei[BGM_frag]; BGM_num = script.bgmnum[BGM_frag]; } else { audiox = 99999; }
            if (BGMe_frag < textti.bgmes) { audioex = script.bgmehantei[BGMe_frag]; BGMe_num = script.bgmenum[BGMe_frag]; } else { audioex = 99999; }
            if (BGMef_frag < textti.bgmefs) { audioefx = script.bgmefhantei[BGMef_frag]; BGMef_num = script.bgmefnum[BGMef_frag]; } else { audioefx = 99999; }
            if (bgcdx < textti.bgcds) { bgcdhantei = script.bgcdhantei[bgcdx]; } else { bgcdhantei = 99999; }
            if (chaptx < textti.chapts) { chapthantei = script.chapthantei[chaptx]; } else { chapthantei = 99999; }
            if (videox < textti.videos) { videohantei = script.videohantei[videox]; } else { videohantei = 99999; }
            if (script.aehantei[1] == 1 & fadex < textti.chrcs) { fadehantei = script.fadehantei[fadex]; } else { fadehantei = 99999; }
            fadehanteif = -2;
            if (chapx < textti.chaps) { chaphantei = script.chaphantei[chapx]; } else { chaphantei = 99999; };
            if (bgex < textti.bges) { bgehantei = script.bgehantei[bgex]; } else { bgehantei = 99999; }
            if (bgswx < textti.bgsws) { bgswhantei = script.bgswhantei[bgswx]; } else { bgswhantei = 99999; }
            if (bglwx < textti.bglws) { bglwhantei = script.bglwhantei[bglwx]; } else { bglwhantei = 99999; }
            chrmshantei = 99999;
            if (seriousx < textti.seriouss) { serioushantei = script.serioushantei[seriousx]; } else { serioushantei = 99999; }
            if (seriousx > 0) { seriousfhantei = script.serioushantei[0]; } else { seriousfhantei = 99999; }
            if (seriousex < textti.seriouss) { seriousehantei = script.serioushantei[seriousex]; } else { seriousehantei = 99999; }
            if (kakudaix < textti.kakudais) { kakudaihantei = script.kakudaihantei[kakudaix]; } else { kakudaihantei = 99999; }
            fadehanteif = -2;
            if (text_num >= chrmshantei)
            {

                chrmsnam = (script.Bgccon[chrmsx].Substring(245, 1));
                if (chrmsnam != "")
                {
                    chrms.SetActive(true);
                    Image chap = chrms.GetComponent<Image>();
                    chap.sprite = Resources.Load<Sprite>(("Bg/" + script.Bgccon[chrmsx].Substring(245, 6)));
                }
                else
                {
                    chrms.SetActive(false);
                }
                chrmsx += 1;
            }
            if (text_num < fadehanteif)
            {
                this.transform.localScale = new Vector3(1, 1, 0);
                if (chrdlf <= -1)
                {
                    chrdlf = 0;
                    chr1.transform.position = chr1l;
                    chr2.transform.position = chr2l;
                    chr3.transform.position = chr3l;
                    Bg.transform.position = bgl;
                }
                if (chrdlf >= 1)
                {
                    chrdlf = 0;
                    chr1.transform.position = chr1l;
                    chr2.transform.position = chr2l;
                    chr3.transform.position = chr3l;
                    Bg.transform.position = bgl;
                }
            }

            if (text_num >= fadehantei)
            {

                fadeoiflag = script.fadeoiflag[fadex];
                fadew3 = 1;
                fadew2 = 0;
                fadew1 = 0;
                fadex += 1;

                if (chrdlf <= -1)
                {
                    this.GetComponent<Image>().transform.Translate(1, 0, 0);
                    chrdlf = 0;
                    chr1.transform.position = chr1l;
                    chr2.transform.position = chr2l;
                    chr3.transform.position = chr3l;
                    Bg.transform.position = bgl;
                }
                if (chrdlf >= 1)
                {
                    this.GetComponent<Image>().transform.Translate(-1, 0, 0);
                    chrdlf = 0;
                    chr1.transform.position = chr1l;
                    chr2.transform.position = chr2l;
                    chr3.transform.position = chr3l;
                    Bg.transform.position = bgl;
                }
                fadep = 1f;

                Image bgcid = bgc.GetComponent<Image>();
                bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                if (fadew3 == 3 | fadew3 == 4 | fadew3 == 5)
                {
                    fadep = 1.278f;


                    if (fadeoiflag == 25)
                    {
                        this.GetComponent<Image>().transform.Translate(-2.17f, 0, 0);
                        chrdlf = -1;
                    }
                    if (fadeoiflag == 24)
                    {
                        this.GetComponent<Image>().transform.Translate(2.17f, 0, 0);
                        chrdlf = 1;

                    }
                    if (fadeoiflag == 54)
                    {
                        this.GetComponent<Image>().transform.Translate(2.17f, 0, 0);
                        chrdlf = 1;
                    }
                    if (fadeoiflag == 45)
                    {
                        this.GetComponent<Image>().transform.Translate(-2.17f, 0, 0);
                        chrdlf = -1;
                    }
                }
                if (fadew3 == 2)
                {
                    fadep = 1.179f;
                }

                if (fadew3 == 1 | fadew3 == 7 | fadew3 == 8)
                {
                    fadep = 1.079f;
                    if (fadeoiflag == 78)
                    {
                        this.GetComponent<Image>().transform.Translate(1, 0, 0);
                        chrdlf = -1;
                    }
                    if (fadeoiflag == 87)
                    {
                        this.GetComponent<Image>().transform.Translate(1, 0, 0);
                        chrdlf = 1;
                    }
                }

                this.transform.localScale = new Vector3(fadep, fadep, 0);
                bgc.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra2 = chr2.GetComponent<Image>();
                chra2.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3 = chr3.GetComponent<Image>();
                chra3.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1c = chr1c.GetComponent<Image>();
                chra1c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra2c = chr2c.GetComponent<Image>();
                chra2c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3c = chr3c.GetComponent<Image>();
                chra3c.transform.localScale = new Vector3(fadep, fadep, 0);

                mwxf = 1;
                fadeoiflag = 0;

            }
            if (text_num <= hazimarihanteif)
            {



                if (hazimarif >= 1)
                {
                    ms.SetActive(true);

                    Image msw = ms.GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, 3, 0);
                    Image ne = tex.GetComponent<Image>();
                    ne.GetComponent<Image>().transform.Translate(0, -6, 0);
                    Image nex = nexttext.GetComponent<Image>();
                    nex.GetComponent<Image>().transform.Translate(0, -6, 0);
                    hazimarif = 0;
                }
                mwxf = 1;







            }
            if (text_num >= kakudaihantei)
            {
                kakudaix += 1;
            }
            if (text_num >= hazimarihantei)
            {
                hazimarix += 1;
                nexttext.SetActive(true);
                ms.SetActive(true);


                if (hazimarif <= 0 & hazimariehantei >= text_num)
                {


                    ms.SetActive(true);

                    Image msw = ms.GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, -3, 0);
                    Image ne = tex.GetComponent<Image>();
                    ne.GetComponent<Image>().transform.Translate(0, 6, 0);
                    Image nex = nexttext.GetComponent<Image>();
                    nex.GetComponent<Image>().transform.Translate(0, 6, 0);

                    hazimarif = 1;
                }




            }
            if (text_num >= hazimariehantei)
            {

                hazimariex += 1;

                if (hazimarif > 0)
                {
                    Image msw = ms.GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, 3, 0);
                    Image ne = tex.GetComponent<Image>();
                    ne.GetComponent<Image>().transform.Translate(0, -6, 0);
                    Image nex = nexttext.GetComponent<Image>();
                    nex.GetComponent<Image>().transform.Translate(0, -6, 0);


                    hazimarif = 0;
                    mwxf = 1;
                }
            }

            if (text_num >= chaphantei)
            {
                chapx += 1;
            }

            if (text_num >= bgehantei)
            {

                bgexnam = script.bgenum[bgex];
                if (bgexnam != "")
                {
                    bge.SetActive(true);
                    Image chap = bge.GetComponent<Image>();
                    chap.sprite = script2.bgs[script.bgenum[bgex]];
                }
                else
                {
                    bge.SetActive(false);
                }
                bgex += 1;
            }
            if (text_num >= bgswhantei)
            {

                bgswnam = script.bgswnum[bgswx];
                if (bgswnam != "")
                {
                    bgfla.SetActive(true);
                    Image sw = bgfla.GetComponent<Image>();
                    sw.sprite =script2.bgs[script.bgswnum[bgswx]];
                    Image bgf = bgfla.GetComponent<Image>();
                    bgf.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                    bgfgage = 1;
                }
                else
                {
                    bgfla.SetActive(false);
                    bgfgage = 0;
                }
                bgswx += 1;
            }
            if (text_num >= bglwhantei)
            {

                bglwnam = script.bglwnum[bglwx];
                if (bglwnam != "")
                {
                    bgflal.SetActive(true);
                    Image lw = bgflal.GetComponent<Image>();
                    lw.sprite = script2.bgs[script.bglwnum[bglwx]];
                    Image bgfl = bgflal.GetComponent<Image>();
                    bgfl.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                    bgflgage = 1;
                }
                else
                {
                    bgflal.SetActive(false);
                    bgflgage = 0;
                }
                bglwx += 1;
            }
            if (text_num >= bgchantei)
            {
                bgcx += 1;
            }
            if (text_num >= bgcdhantei)
            {
                bgcdghantei = script.bgcdg[bgcdx];
                bgcdux = bgcdux + bgcdghantei;
                bgcdx += 1;
            }
            if (text_num >= chapthantei)
            {
                chaptx += 1;
            }
            if (bgcx >= 1)
            {
                bgchanteit = script.bgchantei[bgcx-1];
            }
            else
            {
                bgchanteit = -2;
            }
            if (bgcdx >= 1)
            {
                bgcdhanteit = script.bgcdhantei[bgcdx-1];
            }
            else
            {
                bgcdhanteit = -2;
            }
            if (chaptx >= 1)
            {
                chapthanteit = script.chapthantei[chaptx-1];
            }
            else
            {
                chapthanteit = -2;
            }
            if (hazimarix >= 1)
            {
                hazimarihanteit = script.hazimarihantei[hazimarix-1];
            }
            else
            {
                hazimarihanteit = -2;
            }
            if (hazimariex >= 1)
            {
                hazimariehanteit = script.hazimarihantei[hazimariex-1];
            }
            else
            {
                hazimariehanteit = -2;
            }
            if (fadex >= 1)
            {
                fadehanteit = script.fadehantei[fadex - 1];
            }
            else
            {
                fadehanteit = -2;
            }
            if (kakudaix >= 1)
            {
                kakudaihanteit = script.kakudaihantei[kakudaix-1];
            }
            else
            {
                kakudaihanteit = -2;
            }
            if (chapx >= 1)
            {
                chaphanteit = script.chaphantei[chapx-1];
            }
            else
            {
                chaphanteit = -2;
            }

            if (text_num >= audiox)
            {
                audios.Stop();
                WWW bgmeu = new WWW(script.bgmnum[BGM_frag]);
                audios.clip = bgmeu.GetAudioClip(true, true);
                audios.Play();
                BGM_frag += 1;
            }
            if (text_num >= audioex)
            {
                audioes.Stop();
                WWW bgmeu = new WWW(script.bgmenum[BGMe_frag]);
                audioes.clip = bgmeu.GetAudioClip(true, true);
                audioes.Play();
                BGMe_frag += 1;
            }
            if (text_num >= audioefx)
            {
                audioefs.Stop();

                BGMef_frag += 1;
            }
            if (text_num >= videohantei)
            {
                videox += 1;

            }
            if (text_num <= seriousfhantei)
            {
                seriousf = 0;
                if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
            }
            if (text_num >= serioushantei)
            {
                seriousf = 1;
                ms.SetActive(true);
                Image bgcdbfas = ms.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Image bgcdbfcs = chrna.GetComponent<Image>();
                bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                ms.SetActive(false);
                seriousx += 1;
            }
            if (text_num >= seriousehantei)
            {
                seriousf = 0;
                ms.SetActive(true);
                if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
                seriousex += 1;
                ms.SetActive(false);
            }
            if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit & chapthanteit > hazimarihanteit & chapthanteit >= chaphanteit)
            {

                Bgsp = script2.bgs[script.chaptnum[1+2*(chaptx-1)]];
                if (fadep > 1.05f & fadep < 1.29f)
                {
                    Bgsp = script2.bgs[script.chaptnum[1 + 2 * (chaptx - 1)]];
                }
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                if (chapthanteit >fadehanteit)
                {
                    Bg = this.GetComponent<Image>();
                    Bg.transform.localScale = new Vector3(1, 1, 0);
                    Bgsp = script2.bgs[script.chaptnum[1+2*(chaptx-1)]];
                    Bg = this.GetComponent<Image>();
                    Bg.sprite = Bgsp;
                    Image bgcid = bgc.GetComponent<Image>();
                    bgcid.sprite = Bgsp;
                    if (chrdlf <= -1)
                    {
                        this.GetComponent<Image>().transform.Translate(1, 0, 0);
                        chrdlf = 0;
                    }
                    if (chrdlf >= 1)
                    {
                        this.GetComponent<Image>().transform.Translate(-1, 0, 0);
                        chrdlf = 0;
                    }
                }

            }
            if (bgcdhanteit > bgchanteit & bgcdhanteit >= chapthanteit & bgcdhanteit > hazimarihanteit & bgcdhanteit > kakudaihanteit & bgcdhanteit >= chaphanteit)
            {
                Bgsp = script2.bgs[script.bgcdnum[bgcdux-1]];
                if (fadep > 1.05f & fadep < 1.29f)
                {
                    Bgsp =script2.bgs[script.bgcdnum[bgcdux-1]];
                }
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                Image bgcid = bgc.GetComponent<Image>();
                bgcid.sprite = Bgsp;
                if (bgcdhanteit >fadehanteit)
                {
                    Bg = this.GetComponent<Image>();
                    Bg.transform.localScale = new Vector3(1, 1, 0);
                    Bgsp = script2.bgs[script.bgcdnum[bgcdux-1]];
                    Bg = this.GetComponent<Image>();
                    if (chrdlf <= -1)
                    {
                        this.GetComponent<Image>().transform.Translate(1, 0, 0);
                        chrdlf = 0;
                    }
                    if (chrdlf >= 1)
                    {
                        this.GetComponent<Image>().transform.Translate(-1, 0, 0);
                        chrdlf = 0;
                    }
                    Bg.sprite = Bgsp;
                }
            }
            if (bgchanteit > bgcdhanteit & bgchanteit > chapthanteit & bgchanteit > hazimarihanteit & bgchanteit > kakudaihanteit & bgchanteit >= chaphanteit)
            {
               Bgsp=script2.bgs[script.bgcnum[bgcx-1]];
                if (fadep > 1.05f & fadep < 1.29f)
                {
                    Bgsp = script2.bgs[script.bgcnum[bgcx-1]];
                }
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                Image bgcid = bgc.GetComponent<Image>();
                bgcid.sprite = Bgsp;
                if (bgchanteit >fadehanteit)
                {
                    Bg = this.GetComponent<Image>();
                    Bg.transform.localScale = new Vector3(1, 1, 0);
                   Bgsp=script2.bgs[script.bgcnum[bgcx-1]];
                    Bg = this.GetComponent<Image>();
                    if (chrdlf <= -1)
                    {
                        this.GetComponent<Image>().transform.Translate(1, 0, 0);
                        chrdlf = 0;
                    }
                    if (chrdlf >= 1)
                    {
                        this.GetComponent<Image>().transform.Translate(-1, 0, 0);
                        chrdlf = 0;
                    }
                    Bg.sprite = Bgsp;
                }


            }
            if (kakudaihanteit > chaphanteit & kakudaihanteit > hazimarihanteit & kakudaihanteit > bgchanteit & kakudaihanteit > bgcdhanteit & kakudaihanteit > chaphanteit)
            {

                BGl.transform.position = Bglo;
                Image chra2t = BGl.GetComponent<Image>();
                chra2t.sprite = script2.bgs[script.kakudainum[kakudaix-1]];



                kakudaiflag = int.Parse(script.kakudaisy[script.kakudaitypes[kakudaix-1]]);
                kakudaihantei = script.kakudaihantei[kakudaix-1];
                BGl.SetActive(true);
                if (kakudaiflag == 1)
                {
                    fadekp = 1.18f;

                }
                if (kakudaiflag == 2 | kakudaiflag == 3)
                {
                    fadekp = 1.3f;
                }
                if (kakudaiflag >= 4)
                {
                    fadekp = 1.5f;
                }
                Image chra1 = BGl.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(fadekp, fadekp, 0);
                kakudaimmx = 2.5f;
                kakudaimx = 0.003f;
                kakudaimmy = 2.5f;
                kakudaimy = 0.003f;
                kakudaimkx = 0;
                kakudaimky = 0;
                if (kakudaiflag == 2)
                {
                    Image bgcu = BGl.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(-kakudaimmx, 0, 0);
                }
                if (kakudaiflag == 3)
                {
                    Image bgcu = BGl.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(kakudaimmx, 0, 0);
                }
                if (kakudaiflag == 4)
                {
                    Image bgcu = BGl.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, -kakudaimmy, 0);
                }
                if (kakudaiflag == 5)
                {
                    Image bgcu = BGl.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, kakudaimmy, 0);
                }
                kakudaitx = 2;
            }
            else
            {
                BGl.SetActive(false);
            }
            if (bgchanteit >fadehanteit | bgcdhanteit >fadehanteit | chapthanteit >fadehanteit | kakudaihanteit >fadehanteit | hazimarihanteit >fadehanteit)
            {
                fadep = 1f;
                this.transform.localScale = new Vector3(fadep, fadep, 0);
                bgc.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(1, 1, 0);

                Image chra2 = chr2.GetComponent<Image>();
                chra2.transform.localScale = new Vector3(1, 1, 0);
                Image chra3 = chr3.GetComponent<Image>();
                chra3.transform.localScale = new Vector3(1, 1, 0);
                Image chra1c = chr1c.GetComponent<Image>();
                chra1c.transform.localScale = new Vector3(1, 1, 0);

                Image chra2c = chr2c.GetComponent<Image>();
                chra2c.transform.localScale = new Vector3(1, 1, 0);
                Image chra3c = chr3c.GetComponent<Image>();
                chra3c.transform.localScale = new Vector3(1, 1, 0);
            }
            if (hazimarihanteit > bgcdhanteit & hazimarihanteit > bgchanteit & hazimarihanteit > chapthanteit & hazimarihanteit > chaphanteit & hazimarihanteit > kakudaihanteit)
            {
                Bgsp = script2.bgs[script.hazimarinum[hazimarix - 1]];
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                Bg.transform.localScale = new Vector3(1, 1, 0);


            }



            if (hazimarief <= 0)
            {
                mwxf = 1;
            }

        }
        //ロード終了
        if (openingflag == 1)
        {

            ofadep = 1f;
            Bgsp = Resources.Load<Sprite>("evening1");
            Bg = this.GetComponent<Image>();
            Bg.sprite = Bgsp;
            openingflag = 2;
            ott = 1;
            otm = 0;
        }
        if (openingflag == 2)
        {
            if (texto_num <= 7 & Input.GetKey(KeyCode.J))
            {
                texto_num += 1;
                ott = 2;


            }
            ofadep += 0.0003f;
            Bg.transform.localScale = new Vector3(ofadep, ofadep, 0);

            if (antenhantei <= 0 & ott == 1)
            {
                Text teo = textop.GetComponent<Text>();
                teo.GetComponent<Text>().color = new Color(255, 255, 255, otm);
                Text teot = textop.GetComponent<Text>();
                teot.text = texto[texto_num];
                otm += 0.007f;

                if (otm >= 1)
                {

                    teo.GetComponent<Text>().color = new Color(255, 255, 255, 1);
                    ott = 2;
                    otm = 1.8f;
                }
            }
            if (ott == 2)
            {
                Text teo = textop.GetComponent<Text>();
                teo.GetComponent<Text>().color = new Color(255, 255, 255, otm);
                Text teot = textop.GetComponent<Text>();
                teot.text = texto[texto_num];
                otm -= 0.007f;
                if (otm <= 0)
                {
                    texto_num += 1;
                    ott = 1;
                    otm = -0.5f;
                    teo.GetComponent<Text>().color = new Color(255, 255, 255, 0);
                }
            }
            if (texto_num == 7)
            {
                Text teo = textop.GetComponent<Text>();
                teo.GetComponent<Text>().color = new Color(255, 255, 255, 0);
                openingflag = 3;

                TextManager.antenhantei = 1;

                Image ne = ms.GetComponent<Image>();
                ne.GetComponent<Image>().transform.Translate(0, 3, 0);


            }


        }
        if (loadflag <= 0 & text_num >= chrmshantei)
        {

            chrmsnam = (script.Bgccon[chrmsx].Substring(245, 1));
            if (chrmsnam != "")
            {
                chrms.SetActive(true);
                Image chap = chrms.GetComponent<Image>();
                chap.sprite = Resources.Load<Sprite>(("Bg/" + script.Bgccon[chrmsx].Substring(245, 6)));
            }
            else
            {
                chrms.SetActive(false);
            }
            chrmsx += 1;
        }
        if (loadflag <= 0 & text_num >= chaphantei)
        {

            qlh.SetActive(false);
            qsh.SetActive(false);


            startflag = 1;

            anmak.antenflag = int.Parse(script.chapsy[script.chaptypes[chapx]]);


            TextManager.antenhantei = 1;
            chapx += 1;

        }
        if (loadflag <= 0 & startflag >= 1 & anmak.antenflag > 100)
        {

            BGl.SetActive(false);
            startflag = 0;
            chapt.SetActive(false);
            if (bgcx >= 1)
            {
                bgchanteit = script.bgchantei[bgcx-1];
            }
            else
            {
                bgchanteit = -2;
            }
            if (bgcdx >= 1)
            {
                bgcdhanteit = script.bgcdhantei[bgcdx-1];
            }
            else
            {
                bgcdhanteit = -2;
            }
            if (chaptx >= 1)
            {
                chapthanteit = script.chapthantei[chaptx-1];
            }
            else
            {
                chapthanteit = -2;
            }
            if (chapx >= 1)
            {
                chaphanteit = 99999;
            }
            else
            {
                chaphanteit = -2;
            }
            if (chaphanteit != bgchanteit & chaphanteit != bgcdhanteit & chaphanteit != chapthanteit)
            {
                Image chra1 = Bg.GetComponent<Image>();
                chra1.sprite = script2.bgs[script.chaptnum[chappx]];
                chappx += 1;
            }
            else
            {
                fadep = 1f;
                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1c = chr1c.GetComponent<Image>();
                chra1c.transform.localScale = new Vector3(fadep, fadep, 0);


                Image chra2cc = chr2.GetComponent<Image>();
                chra2cc.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3cc = chr3.GetComponent<Image>();
                chra3cc.transform.localScale = new Vector3(fadep, fadep, 0);

                Image chra2c = chr2c.GetComponent<Image>();
                chra2c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3c = chr3c.GetComponent<Image>();
                chra3c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image bgcidb = Bg.GetComponent<Image>();
                bgcidb.transform.localScale = new Vector3(fadep, fadep, 0);
                chr1.SetActive(false);
                chr2.SetActive(false);
                chr3.SetActive(false);
                chr1c.SetActive(false);
                chr2c.SetActive(false);
                chr3c.SetActive(false);
            }


        }
        if (kakudaix < textti.kakudais) { kakudaihantei = script.kakudaihantei[kakudaix]; } else { kakudaihantei = 99999; }
        if (loadflag <= 0 & text_num >= kakudaihantei)
        {

            chr1.SetActive(false);
            chr2.SetActive(false);
            chr3.SetActive(false);
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);
            kakudaitx = 0;

            ms.SetActive(false);
            BGl.transform.position = Bglo;
            kakudaiflag = int.Parse(script.kakudaisy[script.kakudaitypes[kakudaix]]);
            BGl.SetActive(true);
            if (kakudaiflag == 1)
            {
                fadekp = 1.18f;

            }
            if (kakudaiflag == 2 | kakudaiflag == 3)
            {
                fadekp = 1.3f;
            }
            if (kakudaiflag >= 4)
            {
                fadekp = 1.5f;
            }
            Image chra1 = BGl.GetComponent<Image>();
            chra1.transform.localScale = new Vector3(fadekp, fadekp, 0);
            Image annmak = BGl.GetComponent<Image>();
            annmak.GetComponent<Image>().color = new Color(255, 255, 255, 0);

            BGl.transform.position = Bglo;
            kakudaimkx = 0;
            kakudaimky = 0;
            kakudaiflag = int.Parse(script.kakudaisy[script.kakudaitypes[kakudaix]]);
            kakudaimmx = 2.5f;
            kakudaimx = 0.003f;
            kakudaimmy = 2.5f;
            kakudaimy = 0.003f;

            if (kakudaiflag == 2)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-kakudaimmx, 0, 0);
            }
            if (kakudaiflag == 3)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(kakudaimmx, 0, 0);
            }
            if (kakudaiflag == 4)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, -kakudaimmy, 0);
            }
            if (kakudaiflag == 5)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, kakudaimmy, 0);
            }
            Image chra2t = BGl.GetComponent<Image>();
            chra2t.sprite = script2.bgs[script.kakudainum[kakudaix]];

            kakudaix += 1;

        }
        if (kakudaiflag >= 1 & kakudaitx <= 1)
        {

            Image annmak = BGl.GetComponent<Image>();
            annmak.GetComponent<Image>().color = new Color(255, 255, 255, kakudaitx);
            kakudaitx += 0.01f;
        }
        if (kakudaiflag >= 1 & kakudaitx >= 1 & kakudaitx < 2)
        {
            Image annmak = BGl.GetComponent<Image>();
            annmak.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            kakudaitx = 2;
            if (antenhantei == 0)
            {
                mwxf = 1;
            }
            if (kakudaiflag == 1)
            {
                chr1.SetActive(true);
                chr1c.SetActive(true);
                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(1.18f, 1.18f, 0);
                Image chra2 = chr1c.GetComponent<Image>();
                chra2.transform.localScale = new Vector3(1.18f, 1.18f, 0);
                fadekp = 1;

            }
        }
        if (antenhantei == 0 & loadflag <= 0 & kakudaiflag >= 1 & kakudaitx == 2)
        {


            if (kakudaiflag == 1)
            {
                kakudaiflag = 0;
            }
            if (kakudaiflag == 2 & kakudaimkx < 2 * kakudaimmx)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(kakudaimx, 0, 0);
                kakudaimkx += kakudaimx;
            }
            if (kakudaiflag == 2 & kakudaimkx >= 2 * kakudaimmx)
            {

                kakudaiflag = 0;
                kakudaimkx = 0;
            }
            if (kakudaiflag == 3 & kakudaimkx < 2 * kakudaimmx)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-kakudaimx, 0, 0);
                kakudaimkx += kakudaimx;
            }
            if (kakudaiflag == 3 & kakudaimkx >= 2 * kakudaimmx)
            {

                kakudaiflag = 0;
                kakudaimkx = 0;
            }
            if (kakudaiflag == 4 & kakudaimky < 2 * kakudaimmy)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, kakudaimy, 0);
                kakudaimky += kakudaimy;
            }
            if (kakudaiflag == 4 & kakudaimky >= 2 * kakudaimmy)
            {

                kakudaiflag = 0;
                kakudaimky = 0;
                kakudaimky += kakudaimy;
            }
            if (kakudaiflag == 5 & kakudaimky < 2 * kakudaimmy)
            {
                Image bgcu = BGl.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, -kakudaimy, 0);
                kakudaimky += kakudaimy;
            }
            if (kakudaiflag == 5 & kakudaimky >= 2 * kakudaimmy)
            {

                kakudaiflag = 0;
                kakudaimky = 0;
            }
        }


        if (loadflag <= 0 & text_num >= bgchantei)
        {
            ms.SetActive(false);
            nexttext.SetActive(false);
            bgcf = 1;
        }
        if (loadflag <= 0 & text_num >= chapthantei)
        {


            ms.SetActive(false);
            nexttext.SetActive(false);
            chaptf = 1;
        }
        if (loadflag <= 0 & chaptf <= 0 & text_num >= bgcdhantei)
        {


            ms.SetActive(false);
            nexttext.SetActive(false);
            bgcdghantei = script.bgcdg[bgcdx];
            bgcdf = 1;
        }
        if (loadflag <= 0 & text_num >= audiox)
        {
            if (BGM_frag >= 1 & audiov > 0)
            {
                WWW bgmu = new WWW(script.bgmnum[BGM_frag-1]);
                audios.clip = bgmu.GetAudioClip(true, true);
                audiov -= 0.03f * textti.audiov;
                audios.volume = audiov;
            }
            if (BGM_frag < 1)
            {
                WWW bgmu = new WWW(script.bgmnum[BGM_frag]);
                audios.clip = bgmu.GetAudioClip(true, true);
                audios.Play();
                BGM_frag += 1;
            }
            if (bgcdf <= 0 & fadef <= 0 & chaptf <= 0 & audiov <= 0 & (anmak.antenflag == 0 | anmak.antenflag > 100) & anmak.antenxt == 0)
            {
                audios.volume = textti.audiov;
                WWW bgmu = new WWW(script.bgmnum[BGM_frag]);
                audios.clip = bgmu.GetAudioClip(true, true);
                audios.Play();
                BGM_frag += 1;
            }
        }
        if (loadflag <= 0 & text_num >= audioex)
        {
            if (BGMe_frag >= 1)
            {
                WWW bgmeu = new WWW(script.bgmenum[BGMe_frag - 1]);
                audioes.clip = bgmeu.GetAudioClip(true, true);
                audioev -= 0.03f * textti.audioev;
                audioes.volume = audioev;
            }
            if (bgcdf <= 0 & chaptf <= 0 & audioev <= 0 | audioev <= 0 & bgcdf >= bgcdghantei & (anmak.antenflag == 0 | anmak.antenflag > 100) & anmak.antenxt == 0 & audiov <= 0 | audioev <= 0 & chaptf >= 4)
            {
                audioes.volume = textti.audioev;
                WWW bgmeu = new WWW(script.bgmenum[BGMe_frag - 1]);
                audioes.clip = bgmeu.GetAudioClip(true, true);
                audioes.Play();
                BGMe_frag += 1;
            }
            if (bgcdf <= 0 & chaptf <= 0 & BGMe_frag < 1 | BGMe_frag < 1 & bgcdf >= bgcdghantei | BGMe_frag < 1 & chaptf >= 4)
            {
                WWW bgmeu = new WWW(script.bgmenum[BGMe_frag]);
                audioes.clip = bgmeu.GetAudioClip(true, true);
                audioes.Play();
                BGMe_frag += 1;
            }
        }

        if (loadflag <= 0 & text_num >= audioefx)
        {
            if (BGMef_frag >= 1)
            {
                WWW bgmefu = new WWW(script.bgmefnum[BGMef_frag - 1]);
                audioefs.clip = bgmefu.GetAudioClip(true, true);
                audioefs.Stop();
            }
            if (bgcdf <= 0 & fadef <= 0 & chaptf <= 0)
            {
                WWW bgmefu = new WWW(script.bgmefnum[BGMef_frag]);
                audioefs.clip = bgmefu.GetAudioClip(true, true);
                audioefs.Play();
                BGMef_frag += 1;
            }
        }
        if (videof == -1)
        {
            if (videoflag == 1)
            {
                endflag = 1;
                ButtonManager.gamelogohantei = 0;
            }
            if (TextManager.antenhantei == 0)
            {
                TextManager.antenhantei = 1;
                anmak.antenflag = 1;
            }

            if (anmak.antenflag == 101)
            {
                nexttext.SetActive(true);
                video.Stop();
                videof = 0;
                videop.SetActive(false);
            }
        }


        if (loadflag <= 0 & text_num >= videohantei)
        {
            if (TextManager.antenhantei == 0)
            {
                TextManager.antenhantei = 1;
                anmak.antenflag = 1;
            }
            videof = 1;
            video.url=script.videonum[videox];

            if (anmak.antenflag == 101)
            {
                Image bgcb = Bg.GetComponent<Image>();
                bgcb.sprite = Resources.Load<Sprite>("UI/" + "black");

                videop.SetActive(true);
                video.Play();

                videox += 1;
            }

        }
        if (antenhantei==0&videof > 0)
        {
            nexttext.SetActive(false);
            videof += Time.deltaTime;
            if (videof != -1 & (loadflag <= 0&videof >= video.length| video.isPlaying == true & loadflag == 0 & antenhantei == 0 & Input.GetMouseButtonDown(0)))
            {
                videoflag = 99999;
                videof = -1;
            }
        }

        if (loadflag <= 0 & (bgcdf <= 0 & chaptf <= 0 & antenhantei <= 0 & text_num >= bgehantei | text_num >= bgehantei & bgcdf >= bgcdghantei | text_num >= bgehantei & chaptf >= 4))
        {

            bgexnam = script.bgenum[bgex];
            if (bgexnam != "")
            {
                bge.SetActive(true);
                Image chap = bge.GetComponent<Image>();
                fadep = 10f;
                chap.transform.localScale = new Vector3(10f, 10f, 0);




                chap.sprite = script2.bgs[script.bgenum[bgex]];
            }
            else
            {
                bge.SetActive(false);
            }
            bgex += 1;

        }

        if (loadflag <= 0 & text_num >= bgswhantei)
        {

            bgswnam = script.bgswnum[bgswx];
            if (bgswnam!=""&bgswnam!=null & bgfgage == 0)
            {
                Image bgcuc = bgfla.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
            }
            if (bgswnam!=""&bgswnam!=null & bgfgage <= 1)
            {
                bgfla.SetActive(true);
                ms.SetActive(false);
                Image bgf = bgfla.GetComponent<Image>();
                bgf.sprite =script2.bgs[script.bgswnum[bgswx]];
                Image bgcuc = bgfla.GetComponent<Image>();
                if (bgfgage <= 0.32f)
                {
                    bgcuc.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                }
                bgf.GetComponent<Image>().color = new Color(255, 255, 255, bgfgage);

                bgfgage += 0.08f;
            }



            if (bgswnam!=""&bgswnam!=null & bgfgage >= 1)
            {
                Image bgf = bgfla.GetComponent<Image>();
                bgf.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                bgfgage = 1;
                bgswx += 1;
                mwxf = 1;
            }
            if (bgswnam == "" & bgfgage >= 0)
            {
                ms.SetActive(false);
                Image bgf = bgfla.GetComponent<Image>();
                Image bgcuc = bgfla.GetComponent<Image>();
                if (bgfgage >= 0.68f)
                {
                    bgcuc.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                }
                bgf.GetComponent<Image>().color = new Color(255, 255, 255, bgfgage);
                bgfgage -= 0.08f;
            }
            if (bgswnam == "" & bgfgage <= 0)
            {
                bgfla.SetActive(false);
                Image bgf = bgfla.GetComponent<Image>();
                Image bgcuc = bgfla.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(0, 0.5f, 0);
                bgf.GetComponent<Image>().color = new Color(255, 255, 255, bgfgage);
                bgfgage = 0;
                bgswx += 1;
                mwxf = 1;
            }
        }
        if (loadflag <= 0 & text_num >= bglwhantei)
        {

            bglwnam = script.bglwnum[bglwx];
            if (bglwnam != "" & bgflgage <= 1)
            {
                bgflal.SetActive(true);
                ms.SetActive(false);
                Image bgfl = bgflal.GetComponent<Image>();

                bgfl.GetComponent<Image>().color = new Color(255, 255, 255, bgflgage);
                bgfl.sprite = script2.bgs[script.bglwnum[bglwx]];
                bgflgage += 0.03f;
            }



            if (bglwnam != "" & bgflgage > 1)
            {
                Image bgfl = bgflal.GetComponent<Image>();
                bgfl.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                bgflgage = 1;
                bglwx += 1;
                mwxf = 1;
            }
            if (bglwnam == "" & bgflgage >= 0)
            {
                ms.SetActive(false);
                Image bgfl = bgflal.GetComponent<Image>();
                bgfl.GetComponent<Image>().color = new Color(255, 255, 255, bgflgage);
                bgflgage -= 0.03f;
            }
            if (bglwnam == "" & bgflgage < 0)
            {
                bgflal.SetActive(false);
                Image bgfl = bgflal.GetComponent<Image>();
                bgfl.GetComponent<Image>().color = new Color(255, 255, 255, bgflgage);
                bgflgage = 0;
                bglwx += 1;
                mwxf = 1;
            }
        }
        if (loadflag <= 0 & text_num >= fadehantei)
        {
            if (fadep < 1.05f | bgcf > 0 | bgcdf > 0 | chaptf > 0)
            { 
            fadeoiflag = script.fadeoiflag[fadex];
                fadew3 = 1;
                fadew2 = 0;
                fadew1 = 0;
            ms.SetActive(false);
            nexttext.SetActive(false);
            qlh.SetActive(false);
            qsh.SetActive(false);
            TextManager.qlf = 0;
            TextManager.qsf = 0;

            if (seriousf <= 0)
            {
                    if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                    if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
                }

            if (seriousf >= 1)
            {
                Image bgcdbfas = ms.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Image bgcdbfcs = chrna.GetComponent<Image>();
                bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            }
                if (loadflag <= 0)
                {
                    fadef = 1;
                    if (fadew2 == 0)
                    {
                        fadep = 1;
                        fadecp = 1;
                        if (fadew3 == 1 | fadew3 == 7 | fadew3 == 8)
                        {
                            fadepx = 10;
                        }
                        if (fadew3 == 2)
                        {
                            fadepx = 7;
                        }
                        if (fadew3 == 3 | fadew3 == 4 | fadew3 == 5)
                        {
                            fadepx = 5;
                        }
                    }

                    if (fadew2 == 2)
                    {
                        fadep = 1.179f;
                        fadecp = 1.179f;
                        if (fadew1 == 1)
                        {
                            fadepx = 50;
                        }
                        else
                        {
                            fadepx = 30;
                        }
                    }

                    if (fadeoiflag == 45 | fadeoiflag == 54)
                    {
                        fadep = 1.278f;
                        f2rlf = 1;
                    }
                    else
                    {
                        f2rlf = 0;
                    }
                    if (fadew2 == 1 | fadew2 == 7 | fadew2 == 8)
                    {
                        fadep = 1.079f;
                        fadecp = 1.079f;
                        fadepx = 10;
                    }

                    if (fadew1 == 1 & (fadew2 == 3 | fadew2 == 4 | fadew2 == 5))
                    {
                        fadep = 1.278f;

                        fadecp = 2.5f;
                        if (fadew3 == 2)
                        {
                            fadepx = 10;
                            if (fadeoiflag == 132)
                            {
                                Image chra2ch = chr2.GetComponent<Image>();
                                Image chra3ch = chr3.GetComponent<Image>();
                                Image chra2cch = chr2c.GetComponent<Image>();
                                Image chra3cch = chr3c.GetComponent<Image>();
                                chra2ch.GetComponent<Image>().transform.Translate(-4.5f, 0, 0);
                                chra3ch.GetComponent<Image>().transform.Translate(4.5f, 0, 0);
                                chra2cch.GetComponent<Image>().transform.Translate(-4.5f, 0, 0);
                                chra3cch.GetComponent<Image>().transform.Translate(4.5f, 0, 0);

                            }
                            if (fadeoiflag == 142)
                            {
                                Image chra3ch = chr3.GetComponent<Image>();
                                Image chra3cch = chr3c.GetComponent<Image>();
                                chra3ch.GetComponent<Image>().transform.Translate(8f, 0, 0);
                                chra3cch.GetComponent<Image>().transform.Translate(8f, 0, 0);
                            }
                            if (fadeoiflag == 152)
                            {
                                Image chra2ch = chr2.GetComponent<Image>();
                                Image chra2cch = chr2c.GetComponent<Image>();
                                chra2ch.GetComponent<Image>().transform.Translate(-8f, 0, 0);
                                chra2cch.GetComponent<Image>().transform.Translate(-8f, 0, 0);
                            }
                        }
                    }

                    if (fadew2 == 6)
                    {
                        fadep = 2.5f;
                        fadecp = 4.0f;
                        fadetime = 31;

                        if (fadew3 != 0)
                        {
                            fadepx = 50;
                        }
                    }
                }
            }
            fadex += 1;
        }

        if (bgcf<=0&chaptf == 0 & bgcdf == 0 & antenhantei <= 0 & fadef >= 1)
        {
            if (seriousf <= 0)
            {
                if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
            }

            if (seriousf >= 1)
            {
                Image bgcdbfas = ms.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Image bgcdbfcs = chrna.GetComponent<Image>();
                bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            }
            if (chaptf <= 0 & bgcdf <= 0 & fadeoiflag >= 1)
            {

                this.transform.localScale = new Vector3(fadep, fadep, 0);

                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1c = chr1c.GetComponent<Image>();
                chra1c.transform.localScale = new Vector3(fadep, fadep, 0);
                if (fadeoiflag < 12)
                {
                    Image chra2 = chr2.GetComponent<Image>();
                    chra2.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra3 = chr3.GetComponent<Image>();
                    chra3.transform.localScale = new Vector3(fadep, fadep, 0);

                    Image chra2c = chr2c.GetComponent<Image>();
                    chra2c.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra3c = chr3c.GetComponent<Image>();
                    chra3c.transform.localScale = new Vector3(fadep, fadep, 0);
                }

                if (fadeoiflag >= 12)
                {
                    if (fadeoiflag <= 40)
                    {
                        chr1c.SetActive(true);
                    }
                    if (fadeoiflag != 25)
                    {
                        chr3c.SetActive(true);
                    }
                    if (fadeoiflag != 24)
                    {
                        chr2c.SetActive(true);
                    }

                    if (fadeoiflag >= 45)
                    {
                        Image fach1 = chr1.GetComponent<Image>();
                        fach1.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                        chr1.SetActive(false);
                        chr1c.SetActive(false);
                        chr2.SetActive(false);
                        chr2c.SetActive(false);
                        chr3.SetActive(false);
                        chr3c.SetActive(false);
                    }
                    Image chra2 = chr2.GetComponent<Image>();
                    chra2.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    Image chra3 = chr3.GetComponent<Image>();
                    chra3.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    if (fadeoiflag == 25)
                    {
                        Image chra3c = chr3c.GetComponent<Image>();
                        chra3c.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                    else
                    {
                        Image chra3c = chr3c.GetComponent<Image>();
                        chra3c.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    }
                    if (fadeoiflag == 24)
                    {
                        Image chra2c = chr2c.GetComponent<Image>();
                        chra2c.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                    else
                    {
                        Image chra2c = chr2c.GetComponent<Image>();
                        chra2c.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    }
                    fadecp += 0.055f;
                }
                if (fadeoiflag == 23)
                {
                    Image chra2ch = chr2.GetComponent<Image>();

                    Image chra3ch = chr3.GetComponent<Image>();


                    Image chra2cch = chr2c.GetComponent<Image>();

                    Image chra3cch = chr3c.GetComponent<Image>();

                    chra2ch.GetComponent<Image>().transform.Translate(-0.25f, 0, 0);
                    chra3ch.GetComponent<Image>().transform.Translate(0.25f, 0, 0);
                    chra2cch.GetComponent<Image>().transform.Translate(-0.25f, 0, 0);
                    chra3cch.GetComponent<Image>().transform.Translate(0.25f, 0, 0);
                    chrdl += 1;
                }
                if (fadeoiflag == 25)
                {
                    Image chra2ch = chr2.GetComponent<Image>();

                    Image chra3ch = chr3.GetComponent<Image>();


                    Image chra2cch = chr2c.GetComponent<Image>();

                    Image chra3cch = chr3c.GetComponent<Image>();
                    chra3cch.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
                    chra2ch.GetComponent<Image>().transform.Translate(-0.4f, 0, 0);

                    chra2cch.GetComponent<Image>().transform.Translate(-0.4f, 0, 0);

                    this.GetComponent<Image>().transform.Translate(-0.07f, 0, 0);

                    chrdlf -= 1;

                    chrdl += 1;
                }
                if (fadeoiflag == 24)
                {
                    Image chra2ch = chr2.GetComponent<Image>();

                    Image chra3ch = chr3.GetComponent<Image>();


                    Image chra2cch = chr2c.GetComponent<Image>();

                    Image chra3cch = chr3c.GetComponent<Image>();


                    chra2cch.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
                    chra3ch.GetComponent<Image>().transform.Translate(0.4f, 0, 0);

                    chra3cch.GetComponent<Image>().transform.Translate(0.4f, 0, 0);
                    this.GetComponent<Image>().transform.Translate(0.07f, 0, 0);

                    chrdlf = 1;

                    chrdl += 1;
                }

                if (fadeoiflag == 54 & chrdl < 80)
                {

                    this.GetComponent<Image>().transform.Translate(0.07233f, 0, 0);

                    chrdlf = 1;

                    chrdl += 1;
                }
                if (fadeoiflag == 45 & chrdl < 80)
                {

                    this.GetComponent<Image>().transform.Translate(-0.07233f, 0, 0);

                    chrdlf = -1;

                    chrdl += 1;
                }
                fadetime -= 1;

                if (fadeoiflag == 1)
                {
                    fadep += 0.1f * (1 / fadepx);
                    fadepx += 1;
                }
                if (fadeoiflag == 2)
                {
                    fadep += 0.1f * (1 / fadepx);
                    fadepx += 1;
                }
                if (fadeoiflag == 3 | fadeoiflag == 23 | fadeoiflag == 24 | fadeoiflag == 25)
                {
                    fadep += 0.14f * (1 / fadepx);
                    fadepx += 1;
                }




                if (bgcx >= 1)
                {
                    bgchanteit = script.bgchantei[bgcx-1];
                }
                else
                {
                    bgchanteit = 0;
                }
                if (bgcdx >= 1)
                {
                    bgcdhanteit = script.bgcdhantei[bgcdx-1];
                }
                else
                {
                    bgcdhanteit = 0;
                }
                if (chaptx >= 1)
                {
                    chapthanteit = script.chapthantei[chaptx-1];
                }
                else
                {
                    chapthanteit = 0;
                }
                if (bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                {

                    Bgsp = script2.bgs[script.bgcnum[bgcx-1]];
                    Bg = this.GetComponent<Image>();
                    Bg.sprite = Bgsp;

                }
                if (bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                {

                    Bgsp =script2.bgs[script.bgcdnum[bgcdux-1]];
                    Bg = this.GetComponent<Image>();
                    Bg.sprite = Bgsp;

                }
                if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                {
                    Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];


                    Bg = this.GetComponent<Image>();
                    Bg.sprite = Bgsp;
                }


            }
            if (chaptf == 0 & bgcf == 0 & bgcdf == 0 & fadeoiflag >= 100)
            {


                if (fadeoiflag <= 159)
                {
                    this.transform.localScale = new Vector3(fadep, fadep, 0);
                    if (fadeoiflag <= 121)
                    {

                        Image chra1 = chr1.GetComponent<Image>();
                        chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                        Image chra1c = chr1c.GetComponent<Image>();
                        chra1c.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                    Image chra2 = chr2.GetComponent<Image>();
                    chra2.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra3 = chr3.GetComponent<Image>();
                    chra3.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra1cc = chr1c.GetComponent<Image>();
                    chra1cc.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra2cc = chr2c.GetComponent<Image>();
                    chra2cc.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra3cc = chr3c.GetComponent<Image>();
                    chra3cc.transform.localScale = new Vector3(fadep, fadep, 0);

                    if (fadeoiflag > 121)
                    {
                        chr1c.SetActive(true);
                        if (fadeoiflag == 132)
                        {
                            chr2c.SetActive(true);
                            chr3c.SetActive(true);
                            Image chra2co = chr2c.GetComponent<Image>();
                            chra2co.transform.localScale = new Vector3(fadecp, fadecp, 0);
                            Image chra3co = chr3c.GetComponent<Image>();
                            chra3co.transform.localScale = new Vector3(fadecp, fadecp, 0);
                        }
                        if (fadeoiflag == 152)
                        {
                            chr2c.SetActive(true);
                            chr3c.SetActive(false);
                            Image chra2co = chr2c.GetComponent<Image>();
                            chra2co.transform.localScale = new Vector3(fadecp, fadecp, 0);
                        }
                        if (fadeoiflag == 142)
                        {
                            chr3c.SetActive(true);
                            chr2c.SetActive(false);
                            Image chra3co = chr3c.GetComponent<Image>();
                            chra3co.transform.localScale = new Vector3(fadecp, fadecp, 0);
                        }
                        Image chra1o = chr1.GetComponent<Image>();
                        chra1o.transform.localScale = new Vector3(fadep, fadep, 0);
                        Image chra1co = chr1c.GetComponent<Image>();
                        chra1co.transform.localScale = new Vector3(fadep, fadep, 0);


                    }
                    if (fadeoiflag == 132)
                    {
                        Image chra2ch = chr2.GetComponent<Image>();

                        Image chra3ch = chr3.GetComponent<Image>();


                        Image chra2cch = chr2c.GetComponent<Image>();

                        Image chra3cch = chr3c.GetComponent<Image>();

                        chra2ch.GetComponent<Image>().transform.Translate(0.15f, 0, 0);
                        chra3ch.GetComponent<Image>().transform.Translate(-0.15f, 0, 0);
                        chra2cch.GetComponent<Image>().transform.Translate(0.15f, 0, 0);
                        chra3cch.GetComponent<Image>().transform.Translate(-0.15f, 0, 0);
                        chrdl += 1;
                    }
                    if (fadeoiflag == 152)
                    {
                        Image chra2ch = chr2.GetComponent<Image>();
                        Image chra3ch = chr3.GetComponent<Image>();
                        Image chra2cch = chr2c.GetComponent<Image>();
                        Image chra3cch = chr3c.GetComponent<Image>();
                        Image chra1cch = chr1c.GetComponent<Image>();
                        chra1cch.GetComponent<Image>().transform.Translate(0.075f, 0, 0);
                        chra2ch.GetComponent<Image>().transform.Translate(0.3f, 0, 0);

                        chra2cch.GetComponent<Image>().transform.Translate(0.3f, 0, 0);
                        this.GetComponent<Image>().transform.Translate(0.108f, 0, 0);

                        chrdlf = 0;

                        chrdl += 1;

                    }
                    if (fadeoiflag == 142)
                    {
                        Image chra2ch = chr2.GetComponent<Image>();
                        Image chra3ch = chr3.GetComponent<Image>();
                        Image chra2cch = chr2c.GetComponent<Image>();
                        Image chra3cch = chr3c.GetComponent<Image>();
                        Image chra1cch = chr1c.GetComponent<Image>();
                        chra1cch.GetComponent<Image>().transform.Translate(-0.075f, 0, 0);
                        chra3ch.GetComponent<Image>().transform.Translate(-0.3f, 0, 0);

                        chra3cch.GetComponent<Image>().transform.Translate(-0.3f, 0, 0);
                        this.GetComponent<Image>().transform.Translate(-0.108f, 0, 0);

                        chrdlf = 0;

                        chrdl += 1;
                    }

                    if (fadeoiflag == 142 | fadeoiflag == 152)
                    {
                        fadep -= 0.07f * (1 / fadepx);
                        fadecp -= 0.1125f;
                        fadepx += 1;
                    }
                    else
                    {
                        fadep -= 0.07f * (1 / fadepx);
                        fadecp -= 0.1125f;
                        fadepx += 1;
                    }

                    if (bgcx >= 1)
                    {
                        bgchanteit = script.bgchantei[bgcx-1];
                    }
                    else
                    {
                        bgchanteit = 0;
                    }
                    if (bgcdx >= 1)
                    {
                        bgcdhanteit = script.bgcdhantei[bgcdx-1];
                    }
                    else
                    {
                        bgcdhanteit = 0;
                    }
                    if (chaptx >= 1)
                    {
                        chapthanteit = script.chapthantei[chaptx-1];
                    }
                    else
                    {
                        chapthanteit = 0;
                    }
                    if (bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                    {

                        Bgsp = script2.bgs[script.bgcnum[bgcx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                    {

                        Bgsp =script2.bgs[script.bgcdnum[bgcdux-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }

                    if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                    {
                        Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];


                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;
                    }
                    if (bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                    {

                       Bgsp=script2.bgs[script.bgcnum[bgcx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                    {

                        Bgsp = script2.bgs[script.bgcdnum[bgcdux-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                    {
                        Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;
                    }
                }

                if (fadeoiflag >= 160 & fadeoiflag <= 168)
                {
                    this.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra1 = chr1.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    Image chra1c = chr1c.GetComponent<Image>();
                    chra1c.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    Image chra2 = chr2.GetComponent<Image>();
                    chra2.transform.localScale = new Vector3(fadecp, fadecp, 0);
                    Image chra3 = chr3.GetComponent<Image>();
                    chra3.transform.localScale = new Vector3(fadecp, fadecp, 0);

                    fadepx += 3;
                    fadep -= 1.189f * (5 / fadepx);
                    fadecp -= 0.088f;

                    fadep -= 0.11f * (5 / fadepx);
                    if (bgcx >= 1)
                    {
                        bgchanteit = script.bgchantei[bgcx-1];
                    }
                    else
                    {
                        bgchanteit = 0;
                    }
                    if (bgcdx >= 1)
                    {
                        bgcdhanteit = script.bgcdhantei[bgcdx-1];
                    }
                    else
                    {
                        bgcdhanteit = 0;
                    }
                    if (chaptx >= 1)
                    {
                        chapthanteit = script.chapthantei[chaptx-1];
                    }
                    else
                    {
                        chapthanteit = 0;
                    }
                    if (bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                    {

                        Bgsp = script2.bgs[script.bgcnum[bgcx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                    {

                        Bgsp =script2.bgs[script.bgcdnum[bgcdux-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                    {
                        Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];


                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;
                    }
                    if (fadeoiflag >= -2 & fadeoiflag <= -1 & bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                    {

                       Bgsp=script2.bgs[script.bgcnum[bgcx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (fadeoiflag >= -2 & fadeoiflag <= -1 & bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                    {

                        Bgsp = script2.bgs[script.bgcdnum[bgcdux-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (fadeoiflag >= -2 & fadeoiflag <= -1 & chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                    {
                        Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];


                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;
                    }


                }
                fadetime -= 1;

                if (fadeoiflag >= 160 & fadetime > 0)
                {
                    fadep -= 0.11f * (5 / fadepx);
                    if (bgcx >= 1)
                    {
                        bgchanteit = script.bgchantei[bgcx-1];
                    }
                    else
                    {
                        bgchanteit = 0;
                    }
                    if (bgcdx >= 1)
                    {
                        bgcdhanteit = script.bgcdhantei[bgcdx-1];
                    }
                    else
                    {
                        bgcdhanteit = 0;
                    }
                    if (chaptx >= 1)
                    {
                        chapthanteit = script.chapthantei[chaptx-1];
                    }
                    else
                    {
                        chapthanteit = 0;
                    }
                    if (bgchanteit > chapthanteit & bgchanteit > bgcdhanteit)
                    {

                        Bgsp = script2.bgs[script.bgcnum[bgcx-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (bgcdhanteit > chapthanteit & bgcdhanteit > bgchanteit)
                    {

                        Bgsp =script2.bgs[script.bgcdnum[bgcdux-1]];
                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;

                    }
                    if (chapthanteit > bgcdhanteit & chapthanteit > bgchanteit)
                    {
                        Bgsp = script2.bgs[script.chaptnum[2*chaptx-1]];


                        Bg = this.GetComponent<Image>();
                        Bg.sprite = Bgsp;
                    }

                    fadep = 2.5f;
                    fadecp = 4f;
                    chrcontroller.chrcgage = 0;

                }
            }
            if ((fadew1 == 1 & fadew3 == 0 & fadep <= 1) | (fadew1 == 1 & (fadew3 == 1 | fadew3 == 7 | fadew3 == 8) & fadep <= 1.079f) | (fadew1 == 1 & fadew3 == 2 & fadep <= 1.179f) | fadeoiflag == 163 & fadep <= 1.279f |
                ((fadeoiflag == 1 | fadeoiflag == 7 | fadeoiflag == 8) & fadep >= 1.079f) | (fadew1 == 0 & fadew3 == 2 & fadep >= 1.179f) | (fadew1 == 0 & (fadew3 == 3 | fadew3 == 4 | fadew3 == 5) & fadep >= 1.279f) | ((fadeoiflag == 78 | fadeoiflag == 87 | fadeoiflag == 45 | fadeoiflag == 54) & chrdl == 60))
            {



                if (fadew3 == 0)
                {
                    fadep = 1;
                }

                if (fadew3 == 3 | fadew3 == 4 | fadew3 == 5)
                {
                    fadep = 1.278f;
                    if (fadeoiflag == 23 | fadeoiflag == 24 | fadeoiflag == 25)
                    {
                        chr2c.SetActive(false);
                        chr3c.SetActive(false);
                        chr2.transform.position = chr2l;
                        chr2c.transform.position = chr2l;
                        chr3.transform.position = chr3l;
                        chr3c.transform.position = chr3l;
                    }


                }
                if (fadew3 == 2)
                {
                    fadep = 1.179f;

                    if (fadeoiflag == 142 | fadeoiflag == 152)
                    {
                        chr1c.SetActive(false);
                        chr2c.SetActive(false);
                        chr3c.SetActive(false);
                        chr1.transform.position = chr1l;
                        chr1c.transform.position = chr1l;
                        chr2.transform.position = chr2l;
                        chr2c.transform.position = chr2l;
                        chr3.transform.position = chr3l;
                        chr3c.transform.position = chr3l;
                        Bg.transform.position = bgl;
                    }
                }
                if (fadew3 == 1 | fadew3 == 7 | fadew3 == 8)
                {
                    fadep = 1.079f;
                }
                Image chra1 = chr1.GetComponent<Image>();
                chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra1c = chr1c.GetComponent<Image>();
                chra1c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra2cc = chr2.GetComponent<Image>();
                chra2cc.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3cc = chr3.GetComponent<Image>();
                chra3cc.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra2c = chr2c.GetComponent<Image>();
                chra2c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image chra3c = chr3c.GetComponent<Image>();
                chra3c.transform.localScale = new Vector3(fadep, fadep, 0);
                Image bgcidb = Bg.GetComponent<Image>();
                bgcidb.transform.localScale = new Vector3(fadep, fadep, 0);
                bgf.SetActive(false);
                fadef = 0;
                mwxt = 1;
                chrdl = 0;
                fadecp = 0;
                fadepx = 0;
                fadetime = 0;
                fadeoiflag = 0;

                mwxf = 1;
                nexttext.SetActive(true);
                TextManager.tnumf = 0;
            }
        }

        if (loadflag <= 0 & text_num >= serioushantei)
        {
            seriousf = 1;
            seriousx += 1;
        }
        if (loadflag <= 0 & text_num >= seriousehantei)
        {
            seriousf = 0;
            seriousex += 1;
        }
        
        if (videof == 0 & startflag == 0 & anmak.antenflag > 0 & bgcdf >= 1)
        {
            bgc.SetActive(true);
            Image bgcid = bgc.GetComponent<Image>();
            bgcid.GetComponent<Image>().color = new Color(255, 255, 255, 1);

            bgcid.sprite = script2.bgs[script.bgcdnum[bgcdux]];
            bgcgage = 1;
        }
        if (videof == 0 & startflag == 0 & anmak.antenflag > 0 & bgcf >= 1)
        {
            bgc.SetActive(true);
            Image bgcidc = bgc.GetComponent<Image>();
            bgcidc.GetComponent<Image>().color = new Color(255, 255, 255, 1);

            bgcidc.sprite = script2.bgs[script.bgcnum[bgcx]];
            bgcgage = 1;
        }
        if ((videof == 0 & antenhantei <= 0 & bgcf >= 1 & bgcgage <= 1) | (videof == 0 & antenhantei <= 0 & bgcdf >= 1 & bgcgage <= 1) | (videof == 0 & antenhantei <= 0 & chaptf >= 1 & bgcgage <= 1))
        {
            bgc.SetActive(true);
            qlh.SetActive(false);
            qsh.SetActive(false);
            TextManager.qlf = 0;
            TextManager.qsf = 0;




            if (antenhantei <= 0 & startflag <= 0 & bgcdf >= 1)
            {

                Image bgcid = bgc.GetComponent<Image>();
                bgcid.GetComponent<Image>().color = new Color(255, 255, 255, bgcgage);
                if ((fadeoiflag >= 0) | (fadeoiflag < 0 & bgcdf < bgcdghantei))
                {
                    bgcid.sprite = script2.bgs[script.bgcdnum[bgcdux]];
                }
                if (fadeoiflag <= -10 & fadeoiflag > -11 & bgcdf >= bgcdghantei)
                {
                    fadep = 1.079f;
                    bgcid.sprite = script2.bgs[script.bgcdnum[bgcdux]];
                    bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag <= -20 & fadeoiflag > -22 & bgcdf >= bgcdghantei)
                {
                    fadep = 1.287f;
                    bgcid.sprite = script2.bgs[script.bgcdnum[bgcdux]];
                    bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag <= -60 & fadeoiflag >= -68 & bgcdf >= bgcdghantei)
                {
                    fadep = 2.5f;
                    bgcid.sprite = script2.bgs[script.bgcdnum[bgcdux]];
                    bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                }

            }
            if (bgcdf>0&(antenhantei > 0 | startflag > 0))
            {

                Image bgcdb = bgc.GetComponent<Image>();
                bgcdb.GetComponent<Image>().color = new Color(0, 0, 0, bgcgage);
                bgcdb.sprite = script2.bgs[script.bgcdnum[bgcdux]];

            }

            if (antenhantei <= 0 & startflag <= 0 & bgcf >= 1)
            {

                Image bgcid = bgc.GetComponent<Image>();
                bgcid.GetComponent<Image>().color = new Color(255, 255, 255, bgcgage);
                bgcid.sprite = script2.bgs[script.bgcnum[bgcx]];


            }
            if (antenhantei <= 0 & startflag <= 0 & chaptf > 0)
            {
                if ((chaptf > 0 & chaptf <= 1) | (chaptf > 2 & chaptf <= 3))
                {
                    chaptpx = Resources.Load<Sprite>("UI/black");
                }
                if (chaptf > 1 & chaptf <= 2)
                {
                    chaptpx = script2.bgs[script.chaptnum[2*(chaptx-1)]];
                }
                if (chaptf > 3 & chaptf <= 4)
                {
                    chaptpx = script2.bgs[script.chaptnum[1 + 2 * (chaptx - 1)]];
                    if (fadeoiflag == 110)
                    {
                        fadep = 1.179f;
                        Image bgcid = bgc.GetComponent<Image>();
                        bgcid.sprite = Resources.Load<Sprite>("Bg/" + chaptpx + "b");
                        bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                    if (fadeoiflag >= 120 & fadeoiflag < 122)
                    {
                        fadep = 1.287f;
                        Image bgcid = bgc.GetComponent<Image>();
                        bgcid.sprite = Resources.Load<Sprite>("Bg/" + chaptpx + "b");
                        bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                    if (fadeoiflag >= 130)
                    {
                        fadep = 2.5f;
                        Image bgcid = bgc.GetComponent<Image>();
                        bgcid.sprite = Resources.Load<Sprite>("Bg/" + chaptpx + "b");
                        bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                    }
                }
                Image bgcdbc = bgc.GetComponent<Image>();
                bgcdbc.GetComponent<Image>().color = new Color(255, 255, 255, bgcgage);
                bgcdbc.sprite = chaptpx;
                if (fadeoiflag == 110 & chaptf >= 4)
                {
                    fadep = 1.287f;
                    bgcdbc.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag >= 120 & fadeoiflag < 122 & chaptf >= 4)
                {
                    fadep = 1.287f;
                    bgcdbc.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag >= 130 & fadeoiflag < 133 & chaptf >= 4)
                {
                    fadep = 2.5f;
                    bgcdbc.transform.localScale = new Vector3(fadep, fadep, 0);
                }

            }

            if (bgcdf >= 1 | chaptf >= 1)
            {
                chrcontroller.chrcgage = 0;
            }
            if (bgcf >= 1)
            {
                bgcgage += 0.03f;
            }
            if ((bgcdf >= 1) | (chaptf >= 2 & chaptf < 3))
            {
                bgcgage += 0.008f;
            }
            if (chaptf >= 1 & chaptf < 2 | chaptf >= 3)
            {
                bgcgage += 0.008f;
            }
        }
        if ((loadflag <= 0 & bgcf >= 1 & bgcgage > 0) | (loadflag <= 0 & bgcdf >= 1 & bgcgage > 0) | (loadflag <= 0 & chaptf >= 1 & bgcgage > 0))
        {
            Image chra1 = chr1.GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 1, 0);
            Image chra2 = chr2.GetComponent<Image>();
            chra2.transform.localScale = new Vector3(1, 1, 0);
            Image chra3 = chr3.GetComponent<Image>();
            chra3.transform.localScale = new Vector3(1, 1, 0);
            Image chra1c = chr1c.GetComponent<Image>();
            chra1c.transform.localScale = new Vector3(1, 1, 0);
            Image chra2c = chr2c.GetComponent<Image>();
            chra2c.transform.localScale = new Vector3(1, 1, 0);
            Image chra3c = chr3c.GetComponent<Image>();
            chra3c.transform.localScale = new Vector3(1, 1, 0);
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);
            chr1.SetActive(false);
            chr2.SetActive(false);
            chr3.SetActive(false);
            chr1.transform.position = chr1l;
            chr2.transform.position = chr2l;
            chr3.transform.position = chr3l;
            chr1c.transform.position = chr1l;
            chr2c.transform.position = chr2l;
            chr3c.transform.position = chr3l;
            chrcontroller.unazgage = 0;
            chrcontroller.darugage = 0;
            chrcontroller.odorokigage = 0;
            chrcontroller.okiagarigage = 0;
            chrcontroller.arrivegage = 0;
        }
        if ((loadflag <= 0 & bgcf >= 1 & bgcgage > 1) | (loadflag <= 0 & bgcdf >= 1 & bgcgage > 1) | (loadflag <= 0 & chaptf >= 1 & bgcgage > 1))
        {

            BGl.SetActive(false);
            bti.SetActive(false);
            chrdlf = 0;
            Image chr1d = chr1.GetComponent<Image>();
            chr1d.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            Image chr1dc = chr1c.GetComponent<Image>();
            chr1dc.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            Image chr2d = chr2.GetComponent<Image>();
            chr2d.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            Image chr3d = chr3.GetComponent<Image>();
            chr3d.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            Image bgcidf = bgc.GetComponent<Image>();
            bgcidf.transform.localScale = new Vector3(1, 1, 0);
            Bg.transform.position = bgl;
            bgc.SetActive(false);
            Bg = this.GetComponent<Image>();
            Bg.transform.localScale = new Vector3(1, 1, 0);
            Image chra1 = chr1.GetComponent<Image>();
            chra1.transform.localScale = new Vector3(1, 1, 0);
            Image chra2 = chr2.GetComponent<Image>();
            chra2.transform.localScale = new Vector3(1, 1, 0);
            Image chra3 = chr3.GetComponent<Image>();
            chra3.transform.localScale = new Vector3(1, 1, 0);
            Image chra1c = chr1c.GetComponent<Image>();
            chra1c.transform.localScale = new Vector3(1, 1, 0);
            Image chra2c = chr2c.GetComponent<Image>();
            chra2c.transform.localScale = new Vector3(1, 1, 0);
            Image chra3c = chr3c.GetComponent<Image>();
            chra3c.transform.localScale = new Vector3(1, 1, 0);
            chr1c.SetActive(false);
            chr1.SetActive(false);
            chr2.SetActive(false);
            chr3.SetActive(false);

            if ((bgcdf >= bgcdghantei | chaptf >= 4))
            {

            }
            else
            {
                bge.SetActive(false);
            }


            if (bgcf >= 1)
            {
                Bgsp = script2.bgs[script.bgcnum[bgcx]];
                Bg = this.GetComponent<Image>();
                Image bgcdb = ms.GetComponent<Image>();
                bgcdb.GetComponent<Image>().color = new Color(0, 0, 0, bgcgage);
                bgcdb.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Bg.sprite = Bgsp;
                mwxf = 1;
                if (fadef > 0)
                {
                    mwxf = 0;
                }
                if (fadeoiflag == 101)
                {

                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);


                }
                nexttext.SetActive(true);
                TextManager.tnumf = 0;
                bgcx += 1;
                bgcgage = 0;
                bgcf = -1;
            }
            if (time == 0 & chaptf == 1)
            {
                chaptx += 1;


            }
            if (chaptf >= 1)
            {
                if ((chaptf > 0 & chaptf <= 1) | (chaptf > 2 & chaptf <= 3))
                {
                    chaptpx = Resources.Load<Sprite>("UI/black");
                }
                if (chaptf > 1 & chaptf <= 2)
                {
                    chaptpx = script2.bgs[script.chaptnum[2*(chaptx-1)]];
                }
                if (chaptf > 3 & chaptf <= 4)
                {
                    chaptpx = script2.bgs[script.chaptnum[1 + 2 * (chaptx - 1)]];
                }
                Bgsp = chaptpx;
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                if (fadeoiflag == 110 & chaptf >= 3)
                {
                    bgc.SetActive(false);
                    fadep = 1.179f;

                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);

                }
                if (fadeoiflag >= 120 & fadeoiflag < 122 & chaptf >= 3)
                {
                    bgc.SetActive(false);
                    fadep = 1.287f;

                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag >= 130 & chaptf >= 4)
                {
                    bgc.SetActive(false);
                    fadep = 2.5f;
                    Image bgcdbc = bgc.GetComponent<Image>();
                    bgcdbc.GetComponent<Image>().color = new Color(255, 255, 255, bgcgage);
                    bgcdbc.sprite = script2.bgs[script.chaptnum[chaptx]];
                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);
                }

                if (antenhantei <= 0)
                {
                    Image bgcid = chr1c.GetComponent<Image>();
                    bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                    if (chaptf <= 1 | chaptf >= 3 & chaptf < 4 | chaptf >= 4 & text_num >= bgcdhantei)
                    {
                        timem = 1.75f;
                    }
                    if (chaptf >= 4)
                    {
                        timem = 0.8f;
                    }
                    if (chaptf > 1 & chaptf < 3)
                    {
                        timem = 4.5f;
                    }
                }
                if (time < timem)
                {
                    time += Time.deltaTime;
                }
                else
                {
                    bgcgage = 0;
                    chaptf += 1;
                    timem = 0;
                    time = 0;
                }

            }
            if (chaptf > 4)
            {
                chaptf = 0;
                mwxf = 1;
                nexttext.SetActive(true);
                TextManager.tnumf = 0;
                if (fadef > 0)
                {
                    mwxf = 0;
                }



            }
            if (time == 0 & bgcdf == 1)
            {
                bgcdx += 1;


            }
            if (bgcdf >= 1)
            {

                Bgsp = script2.bgs[script.bgcdnum[bgcdux]];
                Bg = this.GetComponent<Image>();
                Bg.sprite = Bgsp;
                Image bgcdbc = bgc.GetComponent<Image>();
                bgcdbc.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                if (fadeoiflag == 110 & bgcdf >= bgcdghantei)
                {
                    bgc.SetActive(false);
                    fadep = 1.179f;

                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag >= 120 & fadeoiflag < 122 & bgcdf >= bgcdghantei)
                {
                    bgc.SetActive(false);
                    fadep = 1.287f;

                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);
                }
                if (fadeoiflag >= 130 & bgcdf >= bgcdghantei)
                {
                    bgc.SetActive(false);
                    fadep = 2.5f;
                    Bgsp = script2.bgs[script.bgcdnum[bgcdux]];
                    Bg = this.GetComponent<Image>();
                    Bg.sprite = Bgsp;
                    Bg.transform.localScale = new Vector3(fadep, fadep, 0);
                }

                if (antenhantei <= 0)
                {
                    Image bgcid = chr1c.GetComponent<Image>();
                    bgcid.transform.localScale = new Vector3(fadep, fadep, 0);
                    if (bgcdf < bgcdghantei)
                    {
                        timem = 1.75f;
                    }
                    if (bgcdf >= bgcdghantei)
                    {
                        timem = 0.8f;
                    }
                }
                if (time < timem)
                {
                    time += Time.deltaTime;
                }
                else
                {
                    bgcdf += 1;
                    bgcdux += 1;
                    bgcgage = 0;
                    timem = 0;
                    time = 0;
                }
            }
            if (bgcdf > bgcdghantei & bgcdf <= bgcdghantei + 1)
            {
                bgcdf = 0;

                nexttext.SetActive(true);
                TextManager.tnumf = 0;

                mwxf = 1;
                if (fadef > 0)
                {
                    mwxf = 0;
                }
            }

        }
        if (antenhantei > 0 | bgcdf > 0 | chaptf > 0)
        {
            Cursor.visible = false;
            bt.SetActive(false);
        }
        else
        {

            Cursor.visible = true;
            Cursor.SetCursor(mouse, Vector2.zero, CursorMode.ForceSoftware);

        }


        if (videof == 0 & bgcdf <= 0 & chaptf <= 0 & loadflag <= 0 & text_num >= hazimarihantei)
        {


            hazimarix += 1;
            hazimarif = 2;
            next.SetActive(true);


        }
        if (loadflag <= 0 & text_num >= hazimariehantei)
        {
            hazimariex += 1;
            hazimaritt = 0;
            hazimarif = 0;
            hazimarief = 1;
            nexttext.SetActive(false);
            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, 0);
            text.text = "";
            Image ne = ms.GetComponent<Image>();
            ne.GetComponent<Image>().transform.Translate(0, 3, 0);
            Image net = nexttext.GetComponent<Image>();

            net.GetComponent<Image>().transform.Translate(0, -6, 0);
            Image nex = tex.GetComponent<Image>();
            nex.GetComponent<Image>().transform.Translate(0, -6, 0);
            mwxf = 1;
            TextManager.antenhantei = 1;
            anmak.antenflag = 1;

        }
        if (firstf <= 0 & hazimarif >= 2 & bgcgage <= 1)
        {
            ms.SetActive(false);
            bgc.SetActive(true);
            Image bgcid = bgc.GetComponent<Image>();
            bgcid.sprite = script2.bgs[script.hazimarinum[hazimarix - 1]];
            bgcid.GetComponent<Image>().color = new Color(255, 255, 255, bgcgage);
            bgcgage += 0.01f;
        }

        if (hazimarif >= 2 & firstf >= 1 | hazimarif >= 2 & bgcgage > 1)
        {
            BGl.SetActive(false);

            Bgsp = script2.bgs[script.hazimarinum[hazimarix - 1]];
            Bg = this.GetComponent<Image>();
            Bg.sprite = Bgsp;

            Bg.transform.localScale = new Vector3(1, 1, 0);
            bgcgage = 0;
            bgc.SetActive(false);
            ms.SetActive(true);
            next.SetActive(false);
            if (firstf <= 0)
            {
                hazimaritt = 2;
                hazimaritm = 0;
            }
            Image mew = ms.GetComponent<Image>();
            mew.GetComponent<Image>().transform.Translate(0, -3, 0);

            Image ne = tex.GetComponent<Image>();
            ne.GetComponent<Image>().transform.Translate(0, 6, 0);
            Image nex = nexttext.GetComponent<Image>();
            nex.GetComponent<Image>().transform.Translate(0, 6, 0);


            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, 0);
            hazimaritt = 2;
            hazimaritm = 0;
            hazimarif = 1;

        }
        if (hazimarif >= 1 & hazimarif < 2 & hazimaritt < 2 & hazimaritt >= 1)
        {
            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, hazimaritm);
            hazimaritm -= 0.01f;
            if (hazimaritm < 0)
            {
                TextManager.text_num += 1;
                hazimaritt = 2;
            }
        }
        if (antenhantei <= 0 & hazimarif >= 1 & hazimarif < 2 & hazimaritt >= 2)
        {

            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, hazimaritm);
            hazimaritm += 0.01f;

            if (hazimaritm > 1)
            {
                hazimaritm = 1;
                hazimaritt = 0;
            }

        }
        if ((hazimarif <= 0 & mwx < 0.9f & mwxf >= 1) | (antenhantei <= 0 & hazimarif >= 1 & mwxf >= 1 & firstf >= 1 & mwx < 0.9f))
        {
            ms.SetActive(true);
            next.SetActive(false);
            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.text = "";
            if (mwx <= 0 & firstf <= 0 & loadflag <= 0 & seriousf <= 0)
            {
                Image msw = ms.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
            }
            if (mwx <= 0.32f & firstf <= 0 & loadflag <= 0 & seriousf <= 0)
            {
                Image msw = ms.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
            }
            if (seriousf <= 0)
            {
                if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
            }

            if (seriousf >= 1)
            {
                Image bgcdbfas = ms.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Image bgcdbfcs = chrna.GetComponent<Image>();
                bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            }
            Image mw = ms.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, mwx);

            if (loadflag <= 0)
            {
                mwx += 0.08f;
            }
            if (mwx >= 0.75f)
            {
                nexttext.SetActive(true);

                if (TextManager.tnumhantei == 0)
                {
                    TextManager.tnumf = TextManager.tnum - 1;
                    TextManager.tnumhantei = 1;
                }
                bgcf = 0;
                mwxt = 0;
                firstf = 0;
                mwxf = 0;
                mwx = 0;
            }
        }
        if ((hazimarif <= 0 & mwx < 0.9f & mwxf <= -1))
        {
            ms.SetActive(true);

            TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
            te.text = "";
            te.outlineColor = new Color(0, 0, 0, 1);
            if (mwx <= 0.32f & firstf <= 0 & loadflag <= 0 & seriousf <= 0)
            {
                Image msw = ms.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
            }
            if (seriousf <= 0)
            {
                if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
            }

            if (seriousf >= 1)
            {
                Image bgcdbfas = ms.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                Image bgcdbfcs = chrna.GetComponent<Image>();
                bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            }
            Image mw = ms.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f - mwx);



            mwx += 0.08f;
            if (mwx > 0.75f)
            {
                if (firstf <= 0 & loadflag <= 0 & seriousf <= 0)
                {
                    Image msw = ms.GetComponent<Image>();
                    msw.GetComponent<Image>().transform.Translate(0, 0.5f, 0);
                }
                nexttext.SetActive(false);
                ms.SetActive(false);


                bgcf = 0;
                mwxt = 0;
                firstf = 0;
                mwxf = 0;
                mwx = 0;
            }
        }
    }
    public void sentaku()
    {
        for(float sgage=0;sgage<2;sgage+=0.1f)
        {
            if (sentakuf==2)
            {
                Image bgcdbc = senpanel1.GetComponent<Image>();
                bgcdbc.GetComponent<Image>().color = new Color(255,255, 255, 2-sgage);
                Image bgcdbc2 = senpanel2.GetComponent<Image>();
                bgcdbc2.GetComponent<Image>().color = new Color(255,255, 255, 1-sgage);
            }
            else
            {
                Image bgcdbc = senpanel1.GetComponent<Image>();
                bgcdbc.GetComponent<Image>().color = new Color(255,255, 255, 1 - sgage);
                Image bgcdbc2 = senpanel2.GetComponent<Image>();
                bgcdbc2.GetComponent<Image>().color = new Color(255,255, 255, 2 - sgage);
            }
        }
    }
    public void data()
    {
        while (text_num > endhantei)
        {
            if (LOGktext.loglflag > 0)
            {
                Debug.Log(sentakux);
                int icx = script.textho.Length + 1;
                System.Array.Resize(ref script.textho, icx);
                System.Array.Resize(ref script.name, icx);
                System.Array.Resize(ref script.color, icx);
                System.Array.Resize(ref script.ocolor, icx);
                script.textho[script.textho.Length - 1] = "選択肢";
                script.name[script.textho.Length - 1] = "";
                script.color[script.textho.Length - 1] = "ffffff";
                script.ocolor[script.textho.Length - 1] = "000000";
                script.ReloadD1();
                script.ReloadD2();
                if (script.charts[textti.six] == 1)
                {
                    script.Concat1();
                }
                if (script.charts[textti.six] == 2)
                {
                    script.Concat2();
                }
                textti.six += 1;
            }
            else
            {
                if (script.charts[textti.six] == 1)
                {
                    if (Bgcontroller.sentakux == 0) { Bgcontroller.sentakux += 1; script.chartx[script.chartx.Length - 1] = 1; } else { if (script.sentakutypes[Bgcontroller.sentakux] != 0) { Bgcontroller.sentakux += script.sentakutypes[Bgcontroller.sentakux] + 1 + 1; script.chartx[script.chartx.Length - 1] = script.sentakutypes[Bgcontroller.sentakux] + 1 + 1; } }
                }
                if (script.charts[textti.six] == 2)
                {
                    if (Bgcontroller.sentakux == 0) { Bgcontroller.sentakux += 2; script.chartx[script.chartx.Length - 1] = 2; } else { if (script.sentakutypes[Bgcontroller.sentakux] != 0) { Bgcontroller.sentakux += script.sentakutypes[Bgcontroller.sentakux - 1] + 1 + 2; script.chartx[script.chartx.Length - 1] = script.sentakutypes[Bgcontroller.sentakux] + 1 + 2; } }
                }
                textti.six += 1;
            }
            if (sentakuf == 0 & sentakux < script.charth.Length) { endhantei = script.charth[sentakux]; } else { endhantei = 999999; }
            Debug.Log(textti.six);
            if (text_num <= endhantei)
            {
                Debug.Log(sentakux);
                break;
            }
        }
    }

}
