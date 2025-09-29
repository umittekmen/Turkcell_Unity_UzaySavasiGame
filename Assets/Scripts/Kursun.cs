using Unity.VisualScripting;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayim gerisayim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        gerisayim = gameObject.AddComponent<GeriSayim>();
        gerisayim.ToplamSure = 3;
        gerisayim.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (gerisayim.Bitti)
        {
            Destroy(gameObject);
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }


}
