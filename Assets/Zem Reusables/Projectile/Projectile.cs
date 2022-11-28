using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float movementSpeed = 20F;
    public float MovementSpeed { get => movementSpeed; private set => movementSpeed = value; }

    [Header("Setup")]
    [SerializeField] private GameObject shooter;
    [SerializeField] private IProjectileWeapon weapon;
    [SerializeField] private Action onFinish;
    public GameObject Shooter { get => shooter; private set => shooter = value; }
    public IProjectileWeapon Weapon { get => weapon; private set => weapon = value; }
    public Action OnFinish { get => onFinish; private set => onFinish = value; }

    public void Setup(GameObject shooter, IProjectileWeapon weapon, Action onFinish)
    {
        //Physics.IgnoreCollision(collider, user.GetComponent<Collider>());
        Shooter = shooter;
        Weapon = weapon;
        OnFinish = onFinish;
    }

    //private void Update()
    //{
    //    //UpdateLifespan();
    //    //UpdateMovement();
    //}

    private void OnDestroy()
    {
        if (OnFinish != null) OnFinish();
    }

    //private void UpdateLifespan()
    //{
    //    Vector3Int gridPosition = levelGrid.GetGridPosition(transform.position);
    //    bool isInside = levelGrid.IsInsideGrid(gridPosition);
    //    if (!isInside) Destroy(gameObject);
    //}
    
    //private void UpdateMovement()
    //{
    //    Vector3 position = transform.position;
    //    Vector3 direction = transform.forward;
    //    float distance = MovementSpeed * Time.deltaTime;
    //    Physics.Raycast(position, direction, out RaycastHit raycastHit, distance);
    //    Collider collider = raycastHit.collider;
    //    if (!collider)
    //    {
    //        PerformMovement();
    //        return;
    //    }
    //    GameObject gameObject = collider.GetComponent<GameObject>();
    //    if (Shooter && Shooter == gameObject)
    //    {
    //        PerformMovement();
    //        return;
    //    }
    //    Vector3 point = raycastHit.point;
    //    transform.position = point;
    //    //colliderHit = collider;
    //}

    //private void PerformMovement()
    //{
    //    Vector3 direction = transform.forward;
    //    Vector3 translation = direction * MovementSpeed;
    //    translation *= Time.deltaTime;
    //    transform.Translate(translation, Space.World);
    //}
}
