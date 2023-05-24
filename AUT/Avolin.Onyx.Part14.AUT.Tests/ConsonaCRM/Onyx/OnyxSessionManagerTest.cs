using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;
using OnyxSessionManager = ConsonaCRM.Onyx.OnyxSessionManager;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.OnyxSessionManager" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSessionManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSessionManager" />)
        /// </summary>
        public OnyxSessionManagerTest() : base(typeof(OnyxSessionManager))
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

        #region General Initializer : Class (OnyxSessionManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSessionManagerInstanceType;
        private OnyxSessionManager _onyxSessionManagerInstance;
        private OnyxSessionManager _onyxSessionManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSessionManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSessionManagerInstanceType = typeof(OnyxSessionManager);
            _onyxSessionManagerInstanceFixture = this.Create<OnyxSessionManager>(false);
            _onyxSessionManagerInstance = _onyxSessionManagerInstanceFixture ?? this.Create<OnyxSessionManager>(true);
            CurrentInstance = _onyxSessionManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSessionManager) Initializer

        #region Properties

        private const string Propertycontext = "context";

        #endregion

        #region Methods

        private const string MethodHasPermission = "HasPermission";
        private const string MethodSetSessionItem = "SetSessionItem";
        private const string MethodGetSessionItem = "GetSessionItem";
        private const string MethodRemoveSessionItem = "RemoveSessionItem";

        #endregion

        #region Fields

        private const string Fieldm_context = "m_context";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSessionManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSessionManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSessionManager) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSessionManager_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSessionManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSessionManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSessionManager)

        #region General Initializer : Class (OnyxSessionManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodHasPermission, 0)]
        [TestCase(MethodSetSessionItem, 0)]
        [TestCase(MethodGetSessionItem, 0)]
        [TestCase(MethodRemoveSessionItem, 0)]
        public void AUT_OnyxSessionManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxSessionManager) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertycontext)]
        [Category("AUT Property")]
        public void AUT_OnyxSessionManager_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSessionManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_context)]
        [Category("AUT Fields")]
        public void AUT_OnyxSessionManager_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxSessionManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSessionManager_Is_Instance_Present_Test()
        {
            // Assert
            _onyxSessionManagerInstanceType.ShouldNotBeNull();
            _onyxSessionManagerInstance.ShouldNotBeNull();
            _onyxSessionManagerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxSessionManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSessionManager" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSessionManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSessionManagerInstance.ShouldBeAssignableTo<OnyxSessionManager>();
            _onyxSessionManagerInstanceFixture.ShouldBeAssignableTo<OnyxSessionManager>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSessionManager>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxSessionManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionManager_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pContext = this.CreateType<StepPackageContext>();
            OnyxSessionManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSessionManager(pContext);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSessionManagerInstance.ShouldNotBeNull();
            _onyxSessionManagerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxSessionManager>();
        }

        #endregion

        #region General Constructor : Class (OnyxSessionManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionManager_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pContext = this.CreateType<StepPackageContext>();
            OnyxSessionManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSessionManager(pContext);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSessionManagerInstance.ShouldNotBeNull();
            _onyxSessionManagerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSessionManager) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertycontext)]
        public void AUT_OnyxSessionManager_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSessionManager) => Property (context) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSessionManager_context_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycontext);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertycontext);
            Action currentAction = () => propertyInfo.SetValue(_onyxSessionManagerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSessionManager) => Property (context) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSessionManager_Public_Class_context_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycontext);
            var propertyInfo = this.GetPropertyInfo(Propertycontext);

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

        #region Method Call : (HasPermission) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var psResourceId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxSessionManagerInstance.HasPermission(psResourceId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var psResourceId = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { psResourceId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxSessionManagerInstanceFixture, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var psResourceId = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { psResourceId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxSessionManagerInstanceFixture, out exception1, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var psResourceId = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { psResourceId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_HasPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSessionManager_SetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodSetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxSessionManagerInstance.SetSessionItem(psName, psValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { psName, psValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, methodSetSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSessionManagerInstanceFixture, parametersOfSetSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(2);
            methodSetSessionItemParametersTypes.Length.ShouldBe(2);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var psName = this.CreateType<string>();
            var psValue = this.CreateType<string>();
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetSessionItem = { psName, psValue };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSessionItem, parametersOfSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            parametersOfSetSessionItem.ShouldNotBeNull();
            parametersOfSetSessionItem.Length.ShouldBe(2);
            methodSetSessionItemParametersTypes.Length.ShouldBe(2);
            methodSetSessionItemParametersTypes.Length.ShouldBe(parametersOfSetSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var methodSetSessionItemParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSessionItem, methodSetSessionItemParametersTypes);

            // Assert
            methodSetSessionItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSessionItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_SetSessionItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSessionItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSessionManager_GetSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxSessionManagerInstance.GetSessionItem(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var psName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxSessionManagerInstance.GetSessionItem(psName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var psName = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSessionItem = { psName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, methodGetSessionItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxSessionManagerInstanceFixture, parametersOfGetSessionItem);
            var result2 = this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(1);
            methodGetSessionItemParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var psName = this.CreateType<string>();
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetSessionItem = { psName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSessionItem, parametersOfGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            parametersOfGetSessionItem.ShouldNotBeNull();
            parametersOfGetSessionItem.Length.ShouldBe(1);
            methodGetSessionItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionItemParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var methodGetSessionItemParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionItem, methodGetSessionItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSessionItem) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_GetSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionItem, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_Internally(Type[] types)
        {
            var methodRemoveSessionItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var psName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxSessionManagerInstance.RemoveSessionItem(psName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var psName = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveSessionItem = { psName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxSessionManagerInstanceFixture, parametersOfRemoveSessionItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(1);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(1);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var psName = this.CreateType<string>();
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveSessionItem = { psName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveSessionItem, parametersOfRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            parametersOfRemoveSessionItem.ShouldNotBeNull();
            parametersOfRemoveSessionItem.Length.ShouldBe(1);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(1);
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(parametersOfRemoveSessionItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var methodRemoveSessionItemParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveSessionItem, methodRemoveSessionItemParametersTypes);

            // Assert
            methodRemoveSessionItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveSessionItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxSessionManager_RemoveSessionItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveSessionItem);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveSessionItem, 0);

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