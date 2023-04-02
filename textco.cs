using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textco : MonoBehaviour
{
    public int editp;
    public static int tef;
    public static int r_text1;
    public static int r_text2;
    public static int r_text3;
    public static int r_text4;
    public static int r_text5;
    public static string edc;
    public static string tag;
    public static int tikf;
    public static int teikf;
    public static int roundf;
    public static int colflag;
    public static int sentakuchf;
    public static int sentakucof;
    public static int coallf;
    public static int edit_tcnum;
    public static int textcf;
    public static int kakkof;
    public static int chflag;
    public static int coflag;
    public static int hyojif;
    public static int ctef;
    public static int zgt;
    public GameObject editpanel;
    public GameObject editpanelm;
    public Vector3 epp;
    public Vector3 mousep;
    textt script;
    edit script2;
    // Start is called before the first frame update
    void Start()
    {
        ctef = 0;
        script = GameObject.Find("textt").GetComponent<textt>();
        epp = editpanel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_position = Input.mousePosition;
        mousep = Camera.main.ScreenToWorldPoint(m_position);
        mousep.z = 0;

        editp = edit.editp;
        if (edit.editp>0)
        {
            editpanel.transform.position = epp;
            editpanelm.transform.position = epp;
        }
    }
    public void TappedButton(string button)
    {

        script2 = GameObject.Find("specialm").GetComponent<edit>();
        switch (button)
        {
            case "text":
                edit.editp = 0;
                break;
            case "tup":
                if (edit.tnum > 4 & edit.edit_tnum > 5)
                {
                    edit.edit_tnum -= 1;
                    zgt = -1;
                    textt.dataload = 1;
                }
                break;
            case "tdown":
                if (edit.tnum > 4 & edit.edit_tnum < edit.tnum)
                {
                    edit.edit_tnum += 1;
                    zgt = 1;
                    textt.dataload = 1;
                }
                break;
            case "tmin":
                if (edit.tnum > 4 & edit.edit_tnum > 5)
                {
                    edit.edit_tnum = 5;
                    tef = -1;
                    textt.dataload = 1;
                }
                break;
            case "tmax":
                if (edit.tnum > 4)
                {
                    edit.edit_tnum = edit.tnum;
                    tef = -1;
                    textt.dataload = 1;
                }
                break;
            case "thu":
                System.Array.Resize(ref script.chrtext, edit.tnum + 1);
                System.Array.Resize(ref script.textcolor, edit.tnum + 1);
                System.Array.Resize(ref script.textocolor, edit.tnum + 1);
                System.Array.Resize(ref script.color, edit.tnum + 1);
                System.Array.Resize(ref script.ocolor, edit.tnum + 1);
                System.Array.Resize(ref script.texth, edit.tnum + 1);
                System.Array.Resize(ref script.text, edit.tnum + 1);
                System.Array.Resize(ref script2.textnys, edit.tnum + 1);
                edit.tnum += 1;
                if (edit.edit_tnum <= edit.tnum - 1)
                {
                    edit.edit_tnum = edit.tnum;
                    zgt = 2;
                }
                textt.dataload = 1;
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "the":
                if (edit.tnum > 5)
                {
                    System.Array.Resize(ref script.chrtext, edit.tnum - 1);
                    System.Array.Resize(ref script.textcolor, edit.tnum - 1);
                    System.Array.Resize(ref script.textocolor, edit.tnum - 1);
                    System.Array.Resize(ref script.color, edit.tnum - 1);
                    System.Array.Resize(ref script.ocolor, edit.tnum - 1);
                    System.Array.Resize(ref script.texth, edit.tnum - 1);
                    System.Array.Resize(ref script.text, edit.tnum - 1);
                    System.Array.Resize(ref script2.textnys, edit.tnum - 1);
                    edit.tnum -= 1;
                    if (edit.edit_tnum <= edit.tnum + 1)
                    {
                        edit.edit_tnum = edit.tnum;
                        zgt = -2;
                    }
                    textt.dataload = 1;
                    edittext.sif += 1;
                    edittext.simf = edittext.sif;
                    susumu.sinkf = 1;
                }

                break;
            case "textb1":
                tef = 1;
                textcf = 5;
                break;
            case "textb2":
                tef = 1;
                textcf = 4;
                break;
            case "textb3":
                tef = 1;
                textcf = 3;
                break;
            case "textb4":
                tef = 1;
                textcf = 2;
                break;
            case "textb5":
                tef = 1;
                textcf = 1;
                break;
            case "kakko1":
                tef = 1;
                kakkof = 5;
                break;
            case "kakko2":
                tef = 1;
                kakkof = 4;
                break;
            case "kakko3":
                tef = 1;
                kakkof = 3;
                break;
            case "kakko4":
                tef = 1;
                kakkof = 2;
                break;
            case "kakko5":
                tef = 1;
                kakkof = 1;
                break;
            case "chr":
                edit.sepage = 0;
                    chflag = 1;
                    coflag = 0;
                editpanel.transform.position = epp;
                editpanelm.transform.position = epp;
                break;
            case "col":
                edit.sepage = 0;
                    coflag = 1;
                    chflag = 0;
                editpanel.transform.position = epp;
                editpanelm.transform.position = epp;
                break;
            case "tex":
                edit.sepage = 0;
                chflag = 0;
                coflag = 0;
                break;
            case "large":
                edit.largef = 0;
                break;
            case "small":
                edit.largef = 1;
                break;
            case "migi":
                edit.textflag = 1;
                break;
            case "hidari":
                edit.textflag = 0;
                break;
            case "tc":
                if (edit.tcflag == 0) { edit.tcflag = 1; } else { edit.tcflag = 0; }
                break;
            case "tco":
                if (edit.tcoflag == 0) { edit.tcoflag = 1; } else { edit.tcoflag = 0; }
                break;
            case "th":
                if (edit.thflag == 0) { edit.thflag = 1; } else { edit.thflag = 0; }
                break;
            case "epd":
                editpanel.transform.position = mousep;
                editpanelm.transform.position = mousep;
                break;
            case "se1":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 12+edit.sepage*12){ sentakuchf =12;sentakucof=0;}}else {if (edit.cnum >= 12 + edit.sepage * 12) { sentakucof = 12;sentakuchf=0;}}
                break;
            case "se2":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 11 + edit.sepage * 12) { sentakuchf =11;sentakucof=0;}}else {if (edit.cnum >= 11 + edit.sepage * 12) { sentakucof = 11;sentakuchf=0;}}
                break;
            case "se3":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 10 + edit.sepage * 12) { sentakuchf =10;sentakucof=0;}}else {if (edit.cnum >= 10 + edit.sepage * 12) { sentakucof = 10;sentakuchf=0;}}
                break;
            case "se4":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 9 + edit.sepage * 12) { sentakuchf =9;sentakucof=0;}}else {if (edit.cnum >= 9 + edit.sepage * 12) { sentakucof = 9;sentakuchf=0;}}
                break;
            case "se5":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 8 + edit.sepage * 12) { sentakuchf =8;sentakucof=0;}}else {if (edit.cnum >= 8 + edit.sepage * 12) { sentakucof = 8;sentakuchf=0;}}
                break;
            case "se6":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 7 + edit.sepage * 12) { sentakuchf =7;sentakucof=0;}}else {if (edit.cnum >= 7 + edit.sepage * 12) { sentakucof = 7;sentakuchf=0;}}
                break;
            case "se7":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 6 + edit.sepage * 12) { sentakuchf =6;sentakucof=0;}}else {if (edit.cnum >= 6 + edit.sepage * 12) { sentakucof = 6;sentakuchf=0;}}
                break;
            case "se8":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 5 + edit.sepage * 12) { sentakuchf =5;sentakucof=0;}}else {if (edit.cnum >= 5 + edit.sepage * 12) { sentakucof = 5;sentakuchf=0;}}
                break;
            case "se9":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 4 + edit.sepage * 12) { sentakuchf =4;sentakucof=0;}}else {if (edit.cnum >= 4 + edit.sepage * 12) { sentakucof = 4;sentakuchf=0;}}
                break;
            case "se10":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 3 + edit.sepage * 12) { sentakuchf =3;sentakucof=0;}}else {if (edit.cnum >= 3 + edit.sepage * 12) { sentakucof = 3;sentakuchf=0;}}
                break;
            case "se11":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 2 + edit.sepage * 12) { sentakuchf =2;sentakucof=0;}}else {if (edit.cnum >= 2 + edit.sepage * 12) { sentakucof = 2;sentakuchf=0;}}
                break;
            case "se12":
                tef = 1;
                if (coflag == 0) {if (edit.num >= 1 + edit.sepage * 12) { sentakuchf =1;sentakucof=0;}}else {if (edit.cnum >= 1 + edit.sepage * 12) { sentakucof = 1;sentakuchf=0;}}
                break;
            case "sepm":
                if (edit.sepage>0)
                {
                    edit.sepage -= 1;
                }
                else
                {
                    edit.sepage = 0;
                }
                break;
            case "sept":
                if (edit.sempage > edit.sepage)
                {
                    edit.sepage += 1;
                }
                break;
            case "tsave":
                edittext.sf = 1;
                break;
            case "tik":
                tikf = 1;
                tef = 10;
                break;
            case "teik":
                teikf = 1;
                tef = 10;
                break;
            case "coall":
                if (sentakucof > 0)
                {
                    coallf = 1;
                    tef = 10;
                }
                break;
            case "tac":
                edit.tnum = edit.edit_tnum = 5;
                script.chrtext = new string[edit.tnum];
                script.textcolor = new string[edit.tnum];
                script.textocolor = new string[edit.tnum];
                script.texth = new string[edit.tnum];
                script.text = new string[edit.tnum];
                script2.textnys = new string[edit.tnum];
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                tef = 10;
                break;
            default:
                break;
        }
    }
}


