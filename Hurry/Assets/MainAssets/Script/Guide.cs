using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // �S�[��
    [SerializeField] Transform target;

    // �J�[�\��
    [SerializeField] Transform cursor;

    // Update is called once per frame
    void Update()
    {
        cursor.LookAt(target);
    }
}
