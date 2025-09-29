using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Toplayici : MonoBehaviour
{
    //ekrana dinamik olarak dilediðimi,z kadar yýldýz oluþturacaðýz ve bir list içinde o yýldýzlarý kaydedeðiz 
    // daha sonra uzay gemisi tek tek dolasþýp o yýldýzlarý toplaycak.
    [SerializeField]
    GameObject yildizprefab;    
  
   List<GameObject> yildizlar=new List<GameObject>();
    
    /// <summary>
    /// hedefdeki yýldýzý söyler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0)
            {
                return (yildizlar[0]);
            }
            else
            {
                return null;
            }

        }
    }
    
   

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosi = Mouse.current.position.ReadValue();
            Vector3 position = new Vector3(mousePosi.x, mousePosi.y, 10f);

            RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero);

            position = Camera.main.ScreenToWorldPoint(position);

            //  yildizlar.Add(Instantiate(yildizprefab, position, Quaternion.identity));
            //yýldýzlarý listte tutmak için
            if (hit.collider == null||!hit.collider.CompareTag("Player"))
            {
                yildizlar.Add(Instantiate(yildizprefab, position, Quaternion.identity));

            }

        }

        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    // Mouse pozisyonunu al ve dünya koordinatýna çevir
        //    Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(
        //        new Vector3(Mouse.current.position.x.ReadValue(),
        //                    Mouse.current.position.y.ReadValue(),
        //                    -Camera.main.transform.position.z)); // Kamera Z ile düzleme ayar

        //    Vector2 mousePos2D = new Vector2(mouseWorldPos.x, mouseWorldPos.y);

        //    // Raycast ile kontrol et
        //    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        //    if (hit.collider == null)
        //    {
        //        yildizlar.Add(Instantiate(yildizprefab, mouseWorldPos, Quaternion.identity));
        //    }
        //}



    }
    /// <summary>
    /// para metreye göre 
    /// </summary>
    /// <param name="yokedilecekyildiz"></param>
    public void YildizYokEt(GameObject yokedilecekyildiz )
    {

        yildizlar.Remove(yokedilecekyildiz);
        Destroy(yokedilecekyildiz );
        
    }


}
