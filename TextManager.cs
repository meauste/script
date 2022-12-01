using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using System;
using System.IO;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI text_object=null;
    public static int text_num;
    public float texttime;
    public float texttx;
    public int text_flag;
    public static int tnumhantei;
    public int[] autotx;
    public int atx;
    public int tnumflag;
    public static int canif;
    public float kmx;
    public float kx;
    public static int tnum;
    public static int tnumf;
    public static int tnumfa;
    public static int qsf;
    public int qstime;
    public static int qlf;
    public int qltime;
    public int loadflag;
    public static int endflag;
    public string st;
    public DateTime nowtime;
    public int bgcf;
    public int bgcdf;
    public int fadef;
    public string kt;
    public static int antennum;
    public static int antenhanteinum;
    public static int antenhanteinumt;
    public static int antenhantei;
    public int hazimarihantei;
    public int hazimarif;
    public int hazimaritt;
    public float hazimaritm;
    public int hazimarief;
    public string tanif;
    public static float tanitime;
    public float tanimtime;
    public static float auto;
    public int chrmsx;
    public int automax;
    public float autow;
    public static int autoflag;
    public int logflag;
    public string textho;
    public int teemx;
    public int cnx;
    public int cox;
    public int coex;
    public int mostm;
    public int kaigyox;
    public string texts;
    public int[] index;
    public int ix;
    Color chrcolor;
    Color chrncolor;
    public string texthm;
    public GameObject next_object;
    public GameObject MessageWindow_object;
    public GameObject nexttext;
    public GameObject LOG;
    public GameObject autogage;
    public GameObject autoY;
    public GameObject autoN;
    public GameObject qsh;
    public GameObject qlh;
    public GameObject config;
    public GameObject titleback;
    public GameObject quitgame;
    public GameObject savepanel;
    public GameObject loadpanel;
    public GameObject endpanel;
    public GameObject bt;
    public GameObject bt2;
    public GameObject bt3;
    public GameObject chrpanel;
    public GameObject chrtext;
    public Outline chrline;
    public Outline textline;
    public static string chrnam;
    public int atnumf;
    public float atexttex;
    textti script;
    public saveload sl;
    public float texttv;
    public Animator anim;
    public string[] fonx;
    public string cc;
    public int names;
  
   // Start is called before the first 
   void Start()
    {
        loadflag = Load.loadflag;
        if (loadflag <= 0)
        {
            text_num = 0;
        }
        Text chr_text = chrtext.GetComponent<Text>();
        Font txfont = Resources.Load<Font>("Font/" + fonx[textti.fox]);
        TMP_FontAsset txfontp = Resources.Load<TMP_FontAsset>("Font/" + fonx[textti.fox]);
        Material txfontm = Resources.Load<Material>("Font/" + fonx[textti.fox]+" Atlas Material");
        chr_text.font = txfont;
        text_object.font = txfontp;
        text_object.material = txfontm;
        chr_text.fontSize = 35;
        tnumhantei=1;
        tnumfa = 0;
        kx = 0;
        kmx = 0;
        endflag=0;
            autoflag = 0;
        auto = 0;
        texttv = Time.deltaTime;
        savepanel.SetActive(false);
        loadpanel.SetActive(false);
        endpanel.SetActive(false);
            autogage.SetActive(false);
            autoN.SetActive(false);
        chrpanel.SetActive(false);
        qsh.SetActive(false);
        qlh.SetActive(false);
        TextMeshProUGUI te = text_object.GetComponent<TextMeshProUGUI>();
        te.outlineColor = new Color(1,1,1, 1);
        index = new int[10];
    }

    // Update is called once per frame
    void Update()
    {
        Text chr_text = chrtext.GetComponent<Text>();
        Font txfont = Resources.Load<Font>("Font/" + fonx[textti.fox]);
        TMP_FontAsset  txfontp = Resources.Load<TMP_FontAsset >("Font/" + fonx[textti.fox]);
        Material txfontm = Resources.Load<Material>("Font/" + fonx[textti.fox] + " Atlas Material");
        text_object.fontSize = textti.fsi;
        chr_text.font = txfont;
        text_object.font = txfontp;
        text_object.material = txfontm;
        hazimarif = Bgcontroller.hazimarif;
        hazimaritt = Bgcontroller.hazimaritt;
        hazimaritm = Bgcontroller.hazimaritm;
        hazimarief = Bgcontroller.hazimarief;
        bgcf = Bgcontroller.bgcf;
        bgcdf = Bgcontroller.bgcdf;
        fadef=Bgcontroller.fadef;
        loadflag = Load.loadflag;
        script = GameObject.Find("textti").GetComponent<textti>();
        int nexts = anim.GetInteger("nextst");
        nexts = textti.nextst;
        if (loadflag >= 2 & loadflag < 3)
        {autoflag = 0;
        auto = 0;
            chrmsx = 0;
            kx = 0;
            kmx = 0;
            antennum = 0;

            tnumhantei = 1;
            tanitime = 0;
            
        }
        
        if (loadflag == 3)
        {
            tnumhantei = 1;
            if (atx >= 1 & tnum > autotx[atx])
            {
                atx += 1;
            }
            else
            {
                automax = 120 + 10 * atx;
            }


            if (hazimarif > 0)
            {
                automax = 200;
            }
        }
        if (tnumhantei==1)
        {
            
            tnumflag += 1;
        }
        loadflag = Load.loadflag;

        int animtf = 0;
        Outline chrli = chrline.GetComponent<Outline>();
        if (script.name[text_num] != "" & script.name[text_num] != null)
        {
            names = script.name[text_num].Length;
        }
        if (names > 0& script.name[text_num]!="#NONE"& script.name[text_num] != "" & script.name[text_num] != null)
        {
            chrpanel.SetActive(true);
            chr_text.fontSize = 35;
            if (index[6] > 7 & chr_text.fontSize == 35)
            {
                chr_text.fontSize = 35 - 5 * (names);
            }
            ColorUtility.TryParseHtmlString("#" + script.color[text_num], out chrcolor);
            ColorUtility.TryParseHtmlString("#" + script.ocolor[text_num], out Color chrocolor);
            chr_text.color=chrcolor;
            chrli.effectColor = chrocolor;
            chr_text.text = script.name[text_num];
        }
        else
        {
            chr_text.text = "";
            chrpanel.SetActive(false);
        }

        if (tnumf == 0)
        {
                texthm = script.textho[text_num];
        }
        if (texthm.StartsWith("「") == true) {textho=texthm.Replace("/", "\n　"); } else {textho=texthm.Replace("/", "\n"); }
        tnum = textho.Length;

        

        if (hazimarif>=1)
        {
            tnumf = tnum;
        }



        if (Bgcontroller.mwxf == 0 & (tnum >= tnumf) & (tnumhantei == 1))
        {

            autogage.SetActive(false);
            this.next_object.SetActive(false);
            if (tnumf == 0)
            {

                text_object.text = "";
                if (animtf >= 1)
                {

                    atnumf = 0;
                    kx = 0;
                    chrcontroller.kf = 1;
                    chrcontroller.mabatakif = 0;
                }
                if (animtf == 0)
                {
                    atnumf = 0;
                    chrcontroller.kf = 0;
                    chrcontroller.mabatakif = 2;
                }
            }

            texttx += texttv;

            if (texttx > textti.texttime)
            {

                tnumf += 1;
                if (tnumf <= tnum)
                {
                    TextMeshProUGUI te = text_object.GetComponent<TextMeshProUGUI>();
                    te.outlineColor = new Color(0, 0, 0, 1);
                    if (tnumf < 2)
                    {
                        texts = textho.Substring(0, tnumf);
                    }
                    if (tnumf == 2)
                    {
                        texts = textho.Substring(0, tnumf - 1) + "<alpha=#80>" + "" + textho.Substring(tnumf - 1, 1);
                    }
                    if (tnumf == 3)
                    {
                        texts = textho.Substring(0, tnumf - 2) + "<alpha=#80>" + "" + textho.Substring(tnumf - 2, 1) + "<alpha=#60>" + "" + textho.Substring(tnumf - 1, 1);
                    }
                    if (tnumf == 4)
                    {
                        texts = textho.Substring(0, tnumf - 3) + "<alpha=#80>" + "" + textho.Substring(tnumf - 3, 1) + "<alpha=#60>" + textho.Substring(tnumf - 2, 1) + "<alpha=#40>" + "" + textho.Substring(tnumf - 1, 1);
                    }
                    if (tnumf >= 5)
                    {
                        texts = textho.Substring(0, tnumf - 4) + "<alpha=#80>" + "" + textho.Substring(tnumf - 4, 1) + "<alpha=#60>" + textho.Substring(tnumf - 3, 1) + "<alpha=#40>" + "" + textho.Substring(tnumf - 2, 1) + "<alpha=#20>" + "" + textho.Substring(tnumf - 1, 1);
                    }
                    if (tnumf > tnum - 5)
                    {
                        texts = textho;
                    }
                }
                text_object.text = texts;
                texttx = 0;
            }

            if (tnumf >= 1 & tnumf == tnum)
            {
                text_object.text = texts;
            }
            TextMeshProUGUI te2 = text_object.GetComponent<TextMeshProUGUI>();
            ColorUtility.TryParseHtmlString("#" + script.color[text_num], out chrcolor);
            ColorUtility.TryParseHtmlString("#" + script.ocolor[text_num], out Color chrocolor);
            te2.color = chrcolor;
            te2.outlineColor = chrocolor;

            if (bgcf > 0 | bgcdf > 0 | fadef > 0 | antenhantei > 0)
            {

                tnumf = 0;
            }
            if (bgcdf > 0 | fadef > 0 | antenhantei > 0)
            {

                text_object.text = "";
            }
            tnumflag = 0;
        }
        if (hazimaritt>=2)
        {
            text_object.text = script.text[text_num].Substring(index[3]);
        }
        hazimarihantei = Bgcontroller.hazimarihantei;
        if (tnum < tnumf)
        {
            if ((chrcontroller.chrcf == 4 | chrcontroller.unazf == 3 | chrcontroller.arrivef == 3 | chrcontroller.odorokif == 3|chrcontroller.daruf == 3| chrcontroller.okiagarif == 3))
            {
                tnumhantei = 2;
                
            }
            else
            {
                next_object.SetActive(true);
                tnumhantei = 0;
               
            }
            
            tnumf = 0;

        }
        if (tnumhantei==2)
        {
            tnumfa += 1;
        }
        if (tnumhantei==2& (chrcontroller.chrcf != 4 & chrcontroller.unazf != 3 & chrcontroller.arrivef != 3 & chrcontroller.odorokif != 3& chrcontroller.daruf != 3&chrcontroller.okiagarif != 3))
        {
            next_object.SetActive(true);
            tnumhantei = 0;
         
            tnumfa = 0;
        }
      if (antenhantei==1|chrcontroller.chsf==1|chrcontroller.animf==0)
        {
            kx = 0;
            atnumf = 0;
            atexttex = 0;
        }
        if (chrcontroller.kf ==1&chrcontroller.chsf==0&chrcontroller.mabatakif==0)
        {
            tanimtime = 1;
            if (tanitime == 0)
            {
                atexttex += Time.deltaTime;
                if (atnumf < tnum & atexttex >= 0.1f)
                {
                    if (tanif == "、" | tanif == "。")
                    {
                        tanitime = 0.01f;
                    }
                    atnumf += 1;
                    atexttex = 0;
                }
                kmx = 0.1f * tnum;
            }
            else
            {
                atexttex = 0;
            }
           
            if (atnumf > 0)
            {
                tanif = script.text[text_num].Substring(index[3]+atnumf - 1, 1);
            }
          
            if (tanitime>0&tanitime<=tanimtime)
            {
                tanitime += Time.deltaTime;
            }
            else
            {
                tanitime = 0;
            }
            if (kmx > kx & tanitime == 0)
            {
                kx += Time.deltaTime;
            }
            if (kmx<=kx)
            {
                atnumf = 0;
                atexttex=0;
                kx = 0;
                chrcontroller.mabatakif = 1;
            }
        }

        if (hazimarif==0&tnum>autotx[atx])
        {
            atx += 1;
        }
        else
        {
            automax=120+atx*10;
        }
        
        if (hazimarif>0)
        {
            automax = 200;
        }
        
        autow = auto / automax;
        if ((Input.GetKeyDown(KeyCode.Space))|(autow>=1))
        {
            canif = 1;

            if ((hazimarif==0&autow>0)|(hazimarif==0&tnumhantei == 0 & next_object == true))
            {
                text_num += 1;
            }
            else
            {
                text_object.text = textho;
                tnumf = tnum+1;

            }
            if (hazimarif >= 1&hazimaritt<=0)
            {

                Bgcontroller.hazimaritt = 1;
                Bgcontroller.hazimaritm = 1;
            }
            auto = 0;
            
            autogage.SetActive(false);
            tnumhantei = 1;
        }
       
      
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            sound.soundflag = 3;
            Text tex = bt2.GetComponent<Text>();
            tex.GetComponent<Text>().color = new Color(255, 255, 255, 255);
          
            autoY.SetActive(false);
            autoN.SetActive(true);
            
            autoflag = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Text tex = bt3.GetComponent<Text>();
            tex.GetComponent<Text>().color = new Color(255, 255, 255, 255);
      
            autoflag = 0;
            autogage.SetActive(false);
            
            autoY.SetActive(true);
            autoN.SetActive(false);
            
        }
        if (configmenu.mwxfc ==0&Input.GetKeyDown(KeyCode.C))
        {
            sound.soundflag = 1;
            config.SetActive(true);

            Bgcontroller.mwxf = -1;
            configmenu.mwxfc = 1;
            configmenu.mwxc = 0;
        }
        if (antenhantei <= 0 & text_num > 0 & hazimaritt <= 0 & Input.GetKeyDown(KeyCode.UpArrow))
        {
            sound.soundflag = 1;
            bt.SetActive(false);

            Image mw = LOG.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0);
            Image msw = LOG.GetComponent<Image>();
            msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
            LOG.SetActive(true);
            LOGtext.mwxfl = 1;
            Bgcontroller.mwxf = -1;
            nexttext.SetActive(true);
            gpointerevent.logflag = 1;
        }
        if (antenhantei <= 0 &hazimaritt<=0& Input.GetKeyDown(KeyCode.LeftControl))
        {
            sound.soundflag = 1;
            Bgcontroller.mwxf = -1;
            Image msw = savepanel.GetComponent<Image>();
            msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
            savepanel.SetActive(true);
            SaveManager.mwxfs = 1;
            bt.SetActive(false);
        }
        if (antenhantei <= 0 & hazimaritt <= 0 & Input.GetKeyDown(KeyCode.RightControl))
        {
            sound.soundflag = 1;
            Bgcontroller.mwxf = -1;
            Image msw = loadpanel.GetComponent<Image>();
            msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
            loadpanel.SetActive(true);
            Load.mwxfl = 1;
            bt.SetActive(false);
        }
        
        if (tnumhantei==0&loadflag<=0&Input.GetKeyDown(KeyCode.S))
        {
            sound.soundflag = 2;
            nowtime = DateTime.Now;
            st = nowtime.ToString();
            if (saveload.savef == 0)
            {
                text_num = TextManager.text_num;

                PlayerPrefs.SetInt("Dataq"+textti.loaddata, text_num);

                PlayerPrefs.Save();
                PlayerPrefs.SetString("DataqT"+textti.loaddata, st);

                PlayerPrefs.Save();
                PlayerPrefs.SetString("DataqTE"+textti.loaddata, script.textho[text_num]);

                PlayerPrefs.Save();
                saveload.savesname = "quick";
                sl.Save();

                qsf = 1;
            }
            

        }
        if (qsf>=1&qstime<=100)
        {
            qsh.SetActive(true);
            qstime += 1;
        }
        if (qstime>100)
        {
            qsh.SetActive(false);
            qstime = 0;
            qsf = 0;
        }
        if (hazimarif<=0&antenhantei<=0&loadflag<=0&tnumhantei==0&Input.GetKeyDown(KeyCode.L)| tnumhantei==0&hazimarif>=1&antenhantei<=0&loadflag<=0&hazimaritt<=0& Input.GetKeyDown(KeyCode.L))
        {
            if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + "quick.json"))
            {
                sound.soundflag = 4;
                saveload.savesname = "quick";
                Load.loadflag = 1;
                qlf = 1;
                TextManager.antenhantei = 1;

                auto = 0;
                autoflag = 0;
                autogage.SetActive(false);

                autoY.SetActive(true);
                autoN.SetActive(false);
            }
            else
            {
                sound.soundflag = 7;
            }
                
            
           
        }
        if (Load.loadflag >= 1)
        {
            auto = 0;
            autoflag = 0;
            autogage.SetActive(false);

            autoY.SetActive(true);
            autoN.SetActive(false);
        }
        if (antenhantei<=0&qlf >= 1 & qltime <= 100)
        {
            qlh.SetActive(true);
            qltime += 1;
        }
        if ((antenhantei<=0&qltime > 100)| (bgcdf > 0 | bgcf > 0 | fadef > 0))
        {
            qlh.SetActive(false);
            qltime = 0;
            qlf = 0;
        }
        if (antenhantei<=0&hazimaritt<=0&Input.GetKeyDown(KeyCode.Escape))
        {
            sound.soundflag = 1;
            gpointerevent.mwxf = 1;
            gpointerevent.px = 1;
            nexttext.SetActive(false);
        }
        if (antenhantei <= 0 & hazimaritt <= 0 & Input.GetKeyDown(KeyCode.Delete))
        {
            sound.soundflag = 1;
            gpointerevent.mwxf = 1;
            gpointerevent.px = 2;
            nexttext.SetActive(false);
        }
        if (Input.GetKey(KeyCode.J))
        {
            text_num += 1;

            text_object.text = textho;
        }
        if (hazimaritt==0&autoflag == 1&tnumhantei==0)
        {
            autogage.SetActive(true);
            auto += textti.autott;
            Slider autog = autogage.GetComponent<Slider>();
            autog.value =(float)auto / (float)automax;
        }
        else
        {
            auto = 0;
        }
        anim.SetInteger("nextst", nexts);



    }

    public void Onclick()
    {
        canif = 1;

        if (hazimarif < 1&tnumhantei==0&next_object==true)
        {
            
                text_num += 1;
        }
       else
        {
            text_object.text = textho;
            tnumf = tnum+1;
        }
        auto = 0;
        tnumhantei = 1;
        if (hazimarif>=1&hazimaritt<=0)
        {
            
            Bgcontroller.hazimaritt = 1;
            Bgcontroller.hazimaritm = 1;
        }
    }

}
