using UnityEngine;

public class Graphite : MonoBehaviour
{
    public float range = 100f;

    public Transform fpsCam;
    public ParticleSystem Tinta;
    public GameObject inkSpot;


    // Update is called once per frame
    void Update () {
    
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
        
    
    }

    void Shoot ()    
    {
        Tinta.Play();
   
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.position, fpsCam.forward, out hit ,range))
        {
            GameObject newTag = Instantiate(inkSpot,hit.point, inkSpot.transform.rotation);
        }       
       

       
    }
}
