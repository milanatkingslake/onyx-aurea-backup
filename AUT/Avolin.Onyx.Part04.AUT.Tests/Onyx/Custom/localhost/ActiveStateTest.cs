using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ActiveState" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ActiveStateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ActiveState" />)
        /// </summary>
        public ActiveStateTest() : base(typeof(ActiveState))
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

        #region General Initializer : Class (ActiveState) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _activeStateInstanceType;
        private ActiveState _activeStateInstance;
        private ActiveState _activeStateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ActiveState" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _activeStateInstanceType = typeof(ActiveState);
            _activeStateInstanceFixture = this.Create<ActiveState>(false);
            _activeStateInstance = _activeStateInstanceFixture ?? this.Create<ActiveState>(true);
            CurrentInstance = _activeStateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ActiveState) Initializer

        #region Properties

        private const string PropertyDeliveryExtensionRemoved = "DeliveryExtensionRemoved";
        private const string PropertyDeliveryExtensionRemovedSpecified = "DeliveryExtensionRemovedSpecified";
        private const string PropertySharedDataSourceRemoved = "SharedDataSourceRemoved";
        private const string PropertySharedDataSourceRemovedSpecified = "SharedDataSourceRemovedSpecified";
        private const string PropertyMissingParameterValue = "MissingParameterValue";
        private const string PropertyMissingParameterValueSpecified = "MissingParameterValueSpecified";
        private const string PropertyInvalidParameterValue = "InvalidParameterValue";
        private const string PropertyInvalidParameterValueSpecified = "InvalidParameterValueSpecified";
        private const string PropertyUnknownReportParameter = "UnknownReportParameter";
        private const string PropertyUnknownReportParameterSpecified = "UnknownReportParameterSpecified";

        #endregion

        #region Fields

        private const string FielddeliveryExtensionRemovedField = "deliveryExtensionRemovedField";
        private const string FielddeliveryExtensionRemovedFieldSpecified = "deliveryExtensionRemovedFieldSpecified";
        private const string FieldsharedDataSourceRemovedField = "sharedDataSourceRemovedField";
        private const string FieldsharedDataSourceRemovedFieldSpecified = "sharedDataSourceRemovedFieldSpecified";
        private const string FieldmissingParameterValueField = "missingParameterValueField";
        private const string FieldmissingParameterValueFieldSpecified = "missingParameterValueFieldSpecified";
        private const string FieldinvalidParameterValueField = "invalidParameterValueField";
        private const string FieldinvalidParameterValueFieldSpecified = "invalidParameterValueFieldSpecified";
        private const string FieldunknownReportParameterField = "unknownReportParameterField";
        private const string FieldunknownReportParameterFieldSpecified = "unknownReportParameterFieldSpecified";

        #endregion

        #endregion

        #region General Initializer : Class (ActiveState) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ActiveState" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ActiveState_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActiveState) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ActiveState" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ActiveState_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActiveState) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ActiveState" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ActiveState_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ActiveState)

        #region General Initializer : Class (ActiveState) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ActiveState" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyDeliveryExtensionRemoved)]
        [TestCase(PropertyDeliveryExtensionRemovedSpecified)]
        [TestCase(PropertySharedDataSourceRemoved)]
        [TestCase(PropertySharedDataSourceRemovedSpecified)]
        [TestCase(PropertyMissingParameterValue)]
        [TestCase(PropertyMissingParameterValueSpecified)]
        [TestCase(PropertyInvalidParameterValue)]
        [TestCase(PropertyInvalidParameterValueSpecified)]
        [TestCase(PropertyUnknownReportParameter)]
        [TestCase(PropertyUnknownReportParameterSpecified)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ActiveState_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ActiveState) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ActiveState" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FielddeliveryExtensionRemovedField)]
        [TestCase(FielddeliveryExtensionRemovedFieldSpecified)]
        [TestCase(FieldsharedDataSourceRemovedField)]
        [TestCase(FieldsharedDataSourceRemovedFieldSpecified)]
        [TestCase(FieldmissingParameterValueField)]
        [TestCase(FieldmissingParameterValueFieldSpecified)]
        [TestCase(FieldinvalidParameterValueField)]
        [TestCase(FieldinvalidParameterValueFieldSpecified)]
        [TestCase(FieldunknownReportParameterField)]
        [TestCase(FieldunknownReportParameterFieldSpecified)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ActiveState_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ActiveState) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ActiveState" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ActiveState_Is_Instance_Present_Test()
        {
            // Assert
            _activeStateInstanceType.ShouldNotBeNull();
            _activeStateInstance.ShouldNotBeNull();
            _activeStateInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ActiveState) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ActiveState" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ActiveState_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _activeStateInstance.ShouldBeAssignableTo<ActiveState>();
            _activeStateInstanceFixture.ShouldBeAssignableTo<ActiveState>();
            CurrentInstance.ShouldBeAssignableTo<ActiveState>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ActiveState) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ActiveState_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ActiveState instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ActiveState) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyDeliveryExtensionRemoved)]
        [TestCase(PropertyDeliveryExtensionRemovedSpecified)]
        [TestCase(PropertySharedDataSourceRemoved)]
        [TestCase(PropertySharedDataSourceRemovedSpecified)]
        [TestCase(PropertyMissingParameterValue)]
        [TestCase(PropertyMissingParameterValueSpecified)]
        [TestCase(PropertyInvalidParameterValue)]
        [TestCase(PropertyInvalidParameterValueSpecified)]
        [TestCase(PropertyUnknownReportParameter)]
        [TestCase(PropertyUnknownReportParameterSpecified)]
        public void AUT_ActiveState_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ActiveState) => Property (DeliveryExtensionRemoved) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_DeliveryExtensionRemoved_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeliveryExtensionRemoved);
            var propertyInfo = this.GetPropertyInfo(PropertyDeliveryExtensionRemoved);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (DeliveryExtensionRemovedSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_DeliveryExtensionRemovedSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeliveryExtensionRemovedSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyDeliveryExtensionRemovedSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (InvalidParameterValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_InvalidParameterValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInvalidParameterValue);
            var propertyInfo = this.GetPropertyInfo(PropertyInvalidParameterValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (InvalidParameterValueSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_InvalidParameterValueSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInvalidParameterValueSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyInvalidParameterValueSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (MissingParameterValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_MissingParameterValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMissingParameterValue);
            var propertyInfo = this.GetPropertyInfo(PropertyMissingParameterValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (MissingParameterValueSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_MissingParameterValueSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMissingParameterValueSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyMissingParameterValueSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (SharedDataSourceRemoved) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_SharedDataSourceRemoved_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySharedDataSourceRemoved);
            var propertyInfo = this.GetPropertyInfo(PropertySharedDataSourceRemoved);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (SharedDataSourceRemovedSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_SharedDataSourceRemovedSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySharedDataSourceRemovedSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertySharedDataSourceRemovedSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (UnknownReportParameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_UnknownReportParameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnknownReportParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyUnknownReportParameter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActiveState) => Property (UnknownReportParameterSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ActiveState_Public_Class_UnknownReportParameterSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUnknownReportParameterSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyUnknownReportParameterSpecified);

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