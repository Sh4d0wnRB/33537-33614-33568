using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    public float Velocidade;
    public GameObject Player;
    private Rigidbody2D rbPlayer;
    void Start () {
        rbPlayer = Player.GetComponent<Rigidbody2D>();
    }

    public void MovementRight(){
        InvokeRepeating("MovementLoopRight",0f,0.0002f);
    }

    public void MovementLeft(){
        InvokeRepeating("MovementLoopLeft",0f,0.0002f);
    }

    public void CancelReapeatRight(){
        CancelInvoke("MovementLoopRight");
        rbPlayer.drag = 2f;
    }
    public void CancelReapeatLeft(){
        CancelInvoke("MovementLoopLeft");
        rbPlayer.drag = 2f;
    }

    private void MovementLoopRight(){
        rbPlayer.velocity = new Vector2(1 * Velocidade * Time.deltaTime, rbPlayer.velocity.y);
    }

    private void MovementLoopLeft(){
        rbPlayer.velocity =  new Vector2(-1 * Velocidade * Time.deltaTime, rbPlayer.velocity.y);
    }

    public void Jump(float ForcaPulo){
        rbPlayer.AddForce(new Vector2(rbPlayer.velocity.x, ForcaPulo * Time.deltaTime));
    }
}
