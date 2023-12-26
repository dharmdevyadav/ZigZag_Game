using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
  [SerializeField] float moveSpeed=2f;
  [SerializeField] bool movingRight=true;
  [SerializeField] Transform rayStart;
  Animator anim;
  Rigidbody rb;
  private GameManager gameManager;
  public void Awake()
  {
    rb = GetComponent<Rigidbody>();
    anim = GetComponent<Animator>();
    gameManager=FindObjectOfType<GameManager>();
  }
  
  public void FixedUpdate()
  {
    if (!gameManager.gamestarted)
    {
      return;
    }
    else
    {
      anim.SetBool("isIdle",true);
    }
    rb.transform.position = transform.position + transform.forward * moveSpeed*Time.deltaTime;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Switch();
    }
    RaycastHit hit;
    if(!Physics.Raycast(rayStart.position,-transform.up,out hit, Mathf.Infinity))
    {
      anim.SetTrigger("isfalling");
    }
  }
  public void Switch()
  {
    movingRight = !movingRight;
    if (movingRight)
    {
      transform.rotation = Quaternion.Euler(0, 45, 0);
    }
    else
    {
      transform.rotation = Quaternion.Euler(0,-45, 0);
    }
   
  }

}
