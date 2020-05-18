using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannequin : MonoBehaviour
{
    public bool joueurAttrape = false; //A des effets dans le levelManager
    public float speed = 0.6f;
    public bool porteNonOuverte = true; //devient false dans le levelManager quand la porte reçoit une interaction.

    public GameObject levelManager;
    public GameObject playerController;
    public GameObject mannequinAllonge;
    public GameObject pannel;
    public GameObject mannequinhead;
    public AudioSource poursuiteOST;

    private Transform target;

    private void Start()
    {
        target = playerController.GetComponent<Transform>();
    }

    private void Update()
    {
        if (levelManager.GetComponent<Journee01Manager>().startMannequin == true && porteNonOuverte == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            if(!poursuiteOST.isPlaying)
            {
                poursuiteOST.Play(0);
            }
        }
        if (porteNonOuverte == false)
        {
            gameObject.SetActive(false);
            mannequinAllonge.transform.position = new Vector3(transform.position.x, 1.747f, transform.position.z);
            mannequinAllonge.SetActive(true);
            if(poursuiteOST.isPlaying)
            {
                poursuiteOST.Stop();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        joueurAttrape = true;
        pannel.SetActive(true);
        mannequinhead.SetActive(true);
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        //Le retour au point de départ se fait sur le script du canavas (lié à l'animation)
    }
}
