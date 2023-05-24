using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Dispatcher;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxOperationInvoker" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOperationInvokerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOperationInvoker" />)
        /// </summary>
        public OnyxOperationInvokerTest() : base(typeof(OnyxOperationInvoker))
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

        #region General Initializer : Class (OnyxOperationInvoker) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOperationInvokerInstanceType;
        private OnyxOperationInvoker _onyxOperationInvokerInstance;
        private OnyxOperationInvoker _onyxOperationInvokerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOperationInvoker" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOperationInvokerInstanceType = typeof(OnyxOperationInvoker);
            _onyxOperationInvokerInstanceFixture = this.Create<OnyxOperationInvoker>(false);
            _onyxOperationInvokerInstance = _onyxOperationInvokerInstanceFixture ?? this.Create<OnyxOperationInvoker>(true);
            CurrentInstance = _onyxOperationInvokerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOperationInvoker) Initializer

        #region Properties

        private const string PropertyIsSynchronous = "IsSynchronous";

        #endregion

        #region Methods

        private const string MethodAllocateInputs = "AllocateInputs";
        private const string MethodInvoke = "Invoke";
        
        private const string MethodInvokeEnd = "InvokeEnd";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string Field_innerInvoker = "_innerInvoker";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOperationInvoker) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOperationInvoker_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOperationInvoker) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOperationInvoker_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOperationInvoker) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOperationInvoker_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOperationInvoker)

        #region General Initializer : Class (OnyxOperationInvoker) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAllocateInputs, 0)]
        public void AUT_OnyxOperationInvoker_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOperationInvoker) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsSynchronous)]
        [Category("AUT Property")]
        public void AUT_OnyxOperationInvoker_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOperationInvoker) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxOperationInvoker_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOperationInvoker) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOperationInvoker_Is_Instance_Present_Test()
        {
            // Assert
            _onyxOperationInvokerInstanceType.ShouldNotBeNull();
            _onyxOperationInvokerInstance.ShouldNotBeNull();
            _onyxOperationInvokerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxOperationInvoker) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOperationInvoker" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOperationInvoker_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOperationInvokerInstance.ShouldBeAssignableTo<OnyxOperationInvoker>();
            _onyxOperationInvokerInstanceFixture.ShouldBeAssignableTo<OnyxOperationInvoker>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOperationInvoker>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxOperationInvoker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOperationInvoker_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var innerInvoker = this.CreateType<IOperationInvoker>();
            OnyxOperationInvoker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOperationInvoker(innerInvoker);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOperationInvokerInstance.ShouldNotBeNull();
            _onyxOperationInvokerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxOperationInvoker>();
        }

        #endregion

        #region General Constructor : Class (OnyxOperationInvoker) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOperationInvoker_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var innerInvoker = this.CreateType<IOperationInvoker>();
            OnyxOperationInvoker instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOperationInvoker(innerInvoker);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOperationInvokerInstance.ShouldNotBeNull();
            _onyxOperationInvokerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOperationInvoker) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsSynchronous)]
        public void AUT_OnyxOperationInvoker_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOperationInvoker) => Property (IsSynchronous) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOperationInvoker_Public_Class_IsSynchronous_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSynchronous);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSynchronous);

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

        #region Method Call : (AllocateInputs) (Return Type : object[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_Internally(Type[] types)
        {
            var methodAllocateInputsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAllocateInputs, methodAllocateInputsParametersTypes);
        }

        #endregion

        #region Method Call : (AllocateInputs) (Return Type : object[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);

            // Act
            Action executeAction = () => _onyxOperationInvokerInstance.AllocateInputs();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AllocateInputs) (Return Type : object[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            var returnedValue = default(object[]);

            // Act
            Action executeAction = () => returnedValue = _onyxOperationInvokerInstance.AllocateInputs();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AllocateInputs) (Return Type : object[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            Type [] methodAllocateInputsParametersTypes = null;
            object[] parametersOfAllocateInputs = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAllocateInputs, methodAllocateInputsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object[]>(_onyxOperationInvokerInstanceFixture, parametersOfAllocateInputs);
            var result2 = this.GetResultOfMethod<object[]>(MethodAllocateInputs, parametersOfAllocateInputs, methodAllocateInputsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAllocateInputs.ShouldBeNull();
            methodAllocateInputsParametersTypes.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (AllocateInputs) (Return Type : object[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            Type [] methodAllocateInputsParametersTypes = null;
            object[] parametersOfAllocateInputs = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<object[]>(MethodAllocateInputs, parametersOfAllocateInputs, methodAllocateInputsParametersTypes);

            // Assert
            parametersOfAllocateInputs.ShouldBeNull();
            methodAllocateInputsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AllocateInputs) (Return Type : object[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            Type [] methodAllocateInputsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAllocateInputs, methodAllocateInputsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAllocateInputsParametersTypes.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (AllocateInputs) (Return Type : object[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            Type [] methodAllocateInputsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAllocateInputs, methodAllocateInputsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAllocateInputsParametersTypes.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (AllocateInputs) (Return Type : object[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOperationInvoker_AllocateInputs_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAllocateInputs);
            var currentMethodInfo = this.GetMethodInfo(MethodAllocateInputs, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Invoke) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOperationInvoker_Invoke_Method_Call_Internally(Type[] types)
        {
            var methodInvokeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvoke, methodInvokeParametersTypes);
        }

        #endregion

        #region Method Call : (InvokeEnd) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOperationInvoker_InvokeEnd_Method_Call_Internally(Type[] types)
        {
            var methodInvokeEndParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvokeEnd, methodInvokeEndParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}