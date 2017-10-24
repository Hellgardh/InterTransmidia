using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{

    //Specifics

    public static float M_Horizontal()
    {
        float i = 0f;
        i += Input.GetAxis("Horizontal");
        i += Input.GetAxis("Gamepad_LStickX");
        return Mathf.Clamp(i, -1f, 1f);
    }

    public static float M_Vertical()
    {
        float i = 0f;
        i += Input.GetAxis("Vertical");
        i += Input.GetAxis("Gamepad_LStickY");
        return Mathf.Clamp(i, -1f, 1f);
    }

    public static float P_Horizontal()
    {
        float i = 0f;
        i += Input.GetAxis("PedroHorizontal");
        i += Input.GetAxis("Gamepad_RStickX");
        return Mathf.Clamp(i, -1f, 1f);
    }

    public static float P_Vertical ()
    {
        float i = 0f;
        i += Input.GetAxis("PedroVertical");
        i += Input.GetAxis("Gamepad_RStickY");
        return Mathf.Clamp(i, -1f, 1f);
    }

}
