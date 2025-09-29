using UnityEngine;

public class ArkaPlan : MonoBehaviour
{
    MeshRenderer meshRanderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRanderer=GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = 0.1f * Time.time;
        meshRanderer.material.SetTextureOffset("_MainTex", new Vector2(0, y));
        
    }
}
