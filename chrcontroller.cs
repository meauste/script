using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class chrcontroller : MonoBehaviour
{

    public static int daruf;
    public static float darugage;
    public int darufx;
    public float darumx;

    public static int px;
    public int chrpx;
    public int unazpx;
    public int odorokipx;
    public int arrivepx;
    public static int cpx;
    public static int chsf;
    public int animft;
    public GameObject chr1body;
    public GameObject chr2body;
    public GameObject chr3body;
    public GameObject chr1c;
    public GameObject chr2c;
    public GameObject chr3c;
    public GameObject chr4body;
    public GameObject chr5body;
    public GameObject chr6body;
    public GameObject chr4c;
    public GameObject chr5c;
    public GameObject chr6c;
    public static int kf;
    public GameObject nt;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    textti script;
    private Material material;
    public int text_num;
    public int antenhantei = TextManager.antenhantei;
    public float bgcgage;
    public int chrchantei;
    public int chracfhantei;
    public int chrchanteit;
    public int unazhantei;
    public int unazchr;
    public int odorokihantei;
    public int arrivehantei;
    public static int arrivef;
    public static int arrivegage;
    public int arrivechr;
    public static int arrivex;
    public int arriveshantei;
    public int arrivesf;
    public static int arrivesgage;
    public int arriveschr;
    public static int arrivesx;
    public int odorokichr;
    public int okiagarihantei;
    public int okiagarihanteit;
    public static int okiagarix;
    public static int okiagari1x;
    public static int okiagari2x;
    public static int okiagari3x;
    public int okiagarichr;
    public static int okiagarif;
    public int okiagaripx;
    public int okiagaric;
    public static int okiagarigage;
    public int darupx;
    public static int fhantei;
    public static int animf;
    public static int unazx;
    public static int odorokix;
    public static int chrcx;
    public static int chrx;
    public string chr1b;
    public static int chr1x;
    public string chr2b;

    public static int chr2x;
    public string chr3b;
    public static int chr3x;
    public string chr4b;

    public int chr4x;
    public string chr5b;
    public int bgf;
    public static int mabatakif;

    public int chr5x;
    public string chr6b;
    public int chr6x;
    public static int syutugen;
    public int syutugenflag;
    public float syugenp;
    public float syugen2p;
    public static int chrcf;
    public static int unazf;
    public static int odorokif;
    public int chrcc;
    public int unazc;
    public int odorokic;
    public int arrivec;
    public int daruc;
    public int unazpmx;
    public int chrpmx;
    public int odorokipmx;
    public int okiagaripmx;
    public int darupmx;
    public int daruhantei;
    public int daruhanteit;
    public static int darux;
    public int daruchr;
    public static int daru1x;
    public static int daru2x;
    public static int daru3x;
    public static int odorokigage;
    public static int unazgage;
    public int bgcf;
    public int bgcdf;
    public int chaptf;
    public int fadef;
    public int fadetime;
    public int fadeoiflag;
    public static float chrcgage;
    public int loadflag;
    public static int unazhanteit;
    public int odorokihanteit;
    public int arrivehanteit;
    public static int unaz1x;
    public static int unaz2x;
    public static int unaz3x;
    public static int odoroki1x;
    public static int odoroki2x;
    public static int odoroki3x;
    public int unazfx;
    public float unazmx;
    public Sprite chr1body_num;
    public static string chr2body_num;
    public static string chr3body_num;
    public static string chr4body_num;
    public static string chr5body_num;
    public static string chr6body_num;
    public static int c1anim;
    public static int c2anim;
    public static int c3anim;
    public static string chr1anim;
    public static string chr2anim;
    public static string chr3anim;
    public GameObject Bgc;
    public static string chr_num;
    public static string chrnam;
    public static int ax;
    public Vector3 chr1l;
    public Vector3 chr2l;
    public Vector3 chr3l;
    dataload script3;
    // Use this for initialization
    void Start()
    {

        if (loadflag <= 0)
        {
            darupx = 0;
            unazpx = 0;
            odorokipx = 0;
            syutugen = 0;
            syugenp = 0;
            chrcx = 0;
            chr1x = 0;
            chr2x = 0;
            chr3x = 0;
            chr4x = 0;
            chr5x = 0;
            chr6x = 0;
            chrcf = 0;
            unaz1x = 0;
            unaz2x = 0;
            unaz3x = 0;
            odoroki1x = 0;
            odoroki2x = 0;
            odoroki3x = 0;
            daru1x = 0;
            daru2x = 0;
            daru3x = 0;
            okiagaripx = 0;
            chrpx = 0;
            okiagarix = 0;
            chr1body.SetActive(false);
            chr2body.SetActive(false);
            chr3body.SetActive(false);
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);
            chr4body.SetActive(false);
            chr5body.SetActive(false);
            chr6body.SetActive(false);
            chr4c.SetActive(false);
            chr5c.SetActive(false);
            chr6c.SetActive(false);
            chr1l = chr1body.transform.position;
            chr2l = chr2body.transform.position;
            chr3l = chr3body.transform.position;
        }
        Image chra1body = chr1body.GetComponent<Image>();
        chra1body.sprite = Resources.Load<Sprite>("Chr/transparentc");
        Image chra2body = chr2body.GetComponent<Image>();
        chra2body.sprite = Resources.Load<Sprite>("Chr/transparentc");
        Image chra3body = chr3body.GetComponent<Image>();
        chra3body.sprite = Resources.Load<Sprite>("Chr/transparentc");
    }

    // Update is called once per frame
    void Update()
    {
        script = GameObject.Find("textti").GetComponent<textti>();
        script3 = GameObject.Find("dataload").GetComponent<dataload>();
        text_num = TextManager.text_num;
        if (chrcx > 0) { chracfhantei = script.chrchantei[0]; }
        if (chrcx < textti.chrcs) { chrchantei = script.chrchantei[chrcx]; } else { chrchantei = 99999; }
        if (unazx < textti.unazs) { unazhantei = script.unazhantei[unazx]; } else { unazhantei = 99999; }
        if (odorokix < textti.odorokis) { odorokihantei = script.odorokihantei[odorokix]; } else { odorokihantei = 99999; }
        if (darux < textti.darus) { daruhantei = script.daruhantei[darux]; } else { daruhantei = 99999; }
        okiagarihantei = 2246;
        arrivehantei = 2736;
        arriveshantei = 3016;

        int c1a = anim1.GetInteger("c1a");
        anim1.SetInteger("c1a", c1a);
        int c2a = anim2.GetInteger("c2a");
        anim2.SetInteger("c2a", c2a);
        int c3a = anim3.GetInteger("c3a");
        anim3.SetInteger("c3a", c3a);
        bgcdf = Bgcontroller.bgcdf;
        chaptf = Bgcontroller.chaptf;
        fadef = Bgcontroller.fadef;
        fadetime = Bgcontroller.fadetime;
        fadeoiflag = Bgcontroller.fadeoiflag;
        loadflag = Load.loadflag;
        if (loadflag >= 2 & loadflag < 3)
        {
            px = 0;
            okiagaripx = 0;
            chrpx = 0;
            chrpmx = 0;
            okiagaripmx = 0;
            odorokipmx = 0;
            darupmx = 0;
            unazpmx = 0;
            okiagari1x = 0;

            okiagari2x = 0;

            okiagari3x = 0;

            okiagarix = 0;


            daru1x = 0;
            daru2x = 0;

            daru3x = 0;


            unaz1x = 0;
            unaz2x = 0;
            unaz3x = 0;
            odoroki1x = 0;
            odoroki2x = 0;
            odoroki3x = 0;
            darupx = 0;
            unazpx = 0;
            odorokipx = 0;



            chrcx = 0;



            chr1x = 0;

            chr2x = 0;

            chr3x = 0;

            chrcf = 0;



            unazx = 0;



            odorokix = 0;



            darux = 0;



            arrivex = 0;


            arrivesx = 0;

            chrpx = 0;
            px = 0;
            kf = 0;

            chr1body.SetActive(true);

            chr2body.SetActive(true);
            chr3body.SetActive(true);
            chr1c.SetActive(true);

            chr2c.SetActive(true);
            chr3c.SetActive(true);

        }

        if (loadflag == 3 & anmak.loadtime >= 60)
        {


            if (px == 0)
            {
                kf = 0;
                if (text_num <= chracfhantei)
                {
                    
                }

                if (text_num>= chrchantei)
                {
                    syutugen = script.ceventsyl[chrcx];
                    if (syutugen == 1)
                    {
                        chr1body_num = (script3.chrs[script.chrcnum[chr1x]]);
                        chr2body_num = ("transparentc");
                        chr3body_num = ("transparentc");
                        chrpx = 1;
                        chr1x += 1;

                    }
                    if (syutugen == 5)
                    {
                        chr2body_num = (script.chrcon[chr2x].Substring(21, 6));
                        chr3body_num = (script.chrcon[chr3x].Substring(28, 6));


                        chr2x += 1;
                        chr3x += 1;
                        chrpx = 2;

                    }
                    chrcx += 1;
                }

                if (text_num>= unazhantei)
                {
                    unazchr = 1;

                    unazx += 1;

                    if (unazchr == 1)
                    {

                        chr1body_num = script3.chrs[script.unaznum[unaz1x]];
                        unaz1x += 1;
                        unazpx = 1;
                    }
                    if (unazchr == 2)
                    {
                        chr2body_num = (script.chrcon[unaz2x].Substring(70, 6));

                        unaz2x += 1;
                        unazpx = 2;
                    }
                    if (unazchr == 3)
                    {
                        chr3body_num = (script.chrcon[unaz3x].Substring(77, 6));

                        unaz3x += 1;
                        unazpx = 2;
                    }
                }
                if (text_num>= odorokihantei)
                {
                    odorokichr = 1;
                    odorokix += 1;

                    if (odorokichr == 1)
                    {
                        chr1body_num = script3.chrs[script.odorokinum[odoroki1x]];

                        odoroki1x += 1;
                        odorokipx = 1;
                    }
                    if (odorokichr == 2)
                    {
                        chr2body_num = (script.chrcon[odoroki2x].Substring(133, 6));

                        odoroki2x += 1;
                        odorokipx = 2;
                    }
                    if (odorokichr == 3)
                    {
                        chr3body_num = (script.chrcon[odoroki3x].Substring(140, 6));

                        odoroki3x += 1;
                        odorokipx = 2;
                    }

                }
                if (text_num>= daruhantei)
                {
                    daruchr = 1;

                    darux += 1;

                    if (daruchr == 1)
                    {
                        chr1body_num = script3.chrs[script.darunum[daru1x]];

                        daru1x += 1;
                        darupx = 1;
                    }
                    if (daruchr == 2)
                    {
                        chr2body_num = (script.chrcon[daru2x].Substring(182, 6));

                        daru2x += 1;
                        darupx = 2;
                    }
                    if (daruchr == 3)
                    {
                        chr3body_num = (script.chrcon[daru3x].Substring(189, 6));

                        daru3x += 1;
                        darupx = 2;
                    }
                }
                if (text_num>= okiagarihantei)
                {
                    okiagarichr = int.Parse(script.chrcon[okiagarix].Substring(231, 6));

                    if (okiagarichr <= 1)
                    {


                        okiagari1x += 1;
                        okiagaripx = 1;
                    }
                    if (okiagarichr > 1 & okiagarichr <= 2)
                    {
                        chr2body_num = (script.chrcon[okiagari2x].Substring(245, 6));
                        okiagari2x += 1;
                        okiagaripx = 2;
                    }
                    if (okiagarichr > 2 & okiagarichr <= 3)
                    {
                        chr3body_num = (script.chrcon[okiagari3x].Substring(252, 6));
                        okiagari3x += 1;
                        okiagaripx = 2;
                    }
                    okiagarix += 1;
                }
                if (text_num>= arrivehantei)
                {
                    arrivechr = int.Parse(script.chrcon[arrivex].Substring(280, 6));

                    if (arrivechr == 1)
                    {
                        

                        arrivepx = 1;
                    }
                    if (arrivechr == 2)
                    {
                        chr2body_num = ("transparentc");


                        arrivepx = 2;
                    }
                    if (arrivechr == 3)
                    {
                        chr3body_num = ("transparentc");

                        arrivepx = 2;
                    }
                    arrivex += 1;
                }
                if (text_num>= arriveshantei)
                {

                    arrivesx += 1;
                }
                if (chrcx < textti.chrcs) { chrchantei = script.chrchantei[chrcx]; } else { chrchantei = 99999; }
                if (unazx < textti.unazs) { unazhantei = script.unazhantei[unazx]; } else { unazhantei = 99999; }
                if (odorokix < textti.odorokis) { odorokihantei = script.odorokihantei[odorokix]; } else { odorokihantei = 99999; }
                if (darux < textti.darus) { daruhantei = script.daruhantei[darux]; } else { daruhantei = 99999; }
                okiagarihantei = 2246;
                arrivehantei = 2736;
                arriveshantei = 3016;
                if (text_num <= chrchantei & text_num <= unazhantei & text_num <= odorokihantei & text_num <= daruhantei & text_num <= arrivehantei & text_num <= okiagarihantei)
                {
                    if (chrcx >= 1)
                    {
                        chrchanteit = script.chrchantei[chrcx-1];

                        chrcc = 0;
                    }
                    else
                    {
                        chrchanteit = 0;
                    }
                    if (unazx >= 1)
                    {
                        unazhanteit = script.unazhantei[unazx-1];

                        unazc = script.unazc[unazx-1];
                    }
                    else
                    {
                        unazhanteit = 0;
                    }

                    if (odorokix >= 1)
                    {
                        odorokihanteit = script.odorokihantei[odorokix-1];

                        odorokic = script.odorokic[odorokix-1];
                    }
                    else
                    {
                        odorokihanteit = 0;
                    }
                    if (darux >= 1)
                    {
                        daruhanteit = script.daruhantei[darux-1];

                        daruc = script.daruc[darux-1];
                    }
                    else
                    {
                        daruhanteit = 0;
                    }
                    if (okiagarix >= 1)
                    {
                        okiagarihanteit = int.Parse(script.chrcon[okiagarix - 1].Substring(224, 6));
                        okiagaric = int.Parse(script.chrcon[okiagarix - 1].Substring(266, 6));
                    }
                    else
                    {
                        okiagarihanteit = 0;
                    }
                    if (arrivex >= 1)
                    {

                        arrivec = int.Parse(script.chrcon[arrivex - 1].Substring(273, 6));
                        arrivehanteit = int.Parse(script.chrcon[arrivex - 1].Substring(294, 6));

                    }
                    else
                    {
                        arrivehanteit = 0;
                    }

                    px = chrpx;
                    chrpmx = 5;
                    if (okiagarihanteit > chrchanteit & okiagarihanteit > unazhanteit & okiagarihanteit > odorokihanteit & okiagarihanteit > daruhanteit)
                    {
                        px = okiagaripx;
                        chrpmx = 0;
                        okiagaripmx = 5;
                    }
                    if (unazhanteit > odorokihanteit & unazhanteit > daruhanteit & unazhanteit > okiagarihanteit)
                    {
                        px = unazpx;
                        chrpmx = 0;
                        unazpmx = 5;
                    }
                    if (odorokihanteit > okiagarihanteit & odorokihanteit > chrchanteit & odorokihanteit > daruhanteit & odorokihanteit > unazhanteit)
                    {
                        px = odorokipx;
                        chrpmx = 0;
                        odorokipmx = 5;
                    }
                    if (daruhanteit > okiagarihanteit & daruhanteit > chrchanteit & daruhanteit > odorokihanteit & daruhanteit > unazhanteit)
                    {
                        px = darupx;
                        chrpmx = 0;
                        darupmx = 5;
                    }
                }
                if (px == 0)
                {
                    px = 5;
                }
            }

            if (px == 1)
            {
                Image chra1body = chr1body.GetComponent<Image>();
                chra1body.sprite = chr1body_num;
                Image chra1bodyc = chr1c.GetComponent<Image>();
                chra1bodyc.sprite = chr1body_num;
            }
            if (px == 2)
            {

                Image chra2body = chr2body.GetComponent<Image>();
                chra2body.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                Image chra2bodyc = chr2c.GetComponent<Image>();
                chra2bodyc.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                if (chr2body_num != "transparentc")
                {
                    chr2anim = chr2body_num.Substring(1, 5);
                    c2anim = int.Parse(chrcontroller.chr2anim);
                }
                else
                {
                    c2anim = 0;
                }
                Image chra3bodyc = chr3c.GetComponent<Image>();
                chra3bodyc.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                Image chra3body = chr3body.GetComponent<Image>();
                chra3body.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                if (chr3body_num != "transparentc")
                {
                    chr3anim = chr3body_num.Substring(1, 5);
                    c3anim = int.Parse(chrcontroller.chr3anim);
                }
                else
                {
                    c3anim = 0;
                }

            }



            if (px > 0)
            {

                if (chrcx >= 1)
                {
                    if (chrchanteit > unazhanteit & chrchanteit > odorokihanteit & chrchanteit > arrivehanteit & chrchanteit > daruhanteit & chrchanteit > okiagarihanteit | chrchanteit == okiagarihanteit & chrcc > okiagaric | chrchanteit == unazhanteit & chrcc >= unazc | chrchanteit == arrivehanteit | chrchanteit == odorokihanteit & chrcc >= odorokic
        | chrchanteit == daruhanteit & chrcc >= daruc)
                    {
                        syutugen = script.ceventsyl[chrcx-1];
                        if (syutugen ==2)
                        {

                            Image chra1 = chr1body.GetComponent<Image>();
                            chra1.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra2body = chr2body.GetComponent<Image>();
                            chra2body.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra3body = chr3body.GetComponent<Image>();
                            chra3body.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");

                        }

                        if (syutugen ==1)
                        {



                            px = 1;
                            if (chrcx > 9999)
                            {
                                chr1anim = script.chrcon[chr1x - 1].Substring(15, 5);
                            }
                            chr1body_num = (script3.chrs[script.chrcnum[chr1x-1]]);




                            Image bgcs = chr1c.GetComponent<Image>();
                            bgcs.sprite =chr1body_num;
                            Image chra2body = chr2body.GetComponent<Image>();
                            chra2body.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra3body = chr3body.GetComponent<Image>();
                            chra3body.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");





                        }
                        if (syutugen >=5)
                        {
                            px = 2;
                            chr2anim = script.chrcon[chr2x - 1].Substring(22, 5);
                            chr3anim = script.chrcon[chr3x - 1].Substring(29, 5);
                            chr2body_num = (script.chrcon[chr2x - 1].Substring(21, 6));
                            chr3body_num = (script.chrcon[chr3x - 1].Substring(28, 6));
                            Image chra1body = chr1body.GetComponent<Image>();
                            chra1body.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra2body = chr2body.GetComponent<Image>();
                            chra2body.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);

                            Image bgcs2 = chr2c.GetComponent<Image>();
                            bgcs2.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                            Image chra3body = chr3body.GetComponent<Image>();
                            chra3body.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                            Image bgcs3 = chr3c.GetComponent<Image>();
                            bgcs3.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);


                        }




                    }
                    if (text_num ==chrchanteit)
                    {
                        chrcx -= 1;
                        syutugen = script.ceventsyl[chrcx];


                        if (syutugen ==1)
                        {

                            chr1body_num = (script3.chrs[script.chrcnum[chr1x-1]]);
                            Image bgcs = chr1c.GetComponent<Image>();
                            bgcs.sprite =chr1body_num;
                            chr1x -= 1;
                        }
                        if (syutugen >5)
                        {
                            chr2body_num = (script.chrcon[chr2x - 1].Substring(21, 6));
                            chr3body_num = (script.chrcon[chr3x - 1].Substring(28, 6));

                            Image chra2bodyc = chr2c.GetComponent<Image>();
                            chra2bodyc.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                            Image bgcs3 = chr3c.GetComponent<Image>();
                            bgcs3.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                            chr2x -= 1;
                            chr3x -= 1;
                        }
                    }
                }
                if (unazx >= 1)
                {

                    if (unazhanteit > chrchanteit & unazhanteit > odorokihanteit & unazhanteit > arrivehanteit & unazhanteit > daruhanteit & unazhanteit > okiagarihanteit | unazhanteit == chrchanteit & unazc >= chrcc | unazhanteit == okiagarihanteit & unazc >= okiagaric | unazhanteit == arrivehanteit)
                    {
                        unazchr = 1;

                        if (unazchr == 1)
                        {
                            px = 1;
                            if (unazx > 999999)
                            {
                                chr1anim = script.chrcon[unaz1x - 1].Substring(64, 5);
                            }

                            Image chra1ct = chr1c.GetComponent<Image>();
                            chra1ct.sprite = script3.chrs[script.unaznum[unaz1x-1]];

                        }
                        if (unazchr == 2)
                        {
                            px = 2;
                            chr2anim = script.chrcon[unaz2x - 1].Substring(71, 5);
                            Image chra2t = chr2body.GetComponent<Image>();
                            chra2t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz2x - 1].Substring(56, 6));
                            Image chra2ct = chr2c.GetComponent<Image>();
                            chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz2x - 1].Substring(56, 6));

                        }
                        if (unazchr == 3)
                        {
                            px = 2;
                            chr3anim = script.chrcon[unaz3x - 1].Substring(78, 5);
                            Image chra3t = chr3body.GetComponent<Image>();
                            chra3t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz3x - 1].Substring(63, 6));
                            Image chra3ct = chr2c.GetComponent<Image>();
                            chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz3x - 1].Substring(63, 6));

                        }
                    }
                    if (text_num == unazhanteit)
                    {
                        unazx -= 1;
                        unazchr = 1;

                        if (unazchr == 1)
                        {
                            unaz1x -= 1;

                        }
                        if (unazchr == 2)
                        {
                            unaz2x -= 1;

                        }
                        if (unazchr == 3)
                        {
                            unaz3x -= 1;
                        }
                    }
                }
                if (odorokix >= 1)
                {
                    if (odorokihanteit > chrchanteit & odorokihanteit > unazhanteit & odorokihanteit > arrivehanteit & odorokihanteit > daruhanteit & odorokihanteit > okiagarihanteit | odorokihanteit == daruhanteit & odorokic >= daruc | odorokihanteit == okiagarihanteit & odorokic >= okiagaric | odorokihanteit == chrchanteit & odorokic >= chrcc | odorokihanteit == arrivehanteit)
                    {
                        odorokichr = 1;
                        if (odorokichr == 1)
                        {
                            px = 1;
                            if (odoroki1x > 99999)
                            {
                                chr1anim = script.chrcon[odoroki1x - 1].Substring(127, 5);
                            }

                            Image chra1ct = chr1c.GetComponent<Image>();
                            chra1ct.sprite = script3.chrs[script.odorokinum[odoroki1x-1]];

                        }
                        if (odorokichr == 2)
                        {
                            px = 2;
                            chr2anim = script.chrcon[odoroki2x - 1].Substring(134, 5);
                            Image chra2t = chr2body.GetComponent<Image>();
                            chra2t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki2x - 1].Substring(133, 6));
                            Image chra2ct = chr2c.GetComponent<Image>();
                            chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki2x - 1].Substring(133, 6));

                        }
                        if (odorokichr == 3)
                        {
                            px = 2;
                            chr3anim = script.chrcon[odoroki3x - 1].Substring(141, 5);
                            Image chra3t = chr3body.GetComponent<Image>();
                            chra3t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki3x - 1].Substring(140, 6));
                            Image chra3ct = chr3c.GetComponent<Image>();
                            chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki3x - 1].Substring(140, 6));

                        }
                    }
                    if (text_num == odorokihanteit)
                    {
                        odorokix -= 1;

                        odorokichr = 1;
                        if (odorokichr == 1)
                        {
                            odoroki1x -= 1;

                        }
                        if (odorokichr == 2)
                        {
                            odoroki2x -= 1;

                        }
                        if (odorokichr == 3)
                        {
                            odoroki3x -= 1;

                        }
                    }
                }
                if (darux >= 1)
                {
                    if (daruhanteit > chrchanteit & daruhanteit > unazhanteit & daruhanteit > arrivehanteit & daruhanteit > odorokihanteit & daruhanteit > okiagarihanteit | daruhanteit == chrchanteit & daruc >= chrcc | daruhantei == okiagarihanteit & daruc >= okiagaric | daruhanteit == odorokihanteit & daruc >= odorokic)
                    {
                        daruchr = 1;
                        if (daruchr == 1)
                        {
                            px = 1;
                            if (daru1x > 999999)
                            {
                                chr1anim = script.chrcon[daru1x - 1].Substring(175, 5);
                            }

                            Image chra1ct = chr1c.GetComponent<Image>();
                            chra1ct.sprite = script3.chrs[script.darunum[daru1x-1]];

                        }
                        if (daruchr == 2)
                        {
                            px = 2;
                            chr2anim = script.chrcon[daru2x - 1].Substring(183, 5);
                            Image chra2t = chr2body.GetComponent<Image>();
                            chra2t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru2x - 1].Substring(182, 6));
                            Image chra2ct = chr2c.GetComponent<Image>();
                            chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru2x - 1].Substring(182, 6));

                        }
                        if (daruchr == 3)
                        {
                            px = 2;
                            chr3anim = script.chrcon[daru3x - 1].Substring(190, 5);
                            Image chra3t = chr3body.GetComponent<Image>();
                            chra3t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru3x - 1].Substring(189, 6));
                            Image chra3ct = chr3c.GetComponent<Image>();
                            chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru3x - 1].Substring(189, 6));

                        }
                    }
                    if (text_num == daruhanteit)
                    {
                        darux -= 1;
                        daruchr = 1;
                        if (daruchr == 1)
                        {
                            daru1x -= 1;

                        }
                        if (daruchr == 2)
                        {
                            daru2x -= 1;

                        }
                        if (daruchr == 3)
                        {
                            daru3x = -1;

                        }

                    }
                    if (okiagarix >= 1)
                    {
                        if (okiagarihanteit > chrchanteit & okiagarihanteit > unazhanteit & okiagarihanteit > arrivehanteit & okiagarihanteit > daruhanteit | okiagarihanteit == chrchanteit & okiagaric <= chrcc | okiagarihanteit == unazhanteit & okiagaric < unazc | okiagarihanteit == odorokihanteit & okiagaric < odorokic | okiagarihanteit == daruhanteit & okiagaric < daruc)
                        {
                            okiagarichr = int.Parse(script.chrcon[okiagarix - 1].Substring(238, 6));
                            if (okiagarichr <= 1)
                            {
                                px = 1;
                                chr1anim = script.chrcon[okiagari1x - 1].Substring(246, 5);

                                Image chract = chr1c.GetComponent<Image>();
                                chract.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari1x - 1].Substring(245, 6));

                            }
                            if (okiagarichr > 1 & okiagarichr <= 2)
                            {
                                px = 2;
                                chr2anim = script.chrcon[okiagari2x - 1].Substring(253, 5);
                                Image chra2t = chr2body.GetComponent<Image>();
                                chra2t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari2x - 1].Substring(252, 6));
                                Image chra2ct = chr2c.GetComponent<Image>();
                                chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari2x - 1].Substring(252, 6));

                            }
                            if (okiagarichr > 2 & okiagarichr <= 3)
                            {
                                px = 2;
                                chr3anim = script.chrcon[okiagari3x - 1].Substring(260, 5);
                                Image chra3t = chr3body.GetComponent<Image>();
                                chra3t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari3x - 1].Substring(259, 6));
                                Image chra3ct = chr3c.GetComponent<Image>();
                                chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari3x - 1].Substring(259, 6));

                            }
                            if (text_num == okiagarihanteit)
                            {
                                okiagarix -= 1;
                                okiagarichr = int.Parse(script.chrcon[okiagarix].Substring(238, 6));
                                if (okiagarichr <= 1)
                                {
                                    okiagari1x -= 1;

                                }
                                if (okiagarichr > 1 & okiagarichr <= 2)
                                {
                                    okiagari2x -= 1;
                                }
                                if (okiagarichr > 2 & okiagarichr <= 3)
                                {
                                    okiagari3x -= 1;

                                }
                            }

                        }
                    }


                }
                if (arrivex >= 1)
                {
                    if (arrivehanteit > chrchanteit & arrivehanteit > unazhanteit & arrivehanteit > odorokihanteit | arrivehanteit > daruhanteit | arrivehanteit == chrchanteit | unazhanteit == arrivehanteit | odorokihanteit == arrivehanteit)
                    {

                        arrivechr = int.Parse(script.chrcon[arrivex - 1].Substring(280, 6));
                        if (arrivechr == 1)
                        {
                            px = 1;
                            Image chra1t = chr1body.GetComponent<Image>();
                            chra1t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra1ct = chr1c.GetComponent<Image>();
                            chra1ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                        }
                        if (arrivechr == 2)
                        {
                            px = 2;
                            Image chra2t = chr2body.GetComponent<Image>();
                            chra2t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra2ct = chr2c.GetComponent<Image>();
                            chra2ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");

                        }
                        if (arrivechr == 3)
                        {
                            px = 2;
                            Image chra3t = chr3body.GetComponent<Image>();
                            chra3t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                            Image chra3ct = chr3c.GetComponent<Image>();
                            chra3ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");

                        }
                    }
                }
                if (okiagaripmx == 5)
                {
                    fhantei = okiagarihanteit;
                }
                if (chrpmx == 5)
                {
                    fhantei = chrchanteit;
                }
                if (unazpmx == 5)
                {
                    fhantei = unazhanteit;
                }
                if (odorokipmx == 5)
                {
                    fhantei = odorokihanteit;
                }
                if (darupmx == 5)
                {
                    fhantei = daruhanteit;
                }
                if (fhantei < Bgcontroller.kakudaihanteit | fhantei < Bgcontroller.bgcdhanteit | fhantei < Bgcontroller.bgchanteit | fhantei < Bgcontroller.chapthanteit | fhantei < Bgcontroller.hazimarihanteit | fhantei < Bgcontroller.hazimariehanteit)
                {
                    chr1body.SetActive(false);
                    chr2body.SetActive(false);
                    chr3body.SetActive(false);
                    chr1c.SetActive(false);
                    chr2c.SetActive(false);
                    chr3c.SetActive(false);
                }
                if (Bgcontroller.kakudaiflag == 1)
                {
                    chr1body.SetActive(true);
                    chr1c.SetActive(true);
                    float fadep = 1.15f;
                    Image chra1 = chr1body.GetComponent<Image>();
                    chra1.transform.localScale = new Vector3(fadep, fadep, 0);
                    Image chra2 = chr1c.GetComponent<Image>();
                    chra2.transform.localScale = new Vector3(fadep, fadep, 0);
                    fadep = 0;

                }
                animf = 0;
                if (animf == 1)
                {
                    chr1c.SetActive(false);
                    chr2c.SetActive(false);
                    chr3c.SetActive(false);
                    chr2body.SetActive(false);
                    chr3body.SetActive(false);
                }
                if (animf >= 2 & animf <= 3)
                {
                    chr1c.SetActive(false);
                    chr2c.SetActive(false);
                    chr3c.SetActive(false);
                    chr1body.SetActive(false);
                }
                if (animf == 4)
                {
                    chr1c.SetActive(false);
                    chr2c.SetActive(false);
                    chr3c.SetActive(false);
                    chr1body.SetActive(false);
                    chr2body.SetActive(false);
                    chr3body.SetActive(false);
                }
                if (animf == 0)
                {
                    if (px == 1)
                    {
                        chr2c.SetActive(false);
                        chr3c.SetActive(false);
                        chr2body.SetActive(false);
                        chr3body.SetActive(false);
                    }
                    if (px == 2)
                    {
                        chr1c.SetActive(false);
                        chr1body.SetActive(false);
                    }
                    if (px == 5)
                    {
                        chr1c.SetActive(false);
                        chr2c.SetActive(false);
                        chr3c.SetActive(false);
                        chr1body.SetActive(false);
                        chr2body.SetActive(false);
                        chr3body.SetActive(false);
                    }
                }

            }

        }

        if (Bgcontroller.hazimarif == 1 & Bgcontroller.hazimarihanteit < text_num & Bgcontroller.hazimariehantei >= text_num)
        {


            chr1body.transform.position = chr1l;
            chr2body.transform.position = chr2l;
            chr3body.transform.position = chr3l;
            chr1c.transform.position = chr1l;
            chr2c.transform.position = chr2l;
            chr3c.transform.position = chr3l;
            unazgage = 0;
            arrivegage = 0;
            arrivesgage = 0;
            odorokigage = 0;
            Image chra1 = chr1body.GetComponent<Image>();
            chra1.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");


            Image chra2 = chr2body.GetComponent<Image>();
            chra2.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");

            Image chra3 = chr3body.GetComponent<Image>();
            chra3.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
            Image chra1c = chr1c.GetComponent<Image>();
            chra1c.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");


            Image chra2c = chr2c.GetComponent<Image>();
            chra2c.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");

            Image chra3c = chr3c.GetComponent<Image>();
            chra3c.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
            chr1body.SetActive(false);
            chr2body.SetActive(false);
            chr3body.SetActive(false);
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);
        }
        if ((Bgcontroller.hazimarif == 0) & (Bgcontroller.bgcdf == 0) & (Bgcontroller.bgcf == 0) & (Bgcontroller.chaptf == 0))
        {
            bgf = 0;
        }
        else
        {
            bgf = 1;
        }
        if ((anmak.antenflag == 0 | anmak.antenflag > 100) & loadflag == 0 & (Bgcontroller.hazimarif == 0) & (Bgcontroller.bgcdf == 0) & (Bgcontroller.bgcf == 0) & (Bgcontroller.chaptf == 0))
        {

            if ((loadflag <= 0) & (text_num >= chrchantei))
            {
                syutugen = script.ceventsyl[chrcx];



                if (syutugen == 2)
                {
                    chrcgage = 1;
                    chr2body.SetActive(false);
                    chr3body.SetActive(false);
                    chrcf = 2;
                }

                if (syutugen == 1)
                {
                    chr1anim = script.chrcnum[chr1x];
                    chr1body_num = (script3.chrs[script.chrcnum[chr1x]]);
                    chr1x += 1;

                }
                if (syutugen == 5)
                {
                    chr2anim = script.chrcon[chr2x].Substring(22, 5);
                    chr3anim = script.chrcon[chr3x].Substring(29, 5);
                    chr2body_num = (script.chrcon[chr2x].Substring(21, 6));
                    chr3body_num = (script.chrcon[chr3x].Substring(28, 6));
                    chr2x += 1;
                    chr3x += 1;

                }
                chrcf = 5;
                if (chrcf == 4)
                {
                    chrcc = int.Parse(script.chrcon[chrcx].Substring(42, 6));
                }
                chrcx += 1;
            }
            if (chrcf == 5 | chrcf == 4 & TextManager.tnumfa > chrcc)
            {
                chrcf = syutugen;
                chrcc = 0;
            }

            if (chrcf >= 1 & chrcf < 4 & chrcgage <= 1)
            {
                if (bgcdf < 1 & chrcf < 2)
                {

                    Image bgci = chr1c.GetComponent<Image>();
                    bgci.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                    Image bgcs = chr1c.GetComponent<Image>();
                    if (fadeoiflag < 45)
                    {
                        bgcs.sprite = chr1body_num;
                    }
                    else
                    {
                        bgcs.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                    }
                    Image bgci2 = chr2c.GetComponent<Image>();
                    bgci2.GetComponent<Image>().color = new Color(255, 255, 255, 0.5f - chrcgage);
                    Image bgcs2 = chr2c.GetComponent<Image>();

                    Image bgci3 = chr3c.GetComponent<Image>();
                    bgci3.GetComponent<Image>().color = new Color(255, 255, 255, 0.5f - chrcgage);
                    Image bgcs3 = chr3c.GetComponent<Image>();

                    chr1c.SetActive(true);
                    chr2c.SetActive(false);
                    chr3c.SetActive(false);
                    chr1body.SetActive(true);
                    chr2body.SetActive(false);
                    chr3body.SetActive(false);
                    chr4c.SetActive(false);
                    chr5c.SetActive(false);
                    chr6c.SetActive(false);
                    chr4body.SetActive(false);
                    chr5body.SetActive(false);
                    chr6body.SetActive(false);
                }
                if (chrcf == 2)
                {

                    Image bgci = chr1c.GetComponent<Image>();
                    bgci.GetComponent<Image>().color = new Color(255, 255, 255, 0.5f - chrcgage);
                    Image bgcs = chr1c.GetComponent<Image>();

                    Image bgci2 = chr2c.GetComponent<Image>();
                    bgci2.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                    Image bgcs2 = chr2c.GetComponent<Image>();
                    bgcs2.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                    Image bgci3 = chr3c.GetComponent<Image>();
                    bgci3.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                    Image bgcs3 = chr3c.GetComponent<Image>();
                    bgcs3.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                    chr1c.SetActive(false);
                    chr2c.SetActive(true);
                    chr3c.SetActive(true);
                    chr1body.SetActive(false);
                    chr2body.SetActive(true);
                    chr3body.SetActive(true);
                    chr4c.SetActive(false);
                    chr5c.SetActive(false);
                    chr6c.SetActive(false);
                    chr4body.SetActive(false);
                    chr5body.SetActive(false);
                    chr6body.SetActive(false);
                }





                if (fadef == 0 & Bgcontroller.chaptf == 0 & bgcdf <= 0 | fadef >= 1 & chrcgage <= 0.12f)
                {
                    chrcgage += 0.12f;
                }

                if (Bgcontroller.chaptf == 0 & bgcdf >= 1)
                {
                    chrcgage = 0;
                }

            }
            if (chrcf >= 1 & chrcf < 4 & chrcgage > 1)
            {



                if (chrcf == 1)
                {
                    if (chrcx > 99999)
                    {
                        c1anim = int.Parse(chrcontroller.chr1anim);
                    }
                    Image chra2 = chr2body.GetComponent<Image>();
                    chra2.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                    Image bgci2 = chr2c.GetComponent<Image>();
                    bgci2.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                    Image chra3 = chr3body.GetComponent<Image>();
                    chra3.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                    Image bgci3 = chr3c.GetComponent<Image>();
                    bgci3.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                }
                if (chrcf == 5)
                {
                    c2anim = int.Parse(chrcontroller.chr2anim);
                    c3anim = int.Parse(chrcontroller.chr3anim);
                    Image chra1 = chr1body.GetComponent<Image>();
                    chra1.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                    Image bgci1 = chr1c.GetComponent<Image>();
                    bgci1.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                    Image chra2 = chr2body.GetComponent<Image>();
                    chra2.sprite = Resources.Load<Sprite>("Chr/" + chr2body_num);
                    Image chra3 = chr3body.GetComponent<Image>();
                    chra3.sprite = Resources.Load<Sprite>("Chr/" + chr3body_num);
                }
                chrcgage = 0;
                chrcf = 0;
            }
            if (bgcdf <= 0 & chaptf <= 0 & chrcf == 2 & chrcgage >= 0)
            {
                TextManager.tnumf = 0;
                Image bgcn = chr1body.GetComponent<Image>();
                bgcn.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                Image bgcn2 = chr2body.GetComponent<Image>();
                bgcn2.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                Image bgcn3 = chr3body.GetComponent<Image>();
                bgcn3.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                Image bgcn4 = chr4body.GetComponent<Image>();
                bgcn4.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                Image bgcn5 = chr5body.GetComponent<Image>();
                bgcn5.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                Image bgcn6 = chr6body.GetComponent<Image>();
                bgcn6.GetComponent<Image>().color = new Color(255, 255, 255, chrcgage);
                chrcgage -= 0.05f;

            }
            if (chrcf == 2 & chrcgage < 0)
            {
                chr1c.SetActive(false);
                chr2c.SetActive(false);
                chr3c.SetActive(false);
                chr4c.SetActive(false);
                chr5c.SetActive(false);
                chr6c.SetActive(false);
                Image bgcn = chr1body.GetComponent<Image>();
                bgcn.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image bgcn2 = chr2body.GetComponent<Image>();
                bgcn2.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image bgcn3 = chr3body.GetComponent<Image>();
                bgcn3.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image chra1t = chr1body.GetComponent<Image>();
                chra1t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra2t = chr2body.GetComponent<Image>();
                chra2t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra3t = chr3body.GetComponent<Image>();
                chra3t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcn4 = chr4body.GetComponent<Image>();
                bgcn4.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image bgcn5 = chr5body.GetComponent<Image>();
                bgcn5.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image bgcn6 = chr6body.GetComponent<Image>();
                bgcn6.GetComponent<Image>().color = new Color(255, 255, 255, 1);
                Image chra4t = chr4body.GetComponent<Image>();
                chra4t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra5t = chr5body.GetComponent<Image>();
                chra5t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra6t = chr6body.GetComponent<Image>();
                chra6t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                chrcf = 0;
            }
            if (loadflag <= 0 & text_num >= unazhantei)
            {
                unazchr = 1;
                unazfx = 30;
                unazmx = 0.03f;
                if (unazchr == 1)
                {
                    unaz1x += 1;
                }
                if (unazchr == 2)
                {
                    unaz2x += 1;
                }
                if (unazchr == 3)
                {
                    unaz3x += 1;
                }
                unazc = script.unazc[unazx];
                unazf = 3;
                unazx += 1;
            }
            if (unazf==3&TextManager.tnumfa > unazc)
            {
                unazf = 1;
            }
            if (unazf == 1 & unazgage < unazfx)
            {
                if (unazchr == 1)
                {
                    chr1body.SetActive(true);
                    chr1c.SetActive(true);
                    if (unazx < -100)
                    {
                        chr1anim = script.chrcon[unaz1x - 1].Substring(64, 5);

                        c1anim = int.Parse(chrcontroller.chr1anim);
                    }
                    Image chra1ct = chr1c.GetComponent<Image>();
                    chra1ct.sprite = script3.chrs[script.unaznum[unaz1x-1]];
                    Image bgcu = chr1body.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                    Image bgcuc = chr1c.GetComponent<Image>();
                    bgcuc.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                }
                if (unazchr == 2)
                {
                    chr2anim = script.chrcon[unaz2x - 1].Substring(71, 5);
                    c2anim = int.Parse(chrcontroller.chr2anim);
                    Image chra2ct = chr2c.GetComponent<Image>();
                    chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz2x - 1].Substring(70, 6));
                    Image bgcu2 = chr2body.GetComponent<Image>();
                    bgcu2.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                    Image bgcuc2 = chr2c.GetComponent<Image>();
                    bgcuc2.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                }
                if (unazchr == 3)
                {

                    chr3anim = script.chrcon[unaz3x - 1].Substring(78, 5);
                    c3anim = int.Parse(chrcontroller.chr3anim);
                    Image chra3ct = chr3c.GetComponent<Image>();
                    chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[unaz3x - 1].Substring(77, 6));
                    Image bgcu3 = chr3body.GetComponent<Image>();
                    bgcu3.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                    Image bgcuc3 = chr3c.GetComponent<Image>();
                    bgcuc3.GetComponent<Image>().transform.Translate(0, -unazmx, 0);
                }
                unazgage += 1;

            }
            if (unazf == 1 & unazgage >= unazfx)
            {

                unazf = 2;


            }
            if (unazf == 2 & unazgage < 2 * unazfx)
            {
                if (unazchr <= 1)
                {
                    chr1body.SetActive(true);
                    chr1c.SetActive(true);
                    chr2body.SetActive(false);
                    chr2c.SetActive(false);
                    chr3body.SetActive(false);
                    chr3c.SetActive(false);
                    Image bgcu = chr1body.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                    Image bgcuc = chr1c.GetComponent<Image>();
                    bgcuc.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                }
                unazgage += 1;

                if (unazchr > 1 & unazchr <= 2)
                {
                    chr1body.SetActive(false);
                    chr1c.SetActive(false);
                    chr2body.SetActive(true);
                    chr2c.SetActive(true);
                    chr3body.SetActive(true);
                    chr3c.SetActive(true);

                    Image bgcu2 = chr2body.GetComponent<Image>();
                    bgcu2.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                    Image bgcuc2 = chr2c.GetComponent<Image>();
                    bgcuc2.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                }
                if (unazchr > 2 & unazchr <= 3)
                {
                    chr1body.SetActive(false);
                    chr1c.SetActive(false);
                    chr2body.SetActive(true);
                    chr2c.SetActive(true);
                    chr3body.SetActive(true);
                    chr3c.SetActive(true);

                    Image bgcu3 = chr3body.GetComponent<Image>();
                    bgcu3.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                    Image bgcuc3 = chr3c.GetComponent<Image>();
                    bgcuc3.GetComponent<Image>().transform.Translate(0, unazmx, 0);
                }
            }
            if (unazf == 2 & unazgage >= 2 * unazfx)
            {
                chr1body.transform.position = chr1l;
                chr2body.transform.position = chr2l;
                chr3body.transform.position = chr3l;
                chr1c.transform.position = chr1l;
                chr2c.transform.position = chr2l;
                chr3c.transform.position = chr3l;

                unazgage = 0;
                unazf = 0;
                unazfx = 0;
                unazmx = 0;
            }
            if (loadflag <= 0 & text_num>= odorokihantei)
            {
                odorokichr = 1;
                if (odorokichr == 1)
                {
                    odoroki1x += 1;
                }
                if (odorokichr == 2)
                {
                    odoroki2x += 1;
                }
                if (odorokichr == 3)
                {
                    odoroki3x += 1;
                }
                odorokif = 3;
                odorokic = script.odorokic[odorokix];
                odorokix += 1;

            }

            if (odorokif == 3 & odorokic < TextManager.tnumfa)
            {
                odorokif = 1;
            }

            if (odorokif == 1 & odorokigage < 4)
            {

                if (odorokichr <= 1)
                {
                    chr1body.SetActive(true);
                    chr1c.SetActive(true);
                    if (odorokix > 999999)
                    {
                        chr1anim = script.chrcon[odoroki1x - 1].Substring(127, 5);
                        c1anim = int.Parse(chrcontroller.chr1anim);
                    }

                    Image chra1ct = chr1c.GetComponent<Image>();
                    chra1ct.sprite = script3.chrs[script.odorokinum[odoroki1x-1]];
                    Image bgcu = chr1body.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                    Image bgcuc = chr1c.GetComponent<Image>();
                    bgcuc.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                }
                if (odorokichr > 1 & odorokichr <= 2)
                {
                    chr2anim = script.chrcon[odoroki2x - 1].Substring(134, 5);
                    c2anim = int.Parse(chrcontroller.chr2anim);

                    Image chra2ct = chr2c.GetComponent<Image>();
                    chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki2x - 1].Substring(133, 6));
                    Image bgcu2 = chr2body.GetComponent<Image>();
                    bgcu2.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                    Image bgcuc2 = chr2c.GetComponent<Image>();
                    bgcuc2.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                }
                if (odorokichr > 2 & odorokichr <= 3)
                {

                    chr3anim = script.chrcon[odoroki3x - 1].Substring(141, 5);
                    c3anim = int.Parse(chrcontroller.chr3anim);
                    Image chra3ct = chr3c.GetComponent<Image>();
                    chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[odoroki3x - 1].Substring(140, 6));
                    Image bgcu3 = chr3body.GetComponent<Image>();
                    bgcu3.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                    Image bgcuc3 = chr3c.GetComponent<Image>();
                    bgcuc3.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                }
                odorokigage += 1;
            }
            if (odorokif == 1 & odorokigage >= 4)
            {
                odorokif = 2;

            }
            if (odorokif == 2 & odorokigage < 8)
            {

                if (odorokichr <= 1)
                {
                    chr1body.SetActive(true);
                    chr1c.SetActive(true);
                    chr2body.SetActive(false);
                    chr2c.SetActive(false);
                    chr3body.SetActive(false);
                    chr3c.SetActive(false);
                    Image bgcu = chr1body.GetComponent<Image>();
                    bgcu.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                    Image bgcuc = chr1c.GetComponent<Image>();
                    bgcuc.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                }
                if (odorokichr > 1 & odorokichr <= 2)
                {
                    chr1body.SetActive(false);
                    chr1c.SetActive(false);
                    chr2body.SetActive(true);
                    chr2c.SetActive(true);
                    chr3body.SetActive(true);
                    chr3c.SetActive(true);
                    Image bgcu2 = chr2body.GetComponent<Image>();
                    bgcu2.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                    Image bgcuc2 = chr2c.GetComponent<Image>();
                    bgcuc2.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                }
                if (odorokichr > 2 & odorokichr <= 3)
                {
                    chr1body.SetActive(false);
                    chr1c.SetActive(false);
                    chr2body.SetActive(true);
                    chr2c.SetActive(true);
                    chr3body.SetActive(true);
                    chr3c.SetActive(true);
                    Image bgcu3 = chr3body.GetComponent<Image>();
                    bgcu3.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                    Image bgcuc3 = chr3c.GetComponent<Image>();
                    bgcuc3.GetComponent<Image>().transform.Translate(0, -0.1f, 0);
                }
                odorokigage += 1;
            }
            if (odorokif == 2 & odorokigage >= 8)
            {
                chr1body.transform.position = chr1l;
                chr2body.transform.position = chr2l;
                chr3body.transform.position = chr3l;
                chr1c.transform.position = chr1l;
                chr2c.transform.position = chr2l;
                chr3c.transform.position = chr3l;

                odorokigage = 0;
                odorokif = 0;
            }

        }
        if (bgf == 0 & loadflag <= 0 & text_num >= daruhantei)
        {
            daruchr = 1;
            if (daruchr == 1)
            {
                daru1x += 1;
            }
            if (daruchr == 2)
            {
                daru2x += 1;
            }
            if (daruchr == 3)
            {
                daru3x += 1;
            }
            darufx = 30;
            darumx = 0.03f;
            daruf = 3;
            daruc = script.daruc[darux];
            darux += 1;
        }
        if (daruf == 3 & TextManager.tnumfa > daruc)
        {
            daruf = 1;
        }
        if (daruf == 1 & darugage < darufx)
        {
            if (daruchr <= 1)
            {
                chr1body.SetActive(true);
                chr1c.SetActive(true);
                chr2body.SetActive(false);
                chr2c.SetActive(false);
                chr3body.SetActive(false);
                chr3c.SetActive(false);
                if (darux > 999999)
                {
                    chr1anim = script.chrcon[daru1x - 1].Substring(176, 5);
                    c1anim = int.Parse(chrcontroller.chr1anim);
                }
                Image chra1ct = chr1c.GetComponent<Image>();
                chra1ct.sprite = script3.chrs[script.darunum[daru1x-1]];
                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            if (daruchr > 1 & daruchr <= 2)
            {
                chr2anim = script.chrcon[daru2x - 1].Substring(183, 5);
                c2anim = int.Parse(chrcontroller.chr2anim);

                chr1body.SetActive(false);
                chr1c.SetActive(false);
                chr2body.SetActive(true);
                chr2c.SetActive(true);
                chr3body.SetActive(true);
                chr3c.SetActive(true);
                Image chra2ct = chr2c.GetComponent<Image>();
                chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru2x - 1].Substring(182, 6));
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            if (daruchr > 2 & daruchr <= 3)
            {

                chr3anim = script.chrcon[daru3x].Substring(190, 5);
                c3anim = int.Parse(chrcontroller.chr3anim);
                chr1body.SetActive(false);
                chr1c.SetActive(false);
                chr2body.SetActive(true);
                chr2c.SetActive(true);
                chr3body.SetActive(true);
                chr3c.SetActive(true);
                Image chra3ct = chr3c.GetComponent<Image>();
                chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[daru3x].Substring(189, 6));
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            darugage += 1;

        }
        if (daruf == 1 & darugage >= darufx)
        {

            daruf = 2;


        }
        if (daruf == 2 & darugage < darufx * 3)
        {
            if (daruchr <= 1)
            {

                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(darumx, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(darumx, 0, 0);
            }
            if (daruchr > 1 & daruchr <= 2)
            {

                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(darumx, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(darumx, 0, 0);
            }
            if (daruchr > 2 & daruchr <= 3)
            {

                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(darumx, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(darumx, 0, 0);
            }
            darugage += 1;

        }
        if (daruf == 2 & darugage >= darufx * 3)
        {
            daruf = 4;
        }
        if (daruf == 4 & darugage <= darufx * 4)
        {
            if (daruchr <= 1)
            {

                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            if (daruchr > 1 & daruchr <= 2)
            {

                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            if (daruchr > 2 & daruchr <= 3)
            {

                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(-darumx, 0, 0);
            }
            darugage += 1;


        }
        if (daruf == 4 & darugage > darufx * 4)
        {
            chr1body.transform.position = chr1l;
            chr2body.transform.position = chr2l;
            chr3body.transform.position = chr3l;
            chr1c.transform.position = chr1l;
            chr2c.transform.position = chr2l;
            chr3c.transform.position = chr3l;

            darugage = 0;
            daruf = 0;
        }
        if (loadflag <= 0 & text_num>= okiagarihantei)
        {

            okiagarichr = int.Parse(script.chrcon[okiagarix].Substring(231, 6));

            if (okiagarichr <= 1)
            {
                okiagari1x += 1;

                chr1body.SetActive(true);
                chr1c.SetActive(true);
                chr2body.SetActive(false);
                chr2c.SetActive(false);
                chr3body.SetActive(false);
                chr3c.SetActive(false);
                Image chra1t = chr1body.GetComponent<Image>();
                chra1t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra1ct = chr1c.GetComponent<Image>();
                chra1ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, -1f, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(0, -1f, 0);
            }


            if (okiagarichr > 1 & okiagarichr <= 2)
            {
                okiagari2x += 1;
                chr2body.SetActive(true);
                chr2c.SetActive(true);
                chr3body.SetActive(true);
                chr3c.SetActive(true);
                chr1body.SetActive(false);
                chr1c.SetActive(false);
                Image chra2t = chr2body.GetComponent<Image>();
                chra2t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra2ct = chr2c.GetComponent<Image>();
                chra2ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(0, -1f, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(0, -1f, 0);
            }
            if (okiagarichr > 2 & okiagarichr <= 3)
            {
                okiagari3x += 1;
                chr2body.SetActive(true);
                chr2c.SetActive(true);
                chr3body.SetActive(true);
                chr3c.SetActive(true);
                chr1body.SetActive(false);
                chr1c.SetActive(false);
                Image chra3t = chr3body.GetComponent<Image>();
                chra3t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra3ct = chr3c.GetComponent<Image>();
                chra3ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(0, -1f, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(0, -1f, 0);
            }

            okiagarif = int.Parse(script.chrcon[okiagarix].Substring(259, 6));
            if (okiagarif == 3)
            {
                okiagaric = int.Parse(script.chrcon[okiagarix].Substring(266, 6));
            }
            else
            {
                okiagaric = 0;
            }

            okiagarix += 1;

        }
        if (okiagarif == 3)
        {
            okiagarif = 1;


        }
        if (okiagarif >= 1 & okiagarigage < 10)
        {
            if (okiagarichr <= 1)
            {
                chr1anim = script.chrcon[okiagari1x].Substring(239, 5);

                c1anim = int.Parse(chrcontroller.chr1anim);
                Image chra1ct = chr1c.GetComponent<Image>();
                chra1ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari1x - 1].Substring(238, 6));
                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(0, 0.1f, 0);

            }
            if (okiagarichr > 1 & okiagarichr <= 2)
            {

                chr2anim = script.chrcon[okiagari2x].Substring(246, 5);
                c2anim = int.Parse(chrcontroller.chr2anim);
                Image chra2t = chr2body.GetComponent<Image>();
                chra2t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari2x - 1].Substring(245, 6));
                Image chra2ct = chr2c.GetComponent<Image>();
                chra2ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari2x - 1].Substring(245, 6));
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(0, 0.1f, 0);

            }
            if (okiagarichr > 2 & okiagarichr <= 3)
            {

                chr3anim = script.chrcon[okiagari3x].Substring(253, 5);
                c3anim = int.Parse(chrcontroller.chr3anim);
                Image chra3t = chr3body.GetComponent<Image>();
                chra3t.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari3x - 1].Substring(252, 6));
                Image chra3ct = chr3c.GetComponent<Image>();
                chra3ct.sprite = Resources.Load<Sprite>("Chr/" + script.chrcon[okiagari3x - 1].Substring(252, 6));
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(0, 0.1f, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(0, 0.1f, 0);

            }
            okiagarigage += 1;

            if (okiagarif >= 1 & okiagarigage >= 10)
            {


                chr1body.transform.position = chr1l;
                chr2body.transform.position = chr2l;
                chr3body.transform.position = chr3l;
                chr1c.transform.position = chr1l;
                chr2c.transform.position = chr2l;
                chr3c.transform.position = chr3l;

                okiagarigage = 0;
                okiagarif = 0;
            }
        }

        if (loadflag <= 0 & text_num>= arrivehantei)
        {
            arrivechr = int.Parse(script.chrcon[arrivex].Substring(280, 6));


            arrivef = int.Parse(script.chrcon[arrivex].Substring(287, 6));
            if (arrivef == 3)
            {
                arrivec = int.Parse(script.chrcon[arrivex].Substring(294, 6));
            }

            arrivex += 1;

        }
        if (arrivef == 3 & TextManager.tnumfa > arrivec)
        {
            arrivef = 1;
        }
        if (arrivef == 1 & arrivegage < 10)
        {
            if (arrivechr <= 1)
            {

                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
            }
            if (arrivechr > 1 & arrivechr <= 2)
            {
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
            }
            if (arrivechr > 2 & arrivechr <= 3)
            {
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(-0.1f, 0, 0);
            }
            arrivegage += 1;

        }
        if (arrivef == 1 & arrivegage >= 10 & chrcf >= 0)
        {


            if (arrivechr == 1)
            {
                Image chra1t = chr1body.GetComponent<Image>();
                chra1t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra1ct = chr1c.GetComponent<Image>();
                chra1ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(1f, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(1f, 0, 0);

            }

            TextManager.tnumf = 0;
            if (arrivechr > 1 & arrivechr <= 2)
            {
                Image chra2t = chr2body.GetComponent<Image>();
                chra2t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra2ct = chr2c.GetComponent<Image>();
                chra2ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(1f, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(1f, 0, 0);

            }
            if (arrivechr > 2 & arrivechr <= 3)
            {
                Image chra3t = chr3body.GetComponent<Image>();
                chra3t.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image chra3ct = chr3c.GetComponent<Image>();
                chra3ct.sprite = Resources.Load<Sprite>("Chr/" + "transparentc");
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(1f, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(1f, 0, 0);

            }
            chr1body.transform.position = chr1l;
            chr2body.transform.position = chr2l;
            chr3body.transform.position = chr3l;
            chr1c.transform.position = chr1l;
            chr2c.transform.position = chr2l;
            chr3c.transform.position = chr3l;

            arrivegage = 0;
            arrivef = 0;
        }
        if (loadflag <= 0 & text_num>= arriveshantei)
        {
            chr1c.SetActive(true);
            arriveschr = int.Parse(script.chrcon[arrivesx].Substring(308, 6));

            if (arriveschr <= 1)
            {
                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(-1f, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(-1f, 0, 0);
            }

            TextManager.tnumf = 0;
            if (arriveschr > 1 & arriveschr <= 2)
            {
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(-1f, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(-1f, 0, 0);
            }
            if (arriveschr > 2 & arriveschr <= 3)
            {
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(-1f, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(-1f, 0, 0);
            }
            arrivesx += 1;
            arrivesf = 1;


        }
        if (arrivesf >= 1 & arrivesgage < 10)
        {
            if (arriveschr <= 1)
            {

                Image bgcu = chr1body.GetComponent<Image>();
                bgcu.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
                Image bgcuc = chr1c.GetComponent<Image>();
                bgcuc.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
            }
            if (arriveschr > 1 & arriveschr <= 2)
            {
                Image bgcu2 = chr2body.GetComponent<Image>();
                bgcu2.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
                Image bgcuc2 = chr2c.GetComponent<Image>();
                bgcuc2.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
            }
            if (arriveschr > 2 & arriveschr <= 3)
            {
                Image bgcu3 = chr3body.GetComponent<Image>();
                bgcu3.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
                Image bgcuc3 = chr3c.GetComponent<Image>();
                bgcuc3.GetComponent<Image>().transform.Translate(0.1f, 0, 0);
            }
            arrivesgage += 1;

        }
        if (arrivesf >= 1 & arrivesgage >= 10 & chrcf >= 0)
        {


            chr1body.transform.position = chr1l;
            chr2body.transform.position = chr2l;
            chr3body.transform.position = chr3l;
            chr1c.transform.position = chr1l;
            chr2c.transform.position = chr2l;
            chr3c.transform.position = chr3l;

            arrivesgage = 0;
            arrivesf = 0;
        }


        if ((chrcf == 0 | chrcf > 0 & chrcc > 0) & (unazf == 0 | unazf > 0 & unazc > 0) & (odorokif == 0 | odorokif > 0 & odorokic > 0) & (okiagarif == 0 | okiagarif > 0 & okiagaric > 0) & (daruf == 0 | daruf > 0 & daruc > 0) & arrivef == 0)
        {
            chsf = 0;
        }
        else
        {
            chsf = 1;
        }
        if (ax > 9999999)
        {
            ax = script.text[text_num].IndexOf(" ") + 1;
            chrnam = script.text[text_num].Substring(ax, 1);
        }
        animf = 0;

        if (Bgcontroller.chaptf == 0 & Bgcontroller.bgcf == 0 & Bgcontroller.bgcdf == 0 & antenhantei == 0 & animf > 0 & chsf == 0 & TextManager.chrnam != " " & mabatakif == 0)
        {
            if (animf == 1)
            {
                c1a = c1anim;
                anim1.SetInteger("c1a", c1a);

            }
            if (animf == 2)
            {

                c3a = c3anim + 100000;
                anim3.SetInteger("c3a", c3a);
                c2a = c2anim;
                anim2.SetInteger("c2a", c2a);
            }
            if (animf == 3)
            {

                c2a = c2anim + 100000;
                anim2.SetInteger("c2a", c2a);
                c3a = c3anim;
                anim3.SetInteger("c3a", c3a);
            }
         
        }
        if (mabatakif == 1)
        {
            if (animf == 1)
            {
                c1a = c1anim + 100000;
                anim1.SetInteger("c1a", c1a);
            }
            if (animf == 2)
            {
                c3a = c3anim + 100000;
                anim3.SetInteger("c3a", c3a);
                c2a = c2anim + 100000;
                anim2.SetInteger("c2a", c2a);
            }
            if (animf == 3)
            {
                c2a = c2anim + 100000;
                anim2.SetInteger("c2a", c2a);
                c3a = c3anim + 100000;
                anim3.SetInteger("c3a", c3a);
            }
        }

        if (animf == 0 & mabatakif == 2)
        {

            c1a = c1anim + 100000;
            anim1.SetInteger("c1a", c1a);

            c3a = c3anim + 100000;
            anim3.SetInteger("c3a", c3a);
            c2a = c2anim + 100000;
            anim2.SetInteger("c2a", c2a);
            if (Bgcontroller.bgcdf == 0)
            {

            }
        }
        if (Bgcontroller.chaptf == 0 & Bgcontroller.bgcf == 0 & Bgcontroller.bgcdf == 0)
        {
            if (animf >= 1 & (chsf == 1 | antenhantei == 1 | TextManager.canif == 1))
            {
                if (TextManager.canif == 1)
                {
                    TextManager.canif = 0;
                }
                if (animf == 1)
                {
                    var info = anim1.GetCurrentAnimatorStateInfo(0);
                    anim1.Play(info.nameHash, 0, 0.0f);
                    anim1.speed = 0;
                }
                if (animf == 2)
                {
                    var info = anim2.GetCurrentAnimatorStateInfo(0);
                    anim2.Play(info.nameHash, 0, 0.0f);
                    anim2.speed = 0;
                }
                if (animf == 3)
                {
                    var info = anim3.GetCurrentAnimatorStateInfo(0);
                    anim3.Play(info.nameHash, 0, 0.0f);
                    anim3.speed = 0;
                }

            }
            else
            {

                anim1.speed = 1;

                anim2.speed = 1;

                anim3.speed = 1;
            }
        }
        if (animf == 3 & anim3.GetCurrentAnimatorStateInfo(0).IsName(c3anim + 100000 + "") | animf == 1 & anim1.GetCurrentAnimatorStateInfo(0).IsName(c1anim + 100000 + "") | animf == 2 & anim2.GetCurrentAnimatorStateInfo(0).IsName(c2anim + 100000 + "") | animf == 0 & TextManager.tnumhantei == 0)
        {
            kf = 0;
        }
        else
        {
            kf = 1;
        }
        if (mabatakif == 2 & animf == 0 & mabatakif == 2 & animf == 0 & anim3.GetCurrentAnimatorStateInfo(0).IsName(c3anim + 100000 + "") & anim2.GetCurrentAnimatorStateInfo(0).IsName(c2anim + 100000 + "") | animf == 0 & anim1.GetCurrentAnimatorStateInfo(0).IsName(c1anim + 100000 + ""))
        {
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);
        }
        if (animf == 3 & anim3.GetCurrentAnimatorStateInfo(0).IsName(c3anim + "") | animf == 2 & anim2.GetCurrentAnimatorStateInfo(0).IsName(c2anim + "") | animf == 1 & anim1.GetCurrentAnimatorStateInfo(0).IsName(c1anim + ""))
        {
            chr1c.SetActive(false);
            chr2c.SetActive(false);
            chr3c.SetActive(false);

            if (TextManager.tanitime > 0)
            {
                if (animf == 1)
                {
                    var info = anim1.GetCurrentAnimatorStateInfo(0);
                    anim1.Play(info.nameHash, 0, 0.0f);
                    anim1.speed = 0;

                }
                if (animf == 2)
                {
                    var info = anim2.GetCurrentAnimatorStateInfo(0);
                    anim2.Play(info.nameHash, 0, 0.0f);
                    anim2.speed = 0;

                }
                if (animf == 3)
                {
                    var info = anim3.GetCurrentAnimatorStateInfo(0);
                    anim3.Play(info.nameHash, 0, 0.0f);
                    anim3.speed = 0;

                }

            }

            anim1.SetInteger("c1a", c1a);
            anim2.SetInteger("c2a", c2a);
            anim3.SetInteger("c3a", c3a);

        }
    }
}
