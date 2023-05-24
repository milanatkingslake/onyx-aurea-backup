using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxOutlookListDataDetail" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookListDataDetailTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookListDataDetail" />)
        /// </summary>
        public OnyxOutlookListDataDetailTest() : base(typeof(OnyxOutlookListDataDetail))
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

        #region General Initializer : Class (OnyxOutlookListDataDetail) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookListDataDetailInstanceType;
        private OnyxOutlookListDataDetail _onyxOutlookListDataDetailInstance;
        private OnyxOutlookListDataDetail _onyxOutlookListDataDetailInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookListDataDetail" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookListDataDetailInstanceType = typeof(OnyxOutlookListDataDetail);
            _onyxOutlookListDataDetailInstanceFixture = this.Create<OnyxOutlookListDataDetail>(false);
            _onyxOutlookListDataDetailInstance = _onyxOutlookListDataDetailInstanceFixture ?? this.Create<OnyxOutlookListDataDetail>(true);
            CurrentInstance = _onyxOutlookListDataDetailInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListDataDetail) Initializer

        #region Properties

        private const string PropertyLabel = "Label";
        private const string PropertyValue = "Value";
        private const string PropertyDataType = "DataType";
        private const string PropertyIsHyperLink = "IsHyperLink";

        #endregion

        #region Fields

        private const string Fieldlabel = "label";
        private const string FielddetailValue = "detailValue";
        private const string Fieldtype = "type";
        private const string Fieldhyperlink = "hyperlink";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookListDataDetail) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListDataDetail_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListDataDetail) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListDataDetail_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookListDataDetail) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookListDataDetail_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookListDataDetail)

        #region General Initializer : Class (OnyxOutlookListDataDetail) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyLabel)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyIsHyperLink)]
        [Category("AUT Property")]
        public void AUT_OnyxOutlookListDataDetail_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOutlookListDataDetail) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldlabel)]
        [TestCase(FielddetailValue)]
        [TestCase(Fieldtype)]
        [TestCase(Fieldhyperlink)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookListDataDetail_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookListDataDetail) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookListDataDetail" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookListDataDetail_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookListDataDetailInstance.ShouldBeAssignableTo<OnyxOutlookListDataDetail>();
            _onyxOutlookListDataDetailInstanceFixture.ShouldBeAssignableTo<OnyxOutlookListDataDetail>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookListDataDetail>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOutlookListDataDetail) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyLabel)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyIsHyperLink)]
        public void AUT_OnyxOutlookListDataDetail_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOutlookListDataDetail) => Property (DataType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListDataDetail_Public_Class_DataType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataType);
            var propertyInfo = this.GetPropertyInfo(PropertyDataType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListDataDetail) => Property (IsHyperLink) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListDataDetail_Public_Class_IsHyperLink_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsHyperLink);
            var propertyInfo = this.GetPropertyInfo(PropertyIsHyperLink);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListDataDetail) => Property (Label) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListDataDetail_Public_Class_Label_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookListDataDetail) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookListDataDetail_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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