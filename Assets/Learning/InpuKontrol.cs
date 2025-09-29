using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InpuKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    //list tanýmlamasý böyle
    List<GameObject> asteroidList = new List<GameObject>();
    

    //array tanýmý bu þekilde
    //GameObject[] asteroidler=new GameObject[4];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {

            Debug.Log("mauseun yeri: "+Mouse.current.position.ReadValue());
           
            Vector2 mousePosi = Mouse.current.position.ReadValue();
            Vector3 position = new Vector3(mousePosi.x, mousePosi.y, 10f);
            
            position=Camera.main.ScreenToWorldPoint(position);


            for (int i=0;i<10;i++) {
               
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));

            }

            //döngüsüz array örneði 

            //asteroidler[0]=Instantiate(asteroidPrefab, position, Quaternion.identity);
            //asteroidler[1] = Instantiate(asteroidPrefab, position, Quaternion.identity);
            //asteroidler[2] = Instantiate(asteroidPrefab, position, Quaternion.identity);
            //asteroidler[3] = Instantiate(asteroidPrefab, position, Quaternion.identity);
           


        }

        //burada mouse ile spwanýn ikini kod kýsmý yeni sisteme göre ysapýlmýþ
        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    Instantiate(asteroidPrefab, 
        //    Camera.main.ScreenToWorldPoint
        //    (
        //        new Vector3(Mouse.current.position.x.ReadValue(),Mouse.current.position.y.ReadValue(),10f)
        //    ),
        //    Quaternion.identity);

        //}

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Debug.Log("SOL TIK");
            


        }
             if (Mouse.current.rightButton.wasPressedThisFrame)
            {
                Debug.Log("sag týk");
            //ARAYLÝST ÝLE ASTEROÝD YOK ETME
            //for (int i = 0; i < asteroidler.Length; i++)
            //     {

            //    Destroy(asteroidler[i]);


            //    }

            //list ile asteroid yok etme
            //for (int i = 0; i < asteroidList.Count; i++)
            //{
            //    Destroy(asteroidList[i]);

            //}

            foreach (GameObject ast in asteroidList) 
            {


                Destroy(ast);


            }



              }
            //mantýksal hata düzeltme list temizelem
            //asteroidList.Clear();
            
        if (Mouse.current.middleButton.wasPressedThisFrame) {

                Debug.Log("ora tekerlek");
            }
           





        }
}
