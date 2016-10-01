﻿// ---------------------------------------------------------------------
// This file is auto-generated by behaviac designer, so please don't modify it by yourself!
// ---------------------------------------------------------------------

using System.Collections.Generic;

namespace behaviac
{
	partial class AgentMeta
	{

		static partial void registerMeta()
		{
			// ---------------------------------------------------------------------
			// properties
			// ---------------------------------------------------------------------

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta();
			_agentMetas[2436498804] = meta;

			// DJTest
			meta = new AgentMeta();
			_agentMetas[1241053461] = meta;
			meta.RegisterMemberProperty(2269881519, new CMemberProperty<int>("hp", delegate(Agent self, int value) { ((DJTest)self).hp = value; }, delegate(Agent self) { return ((DJTest)self).hp; }));
			meta.RegisterMemberProperty(4050060769, new CMemberProperty<bool>("isDead", delegate(Agent self, bool value) { ((DJTest)self).isDead = value; }, delegate(Agent self) { return ((DJTest)self).isDead; }));
			meta.RegisterMethod(2589968182, new CAgentMethodVoid<int>(delegate(Agent self, int param0) { ((DJTest)self).ChangeHp(param0); }));
			meta.RegisterMethod(4271107009, new CAgentMethodVoid<string, string>(delegate(Agent self, string param0, string param1) { ((DJTest)self).ExecuteLua(param0, param1); }));
			meta.RegisterMethod(2331964840, new CAgentMethodVoid(delegate(Agent self) { ((DJTest)self).ReBorn(); }));

			AgentMeta.Register<behaviac.EBTStatus>("behaviac.EBTStatus");
			AgentMeta.Register<System.Object>("System.Object");
			AgentMeta.Register<DJTest>("DJTest");

		}

		static partial void unRegisterMeta()
		{
			AgentMeta.UnRegister<behaviac.EBTStatus>("behaviac.EBTStatus");
			AgentMeta.UnRegister<System.Object>("System.Object");
			AgentMeta.UnRegister<DJTest>("DJTest");
		}
	}
}
