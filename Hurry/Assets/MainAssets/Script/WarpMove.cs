using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpMove : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Warp());
    }

    private IEnumerator Warp()
    {
        while (true)
        {
            // 5�b�ゲ�ƂɃ��[�v�ړ�����B
            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(1040, 355, 540);

            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(600, 240, -990);

            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(100, 60, -40);
        }
    }
}