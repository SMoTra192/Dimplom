using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEffectsForGameOver : MonoBehaviour
{
   [SerializeField] private ParticleSystem Effect1, Effect2;

   public void startEffect()
   {
      Effect1.Play();
      Effect2.Play();
   }
}
