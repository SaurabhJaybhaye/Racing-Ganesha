using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float Score;
    public void UpdateScore(float value)
    {
        Score += value;
    }
    public void DamageScore(float value)
    {
        Score -= value;
    }
  
}
