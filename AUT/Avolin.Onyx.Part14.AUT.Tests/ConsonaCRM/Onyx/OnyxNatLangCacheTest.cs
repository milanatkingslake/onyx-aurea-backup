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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.OnyxNatLangCache" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxNatLangCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxNatLangCache" />)
        /// </summary>
        public OnyxNatLangCacheTest() : base(typeof(OnyxNatLangCache))
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

        #region General Initializer : Class (OnyxNatLangCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxNatLangCacheInstanceType;
        private OnyxNatLangCache _onyxNatLangCacheInstance;
        private OnyxNatLangCache _onyxNatLangCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxNatLangCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxNatLangCacheInstanceType = typeof(OnyxNatLangCache);
            _onyxNatLangCacheInstanceFixture = this.Create<OnyxNatLangCache>(false);
            _onyxNatLangCacheInstance = _onyxNatLangCacheInstanceFixture ?? this.Create<OnyxNatLangCache>(true);
            CurrentInstance = _onyxNatLangCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangCache) Initializer

        #region Properties

        private const string PropertyapplicationName = "applicationName";
        private const string PropertysiteID = "siteID";
        private const string PropertypreferredLanguage = "preferredLanguage";

        #endregion

        #region Methods

        private const string MethodRetrieveString = "RetrieveString";
        private const string MethodRetrieveStringList = "RetrieveStringList";

        #endregion

        #region Fields

        private const string Fieldm_applicationName = "m_applicationName";
        private const string Fieldm_siteId = "m_siteId";
        private const string Fieldm_preferredLanguage = "m_preferredLanguage";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxNatLangCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxNatLangCache)

        #region General Initializer : Class (OnyxNatLangCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetrieveString, 0)]
        [TestCase(MethodRetrieveStringList, 0)]
        public void AUT_OnyxNatLangCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxNatLangCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertysiteID)]
        [TestCase(PropertypreferredLanguage)]
        [Category("AUT Property")]
        public void AUT_OnyxNatLangCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxNatLangCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_applicationName)]
        [TestCase(Fieldm_siteId)]
        [TestCase(Fieldm_preferredLanguage)]
        [Category("AUT Fields")]
        public void AUT_OnyxNatLangCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxNatLangCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxNatLangCache_Is_Instance_Present_Test()
        {
            // Assert
            _onyxNatLangCacheInstanceType.ShouldNotBeNull();
            _onyxNatLangCacheInstance.ShouldNotBeNull();
            _onyxNatLangCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxNatLangCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxNatLangCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxNatLangCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxNatLangCacheInstance.ShouldBeAssignableTo<OnyxNatLangCache>();
            _onyxNatLangCacheInstanceFixture.ShouldBeAssignableTo<OnyxNatLangCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxNatLangCache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxNatLangCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangCache_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            var piSiteID = this.CreateType<int>();
            var psPreferredLanguage = this.CreateType<string>();
            OnyxNatLangCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxNatLangCache(psApplicationName, piSiteID, psPreferredLanguage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxNatLangCacheInstance.ShouldNotBeNull();
            _onyxNatLangCacheInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxNatLangCache>();
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangCache) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangCache_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psApplicationName = this.CreateType<string>();
            var piSiteID = this.CreateType<int>();
            var psPreferredLanguage = this.CreateType<string>();
            OnyxNatLangCache instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxNatLangCache(psApplicationName, piSiteID, psPreferredLanguage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxNatLangCacheInstance.ShouldNotBeNull();
            _onyxNatLangCacheInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxNatLangCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyapplicationName)]
        [TestCase(PropertysiteID)]
        [TestCase(PropertypreferredLanguage)]
        public void AUT_OnyxNatLangCache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxNatLangCache) => Property (applicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangCache_Public_Class_applicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxNatLangCache) => Property (preferredLanguage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangCache_Public_Class_preferredLanguage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertypreferredLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertypreferredLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxNatLangCache) => Property (siteID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangCache_Public_Class_siteID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysiteID);
            var propertyInfo = this.GetPropertyInfo(PropertysiteID);

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

        #region Method Call : (RetrieveString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var piMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxNatLangCacheInstance.RetrieveString(piMessageId, psArguments);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var piMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxNatLangCacheInstance.RetrieveString(piMessageId, psArguments);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var piMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();
            var methodRetrieveStringParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfRetrieveString = { piMessageId, psArguments };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveString, methodRetrieveStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxNatLangCacheInstanceFixture, parametersOfRetrieveString);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveString, parametersOfRetrieveString, methodRetrieveStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveString.ShouldNotBeNull();
            parametersOfRetrieveString.Length.ShouldBe(2);
            methodRetrieveStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var piMessageId = this.CreateType<int>();
            var psArguments = this.CreateType<string>();
            var methodRetrieveStringParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfRetrieveString = { piMessageId, psArguments };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveString, parametersOfRetrieveString, methodRetrieveStringParametersTypes);

            // Assert
            parametersOfRetrieveString.ShouldNotBeNull();
            parametersOfRetrieveString.Length.ShouldBe(2);
            methodRetrieveStringParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var methodRetrieveStringParametersTypes = new Type[] { typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveString, methodRetrieveStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveStringParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var methodRetrieveStringParametersTypes = new Type[] { typeof(int), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveString, methodRetrieveStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveString, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveStringListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveStringList, methodRetrieveStringListParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var piStartMessageId = this.CreateType<int>();
            var piEndMessageId = this.CreateType<int>();

            // Act
            Action executeAction = () => _onyxNatLangCacheInstance.RetrieveStringList(piStartMessageId, piEndMessageId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var piStartMessageId = this.CreateType<int>();
            var piEndMessageId = this.CreateType<int>();
            var returnedValue = default(System.Array);

            // Act
            Action executeAction = () => returnedValue = _onyxNatLangCacheInstance.RetrieveStringList(piStartMessageId, piEndMessageId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var piStartMessageId = this.CreateType<int>();
            var piEndMessageId = this.CreateType<int>();
            var methodRetrieveStringListParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfRetrieveStringList = { piStartMessageId, piEndMessageId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveStringList, methodRetrieveStringListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<System.Array>(_onyxNatLangCacheInstanceFixture, parametersOfRetrieveStringList);
            var result2 = this.GetResultOfMethod<System.Array>(MethodRetrieveStringList, parametersOfRetrieveStringList, methodRetrieveStringListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveStringList.ShouldNotBeNull();
            parametersOfRetrieveStringList.Length.ShouldBe(2);
            methodRetrieveStringListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var piStartMessageId = this.CreateType<int>();
            var piEndMessageId = this.CreateType<int>();
            var methodRetrieveStringListParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfRetrieveStringList = { piStartMessageId, piEndMessageId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Array>(MethodRetrieveStringList, parametersOfRetrieveStringList, methodRetrieveStringListParametersTypes);

            // Assert
            parametersOfRetrieveStringList.ShouldNotBeNull();
            parametersOfRetrieveStringList.Length.ShouldBe(2);
            methodRetrieveStringListParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var methodRetrieveStringListParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveStringList, methodRetrieveStringListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveStringListParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var methodRetrieveStringListParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveStringList, methodRetrieveStringListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveStringListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveStringList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveStringList) (Return Type : System.Array) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxNatLangCache_RetrieveStringList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveStringList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveStringList, 0);
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