using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copzombieControl : MonoBehaviour
{
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _animator.SetTrigger("Punch");
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            _animator.SetBool("Dancing", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            _animator.SetBool("Dancing",false);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _animator.SetBool("Blocking", true);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            _animator.SetBool("Blocking", false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            _animator.SetTrigger("Die");
        }
    }
}
