using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.MVEL {
	class MVELRuleDefinition {
		public String Name { get; set; }
		public String Description { get; set; }
		public int Priority { get; set; }
		public String Condition { get; set; }
		public java.util.List<String> Actions { get; set; }
		private String compositeRuleType;
		private java.util.List<String> allowedCompositeRuleTypes = new ArrayList<>(
            Arrays.asList(UnitRuleGroup.class.getSimpleName(), ConditionalRuleGroup.class.getSimpleName(), ActivationRuleGroup.class.getSimpleName())
    );
		private Rules composingRules;

		void SetComposingRules(ref java.util.List<MVELRuleDefinition> composingRuleDefinitions) {
			throw new System.Exception("Not implemented");
		}
		void SetCompositeRuleType(ref String compositeRuleType) {
			this.compositeRuleType = compositeRuleType;
		}
		String GetCompositeRuleType() {
			return this.compositeRuleType;
		}
		Rules GetComposingRules() {
			return this.composingRules;
		}
		Rule Create() {
			throw new System.Exception("Not implemented");
		}
		private Rule CreateSimpleRule() {
			throw new System.Exception("Not implemented");
		}
		private Rule CreateCompositeRule() {
			throw new System.Exception("Not implemented");
		}
		private bool IsCompositeRule() {
			throw new System.Exception("Not implemented");
		}


	}

}
