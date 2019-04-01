using System;
namespace org.jeasy.rules.core {
	sealed class Utils {
		private Utils() {
			throw new System.Exception("Not implemented");
		}
		static A FindAnnotation<A>(ref Class<A> targetAnnotation, ref Class<void> annotatedType)
			where A : java.lang.annotation.Annotation {
			throw new System.Exception("Not implemented");
		}
		static bool IsAnnotationPresent(ref Class<java.lang.annotation.Annotation> targetAnnotation, ref Class<void> annotatedType) {
			throw new System.Exception("Not implemented");
		}

	}

}
