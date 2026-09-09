using UnityEngine;
using System;
using System.Collections;

public class HeroineStandingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;

    public void Handle(HeroineController heroineController)
    {
        if (!_heroineController)
            _heroineController = heroineController;
        Debug.Log("In standingstate");
    }

    void Update()
    {
        if (_heroineController)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _heroineController.rb.AddForce(Vector3.up * _heroineController.jumpHeight, ForceMode.Impulse);
                _heroineController.Jumping();
            }
        }
    }
}
