using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File.TextFileReadBase" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TextFileReadBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TextFileReadBase" />)
        /// </summary>
        public TextFileReadBaseTest() : base(typeof(TextFileReadBase))
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

        #region General Initializer : Class (TextFileReadBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _textFileReadBaseInstanceType;
        private TextFileReadBase _textFileReadBaseInstance;
        private TextFileReadBase _textFileReadBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TextFileReadBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _textFileReadBaseInstanceType = typeof(TextFileReadBase);
            _textFileReadBaseInstanceFixture = this.Create<TextFileReadBase>(false);
            _textFileReadBaseInstance = _textFileReadBaseInstanceFixture ?? this.Create<TextFileReadBase>(true);
            CurrentInstance = _textFileReadBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TextFileReadBase) Initializer

        #region Methods

        private const string MethodGetCacheKey = "GetCacheKey";
        private const string MethodGetCachedInfo = "GetCachedInfo";

        #endregion

        #endregion

        #region General Initializer : Class (TextFileReadBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TextFileReadBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TextFileReadBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TextFileReadBase)

        #region General Initializer : Class (TextFileReadBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TextFileReadBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCacheKey, 0)]
        [TestCase(MethodGetCachedInfo, 0)]
        public void AUT_TextFileReadBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (TextFileReadBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TextFileReadBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadBase_Is_Instance_Present_Test()
        {
            // Assert
            _textFileReadBaseInstanceType.ShouldNotBeNull();
            _textFileReadBaseInstance.ShouldNotBeNull();
            _textFileReadBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TextFileReadBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TextFileReadBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _textFileReadBaseInstance.ShouldBeAssignableTo<TextFileReadBase>();
            _textFileReadBaseInstanceFixture.ShouldBeAssignableTo<TextFileReadBase>();
            CurrentInstance.ShouldBeAssignableTo<TextFileReadBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TextFileReadBase) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TextFileReadBase_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TextFileReadBase instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCacheKey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCacheKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            Type [] methodGetCacheKeyParametersTypes = null;
            object[] parametersOfGetCacheKey = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_textFileReadBaseInstanceFixture, parametersOfGetCacheKey);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCacheKey.ShouldBeNull();
            methodGetCacheKeyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCacheKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            Type [] methodGetCacheKeyParametersTypes = null;
            object[] parametersOfGetCacheKey = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            parametersOfGetCacheKey.ShouldBeNull();
            methodGetCacheKeyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            Type [] methodGetCacheKeyParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCacheKeyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCacheKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            Type [] methodGetCacheKeyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheKeyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TextFileReadBase_GetCachedInfo_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCachedInfo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;
            object[] parametersOfGetCachedInfo = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedInfo, methodGetCachedInfoParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<TextReader>(_textFileReadBaseInstanceFixture, parametersOfGetCachedInfo);
            var result2 = this.GetResultOfMethod<TextReader>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedInfo.ShouldBeNull();
            methodGetCachedInfoParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCachedInfo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;
            object[] parametersOfGetCachedInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<TextReader>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            parametersOfGetCachedInfo.ShouldBeNull();
            methodGetCachedInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedInfoParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedInfoParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : TextReader) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedInfo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}