using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _agroDistance;

    [SerializeField] private List<Transform> _waypoints;
    [SerializeField] private Transform _heroTarget;

    private Queue<Vector3> _waypointsPositions;
    private Vector3 _currentTarget;
    private float _minDistanceToWaypoint = 0.05f;

    private void Awake()
    {
        _waypointsPositions = new Queue<Vector3>();

        foreach (Transform target in _waypoints)
            _waypointsPositions.Enqueue(target.position);

        SwitchTarget();
    }

    private void Update()
    {
        Vector3 direction = GetDirectionToHero();

        if (direction.magnitude > _agroDistance)
        {
            //Keep Patrol
            direction = GetDirectionToTargetPoint();

            if (direction.magnitude <= _minDistanceToWaypoint)
                SwitchTarget();
        }

        Vector3 normalizedDirection = direction.normalized;

        MoveToTarget(normalizedDirection);
    }

    private Vector3 GetDirectionToHero() => _heroTarget.position - transform.position;

    private Vector3 GetDirectionToTargetPoint() => _currentTarget - transform.position;

    private void MoveToTarget(Vector3 direction) => transform.Translate(direction * _speed * Time.deltaTime, Space.World);

    private void LateUpdate() =>
        Debug.DrawRay(transform.position, GetDirectionToTargetPoint(), Color.red);

    private void SwitchTarget()
    {
        _currentTarget = _waypointsPositions.Dequeue();

        _waypointsPositions.Enqueue(_currentTarget);
    }
}