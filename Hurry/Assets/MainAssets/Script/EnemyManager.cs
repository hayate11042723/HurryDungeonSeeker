using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;

    public Transform EnemyPlace1;
    public Transform EnemyPlace2;

    float TimeCount;

    public int Count;
    public int MaxCount;

    [SerializeField]
    private GameObject createPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(MaxCount <= Count)
        {
            return;
        }

        TimeCount += Time.deltaTime;
        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (TimeCount > 1.0f)
        {
            // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float x = Random.Range(EnemyPlace1.position.x, EnemyPlace2.position.x);
            // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float y = Random.Range(EnemyPlace1.position.y, EnemyPlace2.position.y);
            // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float z = Random.Range(EnemyPlace1.position.z, EnemyPlace2.position.z);

            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(Enemy1, new Vector3(x, y, z),Enemy1.transform.rotation);
            Count++;
            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(Enemy2, new Vector3(x, y, z), Enemy2.transform.rotation);
            Count++;

            // �o�ߎ��ԃ��Z�b�g
            TimeCount = 0f;
        }
    }
}
