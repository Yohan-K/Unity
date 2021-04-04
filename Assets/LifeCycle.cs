using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 초기화 영역
    // 게임 오브젝트 생성할 때, 최초 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // 활성화 ( 초기화 물리 영역 사이에 위치 )
    // 게임 오브젝트가 활성화 되었을 때 ( 연속성 )
    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }


    // 업데이트 시작 직전, 최초 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    
    // 물리 연산 영역
    // 물리 연산 하기 전에 실행되는 함수 (FixedUpdate)
    // 고정 된 실행 주기로 CPU를 많이 사용 -> CPU 부하 많음
    void FixedUpdate()
    {
        Debug.Log("이동");
    }

    // 게임 로직 영역
    // 물리 연산 제외한 나머지 주기적인 로직을 넣을 때 사용
    // 환경에 따라 실행 주기 다를 수 있음
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    // 모든 업데이트 끝난 후
    private void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }
    
    // 비활성화 영역
    // 게임 오브젝트가 비활성화 되었을 때
    private void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    // 해체
    // 게임 오브젝트가 삭제되기 직전에
    void OnDestory()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
