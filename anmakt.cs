using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anmakt : MonoBehaviour
{
    public int antenthantei;
    public int antentflag;
    public int endtflag;
    public int gamelogohantei;
    public int logox;
    public static float antent;
    public GameObject anmaku;
    // Start is called before the first frame update
    void Start()
    {
        antenthantei = 2;
        antent = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        antenthantei = ButtonManager.antenthantei;
        endtflag = tpointerenter.endtflag;
        
        if ((antenthantei >= 1) & (antenthantei < 2))
        {

            anmaku.SetActive(true);
            Image annmakt = anmaku.GetComponent<Image>();
            annmakt.GetComponent<Image>().color = new Color(0, 0, 0, antent);
            gamelogohantei = ButtonManager.gamelogohantei;
            if (gamelogohantei == 0)
            {
                if (Load.loadflag == 1)
                {
                    antent += 0.05f;
                }
                else
                {
                    antent += 0.0035f;
                }
            }
            else
            {
        
                    antent += 0.007f;
            }
            if (antent > 1)
            {
                if (endtflag>=1)
                {
                    Application.Quit();
                }
                gamelogohantei = ButtonManager.gamelogohantei;
                if (gamelogohantei == 0)
                {
                    antenthantei = 0;
                    ButtonManager.titlebx = -1;
                    tpointerenter.tloadf = 0;
                    SceneManager.LoadScene("SampleScene");
                }
                logox = titlebg.logox;
                if (gamelogohantei>=1)
                {
                    ButtonManager.gamelogohantei += 1;
                    ButtonManager.antenthantei = 2;
                    if (gamelogohantei>logox)
                    {
                        ButtonManager.gamelogohantei = 0;
                    }
                }
                
                
            }
        }
        if (antenthantei >= 2)
        {
            Image annmak = anmaku.GetComponent<Image>();
            annmak.GetComponent<Image>().color = new Color(0, 0, 0, antent);
            gamelogohantei = ButtonManager.gamelogohantei;
              if(gamelogohantei>=1&Input.GetMouseButtonDown(0))
        {
                    antent = -1;
                }
            antent -= 0.007f;
            if (antent < 0)
            {
                ButtonManager.antenthantei = 0;
                antent = 0;
                anmaku.SetActive(false);
            }
        }
    }
}

