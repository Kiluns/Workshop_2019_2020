using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journee02Manager : MonoBehaviour
{
    public GameObject projecteurBloquant;
    public GameObject murBloque;
    public GameObject effetMurBloque;

    private bool effetAJoue = true;

    private void Start()
    {
        effetMurBloque.transform.localScale = murBloque.transform.localScale;
    }

    private void Update()
    {
        BloquageMur();
    }

    private void BloquageMur()
    {
        if(projecteurBloquant.GetComponent<Projecteurs>().murActive == true && effetAJoue == false)
        {
            effetAJoue = true;
            murBloque.SetActive(false);
            Destroy(Instantiate(effetMurBloque, new Vector3(murBloque.transform.position.x, murBloque.transform.position.y, murBloque.transform.position.z), new Quaternion(murBloque.transform.rotation.x, murBloque.transform.rotation.y, murBloque.transform.rotation.z, murBloque.transform.rotation.w)), 3.5f);
        }
        if (projecteurBloquant.GetComponent<Projecteurs>().murActive == false && effetAJoue == true)
        {
            effetAJoue = false;
            murBloque.SetActive(true);
        }
    }
}
