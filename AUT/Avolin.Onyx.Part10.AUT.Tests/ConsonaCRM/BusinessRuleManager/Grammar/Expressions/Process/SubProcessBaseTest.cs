using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.SubProcessBase" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SubProcessBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubProcessBase" />)
        /// </summary>
        public SubProcessBaseTest() : base(typeof(SubProcessBase))
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

        #region General Initializer : Class (SubProcessBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subProcessBaseInstanceType;
        private SubProcessBase _subProcessBaseInstance;
        private SubProcessBase _subProcessBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubProcessBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subProcessBaseInstanceType = typeof(SubProcessBase);
            _subProcessBaseInstanceFixture = this.Create<SubProcessBase>(false);
            _subProcessBaseInstance = _subProcessBaseInstanceFixture ?? this.Create<SubProcessBase>(true);
            CurrentInstance = _subProcessBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubProcessBase) Initializer

        #region Methods

        private const string MethodGetCacheKey = "GetCacheKey";
        private const string MethodGetCachedInfo = "GetCachedInfo";
        private const string MethodSetCachedInfo = "SetCachedInfo";
        private const string MethodRemoveCachedInfo = "RemoveCachedInfo";

        #endregion

        #endregion

        #region General Initializer : Class (SubProcessBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubProcessBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubProcessBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubProcessBase)

        #region General Initializer : Class (SubProcessBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SubProcessBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCacheKey, 0)]
        [TestCase(MethodGetCachedInfo, 0)]
        [TestCase(MethodSetCachedInfo, 0)]
        [TestCase(MethodRemoveCachedInfo, 0)]
        public void AUT_SubProcessBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SubProcessBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SubProcessBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubProcessBase_Is_Instance_Present_Test()
        {
            // Assert
            _subProcessBaseInstanceType.ShouldNotBeNull();
            _subProcessBaseInstance.ShouldNotBeNull();
            _subProcessBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SubProcessBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubProcessBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubProcessBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subProcessBaseInstance.ShouldBeAssignableTo<SubProcessBase>();
            _subProcessBaseInstanceFixture.ShouldBeAssignableTo<SubProcessBase>();
            CurrentInstance.ShouldBeAssignableTo<SubProcessBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubProcessBase) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubProcessBase_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SubProcessBase instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCacheKey) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var pBaseGrammar = this.CreateType<GrammarBase>();

            // Act
            Action executeAction = () => SubProcessBase.GetCacheKey(pBaseGrammar);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = SubProcessBase.GetCacheKey(pBaseGrammar);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfGetCacheKey = { pBaseGrammar };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_subProcessBaseInstanceFixture, parametersOfGetCacheKey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfGetCacheKey = { pBaseGrammar };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(GrammarBase) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(GrammarBase) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetCacheKey) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCacheKey_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();

            // Act
            Action executeAction = () => SubProcessBase.GetCachedInfo(pBaseGrammar);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var returnedValue = default(Dictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = SubProcessBase.GetCachedInfo(pBaseGrammar);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodGetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfGetCachedInfo = { pBaseGrammar };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedInfo, methodGetCachedInfoParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);
            var result2 = this.GetResultOfMethod<Dictionary<string, string>>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_subProcessBaseInstanceFixture, parametersOfGetCachedInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedInfo.ShouldNotBeNull();
            parametersOfGetCachedInfo.Length.ShouldBe(1);
            methodGetCachedInfoParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodGetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfGetCachedInfo = { pBaseGrammar };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Dictionary<string, string>>(MethodGetCachedInfo, parametersOfGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            parametersOfGetCachedInfo.ShouldNotBeNull();
            parametersOfGetCachedInfo.Length.ShouldBe(1);
            methodGetCachedInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var methodGetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedInfoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var methodGetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedInfo, methodGetCachedInfoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedInfoParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetCachedInfo) (Return Type : Dictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_GetCachedInfo_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedInfo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetCachedInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetCachedInfo, methodSetCachedInfoParametersTypes);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var pCacheItem = this.CreateType<Dictionary<string, string>>();

            // Act
            Action executeAction = () => SubProcessBase.SetCachedInfo(pBaseGrammar, pCacheItem);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var pCacheItem = this.CreateType<Dictionary<string, string>>();
            var methodSetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase), typeof(Dictionary<string, string>) };
            object[] parametersOfSetCachedInfo = { pBaseGrammar, pCacheItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetCachedInfo, methodSetCachedInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_subProcessBaseInstanceFixture, parametersOfSetCachedInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetCachedInfo.ShouldNotBeNull();
            parametersOfSetCachedInfo.Length.ShouldBe(2);
            methodSetCachedInfoParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var pCacheItem = this.CreateType<Dictionary<string, string>>();
            var methodSetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase), typeof(Dictionary<string, string>) };
            object[] parametersOfSetCachedInfo = { pBaseGrammar, pCacheItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetCachedInfo, parametersOfSetCachedInfo, methodSetCachedInfoParametersTypes);

            // Assert
            parametersOfSetCachedInfo.ShouldNotBeNull();
            parametersOfSetCachedInfo.Length.ShouldBe(2);
            methodSetCachedInfoParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodSetCachedInfo, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var methodSetCachedInfoParametersTypes = new Type[] { typeof(GrammarBase), typeof(Dictionary<string, string>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetCachedInfo, methodSetCachedInfoParametersTypes);

            // Assert
            methodSetCachedInfoParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCachedInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_SetCachedInfo_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodSetCachedInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_Internally(Type[] types)
        {
            var methodRemoveCachedInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveCachedInfo, methodRemoveCachedInfoParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();

            // Act
            Action executeAction = () => SubProcessBase.RemoveCachedInfo(pBaseGrammar);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodRemoveCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfRemoveCachedInfo = { pBaseGrammar };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveCachedInfo, methodRemoveCachedInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_subProcessBaseInstanceFixture, parametersOfRemoveCachedInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveCachedInfo.ShouldNotBeNull();
            parametersOfRemoveCachedInfo.Length.ShouldBe(1);
            methodRemoveCachedInfoParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var pBaseGrammar = this.CreateType<GrammarBase>();
            var methodRemoveCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };
            object[] parametersOfRemoveCachedInfo = { pBaseGrammar };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveCachedInfo, parametersOfRemoveCachedInfo, methodRemoveCachedInfoParametersTypes);

            // Assert
            parametersOfRemoveCachedInfo.ShouldNotBeNull();
            parametersOfRemoveCachedInfo.Length.ShouldBe(1);
            methodRemoveCachedInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveCachedInfo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var methodRemoveCachedInfoParametersTypes = new Type[] { typeof(GrammarBase) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveCachedInfo, methodRemoveCachedInfoParametersTypes);

            // Assert
            methodRemoveCachedInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveCachedInfo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubProcessBase_RemoveCachedInfo_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveCachedInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveCachedInfo, 0);

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