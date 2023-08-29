using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Portal : MonoBehaviour
{
    public UnityEvent portal;

    public Transform transformPos;
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            portal?.Invoke();
        }
    }

    public void PositionChange()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        player.transform.position = transformPos.transform.position;
    }

}
