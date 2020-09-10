using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour
{
    public Transform pfHealthBar;
    public int maxHealth;
    //public HealthBar healthBar;







    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(maxHealth);

        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);

/*        Debug.Log("Health: " + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health: " + healthSystem.GetHealthPercent());
        healthSystem.Heal(10);
        Debug.Log("Health: " + healthSystem.GetHealthPercent());

        //Debug.Log("Health " + healthSystem.GetHealth(100, 100));

        CMDebug.ButtonUI(new Vector2(100, 100), "damage", () =>
        {
            healthSystem.Damage(10);
            Debug.Log("Damaged: " + healthSystem.GetHealth());
        });
        CMDebug.ButtonUI(new Vector2(-100, 100), "heal", () =>
        {
            healthSystem.Heal(10);
            Debug.Log("Healed: " + healthSystem.GetHealth());
        });
*/


    }



    // Update is called once per frame
    void Update()
    {
        
    }



}
