using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.MVEL {
	/// <summary>
	/// Factory to create {@link MVELRule} instances.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class MVELRuleFactory {
		private static MVELRuleDefinitionReader reader = new MVELRuleDefinitionReader();

		/// <summary>
		/// Create a new {@link MVELRule} from a Reader.
		/// </summary>
		/// <param name="ruleDescriptor">as a Reader</param>
		/// <returns>a new rule</returns>
		public static Rule CreateRuleFrom(ref java.io.Reader ruleDescriptor) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a set of {@link MVELRule} from a Reader.
		/// </summary>
		/// <param name="rulesDescriptor">as a Reader</param>
		/// <returns>a set of rules</returns>
		public static Rules CreateRulesFrom(ref java.io.Reader rulesDescriptor) {
			throw new System.Exception("Not implemented");
		}


	}

}
