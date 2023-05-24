using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.Common" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodInitialize = "Initialize";
        private const string MethodInit = "Init";
        private const string MethodInitReferenceCaches = "InitReferenceCaches";
        private const string MethodGetDescriptionFromParameterId = "GetDescriptionFromParameterId";
        private const string MethodGetCurrentDirectory = "GetCurrentDirectory";
        private const string MethodGetOnyxAppDirectory = "GetOnyxAppDirectory";
        private const string MethodXmlEscape = "XmlEscape";

        #endregion

        #region Fields

        private const string FieldconfigDom = "configDom";
        private const string FieldappLogHelper = "appLogHelper";
        private const string FieldconfigLock = "configLock";
        private const string FieldrefCacheLock = "refCacheLock";
        private const string FieldrefParamCache = "refParamCache";
        private const string FieldrefMapCache = "refMapCache";
        private const string FieldregionCodeCache = "regionCodeCache";
        private const string FieldcountryCodeCache = "countryCodeCache";
        private const string FieldONYX_360_FOLDERNAME = "ONYX_360_FOLDERNAME";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitialize, 0)]
        [TestCase(MethodInit, 0)]
        [TestCase(MethodInitReferenceCaches, 0)]
        [TestCase(MethodGetDescriptionFromParameterId, 0)]
        [TestCase(MethodGetCurrentDirectory, 0)]
        [TestCase(MethodGetOnyxAppDirectory, 0)]
        [TestCase(MethodXmlEscape, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Common) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldconfigDom)]
        [TestCase(FieldappLogHelper)]
        [TestCase(FieldconfigLock)]
        [TestCase(FieldrefCacheLock)]
        [TestCase(FieldrefParamCache)]
        [TestCase(FieldrefMapCache)]
        [TestCase(FieldregionCodeCache)]
        [TestCase(FieldcountryCodeCache)]
        [TestCase(FieldONYX_360_FOLDERNAME)]
        [Category("AUT Fields")]
        public void AUT_Common_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Initialize) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var configFileName = this.CreateType<string>();
            var onyxSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => Common.Initialize(configFileName, onyxSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var configFileName = this.CreateType<string>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodInitializeParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfInitialize = { configFileName, onyxSession };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitialize, methodInitializeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitialize);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitialize.ShouldNotBeNull();
            parametersOfInitialize.Length.ShouldBe(2);
            methodInitializeParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var configFileName = this.CreateType<string>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodInitializeParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfInitialize = { configFileName, onyxSession };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitialize, parametersOfInitialize, methodInitializeParametersTypes);

            // Assert
            parametersOfInitialize.ShouldNotBeNull();
            parametersOfInitialize.Length.ShouldBe(2);
            methodInitializeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var currentMethodInfo = this.GetMethodInfo(MethodInitialize, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var methodInitializeParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitialize, methodInitializeParametersTypes);

            // Assert
            methodInitializeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Initialize) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Initialize_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitialize);
            var currentMethodInfo = this.GetMethodInfo(MethodInitialize, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_Init_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInit, methodInitParametersTypes);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var configFileName = this.CreateType<string>();
            var appName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.Init(configFileName, appName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var configFileName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var methodInitParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfInit = { configFileName, appName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInit, methodInitParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInit);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInit.ShouldNotBeNull();
            parametersOfInit.Length.ShouldBe(2);
            methodInitParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var configFileName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var methodInitParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfInit = { configFileName, appName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInit, parametersOfInit, methodInitParametersTypes);

            // Assert
            parametersOfInit.ShouldNotBeNull();
            parametersOfInit.Length.ShouldBe(2);
            methodInitParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var currentMethodInfo = this.GetMethodInfo(MethodInit, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var methodInitParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInit, methodInitParametersTypes);

            // Assert
            methodInitParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Init) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_Init_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInit);
            var currentMethodInfo = this.GetMethodInfo(MethodInit, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_InitReferenceCaches_Static_Method_Call_Internally(Type[] types)
        {
            var methodInitReferenceCachesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInitReferenceCaches, methodInitReferenceCachesParametersTypes);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var onyxSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => Common.InitReferenceCaches(onyxSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var onyxSession = this.CreateType<OnyxSession>();
            var methodInitReferenceCachesParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfInitReferenceCaches = { onyxSession };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitReferenceCaches, methodInitReferenceCachesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfInitReferenceCaches);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitReferenceCaches.ShouldNotBeNull();
            parametersOfInitReferenceCaches.Length.ShouldBe(1);
            methodInitReferenceCachesParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var onyxSession = this.CreateType<OnyxSession>();
            var methodInitReferenceCachesParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfInitReferenceCaches = { onyxSession };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitReferenceCaches, parametersOfInitReferenceCaches, methodInitReferenceCachesParametersTypes);

            // Assert
            parametersOfInitReferenceCaches.ShouldNotBeNull();
            parametersOfInitReferenceCaches.Length.ShouldBe(1);
            methodInitReferenceCachesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var currentMethodInfo = this.GetMethodInfo(MethodInitReferenceCaches, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var methodInitReferenceCachesParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitReferenceCaches, methodInitReferenceCachesParametersTypes);

            // Assert
            methodInitReferenceCachesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitReferenceCaches) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_InitReferenceCaches_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitReferenceCaches);
            var currentMethodInfo = this.GetMethodInfo(MethodInitReferenceCaches, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetDescriptionFromParameterIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => Common.GetDescriptionFromParameterId(id, oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Common.GetDescriptionFromParameterId(id, oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfGetDescriptionFromParameterId = { id, oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodGetDescriptionFromParameterId, parametersOfGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDescriptionFromParameterId);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDescriptionFromParameterId.ShouldNotBeNull();
            parametersOfGetDescriptionFromParameterId.Length.ShouldBe(2);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var id = this.CreateType<string>();
            var oSession = this.CreateType<OnyxSession>();
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            object[] parametersOfGetDescriptionFromParameterId = { id, oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetDescriptionFromParameterId, parametersOfGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            parametersOfGetDescriptionFromParameterId.ShouldNotBeNull();
            parametersOfGetDescriptionFromParameterId.Length.ShouldBe(2);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var methodGetDescriptionFromParameterIdParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDescriptionFromParameterId, methodGetDescriptionFromParameterIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDescriptionFromParameterIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDescriptionFromParameterId) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetDescriptionFromParameterId_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDescriptionFromParameterId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDescriptionFromParameterId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetCurrentDirectory_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentDirectoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);

            // Act
            Action executeAction = () => Common.GetCurrentDirectory();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Common.GetCurrentDirectory();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            Type [] methodGetCurrentDirectoryParametersTypes = null;
            object[] parametersOfGetCurrentDirectory = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodGetCurrentDirectory, parametersOfGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCurrentDirectory.ShouldBeNull();
            methodGetCurrentDirectoryParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodGetCurrentDirectory, parametersOfGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes));
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            Type [] methodGetCurrentDirectoryParametersTypes = null;
            object[] parametersOfGetCurrentDirectory = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetCurrentDirectory);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCurrentDirectory.ShouldBeNull();
            methodGetCurrentDirectoryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            Type [] methodGetCurrentDirectoryParametersTypes = null;
            object[] parametersOfGetCurrentDirectory = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetCurrentDirectory, parametersOfGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);

            // Assert
            parametersOfGetCurrentDirectory.ShouldBeNull();
            methodGetCurrentDirectoryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            Type [] methodGetCurrentDirectoryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCurrentDirectoryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            Type [] methodGetCurrentDirectoryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentDirectory, methodGetCurrentDirectoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentDirectoryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentDirectory) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetCurrentDirectory_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentDirectory);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentDirectory, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxAppDirectoryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var appName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetOnyxAppDirectory(appName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var appName = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Common.GetOnyxAppDirectory(appName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var appName = this.CreateType<string>();
            var methodGetOnyxAppDirectoryParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetOnyxAppDirectory = { appName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodGetOnyxAppDirectory, parametersOfGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOnyxAppDirectory);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOnyxAppDirectory.ShouldNotBeNull();
            parametersOfGetOnyxAppDirectory.Length.ShouldBe(1);
            methodGetOnyxAppDirectoryParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var appName = this.CreateType<string>();
            var methodGetOnyxAppDirectoryParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetOnyxAppDirectory = { appName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetOnyxAppDirectory, parametersOfGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);

            // Assert
            parametersOfGetOnyxAppDirectory.ShouldNotBeNull();
            parametersOfGetOnyxAppDirectory.Length.ShouldBe(1);
            methodGetOnyxAppDirectoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var methodGetOnyxAppDirectoryParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOnyxAppDirectoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var methodGetOnyxAppDirectoryParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxAppDirectory, methodGetOnyxAppDirectoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxAppDirectoryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAppDirectory, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxAppDirectory) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetOnyxAppDirectory_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAppDirectory);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAppDirectory, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_XmlEscape_Static_Method_Call_Internally(Type[] types)
        {
            var methodXmlEscapeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.XmlEscape(s);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = Common.XmlEscape(s);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, methodXmlEscapeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);
            var result2 = this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes));
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, methodXmlEscapeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfXmlEscape);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var s = this.CreateType<string>();
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfXmlEscape = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodXmlEscape, parametersOfXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            parametersOfXmlEscape.ShouldNotBeNull();
            parametersOfXmlEscape.Length.ShouldBe(1);
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodXmlEscapeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var methodXmlEscapeParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodXmlEscape, methodXmlEscapeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodXmlEscapeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (XmlEscape) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_XmlEscape_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodXmlEscape);
            var currentMethodInfo = this.GetMethodInfo(MethodXmlEscape, 0);
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