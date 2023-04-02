using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
public class SaveManager : MonoBehaviour
{
    public GameObject Save;
    public GameObject SavePanel;
    public GameObject Savemae;
    public GameObject nexttext;
    public int text_num;
    public string text_lnum;
    public int bgx;
    public static int mwxfs;
    public float mwxs;
    public int chapsx;
    public int chapsf;
    public int chapshantei;
    public static int s1nf;
    public static int s1nfl;
    public static string save1;
    public string savepagew;
    public Text savepaget;
    public Text save1a;
    public Text save1t;
    public GameObject s1n;
    public GameObject savep;
    public saveload sl;
    public static string save2a;
    public static int s2nf;
    public GameObject s2n;
    public Text save2t;
    public Text save2b;
    public static string save3a;
    public static int s3nf;
    public GameObject s3n;
    public Text save3t;
    public Text save3b;
    public static string save4a;
    public static int s4nf;
    public GameObject s4n;
    public Text save4t;
    public Text save4b;
    public static string save5a;
    public static string save2;
    public static string save3;
    public static string save4;
    public static string save5;
    public static string save6;
    public static string save6a;
    public static string save1text;
    public static string save2text;
    public static string save3text;
    public static string save4text;
    public static string save5text;
    public static string save6text;
    public static int s5nf;
    public GameObject s5n;
    public Text save5t;
    public Text save5b;
    public static int s6nf;
    public GameObject s6n;
    public Text save6t;
    public Text save6b;
    textti script;
    Bgcontroller script2;
    public string st;
    public DateTime nowtime;
    public GameObject stime;
        public GameObject stime2;
        public GameObject stime3;
        public GameObject stime4;
        public GameObject stime5;
        public GameObject stime6;
    public static string save1at;
    public static  string save2at;
    public Text savekt;
        public static string save3at;
    public static  string save4at;
    public static  string save5at;
    public static string save6at;
    public Vector3 sp;
    public int s;
    public InputField kensaku;
    public string kex;
    public int kexl;
    public int page;
 
