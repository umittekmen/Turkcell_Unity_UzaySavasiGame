using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Rendering;

public static class EkranHesaplayici
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    /// <summary>
    /// ekranýn sag sol ust alt kordinatlarý  
    /// </summary>
    public static float Sol
    {
        get { return sol; }
    }
    public static float Sag
    {
        get { return sag; }
    }
    public static float Ust 
    {
        get { return ust; }
    }
    public static float Alt
    {
        get { return alt; }
    }

    public static void Init()
    {

        float ekranZekseni=-Camera.main.transform.position.z;
        Vector3 solAltkose=new Vector3(0,0,ekranZekseni);
        Vector3 sagUstkose = new Vector3(Screen.width, Screen.height, ekranZekseni);

        Vector3 solAltKoseOyunDunyasi = Camera.main.ScreenToWorldPoint(solAltkose);
        Vector3 sagUstKoseOyunDunyasi=Camera.main.ScreenToWorldPoint(sagUstkose);

        sol=solAltKoseOyunDunyasi.x;
        sag = sagUstKoseOyunDunyasi.x;
        ust = sagUstKoseOyunDunyasi.y;
        alt = solAltKoseOyunDunyasi.y;

    }




}





