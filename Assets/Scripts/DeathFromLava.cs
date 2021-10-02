using UnityEngine;

public class DeathFromLava : MonoBehaviour
{
    public GameObject Player;
    public GameObject DeadPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lava")
        {
            Player.SetActive(false);
            DeadPlayer.SetActive(true);
            Instantiate(DeadPlayer, transform.position, transform.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
