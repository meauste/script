using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static int antenthantei;
    public static int antent;
    public static int titlebx;
    public int titlebhantei;
    public int titlef;
    public int titlehantei;
    public static int tmwxf;
    public string[] jsonname;
    public static int jsons;
    public float tmwx;
    public int endtflag = tpointerenter.endtflag;
    public static int gamelogohantei;
    public AudioClip[] clipes;
    public AudioSource audioes;
    public Image text;
    public Image text2;
    public Image text3;
    public Image text4;
    public Image text5;
    public GameObject specialm;
    public GameObject configm;
    public GameObject tload;
    public saveloadc slc;
    public void Start()
    {
        gamelogohantei = -2;
        antenthantei = 2;
        titlebx = -1;
        tpointerenter.tmwxf = 0;
        tmwx = 0;
        slc.Load();
    }
    public int text_num;
    // Start is called before the first frame update
    public void Update()
    {
        if (jsons == 0)
        {
            string jsonPath = Application.dataPath + "/SAVEDATA/json/whole/";
            string[] jsonnamem = Directory.GetFiles(jsonPath);
            jsonname = System.Array.FindAll(jsonnamem, t => t.Contains(".meta") == false);
            jsons = jsonname.Length;
        }
        titlehantei = titlebg.titlehantei;
        if (tpointerenter.endf <= 0&tpointerenter.tloadf<=0&antenthantei <=0&titlehantei>0&titlebx>0&titlebhantei<=0&Input.GetKey(KeyCode.UpArrow))
        {
            titlebx -= 1;
            audioes.clip = clipes[0];
            audioes.Play();
            titlebhantei = 1;
        }
        if (tpointerenter.endf<=0&tpointerenter.tloadf<=0&antenthantei <= 0&titlehantei>0&titlebx>0&titlebhantei<=0&Input.GetKey(KeyCode.DownArrow))
        {
            titlebx += 1;
            audioes.clip = clipes[0];
            audioes.Play();
            titlebhantei =1;
        }
        if ((tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0) &(antenthantei<=0&titlehantei>0&titlebx < 0&titlebhantei<=0& Input.GetKey(KeyCode.UpArrow)) | (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0) & (antenthantei<=0&titlehantei>0&titlebx < 0&titlebhantei<=0 & Input.GetKey(KeyCode.DownArrow)))
        {
            titlebx = 1;
            audioes.clip = clipes[0];
            audioes.Play();
            titlebhantei = 1;
        }
        if (titlebx<0)
        {

          
            text.sprite =Resources.Load<Sprite>("UI/button1a");
            text2.sprite = Resources.Load<Sprite>("UI/"+"button2a");
            text3.sprite = Resources.Load<Sprite>("UI/button3a");
            text4.sprite = Resources.Load<Sprite>("UI/button4a");
            text5.sprite = Resources.Load<Sprite>("UI/button5a");
        }
        if (antenthantei==0&titlebx==1)
        {
            text.sprite = Resources.Load<Sprite>("UI/button1b");
            text2.sprite = Resources.Load<Sprite>("UI/button2a");
            text3.sprite = Resources.Load<Sprite>("UI/button3a");
            text4.sprite = Resources.Load<Sprite>("UI/button4a");
            text5.sprite = Resources.Load<Sprite>("UI/button5a");
            if (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0 & Input.GetKey(KeyCode.Return) & jsonname.Length > 0 & textti.loaddata != "" & textti.loaddata != null)
                    {
                titlebx = -1;
                text_num = TextManager.text_num = 0;
                audioes.clip = clipes[1];
                audioes.Play();
                antenthantei = 1;
                tpointerenter.tmwxf= 1;
            }
        }
        if (titlebx==2)
        {
            text.sprite = Resources.Load<Sprite>("UI/button1a");
            text2.sprite = Resources.Load<Sprite>("UI/button2b");
            text3.sprite = Resources.Load<Sprite>("UI/button3a");
            text4.sprite = Resources.Load<Sprite>("UI/button4a");
            text5.sprite = Resources.Load<Sprite>("UI/button5a");
            if (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0 & Input.GetKey(KeyCode.Return) & jsonname.Length > 0 & textti.loaddata != "" & textti.loaddata != null)
                    {
                
                tpointerenter.tloadf = 1;
                audioes.clip = clipes[1];
                audioes.Play();
                tload.SetActive(true);
                Image msw = tload.GetComponent<Image>();
                msw.GetComponent<Image>().transform.Translate(0, -0.5f, 0);
                tload1.mwxftl = 1;


            }
        }
        if (titlebx == 3)
        {
            text.sprite = Resources.Load<Sprite>("UI/button1a");
            text2.sprite = Resources.Load<Sprite>("UI/button2a");
            text3.sprite = Resources.Load<Sprite>("UI/button3a");
            text4.sprite = Resources.Load<Sprite>("UI/button4b");
            text5.sprite = Resources.Load<Sprite>("UI/button5a");
            if (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0 & Input.GetKey(KeyCode.Return))
            {
               
                audioes.clip = clipes[1];
                audioes.Play();
                specialm.SetActive(true);
               


            }
        }

        if (titlebx == 4)
        {
            text.sprite = Resources.Load<Sprite>("UI/button1a");
            text2.sprite = Resources.Load<Sprite>("UI/button2a");
            text3.sprite = Resources.Load<Sprite>("UI/button3a");
            text4.sprite = Resources.Load<Sprite>("UI/button4a");
            text5.sprite = Resources.Load<Sprite>("UI/button5b");
            if (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0 & Input.GetKey(KeyCode.Return))
            {

                audioes.clip = clipes[1];
                audioes.Play();
                configm.SetActive(true);



            }
        }
        if (titlebx ==5)
        {
            text.sprite = Resources.Load<Sprite>("UI/button1a");
            text2.sprite = Resources.Load<Sprite>("UI/button2a");
            text3.sprite = Resources.Load<Sprite>("UI/button3b");
            text4.sprite = Resources.Load<Sprite>("UI/button4a");
            text5.sprite = Resources.Load<Sprite>("UI/button5a");
            if (tpointerenter.endf <= 0 & tpointerenter.tloadf <= 0 & Input.GetKey(KeyCode.Return))
            {

                tpointerenter.endf = 1;
                tpointerenter.mwxf = 1;
                audioes.clip = clipes[1];
                audioes.Play();
                
                

            }
        }
        if (tpointerenter.tmwxf== 1 & tmwx <= 1)
        {
            text2.color = new Color(255, 255, 255, 1 - tmwx);
           
            text3.color = new Color(255, 255, 255, 1 - tmwx);
           
            text4.color = new Color(255, 255, 255, 1 - tmwx);
           
            text5.color = new Color(255, 255, 255, 1 - tmwx);
            tmwx += 0.015f;
            antent = 0;
        }
        if (tpointerenter.tmwxf== 3 & tmwx <= 1)
        {
            text.color = new Color(255, 255, 255, 1 - tmwx);
            text2.color = new Color(255, 255, 255, 1 - tmwx);
           
            text4.color = new Color(255, 255, 255, 1 - tmwx);
           
            text5.color = new Color(255, 255, 255, 1 - tmwx);
            tmwx += 0.015f;
            antent = 0;
        }
        if (tmwxf==1&tmwx>=1)
        {
            text2.color = new Color(255, 255, 255, 0);
           
            text3.color = new Color(255, 255, 255, 0);
           
            text4.color = new Color(255, 255, 255, 0);
           
            text5.color = new Color(255, 255, 255, 0);
            tmwx = 0;
            tpointerenter.tmwxf= 0;
            
        }
        if (tpointerenter.tmwxf== 3 & tmwx >= 1)
        {
            text.color = new Color(255, 255, 255, 0);
            text2.color = new Color(255, 255, 255, 0);
           
            text4.color = new Color(255, 255, 255, 0);
           
            text5.color = new Color(255, 255, 255, 0);
            tmwx = 0;
            tpointerenter.tmwxf= 0;

        }
        if (titlebx<1&titlebx>-1)
        {
            titlebx = 5;
           
        }
        if (titlebx>5)
        {
            titlebx = 1;
      
        }
        if (titlebhantei>=1)
        {
            titlef += 1;
        }
        if (titlef>=10)
        {
            titlef = 0;
            titlebhantei = 0;
        }
    }
public static int getA() { return antenthantei; }
    public static int getB() { return antent; }
}
