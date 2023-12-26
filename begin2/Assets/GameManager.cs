using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI point_Txt;
    float point=0;

    private void Start()
    {
        point_Txt.text = "Point = 0";
    }


    public void PointInc()
    {
        point = point + 25;
        point_Txt.text = "Point : " + point.ToString();
    }

}
