using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    public bool run = false;
    public bool idle = true;

    public Animator EnemyAnimator;


    // Start is called before the first frame update
    void Start()
    {
        // ���̃X�N���v�g��ݒ肵��GameObject��NavMeshAgent�R���|�[�l���g���擾
        navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // CollisionDetector�N���X�ɍ����onTriggerStayEvent�ɃZ�b�g����B
    public void OnDetectObject(Collider other)
    {
        // ���m�����I�u�W�F�N�g��"Player"�^�O���t���Ă�΁A���̃I�u�W�F�N�g��ǂ�������
        if (other.tag == "Player")
        {
            // �Ώۂ̃I�u�W�F�N�g��ǂ�������
            navMeshAgent.destination = other.transform.position;
            EnemyAnimator.SetBool("run", true);
        }
    }

    // CollisionDetector�N���X�ɍ����onTriggerExitEvent�ɃZ�b�g����B 
    public void OnLoseObject(Collider other)
    {
        // ���m�����I�u�W�F�N�g��"Player"�^�O���t���Ă�΁A���̏�Ŏ~�܂�
        if (other.tag == "Player")
        {
            // ���̏�Ŏ~�܂�i�ړI�n�����̎������g�̏ꏊ�ɂ��邱�Ƃɂ��~�߂Ă���j
            navMeshAgent.destination = this.gameObject.transform.position;
            EnemyAnimator.SetBool("run", false);
        }
    }
}