using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxConfigLBO" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxConfigLBOTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxConfigLBO" />)
        /// </summary>
        public OnyxConfigLBOTest() : base(typeof(OnyxConfigLBO))
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

        #region General Initializer : Class (OnyxConfigLBO) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxConfigLBOInstanceType;
        private OnyxConfigLBO _onyxConfigLBOInstance;
        private OnyxConfigLBO _onyxConfigLBOInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxConfigLBO" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxConfigLBOInstanceType = typeof(OnyxConfigLBO);
            _onyxConfigLBOInstanceFixture = this.Create<OnyxConfigLBO>(false);
            _onyxConfigLBOInstance = _onyxConfigLBOInstanceFixture ?? this.Create<OnyxConfigLBO>(true);
            CurrentInstance = _onyxConfigLBOInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxConfigLBO) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyLbo = "Lbo";
        private const string PropertyLbm = "Lbm";
        private const string PropertyDependentOnObject = "DependentOnObject";
        private const string PropertyPreInsertTransform = "PreInsertTransform";
        private const string PropertyDocParam = "DocParam";
        private const string PropertyNoNodesToProcess = "NoNodesToProcess";
        private const string PropertyBypassDupeCheck = "BypassDupeCheck";
        private const string PropertyLogRawNotes = "LogRawNotes";

        #endregion

        #region Methods

        private const string MethodPopulateTargetData = "PopulateTargetData";
        private const string MethodPopulateSourceData = "PopulateSourceData";
        private const string MethodExecuteLBM = "ExecuteLBM";
        private const string MethodProcessPreInputMethods = "ProcessPreInputMethods";
        private const string MethodGetConfigNodeValue = "GetConfigNodeValue";
        private const string MethodFormatInputForNonUSAddresses = "FormatInputForNonUSAddresses";
        private const string MethodFormatForPrimaryPhone = "FormatForPrimaryPhone";
        private const string MethodgetValueFromInput = "getValueFromInput";
        private const string MethodtransformDataValue = "transformDataValue";

        #endregion

        #region Fields

        private const string FieldlboParamDoc = "lboParamDoc";
        private const string Fieldlbo = "lbo";
        private const string Fieldlbm = "lbm";
        private const string Fieldid = "id";
        private const string FielddependsOn = "dependsOn";
        private const string FieldbypassDupeCheck = "bypassDupeCheck";
        private const string FieldlogRawNotes = "logRawNotes";
        private const string FieldnoNodesToProcess = "noNodesToProcess";
        private const string FieldpreInsertTransform = "preInsertTransform";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxConfigLBO) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxConfigLBO_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxConfigLBO) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxConfigLBO_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxConfigLBO) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxConfigLBO_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxConfigLBO)

        #region General Initializer : Class (OnyxConfigLBO) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPopulateTargetData, 0)]
        [TestCase(MethodPopulateSourceData, 0)]
        [TestCase(MethodExecuteLBM, 0)]
        [TestCase(MethodExecuteLBM, 1)]
        [TestCase(MethodProcessPreInputMethods, 0)]
        [TestCase(MethodGetConfigNodeValue, 0)]
        [TestCase(MethodFormatInputForNonUSAddresses, 0)]
        [TestCase(MethodFormatForPrimaryPhone, 0)]
        [TestCase(MethodgetValueFromInput, 0)]
        [TestCase(MethodtransformDataValue, 0)]
        public void AUT_OnyxConfigLBO_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxConfigLBO) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyLbo)]
        [TestCase(PropertyLbm)]
        [TestCase(PropertyDependentOnObject)]
        [TestCase(PropertyPreInsertTransform)]
        [TestCase(PropertyDocParam)]
        [TestCase(PropertyNoNodesToProcess)]
        [TestCase(PropertyBypassDupeCheck)]
        [TestCase(PropertyLogRawNotes)]
        [Category("AUT Property")]
        public void AUT_OnyxConfigLBO_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxConfigLBO) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlboParamDoc)]
        [TestCase(Fieldlbo)]
        [TestCase(Fieldlbm)]
        [TestCase(Fieldid)]
        [TestCase(FielddependsOn)]
        [TestCase(FieldbypassDupeCheck)]
        [TestCase(FieldlogRawNotes)]
        [TestCase(FieldnoNodesToProcess)]
        [TestCase(FieldpreInsertTransform)]
        [Category("AUT Fields")]
        public void AUT_OnyxConfigLBO_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxConfigLBO) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxConfigLBO" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxConfigLBO_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxConfigLBOInstance.ShouldBeAssignableTo<OnyxConfigLBO>();
            _onyxConfigLBOInstanceFixture.ShouldBeAssignableTo<OnyxConfigLBO>();
            CurrentInstance.ShouldBeAssignableTo<OnyxConfigLBO>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxConfigLBO) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyLbo)]
        [TestCase(PropertyLbm)]
        [TestCase(PropertyDependentOnObject)]
        [TestCase(PropertyPreInsertTransform)]
        [TestCase(PropertyDocParam)]
        [TestCase(PropertyNoNodesToProcess)]
        [TestCase(PropertyBypassDupeCheck)]
        [TestCase(PropertyLogRawNotes)]
        public void AUT_OnyxConfigLBO_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (BypassDupeCheck) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_BypassDupeCheck_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBypassDupeCheck);
            var propertyInfo = this.GetPropertyInfo(PropertyBypassDupeCheck);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (DependentOnObject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_DependentOnObject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDependentOnObject);
            var propertyInfo = this.GetPropertyInfo(PropertyDependentOnObject);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (DocParam) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_DocParam_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocParam);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDocParam);
            Action currentAction = () => propertyInfo.SetValue(_onyxConfigLBOInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (DocParam) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_DocParam_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocParam);
            var propertyInfo = this.GetPropertyInfo(PropertyDocParam);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (Lbm) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_Lbm_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLbm);
            var propertyInfo = this.GetPropertyInfo(PropertyLbm);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (Lbo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_Lbo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLbo);
            var propertyInfo = this.GetPropertyInfo(PropertyLbo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (LogRawNotes) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_LogRawNotes_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogRawNotes);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyLogRawNotes);
            Action currentAction = () => propertyInfo.SetValue(_onyxConfigLBOInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (LogRawNotes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_LogRawNotes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogRawNotes);
            var propertyInfo = this.GetPropertyInfo(PropertyLogRawNotes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (NoNodesToProcess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_NoNodesToProcess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNoNodesToProcess);
            var propertyInfo = this.GetPropertyInfo(PropertyNoNodesToProcess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxConfigLBO) => Property (PreInsertTransform) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxConfigLBO_Public_Class_PreInsertTransform_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPreInsertTransform);
            var propertyInfo = this.GetPropertyInfo(PropertyPreInsertTransform);

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

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var onyxSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.PopulateTargetData(inputVals, onyxSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = _onyxConfigLBOInstance.PopulateTargetData(inputVals, onyxSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodPopulateTargetDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(OnyxSession) };
            object[] parametersOfPopulateTargetData = { inputVals, onyxSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateTargetData, methodPopulateTargetDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_onyxConfigLBOInstanceFixture, parametersOfPopulateTargetData);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodPopulateTargetData, parametersOfPopulateTargetData, methodPopulateTargetDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPopulateTargetData.ShouldNotBeNull();
            parametersOfPopulateTargetData.Length.ShouldBe(2);
            methodPopulateTargetDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodPopulateTargetDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(OnyxSession) };
            object[] parametersOfPopulateTargetData = { inputVals, onyxSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodPopulateTargetData, parametersOfPopulateTargetData, methodPopulateTargetDataParametersTypes);

            // Assert
            parametersOfPopulateTargetData.ShouldNotBeNull();
            parametersOfPopulateTargetData.Length.ShouldBe(2);
            methodPopulateTargetDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var methodPopulateTargetDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPopulateTargetData, methodPopulateTargetDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPopulateTargetDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var methodPopulateTargetDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateTargetData, methodPopulateTargetDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPopulateTargetDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateTargetData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateTargetData) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateTargetData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateTargetData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateTargetData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_Internally(Type[] types)
        {
            var methodPopulateSourceDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPopulateSourceData, methodPopulateSourceDataParametersTypes);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var onyxSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.PopulateSourceData(inputVals, lboList, onyxSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = _onyxConfigLBOInstance.PopulateSourceData(inputVals, lboList, onyxSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodPopulateSourceDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>), typeof(OnyxSession) };
            object[] parametersOfPopulateSourceData = { inputVals, lboList, onyxSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateSourceData, methodPopulateSourceDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_onyxConfigLBOInstanceFixture, parametersOfPopulateSourceData);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodPopulateSourceData, parametersOfPopulateSourceData, methodPopulateSourceDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPopulateSourceData.ShouldNotBeNull();
            parametersOfPopulateSourceData.Length.ShouldBe(3);
            methodPopulateSourceDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var onyxSession = this.CreateType<OnyxSession>();
            var methodPopulateSourceDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>), typeof(OnyxSession) };
            object[] parametersOfPopulateSourceData = { inputVals, lboList, onyxSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodPopulateSourceData, parametersOfPopulateSourceData, methodPopulateSourceDataParametersTypes);

            // Assert
            parametersOfPopulateSourceData.ShouldNotBeNull();
            parametersOfPopulateSourceData.Length.ShouldBe(3);
            methodPopulateSourceDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var methodPopulateSourceDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPopulateSourceData, methodPopulateSourceDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPopulateSourceDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var methodPopulateSourceDataParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>), typeof(OnyxSession) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPopulateSourceData, methodPopulateSourceDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPopulateSourceDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateSourceData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PopulateSourceData) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_PopulateSourceData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPopulateSourceData);
            var currentMethodInfo = this.GetMethodInfo(MethodPopulateSourceData, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_Internally(Type[] types)
        {
            var methodExecuteLBMParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.ExecuteLBM(oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(OnyxOTMResponse);

            // Act
            Action executeAction = () => returnedValue = _onyxConfigLBOInstance.ExecuteLBM(oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfExecuteLBM = { oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, methodExecuteLBMParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxOTMResponse>(_onyxConfigLBOInstanceFixture, parametersOfExecuteLBM);
            var result2 = this.GetResultOfMethod<OnyxOTMResponse>(MethodExecuteLBM, parametersOfExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLBM.ShouldNotBeNull();
            parametersOfExecuteLBM.Length.ShouldBe(1);
            methodExecuteLBMParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfExecuteLBM = { oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxOTMResponse>(MethodExecuteLBM, parametersOfExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            parametersOfExecuteLBM.ShouldNotBeNull();
            parametersOfExecuteLBM.Length.ShouldBe(1);
            methodExecuteLBMParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLBMParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLBMParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodExecuteLBMParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var sLBO = this.CreateType<string>();
            var sLBM = this.CreateType<string>();
            var sInputXml = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxConfigLBO.ExecuteLBM(oSession, sLBO, sLBM, sInputXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var sLBO = this.CreateType<string>();
            var sLBM = this.CreateType<string>();
            var sInputXml = this.CreateType<string>();
            var returnedValue = default(OnyxOTMResponse);

            // Act
            Action executeAction = () => returnedValue = OnyxConfigLBO.ExecuteLBM(oSession, sLBO, sLBM, sInputXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var sLBO = this.CreateType<string>();
            var sLBM = this.CreateType<string>();
            var sInputXml = this.CreateType<string>();
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfExecuteLBM = { oSession, sLBO, sLBM, sInputXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, methodExecuteLBMParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxOTMResponse>(MethodExecuteLBM, parametersOfExecuteLBM, methodExecuteLBMParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_onyxConfigLBOInstanceFixture, parametersOfExecuteLBM);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLBM.ShouldNotBeNull();
            parametersOfExecuteLBM.Length.ShouldBe(4);
            methodExecuteLBMParametersTypes.Length.ShouldBe(4);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var oSession = this.CreateType<OnyxSession>();
            var sLBO = this.CreateType<string>();
            var sLBM = this.CreateType<string>();
            var sInputXml = this.CreateType<string>();
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(String) };
            object[] parametersOfExecuteLBM = { oSession, sLBO, sLBM, sInputXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxOTMResponse>(MethodExecuteLBM, parametersOfExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            parametersOfExecuteLBM.ShouldNotBeNull();
            parametersOfExecuteLBM.Length.ShouldBe(4);
            methodExecuteLBMParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLBMParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var methodExecuteLBMParametersTypes = new Type[] { typeof(OnyxSession), typeof(String), typeof(String), typeof(String) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLBM, methodExecuteLBMParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLBMParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBM) (Return Type : OnyxOTMResponse) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ExecuteLBM_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBM);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBM, 1);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_Internally(Type[] types)
        {
            var methodProcessPreInputMethodsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodProcessPreInputMethods, methodProcessPreInputMethodsParametersTypes);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.ProcessPreInputMethods(oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var oSession = this.CreateType<OnyxSession>();
            var methodProcessPreInputMethodsParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfProcessPreInputMethods = { oSession };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcessPreInputMethods, methodProcessPreInputMethodsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxConfigLBOInstanceFixture, parametersOfProcessPreInputMethods);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcessPreInputMethods.ShouldNotBeNull();
            parametersOfProcessPreInputMethods.Length.ShouldBe(1);
            methodProcessPreInputMethodsParametersTypes.Length.ShouldBe(1);
            methodProcessPreInputMethodsParametersTypes.Length.ShouldBe(parametersOfProcessPreInputMethods.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var oSession = this.CreateType<OnyxSession>();
            var methodProcessPreInputMethodsParametersTypes = new Type[] { typeof(OnyxSession) };
            object[] parametersOfProcessPreInputMethods = { oSession };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcessPreInputMethods, parametersOfProcessPreInputMethods, methodProcessPreInputMethodsParametersTypes);

            // Assert
            parametersOfProcessPreInputMethods.ShouldNotBeNull();
            parametersOfProcessPreInputMethods.Length.ShouldBe(1);
            methodProcessPreInputMethodsParametersTypes.Length.ShouldBe(1);
            methodProcessPreInputMethodsParametersTypes.Length.ShouldBe(parametersOfProcessPreInputMethods.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessPreInputMethods, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var methodProcessPreInputMethodsParametersTypes = new Type[] { typeof(OnyxSession) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcessPreInputMethods, methodProcessPreInputMethodsParametersTypes);

            // Assert
            methodProcessPreInputMethodsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessPreInputMethods) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_ProcessPreInputMethods_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessPreInputMethods);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessPreInputMethods, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_Internally(Type[] types)
        {
            var methodGetConfigNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConfigNodeValue, methodGetConfigNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var configNode = this.CreateType<XmlNode>();
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.GetConfigNodeValue(configNode, inputVals, lboList);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var configNode = this.CreateType<XmlNode>();
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxConfigLBOInstance.GetConfigNodeValue(configNode, inputVals, lboList);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var configNode = this.CreateType<XmlNode>();
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var methodGetConfigNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>) };
            object[] parametersOfGetConfigNodeValue = { configNode, inputVals, lboList };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigNodeValue, methodGetConfigNodeValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxConfigLBOInstanceFixture, parametersOfGetConfigNodeValue);
            var result2 = this.GetResultOfMethod<String>(MethodGetConfigNodeValue, parametersOfGetConfigNodeValue, methodGetConfigNodeValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetConfigNodeValue.ShouldNotBeNull();
            parametersOfGetConfigNodeValue.Length.ShouldBe(3);
            methodGetConfigNodeValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var configNode = this.CreateType<XmlNode>();
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var lboList = this.CreateType<Dictionary<String, VisitedConfigLBO>>();
            var methodGetConfigNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>) };
            object[] parametersOfGetConfigNodeValue = { configNode, inputVals, lboList };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetConfigNodeValue, parametersOfGetConfigNodeValue, methodGetConfigNodeValueParametersTypes);

            // Assert
            parametersOfGetConfigNodeValue.ShouldNotBeNull();
            parametersOfGetConfigNodeValue.Length.ShouldBe(3);
            methodGetConfigNodeValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var methodGetConfigNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConfigNodeValue, methodGetConfigNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConfigNodeValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var methodGetConfigNodeValueParametersTypes = new Type[] { typeof(XmlNode), typeof(Dictionary<String, String>), typeof(Dictionary<String, VisitedConfigLBO>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConfigNodeValue, methodGetConfigNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConfigNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfigNodeValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_GetConfigNodeValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigNodeValue, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_Call_Internally(Type[] types)
        {
            var methodFormatInputForNonUSAddressesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatInputForNonUSAddresses, methodFormatInputForNonUSAddressesParametersTypes);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatInputForNonUSAddresses);

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.FormatInputForNonUSAddresses();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatInputForNonUSAddresses);
            Type [] methodFormatInputForNonUSAddressesParametersTypes = null;
            object[] parametersOfFormatInputForNonUSAddresses = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatInputForNonUSAddresses, methodFormatInputForNonUSAddressesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxConfigLBOInstanceFixture, parametersOfFormatInputForNonUSAddresses);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatInputForNonUSAddresses.ShouldBeNull();
            methodFormatInputForNonUSAddressesParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatInputForNonUSAddresses);
            Type [] methodFormatInputForNonUSAddressesParametersTypes = null;
            object[] parametersOfFormatInputForNonUSAddresses = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFormatInputForNonUSAddresses, parametersOfFormatInputForNonUSAddresses, methodFormatInputForNonUSAddressesParametersTypes);

            // Assert
            parametersOfFormatInputForNonUSAddresses.ShouldBeNull();
            methodFormatInputForNonUSAddressesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatInputForNonUSAddresses);
            Type [] methodFormatInputForNonUSAddressesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatInputForNonUSAddresses, methodFormatInputForNonUSAddressesParametersTypes);

            // Assert
            methodFormatInputForNonUSAddressesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatInputForNonUSAddresses) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatInputForNonUSAddresses_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatInputForNonUSAddresses);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatInputForNonUSAddresses, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_Call_Internally(Type[] types)
        {
            var methodFormatForPrimaryPhoneParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFormatForPrimaryPhone, methodFormatForPrimaryPhoneParametersTypes);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatForPrimaryPhone);

            // Act
            Action executeAction = () => _onyxConfigLBOInstance.FormatForPrimaryPhone();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatForPrimaryPhone);
            Type [] methodFormatForPrimaryPhoneParametersTypes = null;
            object[] parametersOfFormatForPrimaryPhone = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFormatForPrimaryPhone, methodFormatForPrimaryPhoneParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxConfigLBOInstanceFixture, parametersOfFormatForPrimaryPhone);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFormatForPrimaryPhone.ShouldBeNull();
            methodFormatForPrimaryPhoneParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatForPrimaryPhone);
            Type [] methodFormatForPrimaryPhoneParametersTypes = null;
            object[] parametersOfFormatForPrimaryPhone = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFormatForPrimaryPhone, parametersOfFormatForPrimaryPhone, methodFormatForPrimaryPhoneParametersTypes);

            // Assert
            parametersOfFormatForPrimaryPhone.ShouldBeNull();
            methodFormatForPrimaryPhoneParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatForPrimaryPhone);
            Type [] methodFormatForPrimaryPhoneParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFormatForPrimaryPhone, methodFormatForPrimaryPhoneParametersTypes);

            // Assert
            methodFormatForPrimaryPhoneParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FormatForPrimaryPhone) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_FormatForPrimaryPhone_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFormatForPrimaryPhone);
            var currentMethodInfo = this.GetMethodInfo(MethodFormatForPrimaryPhone, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_Internally(Type[] types)
        {
            var methodgetValueFromInputParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetValueFromInput, methodgetValueFromInputParametersTypes);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var attrDict = this.CreateType<Dictionary<String, String>>();
            var methodgetValueFromInputParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, String>) };
            object[] parametersOfgetValueFromInput = { inputVals, attrDict };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetValueFromInput, methodgetValueFromInputParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxConfigLBOInstanceFixture, parametersOfgetValueFromInput);
            var result2 = this.GetResultOfMethod<String>(MethodgetValueFromInput, parametersOfgetValueFromInput, methodgetValueFromInputParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetValueFromInput.ShouldNotBeNull();
            parametersOfgetValueFromInput.Length.ShouldBe(2);
            methodgetValueFromInputParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var inputVals = this.CreateType<Dictionary<String, String>>();
            var attrDict = this.CreateType<Dictionary<String, String>>();
            var methodgetValueFromInputParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, String>) };
            object[] parametersOfgetValueFromInput = { inputVals, attrDict };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodgetValueFromInput, parametersOfgetValueFromInput, methodgetValueFromInputParametersTypes);

            // Assert
            parametersOfgetValueFromInput.ShouldNotBeNull();
            parametersOfgetValueFromInput.Length.ShouldBe(2);
            methodgetValueFromInputParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var methodgetValueFromInputParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetValueFromInput, methodgetValueFromInputParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetValueFromInputParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var methodgetValueFromInputParametersTypes = new Type[] { typeof(Dictionary<String, String>), typeof(Dictionary<String, String>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetValueFromInput, methodgetValueFromInputParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetValueFromInputParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var currentMethodInfo = this.GetMethodInfo(MethodgetValueFromInput, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getValueFromInput) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_getValueFromInput_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetValueFromInput);
            var currentMethodInfo = this.GetMethodInfo(MethodgetValueFromInput, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxConfigLBO_transformDataValue_Method_Call_Internally(Type[] types)
        {
            var methodtransformDataValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodtransformDataValue, methodtransformDataValueParametersTypes);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var tList = this.CreateType<String[]>();
            var cfgNodeValue = this.CreateType<string>();
            var methodtransformDataValueParametersTypes = new Type[] { typeof(String[]), typeof(String) };
            object[] parametersOftransformDataValue = { tList, cfgNodeValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodtransformDataValue, methodtransformDataValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxConfigLBOInstanceFixture, parametersOftransformDataValue);
            var result2 = this.GetResultOfMethod<String>(MethodtransformDataValue, parametersOftransformDataValue, methodtransformDataValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOftransformDataValue.ShouldNotBeNull();
            parametersOftransformDataValue.Length.ShouldBe(2);
            methodtransformDataValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var tList = this.CreateType<String[]>();
            var cfgNodeValue = this.CreateType<string>();
            var methodtransformDataValueParametersTypes = new Type[] { typeof(String[]), typeof(String) };
            object[] parametersOftransformDataValue = { tList, cfgNodeValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodtransformDataValue, parametersOftransformDataValue, methodtransformDataValueParametersTypes);

            // Assert
            parametersOftransformDataValue.ShouldNotBeNull();
            parametersOftransformDataValue.Length.ShouldBe(2);
            methodtransformDataValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var methodtransformDataValueParametersTypes = new Type[] { typeof(String[]), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodtransformDataValue, methodtransformDataValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodtransformDataValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var methodtransformDataValueParametersTypes = new Type[] { typeof(String[]), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodtransformDataValue, methodtransformDataValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodtransformDataValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var currentMethodInfo = this.GetMethodInfo(MethodtransformDataValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (transformDataValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxConfigLBO_transformDataValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodtransformDataValue);
            var currentMethodInfo = this.GetMethodInfo(MethodtransformDataValue, 0);
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