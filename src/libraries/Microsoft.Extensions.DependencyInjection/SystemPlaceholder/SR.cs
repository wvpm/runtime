using System.Linq;

namespace System;

public static class SR {
	public const string
	AmbiguousConstructorException = "AmbiguousConstructorException",
	AotCannotCreateEnumerableValueType = "AotCannotCreateEnumerableValueType",
	AotCannotCreateGenericValueType = "AotCannotCreateGenericValueType",
	ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation = "ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation",
	AsyncDisposableServiceDispose = "AsyncDisposableServiceDispose",
	CallSiteTypeNotSupported = "CallSiteTypeNotSupported",
	CannotCreateAbstractClasses = "CannotCreateAbstractClasses",
	CannotResolveService = "CannotResolveService",
	CircularDependencyException = "CircularDependencyException",
	ConstantCantBeConvertedToServiceType = "ConstantCantBeConvertedToServiceType",
	CtorNotLocated = "CtorNotLocated",
	DirectScopedResolvedFromRootException = "DirectScopedResolvedFromRootException",
	GetCaptureDisposableNotSupported = "GetCaptureDisposableNotSupported",
	ImplementationTypeCantBeConvertedToServiceType = "ImplementationTypeCantBeConvertedToServiceType",
	InvalidServiceDescriptor = "InvalidServiceDescriptor",
	InvalidServiceKeyType = "InvalidServiceKeyType",
	KeyedDescriptorMisuse = "KeyedDescriptorMisuse",
	KeyedServicesNotSupported = "KeyedServicesNotSupported",
	MarkedCtorMissingArgumentTypes = "MarkedCtorMissingArgumentTypes",
	MultipleCtorsFound = "MultipleCtorsFound",
	MultipleCtorsFoundWithBestLength = "MultipleCtorsFoundWithBestLength",
	MultipleCtorsMarkedWithAttribute = "MultipleCtorsMarkedWithAttribute",
	NoConstructorMatch = "NoConstructorMatch",
	NonKeyedDescriptorMisuse = "NonKeyedDescriptorMisuse",
	NoServiceRegistered = "NoServiceRegistered",
	OpenGenericServiceRequiresOpenGenericImplementation = "OpenGenericServiceRequiresOpenGenericImplementation",
	ScopedInSingletonException = "ScopedInSingletonException",
	ScopedResolvedFromRootException = "ScopedResolvedFromRootException",
	ServiceCollectionReadOnly = "ServiceCollectionReadOnly",
	ServiceDescriptorNotExist = "ServiceDescriptorNotExist",
	TrimmingAnnotationsDoNotMatch = "TrimmingAnnotationsDoNotMatch",
	TrimmingAnnotationsDoNotMatch_NewConstraint = "TrimmingAnnotationsDoNotMatch_NewConstraint",
	TryAddIndistinguishableTypeToEnumerable = "TryAddIndistinguishableTypeToEnumerable",
	TypeCannotBeActivated = "TypeCannotBeActivated",
	UnableToActivateTypeException = "UnableToActivateTypeException",
	UnableToResolveService = "UnableToResolveService";

	public static string Format(string id, params object?[] parameters) {
		return id + parameters.Select(x => " " + x?.ToString() ?? "[NULL]");
	}
}