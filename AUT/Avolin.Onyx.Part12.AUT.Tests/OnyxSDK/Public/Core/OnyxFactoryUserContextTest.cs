using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Core;
using OnyxSDK.Public.Interface;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Core.OnyxFactoryUserContext" />)
    ///     and namespace <see cref="OnyxSDK.Public.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxFactoryUserContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxFactoryUserContext" />)
        /// </summary>
        public OnyxFactoryUserContextTest() : base(typeof(OnyxFactoryUserContext))
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

        #region General Initializer : Class (OnyxFactoryUserContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxFactoryUserContextInstanceType;
        private OnyxFactoryUserContext _onyxFactoryUserContextInstance;
        private OnyxFactoryUserContext _onyxFactoryUserContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxFactoryUserContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxFactoryUserContextInstanceType = typeof(OnyxFactoryUserContext);
            _onyxFactoryUserContextInstanceFixture = this.Create<OnyxFactoryUserContext>(false);
            _onyxFactoryUserContextInstance = _onyxFactoryUserContextInstanceFixture ?? this.Create<OnyxFactoryUserContext>(true);
            CurrentInstance = _onyxFactoryUserContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxFactoryUserContext) Initializer

        #region Properties

        private const string PropertyOnyxContext = "OnyxContext";

        #endregion

        #region Methods

        private const string MethodContext = "Context";

        #endregion

        #region Fields

        private const string Field_onyxContext = "_onyxContext";
        private const string Field_onyxContextLock = "_onyxContextLock";
        private const string Field_onyxSessionLock = "_onyxSessionLock";
        private const string Field_cacheContext = "_cacheContext";
        private const string Field_onyxContextCache = "_onyxContextCache";
        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxFactoryUserContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFactoryUserContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxFactoryUserContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFactoryUserContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxFactoryUserContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxFactoryUserContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxFactoryUserContext)

        #region General Initializer : Class (OnyxFactoryUserContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodContext, 0)]
        [TestCase(MethodContext, 1)]
        [TestCase(MethodContext, 2)]
        public void AUT_OnyxFactoryUserContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxFactoryUserContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxContext)]
        [Category("AUT Property")]
        public void AUT_OnyxFactoryUserContext_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxFactoryUserContext) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_onyxContext)]
        [TestCase(Field_onyxContextLock)]
        [TestCase(Field_onyxSessionLock)]
        [TestCase(Field_cacheContext)]
        [TestCase(Field_onyxContextCache)]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxFactoryUserContext_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxFactoryUserContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxFactoryUserContext_Is_Instance_Present_Test()
        {
            // Assert
            _onyxFactoryUserContextInstanceType.ShouldNotBeNull();
            _onyxFactoryUserContextInstance.ShouldNotBeNull();
            _onyxFactoryUserContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxFactoryUserContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxFactoryUserContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxFactoryUserContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxFactoryUserContextInstance.ShouldBeAssignableTo<OnyxFactoryUserContext>();
            _onyxFactoryUserContextInstanceFixture.ShouldBeAssignableTo<OnyxFactoryUserContext>();
            CurrentInstance.ShouldBeAssignableTo<OnyxFactoryUserContext>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxFactoryUserContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxContext)]
        public void AUT_OnyxFactoryUserContext_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxFactoryUserContext) => Property (OnyxContext) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFactoryUserContext_OnyxContext_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxContext);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxContext);
            Action currentAction = () => propertyInfo.SetValue(_onyxFactoryUserContextInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxFactoryUserContext) => Property (OnyxContext) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxFactoryUserContext_Public_Class_OnyxContext_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxContext);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxContext);

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

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxFactoryUserContextInstance.Context(userId, password, applicationName, siteId, source);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var returnedValue = default(IOnyxUserContext);

            // Act
            Action executeAction = () => returnedValue = _onyxFactoryUserContextInstance.Context(userId, password, applicationName, siteId, source);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfContext = { userId, password, applicationName, siteId, source };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContext, methodContextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IOnyxUserContext>(_onyxFactoryUserContextInstanceFixture, parametersOfContext);
            var result2 = this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(5);
            methodContextParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfContext = { userId, password, applicationName, siteId, source };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(5);
            methodContextParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodContextParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxFactoryUserContext_Context_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodContextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxFactoryUserContextInstance.Context(applicationName, siteId, source);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var returnedValue = default(IOnyxUserContext);

            // Act
            Action executeAction = () => returnedValue = _onyxFactoryUserContextInstance.Context(applicationName, siteId, source);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfContext = { applicationName, siteId, source };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContext, methodContextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IOnyxUserContext>(_onyxFactoryUserContextInstanceFixture, parametersOfContext);
            var result2 = this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(3);
            methodContextParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfContext = { applicationName, siteId, source };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(3);
            methodContextParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodContextParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxFactoryUserContext_Context_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodContextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxFactoryUserContextInstance.Context(sessionId, applicationName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var returnedValue = default(IOnyxUserContext);

            // Act
            Action executeAction = () => returnedValue = _onyxFactoryUserContextInstance.Context(sessionId, applicationName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfContext = { sessionId, applicationName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContext, methodContextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IOnyxUserContext>(_onyxFactoryUserContextInstanceFixture, parametersOfContext);
            var result2 = this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(2);
            methodContextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var sessionId = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfContext = { sessionId, applicationName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IOnyxUserContext>(MethodContext, parametersOfContext, methodContextParametersTypes);

            // Assert
            parametersOfContext.ShouldNotBeNull();
            parametersOfContext.Length.ShouldBe(2);
            methodContextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodContextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var methodContextParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContext, methodContextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Context) (Return Type : IOnyxUserContext) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxFactoryUserContext_Context_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContext);
            var currentMethodInfo = this.GetMethodInfo(MethodContext, 2);
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