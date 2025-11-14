using TMPro;
using UnityEngine;

public class DistanceDetector : MonoBehaviour
{
    [SerializeField] private TMP_Text _distanceText;

    [SerializeField] private Transform _firstPoint;
    [SerializeField] private Transform _secondPoint;

    [SerializeField] private float _minDistanceToDetect;

    private void Update()
    {
        Vector3 direction = _secondPoint.position - _firstPoint.position;

        float distance = direction.magnitude;

        _distanceText.text = $"{distance:F2}";

        if (direction.magnitude < _minDistanceToDetect)
            _distanceText.color = Color.red;
        else
            _distanceText.color = Color.white;

        Debug.DrawLine(_firstPoint.position, _secondPoint.position, _distanceText.color);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(_secondPoint.position, _minDistanceToDetect);
    }
}