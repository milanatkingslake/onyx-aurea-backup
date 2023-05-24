using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CrossOriginSupport;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.CrossOriginSupport
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxPreflightContext" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxPreflightContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxPreflightContext" />)
        /// </summary>
        public OnyxPreflightContextTest() : base(typeof(OnyxPreflightContext))
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

        #region General Initializer : Class (OnyxPreflightContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxPreflightContextInstanceType;
        private OnyxPreflightContext _onyxPreflightContextInstance;
        private OnyxPreflightContext _onyxPreflightContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxPreflightContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxPreflightContextInstanceType = typeof(OnyxPreflightContext);
            _onyxPreflightContextInstanceFixture = this.Create<OnyxPreflightContext>(false);
            _onyxPreflightContextInstance = _onyxPreflightContextInstanceFixture ?? this.Create<OnyxPreflightContext>(true);
            CurrentInstance = _onyxPreflightContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxPreflightContext) Initializer

        #region Properties

        private const string PropertyRequestedHeaders = "RequestedHeaders";

        #endregion

        #region Methods

        private const string MethodAttach = "Attach";
        private const string MethodDetach = "Detach";

        #endregion

        #region Fields

        private const string Field_requestedHeaders = "_requestedHeaders";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxPreflightContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxPreflightContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxPreflightContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxPreflightContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxPreflightContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxPreflightContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxPreflightContext)

        #region General Initializer : Class (OnyxPreflightContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAttach, 0)]
        [TestCase(MethodDetach, 0)]
        public void AUT_OnyxPreflightContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxPreflightContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRequestedHeaders)]
        [Category("AUT Property")]
        public void AUT_OnyxPreflightContext_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxPreflightContext) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_requestedHeaders)]
        [Category("AUT Fields")]
        public void AUT_OnyxPreflightContext_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxPreflightContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxPreflightContext_Is_Instance_Present_Test()
        {
            // Assert
            _onyxPreflightContextInstanceType.ShouldNotBeNull();
            _onyxPreflightContextInstance.ShouldNotBeNull();
            _onyxPreflightContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxPreflightContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxPreflightContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxPreflightContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxPreflightContextInstance.ShouldBeAssignableTo<OnyxPreflightContext>();
            _onyxPreflightContextInstanceFixture.ShouldBeAssignableTo<OnyxPreflightContext>();
            CurrentInstance.ShouldBeAssignableTo<OnyxPreflightContext>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxPreflightContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxPreflightContext_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var requestedHeaders = this.CreateType<string>();
            OnyxPreflightContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxPreflightContext(requestedHeaders);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxPreflightContextInstance.ShouldNotBeNull();
            _onyxPreflightContextInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxPreflightContext>();
        }

        #endregion

        #region General Constructor : Class (OnyxPreflightContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxPreflightContext_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var requestedHeaders = this.CreateType<string>();
            OnyxPreflightContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxPreflightContext(requestedHeaders);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxPreflightContextInstance.ShouldNotBeNull();
            _onyxPreflightContextInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxPreflightContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRequestedHeaders)]
        public void AUT_OnyxPreflightContext_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxPreflightContext) => Property (RequestedHeaders) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxPreflightContext_Public_Class_RequestedHeaders_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestedHeaders);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestedHeaders);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (Attach) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var owner = this.CreateType<OperationContext>();

            // Act
            Action executeAction = () => _onyxPreflightContextInstance.Attach(owner);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (Attach) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var owner = this.CreateType<OperationContext>();
            var methodAttachParametersTypes = new Type[] { typeof(OperationContext) };
            object[] parametersOfAttach = { owner };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAttach, methodAttachParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxPreflightContextInstanceFixture, parametersOfAttach);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAttach.ShouldNotBeNull();
            parametersOfAttach.Length.ShouldBe(1);
            methodAttachParametersTypes.Length.ShouldBe(1);
            methodAttachParametersTypes.Length.ShouldBe(parametersOfAttach.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Attach) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var owner = this.CreateType<OperationContext>();
            var methodAttachParametersTypes = new Type[] { typeof(OperationContext) };
            object[] parametersOfAttach = { owner };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAttach, parametersOfAttach, methodAttachParametersTypes);

            // Assert
            parametersOfAttach.ShouldNotBeNull();
            parametersOfAttach.Length.ShouldBe(1);
            methodAttachParametersTypes.Length.ShouldBe(1);
            methodAttachParametersTypes.Length.ShouldBe(parametersOfAttach.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Attach) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var currentMethodInfo = this.GetMethodInfo(MethodAttach, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Attach) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var methodAttachParametersTypes = new Type[] { typeof(OperationContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAttach, methodAttachParametersTypes);

            // Assert
            methodAttachParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Attach) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Attach_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAttach);
            var currentMethodInfo = this.GetMethodInfo(MethodAttach, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxPreflightContext_Detach_Method_Call_Internally(Type[] types)
        {
            var methodDetachParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDetach, methodDetachParametersTypes);
        }

        #endregion
        
        #region Method Call : (Detach) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var owner = this.CreateType<OperationContext>();

            // Act
            Action executeAction = () => _onyxPreflightContextInstance.Detach(owner);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var owner = this.CreateType<OperationContext>();
            var methodDetachParametersTypes = new Type[] { typeof(OperationContext) };
            object[] parametersOfDetach = { owner };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDetach, methodDetachParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxPreflightContextInstanceFixture, parametersOfDetach);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDetach.ShouldNotBeNull();
            parametersOfDetach.Length.ShouldBe(1);
            methodDetachParametersTypes.Length.ShouldBe(1);
            methodDetachParametersTypes.Length.ShouldBe(parametersOfDetach.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var owner = this.CreateType<OperationContext>();
            var methodDetachParametersTypes = new Type[] { typeof(OperationContext) };
            object[] parametersOfDetach = { owner };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDetach, parametersOfDetach, methodDetachParametersTypes);

            // Assert
            parametersOfDetach.ShouldNotBeNull();
            parametersOfDetach.Length.ShouldBe(1);
            methodDetachParametersTypes.Length.ShouldBe(1);
            methodDetachParametersTypes.Length.ShouldBe(parametersOfDetach.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var currentMethodInfo = this.GetMethodInfo(MethodDetach, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var methodDetachParametersTypes = new Type[] { typeof(OperationContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDetach, methodDetachParametersTypes);

            // Assert
            methodDetachParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Detach) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxPreflightContext_Detach_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDetach);
            var currentMethodInfo = this.GetMethodInfo(MethodDetach, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}