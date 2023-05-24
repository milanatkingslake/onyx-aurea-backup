using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultFilterProfile" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultFilterProfileTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultFilterProfile" />)
        /// </summary>
        public ResultFilterProfileTest() : base(typeof(ResultFilterProfile))
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

        #region General Initializer : Class (ResultFilterProfile) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultFilterProfileInstanceType;
        private ResultFilterProfile _resultFilterProfileInstance;
        private ResultFilterProfile _resultFilterProfileInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultFilterProfile" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultFilterProfileInstanceType = typeof(ResultFilterProfile);
            _resultFilterProfileInstanceFixture = this.Create<ResultFilterProfile>(false);
            _resultFilterProfileInstance = _resultFilterProfileInstanceFixture ?? this.Create<ResultFilterProfile>(true);
            CurrentInstance = _resultFilterProfileInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultFilterProfile) Initializer

        #region Properties

        private const string PropertyFieldId = "FieldId";
        private const string PropertynodeId = "nodeId";
        private const string PropertyPosition = "Position";
        private const string Propertytext = "text";
        private const string PropertyType = "Type";
        private const string PropertyParent = "Parent";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyControlType = "ControlType";
        private const string PropertyProfile = "Profile";
        private const string PropertySortOrder = "SortOrder";
        private const string PropertyIsTransaction = "IsTransaction";
        private const string PropertyLinkedProperty = "LinkedProperty";
        private const string PropertyPrimaryLinkedFieldName = "PrimaryLinkedFieldName";
        private const string PropertySecondaryLinkedFieldName = "SecondaryLinkedFieldName";
        private const string PropertyFieldState = "FieldState";
        private const string PropertySortIndex = "SortIndex";
        private const string Propertyexpanded = "expanded";
        private const string Propertyexpandable = "expandable";
        private const string Propertychildren = "children";

        #endregion

        #region Fields

        private const string Field_children = "_children";

        #endregion

        #endregion

        #region General Initializer : Class (ResultFilterProfile) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultFilterProfile_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultFilterProfile) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultFilterProfile_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultFilterProfile) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultFilterProfile_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultFilterProfile)

        #region General Initializer : Class (ResultFilterProfile) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertynodeId)]
        [TestCase(PropertyPosition)]
        [TestCase(Propertytext)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyProfile)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyIsTransaction)]
        [TestCase(PropertyLinkedProperty)]
        [TestCase(PropertyPrimaryLinkedFieldName)]
        [TestCase(PropertySecondaryLinkedFieldName)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertySortIndex)]
        [TestCase(Propertyexpanded)]
        [TestCase(Propertyexpandable)]
        [TestCase(Propertychildren)]
        [Category("AUT Property")]
        public void AUT_ResultFilterProfile_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ResultFilterProfile) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_children)]
        [Category("AUT Fields")]
        public void AUT_ResultFilterProfile_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResultFilterProfile) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultFilterProfile_Is_Instance_Present_Test()
        {
            // Assert
            _resultFilterProfileInstanceType.ShouldNotBeNull();
            _resultFilterProfileInstance.ShouldNotBeNull();
            _resultFilterProfileInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultFilterProfile) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultFilterProfile" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultFilterProfile_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultFilterProfileInstance.ShouldBeAssignableTo<ResultFilterProfile>();
            _resultFilterProfileInstanceFixture.ShouldBeAssignableTo<ResultFilterProfile>();
            CurrentInstance.ShouldBeAssignableTo<ResultFilterProfile>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultFilterProfile) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultFilterProfile_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultFilterProfile instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResultFilterProfile) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertynodeId)]
        [TestCase(PropertyPosition)]
        [TestCase(Propertytext)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyProfile)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyIsTransaction)]
        [TestCase(PropertyLinkedProperty)]
        [TestCase(PropertyPrimaryLinkedFieldName)]
        [TestCase(PropertySecondaryLinkedFieldName)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertySortIndex)]
        [TestCase(Propertyexpanded)]
        [TestCase(Propertyexpandable)]
        [TestCase(Propertychildren)]
        public void AUT_ResultFilterProfile_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (children) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_children_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertychildren);
            var propertyInfo = this.GetPropertyInfo(Propertychildren);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (ControlType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_ControlType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyControlType);
            var propertyInfo = this.GetPropertyInfo(PropertyControlType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (expandable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_expandable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyexpandable);
            var propertyInfo = this.GetPropertyInfo(Propertyexpandable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (expanded) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_expanded_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyexpanded);
            var propertyInfo = this.GetPropertyInfo(Propertyexpanded);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (FieldId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_FieldId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldId);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (FieldState) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_FieldState_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldState);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldState);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (IsTransaction) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_IsTransaction_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsTransaction);
            var propertyInfo = this.GetPropertyInfo(PropertyIsTransaction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (LinkedProperty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_LinkedProperty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLinkedProperty);
            var propertyInfo = this.GetPropertyInfo(PropertyLinkedProperty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (nodeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_nodeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynodeId);
            var propertyInfo = this.GetPropertyInfo(PropertynodeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (Parent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_Parent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParent);
            var propertyInfo = this.GetPropertyInfo(PropertyParent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (Position) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_Position_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPosition);
            var propertyInfo = this.GetPropertyInfo(PropertyPosition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (PrimaryLinkedFieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_PrimaryLinkedFieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLinkedFieldName);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLinkedFieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (Profile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_Profile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProfile);
            var propertyInfo = this.GetPropertyInfo(PropertyProfile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (SecondaryLinkedFieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_SecondaryLinkedFieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySecondaryLinkedFieldName);
            var propertyInfo = this.GetPropertyInfo(PropertySecondaryLinkedFieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequenceIndex);
            var propertyInfo = this.GetPropertyInfo(PropertySequenceIndex);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (SortIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_SortIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortIndex);
            var propertyInfo = this.GetPropertyInfo(PropertySortIndex);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (SortOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_SortOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortOrder);
            var propertyInfo = this.GetPropertyInfo(PropertySortOrder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytext);
            var propertyInfo = this.GetPropertyInfo(Propertytext);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultFilterProfile) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultFilterProfile_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

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