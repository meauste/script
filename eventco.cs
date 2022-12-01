using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventco : MonoBehaviour
{
    public static int chrenumber;
    public static int chrednumber;
    public static int cedelnumber;
    public static int chref;
    public static int chrcgcf;
    public static int cetf;
    public static int cetdf;
    public static int ceikf;
    public static int bgenumber;
    public static int bgednumber;
    public static int bgef;
    public static int bgcgcf;
    public static int beikf;
    public static int betf;
    public static int betdf;
    public GameObject[] cfilep;
    public GameObject[] cfiled;
    public GameObject[] bfilep;
    public GameObject[] bfiled;
    public GameObject dragp;
    public Vector3 mousep;
    public bool mousef;
    textt script;
    edit script2;
    // Start is called before the first frame update
    void Start()
    {
        dragp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_position = Input.mousePosition;
        mousep =Camera.main.ScreenToWorldPoint(m_position);
        mousep.z = 0;
    }
    public void OnEndDrag()
    {
        mousef = true;
    }
    public void OnDrag()
    {
        mousef = false;
    }
    public void OnBeginDrag()
    {
        bgenumber = 0;
        bgednumber = 0;
    }
    public void TappedButton(string button)
    {
        script = GameObject.Find("textt").GetComponent<textt>();
        script2 = GameObject.Find("specialm").GetComponent<edit>();
        switch (button)
        {
            //ƒLƒƒƒ‰
            case "cevent":
                edit.editp = 3;
                break;
            case "cc":
                edit.cetpage = 0;
                break;
            case "gce":
                edit.cetpage = 1;
                break;
            case "cevent1":
                edit.ceventf = 0 + edit.cetpage * 3;
                break;
            case "cevent2":
                edit.ceventf = 1 + edit.cetpage * 3;
                break;
            case "cevent3":
                edit.ceventf = 2 + edit.cetpage * 3;
                break;
            case "cevent4":
                edit.ceventf = 3;
                break;
            case "cevent5":
                edit.ceventf = 4;
                break;
            case "cexmigi":
                if (edit.cexpage < dataload.cexmpage) { edit.cexpage += 1; }
                break;
            case "cexhidari":
                if (edit.cexpage > 0) { edit.cexpage -= 1; }
                break;
            case "cedel1":
                chref=1;cedelnumber = 5;
                break;
            case "cedel2":
                chref=1;cedelnumber = 4;
                break;
            case "cedel3":
                chref=1;cedelnumber = 3;
                break;
            case "cedel4":
                chref=1;cedelnumber = 2;
                break;
            case "cedel5":
                chref=1;cedelnumber = 1;
                break;
            case "chre1":
                if (edit.ceventf == 0) { chrenumber = edit.chrc_num - 4; }else if (edit.ceventf==3){chrenumber=edit.unaz_num-4;}else if(edit.ceventf==4){chrenumber=edit.odoroki_num-4;}else if(edit.ceventf==5){chrenumber=edit.daru_num-4;}

                break;
            case "chre2":
                if (edit.ceventf == 0) { chrenumber = edit.chrc_num - 3; }else if (edit.ceventf==3){chrenumber=edit.unaz_num-3;}else if(edit.ceventf==4){chrenumber=edit.odoroki_num-3;}else if (edit.ceventf==5){chrenumber=edit.daru_num-3;}

                break;
            case "chre3":
                if (edit.ceventf == 0) { chrenumber = edit.chrc_num - 2; }else if (edit.ceventf==3){chrenumber=edit.unaz_num-2;}else if(edit.ceventf==4){chrenumber=edit.odoroki_num-2;}else if (edit.ceventf==5){chrenumber=edit.daru_num-2;}

                break;
            case "chre4":
                if (edit.ceventf == 0) { chrenumber = edit.chrc_num - 1; }else if (edit.ceventf==3){chrenumber=edit.unaz_num-1;}else if(edit.ceventf==4){chrenumber=edit.odoroki_num-1;}else if (edit.ceventf==5){chrenumber=edit.daru_num-1;}

                break;
            case "chre5":
                if (edit.ceventf == 0) { chrenumber = edit.chrc_num; }else if (edit.ceventf==3){chrenumber=edit.unaz_num;}else if(edit.ceventf==4){chrenumber=edit.odoroki_num;}else if (edit.ceventf==5){chrenumber=edit.daru_num;}

                break;
            case "chred1":
                chrednumber = edit.chrcdg_num - 9;
                break;
            case "chred2":
                chrednumber = edit.chrcdg_num - 8;
                break;
            case "chred3":
                chrednumber = edit.chrcdg_num - 7;
                break;
            case "chred4":
                chrednumber = edit.chrcdg_num - 6;
                break;
            case "chred5":
                chrednumber = edit.chrcdg_num - 5;
                break;
            case "chred6":
                chrednumber = edit.chrcdg_num - 4;
                break;
            case "chred7":
                chrednumber = edit.chrcdg_num - 3;
                break;
            case "chred8":
                chrednumber = edit.chrcdg_num - 2;
                break;
            case "chred9":
                chrednumber = edit.chrcdg_num - 1;
                break;
            case "chred10":
                chrednumber = edit.chrcdg_num;
                break;
            case "cex10":
                if (dataload.cexnum >= 10 + edit.cexpage * 10) { chref = 1; chrcgcf = 10 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[9].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex9":
                if (dataload.cexnum >= 9 + edit.cexpage * 10) { chref = 1; chrcgcf = 9 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[8].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex8":
                if (dataload.cexnum >= 8 + edit.cexpage * 10) { chref = 1; chrcgcf = 8 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[7].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex7":
                if (dataload.cexnum >= 7 + edit.cexpage * 10) { chref = 1; chrcgcf = 7 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[6].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex6":
                if (dataload.cexnum >= 6 + edit.cexpage * 10) { chref = 1; chrcgcf = 6 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[5].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex5":
                if (dataload.cexnum >= 5 + edit.cexpage * 10) { chref = 1; chrcgcf = 5 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[4].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex4":
                if (dataload.cexnum >= 4 + edit.cexpage * 10) { chref = 1; chrcgcf = 4 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[3].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex3":
                if (dataload.cexnum >= 3 + edit.cexpage * 10) { chref = 1; chrcgcf = 3 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[2].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex2":
                if (dataload.cexnum >= 2 + edit.cexpage * 10) { chref = 1; chrcgcf = 2 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[1].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cex1":
                if (dataload.cexnum >= 1 + edit.cexpage * 10) { chref = 1; chrcgcf = 1 + edit.cexpage * 10;dragp.transform.position=mousep;dragp.SetActive(true); cfiled[0].transform.position = mousep;  } else { chrcgcf = 0; }
                break;
            case "cexd10":
                cfiled[9].transform.position = cfilep[9].transform.position; dragp.SetActive(false);
                break;
            case "cexd9":
                cfiled[8].transform.position = cfilep[8].transform.position; dragp.SetActive(false);
                break;
            case "cexd8":
                cfiled[7].transform.position = cfilep[7].transform.position; dragp.SetActive(false);
                break;
            case "cexd7":
                cfiled[6].transform.position = cfilep[6].transform.position; dragp.SetActive(false);
                break;
            case "cexd6":
                cfiled[5].transform.position = cfilep[5].transform.position; dragp.SetActive(false);
                break;
            case "cexd5":
                cfiled[4].transform.position = cfilep[4].transform.position; dragp.SetActive(false);
                break;
            case "cexd4":
                cfiled[3].transform.position = cfilep[3].transform.position; dragp.SetActive(false);
                break;
            case "cexd3":
                cfiled[2].transform.position = cfilep[2].transform.position; dragp.SetActive(false);
                break;
            case "cexd2":
                cfiled[1].transform.position = cfilep[1].transform.position; dragp.SetActive(false);
                break;
            case "cexd1":
                cfiled[0].transform.position = cfilep[0].transform.position; dragp.SetActive(false);
                break;
            case "cet1":
                chref = 1;
                cetf = 5;
                break;
            case "cet2":
                chref = 1;
                cetf = 4;
                break;
            case "cet3":
                chref = 1;
                cetf = 3;
                break;
            case "cet4":
                chref = 1;
                cetf = 2;
                break;
            case "cet5":
                chref = 1;
                cetf = 1;
                break;
            case "cehu":
                System.Array.Resize(ref script.ceventsyl, textt.chrcs + 1);
                if (edit.ceventf == 0) { System.Array.Resize(ref script.chrchantei, textt.chrcs + 1); System.Array.Resize(ref script.chrcnum, textt.chrcs + 1); textt.chrcs += 1; edit.chrc_num = 0; }
                if (edit.ceventf == 1) { System.Array.Resize(ref script.chrcdhantei, textt.chrcds + 1); System.Array.Resize(ref script.chrcdnum, textt.chrcds + 2); textt.chrcds += 1; edit.chrcd_num = 0; }
                if (edit.ceventf == 3) { System.Array.Resize(ref script.unazhantei, textt.unazs + 1); System.Array.Resize(ref script.unaznum, textt.unazs + 1); System.Array.Resize(ref script.unazc, textt.unazs + 1); textt.unazs += 1; edit.unaz_num = 0; }
                if (edit.ceventf == 4) { System.Array.Resize(ref script.odorokihantei, textt.odorokis + 1); System.Array.Resize(ref script.odorokinum, textt.odorokis + 1); System.Array.Resize(ref script.odorokic, textt.odorokis + 1); textt.odorokis += 1; edit.odoroki_num = 0; }
                if (edit.ceventf == 5) { System.Array.Resize(ref script.daruhantei, textt.darus + 1); System.Array.Resize(ref script.darunum, textt.darus + 1); System.Array.Resize(ref script.daruc, textt.darus + 1); textt.darus += 1; edit.daru_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "cehe":
                if (edit.ceventf == 0 & textt.chrcs > 5) { System.Array.Resize(ref script.chrchantei, textt.chrcs - 1); System.Array.Resize(ref script.chrcnum, textt.chrcs - 1); System.Array.Resize(ref script.ceventsyl, textt.chrcs - 1); textt.chrcs -= 1; edit.chrc_num = 0; }
                if (edit.ceventf == 1 & textt.chrcds > 5) { System.Array.Resize(ref script.chrcdhantei, textt.chrcds - 1); System.Array.Resize(ref script.chrcdnum, textt.chrcds - 2); textt.chrcds -= 1; edit.chrcd_num = 0; }
                if (edit.ceventf == 3 & textt.unazs > 5) { System.Array.Resize(ref script.unazhantei, textt.unazs + 1); System.Array.Resize(ref script.unaznum, textt.unazs + 1); System.Array.Resize(ref script.unazc, textt.unazs + 1); textt.unazs += 1; edit.unaz_num = 0; }
                if (edit.ceventf == 4 & textt.odorokis > 5) { System.Array.Resize(ref script.odorokihantei, textt.odorokis + 1); System.Array.Resize(ref script.odorokinum, textt.odorokis + 1); System.Array.Resize(ref script.odorokic, textt.odorokis + 1); textt.odorokis += 1; edit.odoroki_num = 0; }
                if (edit.ceventf == 5 & textt.darus > 5) { System.Array.Resize(ref script.daruhantei, textt.darus + 1); System.Array.Resize(ref script.darunum, textt.darus + 1); System.Array.Resize(ref script.daruc, textt.darus + 1); textt.darus += 1; edit.daru_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "ceup":
                if (edit.ceventf == 0 & edit.chrc_num > 5) { edit.chrc_num -= 1; }
                if (edit.ceventf == 3 & edit.unaz_num > 5) { edit.unaz_num -= 1; }
                if (edit.ceventf == 4 & edit.odoroki_num > 5) { edit.odoroki_num -= 1; }
                if (edit.ceventf == 5 & edit.daru_num > 5) { edit.daru_num -= 1; }
                break;
            case "cedown":
                if (edit.ceventf == 0 & edit.chrc_num < textt.chrcs) { edit.chrc_num += 1; }
                if (edit.ceventf == 3 & edit.unaz_num < textt.unazs) { edit.unaz_num += 1; }
                if (edit.ceventf == 4 & edit.odoroki_num < textt.odorokis) { edit.odoroki_num += 1; }
                if (edit.ceventf == 5 & edit.daru_num < textt.darus) { edit.daru_num += 1; }
                break;
            case "cemax":
                edit.chrc_num = textt.chrcs;
                edit.chrcd_num = textt.chrcds;
                break;
            case "cemin":
                edit.chrc_num = 5;
                edit.chrcd_num = 5;
                break;
            case "ceik":
                ceikf = 1;
                chref = 10;
                break;
            //”wŒi
            case "bevent":
                edit.editp = 4;
                break;
            case "bc":
                edit.betpage = 0;
                break;
            case "ge":
                edit.betpage = 1;
                break;
            case "bevent1":
                edit.beventf = 0 + edit.betpage * 6;
                break;
            case "bevent2":
                edit.beventf = 1 + edit.betpage * 6;
                break;
            case "bevent3":
                edit.beventf = 2 + edit.betpage * 6;
                break;
            case "bevent4":
                edit.beventf = 3 + edit.betpage * 6;
                break;
            case "bevent5":
                edit.beventf = 4 + edit.betpage * 6;
                break;
            case "bexmigi":
                if (edit.bexpage < dataload.bexmpage) { edit.bexpage += 1; }
                break;
            case "bexhidari":
                if (edit.bexpage > 0) { edit.bexpage -= 1; }
                break;
            case "bge1":
                if (edit.beventf == 0) { bgenumber = edit.bgc_num-4; } else if (edit.beventf == 4) { bgenumber = edit.kakudai_num-4; } else if (edit.beventf == 6) { bgenumber = edit.bgsw_num-4; } else if (edit.beventf == 7) { bgenumber = edit.bglw_num-4; } else if (edit.beventf == 8) { bgenumber = edit.bge_num-4; }

                break;
            case "bge2":
                if (edit.beventf == 0) { bgenumber = edit.bgc_num-3; } else if (edit.beventf == 4) { bgenumber = edit.kakudai_num-3; } else if (edit.beventf == 6) { bgenumber = edit.bgsw_num-3; } else if (edit.beventf == 7) { bgenumber = edit.bglw_num-3; } else if (edit.beventf == 8) { bgenumber = edit.bge_num-3; }

                break;
            case "bge3":
                if (edit.beventf == 0) { bgenumber = edit.bgc_num-2; } else if (edit.beventf == 4) { bgenumber = edit.kakudai_num-2; } else if (edit.beventf == 6) { bgenumber = edit.bgsw_num-2; } else if (edit.beventf == 7) { bgenumber = edit.bglw_num-2; } else if (edit.beventf == 8) { bgenumber = edit.bge_num-2; }

                break;
            case "bge4":
                if (edit.beventf == 0) { bgenumber = edit.bgc_num-1; } else if (edit.beventf == 4) { bgenumber = edit.kakudai_num-1; } else if (edit.beventf == 6) { bgenumber = edit.bgsw_num-1; } else if (edit.beventf == 7) { bgenumber = edit.bglw_num-1; } else if (edit.beventf == 8) { bgenumber = edit.bge_num-1; }

                break;
            case "bge5":
                if (edit.beventf == 0) { bgenumber = edit.bgc_num; } else if (edit.beventf == 4) { bgenumber = edit.kakudai_num; } else if (edit.beventf == 6) { bgenumber = edit.bgsw_num; } else if (edit.beventf == 7) { bgenumber = edit.bglw_num; } else if (edit.beventf == 8) { bgenumber = edit.bge_num; }

                break;
            case "bged1":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 9; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 9; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 9; }
                }
                break;
            case "bged2":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 8; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 8; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 8; }
                }
                break;
            case "bged3":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 7; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 7; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 7; }
                }
                break;
            case "bged4":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 6; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 6; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 6; }
                }
                break;
            case "bged5":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 5; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 5; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 5; }
                }
                break;
            case "bged6":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 4; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 4; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 4; }
                }
                break;
            case "bged7":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 3; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 3; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 3; }
                }
                break;
            case "bged8":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 2; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 2; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 2; }
                }
                break;
            case "bged9":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num - 1; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num - 1; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num - 1; }
                }
                break;
            case "bged10":
                if (mousef = true)
                {
                    if (edit.beventf == 1) { bgednumber = edit.bgcdg_num; }
                    if (edit.beventf == 3) { bgednumber = edit.chaptg_num; }
                    if (edit.beventf == 10) { bgednumber = edit.hazimari_num; }
                }
                break;
            case "bex9":
                if (dataload.bexnum >= 9 + edit.bexpage * 9) { bgef = 1; bgcgcf = 9 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[8].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex8":
                if (dataload.bexnum >= 8 + edit.bexpage * 9) { bgef = 1; bgcgcf = 8 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[7].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex7":
                if (dataload.bexnum >= 7 + edit.bexpage * 9) { bgef = 1; bgcgcf = 7 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[6].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex6":
                if (dataload.bexnum >= 6 + edit.bexpage * 9) { bgef = 1; bgcgcf = 6 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[5].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex5":
                if (dataload.bexnum >= 5 + edit.bexpage * 9) { bgef = 1; bgcgcf = 5 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[4].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex4":
                if (dataload.bexnum >= 4 + edit.bexpage * 9) { bgef = 1; bgcgcf = 4 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[3].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex3":
                if (dataload.bexnum >= 3 + edit.bexpage * 9) { bgef = 1; bgcgcf = 3 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[2].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex2":
                if (dataload.bexnum >= 2 + edit.bexpage * 9) { bgef = 1; bgcgcf = 2 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[1].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bex1":
                if (dataload.bexnum >= 1 + edit.bexpage * 9) { bgef = 1; bgcgcf = 1 + edit.bexpage * 9;dragp.transform.position=mousep;dragp.SetActive(true); bfiled[0].transform.position = mousep; } else { bgcgcf = 0; }
                break;
            case "bexd9":
                bfiled[8].transform.position = bfilep[8].transform.position; dragp.SetActive(false);
                break;
            case "bexd8":
                bfiled[7].transform.position = bfilep[7].transform.position; dragp.SetActive(false);
                break;
            case "bexd7":
                bfiled[6].transform.position = bfilep[6].transform.position; dragp.SetActive(false);
                break;
            case "bexd6":
                bfiled[5].transform.position = bfilep[5].transform.position; dragp.SetActive(false);
                break;
            case "bexd5":
                bfiled[4].transform.position = bfilep[4].transform.position; dragp.SetActive(false);
                break;
            case "bexd4":
                bfiled[3].transform.position = bfilep[3].transform.position; dragp.SetActive(false);
                break;
            case "bexd3":
                bfiled[2].transform.position = bfilep[2].transform.position; dragp.SetActive(false);
                break;
            case "bexd2":
                bfiled[1].transform.position = bfilep[1].transform.position; dragp.SetActive(false);
                break;
            case "bexd1":
                bfiled[0].transform.position = bfilep[0].transform.position; dragp.SetActive(false);
                break;
            case "bet1":
                if (mousef = true)
                {
                    bgef = 1;
                    betf = 5;
                }
                break;
            case "bet2":
                if (mousef = true)
                {
                    bgef = 1;
                    betf = 4;
                }
                break;
            case "bet3":
                if (mousef = true)
                {
                    bgef = 1;
                    betf = 3;
                }
                break;
            case "bet4":
                if (mousef = true)
                {
                    bgef = 1;
                    betf = 2;
                }
                break;
            case "bet5":
                if (mousef = true)
                {
                    bgef = 1;
                    betf = 1;
                }
                break;
            case "ehu":
                if (edit.beventf == 0) { System.Array.Resize(ref script.bgchantei, textt.bgcs + 1); System.Array.Resize(ref script.bgcnum, textt.bgcs + 1); textt.bgcs += 1; edit.bgc_num = 0; }
                if (edit.beventf == 1) { System.Array.Resize(ref script.bgcdhantei, textt.bgcds + 1); System.Array.Resize(ref script.bgcdg, textt.bgcds + 1); System.Array.Resize(ref script.bgcdnum, textt.bgcds * 2 + 2); textt.bgcds += 1; edit.bgcd_num = 0; }
                if (edit.beventf == 2) { System.Array.Resize(ref script.chaphantei, textt.chaps + 1); System.Array.Resize(ref script.chaptypes, textt.chaps + 1); System.Array.Resize(ref script.chapnum, textt.chaps + 1); System.Array.Resize(ref script.chapans, textt.chaps + 1); textt.chaps += 1; edit.chap_num = 0; }
                if (edit.beventf == 3) { System.Array.Resize(ref script.chapthantei, textt.chapts + 1); System.Array.Resize(ref script.chaptnum, textt.chapts * 2 + 2); textt.chapts += 1; edit.chapt_num = 0; }
                if (edit.beventf == 4) { System.Array.Resize(ref script.kakudaihantei, textt.kakudais + 1); System.Array.Resize(ref script.kakudaitypes, textt.kakudais + 1); System.Array.Resize(ref script.kakudainum, textt.kakudais + 1); textt.kakudais += 1; edit.kakudai_num = 0; }
                if (edit.beventf == 6) { System.Array.Resize(ref script.bgswhantei, textt.bgsws + 2); System.Array.Resize(ref script.bgswnum, textt.bgsws + 2); textt.bgsws += 2; edit.bgsw_num = 0; }
                if (edit.beventf == 7) { System.Array.Resize(ref script.bglwhantei, textt.bglws + 2); System.Array.Resize(ref script.bglwnum, textt.bglws + 2); textt.bglws += 2; edit.bglw_num = 0; }
                if (edit.beventf == 8) { System.Array.Resize(ref script.bgehantei, textt.bges + 2); System.Array.Resize(ref script.bgenum, textt.bges + 2); textt.bges += 2; edit.bge_num = 0; }
                if (edit.beventf == 9) { System.Array.Resize(ref script.serioushantei, textt.seriouss + 2); textt.seriouss += 2; edit.serious_num = 0; }
                if (edit.beventf == 10) { System.Array.Resize(ref script.hazimarihantei, textt.hazimaris + 2); System.Array.Resize(ref script.hazimarinum, textt.hazimaris + 2); textt.hazimaris += 2; edit.hazimari_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "ehe":
                if (edit.beventf == 0 & textt.bgcs > 5) { System.Array.Resize(ref script.bgchantei, textt.bgcs - 1); System.Array.Resize(ref script.bgcnum, textt.bgcs - 1); textt.bgcs -= 1; edit.bgc_num = 0; }
                if (edit.beventf == 1 & textt.bgcds > 5) { System.Array.Resize(ref script.bgcdhantei, textt.bgcds - 1); System.Array.Resize(ref script.bgcdg, textt.bgcds - 1); System.Array.Resize(ref script.bgcdnum, textt.bgcds * 2 - 2); textt.bgcds -= 1; edit.bgcd_num = 0; }
                if (edit.beventf == 2 & textt.chaps > 5) { System.Array.Resize(ref script.chaphantei, textt.chaps - 1); System.Array.Resize(ref script.chaptypes, textt.chaps - 1); System.Array.Resize(ref script.chapnum, textt.chaps - 1); textt.chaps -= 1; edit.chap_num = 0; }
                if (edit.beventf == 3 & textt.chapts > 5) { System.Array.Resize(ref script.chapthantei, textt.chapts - 1); System.Array.Resize(ref script.chaptnum, textt.chapts * 2 - 2); textt.chapts -= 1; edit.chapt_num = 0; }
                if (edit.beventf == 4 & textt.kakudais > 5) { System.Array.Resize(ref script.kakudaihantei, textt.kakudais - 1); System.Array.Resize(ref script.kakudaitypes, textt.kakudais - 1); System.Array.Resize(ref script.kakudainum, textt.kakudais - 1); textt.kakudais -= 1; edit.kakudai_num = 0; }
                if (edit.beventf == 6&textt.bgsws/2>5) { System.Array.Resize(ref script.bgswhantei, textt.bgsws - 2); System.Array.Resize(ref script.bgswnum, textt.bgsws - 2); textt.bgsws -= 2; edit.bgsw_num = 0; }
                if (edit.beventf == 7&textt.bglws/2>5) { System.Array.Resize(ref script.bglwhantei, textt.bglws - 2); System.Array.Resize(ref script.bglwnum, textt.bglws - 2); textt.bglws -= 2; edit.bglw_num = 0; }
                if (edit.beventf == 8&textt.bges/2>5) { System.Array.Resize(ref script.bgehantei, textt.bges - 2); System.Array.Resize(ref script.bgenum, textt.bges - 2); textt.bges -= 2; edit.bge_num = 0; }
                if (edit.beventf == 9&textt.seriouss/2>5) { System.Array.Resize(ref script.serioushantei, textt.seriouss - 2); textt.seriouss -= 2; edit.serious_num = 0; }
                if (edit.beventf == 10&textt.hazimaris/2>5) { System.Array.Resize(ref script.hazimarihantei, textt.hazimaris - 2); System.Array.Resize(ref script.hazimarinum, textt.hazimaris - 2); textt.hazimaris -= 2; edit.hazimari_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "eup":
                if (edit.beventf == 0 & edit.bgc_num > 5) { edit.bgc_num -= 1; }
                if (edit.beventf == 1 & edit.bgcd_num > 5) { edit.bgcd_num -= 1; }
                if (edit.beventf == 2 & edit.chap_num > 5) { edit.chap_num -= 1; }
                if (edit.beventf == 3 & edit.chapt_num > 5) { edit.chapt_num -= 1; }
                if (edit.beventf == 4 & edit.kakudai_num > 5) { edit.kakudai_num -= 1; }
                if (edit.beventf == 6 & edit.bgsw_num > 5) { edit.bgsw_num -= 1; }
                if (edit.beventf == 7 & edit.bglw_num > 5) { edit.bglw_num -= 1; }
                if (edit.beventf == 8 & edit.bge_num > 5) { edit.bge_num -= 1; }
                if (edit.beventf == 9 & edit.serious_num > 5) { edit.serious_num -= 1; }
                if (edit.beventf == 10 & edit.hazimari_num > 5) { edit.hazimari_num -= 1; }
                break;
            case "edown":
                if (edit.beventf == 0 & edit.bgc_num < textt.bgcs) { edit.bgc_num += 1; }
                if (edit.beventf == 1 & edit.bgcd_num < textt.bgcds) { edit.bgcd_num += 1; }
                if (edit.beventf == 2 & edit.chap_num < textt.chaps) { edit.chap_num += 1; }
                if (edit.beventf == 3 & edit.chapt_num < textt.chapts) { edit.chapt_num += 1; }
                if (edit.beventf == 4 & edit.kakudai_num < textt.kakudais) { edit.kakudai_num += 1; }
                if (edit.beventf == 6 & edit.bgsw_num <textt.bgsws) { edit.bgsw_num += 1; }
                if (edit.beventf == 7 & edit.bglw_num <textt.bglws) { edit.bglw_num += 1; }
                if (edit.beventf == 8 & edit.bge_num <textt.bges) { edit.bge_num += 1; }
                if (edit.beventf == 9 & edit.serious_num <textt.seriouss) { edit.serious_num += 1; }
                if (edit.beventf == 10 & edit.hazimari_num <textt.hazimaris) { edit.hazimari_num += 1; }
                break;
            case "emax":
                edit.bgc_num = textt.bgcs;
                edit.bgcd_num = textt.bgcds;
                edit.chap_num = textt.chaps;
                edit.chapt_num = textt.chapts;
                edit.kakudai_num = textt.kakudais;
                edit.bgsw_num = textt.bgsws;
                edit.bglw_num = textt.bglws;
                edit.bge_num = textt.bges;
                edit.serious_num = textt.seriouss;
                edit.hazimari_num = textt.hazimaris;
                break;
            case "emin":
                edit.bgc_num = 5;
                edit.bgcd_num = 5;
                edit.chap_num = 5;
                edit.chapt_num = 5;
                edit.kakudai_num = 5;
                edit.bgsw_num = 5;
                edit.bglw_num = 5;
                edit.bge_num = 5;
                edit.serious_num = 5;
                edit.hazimari_num = 5;
                break;
            case "beik":
                beikf = 1;
                bgef = 10;
                break;
            case "cpan5":
                if (script.chapans[edit.chap_num - 1] == 0) { script.chapans[edit.chap_num - 1] = 1; script.chapnum[edit.chap_num - 1] = ""; } else { script.chapans[edit.chap_num - 1] = 0; }
                break;
            case "cpan4":
                if (script.chapans[edit.chap_num - 2] == 0) { script.chapans[edit.chap_num - 2] = 1; script.chapnum[edit.chap_num - 2] = ""; } else { script.chapans[edit.chap_num - 2] = 0; };
                break;
            case "cpan3":
                if (script.chapans[edit.chap_num - 3] == 0) { script.chapans[edit.chap_num - 3] = 1; script.chapnum[edit.chap_num - 3] = ""; } else { script.chapans[edit.chap_num - 3] = 0; };
                break;
            case "cpan2":
                if (script.chapans[edit.chap_num - 4] == 0) { script.chapans[edit.chap_num - 4] = 1; script.chapnum[edit.chap_num - 4] = ""; } else { script.chapans[edit.chap_num - 4] = 0; };
                break;
            case "cpan1":
                if (script.chapans[edit.chap_num - 5] == 0) { script.chapans[edit.chap_num - 5] = 1; script.chapnum[edit.chap_num - 5] = ""; } else { script.chapans[edit.chap_num - 5] = 0; }
                break;
            case "ctype5":
                if (script.chaptypes[edit.chap_num - 1] < script.chapsy.Length - 1) { script.chaptypes[edit.chap_num - 1] += 1; } else { script.chaptypes[edit.chap_num - 1] = 0; };
                break;
            case "ctype4":
                if (script.chaptypes[edit.chap_num - 2] < script.chapsy.Length - 1) { script.chaptypes[edit.chap_num - 2] += 1; } else { script.chaptypes[edit.chap_num - 2] = 0; };
                break;
            case "ctype3":
                if (script.chaptypes[edit.chap_num - 3] < script.chapsy.Length - 1) { script.chaptypes[edit.chap_num - 3] += 1; } else { script.chaptypes[edit.chap_num - 3] = 0; };
                break;
            case "ctype2":
                if (script.chaptypes[edit.chap_num - 4] < script.chapsy.Length - 1) { script.chaptypes[edit.chap_num - 4] += 1; } else { script.chaptypes[edit.chap_num - 4] = 0; };
                break;
            case "ctype1":
                if (script.chaptypes[edit.chap_num - 5] < script.chapsy.Length - 1) { script.chaptypes[edit.chap_num - 5] += 1; } else { script.chaptypes[edit.chap_num - 5] = 0; }
                break;
            case "ktype5":
                if (script.kakudaitypes[edit.kakudai_num - 1] < script.kakudaisy.Length - 1) { script.kakudaitypes[edit.kakudai_num - 1] += 1; } else { script.kakudaitypes[edit.kakudai_num - 1] = 0; };
                break;
            case "ktype4":
                if (script.kakudaitypes[edit.kakudai_num - 2] < script.kakudaisy.Length - 1) { script.kakudaitypes[edit.kakudai_num - 2] += 1; } else { script.kakudaitypes[edit.kakudai_num - 2] = 0; };
                break;
            case "ktype3":
                if (script.kakudaitypes[edit.kakudai_num - 3] < script.kakudaisy.Length - 1) { script.kakudaitypes[edit.kakudai_num - 3] += 1; } else { script.kakudaitypes[edit.kakudai_num - 3] = 0; };
                break;
            case "ktype2":
                if (script.kakudaitypes[edit.kakudai_num - 4] < script.kakudaisy.Length - 1) { script.kakudaitypes[edit.kakudai_num - 4] += 1; } else { script.kakudaitypes[edit.kakudai_num - 4] = 0; };
                break;
            case "ktype1":
                if (script.kakudaitypes[edit.kakudai_num - 5] < script.kakudaisy.Length - 1) { script.kakudaitypes[edit.kakudai_num - 5] += 1; } else { script.kakudaitypes[edit.kakudai_num - 5] = 0; }
                break;
            default:
                break;
        }
    }
}