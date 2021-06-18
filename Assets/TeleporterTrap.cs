namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>
    /// An area is a teleportation destination which teleports the user to their pointed
    /// location on a surface.
    /// </summary>
    /// <seealso cref="TeleportationAnchor"/>
    /// 

    public class TeleporterTrap : TeleportationArea
    {

        public GameObject teleportLocation;

        private void Start()
        {
            //gameObject.layer = -1;
        }
        /// <inheritdoc />
        protected override bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
        {
            teleportRequest.destinationPosition = teleportLocation.transform.position;
            teleportRequest.destinationRotation = transform.rotation;
            Debug.Log("I should teleport!");
            return true;
        }

        public void OnActivate()
        {
            Debug.Log("ACTIVATE");
        }
    }
}
