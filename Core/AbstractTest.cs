using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Core {
	public abstract class AbstractTest {
		protected Object fact1;
		protected Object fact2;
		protected Rule rule1;
		protected Rule rule2;
		protected Facts facts;
		protected Rules rules;
		protected DefaultRulesEngine rulesEngine;

		public void Setup() {
			throw new System.Exception("Not implemented");
		}


	}

}
