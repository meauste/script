using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editco : MonoBehaviour
{
    public int editp;
    public static int chf;
    public static int r_text1;
    public static int r_text2;
    public static int r_text3;
    public static int r_text4;
    public static int r_text5;
    public static string edc;
    public static string tag;
    public static int toushif;
    public static int roundf;
    public static int seibetsuf;
    public static int hyojif;
    public static int acf;
    public static int pacf;
    public static int cpicf;
    public static int cexf;
    public static int zg;
    public string[][] cpiccopy;
    textt script;
    edit script2;
    // Start is called before the first frame update
    void Start()
    {
        acf = 0;
    }

    // Update is called once per frame
    void Update()
    {
        editp=edit.editp;
        script = GameObject.Find("textt").GetComponent<textt>();
    }
    public void TappedButton(string button)
    {

        script2 = GameObject.Find("specialm").GetComponent<edit>();
        switch (button)
        {
            //ページ1
            case "chr":
                edit.editp = 1;
                edit.cnum = 0;
                edit.num = 0;
                break;
            case "text":
                edit.editp = 0;
                edit.cnum = 0;
                edit.num = 0;
                break;
            case "UI":
                edit.editp = 11;
                break;
            case "sentaku":
                esaveco.useflag = 0;
                esaveco.jsonflag = 0;
                edit.editp = 10;
                break;
            case "eup":
                if (edit.num > 4 & edit.edit_num > 5)
                {
                    edit.edit_num -= 1;
                    zg = -1;
                }
                break;
            case "edown":
                if (edit.num > 4 & edit.edit_num < edit.num)
                {
                    edit.edit_num += 1;
                    zg = 1;
                }
                break;
            case "emin":
                if (edit.num > 4 & edit.edit_num > 5)
                {
                    edit.edit_num = 5;
                    chf = -1;
                }
                break;
            case "emax":
                if (edit.num > 4)
                {
                    edit.edit_num = edit.num;
                    chf = -1;
                }
                break;
            case "tnum":
                toushif = 1;
                chf = 10;
                break;
            case "ehu":
                System.Array.Resize(ref script.partna, edit.num + 1);
                System.Array.Resize(ref script.chrna, edit.num + 1);
                System.Array.Resize(ref script.chrmyo, edit.num + 1);
                System.Array.Resize(ref script.seibetsu, edit.num + 1);
                System.Array.Resize(ref script.hyoji, edit.num + 1);
                System.Array.Resize(ref script.bikou, edit.num + 1);
                System.Array.Resize(ref script2.tags, edit.num + 1);
                System.Array.Resize(ref script2.names, edit.num + 1);
                System.Array.Resize(ref script2.myojis, edit.num + 1);
                System.Array.Resize(ref script2.bikous, edit.num + 1);
                edit.num += 1;
                System.Array.Resize(ref script.cpic, edit.num + 1);
                script.cpic[edit.num] = new string[5] { "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC", "NAME*PIC" };
                if (edit.edit_num <= edit.num - 1)
                {
                    edit.edit_num = edit.num;
                    zg = 2;
                }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "ehe":
                if (edit.num > 5)
                {
                    System.Array.Resize(ref script.partna, edit.num - 1);
                    System.Array.Resize(ref script.chrna, edit.num - 1);
                    System.Array.Resize(ref script.chrmyo, edit.num - 1);
                    System.Array.Resize(ref script.seibetsu, edit.num - 1);
                    System.Array.Resize(ref script.hyoji, edit.num - 1);
                    System.Array.Resize(ref script.bikou, edit.num - 1);
                    System.Array.Resize(ref script2.tags, edit.num - 1);
                    System.Array.Resize(ref script2.names, edit.num - 1);
                    System.Array.Resize(ref script2.myojis, edit.num - 1);
                    System.Array.Resize(ref script2.bikous, edit.num - 1);
                    System.Array.Resize(ref script.cpic, edit.num - 1);
                    edit.num -= 1;
                    if (edit.edit_num <= edit.num + 1)
                    {
                        edit.edit_num = edit.num;
                        zg = -2;
                    }
                }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "esave":
                edittext.sf = 1;
                break;
            case "eik":
                acf = 1;
                chf = 10;
                break;
            case "eac":
                edit.num = edit.edit_num = 5;
                script.partna = new string[edit.num];
                script.chrna = new string[edit.num];
                script.chrmyo = new string[edit.num];
                script.seibetsu = new int[edit.num];
                script.hyoji = new int[edit.num];
                script.bikou = new string[edit.num];
                script.cpic = new string[edit.cpicnumber][];
                script2.tags = new string[edit.num];
                script2.names = new string[edit.num];
                script2.myojis = new string[edit.num];
                script2.bikous = new string[edit.num];
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                chf = 10;
                break;
            case "migi":
                if (edit.chrpage==0) { edit.chrpage += 1; }
                break;
            case "hidari":
                if (edit.chrpage ==1) { edit.chrpage -= 1; }
                break;
            case "er1":
                chf = 1;
                roundf = 5;
                break;
            case "er2":
                chf = 1;
                roundf = 4;
                break;
            case "er3":
                chf = 1;
                roundf = 3;
                break;
            case "er4":
                chf = 1;
                roundf = 2;
                break;
            case "er5":
                chf = 1;
                roundf = 1;
                break;
            case "hyo1":
                chf = 1;
                hyojif = 5;
                break;
            case "hyo2":
                chf = 1;
                hyojif = 4;
                break;
            case "hyo3":
                chf = 1;
                hyojif = 3;
                break;
            case "hyo4":
                chf = 1;
                hyojif = 2;
                break;
            case "hyo5":
                chf = 1;
                hyojif = 1;
                break;
            case "se1":
                chf = 1;
                seibetsuf = 5;
                break;
            case "se2":
                chf = 1;
                seibetsuf = 4;
                break;
            case "se3":
                chf = 1;
                seibetsuf = 3;
                break;
            case "se4":
                chf = 1;
                seibetsuf = 2;
                break;
            case "se5":
                chf = 1;
                seibetsuf = 1;
                break;
            //ページ2
            //キャラ選択
            case "cpic1":
                edit.cpicnumber=edit.edit_num-5;
                edit.cpic_num = 0;
                break;
            case "cpic2":
                edit.cpicnumber=edit.edit_num-4;
                edit.cpic_num = 0;
                break;
            case "cpic3":
                edit.cpicnumber=edit.edit_num-3;
                edit.cpic_num = 0;
                break;
            case "cpic4":
                edit.cpicnumber=edit.edit_num-2;
                edit.cpic_num = 0;
                break;
            case "cpic5":
                edit.cpicnumber=edit.edit_num-1;
                edit.cpic_num = 0;
                break;
            case "cpicc1":
                cpicf = 1;
                break;
            case "cpicc2":
                cpicf = 2;
                break;
            case "cpicc3":
                cpicf = 3;
                break;
            case "cpicc4":
                cpicf = 4;
                break;
            case "cpicc5":
                cpicf = 5;
                break;
            //画像選択
            case "cpicdown":
                if (edit.cpic_num < edit.cpicnum) { edit.cpic_num += 1; }
                break;
            case "cpicup":
                if (edit.cpic_num >5 ) { edit.cpic_num -= 1; }
                break;
            case "cpicmin":
                edit.cpic_num =5;
                break;
            case "cpicmax":
                edit.cpic_num = edit.cpicnum;
                break;
            case "cpichu":
                edit.cpicnum += 1;
                System.Array.Resize(ref script.cpic[edit.cpicnumber], edit.cpicnum);
                script.cpic[edit.cpicnumber][edit.cpicnum-1] = "NAME*PIC";
                edit.cpic_num = edit.cpicnum;
                break;
            case "cpiche":
                if (edit.cpicnum > 5) { edit.cpicnum -= 1; System.Array.Resize(ref script.cpic[edit.cpicnumber],edit.cpicnum); edit.cpic_num = edit.cpicnum; };
                break;
            //画像ファイル
            case "cexmigi":
                if (edit.cexpage < edit.cexmpage) { edit.cexpage += 1; }
                break;
            case "cexhidari":
                if (edit.cexpage > 0) { edit.cexpage -= 1; }
                break;
            case "cex10":               
                if (edit.cexnum >= 10 + edit.cexpage * 10) { chf=1;cexf = 10 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex9":             
                if (edit.cexnum >= 9 + edit.cexpage * 10) { chf=1;cexf = 9 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex8":     
                if (edit.cexnum >= 8 + edit.cexpage * 10) { chf=1;cexf = 8 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex7":      
                if (edit.cexnum >= 7 + edit.cexpage * 10) { chf=1;cexf = 7 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex6":
                if (edit.cexnum >= 6 + edit.cexpage * 10) { chf=1;cexf = 6 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex5":
                if (edit.cexnum >= 5 + edit.cexpage * 10) { chf=1;cexf = 5 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex4": 
                if (edit.cexnum >= 4 + edit.cexpage * 10) { chf=1;cexf = 4 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex3": 
                if (edit.cexnum >= 3 + edit.cexpage * 10) { chf=1;cexf = 3 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex2": 
                if (edit.cexnum >= 2 + edit.cexpage * 10) { chf=1;cexf = 2 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "cex1":
                if (edit.cexnum >= 1 + edit.cexpage * 10) { chf=1;cexf = 1 + edit.cexpage * 10;}else{cexf=0;}
                break;
            case "pcik":
                pacf = 1;
                chf = 10;
                break;
            default:
                break;
        }
    }
}
