using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// gemini maxhýýz
    /// </summary>
    int maxHýz;
    /// <summary>
    /// uzaygemisin rengi
    /// </summary>
    string renk;
    /// <summary>
    /// max hýz deðerini döner
    /// </summary>
    public int MaxHýz
    {
        get { return maxHýz; }




    }
    public string Renk
    {
        get { return renk; }
    }
    /// <summary>
    /// max hýz ve rengi yazýn
    /// </summary>
    /// <param name="maxHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maxHiz,string renk)
    {
        this.maxHýz = maxHiz;
        this.renk = renk;


    }
    public UzayGemisi(int maxHiz) 
    {
        this.maxHýz=maxHiz;    
    
    }

    public UzayGemisi()
    {
    }
    /// <summary>
    /// uzay gemisi hýzlandýram gücü
    /// </summary>
    public void Hizlandirici()
    {
        maxHýz += Random.Range(5, 20);
        //Debug.Log(maxHýz);
    }
    /// <summary>
    /// uzay gemisi yavaþlatma
    /// </summary>
    public void Yavaslatici()
    {
        maxHýz -= Random.Range(5, 20);
        Debug.Log(maxHýz);

    }
}
