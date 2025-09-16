using UnityEngine;

public class RaceCar : Car  // INHERITED from Car class which is the basic class for our car movement
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();  // INHERITANCE : We can simply use a method from the inherited class, which will be called without problems
                        // even though in this script there is nothing telling the method what to do.
                        // actually a cool concept :)
    }
}
