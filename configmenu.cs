using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class configmenu : MonoBehaviour
{
    public static int mwxfc;
    public static float mwxc;
    public GameObject taute;
    public GameObject bgmte;
    public GameObject bgmete;
    public GameObject bgmsote;
    public GameObject gsmm;
    public GameObject gsmt;
    public string textspx;
    public string texts;
    public float texttx;
    public int tnumf;
    public int tnum;
    public float auto;
    public int automax;
    public float autow;
    public int autof;
    public int tnumflag;
    public string[] gstex;
    public string[] nextsx = { "足跡", "矢印", "時計" };
    public string[] outlinex = { "タイプ１", "タイプ２" };
    public GameObject nsm;
    public GameObject nst;
    public GameObject olm;
    public GameObject olt;
    public Text outline;
    public Text nextst;
    public GameObject gste;
    public GameObject autogage;
    public GameObject bgmefte;
    public GameObject LOG;
    public Vector3 ml;
    public GameObject topte;
    public TextMeshProUGUI textsp;
    public AudioSource audios;
    public AudioSource audioso;
    public AudioSource audioes;
    public AudioSource audioefs;
    public saveloadc slc;
    public Text fonts;
    public GameObject chrtext;
    public Image bgmi;
    public Image bgmei;
    public Image bgmefi;
    public Image bgmsysi;
    public Sprite[] audioi;
    public Slider textslide;
    public Slider autoslide;
    public Slider bgmslide;
    public Slider bgmeslide;
    public Slider bgmefslide;
    public Slider bgmsysslide;
    public Slider fsslide;
    public static float textspeed;
    public static float autospeed;
    public static float bgmvol;
    public static float bgmevol;
    public static float bgmefvol;
    public static float bgmsysvol;
    public float fontsize;
    public Outline chrline;
    public string fs;
    public int fss;
    // Start is called before the first frame update
    void Start()
    {
        gstex=new string[3] { "1366×768", "1920×1080", "フルスクリーン" };
        LOG.transform.position = ml;
        tnumflag = 1;
        autogage.SetActive(false);
        automax = 120;
        bgmslide.value=textti.audiov;
        bgmeslide.value=textti.audioev;
        bgmefslide.value=textti.audioefv;
        bgmsysslide.value=textti.audiosofv;
        fsslide.value=textti.fsi;
        textslide.value = 8-textti.texttime/0.25f/0.02f;
        autoslide.value = textti.autott/1.5f/0.25f;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (mwxc >= 0 & mwxfc >= 1 & mwxfc < 2)
        {
            Image bgcdbb = LOG.GetComponent<Image>();
            bgcdbb.GetComponent<Image>().color = new Color(255, 255, 255, mwxc);
            if (mwxc >= 1f)
            {
                Image bgcdba = LOG.GetComponent<Image>();
                bgcdba.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                mwxfc = 0;
                mwxc = 0;
            }
            mwxc += 0.2f;
        }
        if (mwxfc==0)
        {
            Text chr_text = chrtext.GetComponent<Text>();
            Outline chrli = chrline.GetComponent<Outline>();
            if (textti.outf==0)
            {
                chr_text.color = new Color(0, 0, 0, 1);
                chrli.effectColor = new Color(1, 1, 1, 1);
                textsp.color = new Color(0, 0, 0, 1);
                textsp.outlineColor = new Color(1, 1, 1, 1);
            }
            if (textti.outf == 1)
            {
                chr_text.color = new Color(1,1,1, 1);
                chrli.effectColor = new Color(0,0,0,1);
                textsp.color = new Color(1, 1, 1, 1);
               textsp.outlineColor = new Color(0, 0, 0, 1);
            }
            //音量
            if (configco.bgmanf == 1)
            {
                bgmslide.value=bgmvol;
                bgmeslide.value=bgmevol;
                bgmefslide.value=bgmefvol;
                bgmsysslide.value=bgmsysvol;
                configco.bgmanf = 0;
            }
            else
            {
                bgmvol = bgmslide.value;
                bgmevol = bgmeslide.value;
                bgmefvol = bgmefslide.value;
                bgmsysvol = bgmsysslide.value;
            }
            fontsize = fsslide.value;
            fonts.text = ""+Mathf.Floor(fontsize);
            textti.fsi = fontsize;
            Text text_text = topte.GetComponent<Text>();
            textspeed = textslide.value;
            text_text.text = "" + Mathf.Floor(textspeed);
            textti.texttime = (8-textspeed)*0.25f*0.02f;
            Text text_texta = taute.GetComponent<Text>();
            autospeed = autoslide.value;
            text_texta.text = "" + Mathf.Floor(autospeed);
            textti.autott = autospeed * 0.25f * 1.5f;
            //bgm
            Text text_textb = bgmte.GetComponent<Text>();
            text_textb.text = ""+Mathf.Floor(bgmvol*100);
            textti.audiov = bgmvol;
            audios.volume = textti.audiov;
            if (textti.audiov > 0) { if (textti.audiov < 0.3f) { bgmi.sprite = audioi[1]; } else if (textti.audiov <0.6f) { bgmi.sprite = audioi[2]; } else { bgmi.sprite = audioi[3]; } } else { bgmi.sprite = audioi[0]; }
            Text text_textc = bgmete.GetComponent<Text>();
            text_textc.text = ""+Mathf.Floor(bgmevol * 100);
            textti.audioev = bgmevol;
            audioes.volume = textti.audioev;
            if (textti.audioev > 0) { if (textti.audioev < 0.3f) { bgmei.sprite = audioi[1]; } else if (textti.audioev <0.6f) { bgmei.sprite = audioi[2]; } else { bgmei.sprite = audioi[3]; } } else { bgmei.sprite = audioi[0]; }
            Text text_textd = bgmefte.GetComponent<Text>();
            text_textd.text = ""+Mathf.Floor(bgmefvol * 100);
            textti.audioefv = bgmefvol;
            audioefs.volume = textti.audioefv;
            if (textti.audioefv > 0) { if (textti.audioefv < 0.3f) { bgmefi.sprite = audioi[1]; } else if (textti.audioefv <0.6f) { bgmefi.sprite = audioi[2]; } else { bgmefi.sprite = audioi[3]; } } else { bgmefi.sprite = audioi[0]; }
            Text text_texted = bgmsote.GetComponent<Text>();
            text_texted.text = ""+Mathf.Floor(bgmsysvol * 100);
            textti.audiosofv = bgmsysvol;
            audioso.volume = textti.audiosofv;
            if (textti.audiosofv > 0) { if (textti.audiosofv < 0.3f) { bgmsysi.sprite = audioi[1]; } else if (textti.audiosofv <0.6f) { bgmsysi.sprite = audioi[2]; } else { bgmsysi.sprite = audioi[3]; } } else { bgmsysi.sprite = audioi[0]; }
            Text text_texte = gste.GetComponent<Text>();
            text_texte.text = gstex[textti.gsex];
            nextst.text = nextsx[textti.nextst];
            outline.text = outlinex[textti.outf];
            if (textti.nextst == 0) { nsm.SetActive(false); } else { nsm.SetActive(true); }
            if (textti.nextst == 2) { nst.SetActive(false); }else{ nst.SetActive(true); }
            if (textti.outf == 0) { olm.SetActive(false); olt.SetActive(true); } else { olm.SetActive(true); olt.SetActive(false); }
            textsp.fontSize = textti.fsi * 0.4f ;
           tnum = textspx.Length-7;
                texttx+=Time.deltaTime;
            if (tnumflag == 1 & texttx > textti.texttime)
            {
                tnumf += 1;
                if (tnumf < tnum)
                {
                    if (tnumf < 2)
                    {
                        texts = textspx.Substring(7, tnumf);
                    }
                    if (tnumf == 2)
                    {
                        texts = textspx.Substring(7, tnumf - 1) + "<alpha=#80>" + "" + textspx.Substring(7 + tnumf - 1, 1);
                    }
                    if (tnumf == 3)
                    {
                        texts = textspx.Substring(7, tnumf - 2) + "<alpha=#80>" + "" + textspx.Substring(7 + tnumf - 2, 1) + "<alpha=#60>" + "" + textspx.Substring(7 + tnumf - 1, 1);
                    }
                    if (tnumf == 4)
                    {
                        texts = textspx.Substring(7, tnumf - 3) + "<alpha=#80>" + "" + textspx.Substring(7 + tnumf - 3, 1) + "<alpha=#60>" + textspx.Substring(7 + tnumf - 2, 1) + "<alpha=#40>" + "" + textspx.Substring(7 + tnumf - 1, 1);
                    }
                    if (tnumf >= 5)
                    {
                        texts = textspx.Substring(7, tnumf - 4) + "<alpha=#80>" + "" + textspx.Substring(7 + tnumf - 4, 1) + "<alpha=#60>" + textspx.Substring(7 + tnumf - 3, 1) + "<alpha=#40>" + "" + textspx.Substring(7 + tnumf - 2, 1) + "<alpha=#20>" + "" + textspx.Substring(7 + tnumf - 1, 1);
                    }
                    textsp.text = texts;
                }
                else
                {
                    textsp.text = textspx.Substring(7, tnumf);
                    autof = 1;
                    autow = auto / automax;
                    tnumf = 0;
                    tnumflag = 0;
                }
                texttx = 0;
                
            }
            if (autof==1&autow<=1)
            {

               
                autogage.SetActive(true);
                auto += textti.autott;
                autow = auto / automax;
                Slider autog = autogage.GetComponent<Slider>();
                autog.value = (float)auto / (float)automax;
            }
            if (autow>1)
            {
                
                Slider autog = autogage.GetComponent<Slider>();
                autog.value = (float)auto / (float)automax;
                autogage.SetActive(false);
                tnumflag = 1;
                auto = 0;


            }

            
        }
        if (textti.gsex == 0) { gsmm.SetActive(false); } else { gsmm.SetActive(true); }
        if (textti.gsex == 2) { gsmt.SetActive(false); } else { gsmt.SetActive(true); }
        if (textti.gspf == 1 & textti.gsex == 0)
        {
            Screen.SetResolution(1366, 768, false);
            textti.gspf = 0;
        }
        if (textti.gspf == 1 & textti.gsex == 1)
        {
            Screen.SetResolution(1920, 1080, false);
            textti.gspf = 0;
        }
        if (textti.gspf == 1 & textti.gsex == 2)
        {

            Screen.SetResolution(Screen.width, Screen.height, true);
            textti.gspf = 0;
        }
    }
}
