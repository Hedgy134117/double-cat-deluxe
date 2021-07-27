using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=aLpixrPvlB8
public class MultipleTargetCamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] List<Transform> targets;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothTime = 0.5f;
    [SerializeField] float minZoom = 40f;
    [SerializeField] float maxZoom = 10f;
    [SerializeField] float zoomLimiter = 50f;
    Vector3 velocity;

    void LateUpdate() {
        if (targets.Count == 0) {
            return;
        }

        move();
        zoom();
    }

    public void findCats() {
        foreach(GameObject cat in GameObject.FindGameObjectsWithTag("Cat")) {
            targets.Add(cat.transform);
        }
    }

    void move() {
        Vector3 centerPoint = getCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    void zoom() {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, getGreatestDistance() / zoomLimiter);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
    }

    float getGreatestDistance() {
        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);
        foreach (Transform target in targets)
        {
            bounds.Encapsulate(target.position);
        }

        return bounds.size.x;
    }

    Vector3 getCenterPoint() {
        if (targets.Count == 1) {
            return targets[0].position;
        }

        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);
        foreach (Transform target in targets)
        {
            bounds.Encapsulate(target.position);
        }

        return bounds.center;
    }
}
