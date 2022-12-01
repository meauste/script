using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorco : MonoBehaviour
{
    public int editp;
    public static int cf;
    public static int r_text1;
    public static int r_text2;
    public static int r_text3;
    public static int r_text4;
    public static int r_text5;
    public static string edc;
    public static string tag;
    public static int toushicf;
    public static int roundf;
    public static int colorcf;
    public static int ocolorcf;
    public static int colorsf;
    public static int hyojif;
    public static int ccf;
    public static int zgc;
    textt script;
    edit script2;
    // Start is called before the first frame update
    void Start()
    {
        ccf = 0;
    }

    // Update is called once per frame
    void Update()
    {
        editp = edit.editp;
        script = GameObject.Find("textt").GetComponent<textt>();
    }
    public void TappedButton(string button)
    {

        script2 = GameObject.Find("specialm").GetComponent<edit>();
        switch (button)
        {
            case "color":
                edit.editp = 2;
                edit.cnum = 0;
                edit.num = 0;
                break;
            case "text":
                edit.editp = 0;
                edit.cnum = 0;
                edit.num = 0;
                break;
            case "cup":
                if (edit.cnum > 4 & edit.edit_cnum > 5)
                {
                    edit.edit_cnum -= 1;
                    zgc = -1;
                }
                break;
            case "cdown":
                if (edit.cnum > 4 & edit.edit_cnum < edit.cnum)
                {
                    edit.edit_cnum += 1;
                    zgc = 1;
                }
                break;
            case "cmin":
                if (edit.cnum > 4 & edit.edit_cnum > 5)
                {
                    edit.edit_cnum = 5;
                    cf = -1;
                }
                break;
            case "cmax":
                if (edit.cnum > 4)
                {
                    edit.edit_cnum = edit.cnum;
                    cf = -1;
                }
                break;
            case "tcnum":
                toushicf = 1;
                cf = 10;
                break;
            case "chu":
                System.Array.Resize(ref script.ctagna, edit.cnum + 1);
                System.Array.Resize(ref script.colorna, edit.cnum + 1);
                System.Array.Resize(ref script.ocolorna, edit.cnum + 1);
                System.Array.Resize(ref script2.ctags, edit.cnum + 1);
                System.Array.Resize(ref script2.cnames, edit.cnum + 1);
                edit.cnum += 1;
                if (edit.edit_cnum <= edit.cnum - 1)
                {
                    edit.edit_cnum = edit.cnum;
                    zgc = 2;
                }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "cc1":
                cf = 1;
                if (colorcf!=5){colorcf = 5;}else{colorcf=0;}
                break;
            case "cc2":
                cf = 1;
                if (colorcf!=4){colorcf = 4; } else { colorcf = 0; }
                break;
            case "cc3":
                cf = 1;
                if (colorcf!=3){colorcf = 3; } else { colorcf = 0; }
                break;
            case "cc4":
                cf = 1;
                if (colorcf!=2){colorcf = 2; } else { colorcf = 0; }
                break;
            case "cc5":
                cf = 1;
                if (colorcf!=1){colorcf = 1; } else { colorcf = 0; }
                break;
            case "occ1":
                cf = 1;
                if (ocolorcf != 5) { ocolorcf = 5; } else { ocolorcf = 0; }
                break;
            case "occ2":
                cf = 1;
                if (ocolorcf != 4) { ocolorcf = 4; } else { ocolorcf = 0; }
                break;
            case "occ3":
                cf = 1;
                if (ocolorcf != 3) { ocolorcf = 3; } else { ocolorcf = 0; }
                break;
            case "occ4":
                cf = 1;
                if (ocolorcf != 2) { ocolorcf = 2; } else { ocolorcf = 0; }
                break;
            case "occ5":
                cf = 1;
                if (ocolorcf != 1) { ocolorcf = 1; } else { ocolorcf = 0; }
                break;
            //ƒJƒ‰[‘I‘ð
            case "cs1":

                if (textt.cos> 0 + 15 * edit.cppage) { cf = 1; colorsf = 1+15*edit.cppage; }
                break;
            case "cs2":

                if (textt.cos> 1 + 15 * edit.cppage) { cf = 1; colorsf = 2+15*edit.cppage; }
                break;
            case "cs3":

                if (textt.cos> 2 + 15 * edit.cppage) { cf = 1; colorsf = 3+15*edit.cppage; }
                break;
            case "cs4":

                if (textt.cos> 3 + 15 * edit.cppage) { cf = 1; colorsf = 4+15*edit.cppage; }
                break;
            case "cs5":

                if (textt.cos> 4 + 15 * edit.cppage) { cf = 1; colorsf = 5+15*edit.cppage; }
                break;
            case "cs6":

                if (textt.cos> 5 + 15 * edit.cppage) { cf = 1; colorsf = 6+15*edit.cppage; }
                break;
            case "cs7":

                if (textt.cos> 6 + 15 * edit.cppage) { cf = 1; colorsf = 7+15*edit.cppage; }
                break;
            case "cs8":

                if (textt.cos> 7 + 15 * edit.cppage) { cf = 1; colorsf = 8+15*edit.cppage; }
                break;
            case "cs9":

                if (textt.cos> 8 + 15 * edit.cppage) { cf = 1; colorsf = 9+15*edit.cppage; }
                break;
            case "cs10":

                if (textt.cos> 9 + 15 * edit.cppage) { cf = 1; colorsf = 10+15*edit.cppage; }
                break;
            case "cs11":

                if (textt.cos> 10 + 15 * edit.cppage) { cf = 1; colorsf = 11+15*edit.cppage; }
                break;
            case "cs12":

                if (textt.cos> 11 + 15 * edit.cppage) { cf = 1; colorsf = 12+15*edit.cppage; }
                break;
            case "cs13":

                if (textt.cos> 12 + 15 * edit.cppage) { cf = 1; colorsf = 13+15*edit.cppage; }
                break;
            case "cs14":

                if (textt.cos> 13 + 15 * edit.cppage) { cf = 1; colorsf = 14+15*edit.cppage; }
                break;
            case "cs15":

                if (textt.cos> 14 + 15 * edit.cppage) { cf = 1; colorsf = 15+15*edit.cppage; }
                break;
            case "che":
                if (edit.cnum > 5)
                {
                    System.Array.Resize(ref script.ctagna, edit.cnum - 1);
                    System.Array.Resize(ref script.colorna, edit.cnum - 1);
                    System.Array.Resize(ref script.ocolorna, edit.cnum - 1);
                    System.Array.Resize(ref script2.ctags, edit.cnum - 1);
                    System.Array.Resize(ref script2.cnames, edit.cnum - 1);
                    edit.cnum -= 1;
                    if (edit.edit_cnum <= edit.cnum + 1)
                    {
                        edit.edit_cnum = edit.cnum;
                        zgc = -2;
                    }
                }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "csave":
                edittext.sf = 1;
                break;
            case "cik":
                ccf = 1;
                cf = 10;
                break;
            case "cac":
                edit.cnum = edit.edit_cnum = 5;
                script.ctagna = new string[edit.cnum];
                script.colorna = new string[edit.cnum];
                script.ocolorna = new string[edit.cnum];
                script2.ctags = new string[edit.cnum];
                script2.cnames = new string[edit.cnum];
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                cf = 10;
                break;
            default:
                break;
        }
    }
}

