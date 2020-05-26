using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManequinLieProjecteur : MonoBehaviour
{
    public bool doActivationMur = false;

    //Appelé en Animevent.
    public void DoActivationMur()
    {
        doActivationMur = true;
    }
}
