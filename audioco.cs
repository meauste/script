using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioco : MonoBehaviour
{
    public static int auf;
    public static int audiocf;
    public static int audiotsef;
    public static int audiosef;
    public static int audiosebf;
    public GameObject[] aufilep;
    public GameObject[] aufiled;
    public static int auikf;
    public static int vif;
    public static int videocf;
    public static int videoonf;
    public static int videotsef;
    public static int videosef;
    public static int videosebf;
    public GameObject[] vifilep;
    public GameObject[] vifiled;
    public static int viikf;
    public GameObject dragp;
    public Vector3 mousep;
    textt script;
    edit script2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        script = GameObject.Find("textt").GetComponent<textt>();
        Vector3 m_position = Input.mousePosition;
        mousep = Camera.main.ScreenToWorldPoint(m_position);
        mousep.z = 0;
    }
    public void TappedButton(string button)
    {

        script2 = GameObject.Find("specialm").GetComponent<edit>();
        switch (button)
        {
            case "audio":
                edit.editp = 6;
                break;
            case "bgm":
                edit.audiof = 0;
                edit.audiosf = 1;
                edit.audioph = 0;
                audiocf = 0;
                audiosef = 0;
                audiosebf = 0;
                break;
            case "bgme":
                edit.audiof = 1;
                edit.audiosf = 1;
                edit.audioph = 0;
                audiocf = 0;
                audiosef = 0;
                audiosebf = 0;
                break;
            case "bgmef":
                edit.audiof = 2;
                edit.audiosf = 1;
                edit.audioph = 0;
                audiocf = 0;
                audiosef = 0;
                audiosebf = 0;
                break;
            case "audioplay12":
                if (edit.audioph != 12 + edit.asepage * 12)
                {
                    edit.audiopf = 12 + edit.asepage * 12;
                    edit.audioph = 12 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 12 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                    break;
            case "audioplay11":
                if (edit.audioph != 11 + edit.asepage * 12)
                {
                    edit.audiopf = 11 + edit.asepage * 12;
                    edit.audioph = 11 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 11 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay10":
                if (edit.audioph != 10 + edit.asepage * 12)
                {
                    edit.audiopf = 10 + edit.asepage * 12;
                    edit.audioph = 10 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 10 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay9":
                if (edit.audioph != 9 + edit.asepage * 12)
                {
                    edit.audiopf = 9 + edit.asepage * 12;
                    edit.audioph = 9 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 9 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay8":
                if (edit.audioph != 8 + edit.asepage * 12)
                {
                    edit.audiopf = 8 + edit.asepage * 12;
                    edit.audioph = 8 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 8 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay7":
                if (edit.audioph != 7 + edit.asepage * 12)
                {
                    edit.audiopf = 7 + edit.asepage * 12;
                    edit.audioph = 7 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 7 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay6":
                if (edit.audioph != 6 + edit.asepage * 12)
                {
                    edit.audiopf = 6 + edit.asepage * 12;
                    edit.audioph = 6 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 6 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay5":
                if (edit.audioph != 5 + edit.asepage * 12)
                {
                    edit.audiopf = 5 + edit.asepage * 12;
                    edit.audioph = 5 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 5 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay4":
                if (edit.audioph != 4 + edit.asepage * 12)
                {
                    edit.audiopf = 4 + edit.asepage * 12;
                    edit.audioph = 4 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 4 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay3":
                if (edit.audioph != 3 + edit.asepage * 12)
                {
                    edit.audiopf = 3 + edit.asepage * 12;
                    edit.audioph = 3 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 3 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay2":
                if (edit.audioph != 2 + edit.asepage * 12)
                {
                    edit.audiopf = 2 + edit.asepage * 12;
                    edit.audioph = 2 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 2 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioplay1":
                if (edit.audioph != 1 + edit.asepage * 12)
                {
                    edit.audiopf = 1 + edit.asepage * 12;
                    edit.audioph = 1 + edit.asepage * 12;
                }
                else
                {
                    edit.audiosf = 1 + edit.asepage * 12;
                    edit.audioph = 0;
                }
                break;
            case "audioselect5":
                audiosef = 1;
                auf =1;
                break;
            case "audioselect4":
                audiosef = 2;
                auf = 1;
                break;
            case "audioselect3":
                audiosef = 3;
                auf = 1;
                break;
            case "audioselect2":
                audiosef = 4;
                auf = 1;
                break;
            case "audioselect1":
                audiosef = 5;
                auf = 1;
                break;
            case "audiotselect12":
                if (edit.audiof==0){if(edit.bgmnum >= 12+ edit.asepage *12) { auf = 1; audiocf = 12+ edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[11].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 12+ edit.asepage *12) { auf = 1; audiocf = 12+ edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[11].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 12+ edit.asepage *12) { auf = 1; audiocf = 12+ edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[11].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect11":
                if (edit.audiof==0){if(edit.bgmnum >= 11 + edit.asepage *12) { auf = 1; audiocf = 11 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[10].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 11 + edit.asepage *12) { auf = 1; audiocf = 11 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[10].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 11 + edit.asepage *12) { auf = 1; audiocf = 11 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[10].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect10":
                if (edit.audiof==0){if(edit.bgmnum >= 10 + edit.asepage *12) { auf = 1; audiocf = 10 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[9].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 10 + edit.asepage *12) { auf = 1; audiocf = 10 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[9].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 10 + edit.asepage *12) { auf = 1; audiocf = 10 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[9].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect9":
                if (edit.audiof==0){if(edit.bgmnum >= 9 + edit.asepage *12) { auf = 1; audiocf = 9 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[8].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 9 + edit.asepage *12) { auf = 1; audiocf = 9 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[8].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 9 + edit.asepage *12) { auf = 1; audiocf = 9 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[8].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect8":
                if (edit.audiof==0){if(edit.bgmnum >= 8 + edit.asepage *12) { auf = 1; audiocf = 8 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[7].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 8 + edit.asepage *12) { auf = 1; audiocf = 8 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[7].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 8 + edit.asepage *12) { auf = 1; audiocf = 8 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[7].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect7":
                if (edit.audiof==0){if(edit.bgmnum >= 7 + edit.asepage *12) { auf = 1; audiocf = 7 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[6].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 7 + edit.asepage *12) { auf = 1; audiocf = 7 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[6].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 7 + edit.asepage *12) { auf = 1; audiocf = 7 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[6].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect6":
                if (edit.audiof==0){if(edit.bgmnum >= 6 + edit.asepage *12) { auf = 1; audiocf = 6 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[5].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 6 + edit.asepage *12) { auf = 1; audiocf = 6 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[5].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 6 + edit.asepage *12) { auf = 1; audiocf = 6 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[5].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect5":
                if (edit.audiof==0){if(edit.bgmnum >= 5 + edit.asepage *12) { auf = 1; audiocf = 5 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[4].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 5 + edit.asepage *12) { auf = 1; audiocf = 5 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[4].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 5 + edit.asepage *12) { auf = 1; audiocf = 5 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[4].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect4":
                if (edit.audiof==0){if(edit.bgmnum >= 4 + edit.asepage *12) { auf = 1; audiocf = 4 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[3].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 4 + edit.asepage *12) { auf = 1; audiocf = 4 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[3].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 4 + edit.asepage *12) { auf = 1; audiocf = 4 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[3].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect3":
                if (edit.audiof==0){if(edit.bgmnum >= 3 + edit.asepage *12) { auf = 1; audiocf = 3 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[2].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 3 + edit.asepage *12) { auf = 1; audiocf = 3 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[2].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 3 + edit.asepage *12) { auf = 1; audiocf = 3 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[2].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect2":
                if (edit.audiof==0){if(edit.bgmnum >= 2 + edit.asepage *12) { auf = 1; audiocf = 2 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[1].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 2 + edit.asepage *12) { auf = 1; audiocf = 2 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[1].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 2 + edit.asepage *12) { auf = 1; audiocf = 2 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[1].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "audiotselect1":
                if (edit.audiof==0){if(edit.bgmnum >= 1 + edit.asepage *12) { auf = 1; audiocf = 1 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[0].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==1){if(edit.bgmenum >= 1 + edit.asepage *12) { auf = 1; audiocf = 1 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[0].transform.position = mousep;} else { audiocf = 0;}}
                if (edit.audiof==2){if(edit.bgmefnum >= 1 + edit.asepage *12) { auf = 1; audiocf = 1 + edit.asepage *12; dragp.transform.position=mousep;dragp.SetActive(true); aufiled[0].transform.position = mousep;} else { audiocf = 0;}}
                break;
            case "aused12":
                aufiled[11].transform.position = aufilep[11].transform.position; dragp.SetActive(false);
                break;
            case "aused11":
                aufiled[10].transform.position = aufilep[10].transform.position; dragp.SetActive(false);
                break;
            case "aused10":
                aufiled[9].transform.position = aufilep[9].transform.position; dragp.SetActive(false);
                break;
            case "aused9":
                aufiled[8].transform.position = aufilep[8].transform.position; dragp.SetActive(false);
                break;
            case "aused8":
                aufiled[7].transform.position = aufilep[7].transform.position; dragp.SetActive(false);
                break;
            case "aused7":
                aufiled[6].transform.position = aufilep[6].transform.position; dragp.SetActive(false);
                break;
            case "aused6":
                aufiled[5].transform.position = aufilep[5].transform.position; dragp.SetActive(false);
                break;
            case "aused5":
                aufiled[4].transform.position = aufilep[4].transform.position; dragp.SetActive(false);
                break;
            case "aused4":
                aufiled[3].transform.position = aufilep[3].transform.position; dragp.SetActive(false);
                break;
            case "aused3":
                aufiled[2].transform.position = aufilep[2].transform.position; dragp.SetActive(false);
                break;
            case "aused2":
                aufiled[1].transform.position = aufilep[1].transform.position; dragp.SetActive(false);
                break;
            case "aused1":
                aufiled[0].transform.position = aufilep[0].transform.position; dragp.SetActive(false);
                break;
            case "audioseb5":
                audiosebf = 1;
                auf = 1;
                break;
            case "audioseb4":
                audiosebf = 2;
                auf = 1;
                break;
            case "audioseb3":
                audiosebf = 3;
                auf = 1;
                break;
            case "audioseb2":
                audiosebf = 4;
                auf = 1;
                break;
            case "audioseb1":
                audiosebf = 5;
                auf = 1;
                break;
            case "ahu":
                if (edit.audiof == 0) { System.Array.Resize(ref script.bgmhantei, textt.bgms + 1); System.Array.Resize(ref script.bgmnum, textt.bgms + 1); textt.bgms += 1; edit.bgm_num = 0; }
                if (edit.audiof == 1) { System.Array.Resize(ref script.bgmehantei, textt.bgmes + 1);System.Array.Resize(ref script.bgmenum, textt.bgmes * 2 + 2); textt.bgmes += 1; edit.bgme_num = 0; }
                if (edit.audiof == 2) { System.Array.Resize(ref script.bgmefhantei, textt.bgmefs + 1);System.Array.Resize(ref script.bgmefnum, textt.bgmefs + 1); textt.bgmefs += 1; edit.bgmef_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "ahe":
                if (edit.audiof == 0 & textt.bgms > 5) { System.Array.Resize(ref script.bgmhantei, textt.bgms - 1); System.Array.Resize(ref script.bgmnum, textt.bgms - 1); textt.bgms -= 1; edit.bgm_num = 0; }
                if (edit.audiof == 1 & textt.bgmes > 5) { System.Array.Resize(ref script.bgmehantei, textt.bgmes - 1);System.Array.Resize(ref script.bgmenum, textt.bgmes * 2 - 2); textt.bgmes -= 1; edit.bgme_num = 0; }
                if (edit.audiof == 2 & textt.bgmefs > 5) { System.Array.Resize(ref script.bgmefhantei, textt.bgmefs - 1); System.Array.Resize(ref script.bgmefnum, textt.bgmefs - 1); textt.bgmefs -= 1; edit.bgmef_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "aup":
                if (edit.audiof == 0 & edit.bgm_num > 5) { edit.bgm_num -= 1; }
                if (edit.audiof == 1 & edit.bgme_num > 5) { edit.bgme_num -= 1; }
                if (edit.audiof == 2 & edit.bgmef_num > 5) { edit.bgmef_num -= 1; }
                break;
            case "adown":
                if (edit.audiof == 0 & edit.bgm_num < textt.bgms) { edit.bgm_num += 1; }
                if (edit.audiof == 1 & edit.bgme_num < textt.bgmes) { edit.bgme_num += 1; }
                if (edit.audiof == 2 & edit.bgmef_num < textt.bgmefs) { edit.bgmef_num += 1; }
                break;
            case "amax":
                edit.bgm_num = textt.bgms;
                edit.bgme_num = textt.bgmes;
                edit.bgmef_num = textt.bgmefs;
                break;
            case "amin":
                edit.bgm_num = 5;
                edit.bgme_num = 5;
                edit.bgmef_num = 5;
                break;
            case "amigi":
                if (edit.audiof==0&edit.asepage < textt.bgms) { edit.asepage += 1; }
                if (edit.audiof==1&edit.asepage < textt.bgmes) { edit.asepage += 1; }
                if (edit.audiof==2&edit.asepage < textt.bgmefs) { edit.asepage += 1; }
                break;
            case "ahidari":
                if (edit.asepage >0) { edit.asepage -= 1; }
                break;
            case "aik":
                auikf = 1;
                auf = 1;
                break;
            case "video":
                edit.editp = 7;
                break;
            case "videoselect5":
                videosef = 1;
                vif = 1;
                break;
            case "videoselect4":
                videosef = 2;
                vif = 1;
                break;
            case "videoselect3":
                videosef = 3;
                vif = 1;
                break;
            case "videoselect2":
                videosef = 4;
                vif = 1;
                break;
            case "videoselect1":
                videosef = 5;
                vif = 1;
                break;
            case "videoplay":
                if (edit.videoph == 0) { if (videoonf > 0) { edit.videopf = 1; } } else { edit.videosf = 1; }
                break;
            case "videoon12":
                if (edit.videonum >= 12 + edit.vsepage * 12)
                {
                    videoonf = 12 + edit.vsepage * 12;
                }
                break;            
            case "videoon11":
                if (edit.videonum >= 11 + edit.vsepage * 12)
                {
                    videoonf = 11 + edit.vsepage * 12;
                }
                break;            
            case "videoon10":
                if (edit.videonum >= 10 + edit.vsepage * 12)
                {
                    videoonf = 10 + edit.vsepage * 12;
                }
                break;            
            case "videoon9":
                if (edit.videonum >= 9 + edit.vsepage * 12)
                {
                    videoonf = 9 + edit.vsepage * 12;
                }
                break;            
            case "videoon8":
                if (edit.videonum >= 8 + edit.vsepage * 12)
                {
                    videoonf = 8 + edit.vsepage * 12;
                }
                break;            
            case "videoon7":
                if (edit.videonum >= 7 + edit.vsepage * 12)
                {
                    videoonf = 7 + edit.vsepage * 12;
                }
                break;            
            case "videoon6":
                if (edit.videonum >= 6 + edit.vsepage * 12)
                {
                    videoonf = 6 + edit.vsepage * 12;
                }
                break;            
            case "videoon5":
                if (edit.videonum >= 5 + edit.vsepage * 12)
                {
                    videoonf = 5 + edit.vsepage * 12;
                }
                break;            
            case "videoon4":
                if (edit.videonum >= 4 + edit.vsepage * 12)
                {
                    videoonf = 4 + edit.vsepage * 12;
                }
                break;            
            case "videoon3":
                if (edit.videonum >= 3 + edit.vsepage * 12)
                {
                    videoonf = 3 + edit.vsepage * 12;
                }
                break;            
            case "videoon2":
                if (edit.videonum >= 2 + edit.vsepage * 12)
                {
                    videoonf = 2 + edit.vsepage * 12;
                }
                break;            
            case "videoon1":
                if (edit.videonum >= 1 + edit.vsepage * 12)
                {
                    videoonf = 1 + edit.vsepage * 12;
                }
                break;
            case "videotselect12":
                 if (edit.videonum >= 12 + edit.vsepage * 12) { vif = 1; videocf = 12 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[11].transform.position = mousep; }
                break;
            case "videotselect11":
                 if (edit.videonum >= 11 + edit.vsepage * 12) { vif = 1; videocf = 11 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[10].transform.position = mousep; }
                break;
            case "videotselect10":
                 if (edit.videonum >= 10 + edit.vsepage * 12) { vif = 1; videocf = 10 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[9].transform.position = mousep; }
                break;
            case "videotselect9":
                 if (edit.videonum >= 9 + edit.vsepage * 12) { vif = 1; videocf = 9 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[8].transform.position = mousep; }
                break;
            case "videotselect8":
                 if (edit.videonum >= 8 + edit.vsepage * 12) { vif = 1; videocf = 8 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[7].transform.position = mousep; }
                break;
            case "videotselect7":
                 if (edit.videonum >= 7 + edit.vsepage * 12) { vif = 1; videocf = 7 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[6].transform.position = mousep; }
                break;
            case "videotselect6":
                 if (edit.videonum >= 6 + edit.vsepage * 12) { vif = 1; videocf = 6 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[5].transform.position = mousep; }
                break;
            case "videotselect5":
                 if (edit.videonum >= 5 + edit.vsepage * 12) { vif = 1; videocf = 5 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[4].transform.position = mousep; }
                break;
            case "videotselect4":
                 if (edit.videonum >= 4 + edit.vsepage * 12) { vif = 1; videocf = 4 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[3].transform.position = mousep; }
                break;
            case "videotselect3":
                 if (edit.videonum >= 3 + edit.vsepage * 12) { vif = 1; videocf = 3 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[2].transform.position = mousep; }
                break;
            case "videotselect2":
                 if (edit.videonum >= 2 + edit.vsepage * 12) { vif = 1; videocf = 2 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[1].transform.position = mousep; }
                break;
            case "videotselect1":
                 if (edit.videonum >= 1 + edit.vsepage * 12) { vif = 1; videocf = 1 + edit.vsepage * 12; dragp.transform.position=mousep;dragp.SetActive(true); vifiled[0].transform.position = mousep; }
                break;
            case "visd12":
                vifiled[11].transform.position = vifilep[11].transform.position; dragp.SetActive(false);
                break;
            case "visd11":
                vifiled[10].transform.position = vifilep[10].transform.position; dragp.SetActive(false);
                break;
            case "visd10":
                vifiled[9].transform.position = vifilep[9].transform.position; dragp.SetActive(false);
                break;
            case "visd9":
                vifiled[8].transform.position = vifilep[8].transform.position; dragp.SetActive(false);
                break;
            case "visd8":
                vifiled[7].transform.position = vifilep[7].transform.position; dragp.SetActive(false);
                break;
            case "visd7":
                vifiled[6].transform.position = vifilep[6].transform.position; dragp.SetActive(false);
                break;
            case "visd6":
                vifiled[5].transform.position = vifilep[5].transform.position; dragp.SetActive(false);
                break;
            case "visd5":
                vifiled[4].transform.position = vifilep[4].transform.position; dragp.SetActive(false);
                break;
            case "visd4":
                vifiled[3].transform.position = vifilep[3].transform.position; dragp.SetActive(false);
                break;
            case "visd3":
                vifiled[2].transform.position = vifilep[2].transform.position; dragp.SetActive(false);
                break;
            case "visd2":
                vifiled[1].transform.position = vifilep[1].transform.position; dragp.SetActive(false);
                break;
            case "visd1":
                vifiled[0].transform.position = vifilep[0].transform.position; dragp.SetActive(false);
                break;
            case "videoseb5":
                videosebf = 1;
                vif = 1;
                break;
            case "videoseb4":
                videosebf = 2;
                vif = 1;
                break;
            case "videoseb3":
                videosebf = 3;
                vif = 1;
                break;
            case "videoseb2":
                videosebf = 4;
                vif = 1;
                break;
            case "videoseb1":
                videosebf = 5;
                vif = 1;
                break;
            case "vhu":
                 System.Array.Resize(ref script.videohantei, textt.videos + 1); System.Array.Resize(ref script.videonum, textt.videos + 1); textt.videos += 1; edit.video_num = 0;
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "vhe":
                if (textt.videos > 5) { System.Array.Resize(ref script.videohantei, textt.videos - 1); System.Array.Resize(ref script.videonum, textt.videos - 1); textt.videos -= 1; edit.video_num = 0; }
                edittext.sif += 1;
                edittext.simf = edittext.sif;
                susumu.sinkf = 1;
                break;
            case "vup":
                if (edit.video_num > 5) { edit.video_num -= 1; }
                break;
            case "vdown":
                if (edit.video_num < textt.videos) { edit.video_num += 1; }
                break;
            case "vmax":
                edit.video_num = textt.videos;
                break;
            case "vmin":
                edit.video_num = 5;
                break;
            case "vmigi":
                if (edit.audiof == 0 & edit.vsepage < textt.bgms) { edit.vsepage += 1; }
                if (edit.audiof == 1 & edit.vsepage < textt.bgmes) { edit.vsepage += 1; }
                if (edit.audiof == 2 & edit.vsepage < textt.bgmefs) { edit.vsepage += 1; }
                break;
            case "vhidari":
                if (edit.vsepage > 0) { edit.vsepage -= 1; }
                break;
            case "viik":
                viikf = 1;
                vif = 1;
                break;
            default:
                break;
        }
    }
}
