using UnityEngine;

public class ShootGun : Weapon
{
    private float _bulletsDistance = 0.15f;

    public override void Shoot(Transform shootPoint)
    {
        Debug.Log(typeof(ShootGun));
        Vector3 shootPointCentre = shootPoint.position;

        Instantiate(Bullet, shootPointCentre, Quaternion.identity);
        Instantiate(Bullet, shootPointCentre + Vector3.up * _bulletsDistance, Quaternion.identity);
        Instantiate(Bullet, shootPointCentre + Vector3.down * _bulletsDistance, Quaternion.identity);
    }
}