using System.Linq;

namespace System;

public static class SR {
	public const string
	AmbiguousConstructorException = "Unable to activate type '{0}'. The following constructors are ambiguous:",
	AotCannotCreateEnumerableValueType = "AotCannotCreateEnumerableValueType",
	AotCannotCreateGenericValueType = "AotCannotCreateGenericValueType",
	ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation = "Arity of open generic service type '{0}' does not equal arity of open generic implementation type '{1}'.",
	AsyncDisposableServiceDispose = "'{0}' type only implements IAsyncDisposable. Use DisposeAsync to dispose the container.",
	CallSiteTypeNotSupported = "CallSiteTypeNotSupported",
	CannotCreateAbstractClasses = "Instances of abstract classes cannot be created.",
	CannotResolveService = "Unable to resolve service for type '{0}' while attempting to activate '{1}'.",
	CircularDependencyException = "A circular dependency was detected for the service of type '{0}'.",
	ConstantCantBeConvertedToServiceType = "Constant value of type '{0}' can't be converted to service type '{1}'",
	CtorNotLocated = "A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and all parameters of a public constructor are either registered as services or passed as arguments. Also ensure no extraneous arguments are provided.",
	DirectScopedResolvedFromRootException = "Cannot resolve scoped service '{0}' from root provider.",
	GetCaptureDisposableNotSupported = "GetCaptureDisposableNotSupported",
	ImplementationTypeCantBeConvertedToServiceType = "Implementation type '{0}' can't be converted to service type '{1}'",
	InvalidServiceDescriptor = "InvalidServiceDescriptor",
	InvalidServiceKeyType = "InvalidServiceKeyType",
	KeyedDescriptorMisuse = "KeyedDescriptorMisuse",
	KeyedServicesNotSupported = "KeyedServicesNotSupported",
	MarkedCtorMissingArgumentTypes = "Constructor marked with {0} does not accept all given argument types.",
	MultipleCtorsFound = "Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.",
	MultipleCtorsFoundWithBestLength = "Multiple constructors for type '{0}' were found with length 1.",
	MultipleCtorsMarkedWithAttribute = "Multiple constructors were marked with {0}.",
	NoConstructorMatch = "A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.",
	NonKeyedDescriptorMisuse = "NonKeyedDescriptorMisuse",
	NoServiceRegistered = "No service for type '{0}' has been registered.",
	OpenGenericServiceRequiresOpenGenericImplementation = "Open generic service type '{0}' requires registering an open generic implementation type.",
	ScopedInSingletonException = "Cannot consume scoped service '{0}' from singleton '{1}'.",
	ScopedResolvedFromRootException = "Cannot resolve '{0}' from root provider because it requires scoped service '{1}'.",
	ServiceCollectionReadOnly = "ServiceCollectionReadOnly",
	ServiceDescriptorNotExist = "ServiceDescriptorNotExist",
	TrimmingAnnotationsDoNotMatch = "TrimmingAnnotationsDoNotMatch",
	TrimmingAnnotationsDoNotMatch_NewConstraint = "TrimmingAnnotationsDoNotMatch_NewConstraint",
	TryAddIndistinguishableTypeToEnumerable = "Implementation type cannot be '{0}' because it is indistinguishable from other services registered for '{1}'.",
	TypeCannotBeActivated = "Cannot instantiate implementation type '{0}' for service type '{1}'.",
	UnableToActivateTypeException = "No constructor for type '{0}' can be instantiated using services from the service container and default values.",
	UnableToResolveService = "Unable to resolve service for type '{0}' while attempting to activate '{1}'.";

	public static string Format(string id, params object?[] parameters) {
		return id.Contains("{0}") ? string.Format(id, parameters) :
			id + string.Join(string.Empty, parameters.Select(x => " " + x?.ToString() ?? "[NULL]"));
	}
}