using UnityEngine;
using System;

public class HeroineController : MonoBehaviour
{
    public float walkingSpeed = 2.0f;
    public float runningSpeed = 4.0f;
    public float fallingSpeed = 8.0f;
    public float jumpHeight = 8.0f;
    public Rigidbody rb;

    private IHeroineState _standingState, _sprintingState, _duckingState, _jumpingState, _fallingState, _divingState, _landingState;

    private HeroineStateContext _heroineStateContext;

    private void Start()
    {
        _heroineStateContext = new HeroineStateContext(this);
        _standingState = gameObject.AddComponent<HeroineStandingState>();
        _sprintingState = gameObject.AddComponent<HeroineSprintingState>();
        _duckingState = gameObject.AddComponent<HeroineDuckingState>();
        _jumpingState = gameObject.AddComponent<HeroineJumpingState>();
        _fallingState = gameObject.AddComponent<HeroineFallingState>();
        _divingState = gameObject.AddComponent<HeroineDivingState>();
        _landingState = gameObject.AddComponent<HeroineLandingState>();

        _heroineStateContext.Transition(_standingState);
    }

    public void Standing()
    {
        _heroineStateContext.Transition(_standingState);
    }

    public void Sprinting()
    {
        _heroineStateContext.Transition(_sprintingState);
    }

    public void Ducking()
    {
        _heroineStateContext.Transition(_duckingState);
    }

    public void Jumping()
    {
        _heroineStateContext.Transition(_jumpingState);
    }

    public void Falling()
    {
        _heroineStateContext.Transition(_fallingState);
    }

    public void Diving()
    {
        _heroineStateContext.Transition(_divingState);
    }

    public void Landing()
    {
        _heroineStateContext.Transition(_landingState);
    }
}
