using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class score : MonoBehaviour
{
    public float pendingPoints;
    float currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        pendingPoints = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //other scripts load points into pP, then Update() adds the points in every frame
        if (pendingPoints > 0) {
            currentScore += pendingPoints;
            pendingPoints = 0;
        }
    }
}
