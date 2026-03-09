

using UnityEngine;

public class SteeringBehaviourManager : MonoBehaviour
{
    [Tooltip("Doesnt do anything")] [Header("Spawner settings")] [Space(height: 40)]
    public float other;
    
    
    public void DebugAllBehaviours()
    {
        foreach (SteeringBehaviour_Base item in FindAnyObjectByType<SteeringBehaviour_Base>(FindObjectsInactive.Include,
                     FindObjectsSortMode.None))
        {
            Debug.Log("GO = " + item.gameObject.name+" : behaviour"+item.ToString());
        }
        
               
    }
}