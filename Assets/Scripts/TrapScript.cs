using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class TrapScript : MonoBehaviour
{
    GameObject Player;
    public float TrapSlow = 4f;
    public float TrapJumpSlow;
    public PlayerHP playerhp;
    public int LavaDamage = 5;
    float startTime;
    public Playermovement playermovement;
  

    private void Start()
    {
        Player = GameObject.Find("Player");
        playerhp = Player.gameObject.GetComponent<>();
        playermovement = Player.gameObject.GetComponent<>();
    }
    public void PlayerTakesDamage()
    {
        playerhp.playerHP -= LavaDamage;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && this.CompareTag("Lava"))
        {
            playermovement.jumpHeight = TrapJumpSlow;
            playermovement.speed = TrapSlow;
            if (Time.time > startTime + 0.5f)
            {
                startTime = Time.time;
                PlayerTakesDamage();
            }
        }     
    }  
    
    private void OnTriggerExit(Collider other)
    {

        playermovement.speed = 12f;
        playermovement.jumpHeight = 1;
       
    }
    */





