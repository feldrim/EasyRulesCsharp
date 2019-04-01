using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Core {
	/// <summary>
	/// Main class to create rule proxies from annotated objects.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class RuleProxy {
		private Object target;
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(RuleProxy.class);
		private static RuleDefinitionValidator ruleDefinitionValidator = new RuleDefinitionValidator();

		private RuleProxy(ref Object target) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Makes the rule object implement the {@link Rule} interface.
		/// </summary>
		/// <param name="rule">the annotated rule object.</param>
		/// <returns>a proxy that implements the {@link Rule} interface.</returns>
		public static Rule AsRule(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		public Object Invoke(ref Object proxy, ref java.lang.reflect.Method method, ref Object[] args) {
			throw new System.Exception("Not implemented");
		}
		private Object EvaluateMethod(ref Object[] args) {
			throw new System.Exception("Not implemented");
		}
		private Object ExecuteMethod(ref Object[] args) {
			throw new System.Exception("Not implemented");
		}
		private Object CompareToMethod(ref Object[] args) {
			throw new System.Exception("Not implemented");
		}
		private List<Object> GetActualParameters(ref java.lang.reflect.Method method, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private bool EqualsMethod(ref Object[] args) {
			throw new System.Exception("Not implemented");
		}
		private int HashCodeMethod() {
			throw new System.Exception("Not implemented");
		}
		private String ToStringMethod() {
			throw new System.Exception("Not implemented");
		}
		private int CompareTo(ref Rule otherRule) {
			throw new System.Exception("Not implemented");
		}
		private int GetRulePriority() {
			throw new System.Exception("Not implemented");
		}
		private java.lang.reflect.Method GetConditionMethod() {
			throw new System.Exception("Not implemented");
		}
		private Set<ActionMethodOrderBean> GetActionMethodBeans() {
			throw new System.Exception("Not implemented");
		}
		private java.lang.reflect.Method GetCompareToMethod() {
			throw new System.Exception("Not implemented");
		}
		private java.lang.reflect.Method[] GetMethods() {
			throw new System.Exception("Not implemented");
		}
		private Annotation.Rule GetRuleAnnotation() {
			throw new System.Exception("Not implemented");
		}
		private String GetRuleName() {
			throw new System.Exception("Not implemented");
		}
		private String GetRuleDescription() {
			throw new System.Exception("Not implemented");
		}
		private void AppendConditionMethodName(ref StringBuilder description) {
			throw new System.Exception("Not implemented");
		}
		private void AppendActionMethodsNames(ref StringBuilder description) {
			throw new System.Exception("Not implemented");
		}
		private Class<void> GetTargetClass() {
			throw new System.Exception("Not implemented");
		}


	}

}
