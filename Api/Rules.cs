using System;
namespace EasyRulesCsharp.Api {
	/// <summary>
	/// This class encapsulates a set of rules and represents a rules namespace.
	/// Rules must have a unique name within a rules namespace.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class Rules {
		private Rule[] rules = new TreeSet<>();

		/// <summary>
		/// Create a new {@link Rules} object.
		/// </summary>
		/// <param name="rules">to register</param>
		public Rules(ref Set<Rule> rules) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link Rules} object.
		/// </summary>
		/// <param name="rules">to register</param>
		public Rules(ref Rule rules) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link Rules} object.
		/// </summary>
		/// <param name="rules">to register</param>
		public Rules(ref Object rules) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Register a new rule.
		/// </summary>
		/// <param name="rule">to register</param>
		public void Register(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Unregister a rule.
		/// </summary>
		/// <param name="rule">to unregister</param>
		public void Unregister(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Unregister a rule by name.
		/// </summary>
		/// <param name="ruleName">the name of the rule to unregister</param>
		public void Unregister(ref String ruleName) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Check if the rule set is empty.
		/// </summary>
		/// <returns>true if the rule set is empty, false otherwise</returns>
		public bool IsEmpty() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Clear rules.
		/// </summary>
		public void Clear() {
			throw new System.Exception("Not implemented");
		}
		public Iterator<Rule> Iterator() {
			throw new System.Exception("Not implemented");
		}
		private Rule FindRuleByName(ref String ruleName) {
			throw new System.Exception("Not implemented");
		}



	}

}
