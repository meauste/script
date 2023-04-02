using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGbutton15 : MonoBehaviour
{
    public GameObject LOGkp;
    public int text_num;
    public int text_snum;
    public static int chaptsf;
    public static int chaptshanteif;
    public void Update()
    {
        text_snum = LOGtext.text_snum;
        text_num = TextManager.text_num;
    }
    public void TappedButton(string button)
    {

       
        switch (button)
        {
            case "1":
                if (LOGtext.resm == 0 & LOGtext.text_snum <=TextManager.text_num & LOGtext.text_snum> 0 | LOGtext.resm > 0 & LOGtext.resm >= 1)
                {
                    sound.soundflag = 2;
                    LOGkp.SetActive(true);
                    Image chra1 = LOGkp.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(1, 0, 0);
                    LOGktext.mwxfl = 1;
                    LOGktext.loglf = 1;
                    LOGktext.loglx = 1;
                }
                break;
            case "2":
                if (LOGtext.resm == 0 & LOGtext.text_snum <=TextManager.text_num & LOGtext.text_snum> 1 | LOGtext.resm > 0 & LOGtext.resm >= 2)
                {
                    sound.soundflag = 2;
                    LOGkp.SetActive(true);
                    Image chra1 = LOGkp.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(1, 0, 0);
                    LOGktext.mwxfl = 1;
                    LOGktext.loglf = 1;
                    LOGktext.loglx = 2;
                }
                break;
            case "3":
                if (LOGtext.resm == 0 & LOGtext.text_snum <=TextManager.text_num & LOGtext.text_snum> 2 | LOGtext.resm > 0 & LOGtext.resm >= 3)
                {
                    sound.soundflag = 2;
                    LOGkp.SetActive(true);
                    Image chra1 = LOGkp.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(1, 0, 0);
                    LOGktext.mwxfl = 1;
                    LOGktext.loglf = 1;
                    LOGktext.loglx = 3;
                }
                break;
            case "4":
                if (LOGtext.resm == 0 & LOGtext.text_snum <=TextManager.text_num & LOGtext.text_snum> 3 | LOGtext.resm > 0 & LOGtext.resm >= 4)
                {
                    sound.soundflag = 2;
                    LOGkp.SetActive(true);
                    Image chra1 = LOGkp.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(1, 0, 0);
                    LOGktext.mwxfl = 1;
                    LOGktext.loglf = 1;
                    LOGktext.loglx = 4;
                }
                break;
            case "5":
                if (LOGtext.resm == 0 & LOGtext.text_snum <=TextManager.text_num & LOGtext.text_snum> 4 | LOGtext.resm > 0 & LOGtext.resm >= 5)
                {
                    sound.soundflag = 2;
                    LOGkp.SetActive(true);
                    Image chra1 = LOGkp.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(1, 0, 0);
                    LOGktext.mwxfl = 1;
                    LOGktext.loglf = 1;
                    LOGktext.loglx = 5;
                }
                break;
            case "down":
                if (LOGktext.loglf == 0)
                {

                    if (LOGtext.resm <= 0)
                    {
                        if (text_snum <= text_num)
                        {
                            LOGtext.text_snum += 1;
                            sound.soundflag = 1;
                        }
                    }
                    else
                    {
                        if (LOGtext.resm > 0 & LOGtext.text_rnum < LOGtext.resm)
                        {
                            sound.soundflag = 1;
                            LOGtext.text_rnum += 1;
                        }
                    }
                }
                break;
            case "r1":
                LOGtext.rflag = 1;
                break;
            case "r2":
                LOGtext.rflag = 2;
                break;
            case "r3":
                LOGtext.rflag = 3;
                break;
            case "r4":
                LOGtext.rflag = 4;
                break;
            case "r5":
                LOGtext.rflag = 5;
                break;
            case "up":
                if (LOGtext.resm <= 0 & text_snum>1&LOGktext.loglf == 0)
                {
                    sound.soundflag = 1;
                    LOGtext.text_snum -= 1;
                    chaptsf = 1;
                }
                if (LOGtext.resm > 0 & LOGktext.loglf == 0)
                {
                    if (LOGtext.text_rnum > 5)
                    {
                        sound.soundflag = 1;
                        LOGtext.text_rnum -= 1;
                    }
                }
                break;
            case "cup":
          
                if (text_num > 0 & text_num < 105)
                {
                    sound.soundflag = 2;
                    LOGtext.text_snum = 9;
                }
                if (text_num >= 105 & text_snum >= text_num - 95)
                {
                    sound.soundflag = 2;
                    LOGtext.text_snum = text_num - 95;
                }
                break;
                    case "cdown":
                if (text_num > 0 & (text_snum <= text_num))
                {

                    sound.soundflag = 2;
                    LOGtext.text_snum = text_num;
                }
                break;
         
            

            default:
                break;
        }
    }
}


