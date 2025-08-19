using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TestCode : MonoBehaviour
{
    [SerializeField] private Transform crosshair;

    public float speed = 5;
    public CharacterController cc;

    void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.One, ARAVRInput.Controller.LTouch))
        {
            // 높이를 다시 맞춘다.
            OVRManager.display.RecenterPose();
        }
        
        float h = ARAVRInput.GetAxis("Horizontal");
        float v = ARAVRInput.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        if(dir.magnitude > 1f) dir.Normalize();
        cc.Move(dir * speed * Time.deltaTime);
        
        ARAVRInput.DrawCrosshair(crosshair, false);
    }
}
