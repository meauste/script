using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour
{
    public string rtext;
    public string edc;
    public float tf;
    public int r_text;
    public  string edc1;
    public  string edc2;
    public  string edc3;
    public  string edc4;
    public  string edc5;
    public int edcpl;
    public int edc1pl;
    public int edc2pl;
    public int edc3pl;
    public int edc4pl;
    public int edc5pl;
    public  string rtext1;
    public  string rtext2;
    public  string rtext3;
    public  string rtext4;
    public  string rtext5;
    public string cnaData;
    public int sentakuchf;
    public int sentakucof;
    public int text_num;
    public int chrcx;
    public int[] chart;
    public int[] charts;
    public int[] charth;
    public int[] chartx;
    public int kakudaix;
    public int bgchanteit;
    public int bgcdhanteit;
    public int chaphanteit;
    public int chapthanteit;
    public int kakudaihanteit;
    public int hazimarihanteit;
    textti script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_num = TextManager.text_num;
        rtext = textti.loaddata;
        tf = saveloadl.loadfl;
        sentakuchf = textti.six;
        sentakucof = textti.chapts;
        bgchanteit = textt.sentakus;
        kakudaix = Bgcontroller.kakudaix;
        bgcdhanteit = Bgcontroller.sentakux;
        chaphanteit = Bgcontroller.chaphanteit;
        chapthanteit = Bgcontroller.chapthanteit;
        kakudaihanteit = Bgcontroller.kakudaihanteit;
        hazimarihanteit = Bgcontroller.hazimarihanteit;
        edcpl = Bgcontroller.hazimarihanteit;
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            script = GameObject.Find("textti").GetComponent<textti>();
            chart = script.chart;
            charts = script.charts;
            charth = script.charth;
            chartx = script.chartx;
            chrcx = chrcontroller.chrcx;
        }
    }
}
