using UnityEngine;
using UnityEngine.AI; 

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent; 

    // Update is called once per frame
    void Update()
    {
        //Check if the player press the Left Mouse Button
         if(Input.GetMouseButtonDown(0)) //0 means left mouse button
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); //Create a ray where player click the left mouse button
            RaycastHit hit; //store info on what the ray hit.

            if (Physics.Raycast(ray, out hit)) //If there is a ray shot out
            {
                //Move our Agent
                agent.SetDestination(hit.point);
            }
        }

    }
}
