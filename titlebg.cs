using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class titlebg : MonoBehaviour
{
    public int mwxf;
    public float mwx;
    public int mtwxf;
    public float mtwx;
    public float fadep;
    public int titlebx;
    public float time;

    public static int titlehantei;
    public int gamelogohantei;
    public string[] tlogo;
    public static int logox;
    public static int gamelogof;
    public int antenthantei = ButtonManager.antenthantei;
    public Image titlelogo;
    public Image titleb1;
    public Image titleb2;
    public Image titleb3;
    public Image titleb4;
    public Image titleb5;
    public GameObject titlewa;
    public Image titlega;
    public GameObject titlegap;
    public GameObject titlelogop;
    public AudioSource audioes;
    public AudioClip[] clipes;
    textt script;
    dataload script2;
    // Start is called before the first frame update
    void Start()
    {
        textt.audioev = (4) * 0.1f;
        audioes.volume = textt.audioev;
        titlegap.SetActive(true);
        titlelogop.SetActive(false);
        titlewa.SetActive(false);
        titlehantei = 0;
        script = GameObject.Find("textt").GetComponent<textt>();
        script2 = GameObject.Find("dataload").GetComponent<dataload>();
        mwx = 0;
        mwxf = 1;
        logox = 2;
        mtwx = 2.0f;
        mtwxf = 1;
        fadep = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        gamelogohantei = ButtonManager.gamelogohantei;
        antenthantei = ButtonManager.antenthantei;
        if (gamelogohantei > script.gamelogohanteio.Length)
        {
            ButtonManager.gamelogohantei = 0;
        }
        if (gamelogohantei>=1&gamelogohantei<=script.gamelogohanteio.Length)
        {

            if (antenthantei == 2)
            {
                titlega.sprite = script2.uis[script.gamelogohanteio[gamelogohantei-1]];
            }
            if (antenthantei == 0)
            {
                if (time<3)
                {
                    time += Time.deltaTime;
                }
               else
                {
                    ButtonManager.antenthantei = 1;
                    time = 0;
                }
            }
        }
        if (gamelogohantei == 0)
        {
            if (mtwx==2.0f)
            {
                audioes.clip = clipes[0];
                audioes.Play();
            }
            titlebx = ButtonManager.titlebx;
            antenthantei = ButtonManager.antenthantei;
            if (mtwx > 1.0f & mtwxf >= 1)
            {
                if (script.uitnumo[0] != null & script.uitnumo[0] != "") { titlega.sprite = script2.uis[script.uitnumo[0]]; } else { titlega.sprite = Resources.Load<Sprite>("UI/bgsample"); }
                titlega.transform.localScale = new Vector3(mtwx, mtwx, 0);
                mtwx -= 0.0006f;
            }
            if (mtwx <= 1.0f)
            {
                titlega.transform.localScale = new Vector3(1, 1, 0);
                mtwxf = 0;
            }
            if (antenthantei <= 0 & mwx < 0.9f & mwxf >= 1)
            {
                titlelogop.SetActive(true);
                titlewa.SetActive(true);
                titlelogo.color = new Color(255, 255, 255, mwx);
                titleb1.color = new Color(255, 255, 255, mwx);
                titleb2.color = new Color(255, 255, 255, mwx);
                titleb3.color = new Color(255, 255, 255, mwx);
                titleb4.color = new Color(255, 255, 255, mwx);
                titleb5.color = new Color(255, 255, 255, mwx);
                mwx += 0.008f;

            }
            if (antenthantei <= 0 & fadep >= 1.25f)
            {
                Image til = titlelogo.GetComponent<Image>();
                til.transform.localScale = new Vector3(fadep, fadep, 0);
                if (script.uitnumo[1] != null & script.uitnumo[1] != "") { til.sprite = script2.uis[script.uitnumo[1]]; } else { til.sprite = Resources.Load<Sprite>("UI/titlelogo"); }
                fadep -= 0.005f;
            }
            if (mwx >= 0.9f)
            {
                titlehantei = 1;
                titlewa.SetActive(false);
                titlelogo.color = new Color(255, 255, 255, 255);
                titleb1.color = new Color(255, 255, 255, 255);
                titleb2.color = new Color(255, 255, 255, 255);
                titleb3.color = new Color(255, 255, 255, 255);
                titleb4.color = new Color(255, 255, 255, 255);
                titleb5.color = new Color(255, 255, 255, 255);


                mwxf = 0;
                mwx = 0;
            }

        }
    }
}
