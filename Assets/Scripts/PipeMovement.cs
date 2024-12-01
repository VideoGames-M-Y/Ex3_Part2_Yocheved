using UnityEngine;

public class PipeMovement : MonoBehaviour{

    [SerializeField] private float moveSpeed = 5f; 
    [SerializeField] private float delete = -30f;
    void Update(){
        transform.position = transform.position + (Vector3.left * moveSpeed);

        if(transform.position.x < delete){
            Destroy(gameObject);
        }
    }
}
