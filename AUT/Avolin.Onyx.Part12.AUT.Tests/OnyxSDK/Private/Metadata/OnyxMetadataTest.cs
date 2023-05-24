using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using OnyxSDK.Public.Interface;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.OnyxMetadata" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxMetadataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxMetadata" />)
        /// </summary>
        public OnyxMetadataTest() : base(typeof(OnyxMetadata))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxMetadata) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxMetadataInstanceType;
        private OnyxMetadata _onyxMetadataInstance;
        private OnyxMetadata _onyxMetadataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxMetadata" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxMetadataInstanceType = typeof(OnyxMetadata);
            _onyxMetadataInstanceFixture = this.Create<OnyxMetadata>(false);
            _onyxMetadataInstance = _onyxMetadataInstanceFixture ?? this.Create<OnyxMetadata>(true);
            CurrentInstance = _onyxMetadataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxMetadata) Initializer

        #region Methods

        private const string MethodLoadCompleteMetadata = "LoadCompleteMetadata";
        private const string MethodGetLboObject = "GetLboObject";
        private const string MethodGetLboMethod = "GetLboMethod";

        #endregion

        #region Fields

        private const string FieldonyxUserContext = "onyxUserContext";
        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxMetadata) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMetadata_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxMetadata) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMetadata_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxMetadata)

        #region General Initializer : Class (OnyxMetadata) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadCompleteMetadata, 0)]
        [TestCase(MethodGetLboObject, 0)]
        [TestCase(MethodGetLboMethod, 0)]
        public void AUT_OnyxMetadata_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxMetadata) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldonyxUserContext)]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxMetadata_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxMetadata) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMetadata_Is_Instance_Present_Test()
        {
            // Assert
            _onyxMetadataInstanceType.ShouldNotBeNull();
            _onyxMetadataInstance.ShouldNotBeNull();
            _onyxMetadataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxMetadata) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxMetadata" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMetadata_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxMetadataInstance.ShouldBeAssignableTo<OnyxMetadata>();
            _onyxMetadataInstanceFixture.ShouldBeAssignableTo<OnyxMetadata>();
            CurrentInstance.ShouldBeAssignableTo<OnyxMetadata>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxMetadata) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxMetadata_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            OnyxMetadata instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxMetadata(onyxUserContext);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxMetadataInstance.ShouldNotBeNull();
            _onyxMetadataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxMetadata>();
        }

        #endregion

        #region General Constructor : Class (OnyxMetadata) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxMetadata_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            OnyxMetadata instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxMetadata(onyxUserContext);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxMetadataInstance.ShouldNotBeNull();
            _onyxMetadataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LoadCompleteMetadata) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_LoadCompleteMetadata_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadCompleteMetadata);

            // Act
            Action executeAction = () => _onyxMetadataInstance.LoadCompleteMetadata();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LoadCompleteMetadata) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_LoadCompleteMetadata_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadCompleteMetadata);
            Type [] methodLoadCompleteMetadataParametersTypes = null;
            object[] parametersOfLoadCompleteMetadata = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadCompleteMetadata, methodLoadCompleteMetadataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxMetadataInstanceFixture, parametersOfLoadCompleteMetadata);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadCompleteMetadata.ShouldBeNull();
            methodLoadCompleteMetadataParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LoadCompleteMetadata) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_LoadCompleteMetadata_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadCompleteMetadata);
            Type [] methodLoadCompleteMetadataParametersTypes = null;
            object[] parametersOfLoadCompleteMetadata = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadCompleteMetadata, parametersOfLoadCompleteMetadata, methodLoadCompleteMetadataParametersTypes);

            // Assert
            parametersOfLoadCompleteMetadata.ShouldBeNull();
            methodLoadCompleteMetadataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadCompleteMetadata) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_LoadCompleteMetadata_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadCompleteMetadata);
            Type [] methodLoadCompleteMetadataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadCompleteMetadata, methodLoadCompleteMetadataParametersTypes);

            // Assert
            methodLoadCompleteMetadataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadCompleteMetadata) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_LoadCompleteMetadata_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadCompleteMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadCompleteMetadata, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxMetadata_GetLboObject_Method_Call_Internally(Type[] types)
        {
            var methodGetLboObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboObject, methodGetLboObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var objectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxMetadataInstance.GetLboObject(objectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var objectName = this.CreateType<string>();
            var returnedValue = default(ILboObject);

            // Act
            Action executeAction = () => returnedValue = _onyxMetadataInstance.GetLboObject(objectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var objectName = this.CreateType<string>();
            var methodGetLboObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboObject = { objectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObject, methodGetLboObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ILboObject>(_onyxMetadataInstanceFixture, parametersOfGetLboObject);
            var result2 = this.GetResultOfMethod<ILboObject>(MethodGetLboObject, parametersOfGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboObject.ShouldNotBeNull();
            parametersOfGetLboObject.Length.ShouldBe(1);
            methodGetLboObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var objectName = this.CreateType<string>();
            var methodGetLboObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLboObject = { objectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ILboObject>(MethodGetLboObject, parametersOfGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            parametersOfGetLboObject.ShouldNotBeNull();
            parametersOfGetLboObject.Length.ShouldBe(1);
            methodGetLboObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var methodGetLboObjectParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var methodGetLboObjectParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboObject_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxMetadata_GetLboMethod_Method_Call_Internally(Type[] types)
        {
            var methodGetLboMethodParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboMethod, methodGetLboMethodParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxMetadataInstance.GetLboMethod(objectName, methodName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var returnedValue = default(ILboMethod);

            // Act
            Action executeAction = () => returnedValue = _onyxMetadataInstance.GetLboMethod(objectName, methodName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var methodGetLboMethodParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetLboMethod = { objectName, methodName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethod, methodGetLboMethodParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ILboMethod>(_onyxMetadataInstanceFixture, parametersOfGetLboMethod);
            var result2 = this.GetResultOfMethod<ILboMethod>(MethodGetLboMethod, parametersOfGetLboMethod, methodGetLboMethodParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMethod.ShouldNotBeNull();
            parametersOfGetLboMethod.Length.ShouldBe(2);
            methodGetLboMethodParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var methodGetLboMethodParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetLboMethod = { objectName, methodName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ILboMethod>(MethodGetLboMethod, parametersOfGetLboMethod, methodGetLboMethodParametersTypes);

            // Assert
            parametersOfGetLboMethod.ShouldNotBeNull();
            parametersOfGetLboMethod.Length.ShouldBe(2);
            methodGetLboMethodParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var methodGetLboMethodParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMethod, methodGetLboMethodParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMethodParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var methodGetLboMethodParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMethod, methodGetLboMethodParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMethodParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethod, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMethod) (Return Type : ILboMethod) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMetadata_GetLboMethod_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMethod);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMethod, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}