using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.InputSystem;

public class HareketKontrol : MonoBehaviour
{
    float colliderBoyYarim;
    float colliderEnYarim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        BoxCollider2D collider=GetComponent<BoxCollider2D>();

        colliderBoyYarim = collider.size.y / 2;
        colliderEnYarim = collider.size.x / 2;



      
        //Uzay Gemisini Hareket Ettir

        //burada önce refreasn aldýk bizim oyun objemizdeki rigidbodyb burdaki rigidbody olsun dedik
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        //daha sorna o rigidbodyye güç uygulattýk vektör x ve y eksenindeki kuvveti belitiyo forceda kuvvet uygulansýn diye metod
        //impuls çizgisel momentumdaki deðiþim 


        //oyun objesini rasgeel bir kuvvetle hareket ettir
        rigidbody2D.AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5, 5)), ForceMode2D.Impulse);
        

    } //duvara temasta gelecek mesaj duvara çarpmadan sorna olackalar

    //duvara temasta gelecek mesaj duvara çarpmadan sorna olackalar
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("kemerlerinizi baðlayýn ");
    }
    void Update()
    {
        //asteroid mouse imlecini takip etsin
        //Vector2 mousePos = Mouse.current.position.ReadValue();
        //Vector3 position = new Vector3(mousePos.x, mousePos.y, 10f);
        
        //position=Camera.main.ScreenToWorldPoint(position);
        //transform.position = position;

        //ekrandaKal();

    }
    void ekrandaKal()
    {
        Vector3 position = transform.position;
        //x ekseni
        if (position.x-colliderEnYarim<EkranHesaplayici.Sol)
        {
            position.x = EkranHesaplayici.Sol + colliderEnYarim;

        }
        else if (position.x+colliderEnYarim>EkranHesaplayici.Sag)
        {
            position.x = EkranHesaplayici.Sag - colliderEnYarim; ;
        }
        //y ekseni
        if (position.y+colliderBoyYarim>EkranHesaplayici.Ust) 
        {
            position.y=EkranHesaplayici.Ust - colliderBoyYarim;
        
        }
        else if (position.y-colliderBoyYarim<EkranHesaplayici.Alt) 
        {
            position.y=EkranHesaplayici.Alt+colliderBoyYarim;
        }

            transform.position = position;
    }



}
