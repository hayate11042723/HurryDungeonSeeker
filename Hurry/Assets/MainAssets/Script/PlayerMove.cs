using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    CharacterController characterController;
    PlayerInput playerInput;
    Animator animator;

    [SerializeField] private float speed = 10;

    // �ω��������͂�ێ�
    private Vector3 move_amount;

    // ���͂��ω������Ƃ��ɌĂ΂��iPlayer Input�R���|�[�l���g��Events�ɃZ�b�g����j
    public void OnMove(InputAction.CallbackContext context)
    {
        move_amount = context.ReadValue<Vector3>();
    }


    private void FixedUpdate()
    {
        if (move_amount.magnitude >= 0.1f)
        {
            gameObject.transform.Translate(new Vector3(move_amount.x, 0f, move_amount.y) * speed * Time.deltaTime);
        }
    }
}