using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class saveloadk : MonoBehaviour
{
    public static int usf;
    public static int startf;
    public static string ujssname;
    public string ffilePath;
    public string filePath;
    public static int savecf;
    public string wfPath;
    public InputField titleny;
    public List<string> gamelogohanteil;
    textt script;
    textti script2;
    saveload script3;
    [SerializeField]
    public class SaveDatafc
    {
        public string loaddatac;
    }
    SaveDatafc fc = new SaveDatafc();
    [SerializeField]
    public class SaveDatac
    {
        public string sentakufc;
        public int[] sentakutypesc;
        public string[] sentakuknumc;
        public string[] sentakubnumc;
        public string[] sentakudnumc;
        public int[] aehanteic;
        public string[] uitnumc;
        public string[] uignumc;
        public string[] gamelogohanteic;
    }
    SaveDatac c = new SaveDatac();
    void Awake()
    {
        ffilePath = Application.dataPath + "/SAVEDATA/config/ss.json"; fc = new SaveDatafc();

    }
    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            script2 = GameObject.Find("textti").GetComponent<textti>();
            script3 = GameObject.Find("textti").GetComponent<saveload>();
            Load();
        }
        else
        {
            script = GameObject.Find("textt").GetComponent<textt>();
            ffilePath = Application.dataPath + "/SAVEDATA/config/ss.json";
            if (File.Exists(ffilePath))
            {
                startf = 1;
                lLoad();
            }
            else
            {
                gamelogohanteil = new List<string>(script.gamelogohanteio);
                gamelogohanteil.RemoveAll(item => item == string.Empty | item == null);
                script.gamelogohanteio = gamelogohanteil.ToArray();
            }
        }
    }
    public void Update()
    {
        wfPath = Application.dataPath + "/SAVEDATA/json/";
        if (Directory.Exists(wfPath) == false)
        {
            Directory.CreateDirectory(wfPath);
        }
        if (usf == 1)
        {
            usf = 0;
            if (ujssname != string.Empty)
            {
                string sPath = Application.dataPath + "/SAVEDATA/savedata/" + ujssname;
                string tPath = Application.dataPath + "/SAVEDATA/log/" + ujssname;
                if (Directory.Exists(sPath) == false)
                {
                    Directory.CreateDirectory(sPath);
                }
                DirectoryInfo sfile = new DirectoryInfo(sPath);
                FileInfo[] sfiles = sfile.GetFiles();
                foreach (FileInfo files in sfiles)
                {
                    files.Delete();
                }
                if (Directory.Exists(tPath) == false)
                {
                    Directory.CreateDirectory(tPath);
                }
                DirectoryInfo tfile = new DirectoryInfo(tPath);
                FileInfo[] tfiles = tfile.GetFiles();
                foreach (FileInfo filet in tfiles)
                {
                    filet.Delete();
                }
            }
            edittext.savef = edittext.simf;
            editco.chf = -1;
            edit.cf = 1;
            Save();
        }
        if (usf == 2)
        {
            usf = 0;
            titleny.text = ujssname;
            edittext.dsif = 0;
            edittext.dsimf = edittext.dsif;
            susumuk.dsinkf = 1;
            edittext.savef = edittext.dsimf;
            edit.editp = 10;
            editco.chf = -1;
            edit.cf = 1;
            Load();
        }
        if (usf == 3)
        {
            usf = 0;
            lSave();
        }
        if (usf == 4)
        {
            usf = 0;
            lLoad();
        }
    }
    public void Save()
    {
        usf = 0;
        filePath = Application.dataPath + "/SAVEDATA/json/whole/" + ujssname + ".json"; c = new SaveDatac();
        c.sentakufc = textti.sentakuf;
        c.sentakutypesc = script.sentakutypes;
        c.sentakuknumc = script.sentakuknum;
        c.sentakubnumc = script.sentakubnum;
        c.sentakudnumc = script.sentakudnum;
        c.aehanteic = script.aehantei;
        c.uitnumc = script.uitnum;
        c.uignumc = script.uignum;
        c.gamelogohanteic = script.gamelogohantei;
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(c);
        writer = new StreamWriter(filePath, false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        savecf = 0;
    }
    public void Load()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            filePath = Application.dataPath + "/SAVEDATA/json/whole/" + textti.loaddata + ".json"; c = new SaveDatac();
        }
        else
        {
            filePath = Application.dataPath + "/SAVEDATA/json/whole/" + ujssname + ".json"; c = new SaveDatac();
        }
        if (File.Exists(filePath))
        {
            var fs = new FileStream(
             filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            string datastr = string.Empty;
            StreamReader reader;
            reader = new StreamReader(fs);
            reader = new StreamReader(filePath);
            datastr = reader.ReadToEnd();
            reader.Close();

            c = JsonUtility.FromJson<SaveDatac>(datastr);
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                script2.sentakutypes = c.sentakutypesc;
                script2.sentakuknum = c.sentakuknumc;
                script2.sentakubnum = c.sentakubnumc;
                script2.sentakudnum = c.sentakudnumc;
                script2.aehantei = c.aehanteic;
                script2.uignum = c.uignumc;
                script2.Reload();
            }
            else
            {
                if (startf == 1)
                {
                    script.uitnumo = c.uitnumc;
                    script.gamelogohanteio = c.gamelogohanteic;
                    gamelogohanteil = new List<string>(script.gamelogohanteio);
                    gamelogohanteil.RemoveAll(item => item == string.Empty | item == null);
                    script.gamelogohanteio = gamelogohanteil.ToArray();
                    startf = 0;
                }
                else
                {
                    script.aehantei = c.aehanteic;
                    script.uitnum = c.uitnumc;
                    script.uignum = c.uignumc;
                    script.gamelogohantei = c.gamelogohanteic;
                    if (tloadco.tloadflag == 0)
                    {
                        script.sentakutypes = c.sentakutypesc;
                        script.sentakuknum = c.sentakuknumc;
                        script.sentakubnum = c.sentakubnumc;
                        script.sentakudnum = c.sentakudnumc;
                        edit.sentaku_num = 0;
                        textt.sentakus = script.sentakuknum.Length;
                    }
                    else
                    {
                        script3.Load();
                    }
                }
                
            }
        }
    }
    public void lSave()
    {
        ffilePath = Application.dataPath + "/SAVEDATA/config/ss.json"; fc = new SaveDatafc();
        fc.loaddatac = textti.loaddata;
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(fc);
        writer = new StreamWriter(ffilePath, false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        savecf = 0;
    }
    public void lLoad()
    {
        ffilePath = Application.dataPath + "/SAVEDATA/config/ss.json"; fc = new SaveDatafc();
        if (File.Exists(ffilePath))
        {
            var fs = new FileStream(
             ffilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            string datastr = string.Empty;
            StreamReader reader;
            reader = new StreamReader(fs);
            reader = new StreamReader(ffilePath);
            datastr = reader.ReadToEnd();
            reader.Close();
            fc = JsonUtility.FromJson<SaveDatafc>(datastr);
            ujssname=textti.loaddata = fc.loaddatac;
            if (SceneManager.GetActiveScene().name == "Title")
            {
                startf = 1;
                Load();
            }
        }
    }
}