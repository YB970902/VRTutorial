using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTest : MonoBehaviour
{
    [SerializeField] Animator animHand;
    [SerializeField] ARAVRInput.Controller handSide;

    public readonly int PressIndex = Animator.StringToHash("PressIndex");
    public readonly int PressHand = Animator.StringToHash("PressHand");

    private void Start()
    {
        animHand.speed = 2.0f;
    }

    public void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.IndexTrigger, handSide))
        {
            animHand.SetBool(PressIndex, true);
        }
        
        if (ARAVRInput.GetUp(ARAVRInput.Button.IndexTrigger, handSide))
        {
            animHand.SetBool(PressIndex, false);
        }

        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger, handSide))
        {
            animHand.SetBool(PressHand, true);
        }

        if (ARAVRInput.GetUp(ARAVRInput.Button.HandTrigger, handSide))
        {
            animHand.SetBool(PressHand, false);
        }
    }
}
