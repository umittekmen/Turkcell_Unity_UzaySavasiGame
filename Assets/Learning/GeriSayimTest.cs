using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{
    GeriSayim geriSayim;
    float baslangicZamani;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        geriSayim=gameObject.AddComponent<GeriSayim>();
        geriSayim.ToplamSure = 3;
        geriSayim.Calistir();
        baslangicZamani=Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayim.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);
            baslangicZamani = Time.time;
            geriSayim.Calistir();
        }
    }
}
