using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80,100));
        UzayGemisi gemi2= new UzayGemisi(Random.Range(80, 100), "gri");
        gemi1.Hizlandirici();
        gemi2.Hizlandirici();
        gemi1.Yavaslatici();
        gemi2.Yavaslatici();
       
        if (gemi1.MaxHýz > gemi2.MaxHýz)
        {
            Debug.Log("kazanan gemi1");
        }
        else if (gemi2.MaxHýz> gemi1.MaxHýz)
        {
            Debug.Log("gemi2 kazandý ");

        }
        else 
        {
            Debug.Log("durumlar eþit");
        
        }


        //int saldiranDusman = 10;
        //bool saldiriDevam = true;
        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //}
        //Debug.Log("saldýrý altindayiz, düþman sayýsý: " + saldiranDusman);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
