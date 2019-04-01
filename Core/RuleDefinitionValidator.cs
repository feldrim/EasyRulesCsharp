using System;
namespace EasyRulesCsharp.Core {
	/// <summary>
	/// This component validates that an annotated rule object is well defined.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	class RuleDefinitionValidator {
		void ValidateRuleDefinition(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private void CheckRuleClass(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private void CheckConditionMethod(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private void CheckActionMethods(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private void CheckPriorityMethod(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private bool IsRuleClassWellDefined(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private bool IsConditionMethodWellDefined(ref java.lang.reflect.Method method) {
			throw new System.Exception("Not implemented");
		}
		private bool ValidParameters(ref java.lang.reflect.Method method) {
			throw new System.Exception("Not implemented");
		}
		private bool IsActionMethodWellDefined(ref java.lang.reflect.Method method) {
			throw new System.Exception("Not implemented");
		}
		private bool IsPriorityMethodWellDefined(ref java.lang.reflect.Method method) {
			throw new System.Exception("Not implemented");
		}
		private java.util.List<java.lang.reflect.Method> GetMethodsAnnotatedWith(ref Class<java.lang.annotation.Annotation> annotation, ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		private java.lang.reflect.Method[] GetMethods(ref Object rule) {
			throw new System.Exception("Not implemented");
		}


	}

}
