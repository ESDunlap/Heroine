using UnityEngine;

public class HeroineJumpingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;
    float timer = 0;

    public void Handle(HeroineController heroineController)
    {
        if (!_heroineController)
            _heroineController = heroineController;
        _heroineController.rb.AddForce(Vector3.up * _heroineController.jumpHeight, ForceMode.Impulse);
        timer = 0;
    }

    void Update()
    {
        if (_heroineController)
        {
            timer += Time.deltaTime;
            Ray ray = new Ray(transform.position, Vector3.down);
            if (Physics.Raycast(ray, 1.5f) && _heroineController.rb.linearVelocity.y < 0)
            {
                _heroineController.Landing();
                _heroineController = null;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _heroineController.Falling();
                _heroineController = null;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && timer >= _heroineController.diveTime)
            {
                _heroineController.Diving();
                _heroineController = null;
            }
        }
    }
}
