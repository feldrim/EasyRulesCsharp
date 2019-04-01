using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
using Action = EasyRulesCsharp.EasyRulesCsharp.Api.Action;

namespace EasyRulesCsharp.EasyRulesCsharp.MVEL {
	/// <summary>
	/// This class is an implementation of {@link Action} that uses <a href="https://github.com/mvel/mvel">MVEL</a> to execute the action.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class MVELAction : Action  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(MVELAction.class);
		private String expression;
		private java.io.Serializable compiledExpression;

		/// <summary>
		/// Create a new {@link MVELAction}.
		/// </summary>
		/// <param name="expression">the action written in expression language</param>
		public MVELAction(ref String expression) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link MVELAction}.
		/// </summary>
		/// <param name="expression">the action written in expression language</param>
		/// <param name="parserContext">the MVEL parser context</param>
		public MVELAction(ref String expression, ref org.mvel2.ParserContext parserContext) {
			throw new System.Exception("Not implemented");
		}
		public void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Execute the action when the rule evaluates to true.
		/// </summary>
		/// <param name="facts">known at the time of execution of the action</param>
		/// <returns>@throws Exception when unable to execute the action</returns>
		public void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}

	}

}
