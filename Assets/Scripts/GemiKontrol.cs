using UnityEngine;
using UnityEngine.InputSystem;
public class GemiKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab;
    [SerializeField]
    GameObject patlamaPrefab;
    const float hareketGucu = 5f;

    OyunKontrol oyunKontrol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        oyunKontrol =Camera.main.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        //gemi wasd hareket 
        Vector3 possition = transform.position;

        float yatayInput = 0f;
        float dikeyInput = 0f;
        //yatayda hareket
        if (Keyboard.current.aKey.isPressed)
        {
            yatayInput -= 1f;

        }

        if (Keyboard.current.dKey.isPressed)
        {
            yatayInput += 1f;

        }


        //dikeydehareket
        if (Keyboard.current.wKey.isPressed)
        {
            dikeyInput += 1f;
        }

        if (Keyboard.current.sKey.isPressed)
        {

            dikeyInput -= 1f;
        }
        possition.x += yatayInput * hareketGucu * Time.deltaTime;
        possition.y += dikeyInput * hareketGucu * Time.deltaTime;
        transform.position = possition;

        if (Keyboard.current.spaceKey.wasPressedThisFrame) 
        {
            Vector2 kursunPozisyon=gameObject.transform.position;
            kursunPozisyon.y += 1;
            Instantiate(kursunPrefab,kursunPozisyon,Quaternion.identity);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            oyunKontrol.OyunuBitir();

            Instantiate(patlamaPrefab,gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
}
