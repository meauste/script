using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveloadc : MonoBehaviour
{
    public string cPath;
    public string filePath;
    public AudioSource audios;
    public AudioSource audioes;
    public AudioSource audioefs;
    public AudioSource audioso;
    public static int savecf;

    [SerializeField]
    public class SaveDatac
    {
        //テスト用の文字列
        public float texttimel;
        public float autottl;
        public int bgmxl;
        public float audiovl;
        public float audioevl;
        public float audioefvl;
        public float audiosysvl;
        public int gsexl;
        public int s1nf;
        public int s1nfl;
        public int s2nf;
        public int s3nf;
        public int s4nf;
        public int s5nf;
        public int s6nf;
        public int outfl;
        public float fsl;
        public int nextstl;
        public int foxl;

    }
    SaveDatac savec = new SaveDatac();
    void Awake()
    {
        filePath = Application.dataPath + "/SAVEDATA/config/conf.json"; savec = new SaveDatac();

    }
    void Update()
    {
        if (configco.csavef == 1)
        {
            configco.csavef = 0;
            Save();
        }
        if (configco.csavef==2)
        {
            configco.csavef = 0;
            Load();
        }
    }
    public void Start()
    {
        cPath = Application.dataPath + "/SAVEDATA/config";
        if (Directory.Exists(cPath) == false)
        {
            Directory.CreateDirectory(cPath);
        }
        if (File.Exists(Application.dataPath + "/SAVEDATA/config/conf.json") == true)
        {
            Load();
        }
        else
        {
            textti.gsex = 0;
            textti.gspf = 0;
            textti.fsi = 35;
            textti.texttime = 4 * 0.25f * 0.02f;
            textti.autott = 4 * 0.25f * 1.5f;
            textti.audiov = 0.5f;
            textti.audioev = 0.5f;
            textti.audioefv = 0.5f;
            textti.audiosofv = 0.5f;
            Save();
        }

    }
    public void Save()
    {
            savec.texttimel = textti.texttime;
            savec.autottl=textti.autott;
            savec.gsexl = textti.gsex;
            savec.audiovl = textti.audiov;
            savec.audioevl= textti.audioev;
            savec.audioefvl = textti.audioefv;
            savec.audiosysvl = textti.audiosofv;
            savec.s1nf = textti.s1nf;
            savec.s1nfl = SaveManager.s1nfl;
            savec.s2nf = SaveManager.s2nf;
            savec.s3nf = SaveManager.s3nf;
            savec.s4nf = SaveManager.s4nf;
            savec.s5nf = SaveManager.s5nf;
            savec.s6nf = SaveManager.s6nf;
            savec.outfl = textti.outf;
            savec.fsl = textti.fsi;
            savec.nextstl = textti.nextst;
            savec.foxl = textti.fox;
            savec.gsexl = textti.gsex;
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(savec);
        writer = new StreamWriter(Application.dataPath + "/SAVEDATA/config/conf.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
        savecf = 0;
    }
    public void Load()
    {
        var fs = new FileStream(
         filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(fs);
        reader = new StreamReader(Application.dataPath + "/SAVEDATA/config/conf.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        savec = JsonUtility.FromJson<SaveDatac>(datastr);
        textti.texttime = savec.texttimel;
        textti.autott = savec.autottl;
        textti.gsex = savec.gsexl;
        textti.s1nf = savec.s1nf;
        SaveManager.s2nf = savec.s2nf;
        SaveManager.s3nf = savec.s3nf;
        SaveManager.s4nf = savec.s4nf;
        SaveManager.s5nf = savec.s5nf;
        SaveManager.s6nf = savec.s6nf;
        SaveManager.s1nfl = savec.s1nfl;
        textti.s1nfll = savec.s1nfl;
        textti.s2nfl = savec.s2nf;
        textti.s3nfl = savec.s3nf;
        textti.s4nfl = savec.s4nf;
        textti.s5nfl = savec.s5nf;
        textti.s6nfl = savec.s6nf;
        textti.outf = savec.outfl;
        textti.gsex = savec.gsexl;
        textti.audiov = savec.audiovl;
        textti.audioev = savec.audioevl;
        textti.audioefv = savec.audioefvl;
        textti.audiosofv = savec.audiosysvl;
        textti.fsi = savec.fsl;
        textti.nextst = savec.nextstl;
        textti.fox = savec.foxl;
        audios.volume = textti.audiov;
        audioes.volume = textti.audioev;
        audioefs.volume = textti.audioefv;
        audioso.volume = textti.audiosofv;
    }
}