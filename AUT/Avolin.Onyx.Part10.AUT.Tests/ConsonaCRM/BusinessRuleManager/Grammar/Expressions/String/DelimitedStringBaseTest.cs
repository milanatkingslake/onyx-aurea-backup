using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.DelimitedStringBase" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DelimitedStringBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DelimitedStringBase" />)
        /// </summary>
        public DelimitedStringBaseTest() : base(typeof(DelimitedStringBase))
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

        #region General Initializer : Class (DelimitedStringBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _delimitedStringBaseInstanceType;
        private DelimitedStringBase _delimitedStringBaseInstance;
        private DelimitedStringBase _delimitedStringBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DelimitedStringBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _delimitedStringBaseInstanceType = typeof(DelimitedStringBase);
            _delimitedStringBaseInstanceFixture = this.Create<DelimitedStringBase>(false);
            _delimitedStringBaseInstance = _delimitedStringBaseInstanceFixture ?? this.Create<DelimitedStringBase>(true);
            CurrentInstance = _delimitedStringBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DelimitedStringBase) Initializer

        #region Methods

        private const string MethodGetCacheKey = "GetCacheKey";
        private const string MethodGetCachedInfo = "GetCachedInfo";

        #endregion

        #endregion

        #region General Initializer : Class (DelimitedStringBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DelimitedStringBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DelimitedStringBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DelimitedStringBase)

        #region General Initializer : Class (DelimitedStringBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DelimitedStringBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCacheKey, 0)]
        [TestCase(MethodGetCachedInfo, 0)]
        public void AUT_DelimitedStringBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DelimitedStringBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DelimitedStringBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DelimitedStringBase_Is_Instance_Present_Test()
        {
            // Assert
            _delimitedStringBaseInstanceType.ShouldNotBeNull();
            _delimitedStringBaseInstance.ShouldNotBeNull();
            _delimitedStringBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DelimitedStringBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DelimitedStringBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DelimitedStringBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _delimitedStringBaseInstance.ShouldBeAssignableTo<DelimitedStringBase>();
            _delimitedStringBaseInstanceFixture.ShouldBeAssignableTo<DelimitedStringBase>();
            CurrentInstance.ShouldBeAssignableTo<DelimitedStringBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DelimitedStringBase) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DelimitedStringBase_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DelimitedStringBase instance = null;

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
        public void AUT_DelimitedStringBase_GetCacheKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            Type [] methodGetCacheKeyParametersTypes = null;
            object[] parametersOfGetCacheKey = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_delimitedStringBaseInstanceFixture, parametersOfGetCacheKey);
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
        public void AUT_DelimitedStringBase_GetCacheKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_DelimitedStringBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_DelimitedStringBase_GetCacheKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_DelimitedStringBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetCachedInfo) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;
            object[] parametersOfGetCachedInfo = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedInfo, methodGetCachedInfoParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_delimitedStringBaseInstanceFixture, parametersOfGetCachedInfo);
            var result2 = this.GetResultOfMethod<string>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedInfo.ShouldBeNull();
            methodGetCachedInfoParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            Type [] methodGetCachedInfoParametersTypes = null;
            object[] parametersOfGetCachedInfo = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            parametersOfGetCachedInfo.ShouldBeNull();
            methodGetCachedInfoParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (GetCachedInfo) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetCachedInfo) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DelimitedStringBase_GetCachedInfo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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