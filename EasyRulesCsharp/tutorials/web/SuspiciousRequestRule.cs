using System;
namespace org.jeasy.rules.tutorials.web {
	public class SuspiciousRequestRule {
		const String SUSPICIOUS = "suspicious";

		public bool IsSuspicious(ref javax.servlet.http.HttpServletRequest request) {
			throw new System.Exception("Not implemented");
		}
		public void SetSuspicious(ref javax.servlet.http.HttpServletRequest request) {
			throw new System.Exception("Not implemented");
		}

	}

}
