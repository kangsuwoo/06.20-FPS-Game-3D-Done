using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{

    // ����Ƽ �÷ο� ��Ʈ
    // https://docs.unity3d.com/kr/530/Manual/ExecutionOrder.html

    // Initialization : �ʱ�ȭ �Լ�
    // �� �Լ����� �ʱ�ȭ �� �� ���� ���ȴ�
    // void awake()             Start �Լ� ���� ������ ����ȭ ���� ȣ��
    // void OnEnable()          ������Ʈ�� Ȱ��ȭ �� �� Awake ������ ȣ���
    // void Start()             ��ũ��Ʈ (�ڱ� �ڽ�) �� Ȱ��ȭ �� �� ȣ���

    // Updates : ��� ���ư��� �Լ�
    // void FixedUpdate()       Update ���� ���� ȣ��� �� �ִ�. �������� ������ ���� ���� �� ȣ��� Ȯ������
    // void Update()            �����Ӹ��� �� ���� ȣ��
    // void LateUpdate()        Update �� ���� ���� ������ ���� �� ���� ȣ��

    // Option ..
    // void OnDisable()         ��ũ��Ʈ�� ��Ȱ��ȭ �� �� ȣ��� (OnEnable �̶� �ݴ�)
    // void OnDestroy()         ������Ʈ�� �ı��� �� ȣ��� (�� ������ �����ӿ� ȣ���)

    // C# ?
    // class �� ���� ��ũ��Ʈ�� ���� ?
    // class �� �� �׷��� '��ü' ��� �ϰ�, ��ũ��Ʈ�� �� �׷��� �ڵ�(Code) �̴�
    // ��ũ��Ʈ ģ�� -> �ڵ� ģ��

    // ����Ƽ �ν����Ϳ��� ������Ʈ�� ���� �� �ִ� '��ü' ����� ���
    // 1. �ݵ�� public class ���� �̿��� �Ѵ�
    // 2. �ݵ�� MonoBehavior �� ��ӹ޾ƾ� �Ѵ�
    // 3. class �̸��� ��ũ��Ʈ ���� ���� �����ؾ� �Ѵ� (�ƴϸ� ����Ƽ���� �� ��´�)

    // C# ���� ����, �Լ�, Ŭ���� ���� ��
    // C++ �̶� ���� ����ϴ�
    // public, private, protected, internal ����� '���� ������' <- ã�� ����
    // 1. ������ �տ� �����ڸ� �ٿ��� �ϴµ�, ������ ������ �ڵ����� private �� �ȴ�
    // int value = 0; -> private int value = 0;
    // public int value - 0; -> �տ� public �� �����Ƿ� �ڵ����� ����Ƽ Inspector�� �����ȴ�
    // �׷��� public class ����� ������ public ���� �ؾ� ����Ƽ�� ������ �� �ֱ� ����
    // public �̸� �ڵ����� [SerializeField] ���  Attribute (�Ӽ�) Ŭ���� �� �ٴ´�
    // ��� �پ��־�� ����Ƽ�� ���� �ȴ�
    // [SerializeField] private int value = 0; -> private �̶� �ϴ��� �տ� �ø�������� �Ӽ� Ŭ������ �ִٸ� ���� �ȴ�
    // Ex) A Ŭ���� �ȿ� �� public ���� �ϰ� �ٸ� ����� A Ŭ������ ����Ѵٸ�
    // A. Ŭ���� �ȿ� �ִ� �ۺ����� �� ���δ�
    // 1. �ǵ帮�� ���ƾ� �� �κ��� �ٸ� �����ڰ� �ǵ帱 �� �ִ�
    // 2. ���� �Ǵ� �Լ� �翡 ���� ���ڸ������� ���������ϰ� ��������
    // 3. ��ŷ ������ ���� ����!

    [SerializeField] private GameObject m_Prefab;
    [SerializeField] private Transform m_AimPointTransform;
    public float m_MoveSpeed = 6f;
    public float m_RotateSpeed = 1f;

    public void Update()
    {

        // Ű ���� �� Ȯ���ϴ� ��
        // ���� ����� File -> Build Settings -> Input Manager

        float translation = Input.GetAxis("Vertical") * m_MoveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * m_RotateSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(Input.GetButtonDown("Fire1"))
        {
            var go = Instantiate(m_Prefab, m_AimPointTransform.position, m_AimPointTransform.rotation, null); ;
            // Getcomponent ?
            // �ϴ�, transform, gameObject ����� �������� 
            // �� ��ũ��Ʈ�� ������ �ִ� ��ü�� ���
            var rigidbody = go.GetComponent<Rigidbody>();
            rigidbody.AddRelativeForce(Vector3.forward * 1000f);
            
        }
    }








}
