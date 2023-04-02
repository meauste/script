using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Loadco : MonoBehaviour
{
    public static int loadpage;
    public static int chapsf;
    public saveload sl;
    // Start is called before the first frame update
    void Start()
    {
        loadpage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            chapsf = 1;
            loadpage += 1;
            if (loadpage > 500)
            {
                loadpage = 1;
            }
            sound.soundflag = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            chapsf = 1;
            loadpage -= 1;
            sound.soundflag = 1;
        }
    }
    public void TappedButton(string button)
    {


        switch (button)
        {
            case "lmae":
                sound.soundflag = 1;
                chapsf = 1;
                loadpage -= 1;
                break;
            case "ltsugi":
                chapsf = 1;
                loadpage += 1;
                if (loadpage > 500)
                {
                    loadpage = 1;
                }
                sound.soundflag = 1;
                break;
            case "l10mae":
                chapsf = 1;
                loadpage = loadpage;

                loadpage -= 10;

                sound.soundflag = 2;
                break;
            case "l10tsugi":
                chapsf = 1;
                loadpage += 10;
                if (loadpage > 500)
                {
                    loadpage = 1;
                }
                sound.soundflag = 2;
                break;
            case "lmax":
                chapsf = 1;
                loadpage = 500;

                sound.soundflag = 2;
                break;
            case "lmin":
                chapsf = 1;
                loadpage = 1;
                sound.soundflag = 2;
                break;
            case "l1":
                saveload.savesname = (loadpage * 6 - 5).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "l2":
                saveload.savesname = (loadpage * 6 - 4).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "l3":
                saveload.savesname = (loadpage * 6 - 3).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "l4":
                saveload.savesname = (loadpage * 6 - 2).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "l5":
                saveload.savesname = (loadpage * 6 - 1).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "l6":
                saveload.savesname = (loadpage * 6).ToString();
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.sllf = 1;


                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "quick":
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.savesname = "quick";
                    saveload.sllf = 1;
                    TextManager.qlf = 1;

                    TextManager.auto = 0;
                    TextManager.autoflag = 0;
                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            case "end":
                if (File.Exists(Application.dataPath + "/SAVEDATA/savedata/" + textti.loaddata + "/" + saveload.savesname + ".json"))
                {
                    saveload.savesname = "end";
                    saveload.sllf = 1;
                    anmak.savestname = saveload.savesname;
                    PlayerPrefs.GetInt("Datae");
                    TextManager.text_num = PlayerPrefs.GetInt("Datae");
                    Load.loadflag = 1;
                    sound.soundflag = 4;
                }
                break;
            default:
                break;
        }
    }
}
