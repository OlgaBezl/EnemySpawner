
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints;
    [SerializeField] private Mover _mover;

    private void Start()
    {
        ChangeCurrentWaypoint(_waypoints[0]);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Waypoint waypoint))
        {
            int index = _waypoints.IndexOf(waypoint);
            int nextIndex = 0;

            if (index + 1 < _waypoints.Count)
            {
                nextIndex = index + 1;
            }

            ChangeCurrentWaypoint(_waypoints[nextIndex]);
        }
    }

    private void ChangeCurrentWaypoint(Waypoint waypoint)
    {
        _mover.SetTarget(waypoint.transform);
    }
}
