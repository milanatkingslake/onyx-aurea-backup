using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class GetDataDrivenSubscriptionPropertiesCompletedEventArgsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />)
        /// </summary>
        public GetDataDrivenSubscriptionPropertiesCompletedEventArgsTest() : base(typeof(GetDataDrivenSubscriptionPropertiesCompletedEventArgs))
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

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceType;
        private GetDataDrivenSubscriptionPropertiesCompletedEventArgs _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance;
        private GetDataDrivenSubscriptionPropertiesCompletedEventArgs _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceType = typeof(GetDataDrivenSubscriptionPropertiesCompletedEventArgs);
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceFixture = this.Create<GetDataDrivenSubscriptionPropertiesCompletedEventArgs>(false);
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance = _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceFixture ?? this.Create<GetDataDrivenSubscriptionPropertiesCompletedEventArgs>(true);
            CurrentInstance = _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Initializer

        #region Properties

        private const string PropertyResult = "Result";
        private const string PropertyExtensionSettings = "ExtensionSettings";
        private const string PropertyDataRetrievalPlan = "DataRetrievalPlan";
        private const string PropertyDescription = "Description";
        private const string PropertyActive = "Active";
        private const string PropertyStatus = "Status";
        private const string PropertyEventType = "EventType";
        private const string PropertyMatchData = "MatchData";
        private const string PropertyParameters = "Parameters";

        #endregion

        #region Fields

        private const string Fieldresults = "results";

        #endregion

        #endregion

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs)

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyExtensionSettings)]
        [TestCase(PropertyDataRetrievalPlan)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyMatchData)]
        [TestCase(PropertyParameters)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldresults)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Is_Instance_Present_Test()
        {
            // Assert
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceType.ShouldNotBeNull();
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance.ShouldNotBeNull();
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance.ShouldBeAssignableTo<GetDataDrivenSubscriptionPropertiesCompletedEventArgs>();
            _getDataDrivenSubscriptionPropertiesCompletedEventArgsInstanceFixture.ShouldBeAssignableTo<GetDataDrivenSubscriptionPropertiesCompletedEventArgs>();
            CurrentInstance.ShouldBeAssignableTo<GetDataDrivenSubscriptionPropertiesCompletedEventArgs>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyExtensionSettings)]
        [TestCase(PropertyDataRetrievalPlan)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyMatchData)]
        [TestCase(PropertyParameters)]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Active) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Active_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyActive);
            Action currentAction = () => propertyInfo.SetValue(_getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_Active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var propertyInfo = this.GetPropertyInfo(PropertyActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (DataRetrievalPlan) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_DataRetrievalPlan_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataRetrievalPlan);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDataRetrievalPlan);
            Action currentAction = () => propertyInfo.SetValue(_getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (DataRetrievalPlan) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_DataRetrievalPlan_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataRetrievalPlan);
            var propertyInfo = this.GetPropertyInfo(PropertyDataRetrievalPlan);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (EventType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_EventType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventType);
            var propertyInfo = this.GetPropertyInfo(PropertyEventType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (ExtensionSettings) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_ExtensionSettings_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionSettings);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionSettings);
            Action currentAction = () => propertyInfo.SetValue(_getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (ExtensionSettings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_ExtensionSettings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionSettings);
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionSettings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (MatchData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_MatchData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMatchData);
            var propertyInfo = this.GetPropertyInfo(PropertyMatchData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Parameters) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Parameters_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameters);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyParameters);
            Action currentAction = () => propertyInfo.SetValue(_getDataDrivenSubscriptionPropertiesCompletedEventArgsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Parameters) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_Parameters_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameters);
            var propertyInfo = this.GetPropertyInfo(PropertyParameters);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var propertyInfo = this.GetPropertyInfo(PropertyResult);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (GetDataDrivenSubscriptionPropertiesCompletedEventArgs) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_GetDataDrivenSubscriptionPropertiesCompletedEventArgs_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

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