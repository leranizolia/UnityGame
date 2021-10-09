using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Teleport1")
        {
            Player.transform.position = new Vector3(115F, 1F, 115F);
        }

        if (other.tag == "Teleport2")
        {
            Player.transform.position = new Vector3(50F, 1F, 190F);
        }
    }
}
