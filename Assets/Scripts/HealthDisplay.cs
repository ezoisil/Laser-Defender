using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healthText;
    

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {    
        Player player    = FindObjectOfType<Player>();

            healthText.text = player?.GetHealth().ToString();
        
    }
}
