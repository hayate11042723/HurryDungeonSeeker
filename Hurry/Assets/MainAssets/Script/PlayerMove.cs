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

    // 変化した入力を保持
    private Vector3 move_amount;

    // 入力が変化したときに呼ばれる（Player InputコンポーネントのEventsにセットする）
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