using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;
    OyunKontrol oyunKonqtrol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        oyunKonqtrol=Camera.main.GetComponent<OyunKontrol>();
        //rastgele yon
        float yon = Random.Range(0f, 1.0f);
        if (yon < 0.5f)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(yon * 2.0f);
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(-yon*2.0f);
        }


       


            

    }

     void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag=="Kursun")
            {
                GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AsteroidPatlama();
                oyunKonqtrol.AsteroidYokOldu(gameObject);
                 AsteroidYokEt();
                
            }

        }
        
        public void AsteroidYokEt()
        {
            GameObject patlama = Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(patlama, 2f);
            Destroy(gameObject);
         }





    // Update is called once per frame
    void Update()
    {
        
    }
}
