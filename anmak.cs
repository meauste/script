using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class anmak : MonoBehaviour
{
    [SerializeField]
    private TextAsset antenText;
    public static int mwxflo;
    public float mwlox;
    private string antenData;
    public string[] antencon;
    public int antenx;
    public int antenhantei;
    public int hazimarif;
    public int hazimarief;
    public static int antenflag;
    public static int antenxt;
    public int text_num;
    public int antennum;
    public int antenhanteinum;
    public float anten;
    public int startflag;
    public int loadflag;
    public static int loadtime;
    public int endflag;
    public int endgflag;
    public int chapwx;
    public float mwx;
    public int mwxf;
    public int antenyt;
    public int tnumf;
    public int bgcf;
    public int bgcdf;
    public int camf;
    public int firstf;
    public int seriousf;
    public int bgcdhanteit;
    public int bgchanteit;
    public int bgcmwx;
    public int openingflag;
    public float antenmx;
    public int antenmmx;
    public float antenmy;
    public int antenmmy;
    public static int antenxx;
    public static int antenxy;
    public float antenmkx;
    public float antenmky;
    public GameObject anmakl;
    public GameObject text;
    public saveload sl;
    public saveloadl sll;
    public GameObject MessageWindow_object;
    public GameObject chrna;
    public Image msi;
    public Image chi;
    public GameObject nexttext;
    public TextMeshProUGUI textl;
    public GameObject chrnat;
    public GameObject anmaku;
    public GameObject Bg;
    public GameObject chap;
    public GameObject Loadmenu;
    public Vector3 anmakul;
    public GameObject Panel;
    public static string savestname;
    textti script;
    dataload script2;

  
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        chap.SetActive(false);
        antenData = antenText.text;
        anmakul = anmakl.transform.position;
        // ‰üs‚Å•ªŠ„‚µ‚Ä”z—ñ‚É‘ã“ü
        antencon = antenData.Split(char.Parse("\n"));
        loadflag = Load.loadflag;
        if (tloadco.tloadflag > 0)
        {
           
            anmaku.SetActive(true);
            TextManager.antenhantei = 1;
            antenflag = 1;
            anten = 1;
            antenxt = 0;
        }
        else
        {
            anmakl.SetActive(true);
            TextManager.antenhantei = 1;
            antenflag = 3;
            antenxt = 1;
            antenmy = 0.1f;
            Image annmak = anmakl.GetComponent<Image>();
            annmak.GetComponent<Image>().color = new Color(255,255,255,255);
            antenmmy = 20;
          
            
            Image chra2t = anmakl.GetComponent<Image>();
            chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklyb");
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        antenhantei = TextManager.antenhantei;
        hazimarif = Bgcontroller.hazimarif;
        text_num = TextManager.text_num;
        antennum = TextManager.antennum;
        startflag = Bgcontroller.startflag;
        antenhanteinum = TextManager.antenhanteinum;
        loadflag = Load.loadflag;
        endflag = Bgcontroller.endflag;
        endgflag = gpointerevent.endgflag;
        tnumf = TextManager.tnumf;
        bgcf = Bgcontroller.bgcf;
        bgcmwx = Bgcontroller.bgcmwx;
        bgcdf = Bgcontroller.bgcdf;
        camf = Bgcontroller.camf;
        firstf = Bgcontroller.firstf;
        seriousf = Bgcontroller.seriousf;
        bgchanteit = Bgcontroller.bgchanteit;
        bgcdhanteit = Bgcontroller.bgcdhanteit;
        script = GameObject.Find("textti").GetComponent<textti>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();
        if (loadflag==2)
        {
            
            antenxx = 0;
            antenxy = 0;
        }
        if (antenflag==0&(loadflag==1|endflag>0|endgflag>0))
        {
            antenflag=1;
        }
    

        if ((antenhantei ==1&antenxt==0&antenflag>0&antenflag<100))
        {
            MessageWindow_object.SetActive(false);

            
            if (antenflag == 1)
            {
                anmaku.SetActive(true);
                Image annmak = anmaku.GetComponent<Image>();
                annmak.GetComponent<Image>().color = new Color(0, 0, 0, anten);
                if (loadflag == 0)
                {
                    anten += 0.005f;
                }
                else
                {
                    anten += 0.05f;
                }
                if (anten > 1)
                {
                    if (endgflag > 0)
                    {
                        Application.Quit();
                    }
                    if (Bgcontroller.endflag > 0)
                    {

                        SceneManager.LoadScene("Title");
                    }

                    antenxt = 1;

                    if (loadflag ==1)
                    {
                        Loadmenu.SetActive(false);
                        Load.loadflag = 2;
                        loadtime = 1;
                        antenflag = 101;
                    }
                }
            }
            if (antenflag==2)
            {



                antenmx = 0.2f;
                antenmmx = 30;
                if (antenmkx == 0)
                {
                    anmakl.SetActive(true);

                    Image chra2t = anmakl.GetComponent<Image>();
                    chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklxa");
                    Image annmak = anmakl.GetComponent<Image>();
                    annmak.GetComponent<Image>().color = new Color(255,255,255, 255);
                    Image bgcuca = anmakl.GetComponent<Image>();
                    anmakl.GetComponent<Image>().transform.Translate(-antenmmx, 0, 0);
                }
                Image bgcuc = anmakl.GetComponent<Image>();
                    anmakl.GetComponent<Image>().transform.Translate(antenmx, 0, 0);
                    antenmkx += antenmx;
                    if (antenmkx>=antenmmx-0.6f)
                    {
                    Image chra2t = anmakl.GetComponent<Image>();
                    chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklxb");
                    antenxt = 1;
                  
                    }

            }
            if (antenflag==3)
            {

                antenmy = 0.1f;
                antenmmy = 20;
                if (antenmky == 0)
                {
                    anmakl.SetActive(true);
                    Image chra2t = anmakl.GetComponent<Image>();
                    chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklya");
                    Image annmak = anmakl.GetComponent<Image>();
                    annmak.GetComponent<Image>().color = new Color(255,255,255,255);
                    Image bgcuca = anmakl.GetComponent<Image>();
                    anmakl.GetComponent<Image>().transform.Translate(0,-antenmmy, 0);
                }
                    Image bgcuc = anmakl.GetComponent<Image>();
                    anmakl.GetComponent<Image>().transform.Translate(0, antenmy, 0);
                    antenmky+=antenmy;
                      if (antenmky>=antenmmy-0.6f)
                    {
                    Image chra2t= anmakl.GetComponent<Image>();
                    chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklyb");
                    antenxt = 1;
                     }
            }
            




               

            
        }
        if (loadflag == 0 & antenxt > 0 & antenxt <= 100 & antenflag>0&antenflag<=100)
        {
            antenxt += 1;
        }
        if (antenxt > 100)
        {
            if (antenflag == 1)
            {
                antenflag = 101;
            }
            if (antenflag == 2)
            {
                antenflag = 102;
                Image chra2t = anmakl.GetComponent<Image>();
                chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklxb");
            }
            if (antenflag == 3)
            {
                antenflag = 103;
                Image chra2t= anmakl.GetComponent<Image>();
                    chra2t.sprite = Resources.Load<Sprite>("UI/" + "anmaklyb");
            }
            antenxt = 0;
        }
        if (loadflag>0&antenflag==101|loadflag==0&antenflag >100&textt.dataload==0)
        {
            
            if (antenflag == 101)
            {
                Image annmak = anmaku.GetComponent<Image>();
                annmak.GetComponent<Image>().color = new Color(0, 0, 0, anten);
                if (loadtime== 0)
                {
                    anten -= 0.005f;
                }
                else
                {
                    anten -= 0.05f;
                }
                if (anten<0)
                {
                    antenflag = -1;
                }
            }
            if (antenflag == 102)
            {
                
                
                    anmakl.GetComponent<Image>().transform.Translate(antenmx, 0, 0);
                
                antenmkx += antenmx;
                antenyt += 1;
                if (antenyt>(antenmmx-7*antenmx)/antenmx)
                {
                    antenflag = -1;

                }

            }
            if (antenflag == 103)
            {
               
                Image bgcuc = anmakl.GetComponent<Image>();
                anmakl.GetComponent<Image>().transform.Translate(0, antenmy, 0);
            
                
                    antenmky += antenmy;
                
                antenyt += 1;
                if (antenyt>(antenmmy-7*antenmy)/antenmy)
                {
                    antenflag = -1;
                }
            }
            hazimarief = Bgcontroller.hazimarief;
            if (hazimarief > 0)
            {
                text.SetActive(true);
                nexttext.SetActive(true);
                TextManager.tnumf = 0;
                TextManager.tnumhantei = 1;
            }
            openingflag = Bgcontroller.openingflag;
            if (openingflag == 3)
            {
                TextManager.text_num += 1;
                TextManager.tnumhantei = 1;
                TextManager.tnumf = 0;
                Bgcontroller.openingflag = 0;
            }
            if (tloadco.tloadflag <= 0 & loadtime > 0 & loadtime <= 20 | tloadco.tloadflag >= 1 &loadflag>0& loadtime <= 50)
            {
                if (loadtime==5&tloadco.tloadflag==0)
                {
                    Load.loadflag = 5;
                }
                if (tloadco.tloadflag>0&loadtime<=5)
                {
                    Load.loadflag = 2;
                }
                if (loadtime>5&LOGktext.loglflag==0&tloadco.tloadflag==0)
                { 
                
                    sl.Load();
                
                }
                if (tloadco.tloadflag > 0)
                {
                    saveload.savesname = savestname;
                    sl.Load();
                }
                loadtime += 1;
                anten = 1;
                mwxflo = 1;
                mwlox = 0;

            }
            if (tloadco.tloadflag <= 0 & loadtime > 20 & loadtime <= 200 | tloadco.tloadflag >= 1 & loadtime <= 300 & loadtime > 50)
            {
                anten = 1;
                if (saveload.loadf == 1)
                {

                    Load.loadflag = 3;
                    loadtime += 1;

                }
                if (LOGktext.loglflag == 1)
                {
                    if (saveloadl.loadfl == 0)
                    {
                        saveloadl.loadfl = 1;
                    }
                    if (saveloadl.loadfl == 4)
                    {
                        Load.loadflag = 3;
                        loadtime += 1;
                    }

                }
                antenhantei = 2;
                camf = 0;
                text.SetActive(true);
                nexttext.SetActive(true);
                TextManager.tnumf = 0;
                Panel.SetActive(true);
                if (mwlox >= 0 & mwxflo == 1)
                {
                    Image bgfla = Panel.GetComponent<Image>();
                    bgfla.GetComponent<Image>().color = new Color(255, 255, 255, mwlox);
                    mwlox += 0.01f;
                    if (mwlox >= 1f)
                    {
                        bgfla.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                        mwxflo = 2;
                        mwlox = 0;
                    }
                }
                if (mwlox >= 0 & mwxflo == 2)
                {

                    Image bgflb = Panel.GetComponent<Image>();
                    bgflb.GetComponent<Image>().color = new Color(255, 255, 255, 1 - mwlox);
                    mwlox += 0.01f;
                    if (mwlox >= 1f)
                    {

                        bgflb.GetComponent<Image>().color = new Color(255, 255, 255, 0);
                        mwxflo = 1;
                        mwlox = 0;
                    }
                }
            }
            if (tloadco.tloadflag <= 0 & loadtime > 200 | tloadco.tloadflag >= 1 & loadtime >= 300)
            {
                LOGktext.loglflag = 0;
                mwxflo = 0;
                mwlox = 0;
                Load.loadflag = 0;
                saveload.loadf = 0;
                saveloadl.loadfl = 0;
                loadtime = -1;
                tloadco.tloadflag = 0;
                antenhantei = 1;
                Panel.SetActive(false);
            }
        }
           
              

            if (antenflag==-1)
            {
            antenxt = 0;
            antenyt = 0;
            antenmkx = 0;
            antenmky = 0;
            anten = 0;
                antenmx = 0;
            antenmy = 0;
            anmakl.transform.position = anmakul;
            loadtime = 0;
              if (loadflag<=0)
                {
                    loadflag = 1;
                }


            anmaku.SetActive(false);
            anmakl.SetActive(false);
            if (mwx < 0.9f & mwxf >= 1)
                {
                    MessageWindow_object.SetActive(true);
                    Image mw = MessageWindow_object.GetComponent<Image>();
                mw.GetComponent<Image>().color = new Color(255, 255, 255, mwx);
                    bgchanteit = Bgcontroller.bgchanteit;
                    bgcdhanteit = Bgcontroller.bgcdhanteit;

                    seriousf = Bgcontroller.seriousf;
                    if (seriousf <= 0)
                    {
                    if (script.uignum[0] != null & script.uignum[0] != "") { msi.sprite = script2.uis[script.uignum[0]]; } else { msi.sprite = Resources.Load<Sprite>("UI/mess"); }
                    if (script.uignum[1] != null & script.uignum[1] != "") { chi.sprite = script2.uis[script.uignum[1]]; } else { chi.sprite = Resources.Load<Sprite>("UI/chrna"); }
                }
                    if (seriousf>=1)
                    {
                        Image bgcdbfas = MessageWindow_object.GetComponent<Image>();
                        bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                        Image bgcdbfcs = chrna.GetComponent<Image>();
                        bgcdbfcs.sprite = Resources.Load<Sprite>("UI/" + "transparent");
                    }
                    
                   TextMeshProUGUI te = text.GetComponent<TextMeshProUGUI>();
                te.outlineColor = new Color(0, 0, 0, 1);
                te.text = "";
                    Text tei = text.GetComponent<Text>();
                    tei.GetComponent<Text>().color = new Color(255, 255, 255, mwx);
                    Text chrte = chrnat.GetComponent<Text>();
                    chrte.GetComponent<Text>().color = new Color(255, 255, 255, mwx);

                mwx += 0.05f;
                    if (hazimarif>=1)
                    {
                        mwx -= 0.04f;
                    }
                    
                    if (mwx >= 0.75f)
                    {
                    TextManager.tnumf = 0;
                    TextManager.tnumhantei = 1;
                    nexttext.SetActive(true);
                        Text tex = text.GetComponent<Text>();
                        tex.GetComponent<Text>().color = new Color(255,255,255, 255);
                        Text chrtee = chrnat.GetComponent<Text>();
                        chrtee.GetComponent<Text>().color = new Color(255, 255, 255, 255);
                        TextManager.antenhantei = 0;
                        antenflag = 0;
                    TextManager.tnumf = 0;
                    TextManager.tnumhantei = 1;
                    mwxf = 0;
                        Bgcontroller.bgcmwx = 0;
                        mwx = 0;
                    }
                }




                
                    if (antenhantei>0&hazimarief<=0)
                {


                    mwxf = 1;
                   
                   

                }
                openingflag = Bgcontroller.openingflag;
                    if (openingflag==1)
                {
                    mwxf = 0;
                }
                    if (hazimarief>0)
                {
                    hazimarief = 0;
                }
                hazimarif = Bgcontroller.hazimarif;
                    if (hazimarif>=0)
                {
                    mwxf = 0;
                }
                if (loadflag > 0)
                {
                    MessageWindow_object.SetActive(true);
                    Loadmenu.SetActive(false);
                    nexttext.SetActive(true);
                    Load.loadflag = 0;
                    
                    mwxf = 0;
                        mwx = 0;
                        TextManager.antenhantei = 0;
                        antenflag = 0;
                    


                }
               

                if (startflag > 0)
                {

                    mwxf = 0;
                    nexttext.SetActive(true);



                    if (startflag <= 1 & chapwx <= 100)
                    {

                        Bgcontroller.startflag = -1;
                        chapwx += 1;


                        if (chapwx > 100)
                        {

                            Bgcontroller.startflag = 2;
                            antenflag = 0;

                            chapwx = 0;

                        }
                    }
                    if (startflag > 2)
                    {
                        chap.SetActive(false);
                       
                        
                        
                    }


                
            }
        }
    }
}








