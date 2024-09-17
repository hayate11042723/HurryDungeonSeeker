using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Controller : MonoBehaviour
{
    public float JumpPower;
    private Rigidbody rb;
    public string TagName;
    private bool isJumping = false;

    bool canMove = true;

    public Animator PlayerAnimator;

    public Transform Camera;
    public float Player_Speed;
    public float Rotation_Speed;

    Vector3 speed = Vector3.zero;
    Vector3 rot = Vector3.zero;

    bool isRun = false;

    public Collider WeaponCollider;


    Vector2 input = Vector2.zero;

    public class DpadControl : Vector2Control
    {
        public float speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void MoveSet()
    {
        speed.z = Player_Speed;
        transform.eulerAngles = Camera.transform.eulerAngles + rot;
    }

    void WeaponON()
    {
        WeaponCollider.enabled = true;
    }

    void WeaponOFF()
    {
        WeaponCollider.enabled = false;
        PlayerAnimator.SetBool("attack", false);
    } 
    void CanMove()
    {
        canMove = true;
    }

    // Xbox�R���g���[���[RT�{�^���ŃW�����v
    public void OnJump(InputAction.CallbackContext context)
    {
        //Performed�t�F�[�Y�̔�����s��
        if (context.phase == InputActionPhase.Performed && !isJumping)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = Vector3.up * JumpPower;
                isJumping = true;
            }
        }

    }

   

    // Xbox�R���g���[���[A�{�^���ōU��
    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            PlayerAnimator.SetBool("attack", true);
            canMove = false;
        }
    }

    //public void OnMove(InputAction.CallbackContext context)
    //{
    //    if (canMove == false)
    //    {
    //        return;
    //    }

    //    speed = Vector3.zero;
    //    rot = Vector3.zero;
    //    isRun = false;
    //    WeaponCollider.enabled = false;
    //    if (context.phase == InputActionPhase.Performed)
    //    {


    //        if (Input.GetKeyDown(KeyCode.W))
    //        {
    //            rot.y = -90;
    //            MoveSet();
    //        }
    //        if (Input.GetKeyDown(KeyCode.S))
    //        {
    //            rot.y = 90;
    //            MoveSet();
    //        }
    //        if (Input.GetKeyDown(KeyCode.A))
    //        {
    //            rot.y = 180;
    //            MoveSet();
    //        }
    //        if (Input.GetKeyDown(KeyCode.D))
    //        {
    //            rot.y = 0;
    //            MoveSet();
    //        }
    //    }

    //    transform.Translate(speed);
    //}
}
