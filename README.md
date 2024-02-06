# ATM_Project - 개인 프로젝트
 
### 📆 제작기간 

----

### ✅ 기능

1. 회원가입
2. 로그인
3. 입금
4. 출금

----

### ✅ 기능 설명


회원가입 - 아이디, 이름, 비밀번호, 재확인 비밀번호로 구성 

로그인 - 생성한 아이디를 비교해서 로그인 여부  


입금 기능 - 현재 가지고 있는 금액이 넣고자 하는 금액보다 적을 때 경고 팝업 표시 


출금 기능 - 계좌에 있는 금액이 빼고자 하는 금액보다 적을 때 경고 팝업 표시   

----

### ❗트러블 슈팅

문제 : 회원가입 후 로그인을 하면 NullReferenceException 문제 발생

원인 : 로그인 한 계정의 데이터를 불러오지 못함

시도 : 로그인 스크립트에 내가 입력한 ID와 List에 저장되어 있는 ID가 일치할 경우 List에 저장되어 있는 ID를 GameManager에서 만든 PlayerInfo의 참조변수에 넣어줌    

```
 foreach(var player in GameManager.I.playerInfo)
    {
        if (_playerId == player.playerId && _playerPw == player.playerPw)
        {
            Debug.Log("로그인 성공");
         📌   GameManager.I.player = player; // 해당 ID의 데이터들을 가르킬 수 있음
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            _idInput.text = "";
            _passwordInput.text = "";
            Debug.Log("로그인 실패");
        }
    } 
```


해결 : 위와 같은 시도로 해결하게 됨  

List에는 잘 저장이 되어있었지만 로그인하면서 그 계정에 속한 데이터를 가르키는 코드가 전혀 없어서 null 값이 발생했던 것





   
