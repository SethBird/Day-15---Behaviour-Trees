using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Target Comparaison", story: "[Target] is to the left of [Agent]", category: "Conditions", id: "5843cfe57791e5137543e9289c7eaea7")]
public partial class TargetComparaisonCondition : Condition
{
    [SerializeReference] public BlackboardVariable<Transform> Target;
    [SerializeReference] public BlackboardVariable<Transform> Agent;

    public override bool IsTrue()
    {
        return Target.Value.position.x < Agent.Value.position.x;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
