﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{

	public class BehaviorLoaderImplement : BehaviorLoader
	{
		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 107115361;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(24743406);
			AgentMeta._AgentMetas_[2436498804] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// FirstAgent
			meta = new AgentMeta(136495355);
			AgentMeta._AgentMetas_[1778122110] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { FirstAgent.LogMessage(param0); }));
			meta.RegisterMethod(1505908390, new CAgentMethodVoid(delegate(Agent self) { ((FirstAgent)self).SayHello(); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<FirstAgent>("FirstAgent");
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<FirstAgent>("FirstAgent");
			return true;
		}
	}
}