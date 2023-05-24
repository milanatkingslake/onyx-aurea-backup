using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.XmlProfileHelper" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlProfileHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlProfileHelper" />)
        /// </summary>
        public XmlProfileHelperTest() : base(typeof(XmlProfileHelper))
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

        #region General Initializer : Class (XmlProfileHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlProfileHelperInstanceType;
        private XmlProfileHelper _xmlProfileHelperInstance;
        private XmlProfileHelper _xmlProfileHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlProfileHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlProfileHelperInstanceType = typeof(XmlProfileHelper);
            _xmlProfileHelperInstanceFixture = this.Create<XmlProfileHelper>(false);
            _xmlProfileHelperInstance = _xmlProfileHelperInstanceFixture ?? this.Create<XmlProfileHelper>(true);
            CurrentInstance = _xmlProfileHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlProfileHelper) Initializer

        #region Methods

        private const string MethodApplyTemplate = "ApplyTemplate";
        private const string MethodPopulateData = "PopulateData";
        private const string MethodGetViewColumnNames = "GetViewColumnNames";
        private const string MethodGetSelectClause = "GetSelectClause";
        private const string MethodCheckUIResourcePermission = "CheckUIResourcePermission";
        private const string MethodPaginationForMobile = "PaginationForMobile";
        private const string MethodGetPageSize = "GetPageSize";
        private const string MethodMergeProfileTemplete = "MergeProfileTemplete";
        private const string MethodUpdateAttribute = "UpdateAttribute";
        private const string MethodCreateLBOxml = "CreateLBOxml";

        #endregion

        #region Fields

        private const string FieldXProfileDoc = "XProfileDoc";
        private const string FieldxmlResult = "xmlResult";
        private const string FieldXProfileType = "XProfileType";

        #endregion

        #endregion

        #region General Initializer : Class (XmlProfileHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlProfileHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlProfileHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlProfileHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlProfileHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlProfileHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlProfileHelper)

        #region General Initializer : Class (XmlProfileHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlProfileHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodApplyTemplate, 0)]
        [TestCase(MethodPopulateData, 0)]
        [TestCase(MethodPopulateData, 1)]
        [TestCase(MethodGetViewColumnNames, 0)]
        [TestCase(MethodGetViewColumnNames, 1)]
        [TestCase(MethodGetSelectClause, 0)]
        [TestCase(MethodCheckUIResourcePermission, 0)]
        [TestCase(MethodPaginationForMobile, 0)]
        [TestCase(MethodMergeProfileTemplete, 0)]
        [TestCase(MethodUpdateAttribute, 0)]
        [TestCase(MethodCreateLBOxml, 0)]
        public void AUT_XmlProfileHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (XmlProfileHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlProfileHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldXProfileDoc)]
        [TestCase(FieldxmlResult)]
        [TestCase(FieldXProfileType)]
        [Category("AUT Fields")]
        public void AUT_XmlProfileHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlProfileHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlProfileHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlProfileHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlProfileHelperInstance.ShouldBeAssignableTo<XmlProfileHelper>();
            _xmlProfileHelperInstanceFixture.ShouldBeAssignableTo<XmlProfileHelper>();
            CurrentInstance.ShouldBeAssignableTo<XmlProfileHelper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (XmlProfileHelper) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="XmlProfileHelper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlProfileHelper_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (XmlProfileHelper) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="XmlProfileHelper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlProfileHelper_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodXmlProfileHelperParametersTypes = new Type[] { typeof(string), typeof(ProfileType), typeof(Hashtable) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodXmlProfileHelperParametersTypes);
        }

        #endregion

        #region General Constructor : Class (XmlProfileHelper) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="XmlProfileHelper" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_XmlProfileHelper_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodXmlProfileHelperParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodXmlProfileHelperParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ApplyTemplate) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var templateType = this.CreateType<TemplateType>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.ApplyTemplate(templateType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ApplyTemplate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var templateType = this.CreateType<TemplateType>();
            var methodApplyTemplateParametersTypes = new Type[] { typeof(TemplateType) };
            object[] parametersOfApplyTemplate = { templateType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTemplate, methodApplyTemplateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfApplyTemplate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyTemplate.ShouldNotBeNull();
            parametersOfApplyTemplate.Length.ShouldBe(1);
            methodApplyTemplateParametersTypes.Length.ShouldBe(1);
            methodApplyTemplateParametersTypes.Length.ShouldBe(parametersOfApplyTemplate.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTemplate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var templateType = this.CreateType<TemplateType>();
            var methodApplyTemplateParametersTypes = new Type[] { typeof(TemplateType) };
            object[] parametersOfApplyTemplate = { templateType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyTemplate, parametersOfApplyTemplate, methodApplyTemplateParametersTypes);

            // Assert
            parametersOfApplyTemplate.ShouldNotBeNull();
            parametersOfApplyTemplate.Length.ShouldBe(1);
            methodApplyTemplateParametersTypes.Length.ShouldBe(1);
            methodApplyTemplateParametersTypes.Length.ShouldBe(parametersOfApplyTemplate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTemplate) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTemplate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyTemplate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var methodApplyTemplateParametersTypes = new Type[] { typeof(TemplateType) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyTemplate, methodApplyTemplateParametersTypes);

            // Assert
            methodApplyTemplateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyTemplate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_ApplyTemplate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyTemplate);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyTemplate, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_PopulateData_Method_Call_Internally(Type[] types)
        {
            var methodPopulateDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateData, methodPopulateDataParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var fieldNode = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.PopulateData(resultXml, fieldNode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var fieldNode = this.CreateType<XElement>();
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(XElement) };
            object[] parametersOfPopulateData = { resultXml, fieldNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, methodPopulateDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfPopulateData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateData.ShouldNotBeNull();
            parametersOfPopulateData.Length.ShouldBe(2);
            methodPopulateDataParametersTypes.Length.ShouldBe(2);
            methodPopulateDataParametersTypes.Length.ShouldBe(parametersOfPopulateData.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var fieldNode = this.CreateType<XElement>();
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(XElement) };
            object[] parametersOfPopulateData = { resultXml, fieldNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateData, parametersOfPopulateData, methodPopulateDataParametersTypes);

            // Assert
            parametersOfPopulateData.ShouldNotBeNull();
            parametersOfPopulateData.Length.ShouldBe(2);
            methodPopulateDataParametersTypes.Length.ShouldBe(2);
            methodPopulateDataParametersTypes.Length.ShouldBe(parametersOfPopulateData.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateData, methodPopulateDataParametersTypes);

            // Assert
            methodPopulateDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_PopulateData_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodPopulateDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateData, methodPopulateDataParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var lboName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.PopulateData(resultXml, parameterCollection, lboName, lboMethodName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var lboName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(Hashtable), typeof(string), typeof(string) };
            object[] parametersOfPopulateData = { resultXml, parameterCollection, lboName, lboMethodName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, methodPopulateDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfPopulateData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPopulateData.ShouldNotBeNull();
            parametersOfPopulateData.Length.ShouldBe(4);
            methodPopulateDataParametersTypes.Length.ShouldBe(4);
            methodPopulateDataParametersTypes.Length.ShouldBe(parametersOfPopulateData.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var resultXml = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var lboName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(Hashtable), typeof(string), typeof(string) };
            object[] parametersOfPopulateData = { resultXml, parameterCollection, lboName, lboMethodName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPopulateData, parametersOfPopulateData, methodPopulateDataParametersTypes);

            // Assert
            parametersOfPopulateData.ShouldNotBeNull();
            parametersOfPopulateData.Length.ShouldBe(4);
            methodPopulateDataParametersTypes.Length.ShouldBe(4);
            methodPopulateDataParametersTypes.Length.ShouldBe(parametersOfPopulateData.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, 1);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var methodPopulateDataParametersTypes = new Type[] { typeof(string), typeof(Hashtable), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateData, methodPopulateDataParametersTypes);

            // Assert
            methodPopulateDataParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PopulateData_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateData, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Internally(Type[] types)
        {
            var methodGetViewColumnNamesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.GetViewColumnNames();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var returnedValue = default(List<String>);

            // Act
            Action executeAction = () => returnedValue = _xmlProfileHelperInstance.GetViewColumnNames();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            Type [] methodGetViewColumnNamesParametersTypes = null;
            object[] parametersOfGetViewColumnNames = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<String>>(_xmlProfileHelperInstanceFixture, parametersOfGetViewColumnNames);
            var result2 = this.GetResultOfMethod<List<String>>(MethodGetViewColumnNames, parametersOfGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetViewColumnNames.ShouldBeNull();
            methodGetViewColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            Type [] methodGetViewColumnNamesParametersTypes = null;
            object[] parametersOfGetViewColumnNames = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<String>>(MethodGetViewColumnNames, parametersOfGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            parametersOfGetViewColumnNames.ShouldBeNull();
            methodGetViewColumnNamesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            Type [] methodGetViewColumnNamesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetViewColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            Type [] methodGetViewColumnNamesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetViewColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewColumnNames, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_GetViewColumnNames_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetViewColumnNamesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var FieldNode = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.GetViewColumnNames(FieldNode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var FieldNode = this.CreateType<XElement>();
            var returnedValue = default(List<String>);

            // Act
            Action executeAction = () => returnedValue = _xmlProfileHelperInstance.GetViewColumnNames(FieldNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var FieldNode = this.CreateType<XElement>();
            var methodGetViewColumnNamesParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetViewColumnNames = { FieldNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<String>>(_xmlProfileHelperInstanceFixture, parametersOfGetViewColumnNames);
            var result2 = this.GetResultOfMethod<List<String>>(MethodGetViewColumnNames, parametersOfGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetViewColumnNames.ShouldNotBeNull();
            parametersOfGetViewColumnNames.Length.ShouldBe(1);
            methodGetViewColumnNamesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var FieldNode = this.CreateType<XElement>();
            var methodGetViewColumnNamesParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetViewColumnNames = { FieldNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<String>>(MethodGetViewColumnNames, parametersOfGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            parametersOfGetViewColumnNames.ShouldNotBeNull();
            parametersOfGetViewColumnNames.Length.ShouldBe(1);
            methodGetViewColumnNamesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var methodGetViewColumnNamesParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetViewColumnNamesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var methodGetViewColumnNamesParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetViewColumnNames, methodGetViewColumnNamesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetViewColumnNamesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewColumnNames, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewColumnNames) (Return Type : List<String>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetViewColumnNames_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewColumnNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewColumnNames, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_GetSelectClause_Method_Call_Internally(Type[] types)
        {
            var methodGetSelectClauseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSelectClause, methodGetSelectClauseParametersTypes);
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.GetSelectClause();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlProfileHelperInstance.GetSelectClause();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            Type [] methodGetSelectClauseParametersTypes = null;
            object[] parametersOfGetSelectClause = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSelectClause, methodGetSelectClauseParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlProfileHelperInstanceFixture, parametersOfGetSelectClause);
            var result2 = this.GetResultOfMethod<string>(MethodGetSelectClause, parametersOfGetSelectClause, methodGetSelectClauseParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSelectClause.ShouldBeNull();
            methodGetSelectClauseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            Type [] methodGetSelectClauseParametersTypes = null;
            object[] parametersOfGetSelectClause = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSelectClause, parametersOfGetSelectClause, methodGetSelectClauseParametersTypes);

            // Assert
            parametersOfGetSelectClause.ShouldBeNull();
            methodGetSelectClauseParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            Type [] methodGetSelectClauseParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSelectClause, methodGetSelectClauseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSelectClauseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            Type [] methodGetSelectClauseParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSelectClause, methodGetSelectClauseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSelectClauseParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectClause) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_GetSelectClause_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectClause);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSelectClause, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_Internally(Type[] types)
        {
            var methodCheckUIResourcePermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckUIResourcePermission, methodCheckUIResourcePermissionParametersTypes);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.CheckUIResourcePermission(parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodCheckUIResourcePermissionParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfCheckUIResourcePermission = { parameterCollection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIResourcePermission, methodCheckUIResourcePermissionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfCheckUIResourcePermission);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckUIResourcePermission.ShouldNotBeNull();
            parametersOfCheckUIResourcePermission.Length.ShouldBe(1);
            methodCheckUIResourcePermissionParametersTypes.Length.ShouldBe(1);
            methodCheckUIResourcePermissionParametersTypes.Length.ShouldBe(parametersOfCheckUIResourcePermission.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodCheckUIResourcePermissionParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfCheckUIResourcePermission = { parameterCollection };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCheckUIResourcePermission, parametersOfCheckUIResourcePermission, methodCheckUIResourcePermissionParametersTypes);

            // Assert
            parametersOfCheckUIResourcePermission.ShouldNotBeNull();
            parametersOfCheckUIResourcePermission.Length.ShouldBe(1);
            methodCheckUIResourcePermissionParametersTypes.Length.ShouldBe(1);
            methodCheckUIResourcePermissionParametersTypes.Length.ShouldBe(parametersOfCheckUIResourcePermission.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIResourcePermission, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var methodCheckUIResourcePermissionParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckUIResourcePermission, methodCheckUIResourcePermissionParametersTypes);

            // Assert
            methodCheckUIResourcePermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckUIResourcePermission) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CheckUIResourcePermission_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckUIResourcePermission);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckUIResourcePermission, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_Internally(Type[] types)
        {
            var methodPaginationForMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPaginationForMobile, methodPaginationForMobileParametersTypes);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var pageSize = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.PaginationForMobile(pageSize, ParameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var pageSize = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlProfileHelperInstance.PaginationForMobile(pageSize, ParameterCollection);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var pageSize = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();
            var methodPaginationForMobileParametersTypes = new Type[] { typeof(int), typeof(Hashtable) };
            object[] parametersOfPaginationForMobile = { pageSize, ParameterCollection };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPaginationForMobile, methodPaginationForMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlProfileHelperInstanceFixture, parametersOfPaginationForMobile);
            var result2 = this.GetResultOfMethod<string>(MethodPaginationForMobile, parametersOfPaginationForMobile, methodPaginationForMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPaginationForMobile.ShouldNotBeNull();
            parametersOfPaginationForMobile.Length.ShouldBe(2);
            methodPaginationForMobileParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var pageSize = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();
            var methodPaginationForMobileParametersTypes = new Type[] { typeof(int), typeof(Hashtable) };
            object[] parametersOfPaginationForMobile = { pageSize, ParameterCollection };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPaginationForMobile, parametersOfPaginationForMobile, methodPaginationForMobileParametersTypes);

            // Assert
            parametersOfPaginationForMobile.ShouldNotBeNull();
            parametersOfPaginationForMobile.Length.ShouldBe(2);
            methodPaginationForMobileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var methodPaginationForMobileParametersTypes = new Type[] { typeof(int), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPaginationForMobile, methodPaginationForMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPaginationForMobileParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var methodPaginationForMobileParametersTypes = new Type[] { typeof(int), typeof(Hashtable) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPaginationForMobile, methodPaginationForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPaginationForMobileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodPaginationForMobile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PaginationForMobile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_PaginationForMobile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPaginationForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodPaginationForMobile, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPageSize) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_GetPageSize_Method_Call_Internally(Type[] types)
        {
            var methodGetPageSizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPageSize, methodGetPageSizeParametersTypes);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_Internally(Type[] types)
        {
            var methodMergeProfileTempleteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeProfileTemplete, methodMergeProfileTempleteParametersTypes);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var resultXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.MergeProfileTemplete(resultXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var resultXml = this.CreateType<string>();
            var methodMergeProfileTempleteParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfMergeProfileTemplete = { resultXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeProfileTemplete, methodMergeProfileTempleteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfMergeProfileTemplete);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMergeProfileTemplete.ShouldNotBeNull();
            parametersOfMergeProfileTemplete.Length.ShouldBe(1);
            methodMergeProfileTempleteParametersTypes.Length.ShouldBe(1);
            methodMergeProfileTempleteParametersTypes.Length.ShouldBe(parametersOfMergeProfileTemplete.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var resultXml = this.CreateType<string>();
            var methodMergeProfileTempleteParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfMergeProfileTemplete = { resultXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMergeProfileTemplete, parametersOfMergeProfileTemplete, methodMergeProfileTempleteParametersTypes);

            // Assert
            parametersOfMergeProfileTemplete.ShouldNotBeNull();
            parametersOfMergeProfileTemplete.Length.ShouldBe(1);
            methodMergeProfileTempleteParametersTypes.Length.ShouldBe(1);
            methodMergeProfileTempleteParametersTypes.Length.ShouldBe(parametersOfMergeProfileTemplete.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeProfileTemplete, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var methodMergeProfileTempleteParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeProfileTemplete, methodMergeProfileTempleteParametersTypes);

            // Assert
            methodMergeProfileTempleteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeProfileTemplete) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_MergeProfileTemplete_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeProfileTemplete);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeProfileTemplete, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_Internally(Type[] types)
        {
            var methodUpdateAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateAttribute, methodUpdateAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var xPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var attributeName = this.CreateType<string>();

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.UpdateAttribute(xPath, value, attributeName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var xPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var methodUpdateAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfUpdateAttribute = { xPath, value, attributeName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateAttribute, methodUpdateAttributeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlProfileHelperInstanceFixture, parametersOfUpdateAttribute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateAttribute.ShouldNotBeNull();
            parametersOfUpdateAttribute.Length.ShouldBe(3);
            methodUpdateAttributeParametersTypes.Length.ShouldBe(3);
            methodUpdateAttributeParametersTypes.Length.ShouldBe(parametersOfUpdateAttribute.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var xPath = this.CreateType<string>();
            var value = this.CreateType<string>();
            var attributeName = this.CreateType<string>();
            var methodUpdateAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfUpdateAttribute = { xPath, value, attributeName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateAttribute, parametersOfUpdateAttribute, methodUpdateAttributeParametersTypes);

            // Assert
            parametersOfUpdateAttribute.ShouldNotBeNull();
            parametersOfUpdateAttribute.Length.ShouldBe(3);
            methodUpdateAttributeParametersTypes.Length.ShouldBe(3);
            methodUpdateAttributeParametersTypes.Length.ShouldBe(parametersOfUpdateAttribute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateAttribute, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var methodUpdateAttributeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateAttribute, methodUpdateAttributeParametersTypes);

            // Assert
            methodUpdateAttributeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateAttribute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_UpdateAttribute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateAttribute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_Internally(Type[] types)
        {
            var methodCreateLBOxmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateLBOxml, methodCreateLBOxmlParametersTypes);
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);

            // Act
            Action executeAction = () => _xmlProfileHelperInstance.CreateLBOxml();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlProfileHelperInstance.CreateLBOxml();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            Type [] methodCreateLBOxmlParametersTypes = null;
            object[] parametersOfCreateLBOxml = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateLBOxml, methodCreateLBOxmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlProfileHelperInstanceFixture, parametersOfCreateLBOxml);
            var result2 = this.GetResultOfMethod<string>(MethodCreateLBOxml, parametersOfCreateLBOxml, methodCreateLBOxmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateLBOxml.ShouldBeNull();
            methodCreateLBOxmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            Type [] methodCreateLBOxmlParametersTypes = null;
            object[] parametersOfCreateLBOxml = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateLBOxml, parametersOfCreateLBOxml, methodCreateLBOxmlParametersTypes);

            // Assert
            parametersOfCreateLBOxml.ShouldBeNull();
            methodCreateLBOxmlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            Type [] methodCreateLBOxmlParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateLBOxml, methodCreateLBOxmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateLBOxmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            Type [] methodCreateLBOxmlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateLBOxml, methodCreateLBOxmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateLBOxmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateLBOxml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlProfileHelper_CreateLBOxml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLBOxml);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateLBOxml, 0);

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