using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    GeriSayim gerisayým;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gerisayým=gameObject.AddComponent<GeriSayim>();
        gerisayým.ToplamSure = 1;
        gerisayým.Calistir();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gerisayým.Bitti)
        {
            gerisayým.Calistir();
            SpawnAsteroid();
            
        }
        
    }
    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
