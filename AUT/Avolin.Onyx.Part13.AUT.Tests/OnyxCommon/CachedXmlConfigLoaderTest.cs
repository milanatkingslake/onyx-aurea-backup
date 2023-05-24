using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.CachedXmlConfigLoader" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CachedXmlConfigLoaderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CachedXmlConfigLoader" />)
        /// </summary>
        public CachedXmlConfigLoaderTest() : base(typeof(CachedXmlConfigLoader))
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

        #region General Initializer : Class (CachedXmlConfigLoader) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cachedXmlConfigLoaderInstanceType;
        private CachedXmlConfigLoader _cachedXmlConfigLoaderInstance;
        private CachedXmlConfigLoader _cachedXmlConfigLoaderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CachedXmlConfigLoader" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cachedXmlConfigLoaderInstanceType = typeof(CachedXmlConfigLoader);
            _cachedXmlConfigLoaderInstanceFixture = this.Create<CachedXmlConfigLoader>(false);
            _cachedXmlConfigLoaderInstance = _cachedXmlConfigLoaderInstanceFixture ?? this.Create<CachedXmlConfigLoader>(true);
            CurrentInstance = _cachedXmlConfigLoaderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CachedXmlConfigLoader) Initializer

        #region Methods

        private const string MethodLoadFromFile = "LoadFromFile";

        #endregion

        #region Fields

        private const string FieldconfigLock = "configLock";
        private const string FieldconfigDoms = "configDoms";
        private const string FieldloadCfgDomDates = "loadCfgDomDates";

        #endregion

        #endregion

        #region General Initializer : Class (CachedXmlConfigLoader) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CachedXmlConfigLoader_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CachedXmlConfigLoader) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CachedXmlConfigLoader_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CachedXmlConfigLoader)

        #region General Initializer : Class (CachedXmlConfigLoader) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadFromFile, 0)]
        public void AUT_CachedXmlConfigLoader_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CachedXmlConfigLoader) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldconfigLock)]
        [TestCase(FieldconfigDoms)]
        [TestCase(FieldloadCfgDomDates)]
        [Category("AUT Fields")]
        public void AUT_CachedXmlConfigLoader_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CachedXmlConfigLoader) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CachedXmlConfigLoader_Is_Instance_Present_Test()
        {
            // Assert
            _cachedXmlConfigLoaderInstanceType.ShouldNotBeNull();
            _cachedXmlConfigLoaderInstance.ShouldNotBeNull();
            _cachedXmlConfigLoaderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CachedXmlConfigLoader) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CachedXmlConfigLoader" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CachedXmlConfigLoader_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cachedXmlConfigLoaderInstance.ShouldBeAssignableTo<CachedXmlConfigLoader>();
            _cachedXmlConfigLoaderInstanceFixture.ShouldBeAssignableTo<CachedXmlConfigLoader>();
            CurrentInstance.ShouldBeAssignableTo<CachedXmlConfigLoader>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CachedXmlConfigLoader) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CachedXmlConfigLoader_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CachedXmlConfigLoader instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LoadFromFile) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var alias = this.CreateType<string>();
            var fullFilePath = this.CreateType<string>();
            var forceReLoad = this.CreateType<bool>();

            // Act
            Action executeAction = () => _cachedXmlConfigLoaderInstance.LoadFromFile(alias, fullFilePath, forceReLoad);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var alias = this.CreateType<string>();
            var fullFilePath = this.CreateType<string>();
            var forceReLoad = this.CreateType<bool>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _cachedXmlConfigLoaderInstance.LoadFromFile(alias, fullFilePath, forceReLoad);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var alias = this.CreateType<string>();
            var fullFilePath = this.CreateType<string>();
            var forceReLoad = this.CreateType<bool>();
            var methodLoadFromFileParametersTypes = new Type[] { typeof(String), typeof(String), typeof(bool) };
            object[] parametersOfLoadFromFile = { alias, fullFilePath, forceReLoad };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadFromFile, methodLoadFromFileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_cachedXmlConfigLoaderInstanceFixture, parametersOfLoadFromFile);
            var result2 = this.GetResultOfMethod<XElement>(MethodLoadFromFile, parametersOfLoadFromFile, methodLoadFromFileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfLoadFromFile.ShouldNotBeNull();
            parametersOfLoadFromFile.Length.ShouldBe(3);
            methodLoadFromFileParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var alias = this.CreateType<string>();
            var fullFilePath = this.CreateType<string>();
            var forceReLoad = this.CreateType<bool>();
            var methodLoadFromFileParametersTypes = new Type[] { typeof(String), typeof(String), typeof(bool) };
            object[] parametersOfLoadFromFile = { alias, fullFilePath, forceReLoad };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodLoadFromFile, parametersOfLoadFromFile, methodLoadFromFileParametersTypes);

            // Assert
            parametersOfLoadFromFile.ShouldNotBeNull();
            parametersOfLoadFromFile.Length.ShouldBe(3);
            methodLoadFromFileParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var methodLoadFromFileParametersTypes = new Type[] { typeof(String), typeof(String), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLoadFromFile, methodLoadFromFileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodLoadFromFileParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var methodLoadFromFileParametersTypes = new Type[] { typeof(String), typeof(String), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadFromFile, methodLoadFromFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLoadFromFileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadFromFile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LoadFromFile) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CachedXmlConfigLoader_LoadFromFile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadFromFile);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadFromFile, 0);
            const int parametersCount = 3;

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