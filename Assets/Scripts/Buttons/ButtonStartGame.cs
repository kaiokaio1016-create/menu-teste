using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem buttonParticles;

    public void OnClick()
    {
        if (buttonParticles != null)
        {
            buttonParticles.Play();
        }
    }
}