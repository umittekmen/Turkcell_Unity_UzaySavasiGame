using UnityEngine;
using UnityEngine.InputSystem;

public class UzayGemisiKontrol : MonoBehaviour
{
    const float hareketGucu = 10f;

    bool topluyor=false;

    GameObject hedef;

    Rigidbody2D myRigidbody2d;
    Toplayici toplayici;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody2d = GetComponent<Rigidbody2D>();
        //toplayiic maincamerada olduðu için böyle yaptýk
        toplayici= Camera.main.GetComponent<Toplayici>();
        
    }
    
    
     void OnMouseDown()
    {
        if (!topluyor)
        {
            Gitvetopla();
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef);
            myRigidbody2d.linearVelocity = Vector2.zero;
            Gitvetopla();




        }
    }
    void Gitvetopla() 
    {
        hedef = toplayici.HedefYildiz;
        if(hedef != null)
        {
            Vector2 gidilecekyer=new Vector2(hedef.transform.position.x-transform.position.x, hedef.transform.position.y-transform.position.y);
            gidilecekyer.Normalize();
            myRigidbody2d.AddForce(gidilecekyer*hareketGucu,ForceMode2D.Impulse);
        }
    
    }


    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && !topluyor)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            if (GetComponent<Collider2D>().OverlapPoint(mousePos))
            {
                Gitvetopla();
            }
        }


        //gemi wasd hareket 
        //    Vector3 possition=transform.position;

        //    float yatayInput = 0f;
        //    float dikeyInput=0f;
        //    //yatayda hareket
        //    if (Keyboard.current.aKey.isPressed) 
        //    {
        //        yatayInput -=1f;

        //    }

        //    if (Keyboard.current.dKey.isPressed)
        //    {
        //        yatayInput += 1f;

        //    }


        //    //dikeydehareket
        //    if (Keyboard.current.wKey.isPressed)
        //    {
        //        dikeyInput += 1f;
        //    }

        //    if (Keyboard.current.sKey.isPressed) { 

        //    dikeyInput -= 1f;
        //    }
        //    possition.x += yatayInput* hareketGucu* Time.deltaTime;
        //    possition.y += dikeyInput * hareketGucu * Time.deltaTime;
        //    transform.position = possition;

    }
}
