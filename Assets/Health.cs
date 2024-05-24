using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
   public float health;

    public float maxHealth;
    public Image healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        
        if(health<=0)
        {
          SceneManager.LoadScene("Level 1");
          Debug.Log("Dead");
        }


    }
}
