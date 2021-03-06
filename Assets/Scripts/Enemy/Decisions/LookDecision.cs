using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/LookDecision")]
public class LookDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        return Look(controller);
    }

    private bool Look(StateController controller)
    {
        FieldOfView fov = controller.GetComponent<FieldOfView>();
        if (fov == null) return false;
        if (fov.VisibleTarget != null)
        {
            controller.Target = fov.VisibleTarget;
            return true;
        }
        return false;
    }
}
