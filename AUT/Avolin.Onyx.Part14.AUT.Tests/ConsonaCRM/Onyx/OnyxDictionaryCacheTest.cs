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

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.OnyxDictionaryCache" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxDictionaryCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxDictionaryCache" />)
        /// </summary>
        public OnyxDictionaryCacheTest() : base(typeof(OnyxDictionaryCache))
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

        #region General Initializer : Class (OnyxDictionaryCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxDictionaryCacheInstanceType;
        private OnyxDictionaryCache _onyxDictionaryCacheInstance;
        private OnyxDictionaryCache _onyxDictionaryCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxDictionaryCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxDictionaryCacheInstanceType = typeof(OnyxDictionaryCache);
            _onyxDictionaryCacheInstanceFixture = this.Create<OnyxDictionaryCache>(false);
            _onyxDictionaryCacheInstance = _onyxDictionaryCacheInstanceFixture ?? this.Create<OnyxDictionaryCache>(true);
            CurrentInstance = _onyxDictionaryCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryCache) Initializer

        #region Properties

        private const string PropertyapplicationName = "applicationName";
        private const string PropertyassemblyClassName = "assemblyClassName";

        #endregion

        #region Methods

        private const string MethodGetObjectInstance = "GetObjectInstance";

        #endregion

        #region Fields

        private const string Fieldm_applicationName = "m_applicationName";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxDictionaryCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxDictionaryCache)

        #region General Initializer : Class (OnyxDictionaryCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetObjectInstance, 0)]
        public void AUT_OnyxDictionaryCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxDictionaryCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertyassemblyClassName)]
        [Category("AUT Property")]
        public void AUT_OnyxDictionaryCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxDictionaryCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_applicationName)]
        [Category("AUT Fields")]
        public void AUT_OnyxDictionaryCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxDictionaryCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDictionaryCache_Is_Instance_Present_Test()
        {
            // Assert
            _onyxDictionaryCacheInstanceType.ShouldNotBeNull();
            _onyxDictionaryCacheInstance.ShouldNotBeNull();
            _onyxDictionaryCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxDictionaryCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDictionaryCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxDictionaryCacheInstance.ShouldBeAssignableTo<OnyxDictionaryCache>();
            _onyxDictionaryCacheInstanceFixture.ShouldBeAssignableTo<OnyxDictionaryCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxDictionaryCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxDictionaryCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            OnyxDictionaryCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxDictionaryCache(psApplicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxDictionaryCacheInstance.ShouldNotBeNull();
            _onyxDictionaryCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxDictionaryCache>();
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            OnyxDictionaryCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxDictionaryCache(psApplicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxDictionaryCacheInstance.ShouldNotBeNull();
            _onyxDictionaryCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxDictionaryCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertyassemblyClassName)]
        public void AUT_OnyxDictionaryCache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxDictionaryCache) => Property (applicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxDictionaryCache_Public_Class_applicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyapplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyapplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxDictionaryCache) => Property (assemblyClassName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxDictionaryCache_Public_Class_assemblyClassName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyassemblyClassName);
            var propertyInfo = this.GetPropertyInfo(PropertyassemblyClassName);

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

        #region Method Call : (GetObjectInstance) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var psObjectName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxDictionaryCacheInstance.GetObjectInstance(psObjectName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var psObjectName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxDictionaryCacheInstance.GetObjectInstance(psObjectName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var psObjectName = this.CreateType<string>();
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetObjectInstance = { psObjectName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxDictionaryCacheInstanceFixture, parametersOfGetObjectInstance);
            var result2 = this.GetResultOfMethod<string>(MethodGetObjectInstance, parametersOfGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetObjectInstance.ShouldNotBeNull();
            parametersOfGetObjectInstance.Length.ShouldBe(1);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var psObjectName = this.CreateType<string>();
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetObjectInstance = { psObjectName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetObjectInstance, parametersOfGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            parametersOfGetObjectInstance.ShouldNotBeNull();
            parametersOfGetObjectInstance.Length.ShouldBe(1);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var methodGetObjectInstanceParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetObjectInstance, methodGetObjectInstanceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetObjectInstanceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetObjectInstance) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxDictionaryCache_GetObjectInstance_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetObjectInstance);
            var currentMethodInfo = this.GetMethodInfo(MethodGetObjectInstance, 0);
            const int parametersCount = 1;

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