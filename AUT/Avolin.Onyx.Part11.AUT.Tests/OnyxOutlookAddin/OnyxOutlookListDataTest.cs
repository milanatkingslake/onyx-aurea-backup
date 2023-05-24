using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxOutlookListData" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookListDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookListData" />)
        /// </summary>
        public OnyxOutlookListDataTest() : base(typeof(OnyxOutlookListData))
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

        #region General Initializer : Class (OnyxOutlookListData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookListDataInstanceType;
        private OnyxOutlookListData _onyxOutlookListDataInstance;
        private OnyxOutlookListData _onyxOutlookListDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookListData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookListDataInstanceType = typeof(OnyxOutlookListData);
            _onyxOutlookListDataInstanceFixture = this.Create<OnyxOutlookListData>(false);
            _onyxOutlookListDataInstance = _onyxOutlookListDataInstanceFixture ?? this.Create<OnyxOutlookListData>(true);
            CurrentInstance = _onyxOutlookListDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListData) Initializer

        #region Properties

        private const string PropertyObjectId = "ObjectId";
        private const string PropertyHeader = "Header";
        private const string PropertyObjectEnum = "ObjectEnum";
        private const string PropertyOEPLauncherObjectType = "OEPLauncherObjectType";
        private const string PropertyHyperLinkHeader = "HyperLinkHeader";
        private const string PropertyDetails = "Details";

        #endregion

        #region Fields

        private const string FieldoutlookListData = "outlookListData";
        private const string Fielddetails = "details";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookListData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookListData)

        #region General Initializer : Class (OnyxOutlookListData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectId)]
        [TestCase(PropertyHeader)]
        [TestCase(PropertyObjectEnum)]
        [TestCase(PropertyOEPLauncherObjectType)]
        [TestCase(PropertyHyperLinkHeader)]
        [TestCase(PropertyDetails)]
        [Category("AUT Property")]
        public void AUT_OnyxOutlookListData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOutlookListData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldoutlookListData)]
        [TestCase(Fielddetails)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookListData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookListData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookListData_Is_Instance_Present_Test()
        {
            // Assert
            _onyxOutlookListDataInstanceType.ShouldNotBeNull();
            _onyxOutlookListDataInstance.ShouldNotBeNull();
            _onyxOutlookListDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxOutlookListData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookListData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookListDataInstance.ShouldBeAssignableTo<OnyxOutlookListData>();
            _onyxOutlookListDataInstanceFixture.ShouldBeAssignableTo<OnyxOutlookListData>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookListData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxOutlookListData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOutlookListData_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var listData = this.CreateType<XElement>();
            OnyxOutlookListData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOutlookListData(listData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOutlookListDataInstance.ShouldNotBeNull();
            _onyxOutlookListDataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxOutlookListData>();
        }

        #endregion

        #region General Constructor : Class (OnyxOutlookListData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOutlookListData_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var listData = this.CreateType<XElement>();
            OnyxOutlookListData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOutlookListData(listData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOutlookListDataInstance.ShouldNotBeNull();
            _onyxOutlookListDataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOutlookListData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectId)]
        [TestCase(PropertyHeader)]
        [TestCase(PropertyObjectEnum)]
        [TestCase(PropertyOEPLauncherObjectType)]
        [TestCase(PropertyHyperLinkHeader)]
        [TestCase(PropertyDetails)]
        public void AUT_OnyxOutlookListData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (Details) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_Details_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetails);
            var propertyInfo = this.GetPropertyInfo(PropertyDetails);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (Header) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Header_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeader);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyHeader);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookListDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (Header) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_Header_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeader);
            var propertyInfo = this.GetPropertyInfo(PropertyHeader);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (HyperLinkHeader) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_HyperLinkHeader_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHyperLinkHeader);
            var propertyInfo = this.GetPropertyInfo(PropertyHyperLinkHeader);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (ObjectEnum) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_ObjectEnum_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectEnum);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectEnum);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookListDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (ObjectEnum) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_ObjectEnum_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectEnum);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectEnum);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (ObjectId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_ObjectId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectId);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookListDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (ObjectId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_ObjectId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectId);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (OEPLauncherObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_OEPLauncherObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOEPLauncherObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOEPLauncherObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookListDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListData) => Property (OEPLauncherObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListData_Public_Class_OEPLauncherObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}