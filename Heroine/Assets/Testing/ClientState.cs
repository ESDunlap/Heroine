using UnityEngine;

public class ClientState : MonoBehaviour
{
    private HeroineController _heroineController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _heroineController = (HeroineController) FindObjectOfType(typeof(HeroineController));
    }

    void OnGUI() 
    {
        if (GUILayout.Button("Start Bike"))
            _heroineController.Standing();
    }
}
