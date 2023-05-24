using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.DeltaMergeAspComWrapper" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DeltaMergeAspComWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DeltaMergeAspComWrapper" />)
        /// </summary>
        public DeltaMergeAspComWrapperTest() : base(typeof(DeltaMergeAspComWrapper))
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

        #region General Initializer : Class (DeltaMergeAspComWrapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _deltaMergeAspComWrapperInstanceType;
        private DeltaMergeAspComWrapper _deltaMergeAspComWrapperInstance;
        private DeltaMergeAspComWrapper _deltaMergeAspComWrapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DeltaMergeAspComWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _deltaMergeAspComWrapperInstanceType = typeof(DeltaMergeAspComWrapper);
            _deltaMergeAspComWrapperInstanceFixture = this.Create<DeltaMergeAspComWrapper>(false);
            _deltaMergeAspComWrapperInstance = _deltaMergeAspComWrapperInstanceFixture ?? this.Create<DeltaMergeAspComWrapper>(true);
            CurrentInstance = _deltaMergeAspComWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergeAspComWrapper) Initializer

        #region Methods

        private const string MethodGetSafeGuid = "GetSafeGuid";
        private const string MethodAppendActions = "AppendActions";
        private const string MethodDiscardActions = "DiscardActions";
        private const string MethodSaveActions = "SaveActions";
        private const string MethodMerge = "Merge";
        private const string MethodCompileSite = "CompileSite";
        private const string MethodCompilePage = "CompilePage";
        private const string MethodGetProfileIdsFromXml = "GetProfileIdsFromXml";
        private const string MethodBuildReturnXml = "BuildReturnXml";

        #endregion

        #endregion

        #region General Initializer : Class (DeltaMergeAspComWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DeltaMergeAspComWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DeltaMergeAspComWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DeltaMergeAspComWrapper)

        #region General Initializer : Class (DeltaMergeAspComWrapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DeltaMergeAspComWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSafeGuid, 0)]
        [TestCase(MethodAppendActions, 0)]
        [TestCase(MethodDiscardActions, 0)]
        [TestCase(MethodSaveActions, 0)]
        [TestCase(MethodMerge, 0)]
        [TestCase(MethodCompileSite, 0)]
        [TestCase(MethodCompilePage, 0)]
        [TestCase(MethodGetProfileIdsFromXml, 0)]
        [TestCase(MethodBuildReturnXml, 0)]
        [TestCase(MethodBuildReturnXml, 1)]
        public void AUT_DeltaMergeAspComWrapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DeltaMergeAspComWrapper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DeltaMergeAspComWrapper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergeAspComWrapper_Is_Instance_Present_Test()
        {
            // Assert
            _deltaMergeAspComWrapperInstanceType.ShouldNotBeNull();
            _deltaMergeAspComWrapperInstance.ShouldNotBeNull();
            _deltaMergeAspComWrapperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DeltaMergeAspComWrapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DeltaMergeAspComWrapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergeAspComWrapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _deltaMergeAspComWrapperInstance.ShouldBeAssignableTo<DeltaMergeAspComWrapper>();
            _deltaMergeAspComWrapperInstanceFixture.ShouldBeAssignableTo<DeltaMergeAspComWrapper>();
            CurrentInstance.ShouldBeAssignableTo<DeltaMergeAspComWrapper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DeltaMergeAspComWrapper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DeltaMergeAspComWrapper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DeltaMergeAspComWrapper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSafeGuid) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);

            // Act
            Action executeAction = () => _deltaMergeAspComWrapperInstance.GetSafeGuid();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _deltaMergeAspComWrapperInstance.GetSafeGuid();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            Type [] methodGetSafeGuidParametersTypes = null;
            object[] parametersOfGetSafeGuid = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSafeGuid, methodGetSafeGuidParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfGetSafeGuid);
            var result2 = this.GetResultOfMethod<string>(MethodGetSafeGuid, parametersOfGetSafeGuid, methodGetSafeGuidParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetSafeGuid.ShouldBeNull();
            methodGetSafeGuidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            Type [] methodGetSafeGuidParametersTypes = null;
            object[] parametersOfGetSafeGuid = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSafeGuid, methodGetSafeGuidParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfGetSafeGuid);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSafeGuid.ShouldBeNull();
            methodGetSafeGuidParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            Type [] methodGetSafeGuidParametersTypes = null;
            object[] parametersOfGetSafeGuid = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSafeGuid, parametersOfGetSafeGuid, methodGetSafeGuidParametersTypes);

            // Assert
            parametersOfGetSafeGuid.ShouldBeNull();
            methodGetSafeGuidParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            Type [] methodGetSafeGuidParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSafeGuid, methodGetSafeGuidParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetSafeGuidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            Type [] methodGetSafeGuidParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSafeGuid, methodGetSafeGuidParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSafeGuidParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSafeGuid) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetSafeGuid_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSafeGuid);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSafeGuid, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_Internally(Type[] types)
        {
            var methodAppendActionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAppendActions, methodAppendActionsParametersTypes);
        }

        #endregion
        
        #region Method Call : (AppendActions) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var actionXml = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var comment = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodAppendActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(string), typeof(bool) };
            object[] parametersOfAppendActions = { sourceType, sourceUri, contextString, actionXml, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, isVirtualSource, virtualRootXml, escapeType, comment, shouldPatchClientSideIncludes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendActions, methodAppendActionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfAppendActions);
            var result2 = this.GetResultOfMethod<string>(MethodAppendActions, parametersOfAppendActions, methodAppendActionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAppendActions.ShouldNotBeNull();
            parametersOfAppendActions.Length.ShouldBe(15);
            methodAppendActionsParametersTypes.Length.ShouldBe(15);
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var actionXml = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var comment = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodAppendActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(string), typeof(bool) };
            object[] parametersOfAppendActions = { sourceType, sourceUri, contextString, actionXml, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, isVirtualSource, virtualRootXml, escapeType, comment, shouldPatchClientSideIncludes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendActions, methodAppendActionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfAppendActions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAppendActions.ShouldNotBeNull();
            parametersOfAppendActions.Length.ShouldBe(15);
            methodAppendActionsParametersTypes.Length.ShouldBe(15);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var actionXml = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var comment = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodAppendActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(string), typeof(bool) };
            object[] parametersOfAppendActions = { sourceType, sourceUri, contextString, actionXml, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, isVirtualSource, virtualRootXml, escapeType, comment, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAppendActions, parametersOfAppendActions, methodAppendActionsParametersTypes);

            // Assert
            parametersOfAppendActions.ShouldNotBeNull();
            parametersOfAppendActions.Length.ShouldBe(15);
            methodAppendActionsParametersTypes.Length.ShouldBe(15);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (AppendActions) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var methodAppendActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAppendActions, methodAppendActionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAppendActionsParametersTypes.Length.ShouldBe(15);
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var methodAppendActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(string), typeof(bool) };
            const int parametersCount = 15;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendActions, methodAppendActionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAppendActionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendActions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AppendActions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_AppendActions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendActions);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendActions, 0);
            const int parametersCount = 15;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_Internally(Type[] types)
        {
            var methodDiscardActionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDiscardActions, methodDiscardActionsParametersTypes);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var discardLayers = this.CreateType<DeltaMergeLayersToDiscard>();
            var methodDiscardActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(DeltaMergeLayersToDiscard) };
            object[] parametersOfDiscardActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, discardLayers };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardActions, methodDiscardActionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfDiscardActions);
            var result2 = this.GetResultOfMethod<string>(MethodDiscardActions, parametersOfDiscardActions, methodDiscardActionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDiscardActions.ShouldNotBeNull();
            parametersOfDiscardActions.Length.ShouldBe(10);
            methodDiscardActionsParametersTypes.Length.ShouldBe(10);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var discardLayers = this.CreateType<DeltaMergeLayersToDiscard>();
            var methodDiscardActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(DeltaMergeLayersToDiscard) };
            object[] parametersOfDiscardActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, discardLayers };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardActions, methodDiscardActionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfDiscardActions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDiscardActions.ShouldNotBeNull();
            parametersOfDiscardActions.Length.ShouldBe(10);
            methodDiscardActionsParametersTypes.Length.ShouldBe(10);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var discardLayers = this.CreateType<DeltaMergeLayersToDiscard>();
            var methodDiscardActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(DeltaMergeLayersToDiscard) };
            object[] parametersOfDiscardActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode, discardLayers };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDiscardActions, parametersOfDiscardActions, methodDiscardActionsParametersTypes);

            // Assert
            parametersOfDiscardActions.ShouldNotBeNull();
            parametersOfDiscardActions.Length.ShouldBe(10);
            methodDiscardActionsParametersTypes.Length.ShouldBe(10);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var methodDiscardActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(DeltaMergeLayersToDiscard) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDiscardActions, methodDiscardActionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDiscardActionsParametersTypes.Length.ShouldBe(10);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var methodDiscardActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(DeltaMergeLayersToDiscard) };
            const int parametersCount = 10;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDiscardActions, methodDiscardActionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDiscardActionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardActions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DiscardActions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_DiscardActions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardActions);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardActions, 0);
            const int parametersCount = 10;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_Internally(Type[] types)
        {
            var methodSaveActionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveActions, methodSaveActionsParametersTypes);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodSaveActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string) };
            object[] parametersOfSaveActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveActions, methodSaveActionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfSaveActions);
            var result2 = this.GetResultOfMethod<string>(MethodSaveActions, parametersOfSaveActions, methodSaveActionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveActions.ShouldNotBeNull();
            parametersOfSaveActions.Length.ShouldBe(9);
            methodSaveActionsParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodSaveActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string) };
            object[] parametersOfSaveActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveActions, methodSaveActionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfSaveActions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSaveActions.ShouldNotBeNull();
            parametersOfSaveActions.Length.ShouldBe(9);
            methodSaveActionsParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var editSessionId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodSaveActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string) };
            object[] parametersOfSaveActions = { sourceType, sourceUri, contextString, profileId, editSessionId, isProductionMode, isSafeMode, rootPath, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveActions, parametersOfSaveActions, methodSaveActionsParametersTypes);

            // Assert
            parametersOfSaveActions.ShouldNotBeNull();
            parametersOfSaveActions.Length.ShouldBe(9);
            methodSaveActionsParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var methodSaveActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveActions, methodSaveActionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSaveActionsParametersTypes.Length.ShouldBe(9);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var methodSaveActionsParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string) };
            const int parametersCount = 9;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveActions, methodSaveActionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveActionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveActions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SaveActions) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_SaveActions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveActions);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveActions, 0);
            const int parametersCount = 9;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_Internally(Type[] types)
        {
            var methodMergeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldPersist = this.CreateType<bool>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(bool) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, shouldIncludeUnpublishedLayers, isVirtualSource, virtualRootXml, escapeType, shouldPatchClientSideIncludes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfMerge);
            var result2 = this.GetResultOfMethod<string>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(14);
            methodMergeParametersTypes.Length.ShouldBe(14);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldPersist = this.CreateType<bool>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(bool) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, shouldIncludeUnpublishedLayers, isVirtualSource, virtualRootXml, escapeType, shouldPatchClientSideIncludes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfMerge);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(14);
            methodMergeParametersTypes.Length.ShouldBe(14);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var sourceType = this.CreateType<DeltaMergeSourceType>();
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var isProductionMode = this.CreateType<bool>();
            var isSafeMode = this.CreateType<bool>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldPersist = this.CreateType<bool>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(bool) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, shouldIncludeUnpublishedLayers, isVirtualSource, virtualRootXml, escapeType, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(14);
            methodMergeParametersTypes.Length.ShouldBe(14);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMergeParametersTypes.Length.ShouldBe(14);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType), typeof(bool) };
            const int parametersCount = 14;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_Merge_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);
            const int parametersCount = 14;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_Internally(Type[] types)
        {
            var methodCompileSiteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompileSite, methodCompileSiteParametersTypes);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();

            // Act
            Action executeAction = () => _deltaMergeAspComWrapperInstance.CompileSite(profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _deltaMergeAspComWrapperInstance.CompileSite(profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompileSiteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompileSite = { profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCompileSite, methodCompileSiteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfCompileSite);
            var result2 = this.GetResultOfMethod<string>(MethodCompileSite, parametersOfCompileSite, methodCompileSiteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompileSite.ShouldNotBeNull();
            parametersOfCompileSite.Length.ShouldBe(5);
            methodCompileSiteParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompileSiteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompileSite = { profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCompileSite, methodCompileSiteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfCompileSite);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompileSite.ShouldNotBeNull();
            parametersOfCompileSite.Length.ShouldBe(5);
            methodCompileSiteParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompileSiteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompileSite = { profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCompileSite, parametersOfCompileSite, methodCompileSiteParametersTypes);

            // Assert
            parametersOfCompileSite.ShouldNotBeNull();
            parametersOfCompileSite.Length.ShouldBe(5);
            methodCompileSiteParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CompileSite) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var methodCompileSiteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompileSite, methodCompileSiteParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCompileSiteParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var methodCompileSiteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompileSite, methodCompileSiteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompileSiteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var currentMethodInfo = this.GetMethodInfo(MethodCompileSite, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompileSite_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var currentMethodInfo = this.GetMethodInfo(MethodCompileSite, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_Internally(Type[] types)
        {
            var methodCompilePageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompilePage, methodCompilePageParametersTypes);
        }

        #endregion
        
        #region Method Call : (CompilePage) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();

            // Act
            Action executeAction = () => _deltaMergeAspComWrapperInstance.CompilePage(sourceUri, profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _deltaMergeAspComWrapperInstance.CompilePage(sourceUri, profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (CompilePage) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompilePage = { sourceUri, profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, methodCompilePageParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspComWrapperInstanceFixture, out exception1, parametersOfCompilePage);
            var result2 = this.GetResultOfMethod<string>(MethodCompilePage, parametersOfCompilePage, methodCompilePageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompilePage.ShouldNotBeNull();
            parametersOfCompilePage.Length.ShouldBe(6);
            methodCompilePageParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompilePage = { sourceUri, profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, methodCompilePageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfCompilePage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompilePage.ShouldNotBeNull();
            parametersOfCompilePage.Length.ShouldBe(6);
            methodCompilePageParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdListXml = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var shouldIncludeUnpublishedLayers = this.CreateType<bool>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfCompilePage = { sourceUri, profileIdListXml, rootPath, languageCode, shouldIncludeUnpublishedLayers, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCompilePage, parametersOfCompilePage, methodCompilePageParametersTypes);

            // Assert
            parametersOfCompilePage.ShouldNotBeNull();
            parametersOfCompilePage.Length.ShouldBe(6);
            methodCompilePageParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CompilePage) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompilePage, methodCompilePageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCompilePageParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompilePage, methodCompilePageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompilePageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (CompilePage) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_CompilePage_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProfileIdsFromXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var profileIdsXml = this.CreateType<string>();
            var methodGetProfileIdsFromXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProfileIdsFromXml = { profileIdsXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetProfileIdsFromXml, parametersOfGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfGetProfileIdsFromXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProfileIdsFromXml.ShouldNotBeNull();
            parametersOfGetProfileIdsFromXml.Length.ShouldBe(1);
            methodGetProfileIdsFromXmlParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var profileIdsXml = this.CreateType<string>();
            var methodGetProfileIdsFromXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProfileIdsFromXml = { profileIdsXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetProfileIdsFromXml, parametersOfGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);

            // Assert
            parametersOfGetProfileIdsFromXml.ShouldNotBeNull();
            parametersOfGetProfileIdsFromXml.Length.ShouldBe(1);
            methodGetProfileIdsFromXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var methodGetProfileIdsFromXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProfileIdsFromXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var methodGetProfileIdsFromXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProfileIdsFromXml, methodGetProfileIdsFromXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProfileIdsFromXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileIdsFromXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProfileIdsFromXml) (Return Type : string[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_GetProfileIdsFromXml_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileIdsFromXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileIdsFromXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Internally(Type[] types)
        {
            var methodBuildReturnXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var returnException = this.CreateType<Exception>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(Exception) };
            object[] parametersOfBuildReturnXml = { success, mergedXml, returnException };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(3);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes));
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var returnException = this.CreateType<Exception>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(Exception) };
            object[] parametersOfBuildReturnXml = { success, mergedXml, returnException };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfBuildReturnXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(3);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var returnException = this.CreateType<Exception>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(Exception) };
            object[] parametersOfBuildReturnXml = { success, mergedXml, returnException };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(3);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string), typeof(Exception) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodBuildReturnXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string) };
            object[] parametersOfBuildReturnXml = { success, mergedXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(2);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes));
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string) };
            object[] parametersOfBuildReturnXml = { success, mergedXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspComWrapperInstanceFixture, parametersOfBuildReturnXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(2);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var success = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string) };
            object[] parametersOfBuildReturnXml = { success, mergedXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBuildReturnXml, parametersOfBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            parametersOfBuildReturnXml.ShouldNotBeNull();
            parametersOfBuildReturnXml.Length.ShouldBe(2);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var methodBuildReturnXmlParametersTypes = new Type[] { typeof(bool), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildReturnXml, methodBuildReturnXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildReturnXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildReturnXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (BuildReturnXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAspComWrapper_BuildReturnXml_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildReturnXml, 1);
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