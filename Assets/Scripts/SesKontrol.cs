using UnityEngine;

public class SesKontrol : MonoBehaviour
{   [SerializeField]
    AudioClip asteroidPatlama;
    [SerializeField]
    AudioClip gemiPatlama;
    [SerializeField]
    AudioClip ates;
   
    AudioSource audioSource;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AsteroidPatlama()
    {
        audioSource.PlayOneShot(asteroidPatlama);
    }

    public void GemiPatlama(){
        audioSource.PlayOneShot(gemiPatlama);
    }
    public void Ates(){
        audioSource.PlayOneShot(ates,0.5f);
    }
    
}
