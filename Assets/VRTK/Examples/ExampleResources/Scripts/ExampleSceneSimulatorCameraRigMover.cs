namespace VRTK.Examples
{
    using UnityEngine;

    public class ExampleSceneSimulatorCameraRigMover : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Transform cameraRigTransform = transform.Find("VRSimulatorCameraRig");
            cameraRigTransform.position -= transform.position;
        }

        private void Start()
        {
            Rigidbody rigidBody = gameObject.GetComponentInChildren<Rigidbody>();
            rigidBody.isKinematic = false;
            rigidBody.detectCollisions = true;
        }
    }
}