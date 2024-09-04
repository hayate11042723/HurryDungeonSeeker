using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReplay : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�v���C���[�̃v���n�u��ݒ�")]
    private GameObject playerPrefab;

    // Update is called once per frame
    void Update()
    {
        // �ݒ肵��playerPrefab�Ɠ������O(�����"PlayerSphere")��GameObject��T���Ď擾
        GameObject playerObj = GameObject.Find(playerPrefab.name);

        // playerObj�����݂��Ă��Ȃ��ꍇ
        if (playerObj == null)
        {
            // playerPrefab����V����GameObject���쐬
            GameObject newPlayerObj = Instantiate(playerPrefab);

            // �V�����쐬����GameObject�̖��O���Đݒ�(�����"Player"�ƂȂ�)
            newPlayerObj.name = playerPrefab.name;
        }
    }
}
