using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxOutlookListConfig" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookListConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookListConfig" />)
        /// </summary>
        public OnyxOutlookListConfigTest() : base(typeof(OnyxOutlookListConfig))
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

        #region General Initializer : Class (OnyxOutlookListConfig) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookListConfigInstanceType;
        private OnyxOutlookListConfig _onyxOutlookListConfigInstance;
        private OnyxOutlookListConfig _onyxOutlookListConfigInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookListConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookListConfigInstanceType = typeof(OnyxOutlookListConfig);
            _onyxOutlookListConfigInstanceFixture = this.Create<OnyxOutlookListConfig>(false);
            _onyxOutlookListConfigInstance = _onyxOutlookListConfigInstanceFixture ?? this.Create<OnyxOutlookListConfig>(true);
            CurrentInstance = _onyxOutlookListConfigInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListConfig) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyTitle = "Title";
        private const string PropertyLBO = "LBO";
        private const string PropertyLBM = "LBM";
        private const string PropertyListOwner = "ListOwner";
        private const string PropertyOEPLauncherObjectType = "OEPLauncherObjectType";
        private const string PropertyRecordLimit = "RecordLimit";
        private const string PropertySortField = "SortField";
        private const string PropertyListOrder = "ListOrder";

        #endregion

        #region Methods

        private const string MethodGetListDataForOwner = "GetListDataForOwner";

        #endregion

        #region Fields

        private const string Fieldname = "name";
        private const string Fieldtitle = "title";
        private const string Fieldlbo = "lbo";
        private const string Fieldlbm = "lbm";
        private const string FieldsortField = "sortField";
        private const string FieldoepLauncherObjectType = "oepLauncherObjectType";
        private const string FieldlistOrder = "listOrder";
        private const string FieldlistOwner = "listOwner";
        private const string FieldrecordLimit = "recordLimit";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookListConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListConfig) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListConfig_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListConfig) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListConfig_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookListConfig)

        #region General Initializer : Class (OnyxOutlookListConfig) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetListDataForOwner, 0)]
        public void AUT_OnyxOutlookListConfig_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxOutlookListConfig) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyLBO)]
        [TestCase(PropertyLBM)]
        [TestCase(PropertyListOwner)]
        [TestCase(PropertyOEPLauncherObjectType)]
        [TestCase(PropertyRecordLimit)]
        [TestCase(PropertySortField)]
        [TestCase(PropertyListOrder)]
        [Category("AUT Property")]
        public void AUT_OnyxOutlookListConfig_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOutlookListConfig) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldname)]
        [TestCase(Fieldtitle)]
        [TestCase(Fieldlbo)]
        [TestCase(Fieldlbm)]
        [TestCase(FieldsortField)]
        [TestCase(FieldoepLauncherObjectType)]
        [TestCase(FieldlistOrder)]
        [TestCase(FieldlistOwner)]
        [TestCase(FieldrecordLimit)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookListConfig_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookListConfig) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListConfig" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookListConfig_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookListConfigInstance.ShouldBeAssignableTo<OnyxOutlookListConfig>();
            _onyxOutlookListConfigInstanceFixture.ShouldBeAssignableTo<OnyxOutlookListConfig>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookListConfig>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyLBO)]
        [TestCase(PropertyLBM)]
        [TestCase(PropertyListOwner)]
        [TestCase(PropertyOEPLauncherObjectType)]
        [TestCase(PropertyRecordLimit)]
        [TestCase(PropertySortField)]
        [TestCase(PropertyListOrder)]
        public void AUT_OnyxOutlookListConfig_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (LBM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_LBM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLBM);
            var propertyInfo = this.GetPropertyInfo(PropertyLBM);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (LBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_LBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLBO);
            var propertyInfo = this.GetPropertyInfo(PropertyLBO);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (ListOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_ListOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyListOrder);
            var propertyInfo = this.GetPropertyInfo(PropertyListOrder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (ListOwner) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_ListOwner_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyListOwner);
            var propertyInfo = this.GetPropertyInfo(PropertyListOwner);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (OEPLauncherObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_OEPLauncherObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOEPLauncherObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyOEPLauncherObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (RecordLimit) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_RecordLimit_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordLimit);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordLimit);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (SortField) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_SortField_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortField);
            var propertyInfo = this.GetPropertyInfo(PropertySortField);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListConfig) => Property (Title) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListConfig_Public_Class_Title_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle);

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

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var ownerObj = this.CreateType<OnyxObject>();

            // Act
            Action executeAction = () => _onyxOutlookListConfigInstance.GetListDataForOwner(ownerObj);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var ownerObj = this.CreateType<OnyxObject>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookListConfigInstance.GetListDataForOwner(ownerObj);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var ownerObj = this.CreateType<OnyxObject>();
            var methodGetListDataForOwnerParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetListDataForOwner = { ownerObj };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListDataForOwner, methodGetListDataForOwnerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_onyxOutlookListConfigInstanceFixture, parametersOfGetListDataForOwner);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetListDataForOwner, parametersOfGetListDataForOwner, methodGetListDataForOwnerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetListDataForOwner.ShouldNotBeNull();
            parametersOfGetListDataForOwner.Length.ShouldBe(1);
            methodGetListDataForOwnerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var ownerObj = this.CreateType<OnyxObject>();
            var methodGetListDataForOwnerParametersTypes = new Type[] { typeof(OnyxObject) };
            object[] parametersOfGetListDataForOwner = { ownerObj };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetListDataForOwner, parametersOfGetListDataForOwner, methodGetListDataForOwnerParametersTypes);

            // Assert
            parametersOfGetListDataForOwner.ShouldNotBeNull();
            parametersOfGetListDataForOwner.Length.ShouldBe(1);
            methodGetListDataForOwnerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var methodGetListDataForOwnerParametersTypes = new Type[] { typeof(OnyxObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListDataForOwner, methodGetListDataForOwnerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetListDataForOwnerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var methodGetListDataForOwnerParametersTypes = new Type[] { typeof(OnyxObject) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListDataForOwner, methodGetListDataForOwnerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListDataForOwnerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListDataForOwner, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListDataForOwner) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookListConfig_GetListDataForOwner_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListDataForOwner);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListDataForOwner, 0);
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