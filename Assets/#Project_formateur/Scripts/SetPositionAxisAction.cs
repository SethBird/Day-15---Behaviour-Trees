using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "SetPositionAxis", story: "Set [Agent] Position on [Axis] to [Value]", category: "Action/Boss Fight", id: "bab829ec7e009c9fe4c441b02e1f035c")]
public partial class SetPositionAxisAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<Axes> Axis;
    [SerializeReference] public BlackboardVariable<float> Value;

    protected override Status OnStart()
    {
        Vector3 pos = Agent.Value.transform.position;
        switch (Axis.Value)
        {
            case Axes.X:
                pos.x = Value.Value;
                break;
            case Axes.Y:
                pos.y = Value.Value;
                break;
            case Axes.Z:
                pos.z = Value.Value;
                break;
            
        }
        Agent.Value.transform.position = pos;
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

