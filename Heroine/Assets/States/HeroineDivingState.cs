using UnityEngine;

public class HeroineDivingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;

    public void Handle(HeroineController heroineController)
    {
        if (!_heroineController)
            _heroineController = heroineController;
        _heroineController.rb.AddForce(Vector3.right * _heroineController.diveForce);
        Debug.Log(Mathf.Sign(_heroineController.rb.linearVelocity.x));
        Debug.Log("Diving");
    }

    void Update()
    {
        if (_heroineController)
        {
            Ray ray = new Ray(transform.position, Vector3.down);
            if (Physics.Raycast(ray, 1.5f) && _heroineController.rb.linearVelocity.y < 0)
            {
                _heroineController.Landing();
                _heroineController = null;
            }
        }
    }
}

