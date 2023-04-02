using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class susumuk : MonoBehaviour
{
    public int dsinf;
    public static int dsinkf;
    public string filePath;
    public string fPath;
    public static int rwf;
    public InputField titleny;
    textt script;
    edit script2;


    [SerializeField]
    public class SaveDataE
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
    SaveDataE e = new SaveDataE();

    void Awake()
    {
        filePath = Application.dataPath + "/SAVEDATA/chart/whole/" + "s" + dsinf + ".json"; e = new SaveDataE();

    }
    void Start()
    {
        fPath = Application.dataPath + "/SAVEDATA/chart/whole";
        if (Directory.Exists(fPath) == false)
        {
            Directory.CreateDirectory(fPath);
        }
        DirectoryInfo sfile = new DirectoryInfo(fPath);
        FileInfo[] files = sfile.GetFiles();
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
        script = GameObject.Find("textt").GetComponent<textt>();
    }
    void Update()
    {
        fPath = Application.dataPath + "/SAVEDATA/chart/whole";
        if (Directory.Exists(fPath) == false)
        {
            Directory.CreateDirectory(fPath);
        }
        if (dsinkf == 1)
        {
            dsinkf = 0;
            dsinf = edittext.dsif % 1000 + 1;
            Rewrite();
        }
        if (dsinkf == 2)
        {
            dsinkf = 0;
            dsinf = edittext.dsif % 1000 + 1;
            Reload();
        }
    }
    public void Rewrite()
    {
        e.sentakufc = textti.sentakuf;
        e.sentakutypesc = script.sentakutypes;
        e.sentakuknumc = script.sentakuknum;
        e.sentakubnumc = script.sentakubnum;
        e.sentakudnumc = script.sentakudnum;
        e.aehanteic = script.aehantei;
        e.uitnumc = script.uitnum;
        e.uignumc = script.uignum;
        e.gamelogohanteic = script.gamelogohantei;
        StreamWriter writer;
        string jsonstr = JsonUtility.ToJson(e);
        writer = new StreamWriter(Application.dataPath + "/SAVEDATA/chart/whole/" + "s" + dsinf + ".json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
    public void Reload()
    {
        if (File.Exists(Application.dataPath + "/SAVEDATA/chart/whole/" + "s" + dsinf + ".json"))
        {
            {
                var fs = new FileStream(
                   Application.dataPath + "/SAVEDATA/chart/whole/" + "s" + dsinf + ".json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string datastr = "";
                StreamReader reader;
                reader = new StreamReader(fs);
                reader = new StreamReader(Application.dataPath + "/SAVEDATA/chart/whole/" + "s" + dsinf + ".json");
                datastr = reader.ReadToEnd();
                reader.Close();
                e = JsonUtility.FromJson<SaveDataE>(datastr);
                script.sentakutypes = e.sentakutypesc;
                script.sentakuknum = e.sentakuknumc;
                script.sentakubnum = e.sentakubnumc;
                script.sentakudnum = e.sentakudnumc;
                script.aehantei = e.aehanteic;
                script.uitnum = e.uitnumc;
                script.uignum = e.uignumc;
                script.gamelogohantei = e.gamelogohanteic;
            }
        }
    }
}
