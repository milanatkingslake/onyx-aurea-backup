using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxMergeTemplate" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxMergeTemplateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxMergeTemplate" />)
        /// </summary>
        public OnyxMergeTemplateTest() : base(typeof(OnyxMergeTemplate))
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

        #region General Initializer : Class (OnyxMergeTemplate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxMergeTemplateInstanceType;
        private OnyxMergeTemplate _onyxMergeTemplateInstance;
        private OnyxMergeTemplate _onyxMergeTemplateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxMergeTemplate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxMergeTemplateInstanceType = typeof(OnyxMergeTemplate);
            _onyxMergeTemplateInstanceFixture = this.Create<OnyxMergeTemplate>(false);
            _onyxMergeTemplateInstance = _onyxMergeTemplateInstanceFixture ?? this.Create<OnyxMergeTemplate>(true);
            CurrentInstance = _onyxMergeTemplateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxMergeTemplate) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySecondaryId = "SecondaryId";
        private const string PropertyName = "Name";
        private const string PropertyTemplateText = "TemplateText";
        private const string PropertyMethodCallId = "MethodCallId";

        #endregion

        #region Methods

        private const string MethodMergeCustomerData = "MergeCustomerData";

        #endregion

        #region Fields

        private const string FieldsecondaryId = "secondaryId";
        private const string FieldprimaryId = "primaryId";
        private const string Fieldname = "name";
        private const string FieldtemplateText = "templateText";
        private const string FieldmethodCallId = "methodCallId";
        private const string FieldloadLock = "loadLock";
        private const string FieldmergedTemplates = "mergedTemplates";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxMergeTemplate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMergeTemplate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxMergeTemplate) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMergeTemplate_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxMergeTemplate) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMergeTemplate_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxMergeTemplate)

        #region General Initializer : Class (OnyxMergeTemplate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMergeCustomerData, 0)]
        public void AUT_OnyxMergeTemplate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxMergeTemplate) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyTemplateText)]
        [TestCase(PropertyMethodCallId)]
        [Category("AUT Property")]
        public void AUT_OnyxMergeTemplate_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxMergeTemplate) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsecondaryId)]
        [TestCase(FieldprimaryId)]
        [TestCase(Fieldname)]
        [TestCase(FieldtemplateText)]
        [TestCase(FieldmethodCallId)]
        [TestCase(FieldloadLock)]
        [TestCase(FieldmergedTemplates)]
        [Category("AUT Fields")]
        public void AUT_OnyxMergeTemplate_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxMergeTemplate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMergeTemplate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxMergeTemplateInstance.ShouldBeAssignableTo<OnyxMergeTemplate>();
            _onyxMergeTemplateInstanceFixture.ShouldBeAssignableTo<OnyxMergeTemplate>();
            CurrentInstance.ShouldBeAssignableTo<OnyxMergeTemplate>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxMergeTemplate) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyTemplateText)]
        [TestCase(PropertyMethodCallId)]
        public void AUT_OnyxMergeTemplate_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxMergeTemplate) => Property (MethodCallId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxMergeTemplate_Public_Class_MethodCallId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodCallId);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodCallId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxMergeTemplate) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxMergeTemplate_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxMergeTemplate) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxMergeTemplate_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxMergeTemplate) => Property (SecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxMergeTemplate_Public_Class_SecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertySecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxMergeTemplate) => Property (TemplateText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxMergeTemplate_Public_Class_TemplateText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTemplateText);
            var propertyInfo = this.GetPropertyInfo(PropertyTemplateText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (MergeCustomerData) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var customerId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxMergeTemplateInstance.MergeCustomerData(customerId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var customerId = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxMergeTemplateInstance.MergeCustomerData(customerId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var customerId = this.CreateType<string>();
            var methodMergeCustomerDataParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfMergeCustomerData = { customerId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomerData, methodMergeCustomerDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxMergeTemplateInstanceFixture, parametersOfMergeCustomerData);
            var result2 = this.GetResultOfMethod<String>(MethodMergeCustomerData, parametersOfMergeCustomerData, methodMergeCustomerDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeCustomerData.ShouldNotBeNull();
            parametersOfMergeCustomerData.Length.ShouldBe(1);
            methodMergeCustomerDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var customerId = this.CreateType<string>();
            var methodMergeCustomerDataParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfMergeCustomerData = { customerId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodMergeCustomerData, parametersOfMergeCustomerData, methodMergeCustomerDataParametersTypes);

            // Assert
            parametersOfMergeCustomerData.ShouldNotBeNull();
            parametersOfMergeCustomerData.Length.ShouldBe(1);
            methodMergeCustomerDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var methodMergeCustomerDataParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeCustomerData, methodMergeCustomerDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeCustomerDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var methodMergeCustomerDataParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeCustomerData, methodMergeCustomerDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeCustomerDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomerData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomerData) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplate_MergeCustomerData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomerData);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomerData, 0);
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