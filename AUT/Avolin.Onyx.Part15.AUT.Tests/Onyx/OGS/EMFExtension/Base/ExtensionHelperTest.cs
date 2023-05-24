using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Base
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Base.ExtensionHelper" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExtensionHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExtensionHelper" />)
        /// </summary>
        public ExtensionHelperTest() : base(typeof(ExtensionHelper))
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

        #region General Initializer : Class (ExtensionHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extensionHelperInstanceType;
        private ExtensionHelper _extensionHelperInstance;
        private ExtensionHelper _extensionHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ExtensionHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extensionHelperInstanceType = typeof(ExtensionHelper);
            _extensionHelperInstanceFixture = this.Create<ExtensionHelper>(false);
            _extensionHelperInstance = _extensionHelperInstanceFixture ?? this.Create<ExtensionHelper>(true);
            CurrentInstance = _extensionHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExtensionHelper) Initializer

        #region Methods

        private const string MethodPrepareInputParameters = "PrepareInputParameters";
        private const string MethodExecuteLBO = "ExecuteLBO";
        private const string MethodFormatRowSet = "FormatRowSet";
        private const string MethodMergeColumnDefinitions = "MergeColumnDefinitions";
        private const string MethodFillReferenceParameters = "FillReferenceParameters";
        private const string MethodFillUserName = "FillUserName";
        private const string MethodFillProductName = "FillProductName";

        #endregion

        #region Fields

        private const string FieldactionNodeName = "actionNodeName";
        private const string FieldinterfaceNodeName = "interfaceNodeName";
        private const string FieldstatusAttributeName = "statusAttributeName";
        private const string FieldSUCCESS_VALUE = "SUCCESS_VALUE";
        private const string FieldidNodeName = "idNodeName";
        private const string FieldvalueNodeName = "valueNodeName";
        private const string FieldreferenceParameterNodeName = "referenceParameterNodeName";
        private const string FielduserNodeName = "userNodeName";
        private const string FieldincidentProductNodeName = "incidentProductNodeName";
        private const string FieldlboAttributeName = "lboAttributeName";
        private const string FieldmethodAttributeName = "methodAttributeName";

        #endregion

        #endregion

        #region General Initializer : Class (ExtensionHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExtensionHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExtensionHelper)

        #region General Initializer : Class (ExtensionHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPrepareInputParameters, 0)]
        [TestCase(MethodExecuteLBO, 0)]
        [TestCase(MethodFormatRowSet, 0)]
        [TestCase(MethodMergeColumnDefinitions, 0)]
        [TestCase(MethodFillReferenceParameters, 0)]
        [TestCase(MethodFillUserName, 0)]
        [TestCase(MethodFillProductName, 0)]
        public void AUT_ExtensionHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ExtensionHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldactionNodeName)]
        [TestCase(FieldinterfaceNodeName)]
        [TestCase(FieldstatusAttributeName)]
        [TestCase(FieldSUCCESS_VALUE)]
        [TestCase(FieldidNodeName)]
        [TestCase(FieldvalueNodeName)]
        [TestCase(FieldreferenceParameterNodeName)]
        [TestCase(FielduserNodeName)]
        [TestCase(FieldincidentProductNodeName)]
        [TestCase(FieldlboAttributeName)]
        [TestCase(FieldmethodAttributeName)]
        [Category("AUT Fields")]
        public void AUT_ExtensionHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ExtensionHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExtensionHelper_Is_Instance_Present_Test()
        {
            // Assert
            _extensionHelperInstanceType.ShouldNotBeNull();
            _extensionHelperInstance.ShouldNotBeNull();
            _extensionHelperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExtensionHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExtensionHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExtensionHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _extensionHelperInstance.ShouldBeAssignableTo<ExtensionHelper>();
            _extensionHelperInstanceFixture.ShouldBeAssignableTo<ExtensionHelper>();
            CurrentInstance.ShouldBeAssignableTo<ExtensionHelper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExtensionHelper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ExtensionHelper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ExtensionHelper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (PrepareInputParameters) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_PrepareInputParameters_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfPrepareInputParameters = { parameterCollection, inputXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, methodPrepareInputParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfPrepareInputParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPrepareInputParameters.ShouldNotBeNull();
            parametersOfPrepareInputParameters.Length.ShouldBe(2);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_PrepareInputParameters_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfPrepareInputParameters = { parameterCollection, inputXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPrepareInputParameters, parametersOfPrepareInputParameters, methodPrepareInputParametersParametersTypes);

            // Assert
            parametersOfPrepareInputParameters.ShouldNotBeNull();
            parametersOfPrepareInputParameters.Length.ShouldBe(2);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_PrepareInputParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_PrepareInputParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrepareInputParameters, methodPrepareInputParametersParametersTypes);

            // Assert
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_PrepareInputParameters_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_Internally(Type[] types)
        {
            var methodExecuteLBOParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfExecuteLBO = { parameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, methodExecuteLBOParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);
            var result2 = this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfExecuteLBO);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(1);
            methodExecuteLBOParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfExecuteLBO = { parameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(1);
            methodExecuteLBOParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLBOParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLBOParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_ExecuteLBO_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_Internally(Type[] types)
        {
            var methodFormatRowSetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatRowSet, methodFormatRowSetParametersTypes);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatRowSet);
            var returnXml = this.CreateType<XElement>();
            var rowName = this.CreateType<string>();
            var groupName = this.CreateType<string>();
            var methodFormatRowSetParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };
            object[] parametersOfFormatRowSet = { returnXml, rowName, groupName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatRowSet, methodFormatRowSetParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfFormatRowSet);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatRowSet.ShouldNotBeNull();
            parametersOfFormatRowSet.Length.ShouldBe(3);
            methodFormatRowSetParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatRowSet);
            var returnXml = this.CreateType<XElement>();
            var rowName = this.CreateType<string>();
            var groupName = this.CreateType<string>();
            var methodFormatRowSetParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };
            object[] parametersOfFormatRowSet = { returnXml, rowName, groupName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFormatRowSet, parametersOfFormatRowSet, methodFormatRowSetParametersTypes);

            // Assert
            parametersOfFormatRowSet.ShouldNotBeNull();
            parametersOfFormatRowSet.Length.ShouldBe(3);
            methodFormatRowSetParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatRowSet);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatRowSet, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatRowSet);
            var methodFormatRowSetParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatRowSet, methodFormatRowSetParametersTypes);

            // Assert
            methodFormatRowSetParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatRowSet) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FormatRowSet_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatRowSet);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatRowSet, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_Internally(Type[] types)
        {
            var methodMergeColumnDefinitionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var rowSetNode = this.CreateType<XElement>();
            var rowName = this.CreateType<string>();
            var methodMergeColumnDefinitionsParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfMergeColumnDefinitions = { rowSetNode, rowName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);
            var result2 = this.GetResultOfMethod<List<XElement>>(MethodMergeColumnDefinitions, parametersOfMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMergeColumnDefinitions.ShouldNotBeNull();
            parametersOfMergeColumnDefinitions.Length.ShouldBe(2);
            methodMergeColumnDefinitionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<List<XElement>>(MethodMergeColumnDefinitions, parametersOfMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes));
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var rowSetNode = this.CreateType<XElement>();
            var rowName = this.CreateType<string>();
            var methodMergeColumnDefinitionsParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfMergeColumnDefinitions = { rowSetNode, rowName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfMergeColumnDefinitions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMergeColumnDefinitions.ShouldNotBeNull();
            parametersOfMergeColumnDefinitions.Length.ShouldBe(2);
            methodMergeColumnDefinitionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var rowSetNode = this.CreateType<XElement>();
            var rowName = this.CreateType<string>();
            var methodMergeColumnDefinitionsParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfMergeColumnDefinitions = { rowSetNode, rowName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<XElement>>(MethodMergeColumnDefinitions, parametersOfMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);

            // Assert
            parametersOfMergeColumnDefinitions.ShouldNotBeNull();
            parametersOfMergeColumnDefinitions.Length.ShouldBe(2);
            methodMergeColumnDefinitionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var methodMergeColumnDefinitionsParametersTypes = new Type[] { typeof(XElement), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMergeColumnDefinitionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var methodMergeColumnDefinitionsParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeColumnDefinitions, methodMergeColumnDefinitionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeColumnDefinitionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeColumnDefinitions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (MergeColumnDefinitions) (Return Type : List<XElement>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_MergeColumnDefinitions_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeColumnDefinitions);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeColumnDefinitions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_Internally(Type[] types)
        {
            var methodFillReferenceParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillReferenceParameters = { siteId, languageCode, inputXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfFillReferenceParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFillReferenceParameters.ShouldNotBeNull();
            parametersOfFillReferenceParameters.Length.ShouldBe(3);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillReferenceParameters = { siteId, languageCode, inputXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFillReferenceParameters, parametersOfFillReferenceParameters, methodFillReferenceParametersParametersTypes);

            // Assert
            parametersOfFillReferenceParameters.ShouldNotBeNull();
            parametersOfFillReferenceParameters.Length.ShouldBe(3);
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var methodFillReferenceParametersParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFillReferenceParameters, methodFillReferenceParametersParametersTypes);

            // Assert
            methodFillReferenceParametersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillReferenceParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillReferenceParameters_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillReferenceParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodFillReferenceParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_FillUserName_Static_Method_Call_Internally(Type[] types)
        {
            var methodFillUserNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFillUserName, methodFillUserNameParametersTypes);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillUserName_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillUserName = { siteId, languageCode, inputXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, methodFillUserNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfFillUserName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFillUserName.ShouldNotBeNull();
            parametersOfFillUserName.Length.ShouldBe(3);
            methodFillUserNameParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillUserName_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillUserName = { siteId, languageCode, inputXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFillUserName, parametersOfFillUserName, methodFillUserNameParametersTypes);

            // Assert
            parametersOfFillUserName.ShouldNotBeNull();
            parametersOfFillUserName.Length.ShouldBe(3);
            methodFillUserNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillUserName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillUserName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var methodFillUserNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFillUserName, methodFillUserNameParametersTypes);

            // Assert
            methodFillUserNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillUserName) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillUserName_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillUserName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillUserName, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ExtensionHelper_FillProductName_Static_Method_Call_Internally(Type[] types)
        {
            var methodFillProductNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFillProductName, methodFillProductNameParametersTypes);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillProductName_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillProductName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillProductNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillProductName = { siteId, languageCode, inputXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFillProductName, methodFillProductNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_extensionHelperInstanceFixture, parametersOfFillProductName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFillProductName.ShouldNotBeNull();
            parametersOfFillProductName.Length.ShouldBe(3);
            methodFillProductNameParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillProductName_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillProductName);
            var siteId = this.CreateType<int>();
            var languageCode = this.CreateType<string>();
            var inputXml = this.CreateType<XElement>();
            var methodFillProductNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };
            object[] parametersOfFillProductName = { siteId, languageCode, inputXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFillProductName, parametersOfFillProductName, methodFillProductNameParametersTypes);

            // Assert
            parametersOfFillProductName.ShouldNotBeNull();
            parametersOfFillProductName.Length.ShouldBe(3);
            methodFillProductNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillProductName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillProductName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillProductName, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillProductName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillProductName);
            var methodFillProductNameParametersTypes = new Type[] { typeof(int), typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFillProductName, methodFillProductNameParametersTypes);

            // Assert
            methodFillProductNameParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FillProductName) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExtensionHelper_FillProductName_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFillProductName);
            var currentMethodInfo = this.GetMethodInfo(MethodFillProductName, 0);

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