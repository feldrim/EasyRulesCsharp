using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	/// <summary>
	/// Basic rule implementation class that provides common methods.
	/// 
	/// You can extend this class and override {@link BasicRule#evaluate(Facts)} and {@link BasicRule#execute(Facts)} to provide rule
	/// conditions and actions logic.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class BasicRule : Rule  {
		public String Name { get; }
		public String Description { get; set; }
		public int Priority { get; set; }
		/// <summary>
		/// Default rule priority.
		/// </summary>
		public int DEFAULT_PRIORITY = Integer.MAX_VALUE - 1;
		/// <summary>
		/// Default rule description.
		/// </summary>
		public String DEFAULT_DESCRIPTION = "description";
		/// <summary>
		/// Default rule name.
		/// </summary>
		public String DEFAULT_NAME = "rule";

		/// <summary>
		/// Create a new {@link BasicRule}.
		/// </summary>
		public BasicRule() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link BasicRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		public BasicRule(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link BasicRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		/// <param name="description">rule description</param>
		public BasicRule(ref String name, ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link BasicRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		/// <param name="description">rule description</param>
		/// <param name="priority">rule priority</param>
		public BasicRule(ref String name, ref String description, ref int priority) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// {@inheritDoc}
		/// </summary>
		public bool Evaluate(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// {@inheritDoc}
		/// </summary>
		public void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Rules are unique according to their names within a rules engine registry.
		/// </summary>
		public bool Equals(ref Object o) {
			throw new System.Exception("Not implemented");
		}
		public int HashCode() {
			throw new System.Exception("Not implemented");
		}
		public String ToString() {
			throw new System.Exception("Not implemented");
		}
		public int CompareTo(ref Rule rule) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Rule actions abstraction : this method encapsulates the rule's actions.
		/// </summary>
		/// <returns>@throws Exception thrown if an exception occurs during actions performing</returns>
		public void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Rule conditions abstraction : this method encapsulates the rule's conditions.
		/// <strong>Implementations should handle any runtime exception and return true/false accordingly</strong>
		/// </summary>
		/// <returns>true if the rule should be applied given the provided facts, false otherwise</returns>
		public bool Evaluate(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}

	}

}
