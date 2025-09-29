using UnityEngine;

public class Yokedici : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;
    GeriSayim yokEdiciGeriSayim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yokEdiciGeriSayim=gameObject.AddComponent<GeriSayim>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayim.Bitti)
        {
            GameObject patlama=Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        
    }

    public void AsteroidYokEdici(int sure)
    {
        yokEdiciGeriSayim.ToplamSure = sure;
        yokEdiciGeriSayim.Calistir();

    }


}
