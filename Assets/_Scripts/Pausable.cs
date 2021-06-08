using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class Pausable : MonoBehaviour
{
    public List<MonoBehaviour> scripts;
    public List<NavMeshAgent> agents;
    public bool isGamePaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePaused()
    {
        isGamePaused = !isGamePaused;

        foreach (var script in scripts)
        {
            script.enabled = !isGamePaused;
        }

        foreach (var agent in agents)
        {
            agent.enabled = !isGamePaused;
        }
    }
}
