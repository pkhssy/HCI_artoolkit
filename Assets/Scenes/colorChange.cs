using UnityEngine;

public class colorChange : MonoBehaviour{
    Renderer cubeColor;

    void Start(){
        cubeColor = gameObject.GetComponent<Renderer>();
    }

    void Update(){ // 마우스 버튼의 입력 감지
        if (Input.GetMouseButtonDown(0)){ // 버튼 입력이 감지될 경우 
            if (cubeColor.material.color != Color.blue){ // 파란색이 아니라면 파란색으로 변경
                cubeColor.material.color = Color.blue;
            } else{ // 파란색인 경우 빨간색으로 변경
                cubeColor.material.color = Color.red;
            }
        }
    }
}





