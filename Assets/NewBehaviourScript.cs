using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //1.초기화 영역
    
    //오브젝트 생성시 최초 실행
    void Awake()
    {
        //Debug.Log("데이터 준비 됨");
    }

    //활성화 오브젝트가 활성화 되었을때(게임을 킬때마다 실행 )
    void OnEnable()
    {
        //Debug.Log("로그인 함");
    }

    // Start is called before the first frame update
    //게임 시작시 업데이트 함수 실행전 최초 1번 실행
    void Start()
    {
        //Debug.Log("게임 시작준비, 예)사냥 장비 챙김");
        //Vactor3 오브젝트의 방향값 백터3 = 3D 백터2 = 2D
        //Vector3 vec = new Vector3(0, 0, 0);

        //transform.Translate(vec);//정의된 백터를 움직이게하는 함
    }
    
    //2.물리영역
    
    //uniti엔진이 물리연산을 하기 전 실행되는 함수
    //고정적인 실행주기로 CPU많이 사용 물리효과가 적용되는 오브젝트 상태를 변경할때 주로 쓰임
    void FixedUpdate()
    {
        //물리연산과 관련된 로직들이 보통 들어감
        //Debug.Log("플레이어 이동");
    }

    //매 프레임마다 호출 물리효과가 적용되지 않는 오브젝트 움직임, 단순한 타이머 동작시 실행
    void Update()
    {
        //Debug.Log("몬스터 사냥");
        
        //Input  게임내 입력을 관리하는 클래스
        if (Input.anyKeyDown) //입력이 되었을때
        {
            Debug.Log("key 눌림");
        }

        //입력중일때
        //if (Input.anyKey) Debug.Log("key 누르는중");

        
        //변수로는 KeyCode <- 클래스가 들어감 예) KeyCode.Return <- 엔터 입력
        //키 눌렸을때
        //Input.GetKeyDown();
        
        //키 누르고 있을때
        //Input.GetKey();
        
        //키 눌렀다 땠을 때
        //Input.GetKeyUp();

        //if (Input.GetKeyDown(KeyCode.A)) Debug.Log("엔터키 입력");
        
        //마우스 클릭 이벤트
        //if(Input.GetMouseButtonDown(0)) Debug.Log("죄클릭 입력");
        
        //유니티의 플레이어 인풋 세팅을 사용
        //Input.GetAxis("Horizontal") 사용시 반환값이 float 형으로 반환됨 (가중치 있음)
        //Input.GetAxisRaw("Horizontal") 사용시 반환값 int 형 (가중치 없음 )
        if (Input.GetButton("Horizontal")) Debug.Log("좌우 이동중" + Input.GetAxis("Horizontal"));

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        
        transform.Translate(vec);
    }

    //모든 Update 함수가 호출된 후, 마지막으로 호출 주로 오브젝트를 따라가게 설정한 카메라는 LateUpdate 를 사용
    //카메라가 따라가는 오브젝트가 Update함수 안에서 움직일 경우가 있기 때문
    void LateUpdate()
    {
        //Debug.Log("경험치 획득, 카메라 이동");
    }

    //비활성화(게임을 끌때)
    void OnDisable()
    {
        //Debug.Log("로그아웃 함");
    } 


    //3.해체영역

    //게임 오브젝트가 삭제될 때 
    void OnDestroy()
    {
        //Debug.Log("캐릭터 삭제");
    }
}
