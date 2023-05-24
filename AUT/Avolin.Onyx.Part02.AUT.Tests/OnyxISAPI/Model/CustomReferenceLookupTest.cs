using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.CustomReferenceLookup" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomReferenceLookupTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomReferenceLookup" />)
        /// </summary>
        public CustomReferenceLookupTest() : base(typeof(CustomReferenceLookup))
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

        #region General Initializer : Class (CustomReferenceLookup) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customReferenceLookupInstanceType;
        private CustomReferenceLookup _customReferenceLookupInstance;
        private CustomReferenceLookup _customReferenceLookupInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomReferenceLookup" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customReferenceLookupInstanceType = typeof(CustomReferenceLookup);
            _customReferenceLookupInstanceFixture = this.Create<CustomReferenceLookup>(false);
            _customReferenceLookupInstance = _customReferenceLookupInstanceFixture ?? this.Create<CustomReferenceLookup>(true);
            CurrentInstance = _customReferenceLookupInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomReferenceLookup) Initializer

        #region Properties

        private const string PropertyReferenceId = "ReferenceId";
        private const string PropertyValue = "Value";
        private const string PropertyDescription = "Description";
        private const string PropertyReferenceName = "ReferenceName";
        private const string PropertyLBOParameter = "LBOParameter";
        private const string PropertyObjectName = "ObjectName";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyParentId = "ParentId";

        #endregion

        #endregion

        #region General Initializer : Class (CustomReferenceLookup) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomReferenceLookup_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomReferenceLookup) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomReferenceLookup_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomReferenceLookup) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomReferenceLookup_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomReferenceLookup)

        #region General Initializer : Class (CustomReferenceLookup) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyLBOParameter)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyParentId)]
        [Category("AUT Property")]
        public void AUT_CustomReferenceLookup_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CustomReferenceLookup) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomReferenceLookup_Is_Instance_Present_Test()
        {
            // Assert
            _customReferenceLookupInstanceType.ShouldNotBeNull();
            _customReferenceLookupInstance.ShouldNotBeNull();
            _customReferenceLookupInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomReferenceLookup) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomReferenceLookup" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomReferenceLookup_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customReferenceLookupInstance.ShouldBeAssignableTo<CustomReferenceLookup>();
            _customReferenceLookupInstanceFixture.ShouldBeAssignableTo<CustomReferenceLookup>();
            CurrentInstance.ShouldBeAssignableTo<CustomReferenceLookup>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CustomReferenceLookup) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CustomReferenceLookup_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CustomReferenceLookup instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CustomReferenceLookup) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyReferenceName)]
        [TestCase(PropertyLBOParameter)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyParentId)]
        public void AUT_CustomReferenceLookup_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (LBOParameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_LBOParameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLBOParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyLBOParameter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (ObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_ObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (ParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_ParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyParentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (ReferenceId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_ReferenceId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceId);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (ReferenceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_ReferenceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceName);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomReferenceLookup) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomReferenceLookup_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValue);
            var propertyInfo = this.GetPropertyInfo(PropertyValue);

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