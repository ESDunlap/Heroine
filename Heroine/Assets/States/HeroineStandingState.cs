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
        _heroineController.heroine.localScale = new Vector3(1, 1, 1);
        _heroineController.currentSpeed = _heroineController.walkingSpeed;
    }

    void Update()
    {
        if (_heroineController)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _heroineController.Jumping();
                _heroineController = null;
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                _heroineController.Sprinting();
                _heroineController = null;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _heroineController.Ducking();
                _heroineController = null;
            }
        }
    }
}
