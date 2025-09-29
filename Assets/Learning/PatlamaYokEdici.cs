using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{
    GeriSayim geriSayim;
    SiraliYokEdici siraliYokEdici;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        geriSayim=gameObject.AddComponent<GeriSayim>();
        siraliYokEdici=Camera.main.GetComponent<SiraliYokEdici>();
        geriSayim.ToplamSure = 1;
        geriSayim.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayim.Bitti)
        {
            siraliYokEdici.HedefiYokEt();
            Destroy(gameObject);
        }
    }
}
