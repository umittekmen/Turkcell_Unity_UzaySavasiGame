using UnityEngine;

public class GeriSayim : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;

    bool calisyor=false;
    bool basladi=false;
    /// <summary>
    /// gerisayým sayacýnýj toplam süresini ayarlar
    /// </summary>
    public float ToplamSure
    {
        set {
            if (!calisyor)
            {
                toplamSure=value;
            }
        
        }
    }
    /// <summary>
    /// geri sayýmýn bitip bitmediðin söyler
    /// </summary>
    
    public bool Bitti
    {
        get 
        {
            return basladi && !calisyor;
        
        }
    }
    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisyor=true;
            basladi = true;
            gecenSure = 0;
        }

    }




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (calisyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure>toplamSure) {
            calisyor=false; 
            }
        }


        
    }
}
