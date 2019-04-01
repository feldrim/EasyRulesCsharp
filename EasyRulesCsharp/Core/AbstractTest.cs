using System;
namespace org.jeasy.rules.core {
	public abstract class AbstractTest {
		protected Object fact1;
		protected Object fact2;
		protected org.jeasy.rules.api.Rule rule1;
		protected org.jeasy.rules.api.Rule rule2;
		protected org.jeasy.rules.api.Facts facts;
		protected org.jeasy.rules.api.Rules rules;
		protected DefaultRulesEngine rulesEngine;

		public void Setup() {
			throw new System.Exception("Not implemented");
		}


	}

}
