using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HudManager : MonoBehaviour
{
   public Text Score;
    public void UpdateScoreText(float Score)
    {
       this.Score.text = "Score :" + Score;
    }

}
