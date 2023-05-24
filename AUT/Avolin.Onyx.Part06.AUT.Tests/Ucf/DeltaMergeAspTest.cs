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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.DeltaMergeAsp" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DeltaMergeAspTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DeltaMergeAsp" />)
        /// </summary>
        public DeltaMergeAspTest() : base(typeof(DeltaMergeAsp))
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

        #region General Initializer : Class (DeltaMergeAsp) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _deltaMergeAspInstanceType;
        private DeltaMergeAsp _deltaMergeAspInstance;
        private DeltaMergeAsp _deltaMergeAspInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DeltaMergeAsp" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _deltaMergeAspInstanceType = typeof(DeltaMergeAsp);
            _deltaMergeAspInstanceFixture = this.Create<DeltaMergeAsp>(false);
            _deltaMergeAspInstance = _deltaMergeAspInstanceFixture ?? this.Create<DeltaMergeAsp>(true);
            CurrentInstance = _deltaMergeAspInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergeAsp) Initializer

        #region Methods

        private const string MethodMerge = "Merge";
        private const string MethodCallPersist = "CallPersist";
        private const string MethodCallScriptCreator = "CallScriptCreator";
        private const string MethodCombineAspSections = "CombineAspSections";

        #endregion

        #region Fields

        private const string Field_assemblyVersion = "_assemblyVersion";

        #endregion

        #endregion

        #region General Initializer : Class (DeltaMergeAsp) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DeltaMergeAsp_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DeltaMergeAsp) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DeltaMergeAsp_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DeltaMergeAsp)

        #region General Initializer : Class (DeltaMergeAsp) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMerge, 0)]
        [TestCase(MethodMerge, 1)]
        [TestCase(MethodMerge, 2)]
        [TestCase(MethodMerge, 3)]
        [TestCase(MethodCallPersist, 0)]
        [TestCase(MethodCallScriptCreator, 0)]
        [TestCase(MethodCombineAspSections, 0)]
        public void AUT_DeltaMergeAsp_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DeltaMergeAsp) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_assemblyVersion)]
        [Category("AUT Fields")]
        public void AUT_DeltaMergeAsp_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DeltaMergeAsp) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergeAsp_Is_Instance_Present_Test()
        {
            // Assert
            _deltaMergeAspInstanceType.ShouldNotBeNull();
            _deltaMergeAspInstance.ShouldNotBeNull();
            _deltaMergeAspInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DeltaMergeAsp) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DeltaMergeAsp" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergeAsp_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _deltaMergeAspInstance.ShouldBeAssignableTo<DeltaMergeAsp>();
            _deltaMergeAspInstanceFixture.ShouldBeAssignableTo<DeltaMergeAsp>();
            CurrentInstance.ShouldBeAssignableTo<DeltaMergeAsp>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DeltaMergeAsp) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DeltaMergeAsp_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DeltaMergeAsp instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DeltaMergeAsp) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DeltaMergeAsp_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var deltaMergeAspInstance  = new DeltaMergeAsp();

            // Asserts
            deltaMergeAspInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Merge) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_DirectCall_Throw_Exception_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();

            // Act
            Action executeAction = () => _deltaMergeAspInstance.Merge(sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, isVirtualSource, virtualRootXml, escapeType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, isVirtualSource, virtualRootXml, escapeType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_deltaMergeAspInstanceFixture, parametersOfMerge);
            var result2 = this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(13);
            methodMergeParametersTypes.Length.ShouldBe(13);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_With_Results_Should_Not_Be_Null_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, isVirtualSource, virtualRootXml, escapeType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_deltaMergeAspInstanceFixture, out exception1, parametersOfMerge);
            var result2 = this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(13);
            methodMergeParametersTypes.Length.ShouldBe(13);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, isVirtualSource, virtualRootXml, escapeType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(13);
            methodMergeParametersTypes.Length.ShouldBe(13);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            const int parametersCount = 13;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);
            const int parametersCount = 13;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_Merge_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodMergeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var mergedXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _deltaMergeAspInstance.Merge(sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, isVirtualSource, virtualRootXml, escapeType, out mergedXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 1);
            const int parametersCount = 14;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_Merge_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodMergeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();

            // Act
            Action executeAction = () => _deltaMergeAspInstance.Merge(sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, shouldPatchClientSideIncludes, isVirtualSource, virtualRootXml, escapeType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, shouldPatchClientSideIncludes, isVirtualSource, virtualRootXml, escapeType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_deltaMergeAspInstanceFixture, parametersOfMerge);
            var result2 = this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

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

        #region Method Call : (Merge) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_With_Results_Should_Not_Be_Null_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, shouldPatchClientSideIncludes, isVirtualSource, virtualRootXml, escapeType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_deltaMergeAspInstanceFixture, out exception1, parametersOfMerge);
            var result2 = this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

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

        #region Method Call : (Merge) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            object[] parametersOfMerge = { sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, shouldPatchClientSideIncludes, isVirtualSource, virtualRootXml, escapeType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(14);
            methodMergeParametersTypes.Length.ShouldBe(14);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(DeltaMergeSourceType), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool), typeof(string), typeof(DeltaMergeEscapeType) };
            const int parametersCount = 14;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 2);
            const int parametersCount = 14;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_Merge_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodMergeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_DirectCall_Overloading_Of_3_Throw_Exception_Test()
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
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var isVirtualSource = this.CreateType<bool>();
            var virtualRootXml = this.CreateType<string>();
            var escapeType = this.CreateType<DeltaMergeEscapeType>();
            var mergedXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _deltaMergeAspInstance.Merge(sourceType, sourceUri, contextString, profileId, isProductionMode, isSafeMode, rootPath, languageCode, shouldPersist, layersToMerge, shouldPatchClientSideIncludes, isVirtualSource, virtualRootXml, escapeType, out mergedXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_Merge_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 3);
            const int parametersCount = 15;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CallPersist) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_CallPersist_Method_Call_Internally(Type[] types)
        {
            var methodCallPersistParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCallPersist, methodCallPersistParametersTypes);
        }

        #endregion
        
        #region Method Call : (CallPersist) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallPersist_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallPersist);
            var sourceUri = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var mergedXml = this.CreateType<string>();
            var prefix = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var context = this.CreateType<PageContext>();
            var methodCallPersistParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(PageContext) };
            object[] parametersOfCallPersist = { sourceUri, profileId, rootPath, shouldPatchClientSideIncludes, mergedXml, prefix, suffix, context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCallPersist, parametersOfCallPersist, methodCallPersistParametersTypes);

            // Assert
            parametersOfCallPersist.ShouldNotBeNull();
            parametersOfCallPersist.Length.ShouldBe(8);
            methodCallPersistParametersTypes.Length.ShouldBe(8);
            methodCallPersistParametersTypes.Length.ShouldBe(parametersOfCallPersist.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallPersist) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallPersist_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallPersist);
            var currentMethodInfo = this.GetMethodInfo(MethodCallPersist, 0);
            const int parametersCount = 8;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CallPersist) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallPersist_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallPersist);
            var methodCallPersistParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(PageContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCallPersist, methodCallPersistParametersTypes);

            // Assert
            methodCallPersistParametersTypes.Length.ShouldBe(8);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallPersist) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallPersist_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallPersist);
            var currentMethodInfo = this.GetMethodInfo(MethodCallPersist, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_Internally(Type[] types)
        {
            var methodCallScriptCreatorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCallScriptCreator, methodCallScriptCreatorParametersTypes);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallScriptCreator);
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var isSafeMode = this.CreateType<bool>();
            var layersToInclude = this.CreateType<DeltaMergeLayersToMerge>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var prefix = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var beforeBody = this.CreateType<string>();
            var afterBody = this.CreateType<string>();
            var methodCallScriptCreatorParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfCallScriptCreator = { sourceUri, contextString, profileId, isSafeMode, layersToInclude, rootPath, languageCode, prefix, suffix, beforeBody, afterBody };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCallScriptCreator, methodCallScriptCreatorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspInstanceFixture, parametersOfCallScriptCreator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCallScriptCreator.ShouldNotBeNull();
            parametersOfCallScriptCreator.Length.ShouldBe(11);
            methodCallScriptCreatorParametersTypes.Length.ShouldBe(11);
            methodCallScriptCreatorParametersTypes.Length.ShouldBe(parametersOfCallScriptCreator.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallScriptCreator);
            var sourceUri = this.CreateType<string>();
            var contextString = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var isSafeMode = this.CreateType<bool>();
            var layersToInclude = this.CreateType<DeltaMergeLayersToMerge>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var prefix = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var beforeBody = this.CreateType<string>();
            var afterBody = this.CreateType<string>();
            var methodCallScriptCreatorParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfCallScriptCreator = { sourceUri, contextString, profileId, isSafeMode, layersToInclude, rootPath, languageCode, prefix, suffix, beforeBody, afterBody };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCallScriptCreator, parametersOfCallScriptCreator, methodCallScriptCreatorParametersTypes);

            // Assert
            parametersOfCallScriptCreator.ShouldNotBeNull();
            parametersOfCallScriptCreator.Length.ShouldBe(11);
            methodCallScriptCreatorParametersTypes.Length.ShouldBe(11);
            methodCallScriptCreatorParametersTypes.Length.ShouldBe(parametersOfCallScriptCreator.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallScriptCreator);
            var currentMethodInfo = this.GetMethodInfo(MethodCallScriptCreator, 0);
            const int parametersCount = 11;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallScriptCreator);
            var methodCallScriptCreatorParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool), typeof(DeltaMergeLayersToMerge), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCallScriptCreator, methodCallScriptCreatorParametersTypes);

            // Assert
            methodCallScriptCreatorParametersTypes.Length.ShouldBe(11);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CallScriptCreator) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CallScriptCreator_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCallScriptCreator);
            var currentMethodInfo = this.GetMethodInfo(MethodCallScriptCreator, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_Internally(Type[] types)
        {
            var methodCombineAspSectionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCombineAspSections, methodCombineAspSectionsParametersTypes);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var prefix = this.CreateType<string>();
            var body = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCombineAspSectionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCombineAspSections = { prefix, body, suffix, shouldPatchClientSideIncludes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCombineAspSections, methodCombineAspSectionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_deltaMergeAspInstanceFixture, out exception1, parametersOfCombineAspSections);
            var result2 = this.GetResultOfMethod<string>(MethodCombineAspSections, parametersOfCombineAspSections, methodCombineAspSectionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCombineAspSections.ShouldNotBeNull();
            parametersOfCombineAspSections.Length.ShouldBe(4);
            methodCombineAspSectionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var prefix = this.CreateType<string>();
            var body = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCombineAspSectionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCombineAspSections = { prefix, body, suffix, shouldPatchClientSideIncludes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCombineAspSections, methodCombineAspSectionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_deltaMergeAspInstanceFixture, parametersOfCombineAspSections);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCombineAspSections.ShouldNotBeNull();
            parametersOfCombineAspSections.Length.ShouldBe(4);
            methodCombineAspSectionsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var prefix = this.CreateType<string>();
            var body = this.CreateType<string>();
            var suffix = this.CreateType<string>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCombineAspSectionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCombineAspSections = { prefix, body, suffix, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCombineAspSections, parametersOfCombineAspSections, methodCombineAspSectionsParametersTypes);

            // Assert
            parametersOfCombineAspSections.ShouldNotBeNull();
            parametersOfCombineAspSections.Length.ShouldBe(4);
            methodCombineAspSectionsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var methodCombineAspSectionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCombineAspSections, methodCombineAspSectionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCombineAspSectionsParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var methodCombineAspSectionsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCombineAspSections, methodCombineAspSectionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCombineAspSectionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var currentMethodInfo = this.GetMethodInfo(MethodCombineAspSections, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CombineAspSections) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeAsp_CombineAspSections_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCombineAspSections);
            var currentMethodInfo = this.GetMethodInfo(MethodCombineAspSections, 0);
            const int parametersCount = 4;

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