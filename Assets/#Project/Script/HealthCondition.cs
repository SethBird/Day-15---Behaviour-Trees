using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "HealthCondition", story: "[Agent] [less] [HP]", category: "Conditions", id: "3a16085c8da6ee9bdcdca958d19c76c7")]
public partial class HealthCondition : Condition
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [Comparison(comparisonType: ComparisonType.All)]
    [SerializeReference] public BlackboardVariable<ConditionOperator> Less;
    [SerializeReference] public BlackboardVariable<float> HP;

    public override bool IsTrue()
    {
        return true;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
