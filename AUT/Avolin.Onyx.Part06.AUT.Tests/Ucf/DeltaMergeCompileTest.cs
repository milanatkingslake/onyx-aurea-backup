using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.DeltaMergeCompile" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DeltaMergeCompileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DeltaMergeCompile" />)
        /// </summary>
        public DeltaMergeCompileTest() : base(typeof(DeltaMergeCompile))
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

        #region General Initializer : Class (DeltaMergeCompile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _deltaMergeCompileInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="DeltaMergeCompile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _deltaMergeCompileInstanceType = typeof(DeltaMergeCompile);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergeCompile) Initializer

        #region Methods

        private const string MethodCompileSite = "CompileSite";
        private const string MethodCompilePage = "CompilePage";
        private const string MethodGenerateFrameworkScript = "GenerateFrameworkScript";
        private const string MethodGetContextValuesFromNode = "GetContextValuesFromNode";
        private const string MethodBuildContextStrings = "BuildContextStrings";

        #endregion

        #endregion

        #region General Initializer : Class (DeltaMergeCompile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DeltaMergeCompile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DeltaMergeCompile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DeltaMergeCompile)

        #region General Initializer : Class (DeltaMergeCompile) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DeltaMergeCompile" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCompileSite, 0)]
        [TestCase(MethodCompilePage, 0)]
        [TestCase(MethodGenerateFrameworkScript, 0)]
        [TestCase(MethodGetContextValuesFromNode, 0)]
        [TestCase(MethodBuildContextStrings, 0)]
        public void AUT_DeltaMergeCompile_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DeltaMergeCompile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DeltaMergeCompile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergeCompile_Is_Static_Type_Present_Test()
        {
            // Assert
            _deltaMergeCompileInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CompileSite) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompileSite_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdList = this.CreateType<string[]>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();

            // Act
            Action executeAction = () => DeltaMergeCompile.CompileSite(profileIdList, rootPath, languageCode, layersToMerge, shouldPatchClientSideIncludes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompileSite_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var profileIdList = this.CreateType<string[]>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var methodCompileSiteParametersTypes = new Type[] { typeof(string[]), typeof(string), typeof(string), typeof(DeltaMergeLayersToMerge), typeof(bool) };
            object[] parametersOfCompileSite = { profileIdList, rootPath, languageCode, layersToMerge, shouldPatchClientSideIncludes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCompileSite, parametersOfCompileSite, methodCompileSiteParametersTypes);

            // Assert
            parametersOfCompileSite.ShouldNotBeNull();
            parametersOfCompileSite.Length.ShouldBe(5);
            methodCompileSiteParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompileSite_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var methodCompileSiteParametersTypes = new Type[] { typeof(string[]), typeof(string), typeof(string), typeof(DeltaMergeLayersToMerge), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompileSite, methodCompileSiteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompileSiteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompileSite_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompileSite);
            var currentMethodInfo = this.GetMethodInfo(MethodCompileSite, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CompileSite) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompileSite_Static_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (CompilePage) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeCompile_CompilePage_Static_Method_Call_Internally(Type[] types)
        {
            var methodCompilePageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCompilePage, methodCompilePageParametersTypes);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompilePage_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdList = this.CreateType<string[]>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var shouldGenerateFrameworkScript = this.CreateType<bool>();

            // Act
            Action executeAction = () => DeltaMergeCompile.CompilePage(sourceUri, profileIdList, rootPath, languageCode, layersToMerge, shouldPatchClientSideIncludes, shouldGenerateFrameworkScript);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompilePage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var sourceUri = this.CreateType<string>();
            var profileIdList = this.CreateType<string[]>();
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var layersToMerge = this.CreateType<DeltaMergeLayersToMerge>();
            var shouldPatchClientSideIncludes = this.CreateType<bool>();
            var shouldGenerateFrameworkScript = this.CreateType<bool>();
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string[]), typeof(string), typeof(string), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool) };
            object[] parametersOfCompilePage = { sourceUri, profileIdList, rootPath, languageCode, layersToMerge, shouldPatchClientSideIncludes, shouldGenerateFrameworkScript };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCompilePage, parametersOfCompilePage, methodCompilePageParametersTypes);

            // Assert
            parametersOfCompilePage.ShouldNotBeNull();
            parametersOfCompilePage.Length.ShouldBe(7);
            methodCompilePageParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompilePage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var methodCompilePageParametersTypes = new Type[] { typeof(string), typeof(string[]), typeof(string), typeof(string), typeof(DeltaMergeLayersToMerge), typeof(bool), typeof(bool) };
            const int parametersCount = 7;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompilePage, methodCompilePageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompilePageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompilePage_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CompilePage) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_CompilePage_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompilePage);
            var currentMethodInfo = this.GetMethodInfo(MethodCompilePage, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateFrameworkScriptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateFrameworkScript = { rootPath, languageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodGenerateFrameworkScript, parametersOfGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenerateFrameworkScript.ShouldNotBeNull();
            parametersOfGenerateFrameworkScript.Length.ShouldBe(2);
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodGenerateFrameworkScript, parametersOfGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes));
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateFrameworkScript = { rootPath, languageCode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateFrameworkScript);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateFrameworkScript.ShouldNotBeNull();
            parametersOfGenerateFrameworkScript.Length.ShouldBe(2);
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var rootPath = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateFrameworkScript = { rootPath, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGenerateFrameworkScript, parametersOfGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);

            // Assert
            parametersOfGenerateFrameworkScript.ShouldNotBeNull();
            parametersOfGenerateFrameworkScript.Length.ShouldBe(2);
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var methodGenerateFrameworkScriptParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateFrameworkScript, methodGenerateFrameworkScriptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateFrameworkScriptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateFrameworkScript, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateFrameworkScript) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GenerateFrameworkScript_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateFrameworkScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateFrameworkScript, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetContextValuesFromNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var contextNode = this.CreateType<XmlNode>();
            var methodGetContextValuesFromNodeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetContextValuesFromNode = { contextNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetContextValuesFromNode, parametersOfGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetContextValuesFromNode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextValuesFromNode.ShouldNotBeNull();
            parametersOfGetContextValuesFromNode.Length.ShouldBe(1);
            methodGetContextValuesFromNodeParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var contextNode = this.CreateType<XmlNode>();
            var methodGetContextValuesFromNodeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetContextValuesFromNode = { contextNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetContextValuesFromNode, parametersOfGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);

            // Assert
            parametersOfGetContextValuesFromNode.ShouldNotBeNull();
            parametersOfGetContextValuesFromNode.Length.ShouldBe(1);
            methodGetContextValuesFromNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var methodGetContextValuesFromNodeParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextValuesFromNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var methodGetContextValuesFromNodeParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextValuesFromNode, methodGetContextValuesFromNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextValuesFromNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextValuesFromNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextValuesFromNode) (Return Type : string[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_GetContextValuesFromNode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextValuesFromNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextValuesFromNode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_Internally(Type[] types)
        {
            var methodBuildContextStringsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildContextStrings, methodBuildContextStringsParametersTypes);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextStrings);
            var level = this.CreateType<int>();
            var contextNames = this.CreateType<string[]>();
            var contextValues = this.CreateType<List<string[]>>();
            var contextStrings = this.CreateType<List<string>>();
            var parentContextString = this.CreateType<string>();
            var methodBuildContextStringsParametersTypes = new Type[] { typeof(int), typeof(string[]), typeof(List<string[]>), typeof(List<string>), typeof(string) };
            object[] parametersOfBuildContextStrings = { level, contextNames, contextValues, contextStrings, parentContextString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextStrings, methodBuildContextStringsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfBuildContextStrings);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildContextStrings.ShouldNotBeNull();
            parametersOfBuildContextStrings.Length.ShouldBe(5);
            methodBuildContextStringsParametersTypes.Length.ShouldBe(5);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextStrings);
            var level = this.CreateType<int>();
            var contextNames = this.CreateType<string[]>();
            var contextValues = this.CreateType<List<string[]>>();
            var contextStrings = this.CreateType<List<string>>();
            var parentContextString = this.CreateType<string>();
            var methodBuildContextStringsParametersTypes = new Type[] { typeof(int), typeof(string[]), typeof(List<string[]>), typeof(List<string>), typeof(string) };
            object[] parametersOfBuildContextStrings = { level, contextNames, contextValues, contextStrings, parentContextString };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBuildContextStrings, parametersOfBuildContextStrings, methodBuildContextStringsParametersTypes);

            // Assert
            parametersOfBuildContextStrings.ShouldNotBeNull();
            parametersOfBuildContextStrings.Length.ShouldBe(5);
            methodBuildContextStringsParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextStrings);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextStrings, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextStrings);
            var methodBuildContextStringsParametersTypes = new Type[] { typeof(int), typeof(string[]), typeof(List<string[]>), typeof(List<string>), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildContextStrings, methodBuildContextStringsParametersTypes);

            // Assert
            methodBuildContextStringsParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextStrings) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergeCompile_BuildContextStrings_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextStrings);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextStrings, 0);

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