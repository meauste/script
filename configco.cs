using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configco : MonoBehaviour
{
    public static int topx;
    public static int taux;
    public static int bgmx;
    public static int bgmex;
    public static int bgmefx;
    public static int bgmsox;
    public static int csavef;
    public static int bgmanf;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TappedButton(string button)
    {


        switch (button)
        {
            case "topm":
                if (topx > 1)
                {
                    topx -= 1;
                }
                break;
            case "topt":
                if (topx <= 6)
                {
                    topx += 1;
                }
                break;
            case "taum":
                if (taux > 1)
                {
                    taux -= 1;
                }
                break;
            case "taut":
                if (taux <= 6)
                {
                    taux += 1;
                }
                break;
            case "bgman":
                bgmanf = 1;
                if (configmenu.bgmvol > 0) { configmenu.bgmvol = 0; } else { configmenu.bgmvol = 0.5f; }
                break;
            case "bgmean":
                bgmanf = 1;
                if (configmenu.bgmevol > 0) { configmenu.bgmevol = 0; } else { configmenu.bgmevol = 0.5f; }
                break;
            case "bgmefan":
                bgmanf = 1;
                if (configmenu.bgmefvol > 0) { configmenu.bgmefvol = 0; } else { configmenu.bgmefvol = 0.5f; }
                break;
            case "bgmsysan":
                bgmanf = 1;
                if (configmenu.bgmsysvol > 0) { configmenu.bgmsysvol = 0; } else { configmenu.bgmsysvol = 0.5f; }
                break;
            case "gsmm":
                if (textti.gsex > 0)
                {
                    textti.gsex -= 1;
                    textti.gspf = 1;
                }
                break;
            case "gsmt":
                if (textti.gsex < 2)
                {
                    textti.gsex += 1;
                    textti.gspf = 1;
                }
                break;
            case "font":
                textti.fox += 1;
                if (textti.fox > 2)
                {
                    textti.fox = 0;
                }
                break;
            case "nsm":
                if (textti.nextst >0)
                {
                    textti.nextst -= 1;
                }
                break;
            case "nst":
                if (textti.nextst < 2)
                {
                    textti.nextst += 1;
                }
                break;
            case "outlinem":
                textti.outf = 0;
                break;
            case "outlinet":
                textti.outf = 1;
                break;
            default:
                break;
        }
    }
}
