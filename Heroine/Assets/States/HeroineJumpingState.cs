using UnityEngine;

public class HeroineJumpingState : MonoBehaviour, IHeroineState
{
    private HeroineController _heroineController;

    public void Handle(HeroineController heroineController)
    {
        if (!_heroineController)
            _heroineController = heroineController;
    }

    void Update()
    {
        if (_heroineController)
        {
            Debug.Log("In jumping state");
            Ray ray = new Ray(transform.position, Vector3.down);
            if (Physics.Raycast(ray, 1.0f))
            {
                _heroineController.Landing();
            }
        }
    }
}
