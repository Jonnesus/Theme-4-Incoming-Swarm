using UnityEngine;

[RequireComponent(typeof(InputManager))]

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private float damage = 10f;
    [SerializeField] private float shootDelay = 0.5f;
    [SerializeField] private float range = 100f;

    [SerializeField] private Camera fpsCam;

    private InputManager IM;

    private void Start()
    {
        IM = GetComponent<InputManager>();
    }

    private void Update()
    {
        if (IM.fire == true)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}