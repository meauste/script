using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class convertt : MonoBehaviour
{
    public InputField textny;
    public InputField ctny;
    public string filePath;
    public string sPath;
    public string tPath;
    public static int csf;
    public string test;
    [SerializeField]
    public class SaveDataE
    {
        public string textalls;
    }
    SaveDataE ct  = new SaveDataE();
    void Start()
    {
        sPath = Application.dataPath + "/SAVEDATA";
        if (Directory.Exists(sPath)==false)
        {
            Directory.CreateDirectory(sPath);
        }
        tPath = Application.dataPath + "/SAVEDATA/txt";
        if (Directory.Exists(tPath)==false)
        {
            Directory.CreateDirectory(tPath);
        }
    }
    void Update()
    {
        test = textt.textallct;
        ct.textalls = textt.textallct;
        if (csf == 1)
        {
            if (edit.editp != 5)
            {
                edit.ctname = textny.text;
            }
            else
            {
                edit.ctname = ctny.text;
            }
            if (edit.ctname==""|edit.ctname==null)
            {
                int nln=Directory.GetFiles(tPath).Count(s => s.Contains("nameless") == true);
                if (nln > 0)
                {
                    edit.ctname = "nameless(" + nln + ")";
                }
                else
                {
                    edit.ctname = "nameless";
                }
            }
            edit.cf=1;
            Rewrite();
        }
        if (csf==2)
        {
            edit.cf = 1;
            Reload();
        }

    }
    public void Rewrite()
    {
        csf = 0;
        filePath = Application.dataPath + "/SAVEDATA/txt/" + edit.ctname + ".txt";
        File.WriteAllText(filePath, ct.textalls);
    }
    public void Reload()
    {
        csf = 0;
        if (File.Exists(Application.dataPath + "/SAVEDATA/txt/" + edit.ctname + ".txt"))
            {
            filePath = Application.dataPath + "/SAVEDATA/txt/" + edit.ctname + ".txt";
            textt.textallct = File.ReadAllText(filePath);

            textt.dataload = 2;
        }
    }
}
