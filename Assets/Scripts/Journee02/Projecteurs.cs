using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecteurs : MonoBehaviour
{
    public GameObject mur;
    public GameObject effetMur; //prefab pour l'arrêt de la projection.

    private Animator projecteurAnim;
    private AudioSource projectionSound;

    private bool dansTrigger = false;
    public bool murActive = true;

    private void Start()
    {
        projecteurAnim = gameObject.GetComponent<Animator>();
        projectionSound = gameObject.GetComponent<AudioSource>();
        EtatDuMur();
    }

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if(Input.GetKeyDown("e") && dansTrigger == true && murActive == true)
        {
            projecteurAnim.SetTrigger("Desactivation");
            DesactiveMur();
        }
        else if(Input.GetKeyDown("e") && dansTrigger == true && murActive == false)
        {
            projecteurAnim.SetTrigger("Activation");
            ActiveMur();
        }
    }

    private void ActiveMur()
    {
        mur.SetActive(true);
        projectionSound.Play(0);
        murActive = true;
    }

    private void DesactiveMur()
    {
        mur.SetActive(false);
        Destroy(Instantiate(effetMur, new Vector3(mur.transform.position.x, mur.transform.position.y, mur.transform.position.z), new Quaternion(mur.transform.rotation.x, mur.transform.rotation.y, mur.transform.rotation.z, mur.transform.rotation.w)), 3.5f);
        projectionSound.Stop();
        murActive = false;
    }

    //On check et applique l'état correcte au mur.
    private void EtatDuMur()
    {
        if(murActive == true)
        {
            mur.SetActive(true);
            projecteurAnim.SetTrigger("Activation");
            projectionSound.Play(0);
        }
        else if(murActive == false)
        {
            mur.SetActive(false);
            projecteurAnim.SetTrigger("Desactivation");
            projectionSound.Stop();
        }
    }

    //On autorise le joueur à interagir dans le trigger.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = true;
            transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = true;
        }
    }

    //On refuse au joueur l'intéraction hors du trigger.
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = false;
            transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = false;
        }
    }
}