    public void Start()
    {
      
    }
    public void Update()
    {
        s = saveco.savepage;
        InputField inputField = kensaku.GetComponent<InputField>();
        kex = inputField.text;
        kexl = kex.Length;
        if (kex.StartsWith("P:") == true & kexl >= 3)
        {
            if (kex.Substring(2).All(char.IsDigit) == true)
            {
                int pagek = int.Parse(kex.Substring(2));
                if (page <= 500)
                {
                    saveco.savepage = pagek;
                    savekt.text = "検索結果を表示";
                }
                else
                {
                    savekt.text = "検索結果なし";
                }
            }
            else
            {
                savekt.text = "検索結果なし";
            }
        }
        if (kex.All(char.IsDigit) == true & kexl > 0)
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
                saveco.savepage = page;
                savekt.text = "検索結果を表示";
            }
            else
            {
                saveco.savepage = 500;
                savekt.text = "検索結果なし";
            }
        }
        if (kex == null | kex == "")
        {
            savekt.text = "セーブ検索";
        }
        if ((mwxs < 0.9f & mwxfs == 1))
        {



            if (mwxs <= 0.32f)
            {
                Image msw = savep.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
            }

            Image mw = savep.GetComponent<Image>();
            mw.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);



            mwxs += 0.08f;
            if (mwxs > 0.75f)
            {
                Image mwf = savep.GetComponent<Image>();
                mwf.GetComponent<Image>().color = new Color(255, 255, 255, 0.75f);

                mwxfs = 0;
                mwxs = 0;
            }

        }

        savepagew = saveco.savepage.ToString();
        Text text_text = savepaget.GetComponent<Text>();
        text_text.text = savepagew;
        save1 = "DATA" + textti.loaddata + (saveco.savepage * 6 - 5);
        save1at = "DATAT" + textti.loaddata + (saveco.savepage * 6 - 5);
        save1text = "DATATE" + textti.loaddata + (saveco.savepage * 6 - 5);
        Text l1text = save1a.GetComponent<Text>();
        l1text.text = "DATA" + (saveco.savepage * 6 - 5);
        if (PlayerPrefs.HasKey(save1))
        {
            if (saveload.savef == 0)
            {
                Text l1textl = save1t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save1);
                Text l1textlt = stime.GetComponent<Text>();
                st = PlayerPrefs.GetString(save1at);
                l1textlt.text = st;
                string text = PlayerPrefs.GetString(save1text);
                script = GameObject.Find("textti").GetComponent<textti>();
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l1textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l1textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l1atext = save1t.GetComponent<Text>();
            l1atext.text = "empty";
            Text l1atex = stime.GetComponent<Text>();
            l1atex.text = "";
        }
        if (saveload.savef == 1)
        {
            Text l1textl = save1t.GetComponent<Text>();

            l1textl.text = "セーブ中";
            Text l1textltt = stime.GetComponent<Text>();

            l1textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save1)==true&textti.s1nf == 1 & saveco.savepage == s1nfl & saveload.savef == 0)
        {
            Image bgcdbfas = s1n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s1n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        save2a = "DATA" + textti.loaddata + (saveco.savepage * 6 - 4);
        save2at = "DATAT" + textti.loaddata + (saveco.savepage * 6 - 4);
        save2text = "DATATE" + textti.loaddata + (saveco.savepage * 6 - 4);
        Text l2text = save2b.GetComponent<Text>();
        l2text.text = "DATA" + (saveco.savepage * 6 - 4);
        if (PlayerPrefs.HasKey(save2a))
        {
            if (saveload.savef == 0)
            {
                Text l2textl = save2t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save2a);
                Text l2textlt = stime2.GetComponent<Text>();
                st = PlayerPrefs.GetString(save2at);
                l2textlt.text = st;
                script = GameObject.Find("textti").GetComponent<textti>();
                string text = PlayerPrefs.GetString(save2text);
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l2textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l2textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l2atext = save2t.GetComponent<Text>();
            l2atext.text = "empty";
            Text l2atex = stime2.GetComponent<Text>();
            l2atex.text = "";
        }
        if (saveload.savef == 2)
        {
            Text l2textl = save2t.GetComponent<Text>();

            l2textl.text = "セーブ中";
            Text l2textltt = stime2.GetComponent<Text>();

            l2textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save2a)==true&textti.s1nf == 2 & saveco.savepage == s2nf & saveload.savef == 0)
        {
            Image bgcdbfas = s2n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s2n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        save3a = "DATA" + textti.loaddata + (saveco.savepage * 6 - 3);
        save3at = "DATAT" + textti.loaddata + (saveco.savepage * 6 - 3);
        save3text = "DATATE" + textti.loaddata + (saveco.savepage * 6 - 3);
        Text l3text = save3b.GetComponent<Text>();
        l3text.text = "DATA" + (saveco.savepage * 6 - 3);
        if (PlayerPrefs.HasKey(save3a))
        {
            if (saveload.savef == 0)
            {
                Text l3textl = save3t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save3a);
                Text l3textlt = stime3.GetComponent<Text>();
                st = PlayerPrefs.GetString(save3at);
                l3textlt.text = st;
                script = GameObject.Find("textti").GetComponent<textti>();
                string text = PlayerPrefs.GetString(save3text);
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l3textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l3textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l3atext = save3t.GetComponent<Text>();
            l3atext.text = "empty";
            Text l3atex = stime3.GetComponent<Text>();
            l3atex.text = "";
        }
        if (saveload.savef == 3)
        {
            Text l3textl = save3t.GetComponent<Text>();

            l3textl.text = "セーブ中";
            Text l3textltt = stime3.GetComponent<Text>();

            l3textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save3a)==true&textti.s1nf == 3 & saveco.savepage == s3nf & saveload.savef == 0)
        {
            Image bgcdbfas = s3n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s3n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        save4a = "DATA" + textti.loaddata + (saveco.savepage * 6 - 2);
        save4at = "DATAT" + textti.loaddata + (saveco.savepage * 6 - 2);
        save4text = "DATATE" + textti.loaddata + (saveco.savepage * 6 - 2);
        Text l4text = save4b.GetComponent<Text>();
        l4text.text = "DATA" + (saveco.savepage * 6 - 2);
        if (PlayerPrefs.HasKey(save4a))
        {
            if (saveload.savef == 0)
            {
                Text l4textl = save4t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save4a);
                Text l4textlt = stime4.GetComponent<Text>();
                st = PlayerPrefs.GetString(save4at);
                l4textlt.text = st;
                script = GameObject.Find("textti").GetComponent<textti>();
                 string text = PlayerPrefs.GetString(save4text);
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l4textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l4textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l4atext = save4t.GetComponent<Text>();
            l4atext.text = "empty";
            Text l4atex = stime4.GetComponent<Text>();
            l4atex.text = "";
        }
        if (saveload.savef == 4)
        {
            Text l4textl = save4t.GetComponent<Text>();

            l4textl.text = "セーブ中";
            Text l4textltt = stime4.GetComponent<Text>();

            l4textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save4a)==true&textti.s1nf == 4 & saveco.savepage == s4nf & saveload.savef == 0)
        {
            Image bgcdbfas = s4n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s4n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        save5a = "DATA" + textti.loaddata + (saveco.savepage * 6 - 1);
        save5at = "DATAT" + textti.loaddata + (saveco.savepage * 6 - 1);
        save5text = "DATATE" + textti.loaddata + (saveco.savepage * 6 - 1);
        Text l5text = save5b.GetComponent<Text>();
        l5text.text = "DATA" + (saveco.savepage * 6 - 1);
        if (PlayerPrefs.HasKey(save5a))
        {
            if (saveload.savef == 0)
            {
                Text l5textl = save5t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save5a);
                Text l5textlt = stime5.GetComponent<Text>();
                st = PlayerPrefs.GetString(save5at);
                l5textlt.text = st;
                script = GameObject.Find("textti").GetComponent<textti>();
                string text = PlayerPrefs.GetString(save5text);
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l5textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l5textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l5atext = save5t.GetComponent<Text>();
            l5atext.text = "empty";
            Text l5atex = stime5.GetComponent<Text>();
            l5atex.text = "";
        }
        if (saveload.savef == 5)
        {
            Text l5textl = save5t.GetComponent<Text>();

            l5textl.text = "セーブ中";
            Text l5textltt = stime5.GetComponent<Text>();

            l5textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save5a)==true&textti.s1nf == 5 & saveco.savepage == s5nf & saveload.savef == 0)
        {
            Image bgcdbfas = s5n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s5n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
        save6a = "DATA" + textti.loaddata + (saveco.savepage * 6);
        save6at = "DATAT" + textti.loaddata + (saveco.savepage * 6);
        save6text = "DATATE" + textti.loaddata + (saveco.savepage * 6);
        Text l6text = save6b.GetComponent<Text>();
        l6text.text = "DATA" + (saveco.savepage * 6);
        if (PlayerPrefs.HasKey(save6a))
        {
            if (saveload.savef == 0)
            {
                Text l6textl = save6t.GetComponent<Text>();
                text_num = PlayerPrefs.GetInt(save6a);
                Text l6textlt = stime6.GetComponent<Text>();
                st = PlayerPrefs.GetString(save6at);
                l6textlt.text = st;
                script = GameObject.Find("textti").GetComponent<textti>();
                string text = PlayerPrefs.GetString(save6text);
                int tnum = text.Length;
                if (tnum >= 20)
                {
                    l6textl.text = text.Substring(1,19)+"…";
                }
                else
                {
                    l6textl.text = text;
                }
                script2 = GameObject.Find("Bg").GetComponent<Bgcontroller>();
            }

        }
        else
        {
            Text l6atext = save6t.GetComponent<Text>();
            l6atext.text = "empty";
            Text l6atex = stime6.GetComponent<Text>();
            l6atex.text = "";
        }
        if (saveload.savef == 6)
        {
            Text l6textl = save6t.GetComponent<Text>();

            l6textl.text = "セーブ中";
            Text l6textltt = stime6.GetComponent<Text>();

            l6textltt.text = "";
        }
        if (PlayerPrefs.HasKey(save6a)==true&textti.s1nf == 6 & saveco.savepage == s6nf & saveload.savef == 0)
        {
            Image bgcdbfas = s6n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "new");
        }
        else
        {
            Image bgcdbfas = s6n.GetComponent<Image>();
            bgcdbfas.sprite = Resources.Load<Sprite>("UI/" + "transparent");
        }
    }
}