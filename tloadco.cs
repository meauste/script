using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class tloadco : MonoBehaviour
{
    public saveload sl;
    public static int tloadflag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tload1.loadpage += 1;
            if (tload1.loadpage > 500)
            {
                tload1.loadpage = 1;
            }
            sound.soundflag = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tload1.loadpage -= 1;
            sound.soundflag = 1;
        }
    }
    public void TappedButton(string button)
    {


        switch (button)
        {
            case "1":
                saveload.savesname = (tload1.loadpage * 6 - 5).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                break;
            case "2":
                saveload.savesname = (tload1.loadpage * 6 - 4).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                break;
            case "3":
                saveload.savesname = (tload1.loadpage * 6 - 3).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                break;
            case "4":
                saveload.savesname = (tload1.loadpage * 6 - 2).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                break;
            case "5":
                saveload.savesname = (tload1.loadpage * 6 - 1).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                break;
            case "6":
                saveload.savesname = (tload1.loadpage * 6).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    Load.loadflag = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                }
                    break;
            case "quick":
                saveload.savesname = "quick";
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;
                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    TextManager.qlf = 1;
                    TextManager.antenhantei = 1;
                    sound.soundflag = 4;
                    Load.loadflag = 1;
                }
                break;
            case "end":
                saveload.savesname = "end";
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" +saveload.savesname + ".json"))
                {
                    anmak.savestname = saveload.savesname;

                    tloadflag = 1;
                    ButtonManager.antenthantei = 1;
                    TextManager.antenhantei = 1;

                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "lmae":
                sound.soundflag = 1;
                tload1.chapsf = 1;
                tload1.loadpage -= 1;
                break;
            case "ltsugi":
                tload1.chapsf = 1;
                tload1.loadpage += 1;
                if (tload1.loadpage > 500)
                {
                    tload1.loadpage = 1;
                }
                sound.soundflag = 1;
                break;
            case "l10mae":
                tload1.chapsf = 1;

                tload1.loadpage -= 10;

                sound.soundflag = 2;
                break;
            case "l10tsugi":
                tload1.chapsf = 1;
                tload1.loadpage += 10;
                if (tload1.loadpage > 500)
                {
                    tload1.loadpage = 1;
                }
                sound.soundflag = 2;
                break;
            case "lmax":
                tload1.chapsf = 1;
                tload1.loadpage = 500;

                sound.soundflag = 2;
                break;
            case "lmin":
                tload1.chapsf = 1;
                tload1.loadpage = 1;
                sound.soundflag = 2;
                break;
            default:
                break;
        }
    }
}
