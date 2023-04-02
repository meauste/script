using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class tload1 : MonoBehaviour
{
    public int text_num;
    public string text_lnum;
    public int loadflag;
    public int tloadflag;
    public int tnumf;
    public static int loadpage;
    public static int mwxftl;
    public saveload sl;
    public float mwxl;
    public string load1;
    public string loadpagew;
    public Text loadpaget;
    public Text load1t;
    public Text load1b;
    public string load2;
    public Text load2t;
    public Text load2b;
    public string load2at;
    public string load3;
    public Text load3t;
    public Text load3b;
    public string load3at;
    public string load4;
    public Text load4t;
    public Text load4b;
    public string load4at;
    public string load5;
    public Text load5t;
    public Text load5b;
    public string load5at;
    public string load6;
    public Text load6t;
    public Text load6b;
    public string load6at;
    public static string load1text;
    public static string load2text;
    public static string load3text;
    public static string load4text;
    public static string load5text;
    public static string load6text;
    public Text loadkt;
    public GameObject Loadp;
    textt script;
    public int chapsx;
    public static int chapsf;
    public int chapshantei;
    Bgcontroller script2;
    public Text loadet;
    public Text loadeb;
    public Text loadqt;
    public Text loadqb;
    public GameObject s1n;
    public GameObject s2n;
    public GameObject s3n;
    public GameObject s4n;
    public GameObject s5n;
    public GameObject s6n;
    public InputField kensaku;
    public string kex;
    public int kexl;
    public int page;
    public string st;

    public GameObject stime;
    public GameObject stime2;
    public GameObject stime3;
    public GameObject stime4;
    public GameObject stime5;
    public GameObject stime6;
    public GameObject stimeq;
    public GameObject stimee;
    public string load1at;
    public void Start()
    {
        if (tloadflag >= 1)
        {
            loadflag = 1;
            TextManager.antenhantei = 1;
        }
        loadpage = 1;
    }
    public void Update()
    {
        
        tloadflag = tloadco.tloadflag;
         InputField inputField = kensaku.GetComponent<InputField>();
        kex = inputField.text;
        kexl = kex.Length;
        if (kex.StartsWith("P:")== true & kexl >= 3)
        {
            if (kex.Substring(2).All(char.IsDigit) == true)
            {
                int pagek = int.Parse(kex.Substring(2));
                if (page <= 500)
                {
                    loadpage = pagek;
                    loadkt.text = "検索結果を表示";
                }
                else
                {
                    loadkt.text = "検索結果なし";
                }
            }
            else
            {
                loadkt.text = "検索結果なし";
            }
        }
        if (kex.All(char.IsDigit)==true & kexl > 0)
        {
            int pagew = int.Parse(kex) % 6;
            if (pagew == 0)
            {
                page = int.Parse(kex) / 6;
            }
            else
            {
                page = int.Parse(kex) / 6 + 1;
            }
            if (page <= 500)
            {
                loadpage = page;
                loadkt.text = "検索結果を表示";
            }
            else
            {
                loadpage = 500;
                loadkt.text = "検索結果なし";
            }
        }
        if (kex==null|kex=="")
        {
            loadkt.text = "セーブ検索";
        }
        if ((mwxl < 0.9f & mwxftl == 1))
        {



            if (mwxl <= 0.32f)
            {
                Image msw = Loadp.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
            }

            Image mw = Loadp.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);



            mwxl += 0.08f;
            if (mwxl > 0.75f)
            {
                Image mwf = Loadp.GetComponent<Image>();
                mwf.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);
                mwxftl = 0;
                mwxl = 0;
            }

        }
        if (tloadflag >= 1)
        {
            loadflag = 1;
            TextManager.antenhantei = 1;
        }
        if (loadpage < 1)
        {
            loadpage = 500;
        }
        loadpagew = loadpage.ToString();
        Text text_text = loadpaget.GetComponent<Text>();
        text_text.text = loadpagew;

        load1 = "DATA"+textti.loaddata + (loadpage * 6 - 5);
        load1at = "DATAT"+textti.loaddata + (loadpage * 6 - 5);
        load1text = "DATATE" + textti.loaddata + (loadpage * 6 - 5);
        Text l1text = load1b.GetComponent<Text>();
        l1text.text = "DATA" + (loadpage * 6 - 5);
        if (PlayerPrefs.HasKey(load1))
        {
            Text l1textlt = stime.GetComponent<Text>();
            st = PlayerPrefs.GetString(load1at);
            l1textlt.text = st;
            Text l1textl = load1t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load1);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load1text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l1textl.text = text.Substring(0,19) + "…";
            }
            else
            {
                l1textl.text =text;
            }
            if (PlayerPrefs.HasKey(load1)&textt.s1nf == 1 & loadpage == SaveManager.s1nfl)
            {
                Image bgcdbfas = s1n.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
            }
            else
            {
                Image bgcdbfas = s1n.GetComponent<Image>();
                bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
            }

        }
        else
        {
            Text l1atext = load1t.GetComponent<Text>();
            l1atext.text = "empty";
            Text l1atex = stime.GetComponent<Text>();
            l1atex.text = "";
        }
        load2 = "DATA"+textti.loaddata + (loadpage * 6 - 4);
        load2at = "DATAT"+textti.loaddata + (loadpage * 6 - 4);
        load2text = "DATATE" + textti.loaddata + (loadpage * 6 - 4);
        Text l2text = load2b.GetComponent<Text>();
        l2text.text = "DATA" + (loadpage * 6 - 4);
        if (PlayerPrefs.HasKey(load2))
        {
            Text l2textlt = stime2.GetComponent<Text>();
            st = PlayerPrefs.GetString(load2at);
            l2textlt.text = st;
            Text l2textl = load2t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load2);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load2text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l2textl.text = text.Substring(0,19)+"…";
            }
            else
            {
                l2textl.text = text;
            }
        }
        else
        {
            Text l2atext = load2t.GetComponent<Text>();
            l2atext.text = "empty";
            Text l2atex = stime2.GetComponent<Text>();
            l2atex.text = "";
        }
        if (PlayerPrefs.HasKey(load2)&textt.s1nf == 2 & loadpage == SaveManager.s2nf)
        {
            Image bgcdbfas = s2n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s2n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        load3 = "DATA"+textti.loaddata + (loadpage * 6 - 3);
        load3at = "DATAT"+textti.loaddata + (loadpage * 6 - 3);
        load3text = "DATATE" + textti.loaddata + (loadpage * 6 - 3);
        Text l3text = load3b.GetComponent<Text>();
        l3text.text = "DATA" + (loadpage * 6 - 3);
        if (PlayerPrefs.HasKey(load3))
        {
            Text l3textlt = stime3.GetComponent<Text>();
            st = PlayerPrefs.GetString(load3at);
            l3textlt.text = st;
            Text l3textl = load3t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load3);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load3text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l3textl.text = text.Substring(0,19)+"…";
            }
            else
            {
                l3textl.text = text;
            }
        }
        else
        {
            Text l3atext = load3t.GetComponent<Text>();
            l3atext.text = "empty";
            Text l3atex = stime3.GetComponent<Text>();
            l3atex.text = "";
        }
        if (PlayerPrefs.HasKey(load3)&textt.s1nf == 3 & loadpage == SaveManager.s3nf)
        {
            Image bgcdbfas = s3n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s3n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        load4 = "DATA"+textti.loaddata + (loadpage * 6 - 2);
        load4at = "DATAT"+textti.loaddata + (loadpage * 6 - 2);
        load4text = "DATATE" + textti.loaddata + (loadpage * 6 - 2);
        Text l4text = load4b.GetComponent<Text>();
        l4text.text = "DATA" + (loadpage * 6 - 2);
        if (PlayerPrefs.HasKey(load4))
        {
            Text l4textlt = stime4.GetComponent<Text>();
            st = PlayerPrefs.GetString(load4at);
            l4textlt.text = st;
            Text l4textl = load4t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load4);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load4text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l4textl.text = text.Substring(0,19)+"…";
            }
            else
            {
                l4textl.text = text;
            }
        }
        else
        {
            Text l4atext = load4t.GetComponent<Text>();
            l4atext.text = "empty";
            Text l4atex = stime4.GetComponent<Text>();
            l4atex.text = "";
        }
        if (PlayerPrefs.HasKey(load4)&textt.s1nf == 4 & loadpage == SaveManager.s4nf)
        {
            Image bgcdbfas = s4n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s4n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        load5 = "DATA"+textti.loaddata + (loadpage * 6 - 1);
        load5at = "DATAT"+textti.loaddata + (loadpage * 6 - 1);
        load5text = "DATATE" + textti.loaddata + (loadpage * 6 - 1);
        Text l5text = load5b.GetComponent<Text>();
        l5text.text = "DATA" + (loadpage * 6 - 1);
        if (PlayerPrefs.HasKey(load5))
        {
            Text l5textlt = stime5.GetComponent<Text>();
            st = PlayerPrefs.GetString(load5at);
            l5textlt.text = st;
            Text l5textl = load5t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load5);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load5text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l5textl.text = text.Substring(0,19)+"…";
            }
            else
            {
                l5textl.text = text;
            }
        }
        else
        {
            Text l5atext = load5t.GetComponent<Text>();
            l5atext.text = "empty";
            Text l5atex = stime5.GetComponent<Text>();
            l5atex.text = "";
        }
        if (PlayerPrefs.HasKey(load5)&textt.s1nf == 5 & loadpage == SaveManager.s5nf)
        {
            Image bgcdbfas = s5n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s5n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        load6 = "DATA"+textti.loaddata + (loadpage * 6);
        load6at = "DATAT"+textti.loaddata + (loadpage * 6);
        load6text = "DATATE" + textti.loaddata + (loadpage * 6);
        Text l6text = load6b.GetComponent<Text>();
        l6text.text = "DATA" + (loadpage * 6);
        if (PlayerPrefs.HasKey(load6))
        {
            Text l6textlt = stime6.GetComponent<Text>();
            st = PlayerPrefs.GetString(load6at);
            l6textlt.text = st;
            Text l6textl = load6t.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt(load6);
            text_lnum = text_num.ToString();
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString(load6text);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                l6textl.text = text.Substring(0,19)+"…";
            }
            else
            {
                l6textl.text = text;
            }
        }
        else
        {
            Text l6atext = load6t.GetComponent<Text>();
            l6atext.text = "empty";
            Text l6atex = stime6.GetComponent<Text>();
            l6atex.text = "";
        }
        if (PlayerPrefs.HasKey(load6)&textt.s1nf == 6 & loadpage == SaveManager.s6nf)
        {
            Image bgcdbfas = s6n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s6n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        Text lqatext = loadqb.GetComponent<Text>();
        lqatext.text = "Quick Save";

        if (PlayerPrefs.HasKey("Dataq"+textti.loaddata))
        {
            Text lqtextltt = stimeq.GetComponent<Text>();
            st = PlayerPrefs.GetString("DataqT"+textti.loaddata);
            lqtextltt.text = st;
            Text lqtextl = loadqt.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt("Dataq"+textti.loaddata);
            text_lnum = text_num.ToString();

            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString("DataqTE" + textti.loaddata);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                lqtextl.text = text.Substring(0, 19) + "…";
            }
            else
            {
                lqtextl.text = text;
            }

        }
        else
        {
            Text lqtext = loadqt.GetComponent<Text>();
            lqtext.text = "empty";
            Text lqatex = stimeq.GetComponent<Text>();
            lqatex.text = "";
        }
        Text leatext = loadeb.GetComponent<Text>();
        leatext.text = "End Save";
        if (PlayerPrefs.HasKey("Datae"+textti.loaddata))
        {
            Text letextl = loadet.GetComponent<Text>();
            text_num = PlayerPrefs.GetInt("Datae"+textti.loaddata);
            text_lnum = text_num.ToString();
            Text letextlt = stimee.GetComponent<Text>();
            st = PlayerPrefs.GetString("DataeT"+textti.loaddata);
            letextlt.text = st;
            script = GameObject.Find("textt").GetComponent<textt>();
            string text = PlayerPrefs.GetString("DataeTE" + textti.loaddata);
            int tnum = text.Length;
            if (tnum >= 20)
            {
                letextl.text = text.Substring(0,19)+"…";
            }
            else
            {
                letextl.text = text;
            }


        }
        else
        {
            Text letext = loadet.GetComponent<Text>();
            letext.text = "empty";
            Text leatex = stimee.GetComponent<Text>();
            leatex.text = "";
        }
    }
}