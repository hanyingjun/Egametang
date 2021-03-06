﻿using Base;
using UnityEngine;

namespace Model
{
	[Node(NodeClassifyType.Action, "创建UI特效")]
	public class CreateUIEffect : Node
	{
		[NodeInput("传入的UI参数", typeof(UI))]
		private string uiKey;

		[NodeField("特效")]
		private GameObject effect;

		public CreateUIEffect(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			Log.Debug($"创建UI特效: {this.effect.name}");
			return true;
		}
	}
}