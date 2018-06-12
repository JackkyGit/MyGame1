using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ControlDelegate<T>(T a);
public delegate void ControlDelegate();

public class PlayerControl : MonoBehaviour
{
    public event ControlDelegate OnJumpDown;
    public event ControlDelegate OnActionDown;
    public event ControlDelegate OnAttackDown;
    public event ControlDelegate<float> OnVertical;
    public event ControlDelegate<float> OnHorizontal;

    public PlayerInput CustomInput { get { return Resources.Load("InputSettings") as PlayerInput; } }

    private void Update()
    {
        if (Input.GetButton(CustomInput.Vertical))
        {
            if (OnVertical != null)
            {
                OnVertical(Input.GetAxis(CustomInput.Vertical));
            }
        }
        if (Input.GetButton(CustomInput.Horizontal))
        {
            if (OnHorizontal != null)
            {
                OnHorizontal(Input.GetAxis(CustomInput.Horizontal));
            }
        }
        if (Input.GetButtonDown(CustomInput.Jump))
        {
            if (OnJumpDown != null)
            {
                OnJumpDown();
            }
        }
        if (Input.GetKeyDown(CustomInput.Action))
        {
            if (OnActionDown != null)
            {
                OnActionDown();
            }
        }
        if (Input.GetKeyDown(CustomInput.Attack))
        {
            if (OnAttackDown != null)
            {
                OnAttackDown();
            }
        }
    }
}
