using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texte : MonoBehaviour
{
    public string[] Phrase;
    public int Size;
    public bool Defilement = true;
    public bool fin = false;
    public float speed = 0.2f;
    public GameObject bulle;

    private TextMesh Txt;
    private string TxtAfficher;

    private void Start()
    {
        Txt = transform.GetChild(0).GetComponent<TextMesh>();
        TxtAfficher = Phrase[0].Replace("|", System.Environment.NewLine);

        Size = Phrase.Length;

        if (Defilement)
        {
            StartCoroutine(AfficheTxt());
        }
        else
        {
            Txt.text = TxtAfficher;
        }
    }

    public int compteur = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            compteur++;

        if (compteur == 1)
        {
            StopCoroutine(AfficheTxt());
            Txt.text = TxtAfficher;
        }
        if (compteur == Size)
        {
            bulle.SetActive(false);
        }
        if (compteur == 2)
        {
            TxtAfficher = Phrase[1].Replace("|", System.Environment.NewLine);
            if (Defilement)
            {
                StartCoroutine(AfficheTxt());
            }
            Defilement = false;
        }
    }

    IEnumerator AfficheTxt()
    {
        string temp = TxtAfficher;
        int nbChar = TxtAfficher.Length;

        for (int i = 1; i <= nbChar; i++)
        {
            yield return new WaitForSeconds(speed);
            Txt.text = temp.Substring(0, i);
        }
    }
}
