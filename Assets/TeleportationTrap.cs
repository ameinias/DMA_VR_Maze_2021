namespace UnityEngine.XR.Interaction.Toolkit
{
    /// <summary>BaseTeleportationInteractable
    /// An area is a teleportation destination which teleports the user to their pointed
    /// location on a surface.
    /// </summary>
    /// <seealso cref="TeleportationAnchor"/>
    public class TeleportationTrap : BaseTeleportationInteractable
    {


        /// <inheritdoc />
        protected override bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
        {
            teleportRequest.destinationPosition = raycastHit.point;
            teleportRequest.destinationRotation = transform.rotation;
            Debug.Log("TRAPPP");
            return true;
        }
    }
}
